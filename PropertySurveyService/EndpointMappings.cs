using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
//using System.Text.Json;
using Newtonsoft.Json;
using PropertySurveyService.Data;

using PropertySurveyService.Models;
using System.Timers;
namespace PropertySurveyService
{

    public static class EndpointMappings
    {
        public static void MapAPIEndpoints(this IEndpointRouteBuilder app)
        {
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
            // SENDING FROM PDA , Getting from database
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

                // image.Data may already be byte[]; if it's stored as base64 string decode it
                byte[] bytes;
                //if (image.Data is byte[] b) bytes = b;
                if (image.Data is string s) bytes = Convert.FromBase64String(s);
                else bytes = Array.Empty<byte>();

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

                        job.Items.ForEach(o => o.Id = 0);
                        job.Panels.ForEach(o => o.Id = 0);
                        job.Aluminia.ForEach(o => o.Id = 0);
                        job.Bifolds.ForEach(o => o.Id = 0);
                        job.Composites.ForEach(o => o.Id = 0);
                        job.Cons.ForEach(o => o.Id = 0);
                        job.Garages.ForEach(o => o.Id = 0);
                        job.Glass.ForEach(o => o.Id = 0);
                        job.Greens.ForEach(o => o.Id = 0);
                        job.Locks.ForEach(o => o.Id = 0);
                        job.Timbers.ForEach(o => o.Id = 0);
                        job.UPVCs.ForEach(o => o.Id = 0);
                        /*
                        foreach (var item in job.Items) { db.Frame.Where(l => l.Guid == item.Guid).ExecuteDelete(); }
                        foreach (var item in job.Panels) { db.Panel.Where(l => l.Guid == item.Guid).ExecuteDelete(); }
                        foreach (var item in job.Aluminia) { db.Aluminium.Where(l => l.Guid == item.Guid).ExecuteDelete(); }
                        foreach (var item in job.Bifolds) { db.Bifolding.Where(l => l.Guid == item.Guid).ExecuteDelete(); }
                        foreach (var item in job.Composites) { db.Composite.Where(l => l.Guid == item.Guid).ExecuteDelete(); }
                        foreach (var item in job.Cons) { db.Conservatory.Where(l => l.Guid == item.Guid).ExecuteDelete(); }
                        foreach (var item in job.Garages) { db.Garage.Where(l => l.Guid == item.Guid).ExecuteDelete(); }
                        foreach (var item in job.Glass) { db.Glass.Where(l => l.Guid == item.Guid).ExecuteDelete(); }
                        foreach (var item in job.Greens) { db.Greenhouse.Where(l => l.Guid == item.Guid).ExecuteDelete(); }
                        foreach (var item in job.Locks) { db.Lockmech.Where(l => l.Guid == item.Guid).ExecuteDelete(); }
                        foreach (var item in job.Timbers) { db.Timber.Where(l => l.Guid == item.Guid).ExecuteDelete(); }
                        foreach (var item in job.UPVCs) { db.UPVC.Where(l => l.Guid == item.Guid).ExecuteDelete(); }
                        */
                        SaveItems(job.Items);
                        SaveItems(job.Panels);
                        SaveItems(job.Aluminia);
                        SaveItems(job.Bifolds);
                        SaveItems(job.Composites);
                        SaveItems(job.Cons);
                        SaveItems(job.Garages);
                        SaveItems(job.Glass);
                        SaveItems(job.Greens);
                        SaveItems(job.Locks);
                        SaveItems(job.Timbers);
                        SaveItems(job.UPVCs);

                        await db.SaveChangesAsync();
                    }
                }
                return Results.Ok(new { status = "success" });
            });

            app.MapPost("/GetJobs", (GetDataDTO gs, AppDBContext db) =>
            {
                var agent = db.Agent.FirstOrDefault(x => x.Code == gs.AgentCode);

                if (agent == null)
                    return Task.FromResult<IResult>(Results.BadRequest(new { ReasonPhrase = "Agent Code Not Found : " + gs.AgentCode }));

                var jobs = db.Job
                    .Where(x => x.AgentId == agent.Id && 
                    (x.DiaryDate == DateTime.Today ||
                      x.DiaryDate == DateTime.Today.AddDays(1)))
                    .Include(x => x.Customer)
                    .Include(x => x.Contract)
                    .ToList();

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
                    jobHeader.Instructions = job.Instructions;
                    jobHeader.JobInstructions = "";
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

                    if (job.JobType > enum_job_type.Survey)
                    {
                        jobHeader.FitInstructions = job.Instructions;
                    }

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
                            Items = db.Frame.Where(f => f.HeaderId == jobHeader.Id).ToList(),
                            Panels = db.Panel.Where(p => p.HeaderId == jobHeader.Id).ToList(),
                            Aluminia = db.Aluminium.Where(a => a.HeaderId == jobHeader.Id).ToList(),
                            Bifolds = db.Bifolding.Where(b => b.HeaderId == jobHeader.Id).ToList(),
                            Composites = db.Composite.Where(c => c.HeaderId == jobHeader.Id).ToList(),
                            Cons = db.Conservatory.Where(c => c.HeaderId == jobHeader.Id).ToList(),
                            Garages = db.Garage.Where(g => g.HeaderId == jobHeader.Id).ToList(),
                            Glass = db.Glass.Where(g => g.HeaderId == jobHeader.Id).ToList(),
                            Greens = db.Greenhouse.Where(g => g.HeaderId == jobHeader.Id).ToList(),
                            Locks = db.Lockmech.Where(l => l.HeaderId == jobHeader.Id).ToList(),
                            Timbers = db.Timber.Where(t => t.HeaderId == jobHeader.Id).ToList(),
                            UPVCs = db.UPVC.Where(u => u.HeaderId == jobHeader.Id).ToList(),
                            Images = images
                        });
                    }
                    else
                    {
                        results.Add(new JobHeaderDTO
                        {
                            Head = jobHeader,
                        });
                    }
                }

                return Task.FromResult<IResult>(Results.Ok(results));
            });


            app.MapPost("/SendImage", async (ImageDTO imageDTO, AppDBContext db) =>
            {
                OKRecordDTO return_record = new OKRecordDTO();

                // Prepare contract code safely
                string contractCode = imageDTO.Filename.Length >= 8 ? imageDTO.Filename.Substring(0, 8) : string.Empty;

                try
                {
                    // If an image with the same filename exists, overwrite it; otherwise add a new record
                    var existing = db.Images.FirstOrDefault(i => i.Filename == imageDTO.Filename);
                    if (existing != null)
                    {
                        existing.Data = imageDTO.Data;
                        existing.DateTime = DateTime.Now;
                        existing.ContractCode = contractCode;
                        db.Update(existing);
                    }
                    else
                    {
                        PhotoImage image = new PhotoImage
                        {
                            Filename = imageDTO.Filename,
                            Data = imageDTO.Data,
                            DateTime = DateTime.Now,
                            ContractCode = contractCode
                        };
                        db.Add(image);
                    }

                    await db.SaveChangesAsync();
                }
                catch (Exception exDb)
                {
                    return_record.comments = $"Database Save Failed: {exDb.Message}";
                    return Results.Ok(return_record);
                }

                // Save to file system (will overwrite existing file with same name)
                try
                {
                    string directoryPath = @"D:\PropertySurveyImages";
                    if (Directory.Exists(directoryPath))
                    {
                        string filePath = Path.Combine(directoryPath, imageDTO.Filename);
                        byte[] fileBytes = Convert.FromBase64String(imageDTO.Data);
                        File.WriteAllBytes(filePath, fileBytes);
                    }
                }
                catch (Exception ex)
                {
                    return_record.comments = $"Database Success, File Save Failed: {ex.Message}";
                    return Results.Ok(return_record);
                }

                return_record.comments = "Success";
                return Results.Ok(return_record);
            });
        }
    }
}
