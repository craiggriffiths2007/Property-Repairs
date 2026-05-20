
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PropertySurveyService.Models;
using PropertySurveyService.Data;

public class VAccidentsController : Controller
{
    private readonly AppDBContext _context;

    public VAccidentsController(AppDBContext context)
    {
        _context = context;
    }

    // GET: VACCIDENTS
    public async Task<IActionResult> Index()    
    {
        return View(await _context.VAccidents.ToListAsync());
    }

    // GET: VACCIDENTS/Details/5
    public async Task<IActionResult> Details(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var vaccident = await _context.VAccidents
            .FirstOrDefaultAsync(m => m.Id == id);
        if (vaccident == null)
        {
            return NotFound();
        }

        return View(vaccident);
    }

    // GET: VACCIDENTS/Create
    public IActionResult Create()
    {
        return View();
    }

    // POST: VACCIDENTS/Create
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create([Bind("Id,Guid,date_time,bSent,bComplete,brief,acc_date,acc_time,c_instructions,c_details,c_you,c_them,c_police,c_witness,c_photographs,c_drawings,d_bPolice,d_officers_name,d_officers_number,d_station,d_place,d_speed,d_weather,d_description,d_sign_date,y_make,y_model,y_reg,y_used_for,y_driver_full_name,y_driver_dob,y_address1,y_address2,y_address3,y_pcode,y_occupation,y_years_employed,y_months_employed,y_any_other_accidents,y_infirmity,y_prosecution,y_vehicle_damage,y_driveable,y_damage_to_property,y_injuries_sustained,y_signed,t_name,t_add1,t_add2,t_add3,t_pcode,t_telnum,t_make,t_model,t_reg,t_insurer,t_policy_no,no_of_other_people,p_name,p_add1,p_add2,p_add3,p_pcode,p_wittel,v_reg,v_model")] VAccident vaccident)
    {
        if (ModelState.IsValid)
        {
            _context.Add(vaccident);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        return View(vaccident);
    }

    // GET: VACCIDENTS/Edit/5
    public async Task<IActionResult> Edit(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var vaccident = await _context.VAccidents.FindAsync(id);
        if (vaccident == null)
        {
            return NotFound();
        }
        return View(vaccident);
    }

    // POST: VACCIDENTS/Edit/5
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(int? id, [Bind("Id,Guid,date_time,bSent,bComplete,brief,acc_date,acc_time,c_instructions,c_details,c_you,c_them,c_police,c_witness,c_photographs,c_drawings,d_bPolice,d_officers_name,d_officers_number,d_station,d_place,d_speed,d_weather,d_description,d_sign_date,y_make,y_model,y_reg,y_used_for,y_driver_full_name,y_driver_dob,y_address1,y_address2,y_address3,y_pcode,y_occupation,y_years_employed,y_months_employed,y_any_other_accidents,y_infirmity,y_prosecution,y_vehicle_damage,y_driveable,y_damage_to_property,y_injuries_sustained,y_signed,t_name,t_add1,t_add2,t_add3,t_pcode,t_telnum,t_make,t_model,t_reg,t_insurer,t_policy_no,no_of_other_people,p_name,p_add1,p_add2,p_add3,p_pcode,p_wittel,v_reg,v_model")] VAccident vaccident)
    {
        if (id != vaccident.Id)
        {
            return NotFound();
        }

        if (ModelState.IsValid)
        {
            try
            {
                _context.Update(vaccident);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!VAccidentExists(vaccident.Id))
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
        return View(vaccident);
    }

    // GET: VACCIDENTS/Delete/5
    public async Task<IActionResult> Delete(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var vaccident = await _context.VAccidents
            .FirstOrDefaultAsync(m => m.Id == id);
        if (vaccident == null)
        {
            return NotFound();
        }

        return View(vaccident);
    }

    // POST: VACCIDENTS/Delete/5
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int? id)
    {
        var vaccident = await _context.VAccidents.FindAsync(id);
        if (vaccident != null)
        {
            _context.VAccidents.Remove(vaccident);
        }

        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }

    private bool VAccidentExists(int? id)
    {
        return _context.VAccidents.Any(e => e.Id == id);
    }
}
