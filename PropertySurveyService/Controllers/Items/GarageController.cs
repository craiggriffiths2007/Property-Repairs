
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PropertySurveyService.Models;
using PropertySurveyService.Data;
using PropertySurveyService.ViewModels;

public class GarageController : Controller
{
    private readonly IMainRepo data;

    public GarageController(IMainRepo _data)
    {
        data = _data;
    }

    // GET: GARAGES
    public async Task<IActionResult> Index()    
    {
        return View(await data.db().Garage.ToListAsync());
    }

    // GET: GARAGES/Details/5
    public async Task<IActionResult> Details(int? id)
    {
        ItemDetailsViewModel viewModel = new ItemDetailsViewModel();

        if (id == null)
        {
            return NotFound();
        }

        var garage = await data.db().Garage
            .FirstOrDefaultAsync(m => m.Id == id);
        if (garage == null)
        {
            return NotFound();
        }
        viewModel.Garage = garage;

        viewModel.Images = data.GetSurveyItemImages(garage.ContractCode, garage.item_number);

        return View(viewModel);
    }

    // GET: GARAGES/Create
    public IActionResult Create()
    {
        return View();
    }

    // POST: GARAGES/Create
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create([Bind("Id,HeaderId,Guid,ContractCode,item_number,opening_direction,cause_of_damage,cause_of_damage_reason_different,door_fits_into,new_subframe_req,obstruction_outside_b,obstruction_outside,obstruction_inside_b,obstruction_inside,actual_door_width,actual_door_height,frame_fix_type,type_of_garage,new_electric_operator_req,side_size_A,side_size_B,side_size_C,side_size_D,side_size_E,side_size_F,side_size_G,side_timber_1,side_timber_2,plan_size_A,plan_size_B,plan_size_C1,plan_size_C2,plan_size_D,plan_timber_1,plan_timber_2,color,opening_type,finish,power_points,electric_door,handle_outside,other_access,need_safety_release,no_of_pics,no_of_photos,insulated,door_stuck_shut,motor_position,no_of_vids,bDifferentFromOriginal,ChangeItemTo,print_name,long_comments,bComplete,door_within_perimeter,socket_within_1m,wire_type,colour_match_roll_box,additional_drawn,roller_door_type,roller_box_type,parts_to_order,point_of_entry,type_of_lockng_system_required,was_it_locked,where_is_garage")] Garage garage)
    {
        if (ModelState.IsValid)
        {
            data.db().Add(garage);
            await data.db().SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        return View(garage);
    }

    // GET: GARAGES/Edit/5
    public async Task<IActionResult> Edit(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var garage = await data.db().Garage.FindAsync(id);
        if (garage == null)
        {
            return NotFound();
        }
        return View(garage);
    }

    // POST: GARAGES/Edit/5
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(int? id, [Bind("Id,HeaderId,Guid,ContractCode,item_number,opening_direction,cause_of_damage,cause_of_damage_reason_different,door_fits_into,new_subframe_req,obstruction_outside_b,obstruction_outside,obstruction_inside_b,obstruction_inside,actual_door_width,actual_door_height,frame_fix_type,type_of_garage,new_electric_operator_req,side_size_A,side_size_B,side_size_C,side_size_D,side_size_E,side_size_F,side_size_G,side_timber_1,side_timber_2,plan_size_A,plan_size_B,plan_size_C1,plan_size_C2,plan_size_D,plan_timber_1,plan_timber_2,color,opening_type,finish,power_points,electric_door,handle_outside,other_access,need_safety_release,no_of_pics,no_of_photos,insulated,door_stuck_shut,motor_position,no_of_vids,bDifferentFromOriginal,ChangeItemTo,print_name,long_comments,bComplete,door_within_perimeter,socket_within_1m,wire_type,colour_match_roll_box,additional_drawn,roller_door_type,roller_box_type,parts_to_order,point_of_entry,type_of_lockng_system_required,was_it_locked,where_is_garage")] Garage garage)
    {
        if (id != garage.Id)
        {
            return NotFound();
        }

        if (ModelState.IsValid)
        {
            try
            {
                data.db().Update(garage);
                await data.db().SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!GarageExists(garage.Id))
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
        return View(garage);
    }

    // GET: GARAGES/Delete/5
    public async Task<IActionResult> Delete(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var garage = await data.db().Garage
            .FirstOrDefaultAsync(m => m.Id == id);
        if (garage == null)
        {
            return NotFound();
        }

        return View(garage);
    }

    // POST: GARAGES/Delete/5
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int? id)
    {
        var garage = await data.db().Garage.FindAsync(id);
        if (garage != null)
        {
            data.db().Garage.Remove(garage);
        }

        await data.db().SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }

    private bool GarageExists(int? id)
    {
        return data.db().Garage.Any(e => e.Id == id);
    }
}
