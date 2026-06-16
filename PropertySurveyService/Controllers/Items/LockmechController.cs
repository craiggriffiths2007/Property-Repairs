
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PropertySurveyService.Models;
using PropertySurveyService.Data;
using PropertySurveyService.ViewModels;

public class LockmechController : Controller
{
    private readonly IMainRepo data;

    public LockmechController(IMainRepo _data)
    {
        data = _data;
    }

    // GET: LOCKMECHS
    public async Task<IActionResult> Index()    
    {
        return View(await data.db().Lockmech.ToListAsync());
    }

    // GET: LOCKMECHS/Details/5
    public async Task<IActionResult> Details(int? id)
    {
        ItemDetailsViewModel viewModel = new ItemDetailsViewModel();

        if (id == null)
        {
            return NotFound();
        }

        var lockmech = await data.db().Lockmech
            .FirstOrDefaultAsync(m => m.Id == id);
        if (lockmech == null)
        {
            return NotFound();
        }

        viewModel.Lockmech = lockmech;

        viewModel.Images = data.GetSurveyItemImages(lockmech.ContractCode, lockmech.item_number);

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
            data.db().Add(lockmech);
            await data.db().SaveChangesAsync();
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

        var lockmech = await data.db().Lockmech.FindAsync(id);
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
                data.db().Update(lockmech);
                await data.db().SaveChangesAsync();
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

        var lockmech = await data.db().Lockmech
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
        var lockmech = await data.db().Lockmech.FindAsync(id);
        if (lockmech != null)
        {
            data.db().Lockmech.Remove(lockmech);
        }

        await data.db().SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }

    private bool LockmechExists(int? id)
    {
        return data.db().Lockmech.Any(e => e.Id == id);
    }
}
