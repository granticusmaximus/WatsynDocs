﻿using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace WatsynDocs.Models
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        [StringLength(100)]
        [Display(Name = "Full Name")]
        public string FullName { get; set; }

        [StringLength(250)]
        [Display(Name = "Profile Picture")]
        public string ProfilePictureUrl { get; set; } = "/images/empty-profile.png";

        [StringLength(250)]
        [Display(Name = "Wallpaper Picture")]
        public string WallpaperPictureUrl { get; set; } = "/images/wallpaper1.jpg";

        public bool isSuperAdmin { get; set; } = false;
        public bool IsCustomer { get; set; } = false;
        public bool IsSupportAgent { get; set; } = false;
        public bool IsSupportEngineer { get; set; } = false;
    }
}
