
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PropertySurveyService.Models;
using PropertySurveyService.Data;
using PropertySurveyService.ViewModels;

public class ConservatoryController : Controller
{
    private readonly AppDBContext _context;

    public ConservatoryController(AppDBContext context)
    {
        _context = context;
    }

    // GET: CONSERVATORYS
    public async Task<IActionResult> Index()    
    {
        return View(await _context.Conservatory.ToListAsync());
    }

    // GET: CONSERVATORYS/Details/5
    public async Task<IActionResult> Details(int? id)
    {
        ItemDetailsViewModel viewModel = new ItemDetailsViewModel();

        if (id == null)
        {
            return NotFound();
        }

        var conservatory = await _context.Conservatory
            .FirstOrDefaultAsync(m => m.Id == id);
        if (conservatory == null)
        {
            return NotFound();
        }

        viewModel.Conservatory = conservatory;

        string pattern = $"{conservatory.ContractCode:00000000}____{conservatory.item_number:000}%"; // using _ as a wildcard ( would have been cAZ and dAZ )

        var photoimages = _context.Images
            .Where(x => EF.Functions.Like(x.Filename, pattern))
            .ToList();

        viewModel.Images = photoimages ?? new List<PhotoImage>();

        return View(viewModel);
    }

    // GET: CONSERVATORYS/Create
    public IActionResult Create()
    {
        return View();
    }

    // POST: CONSERVATORYS/Create
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create([Bind("Id,HeaderId,Guid,ContractCode,item_number,bComplete,type,cause_of_damage,cause_of_damage_reason_different,material_type,sizeA,sizeB,sizeC,sizeD,sizeE,sizeF,sizeG,angle1,angle2,angle3,angle4,pitch_height,profile_section_size,sheet_width_1,sheet_height_1,sheet_width_2,sheet_height_2,sheet_width_3,sheet_height_3,sheet_width_4,sheet_height_4,sheet_width_5,sheet_height_5,sheet_width_6,sheet_height_6,sheet_width_7,sheet_height_7,sheet_width_8,sheet_height_8,sheet_width_9,sheet_height_9,sheet_width_10,sheet_height_10,flute_size,color,roof_color,new_firrings_req,new_gutters_req,roof_glazing_thickness,no_of_pics,no_of_photos,room_location,no_of_vids,bDifferentFromOriginal,ChangeItemTo,print_name,wall_pos,pitch_degree,long_comments,bDrawingsOnly,cons_roof_under_drawn,does_roof_fit_under,spars_line_up,roof_sheets_quantity_1,roof_sheets_quantity_2,roof_sheets_quantity_3,roof_sheets_quantity_4,roof_sheets_quantity_5,roof_sheets_quantity_6,roof_sheets_quantity_7,roof_sheets_quantity_8,roof_sheets_quantity_9,roof_sheets_quantity_10,good_conditions,ridge_length,parts_to_order,point_of_entry,type_of_lockng_system_required,was_it_locked,glass_complete,replace_glass,reason_not_repaired,bRepair,fensa,WER_rating,overall_length_of_sheet,lead_bDiamondComplete,lead_bGeorgianComplete,lead_bBarComplete,lead_CWidthf,lead_CHeightf,lead_CWidths,lead_CHeights")] Conservatory conservatory)
    {
        if (ModelState.IsValid)
        {
            _context.Add(conservatory);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        return View(conservatory);
    }

    // GET: CONSERVATORYS/Edit/5
    public async Task<IActionResult> Edit(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var conservatory = await _context.Conservatory.FindAsync(id);
        if (conservatory == null)
        {
            return NotFound();
        }
        return View(conservatory);
    }

    // POST: CONSERVATORYS/Edit/5
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(int? id, [Bind("Id,HeaderId,Guid,ContractCode,item_number,bComplete,type,cause_of_damage,cause_of_damage_reason_different,material_type,sizeA,sizeB,sizeC,sizeD,sizeE,sizeF,sizeG,angle1,angle2,angle3,angle4,pitch_height,profile_section_size,sheet_width_1,sheet_height_1,sheet_width_2,sheet_height_2,sheet_width_3,sheet_height_3,sheet_width_4,sheet_height_4,sheet_width_5,sheet_height_5,sheet_width_6,sheet_height_6,sheet_width_7,sheet_height_7,sheet_width_8,sheet_height_8,sheet_width_9,sheet_height_9,sheet_width_10,sheet_height_10,flute_size,color,roof_color,new_firrings_req,new_gutters_req,roof_glazing_thickness,no_of_pics,no_of_photos,room_location,no_of_vids,bDifferentFromOriginal,ChangeItemTo,print_name,wall_pos,pitch_degree,long_comments,bDrawingsOnly,cons_roof_under_drawn,does_roof_fit_under,spars_line_up,roof_sheets_quantity_1,roof_sheets_quantity_2,roof_sheets_quantity_3,roof_sheets_quantity_4,roof_sheets_quantity_5,roof_sheets_quantity_6,roof_sheets_quantity_7,roof_sheets_quantity_8,roof_sheets_quantity_9,roof_sheets_quantity_10,good_conditions,ridge_length,parts_to_order,point_of_entry,type_of_lockng_system_required,was_it_locked,glass_complete,replace_glass,reason_not_repaired,bRepair,fensa,WER_rating,overall_length_of_sheet,lead_bDiamondComplete,lead_bGeorgianComplete,lead_bBarComplete,lead_CWidthf,lead_CHeightf,lead_CWidths,lead_CHeights")] Conservatory conservatory)
    {
        if (id != conservatory.Id)
        {
            return NotFound();
        }

        if (ModelState.IsValid)
        {
            try
            {
                _context.Update(conservatory);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ConservatoryExists(conservatory.Id))
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
        return View(conservatory);
    }

    // GET: CONSERVATORYS/Delete/5
    public async Task<IActionResult> Delete(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var conservatory = await _context.Conservatory
            .FirstOrDefaultAsync(m => m.Id == id);
        if (conservatory == null)
        {
            return NotFound();
        }

        return View(conservatory);
    }

    // POST: CONSERVATORYS/Delete/5
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int? id)
    {
        var conservatory = await _context.Conservatory.FindAsync(id);
        if (conservatory != null)
        {
            _context.Conservatory.Remove(conservatory);
        }

        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }

    private bool ConservatoryExists(int? id)
    {
        return _context.Conservatory.Any(e => e.Id == id);
    }
}
