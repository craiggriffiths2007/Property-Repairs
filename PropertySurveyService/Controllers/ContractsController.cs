using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PropertySurveyService.Data;
using PropertySurveyService.Models;
using PropertySurveyService.ViewModels;


public class ContractsController : Controller
{
    private readonly AppDBContext _context;

    public ContractsController(AppDBContext context)
    {
        _context = context;
    }

    // GET: CONTRACTS (paginated)
    public async Task<IActionResult> Index(int page = 1)
    {
        const int pageSize = 10;
        var totalCount = await _context.Contract.CountAsync();
        var totalPages = (int)Math.Ceiling(totalCount / (double)pageSize);

        if (page < 1) page = 1;
        if (page > totalPages && totalPages > 0) page = totalPages;

        var contracts = await _context.Contract
            .Include(c => c.Customer)
            .OrderBy(c => c.Id)
            .Skip((page - 1) * pageSize)
            .Take(pageSize)
            .OrderByDescending(c => c.IncidentDate)
            .ToListAsync();

        ViewBag.PageNumber = page;
        ViewBag.TotalPages = totalPages;
        ViewBag.PageSize = pageSize;

        return View(contracts);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> AddNote([Bind("Id,ContractCode")] Contract contract, string note)
    {

        ContractNote contractNote = new ContractNote();

        contractNote.ContractCode = contract.ContractCode;
        contractNote.DateAdded = DateTime.Now;
        contractNote.Note = note;
        contractNote.AddedBy = User.Identity.Name;

        _context.Add(contractNote);
        await _context.SaveChangesAsync();

        return RedirectToAction(nameof(Details), new { id = contract.Id });
    }

    // GET: CONTRACTS/Details/5
    public async Task<IActionResult> Details(int? id)
    {
        ContractDetailsViewModel viewModel = new ContractDetailsViewModel();

        if (id == null)
        {
            return NotFound();
        }

        var contract = await _context.Contract.Include(c => c.Customer)
            .FirstOrDefaultAsync(m => m.Id == id);
        if (contract == null)
        {
            return NotFound();
        }

        viewModel.ContractNotes = _context.ContractNotes.Where(n => n.ContractCode == contract.ContractCode).OrderByDescending(n => n.DateAdded).ToList();

        viewModel.Contract = contract;
        return View(viewModel);
    }

    // GET: CONTRACTS/Create
    public IActionResult Create()
    {
        // Populate customer dropdown for the Create view.
        // The view is expected to use ViewData["CustomerId"] for the select list.
        // Assumes _context and a Customers DbSet with Id and Name properties exist.
        var customers = _context.Customer
            .OrderBy(c => c.Name)
            .Select(c => new { c.Id, c.Name })
            .ToList();

        ViewData["Customers"] = new SelectList(customers, "Id", "Name");

        return View();
    }

    // POST: CONTRACTS/Create
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create([Bind("Id,ContractCode,CustomerId,Customer,IncidentDate,DamageDescription,CauseOfDamage")] Contract contract)
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
        PopulateCustomersDropDownList(contract.CustomerId);
        return View(contract);
    }

    // POST: CONTRACTS/Edit/5
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(int? id, [Bind("Id,ContractCode,CustomerId,Customer,IncidentDate,DamageDescription,CauseOfDamage")] Contract contract)
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
        PopulateCustomersDropDownList(contract.CustomerId);
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
    private void PopulateCustomersDropDownList(object? selectedCustomer = null)
    {
        var customers = _context.Customer.OrderBy(c => c.Name)
            .Select(c => new { c.Id, c.Name });
        ViewBag.Customers = new SelectList(customers, "Id", "Name", selectedCustomer);
    }
}
