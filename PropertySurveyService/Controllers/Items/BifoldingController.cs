
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PropertySurveyService.Data;
using PropertySurveyService.Models;
using PropertySurveyService.ViewModels;

public class BifoldingController : Controller
{
    private readonly Repo repo;

    public BifoldingController(Repo _data)
    {
        repo = _data;
    }

    // GET: BIFOLDINGS
    public async Task<IActionResult> Index()    
    {
        return View(await repo.Db.Bifolding.ToListAsync());
    }

    // GET: BIFOLDINGS/Details/Db
    public async Task<IActionResult> Details(int? id)
    {
        ItemDetailsViewModel viewModel = new ItemDetailsViewModel();

        if (id == null)
        {
            return NotFound();
        }

        var bifolding = await repo.Db.Bifolding
            .FirstOrDefaultAsync(m => m.Id == id);
        if (bifolding == null)
        {
            return NotFound();
        }

        viewModel.Bifolding = bifolding;

        viewModel.Images = repo.GetSurveyItemImages(bifolding.ContractCode, bifolding.item_number);

        return View(viewModel);
    }

    // GET: BIFOLDINGS/Create
    public IActionResult Create()
    {
        return View();
    }

    // POST: BIFOLDINGS/Create
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317Db98.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create([Bind("Id,HeaderId,Guid,ContractCode,item_number,internal_width,internal_height,overall_width,overall_height,opens,trickle_vents,hardware,color_internal,color_external,threshold_type,no_of_pics,no_of_photos,no_of_vids,bComplete,comments,bifold_signed,number_of_doors,cause_of_damage,cause_of_damage_reason_different,door_type,glazing_options,number_of_doors_text,colour_of_doors,handle_colour,cill_type,knock_on,internal_door_colour,s_spare12,parts_to_order,type_of_lockng_system_required,was_it_locked,point_of_entry,ChangeItemTo,print_name,bDifferentFromOriginal,glass_complete,replace_glass,reason_not_repaired,bRepair,fensa,WER_rating,gaskets,gaskets_text,handles_req,bHandleDrawingComplete,handles_text,addons,addon_width,addon_height")] Bifolding bifolding)
    {
        if (ModelState.IsValid)
        {
            repo.Db.Add(bifolding);
            await repo.Db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        return View(bifolding);
    }

    // GET: BIFOLDINGS/Edit/Db
    public async Task<IActionResult> Edit(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var bifolding = await repo.Db.Bifolding.FindAsync(id);
        if (bifolding == null)
        {
            return NotFound();
        }
        return View(bifolding);
    }

    // POST: BIFOLDINGS/Edit/Db
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317Db98.
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
                repo.Db.Update(bifolding);
                await repo.Db.SaveChangesAsync();
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

    // GET: BIFOLDINGS/Delete/Db
    public async Task<IActionResult> Delete(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var bifolding = await repo.Db.Bifolding
            .FirstOrDefaultAsync(m => m.Id == id);
        if (bifolding == null)
        {
            return NotFound();
        }

        return View(bifolding);
    }

    // POST: BIFOLDINGS/Delete/Db
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int? id)
    {
        var bifolding = await repo.Db.Bifolding.FindAsync(id);
        if (bifolding != null)
        {
            repo.Db.Bifolding.Remove(bifolding);
        }

        await repo.Db.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }

    private bool BifoldingExists(int? id)
    {
        return repo.Db.Bifolding.Any(e => e.Id == id);
    }
}
