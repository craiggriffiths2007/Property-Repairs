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
    public class ContractsController : Controller
    {
        private readonly Data.AppDBContext _context;

        public ContractsController(Data.AppDBContext context)
        {
            _context = context;
        }

        // GET: Contracts
        public async Task<IActionResult> Index()
        {
            return _context.Contract != null ?
                        View(await _context.Contract.Include(c => c.Customer).ToListAsync()) :
                        Problem("Entity set 'AppDBContext.Contract'  is null.");
        }

        // GET: Contracts/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Contract == null)
            {
                return NotFound();
            }

            var contract = await _context.Contract
                .Include(c => c.Customer)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (contract == null)
            {
                return NotFound();
            }

            return View(contract);
        }

        // GET: Contracts/Create
        public IActionResult Create()
        {
            PopulateCustomersDropDownList();
            return View();
        }

        // POST: Contracts/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,CustomerId,IncidentAdded,DamageDescription")] Contract contract)
        {
            if (ModelState.IsValid)
            {
                _context.Add(contract);
                await _context.SaveChangesAsync();
                contract.ContractCode = (contract.Id + 500).ToString("00000000");
                _context.Update(contract);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            PopulateCustomersDropDownList(contract.CustomerId);
            return View(contract);
        }

        // GET: Contracts/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Contract == null)
            {
                return NotFound();
            }

            var contract = await _context.Contract.FindAsync(id);
            if (contract == null)
            {
                return NotFound();
            }
            PopulateCustomersDropDownList(contract.CustomerId);
            return View(contract);
        }

        // POST: Contracts/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,ContractCode,CustomerId,IncidentAdded,DamageDescription")] Contract contract)
        {
            if (id != contract.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(contract);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ContractExists(contract.Id))
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
            PopulateCustomersDropDownList(contract.CustomerId);
            return View(contract);
        }

        // GET: Contracts/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Contract == null)
            {
                return NotFound();
            }

            var contract = await _context.Contract
                .Include(c => c.Customer)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (contract == null)
            {
                return NotFound();
            }

            return View(contract);
        }

        // POST: Contracts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Contract == null)
            {
                return Problem("Entity set 'AppDBContext.Contract'  is null.");
            }
            var contract = await _context.Contract.FindAsync(id);
            if (contract != null)
            {
                _context.Contract.Remove(contract);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ContractExists(int id)
        {
            return (_context.Contract?.Any(e => e.Id == id)).GetValueOrDefault();
        }

        private void PopulateCustomersDropDownList(object? selectedCustomer = null)
        {
            var customers = _context.Customer.OrderBy(c => c.Name)
                .Select(c => new { c.CustomerId, c.Name });
            ViewBag.Customers = new SelectList(customers, "CustomerId", "Name", selectedCustomer);
        }
    }
}
