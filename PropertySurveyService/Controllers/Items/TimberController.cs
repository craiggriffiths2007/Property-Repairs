
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PropertySurveyService.Data;
using PropertySurveyService.Models;
using PropertySurveyService.ViewModels;

public class TimberController : Controller
{
    private readonly Repo repo;

    public TimberController(Repo _data)
    {
        repo = _data;
    }

    // GET: TIMBERS
    public async Task<IActionResult> Index()    
    {
        return View(await repo.Db.Timber.ToListAsync());
    }

    // GET: TIMBERS/Details/5
    public async Task<IActionResult> Details(int? id)
    {
        ItemDetailsViewModel viewModel = new ItemDetailsViewModel();

        if (id == null)
        {
            return NotFound();
        }

        var timber = await repo.Db.Timber
            .FirstOrDefaultAsync(m => m.Id == id);
        if (timber == null)
        {
            return NotFound();
        }

        viewModel.Timber = timber;

        viewModel.Images = repo.GetSurveyItemImages(timber.ContractCode, timber.item_number);
        var panel = await repo.Db.Panel.FirstOrDefaultAsync(p => p.HeaderId == timber.HeaderId && p.item_number == timber.item_number);
        if(panel != null)
        {
            viewModel.Panel = panel;
        }
        var glass = await repo.Db.Glass.FirstOrDefaultAsync(g => g.HeaderId == timber.HeaderId && g.item_number == timber.item_number);
        if (glass != null)
        {
            viewModel.Glass = glass;
        }
        var locking = await repo.Db.Lockmech.FirstOrDefaultAsync(l => l.HeaderId == timber.HeaderId && l.item_number == timber.item_number);
        if (locking != null)
        {
            viewModel.Lockmech = locking;
        }
        return View(viewModel);
    }

    // GET: TIMBERS/Create
    public IActionResult Create()
    {
        return View();
    }

