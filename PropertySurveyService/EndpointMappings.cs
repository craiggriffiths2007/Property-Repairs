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
                    .Where(x => x.AgentId == agent.Id && (x.DiaryDate == DateTime.Today ||
                                                                            x.DiaryDate == DateTime.Today.AddDays(1)))
                    .Include(x => x.Customer)
                    .Include(x => x.Contract)
                    .ToList();

                var results = new List<JobHeaderDTO>();

                foreach (var job in jobs)
                {
                    JobHeader header = null;

                    if (job.bIncludeSurvey)
                    {
                        header = db.JobHeader
                        .Where(h => h.ContractCode == job.ContractCode && h.JobType == enum_job_type.Survey)
                        .OrderByDescending(h => h.DiaryDate)
                        .FirstOrDefault();
                    }

                    if (header == null)
                    {
                        header = new JobHeader();
                    }
                    else
                    {
                        header.bSurvey = true;
                    }

                    header.Guid = Guid.NewGuid();
                    header.JobType = job.JobType;
                    header.ContractCode = job.ContractCode;
                    header.bRequestRepudiation = job.bRequestRepudiation;
                    header.Instructions = job.Instructions;
                    header.JobInstructions = "";
                    header.StartTime = job.Time.ToShortTimeString();
                    header.FinishTime = job.Time.AddHours(1).ToShortTimeString(); // doesnt have a finish time yet
                    header.DiaryDate = job.DiaryDate;

                    header.ClientName = job.Customer.Name;
                    header.ClientAddressLine1 = job.Customer.Add1;
                    header.ClientAddressLine2 = job.Customer.Add2;
                    header.ClientAddressLine3 = job.Customer.Add3;
                    header.ClientPostcode = job.Customer.Postcode;
                    header.ClientPhoneNumber = job.Customer.Phone1;
                    header.ClientPhoneNumber2 = job.Customer.Phone2;
                    header.ClientPhoneNumber3 = job.Customer.Phone3;

                    header.InsuranceCompanyName = job.Contract.InsuranceCompanyName;
                    header.IncidentDate = job.Contract.IncidentDate.ToShortDateString();
                    header.CauseOfDamage = job.Contract.CauseOfDamage;
                    header.PolicyNumber = job.Contract.PolicyNumber;
                    header.Excess = job.Contract.Excess;
                    header.DamageDescription = job.Contract.DamageDescription;

                    header.bComplete = false;
                    header.bSent = false;

                    if (job.JobType > enum_job_type.Survey)
                    {
                        //header.FitDate = job.DiaryDate.ToShortDateString();
                        //header.FitStartTime = job.Time.ToString(@"hh\:mm");
                        //header.FitFinishTime = job.Time.Add(TimeSpan.FromHours(1)).ToString(@"hh\:mm");
                        header.FitInstructions = job.Instructions;
                        //header.bSurvey = true;
                        //header.bComplete = false;
                        //header.bSent = false;
                    }

                    // Get all the images for this header
                    var images = new List<string>();
                    
                    /*
                    List<SurveyItem> items = new List<SurveyItem>();

                    foreach (var n in Enum.GetValues(typeof(enum_item_type)))
                    {
                        switch (n)
                        {
                            case enum_item_type.upvc:
                                foreach (var p in db.UPVC.Where(x => x.HeaderId == header.Id)) items.Add(p.AsSurveyItem()); break;
                            case enum_item_type.panel:
                                foreach (var p in db.Panel.Where(x => x.HeaderId == header.Id)) items.Add(p.AsSurveyItem()); break;
                            case enum_item_type.glass:
                                foreach (var p in db.Glass.Where(x => x.HeaderId == header.Id)) items.Add(p.AsSurveyItem()); break;
                            case enum_item_type.alum:
                                foreach (var p in db.Aluminium.Where(x => x.HeaderId == header.Id)) items.Add(p.AsSurveyItem()); break;
                            case enum_item_type.garage:
                                foreach (var p in db.Garage.Where(x => x.HeaderId == header.Id)) items.Add(p.AsSurveyItem()); break;
                            case enum_item_type.timber:
                                foreach (var p in db.Timber.Where(x => x.HeaderId == header.Id)) items.Add(p.AsSurveyItem()); break;
                            case enum_item_type.bifold:
                                foreach (var p in db.Bifolding.Where(x => x.HeaderId == header.Id)) items.Add(p.AsSurveyItem()); break;
                            case enum_item_type.lockin:
                                foreach (var p in db.Lockmech.Where(x => x.HeaderId == header.Id)) items.Add(p.AsSurveyItem()); break;
                            case enum_item_type.green:
                                foreach (var p in db.Greenhouse.Where(x => x.HeaderId == header.Id)) items.Add(p.AsSurveyItem()); break;
                            case enum_item_type.comp:
                                foreach (var p in db.Composite.Where(x => x.HeaderId == header.Id)) items.Add(p.AsSurveyItem()); break;
                            case enum_item_type.cons:
                                foreach (var p in db.Conservatory.Where(x => x.HeaderId == header.Id)) items.Add(p.AsSurveyItem()); break;
                            case enum_item_type.frame:
                                foreach (var p in db.Frame.Where(x => x.HeaderId == header.Id)) items.Add(p.AsSurveyItem()); break;
                        }
                    }
                    */ // get all the images

                    var photoimages = new List<string>();

                    if (job.bIncludeSurvey)
                    {
                        string pattern = $"{header.ContractCode:00000000}_______%"; // using _ as a wildcard ( would have been cAZ and dAZ )

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
                        string pattern = $"{header.ContractCode:00000000}_Videos%"; // using _ as a wildcard ( would have been cAZ and dAZ )

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
                            Head = header,
                            Items = db.Frame.Where(f => f.HeaderId == header.Id).ToList(),
                            Panels = db.Panel.Where(p => p.HeaderId == header.Id).ToList(),
                            Aluminia = db.Aluminium.Where(a => a.HeaderId == header.Id).ToList(),
                            Bifolds = db.Bifolding.Where(b => b.HeaderId == header.Id).ToList(),
                            Composites = db.Composite.Where(c => c.HeaderId == header.Id).ToList(),
                            Cons = db.Conservatory.Where(c => c.HeaderId == header.Id).ToList(),
                            Garages = db.Garage.Where(g => g.HeaderId == header.Id).ToList(),
                            Glass = db.Glass.Where(g => g.HeaderId == header.Id).ToList(),
                            Greens = db.Greenhouse.Where(g => g.HeaderId == header.Id).ToList(),
                            Locks = db.Lockmech.Where(l => l.HeaderId == header.Id).ToList(),
                            Timbers = db.Timber.Where(t => t.HeaderId == header.Id).ToList(),
                            UPVCs = db.UPVC.Where(u => u.HeaderId == header.Id).ToList(),
                            Images = images
                        });
                    }
                    else
                    {
                        results.Add(new JobHeaderDTO
                        {
                            Head = header,
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
