using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PropertySurveyService.Data;
using PropertySurveyService.Models;

namespace PropertySurveyService.Controllers
{
    public class LaddersTablesController : Controller
    {
        private readonly AppDBContext _context;

        public LaddersTablesController(AppDBContext context)
        {
            _context = context;
        }

        // GET: LaddersTables
        public async Task<IActionResult> Index()
        {
            return View(await _context.LaddersTable.ToListAsync());
        }

        // GET: LaddersTables/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var laddersTable = await _context.LaddersTable
                .FirstOrDefaultAsync(m => m.Id == id);
            if (laddersTable == null)
            {
                return NotFound();
            }

            return View(laddersTable);
        }

        // GET: LaddersTables/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: LaddersTables/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,date_done,branch,ladder_number,registration,fitter_surveyor_name,managers_name,CheckID,in_reasonable_condition,rungs_missing_or_loose,stiles_damaged_or_bent,any_cracks,any_corrosion,rubber_plastic_feet,sharp_or_metal_splinters,rungs_dented,painted_or_decorated,hooks_sit_properly,ladders_been_repaired,comments,bSent,bComplete,bSigned,bSigned2,signature_filename,any_damage,signature_filename_2,ladder_type,total_photos")] LaddersTable laddersTable)
        {
            if (ModelState.IsValid)
            {
                _context.Add(laddersTable);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(laddersTable);
        }

        // GET: LaddersTables/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var laddersTable = await _context.LaddersTable.FindAsync(id);
            if (laddersTable == null)
            {
                return NotFound();
            }
            return View(laddersTable);
        }

        // POST: LaddersTables/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,date_done,branch,ladder_number,registration,fitter_surveyor_name,managers_name,CheckID,in_reasonable_condition,rungs_missing_or_loose,stiles_damaged_or_bent,any_cracks,any_corrosion,rubber_plastic_feet,sharp_or_metal_splinters,rungs_dented,painted_or_decorated,hooks_sit_properly,ladders_been_repaired,comments,bSent,bComplete,bSigned,bSigned2,signature_filename,any_damage,signature_filename_2,ladder_type,total_photos")] LaddersTable laddersTable)
        {
            if (id != laddersTable.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(laddersTable);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LaddersTableExists(laddersTable.Id))
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
            return View(laddersTable);
        }

        // GET: LaddersTables/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var laddersTable = await _context.LaddersTable
                .FirstOrDefaultAsync(m => m.Id == id);
            if (laddersTable == null)
            {
                return NotFound();
            }

            return View(laddersTable);
        }

        // POST: LaddersTables/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var laddersTable = await _context.LaddersTable.FindAsync(id);
            if (laddersTable != null)
            {
                _context.LaddersTable.Remove(laddersTable);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LaddersTableExists(int id)
        {
            return _context.LaddersTable.Any(e => e.Id == id);
        }
    }
}