    // POST: TIMBERS/Create
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create([Bind("Id,HeaderId,Guid,ContractCode,item_number,bComplete,bRepair,cosmetic_damage,additional_locks,gaskets,gaskets_text,handles_req,handles_text,replace_reason,replace_explain,timber_item,cause_of_damage,cause_of_damage_reason_different,timber_wood,timber_frame_wood,timber_new_frame_req,brick_width,brick_height,internal_width,internal_height,repair_frame,door_thickness,door_width,door_height,opens,new_sash_required,head_drip,cills,draught_strip,pet_flap,pet_type,pet_magnetic,bDoorComplete,bWindowComplete,beading_type,thresher,single_double,trickle_vents,locks,hardware_color,door_color,frame_color,spacer_thickness,spacer_color,glass_type,glass_pattern,special_glass,bNewLockingMech,bLockComplete,bHandleDrawingComplete,no_of_pics,no_of_photos,no_of_vids,docl,bSashDrawn,bSectionDrawn,bMouldingDrawn,room_location,doc_l_compliant_reason,doc_l_compliant,door_color_out,frame_color_out,door_color_code,door_color_code_out,frame_color_code,frame_color_code_out,b_signed,slide_position,timber_glazed,bDifferentFromOriginal,ChangeItemTo,print_name,standard_sizes,reasonnonstandard,Fensa,WER_rating,long_timber_comments,lead_sizeA,lead_sizeB,lead_sizeC,lead_sizeD,lead_CWidth,lead_CHeight,lead_anti_rattle,lead_thickness,lead_sod,lead_type,lead_bDiamondComplete,lead_bGeorgianComplete,lead_bBarComplete,lock_make,lock_codes,GearBox,left_bolt,right_bolt,letter_box,letter_box_pos,moulding,hinge_type,collect_and_copy,temporary,pre_glazed_door,lead_comments,weather_bar,parts_to_order,is_a_flat,point_of_entry,type_of_lockng_system_required,was_it_locked,back_to_back_spacer_width,back_to_back_spacer_height,l_size1,l_size2,l_sizeA,l_sizeB,l_sizeC,l_sizeD,l_sizeE,l_sizeF,l_sizeG,l_num,l_fpos1,l_fpos2,l_fpos3,l_fpos4,l_fpos5,l_fpos6,l_fpos7,lock_position,l_itype1,l_itype2,l_itype3,l_itype4,l_itype5,l_itype6,l_itype7,lead_CWidthf,lead_CHeightf,lead_CWidths,lead_CHeights,glass_complete,replace_glass")] Timber timber)
    {
        if (ModelState.IsValid)
        {
            repo.Db.Add(timber);
            await repo.Db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        return View(timber);
    }

    // GET: TIMBERS/Edit/5
    public async Task<IActionResult> Edit(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var timber = await repo.Db.Timber.FindAsync(id);
        if (timber == null)
        {
            return NotFound();
        }
        return View(timber);
    }

    // POST: TIMBERS/Edit/5
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(int? id, [Bind("Id,HeaderId,Guid,ContractCode,item_number,bComplete,bRepair,cosmetic_damage,additional_locks,gaskets,gaskets_text,handles_req,handles_text,replace_reason,replace_explain,timber_item,cause_of_damage,cause_of_damage_reason_different,timber_wood,timber_frame_wood,timber_new_frame_req,brick_width,brick_height,internal_width,internal_height,repair_frame,door_thickness,door_width,door_height,opens,new_sash_required,head_drip,cills,draught_strip,pet_flap,pet_type,pet_magnetic,bDoorComplete,bWindowComplete,beading_type,thresher,single_double,trickle_vents,locks,hardware_color,door_color,frame_color,spacer_thickness,spacer_color,glass_type,glass_pattern,special_glass,bNewLockingMech,bLockComplete,bHandleDrawingComplete,no_of_pics,no_of_photos,no_of_vids,docl,bSashDrawn,bSectionDrawn,bMouldingDrawn,room_location,doc_l_compliant_reason,doc_l_compliant,door_color_out,frame_color_out,door_color_code,door_color_code_out,frame_color_code,frame_color_code_out,b_signed,slide_position,timber_glazed,bDifferentFromOriginal,ChangeItemTo,print_name,standard_sizes,reasonnonstandard,Fensa,WER_rating,long_timber_comments,lead_sizeA,lead_sizeB,lead_sizeC,lead_sizeD,lead_CWidth,lead_CHeight,lead_anti_rattle,lead_thickness,lead_sod,lead_type,lead_bDiamondComplete,lead_bGeorgianComplete,lead_bBarComplete,lock_make,lock_codes,GearBox,left_bolt,right_bolt,letter_box,letter_box_pos,moulding,hinge_type,collect_and_copy,temporary,pre_glazed_door,lead_comments,weather_bar,parts_to_order,is_a_flat,point_of_entry,type_of_lockng_system_required,was_it_locked,back_to_back_spacer_width,back_to_back_spacer_height,l_size1,l_size2,l_sizeA,l_sizeB,l_sizeC,l_sizeD,l_sizeE,l_sizeF,l_sizeG,l_num,l_fpos1,l_fpos2,l_fpos3,l_fpos4,l_fpos5,l_fpos6,l_fpos7,lock_position,l_itype1,l_itype2,l_itype3,l_itype4,l_itype5,l_itype6,l_itype7,lead_CWidthf,lead_CHeightf,lead_CWidths,lead_CHeights,glass_complete,replace_glass")] Timber timber)
    {
        if (id != timber.Id)
        {
            return NotFound();
        }

        if (ModelState.IsValid)
        {
            try
            {
                repo.Db.Update(timber);
                await repo.Db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TimberExists(timber.Id))
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
        return View(timber);
    }

    // GET: TIMBERS/Delete/5
    public async Task<IActionResult> Delete(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var timber = await repo.Db.Timber
            .FirstOrDefaultAsync(m => m.Id == id);
        if (timber == null)
        {
            return NotFound();
        }

        return View(timber);
    }

    // POST: TIMBERS/Delete/5
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int? id)
    {
        var timber = await repo.Db.Timber.FindAsync(id);
        if (timber != null)
        {
            repo.Db.Timber.Remove(timber);
        }

        await repo.Db.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }

    private bool TimberExists(int? id)
    {
        return repo.Db.Timber.Any(e => e.Id == id);
    }
}
