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
    public class Accident_sheetController : Controller
    {
        private readonly AppDBContext _context;

        public Accident_sheetController(AppDBContext context)
        {
            _context = context;
        }

        // GET: Accident_sheet
        public async Task<IActionResult> Index()
        {
            return View(await _context.VAccidents.ToListAsync());
        }

        // GET: Accident_sheet/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var accident_sheet = await _context.VAccidents
                .FirstOrDefaultAsync(m => m.Id == id);
            if (accident_sheet == null)
            {
                return NotFound();
            }

            return View(accident_sheet);
        }

        // GET: Accident_sheet/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Accident_sheet/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,date_time,bSent,bComplete,brief,c_instructions,c_details,c_you,c_them,c_police,c_witness,c_photographs,c_drawings,d_bPolice,d_officers_name,d_officers_number,d_station,d_place,d_speed,d_weather,d_description,d_sign_date,y_make,y_model,y_reg,y_used_for,y_driver_full_name,y_driver_dob,y_address1,y_address2,y_address3,y_pcode,y_occupation,y_years_employed,y_months_employed,y_any_other_accidents,y_infirmity,y_prosecution,y_vehicle_damage,y_driveable,y_damage_to_property,y_injuries_sustained,y_signed,t_name,t_add1,t_add2,t_add3,t_pcode,t_make,t_reg,t_model,t_insurer,t_policy_no,t_telnum,no_of_other_people,p_name,p_add1,p_add2,p_add3,p_pcode,p_wittel,v_reg,v_model,acc_date,acc_time")] VAccident accident_sheet)
        {
            if (ModelState.IsValid)
            {
                _context.Add(accident_sheet);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(accident_sheet);
        }

        // GET: Accident_sheet/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var accident_sheet = await _context.VAccidents.FindAsync(id);
            if (accident_sheet == null)
            {
                return NotFound();
            }
            return View(accident_sheet);
        }

        // POST: Accident_sheet/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,date_time,bSent,bComplete,brief,c_instructions,c_details,c_you,c_them,c_police,c_witness,c_photographs,c_drawings,d_bPolice,d_officers_name,d_officers_number,d_station,d_place,d_speed,d_weather,d_description,d_sign_date,y_make,y_model,y_reg,y_used_for,y_driver_full_name,y_driver_dob,y_address1,y_address2,y_address3,y_pcode,y_occupation,y_years_employed,y_months_employed,y_any_other_accidents,y_infirmity,y_prosecution,y_vehicle_damage,y_driveable,y_damage_to_property,y_injuries_sustained,y_signed,t_name,t_add1,t_add2,t_add3,t_pcode,t_make,t_reg,t_model,t_insurer,t_policy_no,t_telnum,no_of_other_people,p_name,p_add1,p_add2,p_add3,p_pcode,p_wittel,v_reg,v_model,acc_date,acc_time")] VAccident accident_sheet)
        {
            if (id != accident_sheet.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(accident_sheet);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Accident_sheetExists(accident_sheet.Id))
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
            return View(accident_sheet);
        }

        // GET: Accident_sheet/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var accident_sheet = await _context.VAccidents
                .FirstOrDefaultAsync(m => m.Id == id);
            if (accident_sheet == null)
            {
                return NotFound();
            }

            return View(accident_sheet);
        }

        // POST: Accident_sheet/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var accident_sheet = await _context.VAccidents.FindAsync(id);
            if (accident_sheet != null)
            {
                _context.VAccidents.Remove(accident_sheet);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Accident_sheetExists(int id)
        {
            return _context.VAccidents.Any(e => e.Id == id);
        }
    }
}
