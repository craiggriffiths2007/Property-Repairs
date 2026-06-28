using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore;
using PropertySurveyService.Data;
using PropertySurveyService.Models;
using PropertySurveyService.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PropertySurveyService.Controllers
{
    [Authorize]
    public class JobsController : Controller
    {
        private readonly Data.AppDBContext _context;

        public static string GetLocalIPAddress()
        {
            return "";
        }

        public JobsController(Data.AppDBContext context)
        {
            DbInitializer.Initialize(context);
            _context = context;
        }

        // GET: Jobs
        public async Task<IActionResult> Index(int? Id, int? headerId, int? month, int? year, string? view, string? weekStart)
        {
            var now = DateTime.Today;
            string viewMode = view ?? "month";
            int displayYear = year ?? now.Year;
            int displayMonth = month ?? now.Month;

            // Calculate the week start (Monday) for week view
            DateTime weekStartDate;
            if (!string.IsNullOrEmpty(weekStart) && DateTime.TryParse(weekStart, out var parsed))
            {
                weekStartDate = parsed;
            }
            else
            {
                // Default to the Monday of the current week
                int diff = ((int)now.DayOfWeek - 1 + 7) % 7;
                weekStartDate = now.AddDays(-diff);
            }
            DateTime weekEndDate = weekStartDate.AddDays(7);


            var viewModel = new JobIndexViewModel
            {
                Year = displayYear,
                Month = displayMonth,
                ViewMode = viewMode,
                WeekStartDate = weekStartDate
            };

            if (viewMode == "week")
            {
                viewModel.Jobs = await _context.Job
                    .Include(j => j.Customer)
                    .Include(j => j.Agent)
                    .Where(j => j.DiaryDate >= weekStartDate && j.DiaryDate < weekEndDate)
                    .OrderBy(j => j.DiaryDate).ThenBy(j => j.Time)
                    .ToListAsync();
            }
            else if (viewMode == "list")
            {
                viewModel.Jobs = await _context.Job
                    .Include(j => j.Customer)
                    .Include(j => j.Agent)
                    .Where(j => j.DiaryDate.Year == displayYear && j.DiaryDate.Month == displayMonth)
                    .OrderBy(j => j.DiaryDate).ThenBy(j => j.Time)
                    .ToListAsync();
            }
            else
            {
                viewModel.Jobs = await _context.Job
                    .Include(j => j.Customer)
                    .Include(j => j.Agent)
                    .Where(j => j.DiaryDate.Year == displayYear && j.DiaryDate.Month == displayMonth)
                    .OrderBy(j => j.DiaryDate).ThenBy(j => j.Time)
                    .ToListAsync();
            }


            // Always populate Headers with all headers for jobs in view
            if (viewModel.Jobs != null)
            {
                var codes = viewModel.Jobs
                    .Where(j => !string.IsNullOrEmpty(j.ContractCode))
                    .Select(j => j.ContractCode!)
                    .Distinct()
                    .ToList();
                viewModel.Headers = await _context.JobHeader
                    .Where(h => h.ContractCode != null && codes.Contains(h.ContractCode))
                    .ToListAsync();

                var codesWithHeaders = viewModel.Headers
                    .Select(h => h.ContractCode!)
                    .Distinct()
                    .ToList();
                viewModel.ContractCodesWithHeaders = new HashSet<string>(codesWithHeaders);
            }

            /*
            if(headerId!=null)
            {
                ViewData["HeaderID"] = headerId.Value;

                foreach (var n in Enum.GetValues(typeof(enum_item_type)))
                {
                    switch (n)
                    {
                        //case enum_item_type.upvc:
                        //    viewModel.SurveyItems += _context.Header.Where(x => x.ContractCode == _context.Header.FirstOrDefault(j => j.Id == headerId.Value).ContractCode).ToEnumeral();
                        case enum_item_type.panel: foreach (var p in _context.PanelTable.Where(x => x.HeaderId == headerId.Value))
                                                        viewModel.SurveyItems.Append(p.AsSurveyItem());
                                                        break;     
                            //case enum_item_type.glass: return "Glass";
                            //case enum_item_type.alum: return "Aluminium";
                            //case enum_item_type.garage: return "Garage";
                            //case enum_item_type.timber: return "Timber";
                            //case enum_item_type.bifold: return "Bifold";
                            //case enum_item_type.lockin: return "Lock-mech";
                            //case enum_item_type.green: return "Greenhouse";
                    }
                }
            }
            */
            return View(viewModel);
        }

        private void PopulateContractsDropDownList(object selectedContract = null)
        {
            var contractsQuery = _context.Contract
                .Include(c => c.Customer)
                .OrderBy(c => c.ContractCode)
                .Select(c => new { c.Id, DisplayText = c.ContractCode + " - " + (c.Customer != null ? c.Customer.Name : "") });
            ViewBag.ContractId = new SelectList(contractsQuery.AsNoTracking(), "Id", "DisplayText", selectedContract);
        }

        private void PopulateAgentsDropDownList(object selectedAgent = null)
        {
            var agentsQuery = from d in _context.Agent
                                 orderby d.Name
                                 select new { d.Id, DisplayText = d.Code + " - " + d.Name };
            ViewBag.AgentId = new SelectList(agentsQuery.AsNoTracking(), "Id", "DisplayText", selectedAgent);
        }

        private void PopulateJobTypeDropDownList(object? selectedValue = null)
        {
            ViewBag.JobTypes = new SelectList(
                Enum.GetValues<enum_job_type>()
                    .Select(j => new { Value = (int)j, Text = j.ToString() }),
                "Value", "Text", selectedValue);
        }


        // GET: Jobs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Job == null)
            {
                return NotFound();
            }

            var job = await _context.Job
                .Include(j => j.Customer)
                .Include(j => j.Agent)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (job == null)
            {
                return NotFound();
            }

            if (!string.IsNullOrEmpty(job.ContractCode))
            {
                ViewBag.Headers = await _context.JobHeader
                    .Where(h => h.ContractCode == job.ContractCode)
                    .ToListAsync();
            }

            return View(job);
        }


        public async Task<ActionResult> GarageMotor(int? id)
        {
            var job = await _context.Job.FirstOrDefaultAsync(m => m.Id == id);

            return View(job);
        }

        public async Task<ActionResult> SignedMandate(int? id)
        {
            var jobHeader = await _context.JobHeader.FirstOrDefaultAsync(m => m.Id == id);

            string fname = string.Format("{0:00000000}_fandates.jpg", jobHeader.ContractCode);
            
            ViewData["MandateSignature"] = _context.Images.Where(x => x.Filename == fname).FirstOrDefault()?.Data;

            return View(jobHeader);
        }


        // GET: Jobs/Create
        public IActionResult Create()
        {
            Job job = new Job();
            job.DiaryDate = DateTime.Now;
            job.Time = DateTime.Now;
            PopulateContractsDropDownList();
            PopulateAgentsDropDownList();
            PopulateJobTypeDropDownList();
            return View(job);
        }

        // POST: Jobs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,DiaryDate,Time,DamageDesc,Instructions,ContractId,AgentId,JobType,bIncludeSurvey,bRequestRepudiation,InsuranceCompanyName,CauseOfDamage")] Job job)
        {
            if (ModelState.IsValid)
            {
                var contract = await _context.Contract.FindAsync(job.ContractId);
                if (contract != null)
                {
                    job.ContractCode = contract.ContractCode;
                    job.CustomerId = contract.CustomerId;
                    job.CauseOfDamage = contract.CauseOfDamage;
                    job.IncidentDate = contract.IncidentDate;
                    job.Excess = contract.Excess;
                    job.PolicyNumber = contract.PolicyNumber;
                }
                _context.Add(job);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            PopulateContractsDropDownList(job.ContractId);
            PopulateAgentsDropDownList(job.AgentId);
            PopulateJobTypeDropDownList(job.JobType);
            return View(job);
        }

        // GET: Jobs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Job == null)
            {
                return NotFound();
            }

            var job = await _context.Job.AsNoTracking()
                .FirstOrDefaultAsync(m => m.Id == id);
            if (job == null)
            {
                return NotFound();
            }

            PopulateContractsDropDownList(job.ContractId);
            PopulateAgentsDropDownList(job.AgentId);
            PopulateJobTypeDropDownList(job.JobType);

            return View(job);
        }

        // POST: Jobs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,ContractId,DiaryDate,Time,DamageDesc,Instructions,AgentId,JobType,bIncludeSurvey,bRequestRepudiation,InsuranceCompanyName, CauseOfDamage")] Job job)
        {
            if (id != job.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var contract = await _context.Contract.FindAsync(job.ContractId);
                    if (contract != null)
                    {
                        job.ContractCode = contract.ContractCode;
                        job.CustomerId = contract.CustomerId;
                    }
                    _context.Update(job);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!JobExists(job.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            PopulateContractsDropDownList(job.ContractId);
            PopulateAgentsDropDownList(job.AgentId);
            PopulateJobTypeDropDownList(job.JobType);

            return View(job);
        }

        // GET: Jobs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Job == null)
            {
                return NotFound();
            }

            var job = await _context.Job
                .Include(j => j.Customer)
                .Include(j => j.Agent)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (job == null)
            {
                return NotFound();
            }

            return View(job);
        }

        // POST: Jobs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Job == null)
            {
                return Problem("Entity set 'PropertySurveyServiceContext.Job'  is null.");
            }
            var job = await _context.Job.FindAsync(id);
            if (job != null)
            {
                _context.Job.Remove(job);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool JobExists(int id)
        {
            return (_context.Job?.Any(e => e.Id == id)).GetValueOrDefault();
        }

        [HttpGet]
        public async Task<IActionResult> GetContractInformation(int id)
        {
            var contract = await _context.Contract.FindAsync(id);
            if (contract == null)
            {
                return Json(new { damageDescription = "" });
            }
            return Json(new { damageDescription = contract.DamageDescription ?? "", causeOfDamage = contract.CauseOfDamage ?? "", insuranceCompany = contract.InsuranceCompanyName ?? "" });
        }

        [HttpGet]
        public async Task<IActionResult> GetAgentListForJobType(enum_job_type jobType)
        {
            // Filter your agents based on job type
            var agents = (jobType == enum_job_type.Fitting || jobType == enum_job_type.Remedial)
                ? _context.Agent.Where(a => a.Type == agent_type.Fitter || a.Type == agent_type.Satellite)
                : _context.Agent.Where(a => a.Type == agent_type.Surveyor || a.Type == agent_type.Satellite);

            foreach(var agent in agents)
            {
                agent.Name = agent.Code + " - " + agent.Name;
            }
            // Convert to a SelectList (assuming Agent has 'Id' and 'Name' properties)
            var selectList = new SelectList(await agents.ToListAsync(), "Id", "Name");

            return Json(selectList);
        }

    }
}
