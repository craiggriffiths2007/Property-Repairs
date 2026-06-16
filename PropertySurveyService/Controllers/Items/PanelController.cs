
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PropertySurveyService.Models;
using PropertySurveyService.Data;
using PropertySurveyService.ViewModels;
public class PanelController : Controller
{
    private readonly IMainRepo data;

    public PanelController(IMainRepo _data)
    {
        data = _data;
    }

    // GET: PANELS
    public async Task<IActionResult> Index()    
    {
        return View(await data.db().Panel.ToListAsync());
    }

    // GET: PANELS/Details/5
    public async Task<IActionResult> Details(int? id)
    {
        ItemDetailsViewModel viewModel = new ItemDetailsViewModel();

        if (id == null)
        {
            return NotFound();
        }

        var panel = await data.db().Panel
            .FirstOrDefaultAsync(m => m.Id == id);
        if (panel == null)
        {
            return NotFound();
        }

        viewModel.Panel = panel;

        viewModel.Images = data.GetSurveyItemImages(panel.ContractCode, panel.item_number);

        return View(viewModel);
    }

    // GET: PANELS/Create
    public IActionResult Create()
    {
        return View();
    }

    // POST: PANELS/Create
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create([Bind("Id,HeaderId,Guid,ContractCode,item_number,bComplete,cause_of_damage,cause_of_damage_reason_different,knockedit,knocoledit,letteredit,letter_box_pos,wedit,hedit,typeedit,thickedit,backgedit,coledit,gltext,spaccoloedit,pet_flap,pet_type,pet_magnetic,no_of_pics,no_of_photos,no_of_vids,room_location,bDifferentFromOriginal,ChangeItemTo,print_name,long_sptext,parts_to_order,point_of_entry,type_of_lockng_system_required,was_it_locked")] Panel panel)
    {
        if (ModelState.IsValid)
        {
            data.db().Add(panel);
            await data.db().SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        return View(panel);
    }

    // GET: PANELS/Edit/5
    public async Task<IActionResult> Edit(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var panel = await data.db().Panel.FindAsync(id);
        if (panel == null)
        {
            return NotFound();
        }
        return View(panel);
    }

    // POST: PANELS/Edit/5
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(int? id, [Bind("Id,HeaderId,Guid,ContractCode,item_number,bComplete,cause_of_damage,cause_of_damage_reason_different,knockedit,knocoledit,letteredit,letter_box_pos,wedit,hedit,typeedit,thickedit,backgedit,coledit,gltext,spaccoloedit,pet_flap,pet_type,pet_magnetic,no_of_pics,no_of_photos,no_of_vids,room_location,bDifferentFromOriginal,ChangeItemTo,print_name,long_sptext,parts_to_order,point_of_entry,type_of_lockng_system_required,was_it_locked")] Panel panel)
    {
        if (id != panel.Id)
        {
            return NotFound();
        }

        if (ModelState.IsValid)
        {
            try
            {
                data.db().Update(panel);
                await data.db().SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PanelExists(panel.Id))
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
        return View(panel);
    }

    // GET: PANELS/Delete/5
    public async Task<IActionResult> Delete(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var panel = await data.db().Panel
            .FirstOrDefaultAsync(m => m.Id == id);
        if (panel == null)
        {
            return NotFound();
        }

        return View(panel);
    }

    // POST: PANELS/Delete/5
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int? id)
    {
        var panel = await data.db().Panel.FindAsync(id);
        if (panel != null)
        {
            data.db().Panel.Remove(panel);
        }

        await data.db().SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }

    private bool PanelExists(int? id)
    {
        return data.db().Panel.Any(e => e.Id == id);
    }
}
