using Microsoft.AspNetCore.Authorization;
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

namespace PropertyRepairs.Controllers
{
    [Authorize]
    public class DeliveryVansController : Controller
    {
        private readonly Repo repo;

        public DeliveryVansController(Repo _db)
        {
            repo = _db;
        }

        // GET: DeliveryVans
        public async Task<IActionResult> Index(int page = 1)
        {
            if (repo.Db.DeliveryVans == null)
            {
                return Problem("Entity set 'Repo.Db.DeliveryVans' is null.");
            }
            const int pageSize = 10;
            var totalCount = await repo.Db.DeliveryVans.CountAsync();
            var totalPages = (int)Math.Ceiling(totalCount / (double)pageSize);
            if (page < 1) page = 1;
            if (page > totalPages && totalPages > 0) page = totalPages;

            var items = repo.Db.DeliveryVans
                .OrderBy(d => d.Id)
                .Skip((page - 1) * pageSize)
                .Take(pageSize);

            ViewBag.PageNumber = page;
            ViewBag.TotalPages = totalPages;
            ViewBag.PageSize = pageSize;

            return View(await items.ToListAsync());
        }

        // GET: DeliveryVans/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var viewModel = repo.GetVehicleCheckDetailsViewModel(id.Value, enum_vehicle_type.delivery_van);

            if (viewModel.DeliveryVan == null)
            {
                return NotFound();
            }

            return View(viewModel);
        }

        // GET: DeliveryVans/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: DeliveryVans/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,ats_card,bodywork_check,breakdown_card,clean_external,clean_internal,fan_belt,fire_extinguisher,first_aid_box,fuel_card,horn,jack,jump_leads,keys_for_branches,lights_inducators,oil_water_checked,racks_poles,ratchet_straps,receipt_book,bump_hats,service_due_sticker,spanners_for_rack_removal,spare_oil,coolant_anti_freeze_mix,spare_wheel,tow_ropes,tyre_pressure,van_height_sticker,van_locks,wheel_nut_check_sticker,wheelbrace,windscreen_washer,pda_phone_accident_pack,branch_keys,ats_card_s,bodywork_check_s,breakdown_card_s,clean_external_s,clean_internal_s,fan_belt_s,fire_extinguisher_s,first_aid_box_s,fuel_card_s,horn_s,jack_s,jump_leads_s,keys_for_branches_s,lights_inducators_s,oil_water_checked_s,racks_poles_s,ratchet_straps_s,receipt_book_s,bump_hats_s,service_due_sticker_s,spanners_for_rack_removal_s,spare_oil_s,coolant_anti_freeze_mix_s,spare_wheel_s,tow_ropes_s,tyre_pressure_s,van_height_sticker_s,van_locks_s,wheel_nut_check_sticker_s,wheelbrace_s,windscreen_washer_s,pda_phone_accident_pack_s,branch_keys_s,loading_area_good_condition,reason_loading_area_not_good_condition,spare_s_1,VehicleCheckHeaderId,CheckID,Destination,CheckDoneDate,Registration,Mileage,BranchCode,PDAVersionDate,is_complete,ReasonNotCompleted,bComplete,bSent,pressure_passenger_front,pressure_passenger_rear,pressure_driver_front,pressure_driver_rear,pressure_spare,pressure_passenger_front_s,pressure_passenger_rear_s,pressure_driver_front_s,pressure_driver_rear_s,pressure_spare_s,bPhotosOutsideComplete,bPhotosInsideComplete,bDiagramsComplete,bSignaturesComplete,damage_pass,damage_driver,damage_front,damage_back,photos_front,photos_rear,photos_left,photos_right,bDriverSigned,bCheckedBySigned,driver_printed,checked_printed")] DeliveryVan deliveryVan)
        {
            if (ModelState.IsValid)
            {
                repo.Db.Add(deliveryVan);
                await repo.Db.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(deliveryVan);
        }

        // GET: DeliveryVans/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var deliveryVan = await repo.Db.DeliveryVans.FindAsync(id);
            if (deliveryVan == null)
            {
                return NotFound();
            }
            return View(deliveryVan);
        }

        // POST: DeliveryVans/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,ats_card,bodywork_check,breakdown_card,clean_external,clean_internal,fan_belt,fire_extinguisher,first_aid_box,fuel_card,horn,jack,jump_leads,keys_for_branches,lights_inducators,oil_water_checked,racks_poles,ratchet_straps,receipt_book,bump_hats,service_due_sticker,spanners_for_rack_removal,spare_oil,coolant_anti_freeze_mix,spare_wheel,tow_ropes,tyre_pressure,van_height_sticker,van_locks,wheel_nut_check_sticker,wheelbrace,windscreen_washer,pda_phone_accident_pack,branch_keys,ats_card_s,bodywork_check_s,breakdown_card_s,clean_external_s,clean_internal_s,fan_belt_s,fire_extinguisher_s,first_aid_box_s,fuel_card_s,horn_s,jack_s,jump_leads_s,keys_for_branches_s,lights_inducators_s,oil_water_checked_s,racks_poles_s,ratchet_straps_s,receipt_book_s,bump_hats_s,service_due_sticker_s,spanners_for_rack_removal_s,spare_oil_s,coolant_anti_freeze_mix_s,spare_wheel_s,tow_ropes_s,tyre_pressure_s,van_height_sticker_s,van_locks_s,wheel_nut_check_sticker_s,wheelbrace_s,windscreen_washer_s,pda_phone_accident_pack_s,branch_keys_s,loading_area_good_condition,reason_loading_area_not_good_condition,spare_s_1,VehicleCheckHeaderId,CheckID,Destination,CheckDoneDate,Registration,Mileage,BranchCode,PDAVersionDate,is_complete,ReasonNotCompleted,bComplete,bSent,pressure_passenger_front,pressure_passenger_rear,pressure_driver_front,pressure_driver_rear,pressure_spare,pressure_passenger_front_s,pressure_passenger_rear_s,pressure_driver_front_s,pressure_driver_rear_s,pressure_spare_s,bPhotosOutsideComplete,bPhotosInsideComplete,bDiagramsComplete,bSignaturesComplete,damage_pass,damage_driver,damage_front,damage_back,photos_front,photos_rear,photos_left,photos_right,bDriverSigned,bCheckedBySigned,driver_printed,checked_printed")] DeliveryVan deliveryVan)
        {
            if (id != deliveryVan.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    repo.Db.Update(deliveryVan);
                    await repo.Db.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DeliveryVanExists(deliveryVan.Id))
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
            return View(deliveryVan);
        }

        // GET: DeliveryVans/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var deliveryVan = await repo.Db.DeliveryVans
                .FirstOrDefaultAsync(m => m.Id == id);
            if (deliveryVan == null)
            {
                return NotFound();
            }

            return View(deliveryVan);
        }

        // POST: DeliveryVans/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var deliveryVan = await repo.Db.DeliveryVans.FindAsync(id);
            if (deliveryVan != null)
            {
                repo.Db.DeliveryVans.Remove(deliveryVan);
            }

            await repo.Db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DeliveryVanExists(int id)
        {
            return repo.Db.DeliveryVans.Any(e => e.Id == id);
        }
    }
}
