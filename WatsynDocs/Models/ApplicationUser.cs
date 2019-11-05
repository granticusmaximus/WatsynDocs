using System;
using Microsoft.AspNetCore.Identity;

namespace WatsynDocs.Models
{
    public partial class ApplicationUser : IdentityUser
    {
        //override identity user, add new column
        public bool isSuperAdmin { get; set; } = false;

    }
}
