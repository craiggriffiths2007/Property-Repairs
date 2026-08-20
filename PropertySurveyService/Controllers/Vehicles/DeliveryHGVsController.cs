using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PropertyRepairs.Data;
using PropertyRepairs.Models;
using PropertyRepairs.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace PropertyRepairs.Controllers
{
    public class DeliveryHGVsController : Controller
    {
        private readonly Repo repo;

        public DeliveryHGVsController(Repo _db)
        {
            repo = _db;
        }

        // GET: DeliveryHGVs
        public async Task<IActionResult> Index(int page = 1)
        {
            if (repo.Db.DeliveryHGVs == null)
            {
                return Problem("Entity set 'Repo.Db.DeliveryHGVs' is null.");
            }
            const int pageSize = 10;
            var totalCount = await repo.Db.DeliveryHGVs.CountAsync();
            var totalPages = (int)Math.Ceiling(totalCount / (double)pageSize);
            if (page < 1) page = 1;
            if (page > totalPages && totalPages > 0) page = totalPages;

            var items = repo.Db.DeliveryHGVs
                .OrderBy(d => d.Id)
                .Skip((page - 1) * pageSize)
                .Take(pageSize);

            ViewBag.PageNumber = page;
            ViewBag.TotalPages = totalPages;
            ViewBag.PageSize = pageSize;

            return View(await items.ToListAsync());
        }

        // GET: DeliveryHGVs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var viewModel = repo.GetVehicleCheckDetailsViewModel(id.Value, enum_vehicle_type.delivery_hgv);

            if (viewModel.DeliveryHGV == null)
            {
                return NotFound();
            }

            return View(viewModel);
        }

        // GET: DeliveryHGVs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: DeliveryHGVs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,national_tyres_card,fmg_support_sticker,fuel_card,clean_external,clean_internal,fan_belt,fire_extinguisher,first_aid_box,horn,oil_and_water_checked,accident_pack,portable_lighting,ad_blue_level_check,racks_and_poles,ratchet_straps,service_due_sticker,no_smoking_sticker,spare_oil,coolant_anti_freez,tyre_pressure,van_height_sticker,van_locks,wheel_nut_check_sticker,windscreen_washer,fuel_oil_leaks,battery_security_condition,tyres_and_wheel_fixing,spray_suppression,steering,security_of_load,mirrors,lights,reflectors,inducators,wipers,washers,horn_comp,excessive_exhaust_smoke,brakes,security_of_body,markers,glass_windscreen,receipt_book,keys_for_branches_sat,pda_phone_accident_pack,trade_invoices,blue_bags,delivery_lists,collection_lists,trade_delivery_notes,report_defects,date_signed,loading_area_good_condition,reason_loading_area_not_good_condition,shell_fuel_card,VehicleCheckHeaderId,CheckID,Destination,CheckDoneDate,Registration,Mileage,BranchCode,PDAVersionDate,is_complete,ReasonNotCompleted,bComplete,bSent,pressure_passenger_front,pressure_passenger_rear,pressure_driver_front,pressure_driver_rear,pressure_spare,pressure_passenger_front_s,pressure_passenger_rear_s,pressure_driver_front_s,pressure_driver_rear_s,pressure_spare_s,bPhotosOutsideComplete,bPhotosInsideComplete,bDiagramsComplete,bSignaturesComplete,damage_pass,damage_driver,damage_front,damage_back,photos_front,photos_rear,photos_left,photos_right,bDriverSigned,bCheckedBySigned,driver_printed,checked_printed")] DeliveryHGV deliveryHGV)
        {
            if (ModelState.IsValid)
            {
                repo.Db.Add(deliveryHGV);
                await repo.Db.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(deliveryHGV);
        }

        // GET: DeliveryHGVs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var deliveryHGV = await repo.Db.DeliveryHGVs.FindAsync(id);
            if (deliveryHGV == null)
            {
                return NotFound();
            }
            return View(deliveryHGV);
        }

        // POST: DeliveryHGVs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,national_tyres_card,fmg_support_sticker,fuel_card,clean_external,clean_internal,fan_belt,fire_extinguisher,first_aid_box,horn,oil_and_water_checked,accident_pack,portable_lighting,ad_blue_level_check,racks_and_poles,ratchet_straps,service_due_sticker,no_smoking_sticker,spare_oil,coolant_anti_freez,tyre_pressure,van_height_sticker,van_locks,wheel_nut_check_sticker,windscreen_washer,fuel_oil_leaks,battery_security_condition,tyres_and_wheel_fixing,spray_suppression,steering,security_of_load,mirrors,lights,reflectors,inducators,wipers,washers,horn_comp,excessive_exhaust_smoke,brakes,security_of_body,markers,glass_windscreen,receipt_book,keys_for_branches_sat,pda_phone_accident_pack,trade_invoices,blue_bags,delivery_lists,collection_lists,trade_delivery_notes,report_defects,date_signed,loading_area_good_condition,reason_loading_area_not_good_condition,shell_fuel_card,VehicleCheckHeaderId,CheckID,Destination,CheckDoneDate,Registration,Mileage,BranchCode,PDAVersionDate,is_complete,ReasonNotCompleted,bComplete,bSent,pressure_passenger_front,pressure_passenger_rear,pressure_driver_front,pressure_driver_rear,pressure_spare,pressure_passenger_front_s,pressure_passenger_rear_s,pressure_driver_front_s,pressure_driver_rear_s,pressure_spare_s,bPhotosOutsideComplete,bPhotosInsideComplete,bDiagramsComplete,bSignaturesComplete,damage_pass,damage_driver,damage_front,damage_back,photos_front,photos_rear,photos_left,photos_right,bDriverSigned,bCheckedBySigned,driver_printed,checked_printed")] DeliveryHGV deliveryHGV)
        {
            if (id != deliveryHGV.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    repo.Db.Update(deliveryHGV);
                    await repo.Db.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DeliveryHGVExists(deliveryHGV.Id))
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
            return View(deliveryHGV);
        }

        // GET: DeliveryHGVs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var deliveryHGV = await repo.Db.DeliveryHGVs
                .FirstOrDefaultAsync(m => m.Id == id);
            if (deliveryHGV == null)
            {
                return NotFound();
            }

            return View(deliveryHGV);
        }

        // POST: DeliveryHGVs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var deliveryHGV = await repo.Db.DeliveryHGVs.FindAsync(id);
            if (deliveryHGV != null)
            {
                repo.Db.DeliveryHGVs.Remove(deliveryHGV);
            }

            await repo.Db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DeliveryHGVExists(int id)
        {
            return repo.Db.DeliveryHGVs.Any(e => e.Id == id);
        }
    }
}
