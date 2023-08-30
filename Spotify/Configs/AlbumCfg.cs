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
    public class AlbumCfg : IEntityTypeConfiguration<Album>
    {
        public void Configure(EntityTypeBuilder<Album> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).HasMaxLength(150).IsRequired();
            builder.Property(x => x.CountOfListening).IsRequired();
            builder.Property(x => x.ArtistId).IsRequired();
            builder.Property(x => x.GenreId).IsRequired();


            builder.HasMany(x => x.Tracks).WithOne(x => x.Album).HasForeignKey(x => x.AlbumId).IsRequired();
            builder.HasOne(x => x.Artist).WithMany(x => x.Albums).HasForeignKey(x => x.ArtistId).IsRequired();
            builder.HasOne(x => x.Genre).WithMany(x => x.Albums).HasForeignKey(x => x.GenreId).IsRequired();
        }
    }
}