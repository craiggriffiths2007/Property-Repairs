
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PropertySurveyService.Models;
using PropertySurveyService.Data;
using PropertySurveyService.ViewModels;

public class AluminiumController : Controller
{
    private readonly MainRepo repo;

    public AluminiumController(MainRepo _data)
    {
        repo = _data;
    }

    // GET: ALUMINIUMS
    public async Task<IActionResult> Index()    
    {
        return View(await repo.Db.Aluminium.ToListAsync());
    }

    // GET: ALUMINIUMS/Details/Db
    public async Task<IActionResult> Details(int? id)
    {
        ItemDetailsViewModel viewModel = new ItemDetailsViewModel();

        if (id == null)
        {
            return NotFound();
        }

        var aluminium = await repo.Db.Aluminium
            .FirstOrDefaultAsync(m => m.Id == id);
        if (aluminium == null)
        {
            return NotFound();
        }

        viewModel.Aluminium = aluminium;

        viewModel.Images = repo.GetSurveyItemImages(aluminium.ContractCode, aluminium.item_number);

        return View(viewModel);
    }

    // GET: ALUMINIUMS/Create
    public IActionResult Create()
    {
        return View();
    }

    // POST: ALUMINIUMS/Create
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317Db98.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create([Bind("Id,HeaderId,Guid,ContractCode,item_number,bRepair,cosmetic_damage,additional_locks,gaskets,gaskets_text,handles_req,handles_text,replace_panel,replace_reason,replace_explain,type,cause_of_damage,cause_of_damage_reason_different,section_type,new_timber_sub_frame,sub_frame_depth,item_frame_width,item_frame_height,brick_width,brick_height,internal_width,internal_height,frame_type,cill,drip,night_vent,midrail_type,item_color,locking_type,letter_box,letter_box_pos,pet_flap,pet_type,pet_magnetic,opens,handle_color,spacer_thickness,spacer_color,glass_type,glass_pattern,special_glass,sub_frame_color,bNewLockingMech,bLockComplete,bHandleDrawingComplete,no_of_pics,midrail_height,no_of_photos,docl,room_location,no_of_vids,LPHandles,threshold_type,bDifferentFromOriginal,ChangeItemTo,print_name,bFencer,FecerRating,long_comments,bDoorComplete,bWindowComplete,lead_sizeA,lead_sizeB,lead_sizeC,lead_sizeD,lead_CWidth,lead_CHeight,lead_anti_rattle,lead_thickness,lead_sod,lead_type,lead_bDiamondComplete,lead_bGeorgianComplete,lead_bBarComplete,lead_bSGDesignComplete,lock_make,lock_codes,bPanelComplete,GearBox,left_bolt,right_bolt,bComplete,cill_on_subframe,cill_type,i_spare3,collect_and_copy,temporary,glazed,bead_type,outer_section_width,outer_section_height,parts_to_order,lead_comments,is_a_flat,point_of_entry,type_of_lockng_system_required,was_it_locked,back_to_back_spacer_width,back_to_back_spacer_height,l_size1,l_size2,l_sizeA,l_sizeB,l_sizeC,l_sizeD,l_sizeE,l_sizeF,l_sizeG,l_num,l_fpos1,l_fpos2,l_fpos3,l_fpos4,l_fposDb,l_fpos6,l_fpos7,lock_position,l_itype1,l_itype2,l_itype3,l_itype4,l_itypeDb,l_itype6,l_itype7,lead_CWidthf,lead_CHeightf,lead_CWidths,lead_CHeights,glass_complete,replace_glass")] Aluminium aluminium)
    {
        if (ModelState.IsValid)
        {
            repo.Db.Add(aluminium);
            await repo.Db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        return View(aluminium);
    }

    // GET: ALUMINIUMS/Edit/Db
    public async Task<IActionResult> Edit(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var aluminium = await repo.Db.Aluminium.FindAsync(id);
        if (aluminium == null)
        {
            return NotFound();
        }
        return View(aluminium);
    }

    // POST: ALUMINIUMS/Edit/Db
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317Db98.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(int? id, [Bind("Id,HeaderId,Guid,ContractCode,item_number,bRepair,cosmetic_damage,additional_locks,gaskets,gaskets_text,handles_req,handles_text,replace_panel,replace_reason,replace_explain,type,cause_of_damage,cause_of_damage_reason_different,section_type,new_timber_sub_frame,sub_frame_depth,item_frame_width,item_frame_height,brick_width,brick_height,internal_width,internal_height,frame_type,cill,drip,night_vent,midrail_type,item_color,locking_type,letter_box,letter_box_pos,pet_flap,pet_type,pet_magnetic,opens,handle_color,spacer_thickness,spacer_color,glass_type,glass_pattern,special_glass,sub_frame_color,bNewLockingMech,bLockComplete,bHandleDrawingComplete,no_of_pics,midrail_height,no_of_photos,docl,room_location,no_of_vids,LPHandles,threshold_type,bDifferentFromOriginal,ChangeItemTo,print_name,bFencer,FecerRating,long_comments,bDoorComplete,bWindowComplete,lead_sizeA,lead_sizeB,lead_sizeC,lead_sizeD,lead_CWidth,lead_CHeight,lead_anti_rattle,lead_thickness,lead_sod,lead_type,lead_bDiamondComplete,lead_bGeorgianComplete,lead_bBarComplete,lead_bSGDesignComplete,lock_make,lock_codes,bPanelComplete,GearBox,left_bolt,right_bolt,bComplete,cill_on_subframe,cill_type,i_spare3,collect_and_copy,temporary,glazed,bead_type,outer_section_width,outer_section_height,parts_to_order,lead_comments,is_a_flat,point_of_entry,type_of_lockng_system_required,was_it_locked,back_to_back_spacer_width,back_to_back_spacer_height,l_size1,l_size2,l_sizeA,l_sizeB,l_sizeC,l_sizeD,l_sizeE,l_sizeF,l_sizeG,l_num,l_fpos1,l_fpos2,l_fpos3,l_fpos4,l_fposDb,l_fpos6,l_fpos7,lock_position,l_itype1,l_itype2,l_itype3,l_itype4,l_itypeDb,l_itype6,l_itype7,lead_CWidthf,lead_CHeightf,lead_CWidths,lead_CHeights,glass_complete,replace_glass")] Aluminium aluminium)
    {
        if (id != aluminium.Id)
        {
            return NotFound();
        }

        if (ModelState.IsValid)
        {
            try
            {
                repo.Db.Update(aluminium);
                await repo.Db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AluminiumExists(aluminium.Id))
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
        return View(aluminium);
    }

    // GET: ALUMINIUMS/Delete/Db
    public async Task<IActionResult> Delete(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var aluminium = await repo.Db.Aluminium
            .FirstOrDefaultAsync(m => m.Id == id);
        if (aluminium == null)
        {
            return NotFound();
        }

        return View(aluminium);
    }

    // POST: ALUMINIUMS/Delete/Db
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int? id)
    {
        var aluminium = await repo.Db.Aluminium.FindAsync(id);
        if (aluminium != null)
        {
            repo.Db.Aluminium.Remove(aluminium);
        }

        await repo.Db.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }

    private bool AluminiumExists(int? id)
    {
        return repo.Db.Aluminium.Any(e => e.Id == id);
    }
}
