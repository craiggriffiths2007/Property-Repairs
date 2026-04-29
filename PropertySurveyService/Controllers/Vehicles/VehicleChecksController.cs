using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PropertySurveyService.Data;
using PropertySurveyService.Models;
using PropertySurveyService.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PropertySurveyService.Controllers
{
    public class VehicleChecksController : Controller
    {
        private readonly AppDBContext _context;

        public VehicleChecksController(AppDBContext context)
        {
            _context = context;
        }

        // GET: VehicleChecks
        public async Task<IActionResult> Index()
        {
            return View(await _context.VehicleCheckHeaders.ToListAsync());
        }

        // GET: VehicleChecks/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            var viewModel = new VehicleCheckHeaderIndexViewModel();

            if (id == null)
            {
                return NotFound();
            }

            viewModel.VehicleCheckHeader = await _context.VehicleCheckHeaders
                .FirstOrDefaultAsync(m => m.Id == id);
            if (viewModel.VehicleCheckHeader == null)
            {
                return NotFound();
            }
            else
            {
                List<VehicleCheckVehicle> items = new List<VehicleCheckVehicle>();

                //
                foreach (var n in Enum.GetValues(typeof(enum_vehicle_type)))
                {
                    switch (n)
                    {
                        case enum_vehicle_type.delivery_hgv:
                            foreach (var p in _context.DeliveryHGVs.Where(x => x.VehicleCheckHeaderId == viewModel.VehicleCheckHeader.Id)) items.Add(p.AsVehicleCheckVehicle()); break;
                        case enum_vehicle_type.delivery_van:
                            foreach (var p in _context.DeliveryVans.Where(x => x.VehicleCheckHeaderId == viewModel.VehicleCheckHeader.Id)) items.Add(p.AsVehicleCheckVehicle()); break;
                        case enum_vehicle_type.fitter_van:
                            foreach (var p in _context.FitterVans.Where(x => x.VehicleCheckHeaderId == viewModel.VehicleCheckHeader.Id)) items.Add(p.AsVehicleCheckVehicle()); break;
                        case enum_vehicle_type.sales_car:
                            foreach (var p in _context.SalesCars.Where(x => x.VehicleCheckHeaderId == viewModel.VehicleCheckHeader.Id)) items.Add(p.AsVehicleCheckVehicle()); break;
                    }

                }

                viewModel.VehicleCheckVehicles = items;

                //List<PhotoImage> photoimages = _context.Images.Where(x => x.Filename.Substring(0, 12) == viewModel.Header.udi_cont + "_cAH").ToList();

                //viewModel.VehicleCheckVehicles = photoimages;
            }
            /*
            var parentVehicleCheck = await _context.VehicleCheckHeaders
                    .FirstOrDefaultAsync(j => j.Id == viewModel.VehicleCheckHeader.udi_cont);
            if (parentJob != null)
            {
                ViewBag.ParentJobId = parentJob.Id;
            }
            */
            return View(viewModel);
        }

        // GET: VehicleChecks/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: VehicleChecks/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,CheckWeekDate,BranchCode,CheckID,bComplete,bSent,TotalDeliveryHGVs,TotalDeliveryVans,TotalFitterVans,TotalSalesCars,CompleteDeliveryHGVs,CompleteDeliveryVans,CompleteFitterVans,CompleteSalesCars")] VehicleCheckHeader vehicleCheckHeader)
        {
            if (ModelState.IsValid)
            {
                _context.Add(vehicleCheckHeader);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(vehicleCheckHeader);
        }

        // GET: VehicleChecks/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vehicleCheckHeader = await _context.VehicleCheckHeaders.FindAsync(id);
            if (vehicleCheckHeader == null)
            {
                return NotFound();
            }
            return View(vehicleCheckHeader);
        }

        // POST: VehicleChecks/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,CheckWeekDate,BranchCode,CheckID,bComplete,bSent,TotalDeliveryHGVs,TotalDeliveryVans,TotalFitterVans,TotalSalesCars,CompleteDeliveryHGVs,CompleteDeliveryVans,CompleteFitterVans,CompleteSalesCars")] VehicleCheckHeader vehicleCheckHeader)
        {
            if (id != vehicleCheckHeader.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(vehicleCheckHeader);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!VehicleCheckHeaderExists(vehicleCheckHeader.Id))
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
            return View(vehicleCheckHeader);
        }

        // GET: VehicleChecks/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vehicleCheckHeader = await _context.VehicleCheckHeaders
                .FirstOrDefaultAsync(m => m.Id == id);
            if (vehicleCheckHeader == null)
            {
                return NotFound();
            }

            return View(vehicleCheckHeader);
        }

        // POST: VehicleChecks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var vehicleCheckHeader = await _context.VehicleCheckHeaders.FindAsync(id);
            if (vehicleCheckHeader != null)
            {
                _context.VehicleCheckHeaders.Remove(vehicleCheckHeader);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool VehicleCheckHeaderExists(int id)
        {
            return _context.VehicleCheckHeaders.Any(e => e.Id == id);
        }
    }
}
