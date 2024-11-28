using Microsoft.EntityFrameworkCore;
using NoteKeeper.Models;

namespace NoteKeeper.Data
{
    public class NoteSystemDBContext : DbContext
    {
        public NoteSystemDBContext(DbContextOptions<NoteSystemDBContext> options)
          : base(options)
        { }    

        // represet tables on database 
        public DbSet<NotesModel> Notes { get; set; }
        public DbSet<UserModel> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.ApplyConfiguration(new NoteMap());
           // modelBuilder.ApplyConfiguration(new UserMap()); 
            base.OnModelCreating(modelBuilder);

        }
            
    }
}
