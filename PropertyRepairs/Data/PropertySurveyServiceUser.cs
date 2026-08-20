using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;


namespace PropertyRepairs.Data
{
    // Add profile data for application users by adding properties to the PropertyRepairsUser class
    public class AppUser : IdentityUser
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }

        public int UsernameChangeLimit { get; set; } = 10;
        public byte[]? ProfilePicture { get; set; } = Array.Empty<byte>();
    }

}
