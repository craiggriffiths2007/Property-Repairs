using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PropertySurveyService.Data;
using PropertySurveyService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PropertySurveyService.Controllers
{
    [Authorize]
    public class FAccidentsController : Controller
    {
        private readonly AppDBContext _context;

        public FAccidentsController(AppDBContext context)
        {
            _context = context;
        }

        // GET: FAccidents
        public async Task<IActionResult> Index()
        {
            return View(await _context.FAccidents.ToListAsync());
        }

        // GET: FAccidents/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var fAccidents = await _context.FAccidents
                .FirstOrDefaultAsync(m => m.Id == id);
            if (fAccidents == null)
            {
                return NotFound();
            }

            ViewData["sig_fname1"] = _context.Images.Where(x => x.Filename == fAccidents.sig_fname1).FirstOrDefault()?.Data;
            ViewData["sig_fname2"] = _context.Images.Where(x => x.Filename == fAccidents.sig_fname2).FirstOrDefault()?.Data;

            string pattern = $"{fAccidents.CheckID}_FAcci___.jpg"; 

            var photoimages = _context.Images
                .Where(x => EF.Functions.Like(x.Filename, pattern))
                .ToList();

            ViewBag.Images = photoimages ?? new List<PhotoImage>();

            return View(fAccidents);
        }

        // GET: FAccidents/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: FAccidents/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,date_time,bSent,bComplete,full_name,add1,add2,add3,pcode,occupation,filer_full_name,filer_add1,filer_add2,filer_add3,filer_pcode,filer_occupation,sign_date,filer_sign_date,date_happened,time_happened,how_did_accident_happen,materials_used_in_treatment,person_signed,supervisor_signed,num_of_photographs,sig_fname1,sig_fname2,GUID,injuries,where_happ_acc,Type,what_happened,where_abouts,anon_or_name")] FAccident fAccidents)
        {
            if (ModelState.IsValid)
            {
                _context.Add(fAccidents);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(fAccidents);
        }

        // GET: FAccidents/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var fAccidents = await _context.FAccidents.FindAsync(id);
            if (fAccidents == null)
            {
                return NotFound();
            }
            return View(fAccidents);
        }

        // POST: FAccidents/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,date_time,bSent,bComplete,full_name,add1,add2,add3,pcode,occupation,filer_full_name,filer_add1,filer_add2,filer_add3,filer_pcode,filer_occupation,sign_date,filer_sign_date,date_happened,time_happened,how_did_accident_happen,materials_used_in_treatment,person_signed,supervisor_signed,num_of_photographs,sig_fname1,sig_fname2,GUID,injuries,where_happ_acc,Type,what_happened,where_abouts,anon_or_name")] FAccident fAccidents)
        {
            if (id != fAccidents.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(fAccidents);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FAccidentsExists(fAccidents.Id))
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
            return View(fAccidents);
        }

        // GET: FAccidents/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var fAccidents = await _context.FAccidents
                .FirstOrDefaultAsync(m => m.Id == id);
            if (fAccidents == null)
            {
                return NotFound();
            }

            return View(fAccidents);
        }

        // POST: FAccidents/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var fAccidents = await _context.FAccidents.FindAsync(id);
            if (fAccidents != null)
            {
                _context.FAccidents.Remove(fAccidents);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FAccidentsExists(int id)
        {
            return _context.FAccidents.Any(e => e.Id == id);
        }
    }
}
