
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PropertySurveyService.Data;
using PropertySurveyService.Models;
using PropertySurveyService.ViewModels;

public class AssemblyController : Controller
{
    private readonly Repo repo;

    public AssemblyController(Repo _data)
    {
        repo = _data;
    }

    // GET: ASSEMBLYS
    public async Task<IActionResult> Index()    
    {
        return View(await repo.Db.Assembly.ToListAsync());
    }

    // GET: ASSEMBLYS/Details/5
    public async Task<IActionResult> Details(int? id)
    {
        ItemDetailsViewModel viewModel = new ItemDetailsViewModel();

        if (id == null)
        {
            return NotFound();
        }

        var assembly = await repo.Db.Assembly
            .FirstOrDefaultAsync(m => m.Id == id);
        if (assembly == null)
        {
            return NotFound();
        }

        viewModel.Assembly = assembly;

        viewModel.Images = repo.GetSurveyItemImages(assembly.ContractCode, assembly.item_number);
        // If there's a matching Panel with same HeaderId and item_number, include its images after the main item
        var panel = await repo.Db.Panel.FirstOrDefaultAsync(p => p.HeaderId == assembly.HeaderId && p.item_number == assembly.item_number);
        if (panel != null)
        {
            viewModel.Panel = panel;
            //viewModel.PanelImages = repo.GetSurveyItemImages(panel.ContractCode, panel.item_number);
        }
        // If there's a matching Glass with same HeaderId and item_number, include its images after the main item
        var glass = await repo.Db.Glass.FirstOrDefaultAsync(g => g.HeaderId == assembly.HeaderId && g.item_number == assembly.item_number);
        if (glass != null)
        {
            viewModel.Glass = glass;
            //viewModel.GlassImages = repo.GetSurveyItemImages(glass.ContractCode, glass.item_number);
        }

        var locking = await repo.Db.Lockmech.FirstOrDefaultAsync(l => l.HeaderId == assembly.HeaderId && l.item_number == assembly.item_number);
        if (locking != null)
        {
            viewModel.Lockmech = locking;
        }

        return View(viewModel);
    }

    // GET: ASSEMBLYS/Create
    public IActionResult Create()
    {
        return View();
    }

