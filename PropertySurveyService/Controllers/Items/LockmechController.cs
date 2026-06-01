
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PropertySurveyService.Models;
using PropertySurveyService.Data;
using PropertySurveyService.ViewModels;

public class LockmechController : Controller
{
    private readonly AppDBContext _context;

    public LockmechController(AppDBContext context)
    {
        _context = context;
    }

    // GET: LOCKMECHS
    public async Task<IActionResult> Index()    
    {
        return View(await _context.Lockmech.ToListAsync());
    }

    // GET: LOCKMECHS/Details/5
    public async Task<IActionResult> Details(int? id)
    {
        ItemDetailsViewModel viewModel = new ItemDetailsViewModel();

        if (id == null)
        {
            return NotFound();
        }

        var lockmech = await _context.Lockmech
            .FirstOrDefaultAsync(m => m.Id == id);
        if (lockmech == null)
        {
            return NotFound();
        }

        viewModel.Lockmech = lockmech;

        string pattern = $"{lockmech.ContractCode:00000000}____{lockmech.item_number:000}%"; // using _ as a wildcard ( would have been cAZ and dAZ )

        var photoimages = _context.Images
            .Where(x => EF.Functions.Like(x.Filename, pattern))
            .ToList();

        viewModel.Images = photoimages ?? new List<PhotoImage>();

        return View(viewModel);
    }

    // GET: LOCKMECHS/Create
    public IActionResult Create()
    {
        return View();
    }

    // POST: LOCKMECHS/Create
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create([Bind("Id,HeaderId,Guid,ContractCode,item_number,bComplete,comments,point_of_entry,type_of_lockng_system_required,was_it_locked,no_of_pics,no_of_photos,bMulti,item,locking_make,locking_codes,bDoorComplete,bWindowComplete,lock_colour,pagenum,bDifferentFromOriginal,ChangeItemTo,print_name,COD_Code,cause_of_damage,cause_of_damage_reason_different,GearBox,no_of_vids,left_bolt,right_bolt,parts_to_order,bLockComplete,l_size1,l_size2,l_sizeA,l_sizeB,l_sizeC,l_sizeD,l_sizeE,l_sizeF,l_sizeG,l_num,l_fpos1,l_fpos2,l_fpos3,l_fpos4,l_fpos5,l_fpos6,l_fpos7,lock_position,l_itype1,l_itype2,l_itype3,l_itype4,l_itype5,l_itype6,l_itype7,long_comments")] Lockmech lockmech)
    {
        if (ModelState.IsValid)
        {
            _context.Add(lockmech);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        return View(lockmech);
    }

    // GET: LOCKMECHS/Edit/5
    public async Task<IActionResult> Edit(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var lockmech = await _context.Lockmech.FindAsync(id);
        if (lockmech == null)
        {
            return NotFound();
        }
        return View(lockmech);
    }

    // POST: LOCKMECHS/Edit/5
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(int? id, [Bind("Id,HeaderId,Guid,ContractCode,item_number,bComplete,comments,point_of_entry,type_of_lockng_system_required,was_it_locked,no_of_pics,no_of_photos,bMulti,item,locking_make,locking_codes,bDoorComplete,bWindowComplete,lock_colour,pagenum,bDifferentFromOriginal,ChangeItemTo,print_name,COD_Code,cause_of_damage,cause_of_damage_reason_different,GearBox,no_of_vids,left_bolt,right_bolt,parts_to_order,bLockComplete,l_size1,l_size2,l_sizeA,l_sizeB,l_sizeC,l_sizeD,l_sizeE,l_sizeF,l_sizeG,l_num,l_fpos1,l_fpos2,l_fpos3,l_fpos4,l_fpos5,l_fpos6,l_fpos7,lock_position,l_itype1,l_itype2,l_itype3,l_itype4,l_itype5,l_itype6,l_itype7,long_comments")] Lockmech lockmech)
    {
        if (id != lockmech.Id)
        {
            return NotFound();
        }

        if (ModelState.IsValid)
        {
            try
            {
                _context.Update(lockmech);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LockmechExists(lockmech.Id))
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
        return View(lockmech);
    }

    // GET: LOCKMECHS/Delete/5
    public async Task<IActionResult> Delete(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var lockmech = await _context.Lockmech
            .FirstOrDefaultAsync(m => m.Id == id);
        if (lockmech == null)
        {
            return NotFound();
        }

        return View(lockmech);
    }

    // POST: LOCKMECHS/Delete/5
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int? id)
    {
        var lockmech = await _context.Lockmech.FindAsync(id);
        if (lockmech != null)
        {
            _context.Lockmech.Remove(lockmech);
        }

        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }

    private bool LockmechExists(int? id)
    {
        return _context.Lockmech.Any(e => e.Id == id);
    }
}
