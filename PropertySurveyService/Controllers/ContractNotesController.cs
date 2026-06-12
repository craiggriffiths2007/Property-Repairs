using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PropertySurveyService.Data;
using PropertySurveyService.Models;

namespace PropertySurveyService.Controllers
{
    public class ContractNotesController : Controller
    {
        private readonly AppDBContext _context;

        public ContractNotesController(AppDBContext context)
        {
            _context = context;
        }

        // GET: ContractNotesController
        public async Task<IActionResult> Index()
        {

            return View(await _context.ContractNotes.ToListAsync());
        }

        // GET: ContractNotesController/Details/5
        public ActionResult Details(int id)
        {


            return View();
        }

        // GET: ContractNotesController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ContractNotesController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ContractNotesController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ContractNotesController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ContractNotesController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ContractNotesController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
