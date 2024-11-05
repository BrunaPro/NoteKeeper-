using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NoteKeeper.Models;

namespace NoteKeeper.Data.Map
{
    public class NoteMap : IEntityTypeConfiguration<NotesModel>
    {
       public void Configure(EntityTypeBuilder<NotesModel> builder)
        {
            builder.HasKey(x => x.id);

            builder.Property( x => x.title).IsRequired();
            builder.Property(x => x.created_at).IsRequired();   
            builder.Property(x => x.updated_at).IsRequired();
            builder.Property(x => x.delete_at).IsRequired();

        }
    }
}
