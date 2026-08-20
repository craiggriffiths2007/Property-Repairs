
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PropertyRepairs.Models;
using PropertyRepairs.Data;
using PropertyRepairs.ViewModels;

public class GreenhouseController : Controller
{
    private readonly Repo repo;

    public GreenhouseController(Repo _data)
    {
        repo = _data;
    }

    // GET: GREENHOUSES
    public async Task<IActionResult> Index()    
    {
        return View(await repo.Db.Greenhouse.ToListAsync());
    }

    // GET: GREENHOUSES/Details/5
    public async Task<IActionResult> Details(int? id)
    {
        ItemDetailsViewModel viewModel = new ItemDetailsViewModel();

        if (id == null)
        {
            return NotFound();
        }

        var greenhouse = await repo.Db.Greenhouse
            .FirstOrDefaultAsync(m => m.Id == id);
        if (greenhouse == null)
        {
            return NotFound();
        }

        viewModel.Greenhouse = greenhouse;

        viewModel.Images = repo.GetSurveyItemImages(greenhouse.ContractCode, greenhouse.item_number);

        return View(viewModel);
    }

    // GET: GREENHOUSES/Create
    public IActionResult Create()
    {
        return View();
    }

    // POST: GREENHOUSES/Create
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create([Bind("Id,HeaderId,Guid,ContractCode,item_number,bComplete,bDifferentFromOriginal,cause_of_damage,cause_of_damage_reason_different,rep_reason,material_type,colour,glaze_type,base_size,base_size_x,base_size_y,type_of_glass,door_opening_type,window_opening_type,roof_opening_lights,auto_or_manual,overall_height,summary,no_of_pics,no_of_photos,no_of_vids,parts_to_order,point_of_entry,type_of_lockng_system_required,was_it_locked,ChangeItemTo,print_name,glass_complete,replace_glass,repair_or_replace")] Greenhouse greenhouse)
    {
        if (ModelState.IsValid)
        {
            repo.Db.Add(greenhouse);
            await repo.Db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        return View(greenhouse);
    }

    // GET: GREENHOUSES/Edit/5
    public async Task<IActionResult> Edit(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var greenhouse = await repo.Db.Greenhouse.FindAsync(id);
        if (greenhouse == null)
        {
            return NotFound();
        }
        return View(greenhouse);
    }

    // POST: GREENHOUSES/Edit/5
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(int? id, [Bind("Id,HeaderId,Guid,ContractCode,item_number,bComplete,bDifferentFromOriginal,cause_of_damage,cause_of_damage_reason_different,rep_reason,material_type,colour,glaze_type,base_size,base_size_x,base_size_y,type_of_glass,door_opening_type,window_opening_type,roof_opening_lights,auto_or_manual,overall_height,summary,no_of_pics,no_of_photos,no_of_vids,parts_to_order,point_of_entry,type_of_lockng_system_required,was_it_locked,ChangeItemTo,print_name,glass_complete,replace_glass,repair_or_replace")] Greenhouse greenhouse)
    {
        if (id != greenhouse.Id)
        {
            return NotFound();
        }

        if (ModelState.IsValid)
        {
            try
            {
                repo.Db.Update(greenhouse);
                await repo.Db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!GreenhouseExists(greenhouse.Id))
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
        return View(greenhouse);
    }

    // GET: GREENHOUSES/Delete/5
    public async Task<IActionResult> Delete(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var greenhouse = await repo.Db.Greenhouse
            .FirstOrDefaultAsync(m => m.Id == id);
        if (greenhouse == null)
        {
            return NotFound();
        }

        return View(greenhouse);
    }

    // POST: GREENHOUSES/Delete/5
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int? id)
    {
        var greenhouse = await repo.Db.Greenhouse.FindAsync(id);
        if (greenhouse != null)
        {
            repo.Db.Greenhouse.Remove(greenhouse);
        }

        await repo.Db.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }

    private bool GreenhouseExists(int? id)
    {
        return repo.Db.Greenhouse.Any(e => e.Id == id);
    }
}
