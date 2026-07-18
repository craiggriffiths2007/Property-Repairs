using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
//using System.Text.Json;
using Newtonsoft.Json;
using PropertySurveyService.Data;
using Microsoft.Extensions.Configuration;

using PropertySurveyService.Models;
using System.Timers;

using System.Collections.Concurrent;


namespace PropertySurveyService
{

    public static class EndpointMappings
    {
        static ConcurrentDictionary<string, object> _uploadLocks = new();

        public static void MapAPIEndpoints(this IEndpointRouteBuilder app)
        {
            var config = app.ServiceProvider.GetRequiredService<IConfiguration>();
            string imageDirectory = config["ImageStoragePath"] ?? @"C:\GlassOpsImages";

            app.MapPost("/AgentLogin", (AgentLoginDTO gs, AppDBContext db) =>
            {
                var agent = db.Agent.FirstOrDefault(x => x.Code == gs.AgentCode);

                if (agent == null) 
                    return Task.FromResult<IResult>(Results.BadRequest(new { ReasonPhrase = "Agent Code Not Found : " + gs.AgentCode }));
                else
                    if(agent.Password != gs.Password)
                        return Task.FromResult<IResult>(Results.BadRequest(new { ReasonPhrase = "Password Incorrect" + gs.AgentCode }));

                AgentLoginDTO send_data = new AgentLoginDTO();
                agent.AuthenticationString = send_data.AuthenticationString;
                agent.LoggedInDateTime = DateTime.Now;

                db.Update(agent);
                db.SaveChanges();

                return Task.FromResult<IResult>(Results.Ok(send_data));
            });
            ///////////////////////
            // Sending From Agents PDA , Getting From Database
            ////////////////////////////////////////
            app.MapPost("/SendLadderChecks", async (List<LadderCheck> laddersSheets, AppDBContext db) =>
            {
                foreach (var sheet in laddersSheets)
                {
                    if (sheet != null)
                    {
                        sheet.Id = 0;
                        db.LadderChecks.Where(l => l.Guid == sheet.Guid).ExecuteDelete();
                        db.LadderChecks.Add(sheet);
                        await db.SaveChangesAsync();
                    }
                }
                return Results.Ok(new { status = "success" });
            });

            app.MapPost("/SendToolChecks", async (List<ToolCheck> tools, AppDBContext db) =>
            {
                foreach (var check in tools)
                {
                    if (check != null)
                    {
                        check.Id = 0;
                        db.ToolChecks.Where(l => l.Guid == check.Guid).ExecuteDelete();
                        db.ToolChecks.Add(check);
                        await db.SaveChangesAsync();
                    }
                }
                return Results.Ok(new { status = "success" });
            });

            app.MapPost("/SendSpotChecks", async (List<SpotCheck> checks, AppDBContext db) =>
            {
                foreach (var check in checks)
                {
                    if (check != null)
                    {
                        check.Id = 0;
                        db.SpotChecks.Where(l => l.Guid == check.Guid).ExecuteDelete();
                        db.SpotChecks.Add(check);
                        await db.SaveChangesAsync();
                    }
                }
                return Results.Ok(new { status = "success" });
            });

            app.MapPost("/GetUpdateContractNotes", (GetDataDTO gs, AppDBContext db) =>
            {
                var agent = db.Agent.FirstOrDefault(x => x.Code == gs.AgentCode);

                if (agent == null)
                    return Task.FromResult<IResult>(Results.BadRequest(new { ReasonPhrase = "Agent Code Not Found : " + gs.AgentCode }));

                var contract = db.Contract
                    .Where(x => x.ContractCode == gs.ContractCode)
                    .FirstOrDefault() ?? new Contract();

                JobContractDTO send_data = new JobContractDTO(contract ?? new Contract(), db.Customer.FirstOrDefault<Customer>(x => x.Id == contract.CustomerId) ?? new Customer());

                if(contract!=null)
                {
                    if(gs.Note.Length > 0)
                    {
                        // add the note
                        ContractNote contractNote = new ContractNote();

                        contractNote.ContractCode = contract.ContractCode;
                        contractNote.DateAdded = DateTime.Now;
                        contractNote.Note = gs.Note;
                        contractNote.AddedBy = "PDA : " + gs.AgentCode;

                        db.Add(contractNote);
                        db.SaveChanges();
                    }

                    send_data.ContractNotes = db.ContractNotes
                    .Where(x => x.ContractCode == gs.ContractCode)
                    .OrderByDescending(x => x.DateAdded)
                    .ToList() ?? new List<ContractNote>();
                }

                return Task.FromResult<IResult>(Results.Ok(send_data));
            });

            app.MapPost("/GetSpotCheckJobInfo", (GetDataDTO gs, AppDBContext db) =>
            {
                var agent = db.Agent.FirstOrDefault(x => x.Code == gs.AgentCode);

                if (agent == null)
                    return Task.FromResult<IResult>(Results.BadRequest(new { ReasonPhrase = "Agent Code Not Found : " + gs.AgentCode }));

                var job = db.Job
                    .Where(x => x.ContractCode == gs.ContractCode && x.DiaryDate == DateTime.Today)
                    .FirstOrDefault()?? new Job();

                JobContractDTO send_data = new JobContractDTO(job ?? new Job(), db.Customer.FirstOrDefault<Customer>(x => x.Id == job.CustomerId) ?? new Customer());

                return Task.FromResult<IResult>(Results.Ok(send_data));
            });

            app.MapPost("/SendMileageSheets", async (List<MileageSheet> milageSheets, AppDBContext db) =>
            {
                foreach (var sheet in milageSheets)
                {
                    if (sheet != null)
                    {
                        sheet.Id = 0;
                        db.MileageSheets.Where(l => l.Guid == sheet.Guid).ExecuteDelete();
                        db.MileageSheets.Add(sheet);
                        await db.SaveChangesAsync();
                    }
                }
                return Results.Ok(new { status = "success" });
            });

            app.MapPost("/SendWorkAccidents", async (List<FAccident> accs, AppDBContext db) =>
            {
                foreach (var acc in accs)
                {
                    if (acc != null)
                    {
                        acc.Id = 0;
                        db.FAccidents.Where(l => l.Guid == acc.Guid).ExecuteDelete();
                        db.FAccidents.Add(acc);
                        await db.SaveChangesAsync();
                    }
                }
                return Results.Ok(new { status = "success" });
            });

            app.MapPost("/SendVehicleAccidents", async (List<AccidentsVehicleDTO> checks, AppDBContext db) =>
            {
                foreach (var check in checks)
                {
                    if (check.Accident != null)
                    {
                        check.Accident.Id = 0;
                        db.VAccidents.Where(l => l.Guid == check.Accident.Guid).ExecuteDelete(); 
                        db.VAccidents.Add(check.Accident);
                        await db.SaveChangesAsync();
                        int headerId = check.Accident.Id;
                        void SaveItems<T>(IEnumerable<T> items) where T : class
                        {
                            if (items != null)
                            {
                                foreach (var item in items)
                                {
                                    var prop = item.GetType().GetProperty("Accident_sheetId");
                                    if (prop != null)
                                        prop.SetValue(item, headerId);
                                    db.Add(item);
                                }
                            }
                        }

                        if (check.Whitnesses != null)
                        {
                            check.Whitnesses.ForEach(o => o.Id = 0);
                            foreach (var whitnesses in check.Whitnesses) { db.Whitnesses.Where(l => l.Guid == whitnesses.Guid).ExecuteDelete(); }
                            SaveItems(check.Whitnesses);
                        }

                        await db.SaveChangesAsync();
                    }
                }
                return Results.Ok(new { status = "success" });
            });




        app.MapPost("/SendVehicleChecks", async (JsonDTO jsonChecks, AppDBContext db) =>
            {
                // Using Newtonsoft just for this one endpoint as System.Text.Json doesn't support TypeNameHandling which is needed for the polymorphic deserialization of the vehicle check items
                JsonSerializerSettings serializerSettings;
                serializerSettings = new JsonSerializerSettings
                {
                    ContractResolver = new Newtonsoft.Json.Serialization.CamelCasePropertyNamesContractResolver(),
                    TypeNameHandling = TypeNameHandling.Auto,
                    Formatting = Formatting.Indented,

                };

                List<VehicleCheckDTO> checks = JsonConvert.DeserializeObject<List<VehicleCheckDTO>>(jsonChecks.json, serializerSettings);

                foreach (var check in checks)
                {
                    if (check.VehicleCheckHeader != null)
                    {
                        check.VehicleCheckHeader.Id = 0;
                        db.VehicleCheckHeaders.Where(l => l.Guid == check.VehicleCheckHeader.Guid).ExecuteDelete();
                        db.VehicleCheckHeaders.Add(check.VehicleCheckHeader);
                        await db.SaveChangesAsync();
                        int headerId = check.VehicleCheckHeader.Id;
                        void SaveItems<T>(IEnumerable<T> items) where T : class
                        {
                            if (items != null)
                            {
                                foreach (var item in items)
                                {
                                    var prop = item.GetType().GetProperty("VehicleCheckHeaderId");
                                    if (prop != null)
                                        prop.SetValue(item, headerId);
                                    db.Add(item);
                                }
                            }
                        }

                        check.DeliveryVans.ForEach(o => o.Id = 0);
                        check.DeliveryHGVs.ForEach(o => o.Id = 0);
                        check.FitterVans.ForEach(o => o.Id = 0);
                        check.SalesCars.ForEach(o => o.Id = 0);

                        foreach (var vehicle in check.DeliveryVans) { db.DeliveryVans.Where(l => l.Guid == vehicle.Guid).ExecuteDelete(); }
                        foreach (var vehicle in check.DeliveryHGVs) { db.DeliveryHGVs.Where(l => l.Guid == vehicle.Guid).ExecuteDelete(); }
                        foreach (var vehicle in check.FitterVans) { db.FitterVans.Where(l => l.Guid == vehicle.Guid).ExecuteDelete(); }
                        foreach (var vehicle in check.SalesCars) { db.SalesCars.Where(l => l.Guid == vehicle.Guid).ExecuteDelete(); }

                        SaveItems(check.DeliveryVans);
                        SaveItems(check.DeliveryHGVs);
                        SaveItems(check.FitterVans);
                        SaveItems(check.SalesCars);

                        await db.SaveChangesAsync();
                    }
                }
                
                return Results.Ok(new { status = "success" });
            });

            app.MapPost("/GetVehicles", (GetDataDTO gs, AppDBContext db) =>
            {
                var agent = db.Agent.FirstOrDefault(x => x.Code == gs.AgentCode);
                var branch = db.Branches.FirstOrDefault(x => x.Code == gs.BranchCode);

                if (agent == null)
                    return Task.FromResult<IResult>(Results.BadRequest(new { ReasonPhrase = "Agent Code Not Found : " + gs.AgentCode }));

                if (branch == null)
                    return Task.FromResult<IResult>(Results.BadRequest(new { ReasonPhrase = "Branch Code Not Found : " + gs.BranchCode }));

                var vehicles = db.Vehicles
                    .Where(x => x.BranchId == branch.Id)
                    .ToList();

                List<VehicleDTO> vehicleDTOs = vehicles.Select(v => new VehicleDTO(v)).ToList();

                return Task.FromResult<IResult>(Results.Ok(vehicleDTOs));
            });


            
            app.MapPost("/GetImage", (GetDataDTO gs, AppDBContext db) =>
            {
                var agent = db.Agent.FirstOrDefault(x => x.Code == gs.AgentCode);
                if (agent == null)
                    return Results.BadRequest(new { ReasonPhrase = "Agent Code Not Found : " + gs.AgentCode });

                var image = db.Images.FirstOrDefault(img => img.Filename == gs.Filename);
                if (image == null)
                    return Results.NotFound();

                byte[] bytes = Array.Empty<byte>();

                // Prefer reading from filesystem at D:\\PropertySurveyImages
                try
                {
                    string directoryPath = imageDirectory;
                    string filePath = Path.Combine(directoryPath, image.Filename);
                    if (File.Exists(filePath))
                    {
                        bytes = File.ReadAllBytes(filePath);
                    }
                    else if (!string.IsNullOrEmpty(image.Data))
                    {
                        // Fallback to database-stored base64 data for legacy records
                        bytes = Convert.FromBase64String(image.Data);
                    }
                    else
                    {
                        return Results.NotFound();
                    }
                }
                catch (Exception)
                {
                    return Results.StatusCode(500);
                }

                var ext = Path.GetExtension(image.Filename)?.ToLowerInvariant();
                var contentType = ext switch
                {
                    ".jpg" or ".jpeg" => "image/jpeg",
                    ".png" => "image/png",
                    ".gif" => "image/gif",
                    ".bmp" => "image/bmp",
                    ".webp" => "image/webp",
                    ".mp4" => "video/mp4",
                    _ => "application/octet-stream"
                };

                return Results.File(bytes, contentType, image.Filename);
            });



            app.MapPost("/SendJobs", async (List<JobHeaderDTO> jobs, AppDBContext db) =>
            {
                foreach (var job in jobs)
                {
                    if (job.Head != null)
                    {
                        job.Head.Id = 0; // Ensure a new record is created
                        db.JobHeader.Where(l => l.Guid == job.Head.Guid).ExecuteDelete();
                        db.JobHeader.Add(job.Head);
                        await db.SaveChangesAsync();
                        int headerId = job.Head.Id;

                        void SaveItems<T>(IEnumerable<T> items) where T : class
                        {
                            if (items == null)
                                return;

                            foreach (var item in items)
                            {
                                var headerProp = item.GetType().GetProperty("HeaderId");
                                if (headerProp != null)
                                    headerProp.SetValue(item, headerId);

                                var guidProp = item.GetType().GetProperty("Guid");
                                if (guidProp != null)
                                {
                                    var guid = (Guid)guidProp.GetValue(item)!;

                                    db.Set<T>()
                                      .Where(e => EF.Property<Guid>(e, "Guid") == guid)
                                      .ExecuteDelete();
                                }

                                db.Add(item);
                            }
                        }

                        job.Material.ForEach(o => o.Id = 0);
                        job.Panel.ForEach(o => o.Id = 0);
                        job.Aluminium.ForEach(o => o.Id = 0);
                        job.Bifolding.ForEach(o => o.Id = 0);
                        job.Composite.ForEach(o => o.Id = 0);
                        job.Conservatory.ForEach(o => o.Id = 0);
                        job.Garage.ForEach(o => o.Id = 0);
                        job.Glass.ForEach(o => o.Id = 0);
                        job.Greenhouse.ForEach(o => o.Id = 0);
                        job.Lockmech.ForEach(o => o.Id = 0);
                        job.Timber.ForEach(o => o.Id = 0);
                        job.UPVC.ForEach(o => o.Id = 0);
                        /*
                        foreach (var item in job.Material) { db.Frame.Where(l => l.Guid == item.Guid).ExecuteDelete(); }
                        foreach (var item in job.Panel) { db.Panel.Where(l => l.Guid == item.Guid).ExecuteDelete(); }
                        foreach (var item in job.Aluminium) { db.Aluminium.Where(l => l.Guid == item.Guid).ExecuteDelete(); }
                        foreach (var item in job.Bifolding) { db.Bifolding.Where(l => l.Guid == item.Guid).ExecuteDelete(); }
                        foreach (var item in job.Composite) { db.Composite.Where(l => l.Guid == item.Guid).ExecuteDelete(); }
                        foreach (var item in job.Conservatory) { db.Conservatory.Where(l => l.Guid == item.Guid).ExecuteDelete(); }
                        foreach (var item in job.Garage) { db.Garage.Where(l => l.Guid == item.Guid).ExecuteDelete(); }
                        foreach (var item in job.Glass) { db.Glass.Where(l => l.Guid == item.Guid).ExecuteDelete(); }
                        foreach (var item in job.Greenhouse) { db.Greenhouse.Where(l => l.Guid == item.Guid).ExecuteDelete(); }
                        foreach (var item in job.Lockmech) { db.Lockmech.Where(l => l.Guid == item.Guid).ExecuteDelete(); }
                        foreach (var item in job.Timber) { db.Timber.Where(l => l.Guid == item.Guid).ExecuteDelete(); }
                        foreach (var item in job.UPVC) { db.UPVC.Where(l => l.Guid == item.Guid).ExecuteDelete(); }
                        */
                        SaveItems(job.Material);
                        SaveItems(job.Panel);
                        SaveItems(job.Aluminium);
                        SaveItems(job.Bifolding);
                        SaveItems(job.Composite);
                        SaveItems(job.Conservatory);
                        SaveItems(job.Garage);
                        SaveItems(job.Glass);
                        SaveItems(job.Greenhouse);
                        SaveItems(job.Lockmech);
                        SaveItems(job.Timber);
                        SaveItems(job.UPVC);

                        await db.SaveChangesAsync();
                    }
                }
                return Results.Ok(new { status = "success" });
            });

            app.MapPost("/GetJobs", (GetDataDTO gs, AppDBContext db) =>
            {
                if (gs.AuthenticationString == "null")
                    return Task.FromResult<IResult>(Results.BadRequest(new { ReasonPhrase = "Not logged in" }));

                var agent = db.Agent.FirstOrDefault(x => x.Code == gs.AgentCode && 
                                                        x.AuthenticationString == gs.AuthenticationString);

                if (agent == null)
                    return Task.FromResult<IResult>(Results.BadRequest(new { ReasonPhrase = "Authentication Failed" }));

                List<Job> jobs = new List<Job>();

                if(gs.AgentCode=="ADMIN")
                {
                    jobs = db.Job
                        .Where(x => x.DiaryDate == DateTime.Today ||
                                    x.DiaryDate == DateTime.Today.AddDays(1))
                        .Include(x => x.Customer)
                        .Include(x => x.Contract)
                        .ToList();
                }
                else
                {
                    jobs = db.Job
                        .Where(x => x.AgentId == agent.Id && 
                        (x.DiaryDate == DateTime.Today ||
                          x.DiaryDate == DateTime.Today.AddDays(1)))
                        .Include(x => x.Customer)
                        .Include(x => x.Contract)
                        .ToList();
                }

                var results = new List<JobHeaderDTO>();

                foreach (var job in jobs)
                {
                    JobHeader jobHeader = new JobHeader();

                    if (job.bIncludeSurvey)
                    {
                        jobHeader = db.JobHeader
                        .Where(h => h.ContractCode == job.ContractCode &&
                                    h.JobType == enum_job_type.Survey)
                         .OrderByDescending(h => h.DateTimeCompleted)

                        .FirstOrDefault() ?? new JobHeader();

                        if (jobHeader.Id > 0) // 
                        {
                            jobHeader.bSurvey = true;
                        }
                    }

                    jobHeader.Guid = Guid.NewGuid();
                    jobHeader.JobType = job.JobType;
                    jobHeader.ContractCode = job.ContractCode;
                    jobHeader.bRequestRepudiation = job.bRequestRepudiation;

                    jobHeader.JobInstructions = job.Instructions;

                    jobHeader.StartTime = job.Time.ToShortTimeString();
                    jobHeader.FinishTime = job.Time.AddHours(1).ToShortTimeString(); // doesnt have a finish time yet
                    jobHeader.DiaryDate = job.DiaryDate;

                    jobHeader.CustomerName = job.Customer.Name;
                    jobHeader.CustomerAddressLine1 = job.Customer.Add1;
                    jobHeader.CustomerAddressLine2 = job.Customer.Add2;
                    jobHeader.CustomerAddressLine3 = job.Customer.Add3;
                    jobHeader.CustomerPostcode = job.Customer.Postcode;
                    jobHeader.CustomerPhoneNumber = job.Customer.Phone1;
                    jobHeader.CustomerPhoneNumber2 = job.Customer.Phone2;
                    jobHeader.CustomerPhoneNumber3 = job.Customer.Phone3;

                    jobHeader.InsuranceCompanyName = job.Contract.InsuranceCompanyName;
                    jobHeader.IncidentDate = job.Contract.IncidentDate.ToShortDateString();
                    jobHeader.CauseOfDamage = job.Contract.CauseOfDamage;
                    jobHeader.PolicyNumber = job.Contract.PolicyNumber;
                    jobHeader.Excess = job.Contract.Excess;
                    jobHeader.DamageDescription = job.Contract.DamageDescription;

                    jobHeader.bComplete = false;
                    jobHeader.bSent = false;

                    var images = new List<string>();

                    if (jobHeader.bSurvey == true)
                    {
                        string pattern = $"{jobHeader.ContractCode:00000000}_______%"; // using _ as a wildcard ( would have been cAZ and dAZ )

                        List<string?> imagesRange = db.Images
                            .Where(x => EF.Functions.Like(x.Filename, pattern)).Select(f => f.Filename)
                            .ToList();

                        foreach (var im in imagesRange)
                        {
                            if (im != null)
                            {
                                images.Add(im);
                            }
                        }
                    }

                    if(false)
                    { // add videos of job
                        string pattern = $"{jobHeader.ContractCode:00000000}_Videos%"; 

                        List<string?> imagesRange = db.Images
                            .Where(x => EF.Functions.Like(x.Filename, pattern)).Select(f => f.Filename)
                            .ToList();

                        foreach (var im in imagesRange)
                        {
                            if (im != null)
                            {
                                images.Add(im);
                            }
                        }
                    }
                    if (job.bIncludeSurvey)
                    {
                        results.Add(new JobHeaderDTO
                        {
                            Head = jobHeader,
                            Material = db.Frame.Where(f => f.HeaderId == jobHeader.Id).ToList(),
                            Panel = db.Panel.Where(p => p.HeaderId == jobHeader.Id).ToList(),
                            Aluminium = db.Aluminium.Where(a => a.HeaderId == jobHeader.Id).ToList(),
                            Bifolding = db.Bifolding.Where(b => b.HeaderId == jobHeader.Id).ToList(),
                            Composite = db.Composite.Where(c => c.HeaderId == jobHeader.Id).ToList(),
                            Conservatory = db.Conservatory.Where(c => c.HeaderId == jobHeader.Id).ToList(),
                            Garage = db.Garage.Where(g => g.HeaderId == jobHeader.Id).ToList(),
                            Glass = db.Glass.Where(g => g.HeaderId == jobHeader.Id).ToList(),
                            Greenhouse = db.Greenhouse.Where(g => g.HeaderId == jobHeader.Id).ToList(),
                            Lockmech = db.Lockmech.Where(l => l.HeaderId == jobHeader.Id).ToList(),
                            Timber = db.Timber.Where(t => t.HeaderId == jobHeader.Id).ToList(),
                            UPVC = db.UPVC.Where(u => u.HeaderId == jobHeader.Id).ToList(),
                            Images = images
                        });
                    }
                    else
                    {
                        results.Add(new JobHeaderDTO
                        {
                            Head = jobHeader,
                            Images = images
                        });
                    }
                }

                return Task.FromResult<IResult>(Results.Ok(results));
            });


            app.MapPost("/SendMedia", async (ImageDTO imageDTO, AppDBContext db) =>
            {
                OKRecordDTO return_record = new OKRecordDTO();
                try
                {
                    // sanitize filename
                    string safeFilename = Path.GetFileName(imageDTO.Filename ?? string.Empty);
                    if (string.IsNullOrWhiteSpace(safeFilename))
                    {
                        return_record.comments = "Invalid filename";
                        return Results.Ok(return_record);
                    }

                    // optional: enforce allowed extensions and max size here
                    var allowed = new[] { ".mp4", ".mov", ".jpg", ".jpeg", ".png" };
                    string ext = Path.GetExtension(safeFilename).ToLowerInvariant();
                    if (!allowed.Contains(ext))
                    {
                        return_record.comments = "File type not allowed";
                        return Results.Ok(return_record);
                    }

                    Directory.CreateDirectory(imageDirectory);
                    string finalPath = Path.Combine(imageDirectory, safeFilename);
                    string tempPath = finalPath + ".part";

                    byte[] chunkBytes = Convert.FromBase64String(imageDTO.Data ?? string.Empty);

                    // If chunk metadata present, handle chunked upload
                    if (imageDTO.ChunkIndex.HasValue && imageDTO.TotalChunks.HasValue)
                    {
                        int chunkIndex = imageDTO.ChunkIndex.Value;
                        int totalChunks = imageDTO.TotalChunks.Value;

                        // lock per-file to avoid race conditions
                        var fileKey = safeFilename;
                        var lockObj = _uploadLocks.GetOrAdd(fileKey, _ => new object());

                        try
                        {
                            lock (lockObj)
                            {
                                // Append chunk (assumes client uploads chunks in order)
                                using (var fs = new FileStream(tempPath, FileMode.OpenOrCreate, FileAccess.Write, FileShare.None))
                                {
                                    fs.Seek(0, SeekOrigin.End);
                                    fs.Write(chunkBytes, 0, chunkBytes.Length);
                                    fs.Flush(true);
                                }

                                // If final chunk, move temp to final and update DB
                                if (chunkIndex == totalChunks)
                                {
                                    if (File.Exists(finalPath))
                                        File.Delete(finalPath);
                                    File.Move(tempPath, finalPath);

                                    // Save metadata to DB (only once after final chunk)
                                    string contractCode = safeFilename.Length >= 8 ? safeFilename.Substring(0, 8) : string.Empty;
                                    var existing = db.Images.FirstOrDefault(i => i.Filename == safeFilename);
                                    if (existing != null)
                                    {
                                        existing.DateTime = DateTime.Now;
                                        existing.ContractCode = contractCode;
                                        existing.Data = string.Empty;
                                        db.Update(existing);
                                    }
                                    else
                                    {
                                        PhotoImage image = new PhotoImage
                                        {
                                            Filename = safeFilename,
                                            Data = string.Empty,
                                            DateTime = DateTime.Now,
                                            ContractCode = contractCode
                                        };
                                        db.Add(image);
                                    }
                                    db.SaveChanges();
                                }
                            } // lock
                        }
                        finally
                        {
                            _uploadLocks.TryRemove(fileKey, out _);
                        }
                    }
                    else
                    {
                        // Non-chunked (backwards compatible): write full file and update DB now
                        byte[] fileBytes = chunkBytes; // whole file
                        await File.WriteAllBytesAsync(finalPath, fileBytes);

                        string contractCode = safeFilename.Length >= 8 ? safeFilename.Substring(0, 8) : string.Empty;
                        var existing = db.Images.FirstOrDefault(i => i.Filename == safeFilename);
                        if (existing != null)
                        {
                            existing.DateTime = DateTime.Now;
                            existing.ContractCode = contractCode;
                            existing.Data = string.Empty;
                            db.Update(existing);
                        }
                        else
                        {
                            PhotoImage image = new PhotoImage
                            {
                                Filename = safeFilename,
                                Data = string.Empty,
                                DateTime = DateTime.Now,
                                ContractCode = contractCode
                            };
                            db.Add(image);
                        }
                        await db.SaveChangesAsync();
                    }

                    return_record.comments = "Success";
                    return Results.Ok(return_record);
                }
                catch (Exception ex)
                {
                    return_record.comments = $"File Save Failed: {ex.Message}";
                    return Results.Ok(return_record);
                }
            });

            // Serve images by filename via GET so <img src="/images/filename"> works
            app.MapGet("/images/{filename}", (string filename) =>
            {
                try
                {
                    string safe = Path.GetFileName(filename);
                    string filePath = Path.Combine(imageDirectory, safe);
                    if (!File.Exists(filePath)) return Results.NotFound();

                    var ext = Path.GetExtension(safe)?.ToLowerInvariant();
                    var contentType = ext switch
                    {
                        ".jpg" or ".jpeg" => "image/jpeg",
                        ".png" => "image/png",
                        ".gif" => "image/gif",
                        ".bmp" => "image/bmp",
                        ".webp" => "image/webp",
                        ".mp4" => "video/mp4",
                        _ => "application/octet-stream"
                    };

                    var bytes = File.ReadAllBytes(filePath);
                    return Results.File(bytes, contentType, safe);
                }
                catch (Exception)
                {
                    return Results.StatusCode(500);
                }
            });

            // Export images stored as base64 in DB to files and clear Data column
            app.MapPost("/ExportImages", async (AppDBContext db) =>
            {
                var imagesWithData = db.Images.Where(i => !string.IsNullOrEmpty(i.Data)).ToList();
                var errors = new List<string>();
                int written = 0;

                Directory.CreateDirectory(imageDirectory);

                foreach (var img in imagesWithData)
                {
                    try
                    {
                        string safe = Path.GetFileName(img.Filename);
                        string filePath = Path.Combine(imageDirectory, safe);
                        byte[] bytes = Convert.FromBase64String(img.Data);
                        await File.WriteAllBytesAsync(filePath, bytes);
                        img.Data = string.Empty;
                        db.Update(img);
                        written++;
                    }
                    catch (Exception ex)
                    {
                        errors.Add($"{img.Filename}: {ex.Message}");
                    }
                }

                await db.SaveChangesAsync();

                return Results.Ok(new { written, errors });
            });
        }
    }
}
