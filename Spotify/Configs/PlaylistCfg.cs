using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Spotify
{
    public class PlaylistCfg : IEntityTypeConfiguration<Playlist>
    {
        public void Configure(EntityTypeBuilder<Playlist> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).HasMaxLength(56).IsRequired();
            builder.Property(x => x.CategoryId).IsRequired();
            builder.Property(x => x.UserId).IsRequired();

            builder.HasMany(x => x.Tracks).WithMany(x => x.Playlists);
            builder.HasOne(x => x.Category).WithMany(x => x.Playlists).HasForeignKey(x => x.CategoryId);
            builder.HasMany(x => x.Users).WithMany(x => x.Playlists);
        }
    }
}
