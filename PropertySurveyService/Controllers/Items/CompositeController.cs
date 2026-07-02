
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PropertySurveyService.Data;
using PropertySurveyService.Models;
using PropertySurveyService.ViewModels;

public class CompositeController : Controller
{
    private readonly MainRepo repo;

    public CompositeController(MainRepo _data)
    {
        repo = _data;
    }

    // GET: COMPOSITES
    public async Task<IActionResult> Index()    
    {
        return View(await repo.Db.Composite.ToListAsync());
    }

    // GET: COMPOSITES/Details/Db
    public async Task<IActionResult> Details(int? id)
    {
        ItemDetailsViewModel viewModel = new ItemDetailsViewModel();
        if (id == null)
        {
            return NotFound();
        }

        var composite = await repo.Db.Composite
            .FirstOrDefaultAsync(m => m.Id == id);
        if (composite == null)
        {
            return NotFound();
        }

        viewModel.Composite = composite;

        viewModel.Images = repo.GetSurveyItemImages(composite.ContractCode, composite.item_number);

        return View(viewModel);
    }

    // GET: COMPOSITES/Create
    public IActionResult Create()
    {
        return View();
    }

    // POST: COMPOSITES/Create
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317Db98.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create([Bind("Id,HeaderId,Guid,ContractCode,item_number,bComplete,cause_of_damage,cause_of_damage_reason_different,door_make,opens,is_lock,frame_colour_inside,frame_colour_outside,door_colour_inside,door_colour_outside,door_design,glass_design,internal_width,internal_height,brick_width,brick_height,trickle_vents,addons,addons_height,addons_width,handle_colour,threshold_type,lever_pad_handles,glass_pattern,glass_type,spacer_thickness,spacer_colour,profile_type,room_location,special_glass,comments,lead_CWidth,lead_CHeight,lead_anti_rattle,lead_thickness,lead_sod,lead_type,docl,letteredit,letter_box_pos,pet_flap,pet_type,pet_magnetic,glaze,print_name,lead_bDiamondComplete,lead_bGeorgianComplete,lead_bBarComplete,no_of_pics,no_of_photos,no_of_vids,bDifferentFromOriginal,lock_other_text,head_drip,ChangeItemTo,cills,door_wood,hinged_on,reason_not_repaired,lead_comments,parts_to_order,is_a_flat,point_of_entry,type_of_lockng_system_required,was_it_locked,fire_door,lead_CWidthf,lead_CHeightf,lead_CWidths,lead_CHeights,glass_complete,replace_glass,bRepair,fensa,WER_rating,gaskets,gaskets_text,handles_req,bHandleDrawingComplete,handles_text")] Composite composite)
    {
        if (ModelState.IsValid)
        {
            repo.Db.Add(composite);
            await repo.Db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        return View(composite);
    }

    // GET: COMPOSITES/Edit/Db
    public async Task<IActionResult> Edit(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var composite = await repo.Db.Composite.FindAsync(id);
        if (composite == null)
        {
            return NotFound();
        }
        return View(composite);
    }

    // POST: COMPOSITES/Edit/Db
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317Db98.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(int? id, [Bind("Id,HeaderId,Guid,ContractCode,item_number,bComplete,cause_of_damage,cause_of_damage_reason_different,door_make,opens,is_lock,frame_colour_inside,frame_colour_outside,door_colour_inside,door_colour_outside,door_design,glass_design,internal_width,internal_height,brick_width,brick_height,trickle_vents,addons,addons_height,addons_width,handle_colour,threshold_type,lever_pad_handles,glass_pattern,glass_type,spacer_thickness,spacer_colour,profile_type,room_location,special_glass,comments,lead_CWidth,lead_CHeight,lead_anti_rattle,lead_thickness,lead_sod,lead_type,docl,letteredit,letter_box_pos,pet_flap,pet_type,pet_magnetic,glaze,print_name,lead_bDiamondComplete,lead_bGeorgianComplete,lead_bBarComplete,no_of_pics,no_of_photos,no_of_vids,bDifferentFromOriginal,lock_other_text,head_drip,ChangeItemTo,cills,door_wood,hinged_on,reason_not_repaired,lead_comments,parts_to_order,is_a_flat,point_of_entry,type_of_lockng_system_required,was_it_locked,fire_door,lead_CWidthf,lead_CHeightf,lead_CWidths,lead_CHeights,glass_complete,replace_glass,bRepair,fensa,WER_rating,gaskets,gaskets_text,handles_req,bHandleDrawingComplete,handles_text")] Composite composite)
    {
        if (id != composite.Id)
        {
            return NotFound();
        }

        if (ModelState.IsValid)
        {
            try
            {
                repo.Db.Update(composite);
                await repo.Db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CompositeExists(composite.Id))
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
        return View(composite);
    }

    // GET: COMPOSITES/Delete/Db
    public async Task<IActionResult> Delete(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var composite = await repo.Db.Composite
            .FirstOrDefaultAsync(m => m.Id == id);
        if (composite == null)
        {
            return NotFound();
        }

        return View(composite);
    }

    // POST: COMPOSITES/Delete/Db
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int? id)
    {
        var composite = await repo.Db.Composite.FindAsync(id);
        if (composite != null)
        {
            repo.Db.Composite.Remove(composite);
        }

        await repo.Db.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }

    private bool CompositeExists(int? id)
    {
        return repo.Db.Composite.Any(e => e.Id == id);
    }
}
