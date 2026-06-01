
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PropertySurveyService.Models;
using PropertySurveyService.Data;
using PropertySurveyService.ViewModels;
public class PanelController : Controller
{
    private readonly AppDBContext _context;

    public PanelController(AppDBContext context)
    {
        _context = context;
    }

    // GET: PANELS
    public async Task<IActionResult> Index()    
    {
        return View(await _context.Panel.ToListAsync());
    }

    // GET: PANELS/Details/5
    public async Task<IActionResult> Details(int? id)
    {
        ItemDetailsViewModel viewModel = new ItemDetailsViewModel();

        if (id == null)
        {
            return NotFound();
        }

        var panel = await _context.Panel
            .FirstOrDefaultAsync(m => m.Id == id);
        if (panel == null)
        {
            return NotFound();
        }

        viewModel.Panel = panel;

        string pattern = $"{panel.ContractCode:00000000}____{panel.item_number:000}%"; // using _ as a wildcard ( would have been cAZ and dAZ )

        var photoimages = _context.Images
            .Where(x => EF.Functions.Like(x.Filename, pattern))
            .ToList();

        viewModel.Images = photoimages ?? new List<PhotoImage>();

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
            _context.Add(panel);
            await _context.SaveChangesAsync();
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

        var panel = await _context.Panel.FindAsync(id);
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
                _context.Update(panel);
                await _context.SaveChangesAsync();
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

        var panel = await _context.Panel
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
        var panel = await _context.Panel.FindAsync(id);
        if (panel != null)
        {
            _context.Panel.Remove(panel);
        }

        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }

    private bool PanelExists(int? id)
    {
        return _context.Panel.Any(e => e.Id == id);
    }
}
