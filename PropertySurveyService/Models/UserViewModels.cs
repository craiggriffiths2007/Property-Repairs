using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;

namespace PropertyRepairs.Models
{
    public class CreateUserViewModel
    {
        [Required]
        [Display(Name = "Username")]
        public string UserName { get; set; } = default!;

        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; } = default!;

        [Display(Name = "First Name")]
        public string? FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string? LastName { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; } = default!;

        [DataType(DataType.Password)]
        [Display(Name = "Confirm Password")]
        [Compare("Password", ErrorMessage = "Passwords do not match.")]
        public string ConfirmPassword { get; set; } = default!;

        [Display(Name = "Profile Photo")]
        public IFormFile? Photo { get; set; }

        public List<ManageUserRolesViewModel> Roles { get; set; } = new();
    }

    public class EditUserViewModel
    {
        public string Id { get; set; } = default!;

        [Required]
        [Display(Name = "Username")]
        public string UserName { get; set; } = default!;

        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; } = default!;

        [Display(Name = "First Name")]
        public string? FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string? LastName { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "New Password")]
        public string? NewPassword { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm New Password")]
        [Compare("NewPassword", ErrorMessage = "Passwords do not match.")]
        public string? ConfirmNewPassword { get; set; }

        [Display(Name = "Profile Photo")]
        public IFormFile? Photo { get; set; }

        public byte[]? ExistingPhoto { get; set; }

        public List<ManageUserRolesViewModel> Roles { get; set; } = new();
    }
}
