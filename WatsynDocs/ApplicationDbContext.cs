using System;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WatsynDocs.Models;

namespace WatsynDocs
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }

        #region DbSets
        public DbSet<ApplicationUser> ApplicationUser { get; set; }
        public DbSet<Document> Document { get; set; }
        public DbSet<Keynote> Keynote { get; set; }
        public DbSet<Spreadsheet> Spreadsheet { get; set; }
        #endregion
    }
}