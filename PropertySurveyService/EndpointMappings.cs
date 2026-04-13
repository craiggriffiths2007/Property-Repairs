using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using PropertySurveyService.Data;
using PropertySurveyService.Models;

namespace PropertySurveyService
{
    public static class EndpointMappings
    {
        public static void MapAPIEndpoints(this IEndpointRouteBuilder app)
        {
            app.MapPost("/GetSurveyJobs", (GetDataDTO gs, AppDBContext db) =>
            {
                var agent = db.Agent.FirstOrDefault(x => x.AgentCode == gs.AgentCode);

                if (agent == null)
                    return Task.FromResult<IResult>(Results.BadRequest(new { ReasonPhrase = "Agent Code Not Found : " + gs.AgentCode }));

                var surveyJobs = db.Job
                    .Where(x => x.AgentId == agent.AgentId && x.JobType == 1)
                    .ToList();

                List<JobDTO> send_jobs = new List<JobDTO>();

                foreach (var j in db.Job.Where<Job>(x => x.Agent.AgentCode == gs.AgentCode &&
                                                        x.JobType == 0 && x.Date >= DateTime.Today).ToList<Job>())
                {
                    Customer? c = db.Customer.FirstOrDefault<Customer>(x => x.CustomerId == j.CustomerId);
                    
                    if (c == null)
                        c = new Customer();

                    send_jobs.Add(new JobDTO(j, c));
                }

                return Task.FromResult<IResult>(Results.Ok(send_jobs));
            });

            app.MapPost("/GetImage", (GetDataDTO gs, AppDBContext db) =>
            {
                // check password here

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
                var agent = db.Agent.FirstOrDefault(x => x.AgentCode == gs.AgentCode);

                if (agent == null)
                    return Task.FromResult<IResult>(Results.BadRequest(new { ReasonPhrase = "Agent Code Not Found : " + gs.AgentCode }));

                var fittingJobs = db.Job
                    .Where(x => x.AgentId == agent.AgentId && x.JobType == 1)
                    .ToList();

                var results = new List<PDAJobDTO>();

                foreach (var job in fittingJobs)
                {
                    var customer = db.Customer.FirstOrDefault(x => x.CustomerId == job.CustomerId) ?? new Customer();

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

            app.MapPost("/SendSurveyImage", (ImageDTO imageDTO, AppDBContext db) =>
            {
                OKRecordDTO return_record = new OKRecordDTO();

                PhotoImage image = new PhotoImage();
                image.Filename = imageDTO.Filename;
                image.Data = imageDTO.Data;
                image.DateTime = DateTime.Now;
                image.ContractCode = imageDTO.Filename.Substring(0, 8);

                if (db.Images.Where<PhotoImage>(x => x.Filename == image.Filename).Count<PhotoImage>()==0)
                    db.Add<PhotoImage>(image);

                db.SaveChanges();
                return_record.comments = "Success";

                return Task.FromResult<IResult>(Results.Ok(return_record));
            });
        }
    }
}
