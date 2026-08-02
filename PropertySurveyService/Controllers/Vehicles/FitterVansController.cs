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
    public class FitterVansController : Controller
    {
        private readonly Repo repo;

        public FitterVansController(Repo _db)
        {
            repo = _db;
        }

        // GET: FitterVans
        public async Task<IActionResult> Index(int page = 1)
        {
            if (repo.Db.FitterVans == null)
            {
                return Problem("Entity set 'Repo.Db.FitterVans' is null.");
            }
            const int pageSize = 10;
            var totalCount = await repo.Db.FitterVans.CountAsync();
            var totalPages = (int)Math.Ceiling(totalCount / (double)pageSize);
            if (page < 1) page = 1;
            if (page > totalPages && totalPages > 0) page = totalPages;

            var items = repo.Db.FitterVans
                .OrderBy(f => f.Id)
                .Skip((page - 1) * pageSize)
                .Take(pageSize);

            ViewBag.PageNumber = page;
            ViewBag.TotalPages = totalPages;
            ViewBag.PageSize = pageSize;

            return View(await items.ToListAsync());
        }

        // GET: FitterVans/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var viewModel = repo.GetVehicleCheckDetailsViewModel(id.Value, enum_vehicle_type.fitter_van);

            if (viewModel.FitterVan == null)
            {
                return NotFound();
            }

            return View(viewModel);
        }

        // GET: FitterVans/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: FitterVans/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,circuit_breaker,power_breaker,hammer_drill,ordinary_drill,cordless_drill,spare_battery_and_charger,circular_saw,jig_saw,planer_check_blade,heat_gun,sander,hoover,halogen_lamp,extension_lead,router,industrial_ladders,ladder_clamps,step_ladders,ladder_stopper,philips_bit,screw_box,tresles_x2,torch_working,ratchett_straps_x4,spare_wheel,blue_external_dust_sheet,internal_dust_sheets_x3,brush_and_shovel,cleaner_bottle,ecloth,mastic_guns,glass_suckers,safety_helmets,helmet_manufacture_date,gloves,wrist_guards,goggles,ear_defenders,dust_masks,customer_care_cards,completion_forms,freepost_envelopes,mandate_forms,quality_manuals,stapler,worksheets,plasters,dressing,eyewashers,steri_wipes,bag,flexi_meter,merlin_low_e_detector,cabin_condition,national_tyres_card,breakdown_card,fuel_card,shell_points_card,fire_extinguisher,jack,wheelbrace,jump_leads,fan_belt,tow_ropes,spare_oil,coolant_anti_freeze,van_height_sticker,wheel_nut_check_sticker,no_smoking_sticker,racks_and_poles,tyre_conditions,van_locks,oil_and_water_checked,hows_my_driving_sticker,pda_setup_date,accident_pack_on_pda,hi_vis_vests,grinder,windscreen_good_contidion,circuit_breaker_s,power_breaker_s,hammer_drill_s,ordinary_drill_s,cordless_drill_s,spare_battery_and_charger_s,circular_saw_s,jig_saw_s,planer_check_blade_s,heat_gun_s,sander_s,hoover_s,halogen_lamp_s,extension_lead_s,router_s,industrial_ladders_s,ladder_clamps_s,step_ladders_s,ladder_stopper_s,philips_bit_s,screw_box_s,tresles_x2_s,torch_working_s,ratchett_straps_x4_s,spare_wheel_s,blue_external_dust_sheet_s,internal_dust_sheets_x3_s,brush_and_shovel_s,cleaner_bottle_s,ecloth_s,mastic_guns_s,glass_suckers_s,safety_helmets_s,helmet_manufacture_date_s,gloves_s,wrist_guards_s,goggles_s,ear_defenders_s,dust_masks_s,customer_care_cards_s,completion_forms_s,freepost_envelopes_s,mandate_forms_s,quality_manuals_s,stapler_s,worksheets_s,plasters_s,dressing_s,eyewashers_s,steri_wipes_s,bag_s,flexi_meter_s,merlin_low_e_detector_s,cabin_condition_s,national_tyres_card_s,breakdown_card_s,fuel_card_s,shell_points_card_s,fire_extinguisher_s,jack_s,wheelbrace_s,jump_leads_s,fan_belt_s,tow_ropes_s,spare_oil_s,coolant_anti_freeze_s,van_height_sticker_s,wheel_nut_check_sticker_s,no_smoking_sticker_s,racks_and_poles_s,tyre_conditions_s,van_locks_s,oil_and_water_checked_s,hows_my_driving_sticker_s,pda_setup_date_s,accident_pack_on_pda_s,hi_vis_vests_s,grinder_s,windscreen_good_contidion_s,fitters_own_power_tools_ladders_on_van,marks_out_of_10,vehicle_reg,spare_s_1,spare_s_2,spare_s_3,spare_s_4,spare_i_1,spare_i_2,spare_i_3,spare_i_4,ManufactureDateOnHelmet,ManufactureDateOnHelmet2,ManufactureDateOnHelmet3,ManufactureDateOnHelmet4,ManufactureDateOnHelmet5,ManufactureDateOnHelmet6,ManufactureDateOnHelmet7,ManufactureDateOnHelmet8,ManufactureDateOnHelmet9,ManufactureDateOnHelmet10,letterbox_jig,VehicleCheckHeaderId,CheckID,Destination,CheckDoneDate,Registration,Mileage,BranchCode,PDAVersionDate,is_complete,ReasonNotCompleted,bComplete,bSent,pressure_passenger_front,pressure_passenger_rear,pressure_driver_front,pressure_driver_rear,pressure_spare,pressure_passenger_front_s,pressure_passenger_rear_s,pressure_driver_front_s,pressure_driver_rear_s,pressure_spare_s,bPhotosOutsideComplete,bPhotosInsideComplete,bDiagramsComplete,bSignaturesComplete,damage_pass,damage_driver,damage_front,damage_back,photos_front,photos_rear,photos_left,photos_right,bDriverSigned,bCheckedBySigned,driver_printed,checked_printed")] FitterVan fitterVan)
        {
            if (ModelState.IsValid)
            {
                repo.Db.Add(fitterVan);
                await repo.Db.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(fitterVan);
        }

        // GET: FitterVans/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var fitterVan = await repo.Db.FitterVans.FindAsync(id);
            if (fitterVan == null)
            {
                return NotFound();
            }
            return View(fitterVan);
        }

        // POST: FitterVans/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,circuit_breaker,power_breaker,hammer_drill,ordinary_drill,cordless_drill,spare_battery_and_charger,circular_saw,jig_saw,planer_check_blade,heat_gun,sander,hoover,halogen_lamp,extension_lead,router,industrial_ladders,ladder_clamps,step_ladders,ladder_stopper,philips_bit,screw_box,tresles_x2,torch_working,ratchett_straps_x4,spare_wheel,blue_external_dust_sheet,internal_dust_sheets_x3,brush_and_shovel,cleaner_bottle,ecloth,mastic_guns,glass_suckers,safety_helmets,helmet_manufacture_date,gloves,wrist_guards,goggles,ear_defenders,dust_masks,customer_care_cards,completion_forms,freepost_envelopes,mandate_forms,quality_manuals,stapler,worksheets,plasters,dressing,eyewashers,steri_wipes,bag,flexi_meter,merlin_low_e_detector,cabin_condition,national_tyres_card,breakdown_card,fuel_card,shell_points_card,fire_extinguisher,jack,wheelbrace,jump_leads,fan_belt,tow_ropes,spare_oil,coolant_anti_freeze,van_height_sticker,wheel_nut_check_sticker,no_smoking_sticker,racks_and_poles,tyre_conditions,van_locks,oil_and_water_checked,hows_my_driving_sticker,pda_setup_date,accident_pack_on_pda,hi_vis_vests,grinder,windscreen_good_contidion,circuit_breaker_s,power_breaker_s,hammer_drill_s,ordinary_drill_s,cordless_drill_s,spare_battery_and_charger_s,circular_saw_s,jig_saw_s,planer_check_blade_s,heat_gun_s,sander_s,hoover_s,halogen_lamp_s,extension_lead_s,router_s,industrial_ladders_s,ladder_clamps_s,step_ladders_s,ladder_stopper_s,philips_bit_s,screw_box_s,tresles_x2_s,torch_working_s,ratchett_straps_x4_s,spare_wheel_s,blue_external_dust_sheet_s,internal_dust_sheets_x3_s,brush_and_shovel_s,cleaner_bottle_s,ecloth_s,mastic_guns_s,glass_suckers_s,safety_helmets_s,helmet_manufacture_date_s,gloves_s,wrist_guards_s,goggles_s,ear_defenders_s,dust_masks_s,customer_care_cards_s,completion_forms_s,freepost_envelopes_s,mandate_forms_s,quality_manuals_s,stapler_s,worksheets_s,plasters_s,dressing_s,eyewashers_s,steri_wipes_s,bag_s,flexi_meter_s,merlin_low_e_detector_s,cabin_condition_s,national_tyres_card_s,breakdown_card_s,fuel_card_s,shell_points_card_s,fire_extinguisher_s,jack_s,wheelbrace_s,jump_leads_s,fan_belt_s,tow_ropes_s,spare_oil_s,coolant_anti_freeze_s,van_height_sticker_s,wheel_nut_check_sticker_s,no_smoking_sticker_s,racks_and_poles_s,tyre_conditions_s,van_locks_s,oil_and_water_checked_s,hows_my_driving_sticker_s,pda_setup_date_s,accident_pack_on_pda_s,hi_vis_vests_s,grinder_s,windscreen_good_contidion_s,fitters_own_power_tools_ladders_on_van,marks_out_of_10,vehicle_reg,spare_s_1,spare_s_2,spare_s_3,spare_s_4,spare_i_1,spare_i_2,spare_i_3,spare_i_4,ManufactureDateOnHelmet,ManufactureDateOnHelmet2,ManufactureDateOnHelmet3,ManufactureDateOnHelmet4,ManufactureDateOnHelmet5,ManufactureDateOnHelmet6,ManufactureDateOnHelmet7,ManufactureDateOnHelmet8,ManufactureDateOnHelmet9,ManufactureDateOnHelmet10,letterbox_jig,VehicleCheckHeaderId,CheckID,Destination,CheckDoneDate,Registration,Mileage,BranchCode,PDAVersionDate,is_complete,ReasonNotCompleted,bComplete,bSent,pressure_passenger_front,pressure_passenger_rear,pressure_driver_front,pressure_driver_rear,pressure_spare,pressure_passenger_front_s,pressure_passenger_rear_s,pressure_driver_front_s,pressure_driver_rear_s,pressure_spare_s,bPhotosOutsideComplete,bPhotosInsideComplete,bDiagramsComplete,bSignaturesComplete,damage_pass,damage_driver,damage_front,damage_back,photos_front,photos_rear,photos_left,photos_right,bDriverSigned,bCheckedBySigned,driver_printed,checked_printed")] FitterVan fitterVan)
        {
            if (id != fitterVan.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    repo.Db.Update(fitterVan);
                    await repo.Db.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FitterVanExists(fitterVan.Id))
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
            return View(fitterVan);
        }

        // GET: FitterVans/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var fitterVan = await repo.Db.FitterVans
                .FirstOrDefaultAsync(m => m.Id == id);
            if (fitterVan == null)
            {
                return NotFound();
            }

            return View(fitterVan);
        }

        // POST: FitterVans/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var fitterVan = await repo.Db.FitterVans.FindAsync(id);
            if (fitterVan != null)
            {
                repo.Db.FitterVans.Remove(fitterVan);
            }

            await repo.Db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FitterVanExists(int id)
        {
            return repo.Db.FitterVans.Any(e => e.Id == id);
        }
    }
}