    // POST: ASSEMBLYS/Create
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create([Bind("Id,item_type,HeaderId,Guid,ContractCode,item_number,material,opening_type,WER_Rating,bRepair,cosmetic_damage,additional_locks,gaskets,gaskets_text,handles_req,handles_text,replace_reason,replace_explain,cause_of_damage,cause_of_damage_reason_different,brick_width,brick_height,internal_width,internal_height,opens,letter_box,letter_box_pos,pet_flap,pet_type,pet_magnetic,bNewLockingMech,spacer_thickness,spacer_colour,glass_type,glass_pattern,special_glass,replace_glass,glass_complete,docl,room_location,bDifferentFromOriginal,ChangeItemTo,print_name,bFensa,Summary,collect_and_copy,temporary,parts_to_order,is_a_flat,point_of_entry,type_of_lockng_system_required,was_it_locked,replace_panel,locking_type,midrail_height,LPHandles,threshold_type,bead_type,bPanelComplete,cills,head_drip,trickle_vents,slide_position,spacer_color,colour,outer_section_size,midrail,addons,addon_width,addon_height,handle_colour,glaze,double_tripple,internal_lock,frame_depth,profile_type,hinge_colour,section_type,new_timber_sub_frame,sub_frame_depth,sub_frame_width,sub_frame_height,frame_type,cill,drip,night_vent,midrail_type,item_color,handle_color,sub_frame_color,cill_on_subframe,cill_type,i_spare3,glazed,outer_section_width,outer_section_height,timber_wood,timber_frame_wood,timber_new_frame_req,repair_frame,door_thickness,door_width,door_height,new_sash_required,draught_strip,fire_rated_glass,thresher,single_double,locks,hardware_color,door_color,frame_color,bSashDrawn,bSectionDrawn,bMouldingDrawn,doc_l_compliant_reason,doc_l_compliant,door_color_out,frame_color_out,door_color_code,door_color_code_out,frame_color_code,frame_color_code_out,b_signed,timber_glazed,standard_sizes,reasonnonstandard,moulding,hinge_type,pre_glazed_door,weather_bar,bComplete,bDifferentFromOriginalSigned,bDoorComplete,bWindowComplete,bLockComplete,bHandleDrawingComplete,no_of_photos,no_of_drawings")] Assembly assembly)
    {
        if (ModelState.IsValid)
        {
            repo.Db.Add(assembly);
            await repo.Db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        return View(assembly);
    }

    // GET: ASSEMBLYS/Edit/5
    public async Task<IActionResult> Edit(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var assembly = await repo.Db.Assembly.FindAsync(id);
        if (assembly == null)
        {
            return NotFound();
        }
        return View(assembly);
    }

    // POST: ASSEMBLYS/Edit/5
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(int? id, [Bind("Id,item_type,HeaderId,Guid,ContractCode,item_number,material,opening_type,WER_Rating,bRepair,cosmetic_damage,additional_locks,gaskets,gaskets_text,handles_req,handles_text,replace_reason,replace_explain,cause_of_damage,cause_of_damage_reason_different,brick_width,brick_height,internal_width,internal_height,opens,letter_box,letter_box_pos,pet_flap,pet_type,pet_magnetic,bNewLockingMech,spacer_thickness,spacer_colour,glass_type,glass_pattern,special_glass,replace_glass,glass_complete,docl,room_location,bDifferentFromOriginal,ChangeItemTo,print_name,bFensa,Summary,collect_and_copy,temporary,parts_to_order,is_a_flat,point_of_entry,type_of_lockng_system_required,was_it_locked,replace_panel,locking_type,midrail_height,LPHandles,threshold_type,bead_type,bPanelComplete,cills,head_drip,trickle_vents,slide_position,spacer_color,colour,outer_section_size,midrail,addons,addon_width,addon_height,handle_colour,glaze,double_tripple,internal_lock,frame_depth,profile_type,hinge_colour,section_type,new_timber_sub_frame,sub_frame_depth,sub_frame_width,sub_frame_height,frame_type,cill,drip,night_vent,midrail_type,item_color,handle_color,sub_frame_color,cill_on_subframe,cill_type,i_spare3,glazed,outer_section_width,outer_section_height,timber_wood,timber_frame_wood,timber_new_frame_req,repair_frame,door_thickness,door_width,door_height,new_sash_required,draught_strip,fire_rated_glass,thresher,single_double,locks,hardware_color,door_color,frame_color,bSashDrawn,bSectionDrawn,bMouldingDrawn,doc_l_compliant_reason,doc_l_compliant,door_color_out,frame_color_out,door_color_code,door_color_code_out,frame_color_code,frame_color_code_out,b_signed,timber_glazed,standard_sizes,reasonnonstandard,moulding,hinge_type,pre_glazed_door,weather_bar,bComplete,bDifferentFromOriginalSigned,bDoorComplete,bWindowComplete,bLockComplete,bHandleDrawingComplete,no_of_photos,no_of_drawings")] Assembly assembly)
    {
        if (id != assembly.Id)
        {
            return NotFound();
        }

        if (ModelState.IsValid)
        {
            try
            {
                repo.Db.Update(assembly);
                await repo.Db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AssemblyExists(assembly.Id))
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
        return View(assembly);
    }

    // GET: ASSEMBLYS/Delete/5
    public async Task<IActionResult> Delete(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var assembly = await repo.Db.Assembly
            .FirstOrDefaultAsync(m => m.Id == id);
        if (assembly == null)
        {
            return NotFound();
        }

        return View(assembly);
    }

    // POST: ASSEMBLYS/Delete/5
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int? id)
    {
        var assembly = await repo.Db.Assembly.FindAsync(id);
        if (assembly != null)
        {
            repo.Db.Assembly.Remove(assembly);
        }

        await repo.Db.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }

    private bool AssemblyExists(int? id)
    {
        return repo.Db.Assembly.Any(e => e.Id == id);
    }
}
