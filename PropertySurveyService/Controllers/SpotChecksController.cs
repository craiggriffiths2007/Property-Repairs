
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PropertySurveyService.Models;
using PropertySurveyService.Data;

public class SpotChecksController : Controller
{
    private readonly AppDBContext _context;

    public SpotChecksController(AppDBContext context)
    {
        _context = context;
    }

    // GET: SPOTCHECKS
    public async Task<IActionResult> Index()    
    {
        return View(await _context.SpotCheckTable.ToListAsync());
    }

    // GET: SPOTCHECKS/Details/5
    public async Task<IActionResult> Details(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var spotcheck = await _context.SpotCheckTable
            .FirstOrDefaultAsync(m => m.Id == id);
        if (spotcheck == null)
        {
            return NotFound();
        }

        return View(spotcheck);
    }

    // GET: SPOTCHECKS/Create
    public IActionResult Create()
    {
        return View();
    }

    // POST: SPOTCHECKS/Create
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create([Bind("Id,Guid,date_done,bComplete,bSent,bCorrectContract,ContractCode,branch,Date,Time,Name,Add1,Add2,Add3,Postcode,Phone1,Phone2,Phone3,DamageDesc,Instructions,uspot_qualityofworks,uspot_appearence_improvements,uspot_qualityofworks_improvements,uspot_customersatisfaction_improvements,uspot_otherobservations,uspot_fitter,uspot_trainee,uspot_date,uspot_customer,uspot_postcode,uspot_insuranceco,uspot_branch,uspot_customersatisfaction,uspot_customersatisfaction_improvementsOld,uspot_otherobservationsOld,uspot_signed,uspot_signeddate,uspot_replace_fit,uspot_p1,uspot_p2,uspot_p3,uspot_p4,uspot_repair,uspot_repair_arrived,uspot_repair_setup,uspot_repair_ongoing,uspot_repair_completed,uspot_replace,uspot_replace_arrived,uspot_replace_setup,uspot_replace_unitmoved,uspot_replace_completed,uspot_rev_door,uspot_rev_window,uspot_rev_garagedoor,uspot_rev_glass,uspot_rev_locks,uspot_rev_other,uspot_revb_upvc,uspot_revb_ali,uspot_revb_timber,uspot_revb_other,uspot_appearence,name1,name2,safety_boots_worn1,safety_gloves_worn1,safety_googles_worn1,safety_helmet_worn1,wristguards_worn1,uniform_worn_complete1,id_card_available1,safety_boots_worn2,safety_gloves_worn2,safety_googles_worn2,safety_helmet_worn2,wristguards_worn2,uniform_worn_complete2,id_card_available2,chemicals_stored_correctly,are_sheets_available,area_above_been_checked,obstructions_checked,lintel_ok,ladders_secure,safe_work_at_height,condition_of_ladders,tools_set_out_safely,fire_extinguisher_on_van,first_aid_kit_on_van,electrical_equipment_tested,safety_boots_worn1_s,safety_gloves_worn1_s,safety_googles_worn1_s,safety_helmet_worn1_s,wristguards_worn1_s,uniform_worn_complete1_s,id_card_available1_s,safety_boots_worn2_s,safety_gloves_worn2_s,safety_googles_worn2_s,safety_helmet_worn2_s,wristguards_worn2_s,uniform_worn_complete2_s,id_card_available2_s,chemicals_stored_correctly_s,are_sheets_available_s,area_above_been_checked_s,obstructions_checked_s,lintel_ok_s,ladders_secure_s,safe_work_at_height_s,condition_of_ladders_s,tools_set_out_safely_s,fire_extinguisher_on_van_s,first_aid_kit_on_van_s,electrical_equipment_tested_s,comments")] SpotCheck spotcheck)
    {
        if (ModelState.IsValid)
        {
            _context.Add(spotcheck);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        return View(spotcheck);
    }

    // GET: SPOTCHECKS/Edit/5
    public async Task<IActionResult> Edit(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var spotcheck = await _context.SpotCheckTable.FindAsync(id);
        if (spotcheck == null)
        {
            return NotFound();
        }
        return View(spotcheck);
    }

    // POST: SPOTCHECKS/Edit/5
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(int? id, [Bind("Id,Guid,date_done,bComplete,bSent,bCorrectContract,ContractCode,branch,Date,Time,Name,Add1,Add2,Add3,Postcode,Phone1,Phone2,Phone3,DamageDesc,Instructions,uspot_qualityofworks,uspot_appearence_improvements,uspot_qualityofworks_improvements,uspot_customersatisfaction_improvements,uspot_otherobservations,uspot_fitter,uspot_trainee,uspot_date,uspot_customer,uspot_postcode,uspot_insuranceco,uspot_branch,uspot_customersatisfaction,uspot_customersatisfaction_improvementsOld,uspot_otherobservationsOld,uspot_signed,uspot_signeddate,uspot_replace_fit,uspot_p1,uspot_p2,uspot_p3,uspot_p4,uspot_repair,uspot_repair_arrived,uspot_repair_setup,uspot_repair_ongoing,uspot_repair_completed,uspot_replace,uspot_replace_arrived,uspot_replace_setup,uspot_replace_unitmoved,uspot_replace_completed,uspot_rev_door,uspot_rev_window,uspot_rev_garagedoor,uspot_rev_glass,uspot_rev_locks,uspot_rev_other,uspot_revb_upvc,uspot_revb_ali,uspot_revb_timber,uspot_revb_other,uspot_appearence,name1,name2,safety_boots_worn1,safety_gloves_worn1,safety_googles_worn1,safety_helmet_worn1,wristguards_worn1,uniform_worn_complete1,id_card_available1,safety_boots_worn2,safety_gloves_worn2,safety_googles_worn2,safety_helmet_worn2,wristguards_worn2,uniform_worn_complete2,id_card_available2,chemicals_stored_correctly,are_sheets_available,area_above_been_checked,obstructions_checked,lintel_ok,ladders_secure,safe_work_at_height,condition_of_ladders,tools_set_out_safely,fire_extinguisher_on_van,first_aid_kit_on_van,electrical_equipment_tested,safety_boots_worn1_s,safety_gloves_worn1_s,safety_googles_worn1_s,safety_helmet_worn1_s,wristguards_worn1_s,uniform_worn_complete1_s,id_card_available1_s,safety_boots_worn2_s,safety_gloves_worn2_s,safety_googles_worn2_s,safety_helmet_worn2_s,wristguards_worn2_s,uniform_worn_complete2_s,id_card_available2_s,chemicals_stored_correctly_s,are_sheets_available_s,area_above_been_checked_s,obstructions_checked_s,lintel_ok_s,ladders_secure_s,safe_work_at_height_s,condition_of_ladders_s,tools_set_out_safely_s,fire_extinguisher_on_van_s,first_aid_kit_on_van_s,electrical_equipment_tested_s,comments")] SpotCheck spotcheck)
    {
        if (id != spotcheck.Id)
        {
            return NotFound();
        }

        if (ModelState.IsValid)
        {
            try
            {
                _context.Update(spotcheck);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SpotCheckExists(spotcheck.Id))
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
        return View(spotcheck);
    }

    // GET: SPOTCHECKS/Delete/5
    public async Task<IActionResult> Delete(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var spotcheck = await _context.SpotCheckTable
            .FirstOrDefaultAsync(m => m.Id == id);
        if (spotcheck == null)
        {
            return NotFound();
        }

        return View(spotcheck);
    }

    // POST: SPOTCHECKS/Delete/5
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int? id)
    {
        var spotcheck = await _context.SpotCheckTable.FindAsync(id);
        if (spotcheck != null)
        {
            _context.SpotCheckTable.Remove(spotcheck);
        }

        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }

    private bool SpotCheckExists(int? id)
    {
        return _context.SpotCheckTable.Any(e => e.Id == id);
    }
}
