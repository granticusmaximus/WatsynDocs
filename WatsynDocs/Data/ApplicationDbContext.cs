using WatsynDocs.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace WatsynDocs.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        #region DbSets
        public DbSet<ApplicationUser> ApplicationUser { get; set; }
        public DbSet<Document> Document { get; set; }
        public DbSet<Keynote> Keynote { get; set; }
        public DbSet<Spreadsheet> Spreadsheet { get; set; }
        public DbSet<Todo> Todo { get; set; }
        #endregion
    }
}