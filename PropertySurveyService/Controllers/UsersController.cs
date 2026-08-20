using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PropertyRepairs.Data;
using PropertyRepairs.Models;

namespace PropertyRepairs.Controllers
{
    [Authorize(Roles = "Admin,SuperAdmin")]
    public class UsersController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public UsersController(UserManager<AppUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
        }

        // GET: Users
        public async Task<IActionResult> Index(int page = 1)
        {
            const int pageSize = 10;
            var totalCount = await _userManager.Users.CountAsync();
            var totalPages = (int)System.Math.Ceiling(totalCount / (double)pageSize);
            if (page < 1) page = 1;
            if (page > totalPages && totalPages > 0) page = totalPages;

            var users = await _userManager.Users
                .OrderBy(u => u.UserName)
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .ToListAsync();

            var userList = new List<UserRolesViewModel>();
            foreach (var user in users)
            {
                userList.Add(new UserRolesViewModel
                {
                    UserId = user.Id,
                    UserName = user.UserName,
                    Email = user.Email,
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    Roles = await _userManager.GetRolesAsync(user),
                    ProfilePicture = user.ProfilePicture
                });
            }

            ViewBag.PageNumber = page;
            ViewBag.TotalPages = totalPages;
            ViewBag.PageSize = pageSize;

            return View(userList);
        }

        // GET: Users/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (string.IsNullOrEmpty(id))
                return NotFound();

            var user = await _userManager.FindByIdAsync(id);
            if (user == null)
                return NotFound();

            var model = new UserRolesViewModel
            {
                UserId = user.Id,
                UserName = user.UserName,
                Email = user.Email,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Roles = await _userManager.GetRolesAsync(user),
                //ProfilePicture = user.ProfilePicture
            };
            return View(model);
        }

        // GET: Users/Create
        public async Task<IActionResult> Create()
        {
            var model = new CreateUserViewModel
            {
                Roles = await GetAllRoles()
            };
            return View(model);
        }

        // POST: Users/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CreateUserViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = new AppUser
                {
                    UserName = model.UserName,
                    Email = model.Email,
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    EmailConfirmed = true
                };

                if (model.Photo != null && model.Photo.Length > 0)
                {
                    using var ms = new MemoryStream();
                    await model.Photo.CopyToAsync(ms);
                    //user.ProfilePicture = ms.ToArray();
                }

                var result = await _userManager.CreateAsync(user, model.Password);
                if (result.Succeeded)
                {
                    var selectedRoles = model.Roles.Where(r => r.Selected).Select(r => r.RoleName).ToList();
                    if (selectedRoles.Any())
                    {
                        await _userManager.AddToRolesAsync(user, selectedRoles);
                    }
                    return RedirectToAction(nameof(Index));
                }
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
            }
            model.Roles = await GetAllRoles();
            return View(model);
        }

        // GET: Users/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (string.IsNullOrEmpty(id))
                return NotFound();

            var user = await _userManager.FindByIdAsync(id);
            if (user == null)
                return NotFound();

            var roles = await GetAllRoles();
            var userRoles = await _userManager.GetRolesAsync(user);
            foreach (var role in roles)
            {
                role.Selected = userRoles.Contains(role.RoleName);
            }

            var model = new EditUserViewModel
            {
                Id = user.Id,
                UserName = user.UserName ?? "",
                Email = user.Email ?? "",
                FirstName = user.FirstName,
                LastName = user.LastName,
                Roles = roles,
                //ExistingPhoto = user.ProfilePicture
            };
            return View(model);
        }

        // POST: Users/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, EditUserViewModel model)
        {
            if (id != model.Id)
                return NotFound();

            if (ModelState.IsValid)
            {
                var user = await _userManager.FindByIdAsync(id);
                if (user == null)
                    return NotFound();

                user.UserName = model.UserName;
                user.Email = model.Email;
                user.FirstName = model.FirstName;
                user.LastName = model.LastName;

                if (model.Photo != null && model.Photo.Length > 0)
                {
                    using var ms = new MemoryStream();
                    await model.Photo.CopyToAsync(ms);
                    //user.ProfilePicture = ms.ToArray();
                }

                var result = await _userManager.UpdateAsync(user);
                if (result.Succeeded)
                {
                    // Reset password if a new one was provided
                    if (!string.IsNullOrEmpty(model.NewPassword))
                    {
                        var token = await _userManager.GeneratePasswordResetTokenAsync(user);
                        var passwordResult = await _userManager.ResetPasswordAsync(user, token, model.NewPassword);
                        if (!passwordResult.Succeeded)
                        {
                            foreach (var error in passwordResult.Errors)
                            {
                                ModelState.AddModelError("", error.Description);
                            }
                            return View(model);
                        }
                    }

                    var currentRoles = await _userManager.GetRolesAsync(user);
                    await _userManager.RemoveFromRolesAsync(user, currentRoles);

                    var selectedRoles = model.Roles.Where(r => r.Selected).Select(r => r.RoleName).ToList();
                    if (selectedRoles.Any())
                    {
                        await _userManager.AddToRolesAsync(user, selectedRoles);
                    }
                    return RedirectToAction(nameof(Index));
                }
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
            }
            return View(model);
        }

        // GET: Users/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (string.IsNullOrEmpty(id))
                return NotFound();

            var user = await _userManager.FindByIdAsync(id);
            if (user == null)
                return NotFound();

            var model = new UserRolesViewModel
            {
                UserId = user.Id,
                UserName = user.UserName,
                Email = user.Email,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Roles = await _userManager.GetRolesAsync(user),
                //ProfilePicture = user.ProfilePicture
            };
            return View(model);
        }

        // POST: Users/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var user = await _userManager.FindByIdAsync(id);
            if (user != null)
            {
                await _userManager.DeleteAsync(user);
            }
            return RedirectToAction(nameof(Index));
        }

        private async Task<List<ManageUserRolesViewModel>> GetAllRoles()
        {
            var roles = await _roleManager.Roles.ToListAsync();
            return roles.Select(r => new ManageUserRolesViewModel
            {
                RoleId = r.Id,
                RoleName = r.Name ?? "",
                Selected = false
            }).ToList();
        }
    }
}
