
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PropertySurveyService.Models;
using PropertySurveyService.Data;

public class ContractsController : Controller
{
    private readonly AppDBContext _context;

    public ContractsController(AppDBContext context)
    {
        _context = context;
    }

    // GET: CONTRACTS
    public async Task<IActionResult> Index()    
    {
        return View(await _context.Contract.ToListAsync());
    }

    // GET: CONTRACTS/Details/5
    public async Task<IActionResult> Details(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var contract = await _context.Contract
            .FirstOrDefaultAsync(m => m.Id == id);
        if (contract == null)
        {
            return NotFound();
        }

        return View(contract);
    }

    // GET: CONTRACTS/Create
    public IActionResult Create()
    {
        return View();
    }

    // POST: CONTRACTS/Create
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create([Bind("Id,ContractCode,CustomerId,Customer,IncidentAdded,DamageDescription,CauseOfDamage")] Contract contract)
    {
        if (ModelState.IsValid)
        {
            _context.Add(contract);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        return View(contract);
    }

    // GET: CONTRACTS/Edit/5
    public async Task<IActionResult> Edit(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var contract = await _context.Contract.FindAsync(id);
        if (contract == null)
        {
            return NotFound();
        }
        return View(contract);
    }

    // POST: CONTRACTS/Edit/5
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(int? id, [Bind("Id,ContractCode,CustomerId,Customer,IncidentAdded,DamageDescription,CauseOfDamage")] Contract contract)
    {
        if (id != contract.Id)
        {
            return NotFound();
        }

        if (ModelState.IsValid)
        {
            try
            {
                _context.Update(contract);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ContractExists(contract.Id))
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
        return View(contract);
    }

    // GET: CONTRACTS/Delete/5
    public async Task<IActionResult> Delete(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var contract = await _context.Contract
            .FirstOrDefaultAsync(m => m.Id == id);
        if (contract == null)
        {
            return NotFound();
        }

        return View(contract);
    }

    // POST: CONTRACTS/Delete/5
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int? id)
    {
        var contract = await _context.Contract.FindAsync(id);
        if (contract != null)
        {
            _context.Contract.Remove(contract);
        }

        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }

    private bool ContractExists(int? id)
    {
        return _context.Contract.Any(e => e.Id == id);
    }
}
