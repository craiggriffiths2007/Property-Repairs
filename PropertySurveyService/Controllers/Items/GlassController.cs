
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PropertySurveyService.Models;
using PropertySurveyService.Data;
using PropertySurveyService.ViewModels;

public class GlassController : Controller
{
    private readonly AppDBContext _context;

    public GlassController(AppDBContext context)
    {
        _context = context;
    }

    // GET: GLASSS
    public async Task<IActionResult> Index()    
    {
        return View(await _context.Glass.ToListAsync());
    }

    // GET: GLASSS/Details/5
    public async Task<IActionResult> Details(int? id)
    {
        ItemDetailsViewModel viewModel = new ItemDetailsViewModel();

        if (id == null)
        {
            return NotFound();
        }

        var glass = await _context.Glass
            .FirstOrDefaultAsync(m => m.Id == id);
        if (glass == null)
        {
            return NotFound();
        }

        viewModel.Glass = glass;

        string pattern = $"{glass.ContractCode:00000000}____{glass  .item_number:000}%"; // using _ as a wildcard ( would have been cAZ and dAZ )

        var photoimages = _context.Images
            .Where(x => EF.Functions.Like(x.Filename, pattern))
            .ToList();

        viewModel.Images = photoimages ?? new List<PhotoImage>();

        return View(viewModel);
    }

    // GET: GLASSS/Create
    public IActionResult Create()
    {
        return View();
    }

    // POST: GLASSS/Create
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create([Bind("Id,HeaderId,Guid,ContractCode,item_number,bComplete,cause_of_damage,cause_of_damage_reason_different,units_required,glass_width,glass_height,glass_width2,glass_height2,glass_width3,glass_height3,glass_width4,glass_height4,glass_width5,glass_height5,glass_width6,glass_height6,glass_width7,glass_height7,glass_width8,glass_height8,stepped_unit,int_width,int_height,single_or_double,glass_type,sizeA,sizeB,sizeC,sizeD,lead_CWidth,lead_CHeight,lead_anti_rattle,lead_thickness,lead_sod,lead_type,lead_bDiamondComplete,lead_bGeorgianComplete,lead_bBarComplete,glass_pattern,spacer_color,spacer_thickness,special_glass,no_of_pics,docl_old,no_of_photos,gb_trim,docl,room_location,no_of_vids,bDifferentFromOriginal,ChangeItemTo,print_name,ProductInto,glazing_type,long_comments,lead_posX,lead_posY,TapeorGasket,glaze,lead_comments,collect_and_copy,temporary,parts_to_order,point_of_entry,type_of_lockng_system_required,was_it_locked,back_to_back_spacer_width,back_to_back_spacer_height,lead_CWidthf,lead_CHeightf,sizeAf,sizeBf,sizeCf,sizeDf,lead_CWidths,lead_CHeights,parent_item")] Glass glass)
    {
        if (ModelState.IsValid)
        {
            _context.Add(glass);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        return View(glass);
    }

    // GET: GLASSS/Edit/5
    public async Task<IActionResult> Edit(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var glass = await _context.Glass.FindAsync(id);
        if (glass == null)
        {
            return NotFound();
        }
        return View(glass);
    }

    // POST: GLASSS/Edit/5
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(int? id, [Bind("Id,HeaderId,Guid,ContractCode,item_number,bComplete,cause_of_damage,cause_of_damage_reason_different,units_required,glass_width,glass_height,glass_width2,glass_height2,glass_width3,glass_height3,glass_width4,glass_height4,glass_width5,glass_height5,glass_width6,glass_height6,glass_width7,glass_height7,glass_width8,glass_height8,stepped_unit,int_width,int_height,single_or_double,glass_type,sizeA,sizeB,sizeC,sizeD,lead_CWidth,lead_CHeight,lead_anti_rattle,lead_thickness,lead_sod,lead_type,lead_bDiamondComplete,lead_bGeorgianComplete,lead_bBarComplete,glass_pattern,spacer_color,spacer_thickness,special_glass,no_of_pics,docl_old,no_of_photos,gb_trim,docl,room_location,no_of_vids,bDifferentFromOriginal,ChangeItemTo,print_name,ProductInto,glazing_type,long_comments,lead_posX,lead_posY,TapeorGasket,glaze,lead_comments,collect_and_copy,temporary,parts_to_order,point_of_entry,type_of_lockng_system_required,was_it_locked,back_to_back_spacer_width,back_to_back_spacer_height,lead_CWidthf,lead_CHeightf,sizeAf,sizeBf,sizeCf,sizeDf,lead_CWidths,lead_CHeights,parent_item")] Glass glass)
    {
        if (id != glass.Id)
        {
            return NotFound();
        }

        if (ModelState.IsValid)
        {
            try
            {
                _context.Update(glass);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!GlassExists(glass.Id))
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
        return View(glass);
    }

    // GET: GLASSS/Delete/5
    public async Task<IActionResult> Delete(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var glass = await _context.Glass
            .FirstOrDefaultAsync(m => m.Id == id);
        if (glass == null)
        {
            return NotFound();
        }

        return View(glass);
    }

    // POST: GLASSS/Delete/5
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int? id)
    {
        var glass = await _context.Glass.FindAsync(id);
        if (glass != null)
        {
            _context.Glass.Remove(glass);
        }

        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }

    private bool GlassExists(int? id)
    {
        return _context.Glass.Any(e => e.Id == id);
    }
}
