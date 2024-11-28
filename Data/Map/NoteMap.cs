using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NoteKeeper.Models;

namespace NoteKeeper.Data.Map
{
    public class NoteMap : IEntityTypeConfiguration<NotesModel>
    {
       public void Configure(EntityTypeBuilder<NotesModel> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property( x => x.Title).IsRequired();
            builder.Property(x => x.Created_at).IsRequired();   
            builder.Property(x => x.Updated_at).IsRequired();
            builder.Property(x => x.Delete_at).IsRequired();

        }
    }
}
