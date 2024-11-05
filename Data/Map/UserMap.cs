using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NoteKeeper.Models;

namespace NoteKeeper.Data.Map
{
    public class UserMap : IEntityTypeConfiguration<UserModel>
    {
       public void Configure(EntityTypeBuilder<UserModel> builder)
        {
            builder.HasKey(x => x.id);
            builder.Property(x => x.userName).IsRequired().HasMaxLength(255);
            builder.Property(x => x.email).IsRequired().HasMaxLength(150);
            builder.Property(x => x.password).IsRequired().HasMaxLength(20);


        }
    }
}
