using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PropertySurveyService.Data;
using PropertySurveyService.Models;
using PropertySurveyService.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PropertySurveyService.Controllers
{
    public class FrameTablesController : Controller
    {
        private readonly AppDBContext _context;

        public FrameTablesController(AppDBContext context)
        {
            _context = context;
        }

        // GET: FrameTables
        public async Task<IActionResult> Index()
        {
            return View(await _context.ItemTable.ToListAsync());
        }

        // GET: FrameTables/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            var viewModel = new ItemDetailsViewModel();


            if (id == null || _context.ItemTable == null)
            {
                return NotFound();
            }

            viewModel.Frame = await _context.ItemTable
                .FirstOrDefaultAsync(m => m.Id == id);
            if (viewModel.Frame == null)
            {
                return NotFound();
            }

            List<PhotoImage> photoimages = _context.Images.Where(x => x.Filename.Substring(0, 8) == viewModel.Frame.udi_cont &&
            x.Filename.Substring(12, 3) == viewModel.Frame.item_number.ToString("000")).ToList();


            viewModel.Images = photoimages;

            return View(viewModel);
        }

        // GET: FrameTables/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: FrameTables/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,HeaderId,Guid,udi_cont,item_number,bComplete,bRepair,material,opening_type,cosmetic_damage,additional_locks,gaskets,gaskets_text,handles_req,handles_text,replace_reason,replace_explain,cause_of_damage,cause_of_damage_reason_different,internal_width,internal_height,brick_width,brick_height,opens,locking_type,letter_box,letter_box_pos,pet_flap,pet_type,pet_magnetic,spacer_thickness,spacer_color,glass_type,glass_pattern,special_glass,bNewLockingMech,bLockComplete,bHandleDrawingComplete,no_of_pics,no_of_photos,no_of_vids,docl,room_location,bDoorComplete,bWindowComplete,lock_make,lock_codes,GearBox,left_bolt,right_bolt,collect_and_copy,temporary,parts_to_order,is_a_flat,point_of_entry,type_of_lockng_system_required,was_it_locked,back_to_back_spacer_width,back_to_back_spacer_height,l_num,lock_position,glass_complete,replace_glass,panel_complete,replace_panel,l_size1,l_size2,l_sizeA,l_sizeB,l_sizeC,l_sizeD,l_sizeE,l_sizeF,l_sizeG,l_fpos1,l_fpos2,l_fpos3,l_fpos4,l_fpos5,l_fpos6,l_fpos7,l_itype1,l_itype2,l_itype3,l_itype4,l_itype5,l_itype6,l_itype7,lead_sizeA,lead_sizeB,lead_sizeC,lead_sizeD,lead_CWidth,lead_CHeight,lead_anti_rattle,lead_thickness,lead_sod,lead_type,lead_bDiamondComplete,lead_bGeorgianComplete,lead_bBarComplete,lead_CWidthf,lead_CHeightf,lead_CWidths,lead_CHeights,timber_wood,timber_frame_wood,item_summary,bFencer,doc_l_compliant_reason,doc_l_compliant")] ItemTable frameTable)
        {
            if (ModelState.IsValid)
            {
                _context.Add(frameTable);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(frameTable);
        }

        // GET: FrameTables/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var frameTable = await _context.ItemTable.FindAsync(id);
            if (frameTable == null)
            {
                return NotFound();
            }
            return View(frameTable);
        }

        // POST: FrameTables/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,HeaderId,Guid,udi_cont,item_number,bComplete,bRepair,material,opening_type,cosmetic_damage,additional_locks,gaskets,gaskets_text,handles_req,handles_text,replace_reason,replace_explain,cause_of_damage,cause_of_damage_reason_different,internal_width,internal_height,brick_width,brick_height,opens,locking_type,letter_box,letter_box_pos,pet_flap,pet_type,pet_magnetic,spacer_thickness,spacer_color,glass_type,glass_pattern,special_glass,bNewLockingMech,bLockComplete,bHandleDrawingComplete,no_of_pics,no_of_photos,no_of_vids,docl,room_location,bDoorComplete,bWindowComplete,lock_make,lock_codes,GearBox,left_bolt,right_bolt,collect_and_copy,temporary,parts_to_order,is_a_flat,point_of_entry,type_of_lockng_system_required,was_it_locked,back_to_back_spacer_width,back_to_back_spacer_height,l_num,lock_position,glass_complete,replace_glass,panel_complete,replace_panel,l_size1,l_size2,l_sizeA,l_sizeB,l_sizeC,l_sizeD,l_sizeE,l_sizeF,l_sizeG,l_fpos1,l_fpos2,l_fpos3,l_fpos4,l_fpos5,l_fpos6,l_fpos7,l_itype1,l_itype2,l_itype3,l_itype4,l_itype5,l_itype6,l_itype7,lead_sizeA,lead_sizeB,lead_sizeC,lead_sizeD,lead_CWidth,lead_CHeight,lead_anti_rattle,lead_thickness,lead_sod,lead_type,lead_bDiamondComplete,lead_bGeorgianComplete,lead_bBarComplete,lead_CWidthf,lead_CHeightf,lead_CWidths,lead_CHeights,timber_wood,timber_frame_wood,item_summary,bFencer,doc_l_compliant_reason,doc_l_compliant")] ItemTable frameTable)
        {
            if (id != frameTable.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(frameTable);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FrameTableExists(frameTable.Id))
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
            return View(frameTable);
        }

        // GET: FrameTables/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var frameTable = await _context.ItemTable
                .FirstOrDefaultAsync(m => m.Id == id);
            if (frameTable == null)
            {
                return NotFound();
            }

            return View(frameTable);
        }

        // POST: FrameTables/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var frameTable = await _context.ItemTable.FindAsync(id);
            if (frameTable != null)
            {
                _context.ItemTable.Remove(frameTable);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FrameTableExists(int id)
        {
            return _context.ItemTable.Any(e => e.Id == id);
        }
    }
}
