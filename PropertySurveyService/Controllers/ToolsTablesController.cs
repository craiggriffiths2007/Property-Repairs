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
    public class ToolsTablesController : Controller
    {
        private readonly AppDBContext _context;

        public ToolsTablesController(AppDBContext context)
        {
            _context = context;
        }

        // GET: ToolsTables
        public async Task<IActionResult> Index()
        {
            return View(await _context.ToolsTable.ToListAsync());
        }

        // GET: ToolsTables/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var toolsTable = await _context.ToolsTable
                .FirstOrDefaultAsync(m => m.Id == id);
            if (toolsTable == null)
            {
                return NotFound();
            }

            return View(toolsTable);
        }

        // GET: ToolsTables/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ToolsTables/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,files_a,pliers_a,chisels_a,pincers_a,scraper_a,hacksaw_a,crowbar_a,handsaw_a,molegrips_a,sidecutters_a,hammer_a,spiritlevel_a,screwdrivers_a,bolsterchisel_a,setsquare_a,stanleyknife_a,clubhammer_a,tapemeasure_a,slidingbevel_a,glazingshovel_a,pointingtrowel_a,setofallenkeys_a,adjustablespanner_a,augerbits_a,nailpunch_a,puttyknife_a,socketset_a,copingsaw_a,augerbitsjoin_a,nailpunchjoin_a,puttyknifejoin_a,socketsetjoin_a,copingsawjoin_a,rivetgunjoin_a,files_f,pliers_f,chisels_f,pincers_f,scraper_f,hacksaw_f,crowbar_f,handsaw_f,molegrips_f,sidecutters_f,hammer_f,spiritlevel_f,screwdrivers_f,bolsterchisel_f,setsquare_f,stanleyknife_f,clubhammer_f,tapemeasure_f,slidingbevel_f,glazingshovel_f,pointingtrowel_f,setofallenkeys_f,adjustablespanner_f,augerbits_f,nailpunch_f,puttyknife_f,socketset_f,copingsaw_f,augerbitsjoin_f,nailpunchjoin_f,puttyknifejoin_f,socketsetjoin_f,copingsawjoin_f,rivetgunjoin_f,date_done,bComplete,bSent,bSigned,bSigned2,signature_filename,signature_filename2,signature_printed,signature_printed2,registration,branch,CheckID,photo_filename")] ToolsTable toolsTable)
        {
            if (ModelState.IsValid)
            {
                _context.Add(toolsTable);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(toolsTable);
        }

        // GET: ToolsTables/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var toolsTable = await _context.ToolsTable.FindAsync(id);
            if (toolsTable == null)
            {
                return NotFound();
            }
            return View(toolsTable);
        }

        // POST: ToolsTables/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,files_a,pliers_a,chisels_a,pincers_a,scraper_a,hacksaw_a,crowbar_a,handsaw_a,molegrips_a,sidecutters_a,hammer_a,spiritlevel_a,screwdrivers_a,bolsterchisel_a,setsquare_a,stanleyknife_a,clubhammer_a,tapemeasure_a,slidingbevel_a,glazingshovel_a,pointingtrowel_a,setofallenkeys_a,adjustablespanner_a,augerbits_a,nailpunch_a,puttyknife_a,socketset_a,copingsaw_a,augerbitsjoin_a,nailpunchjoin_a,puttyknifejoin_a,socketsetjoin_a,copingsawjoin_a,rivetgunjoin_a,files_f,pliers_f,chisels_f,pincers_f,scraper_f,hacksaw_f,crowbar_f,handsaw_f,molegrips_f,sidecutters_f,hammer_f,spiritlevel_f,screwdrivers_f,bolsterchisel_f,setsquare_f,stanleyknife_f,clubhammer_f,tapemeasure_f,slidingbevel_f,glazingshovel_f,pointingtrowel_f,setofallenkeys_f,adjustablespanner_f,augerbits_f,nailpunch_f,puttyknife_f,socketset_f,copingsaw_f,augerbitsjoin_f,nailpunchjoin_f,puttyknifejoin_f,socketsetjoin_f,copingsawjoin_f,rivetgunjoin_f,date_done,bComplete,bSent,bSigned,bSigned2,signature_filename,signature_filename2,signature_printed,signature_printed2,registration,branch,CheckID,photo_filename")] ToolsTable toolsTable)
        {
            if (id != toolsTable.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(toolsTable);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ToolsTableExists(toolsTable.Id))
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
            return View(toolsTable);
        }

        // GET: ToolsTables/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var toolsTable = await _context.ToolsTable
                .FirstOrDefaultAsync(m => m.Id == id);
            if (toolsTable == null)
            {
                return NotFound();
            }

            return View(toolsTable);
        }

        // POST: ToolsTables/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var toolsTable = await _context.ToolsTable.FindAsync(id);
            if (toolsTable != null)
            {
                _context.ToolsTable.Remove(toolsTable);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ToolsTableExists(int id)
        {
            return _context.ToolsTable.Any(e => e.Id == id);
        }
    }
}
