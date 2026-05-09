using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using PropertySurveyService.Data;
using PropertySurveyService.Models;
//using System.Text.Json;
using Newtonsoft.Json;
using Microsoft.EntityFrameworkCore;
namespace PropertySurveyService
{

    public static class EndpointMappings
    {
        public static void MapAPIEndpoints(this IEndpointRouteBuilder app)
        {
            ///////////////////////
            // SENDING FROM PDA , RECEIVING TO PDA
            ////////////////////////////////////////
            app.MapPost("/SendLadderChecks", async (List<LaddersTable> laddersSheets, AppDBContext db) =>
            {
                foreach (var sheet in laddersSheets)
                {
                    if (sheet != null)
                    {
                        sheet.Id = 0;
                        db.LaddersTable.Where(l => l.Guid == sheet.Guid).ExecuteDelete();
                        db.LaddersTable.Add(sheet);
                        await db.SaveChangesAsync();
                    }
                }
                return Results.Ok(new { status = "success" });
            });

            app.MapPost("/SendToolChecks", async (List<ToolsTable> tools, AppDBContext db) =>
            {
                foreach (var check in tools)
                {
                    if (check != null)
                    {
                        check.Id = 0;
                        db.ToolsTable.Where(l => l.Guid == check.Guid).ExecuteDelete();
                        db.ToolsTable.Add(check);
                        await db.SaveChangesAsync();
                    }
                }
                return Results.Ok(new { status = "success" });
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

            app.MapPost("/SendWorkAccidents", async (List<FAccidentTable> accs, AppDBContext db) =>
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

            app.MapPost("/GetSurveyJobs", (GetDataDTO gs, AppDBContext db) =>
            {
                var agent = db.Agent.FirstOrDefault(x => x.Code == gs.AgentCode);

                if (agent == null)
                    return Task.FromResult<IResult>(Results.BadRequest(new { ReasonPhrase = "Agent Code Not Found : " + gs.AgentCode }));

                var surveyJobs = db.Job
                    .Where(x => x.AgentId == agent.Id && x.JobType == 1)
                    .ToList();

                List<JobDTO> send_jobs = new List<JobDTO>();

                foreach (var j in db.Job.Where<Job>(x => x.Agent.Code == gs.AgentCode &&
                                                        x.JobType == 0 && x.Date >= DateTime.Today).ToList<Job>())
                {
                    Customer? c = db.Customer.FirstOrDefault<Customer>(x => x.Id == j.CustomerId);
                    
                    if (c == null)
                        c = new Customer();

                    send_jobs.Add(new JobDTO(j, c));
                }

                return Task.FromResult<IResult>(Results.Ok(send_jobs));
            });

            app.MapPost("/GetImage", (GetDataDTO gs, AppDBContext db) =>
            {
                // check password here
                var agent = db.Agent.FirstOrDefault(x => x.Code == gs.AgentCode);

                if (agent == null)
                    return Results.BadRequest(new { ReasonPhrase = "Agent Code Not Found : " + gs.AgentCode });

                var image = db.Images.FirstOrDefault(img => img.Filename == gs.Filename);
                if (image == null)
                {
                    return Results.NotFound();
                }
                return Results.Ok(new ImageDTO
                {
                    Filename = image.Filename,
                    Data = image.Data
                });
            });

            app.MapPost("/GetFittingJobs", (GetDataDTO gs, AppDBContext db) =>
            {
                var agent = db.Agent.FirstOrDefault(x => x.Code == gs.AgentCode);

                if (agent == null)
                    return Task.FromResult<IResult>(Results.BadRequest(new { ReasonPhrase = "Agent Code Not Found : " + gs.AgentCode }));

                var fittingJobs = db.Job
                    .Where(x => x.AgentId == agent.Id && x.JobType == 1)
                    .ToList();

                var results = new List<PDAJobDTO>();

                foreach (var job in fittingJobs)
                {
                    var customer = db.Customer.FirstOrDefault(x => x.Id == job.CustomerId) ?? new Customer();

                    var header = db.Header
                        .Where(h => h.udi_cont == job.ContractCode)
                        .OrderByDescending(h => h.Id)
                        .FirstOrDefault();

                    if (header == null)
                        continue;
                    header.iRecordType = 1;
                    header.udi_date = job.Date.ToShortDateString();
                    header.fit_diary = job.Date.ToShortDateString();
                    header.bSurvey = true;

                    // Get all images for this header
                    var images = db.Images
                        .Where(img => img.ContractCode == header.udi_cont)
                        .Select(img => img.Filename)
                        .Where(fn => fn != null)
                        .ToList();

                    results.Add(new PDAJobDTO
                    {
                        Job = new JobDTO(job, customer),
                        Head = header,
                        Items = db.ItemTable.Where(f => f.HeaderId == header.Id).ToList(),
                        Panels = db.PanelTable.Where(p => p.HeaderId == header.Id).ToList(),
                        Aluminia = db.AlumTable.Where(a => a.HeaderId == header.Id).ToList(),
                        Bifolds = db.BifoldTable.Where(b => b.HeaderId == header.Id).ToList(),
                        Composites = db.CompositeTable.Where(c => c.HeaderId == header.Id).ToList(),
                        Cons = db.ConsTable.Where(c => c.HeaderId == header.Id).ToList(),
                        Garages = db.GarageTable.Where(g => g.HeaderId == header.Id).ToList(),
                        Glass = db.GlassTable.Where(g => g.HeaderId == header.Id).ToList(),
                        Greens = db.GreenTable.Where(g => g.HeaderId == header.Id).ToList(),
                        Locks = db.LockingTable.Where(l => l.HeaderId == header.Id).ToList(),
                        Timbers = db.TimberTable.Where(t => t.HeaderId == header.Id).ToList(),
                        UPVCs = db.UPVCTable.Where(u => u.HeaderId == header.Id).ToList(),
                        Images = images
                    });
                }

                return Task.FromResult<IResult>(Results.Ok(results));
            });

            app.MapPost("/SendSurveys", async (List<PDAJobDTO> jobs, AppDBContext db) =>
            {
                foreach (var job in jobs)
                {
                    if (job.Head != null)
                    {
                        job.Head.Id = 0; // Ensure a new record is created
                        db.Header.Where(l => l.Guid == job.Head.Guid).ExecuteDelete();
                        db.Header.Add(job.Head);
                        await db.SaveChangesAsync();
                        int headerId = job.Head.Id;

                        void SaveItems<T>(IEnumerable<T> items) where T : class
                        {
                            if (items != null)
                            {
                                foreach (var item in items)
                                {
                                    var prop = item.GetType().GetProperty("HeaderId");
                                    if (prop != null)
                                        prop.SetValue(item, headerId);
                                    db.Add(item);
                                }
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

                        foreach (var item in job.Items) { db.ItemTable.Where(l => l.Guid == item.Guid).ExecuteDelete(); }
                        foreach (var item in job.Panels) { db.PanelTable.Where(l => l.Guid == item.Guid).ExecuteDelete(); }
                        foreach (var item in job.Aluminia) { db.AlumTable.Where(l => l.Guid == item.Guid).ExecuteDelete(); }
                        foreach (var item in job.Bifolds) { db.BifoldTable.Where(l => l.Guid == item.Guid).ExecuteDelete(); }
                        foreach (var item in job.Composites) { db.CompositeTable.Where(l => l.Guid == item.Guid).ExecuteDelete(); }
                        foreach (var item in job.Cons) { db.ConsTable.Where(l => l.Guid == item.Guid).ExecuteDelete(); }
                        foreach (var item in job.Garages) { db.GarageTable.Where(l => l.Guid == item.Guid).ExecuteDelete(); }
                        foreach (var item in job.Glass) { db.GlassTable.Where(l => l.Guid == item.Guid).ExecuteDelete(); }
                        foreach (var item in job.Greens) { db.GreenTable.Where(l => l.Guid == item.Guid).ExecuteDelete(); }
                        foreach (var item in job.Locks) { db.LockingTable.Where(l => l.Guid == item.Guid).ExecuteDelete(); }
                        foreach (var item in job.Timbers) { db.TimberTable.Where(l => l.Guid == item.Guid).ExecuteDelete(); }
                        foreach (var item in job.UPVCs) { db.UPVCTable.Where(l => l.Guid == item.Guid).ExecuteDelete(); }

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

            app.MapPost("/SendFittings", async (List<PDAJobDTO> jobs, AppDBContext db) =>
            {
                foreach (var job in jobs)
                {
                    if (job.Head != null)
                    {
                        job.Head.Id = 0; // Ensure a new record is created
                        db.Header.Add(job.Head);
                        await db.SaveChangesAsync();
                        int headerId = job.Head.Id;

                        await db.SaveChangesAsync();
                    }
                }
                return Results.Ok(new { status = "success" });
            });

            app.MapPost("/SendImage", (ImageDTO imageDTO, AppDBContext db) =>
            {
                OKRecordDTO return_record = new OKRecordDTO();

                PhotoImage image = new PhotoImage();
                image.Filename = imageDTO.Filename;
                image.Data = imageDTO.Data;
                image.DateTime = DateTime.Now;
                image.ContractCode = imageDTO.Filename.Substring(0, 8);

                // Save to database
                db.Add<PhotoImage>(image);
                db.SaveChanges();

                // Save to file system
                try
                {
                    string directoryPath = @"c:\PropertyImages";
                    if (!Directory.Exists(directoryPath))
                    {
                        Directory.CreateDirectory(directoryPath);
                    }
                    string filePath = Path.Combine(directoryPath, imageDTO.Filename);
                    byte[] fileBytes = Convert.FromBase64String(imageDTO.Data); 
                    File.WriteAllBytes(filePath, fileBytes);
                }
                catch (Exception ex)
                {
                    return_record.comments = $"Database Success, File Save Failed: {ex.Message}";
                    return Task.FromResult<IResult>(Results.Ok(return_record));
                }

                return_record.comments = "Success";
                return Task.FromResult<IResult>(Results.Ok(return_record));
            });
        }
    }
}
