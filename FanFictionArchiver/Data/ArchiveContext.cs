// FILE: ArchiveContext.cs
// PROJECT: FanFictionArchiver
// SOLUTION: FanFictionArchiver
// -------------------------------------------
// AUTHOR: Sean Hennessey
// DATE CREATED: 2021-05-16
// DATE MODIFIED: 2021-05-16

namespace FanFictionArchiver.Data
{
    using Microsoft.EntityFrameworkCore;
    using Model;

    public class ArchiveContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-5LMH3M9;Database=FanFictionDB;Trusted_Connection=True;");

        }

        public DbSet<Story> Stories { get; set; }
        public DbSet<Bookmark> Bookmarks { get; set; }
        public DbSet<History> HistoryData { get; set; }
    }
}