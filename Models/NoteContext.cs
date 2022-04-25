using Microsoft.EntityFrameworkCore;

namespace Notes.Models
{
    public class NoteContext : DbContext
    {
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=notesdb;Trusted_Connection=True;");
        }
        public DbSet<Note> Notes { get; set; }
    }
}
