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
    public class SalesCarsController : Controller
    {
        private readonly Repo repo;

        public SalesCarsController(Repo _db)
        {
            repo = _db;
        }

        // GET: SalesCars
        public async Task<IActionResult> Index()
        {
            return View(await repo.Db.SalesCars.ToListAsync());
        }

        // GET: SalesCars/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var viewModel = repo.GetVehicleCheckDetailsViewModel(id.Value, enum_vehicle_type.sales_car);

            if (viewModel.SalesCar == null)
            {
                return NotFound();
            }

            return View(viewModel);
        }

        // GET: SalesCars/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: SalesCars/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,fuel_card,shell_points_card,interior_clean,oil_level,water_level,windscreen_wash,spare_wheel,jack,wheel_brace,tools,tyre_condition,fuel_card_s,shell_points_card_s,interior_clean_s,oil_level_s,water_level_s,windscreen_wash_s,spare_wheel_s,jack_s,wheel_brace_s,tools_s,tyre_condition_s,shell_fuel_card_s,shell_fuel_card,VehicleCheckHeaderId,CheckID,Destination,CheckDoneDate,Registration,Mileage,BranchCode,PDAVersionDate,is_complete,ReasonNotCompleted,bComplete,bSent,pressure_passenger_front,pressure_passenger_rear,pressure_driver_front,pressure_driver_rear,pressure_spare,pressure_passenger_front_s,pressure_passenger_rear_s,pressure_driver_front_s,pressure_driver_rear_s,pressure_spare_s,bPhotosOutsideComplete,bPhotosInsideComplete,bDiagramsComplete,bSignaturesComplete,damage_pass,damage_driver,damage_front,damage_back,photos_front,photos_rear,photos_left,photos_right,bDriverSigned,bCheckedBySigned,driver_printed,checked_printed")] SalesCar salesCar)
        {
            if (ModelState.IsValid)
            {
                repo.Db.Add(salesCar);
                await repo.Db.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(salesCar);
        }

        // GET: SalesCars/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var salesCar = await repo.Db.SalesCars.FindAsync(id);
            if (salesCar == null)
            {
                return NotFound();
            }
            return View(salesCar);
        }

        // POST: SalesCars/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,fuel_card,shell_points_card,interior_clean,oil_level,water_level,windscreen_wash,spare_wheel,jack,wheel_brace,tools,tyre_condition,fuel_card_s,shell_points_card_s,interior_clean_s,oil_level_s,water_level_s,windscreen_wash_s,spare_wheel_s,jack_s,wheel_brace_s,tools_s,tyre_condition_s,shell_fuel_card_s,shell_fuel_card,VehicleCheckHeaderId,CheckID,Destination,CheckDoneDate,Registration,Mileage,BranchCode,PDAVersionDate,is_complete,ReasonNotCompleted,bComplete,bSent,pressure_passenger_front,pressure_passenger_rear,pressure_driver_front,pressure_driver_rear,pressure_spare,pressure_passenger_front_s,pressure_passenger_rear_s,pressure_driver_front_s,pressure_driver_rear_s,pressure_spare_s,bPhotosOutsideComplete,bPhotosInsideComplete,bDiagramsComplete,bSignaturesComplete,damage_pass,damage_driver,damage_front,damage_back,photos_front,photos_rear,photos_left,photos_right,bDriverSigned,bCheckedBySigned,driver_printed,checked_printed")] SalesCar salesCar)
        {
            if (id != salesCar.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    repo.Db.Update(salesCar);
                    await repo.Db.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SalesCarExists(salesCar.Id))
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
            return View(salesCar);
        }

        // GET: SalesCars/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var salesCar = await repo.Db.SalesCars
                .FirstOrDefaultAsync(m => m.Id == id);
            if (salesCar == null)
            {
                return NotFound();
            }

            return View(salesCar);
        }

        // POST: SalesCars/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var salesCar = await repo.Db.SalesCars.FindAsync(id);
            if (salesCar != null)
            {
                repo.Db.SalesCars.Remove(salesCar);
            }

            await repo.Db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SalesCarExists(int id)
        {
            return repo.Db.SalesCars.Any(e => e.Id == id);
        }
    }
}
