
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PropertySurveyService.Data;
using PropertySurveyService.Models;
using PropertySurveyService.ViewModels;

public class BifoldingController : Controller
{
    private readonly AppDBContext _context;

    public BifoldingController(AppDBContext context)
    {
        _context = context;
    }

    // GET: BIFOLDINGS
    public async Task<IActionResult> Index()    
    {
        return View(await _context.Bifolding.ToListAsync());
    }

    // GET: BIFOLDINGS/Details/5
    public async Task<IActionResult> Details(int? id)
    {
        ItemDetailsViewModel viewModel = new ItemDetailsViewModel();

        if (id == null)
        {
            return NotFound();
        }

        var bifolding = await _context.Bifolding
            .FirstOrDefaultAsync(m => m.Id == id);
        if (bifolding == null)
        {
            return NotFound();
        }

        viewModel.Bifolding = bifolding;

        string pattern = $"{bifolding.ContractCode:00000000}____{bifolding.item_number:000}%"; // using _ as a wildcard ( would have been cAZ and dAZ )

        var photoimages = _context.Images
            .Where(x => EF.Functions.Like(x.Filename, pattern))
            .ToList();

        viewModel.Images = photoimages ?? new List<PhotoImage>();

        return View(viewModel);
    }

    // GET: BIFOLDINGS/Create
    public IActionResult Create()
    {
        return View();
    }

    // POST: BIFOLDINGS/Create
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create([Bind("Id,HeaderId,Guid,ContractCode,item_number,internal_width,internal_height,overall_width,overall_height,opens,trickle_vents,hardware,color_internal,color_external,threshold_type,no_of_pics,no_of_photos,no_of_vids,bComplete,comments,bifold_signed,number_of_doors,cause_of_damage,cause_of_damage_reason_different,door_type,glazing_options,number_of_doors_text,colour_of_doors,handle_colour,cill_type,knock_on,internal_door_colour,s_spare12,parts_to_order,type_of_lockng_system_required,was_it_locked,point_of_entry,ChangeItemTo,print_name,bDifferentFromOriginal,glass_complete,replace_glass,reason_not_repaired,bRepair,fensa,WER_rating,gaskets,gaskets_text,handles_req,bHandleDrawingComplete,handles_text,addons,addon_width,addon_height")] Bifolding bifolding)
    {
        if (ModelState.IsValid)
        {
            _context.Add(bifolding);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        return View(bifolding);
    }

    // GET: BIFOLDINGS/Edit/5
    public async Task<IActionResult> Edit(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var bifolding = await _context.Bifolding.FindAsync(id);
        if (bifolding == null)
        {
            return NotFound();
        }
        return View(bifolding);
    }

    // POST: BIFOLDINGS/Edit/5
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(int? id, [Bind("Id,HeaderId,Guid,ContractCode,item_number,internal_width,internal_height,overall_width,overall_height,opens,trickle_vents,hardware,color_internal,color_external,threshold_type,no_of_pics,no_of_photos,no_of_vids,bComplete,comments,bifold_signed,number_of_doors,cause_of_damage,cause_of_damage_reason_different,door_type,glazing_options,number_of_doors_text,colour_of_doors,handle_colour,cill_type,knock_on,internal_door_colour,s_spare12,parts_to_order,type_of_lockng_system_required,was_it_locked,point_of_entry,ChangeItemTo,print_name,bDifferentFromOriginal,glass_complete,replace_glass,reason_not_repaired,bRepair,fensa,WER_rating,gaskets,gaskets_text,handles_req,bHandleDrawingComplete,handles_text,addons,addon_width,addon_height")] Bifolding bifolding)
    {
        if (id != bifolding.Id)
        {
            return NotFound();
        }

        if (ModelState.IsValid)
        {
            try
            {
                _context.Update(bifolding);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BifoldingExists(bifolding.Id))
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
        return View(bifolding);
    }

    // GET: BIFOLDINGS/Delete/5
    public async Task<IActionResult> Delete(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var bifolding = await _context.Bifolding
            .FirstOrDefaultAsync(m => m.Id == id);
        if (bifolding == null)
        {
            return NotFound();
        }

        return View(bifolding);
    }

    // POST: BIFOLDINGS/Delete/5
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int? id)
    {
        var bifolding = await _context.Bifolding.FindAsync(id);
        if (bifolding != null)
        {
            _context.Bifolding.Remove(bifolding);
        }

        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }

    private bool BifoldingExists(int? id)
    {
        return _context.Bifolding.Any(e => e.Id == id);
    }
}
