﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Spotify;

#nullable disable

namespace Spotify.Migrations
{
    [DbContext(typeof(UkrtifyDbContext))]
    partial class UkrtifyDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("PlaylistTrack", b =>
                {
                    b.Property<int>("PlaylistsId")
                        .HasColumnType("int");

                    b.Property<int>("TracksId")
                        .HasColumnType("int");

                    b.HasKey("PlaylistsId", "TracksId");

                    b.HasIndex("TracksId");

                    b.ToTable("PlaylistTrack");
                });

            modelBuilder.Entity("PlaylistUser", b =>
                {
                    b.Property<int>("PlaylistsId")
                        .HasColumnType("int");

                    b.Property<int>("UsersId")
                        .HasColumnType("int");

                    b.HasKey("PlaylistsId", "UsersId");

                    b.HasIndex("UsersId");

                    b.ToTable("PlaylistUser");
                });

            modelBuilder.Entity("Spotify.Album", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ArtistId")
                        .HasColumnType("int");

                    b.Property<int>("CountOfListening")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("GenreId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<double>("Rating")
                        .HasColumnType("float");

                    b.Property<DateTime>("ReleaseDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("ArtistId");

                    b.HasIndex("GenreId");

                    b.ToTable("Albums");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ArtistId = 1,
                            CountOfListening = 1000000,
                            Description = "The Marshall Mathers LP is the third studio album by American rapper Eminem, released on May 23, 2000, by Aftermath Entertainment and Interscope Records.",
                            GenreId = 1,
                            Name = "The Marshall Mathers LP",
                            Rating = 9.0,
                            ReleaseDate = new DateTime(2000, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 2,
                            ArtistId = 2,
                            CountOfListening = 800000,
                            Description = "Lemonade is the sixth solo studio album by American singer Beyoncé.It was released on April 23, 2016 by Parkwood Entertainment and Columbia Records.",
                            GenreId = 5,
                            Name = "Lemonade",
                            Rating = 8.0,
                            ReleaseDate = new DateTime(2016, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 3,
                            ArtistId = 3,
                            CountOfListening = 700000,
                            Description = "1989 is the fifth studio album by American singer - songwriter Taylor Swift.It was released on October 27, 2014, through Big Machine Records.",
                            GenreId = 3,
                            Name = "1989",
                            Rating = 7.0,
                            ReleaseDate = new DateTime(2014, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 4,
                            ArtistId = 4,
                            CountOfListening = 1500000,
                            Description = "Thriller is the sixth studio album by American singer Michael Jackson.It was released on November 30, 1982 by Epic Records.",
                            GenreId = 3,
                            Name = "Thriller",
                            Rating = 10.0,
                            ReleaseDate = new DateTime(1982, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 5,
                            ArtistId = 5,
                            CountOfListening = 900000,
                            Description = "Abbey Road is the eleventh studio album by the English rock band the Beatles.It was released on September 26, 1969 by Apple Records.",
                            GenreId = 2,
                            Name = "Abbey Road",
                            Rating = 9.0,
                            ReleaseDate = new DateTime(1969, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("Spotify.Artist", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("CountryId")
                        .HasColumnType("int");

                    b.Property<string>("Nickname")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<double>("OverallRating")
                        .HasColumnType("float");

                    b.Property<int>("ProducerId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.HasIndex("ProducerId");

                    b.ToTable("Artists");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BirthDate = new DateTime(1972, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CountryId = 1,
                            Nickname = "Eminem",
                            OverallRating = 10.0,
                            ProducerId = 1
                        },
                        new
                        {
                            Id = 2,
                            BirthDate = new DateTime(1981, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CountryId = 1,
                            Nickname = "Beyoncé",
                            OverallRating = 9.0,
                            ProducerId = 9
                        },
                        new
                        {
                            Id = 3,
                            BirthDate = new DateTime(1989, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CountryId = 1,
                            Nickname = "Taylor Swift",
                            OverallRating = 8.0,
                            ProducerId = 3
                        },
                        new
                        {
                            Id = 4,
                            BirthDate = new DateTime(1958, 8, 29, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CountryId = 1,
                            Nickname = "Michael Jackson",
                            OverallRating = 10.0,
                            ProducerId = 4
                        },
                        new
                        {
                            Id = 5,
                            BirthDate = new DateTime(1960, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CountryId = 4,
                            Nickname = "The Beatles",
                            OverallRating = 10.0,
                            ProducerId = 5
                        },
                        new
                        {
                            Id = 6,
                            BirthDate = new DateTime(1981, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CountryId = 1,
                            Nickname = "Justin Timberlake",
                            OverallRating = 8.0,
                            ProducerId = 6
                        },
                        new
                        {
                            Id = 7,
                            BirthDate = new DateTime(1983, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CountryId = 1,
                            Nickname = "Action Bronson",
                            OverallRating = 7.0,
                            ProducerId = 7
                        },
                        new
                        {
                            Id = 8,
                            BirthDate = new DateTime(1973, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CountryId = 1,
                            Nickname = "Nas",
                            OverallRating = 9.0,
                            ProducerId = 8
                        });
                });

            modelBuilder.Entity("Spotify.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Relaxing"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Energetic"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Motivational"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Productive"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Romantic"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Sad"
                        },
                        new
                        {
                            Id = 7,
                            Name = "Happy"
                        },
                        new
                        {
                            Id = 8,
                            Name = "Party"
                        },
                        new
                        {
                            Id = 9,
                            Name = "Meditative"
                        },
                        new
                        {
                            Id = 10,
                            Name = "Classical"
                        });
                });

            modelBuilder.Entity("Spotify.Country", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Countries");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "USA"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Ukraine"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Germany"
                        },
                        new
                        {
                            Id = 4,
                            Name = "UK"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Poland"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Japan"
                        },
                        new
                        {
                            Id = 7,
                            Name = "South Korea"
                        },
                        new
                        {
                            Id = 8,
                            Name = "China"
                        },
                        new
                        {
                            Id = 9,
                            Name = "India"
                        },
                        new
                        {
                            Id = 10,
                            Name = "Russia"
                        },
                        new
                        {
                            Id = 11,
                            Name = "France"
                        },
                        new
                        {
                            Id = 12,
                            Name = "Italy"
                        },
                        new
                        {
                            Id = 13,
                            Name = "Spain"
                        },
                        new
                        {
                            Id = 14,
                            Name = "Canada"
                        },
                        new
                        {
                            Id = 15,
                            Name = "Brazil"
                        },
                        new
                        {
                            Id = 16,
                            Name = "Mexico"
                        },
                        new
                        {
                            Id = 17,
                            Name = "Australia"
                        },
                        new
                        {
                            Id = 18,
                            Name = "New Zealand"
                        },
                        new
                        {
                            Id = 19,
                            Name = "Egypt"
                        },
                        new
                        {
                            Id = 20,
                            Name = "South Africa"
                        },
                        new
                        {
                            Id = 21,
                            Name = "Nigeria"
                        },
                        new
                        {
                            Id = 22,
                            Name = "Kenya"
                        },
                        new
                        {
                            Id = 23,
                            Name = "Turkey"
                        },
                        new
                        {
                            Id = 24,
                            Name = "Iran"
                        },
                        new
                        {
                            Id = 25,
                            Name = "Iraq"
                        },
                        new
                        {
                            Id = 26,
                            Name = "Saudi Arabia"
                        },
                        new
                        {
                            Id = 27,
                            Name = "Israel"
                        },
                        new
                        {
                            Id = 28,
                            Name = "Sweden"
                        },
                        new
                        {
                            Id = 29,
                            Name = "Norway"
                        },
                        new
                        {
                            Id = 30,
                            Name = "Finland"
                        });
                });

            modelBuilder.Entity("Spotify.Genre", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Genres");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Hip-hop"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Rock"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Pop"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Jazz"
                        },
                        new
                        {
                            Id = 5,
                            Name = "R&B"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Country"
                        },
                        new
                        {
                            Id = 7,
                            Name = "Reggae"
                        },
                        new
                        {
                            Id = 8,
                            Name = "Metal"
                        },
                        new
                        {
                            Id = 9,
                            Name = "Blues"
                        },
                        new
                        {
                            Id = 10,
                            Name = "Folk"
                        },
                        new
                        {
                            Id = 11,
                            Name = "Electronic"
                        },
                        new
                        {
                            Id = 12,
                            Name = "Soul"
                        },
                        new
                        {
                            Id = 13,
                            Name = "Funk"
                        },
                        new
                        {
                            Id = 14,
                            Name = "Punk"
                        },
                        new
                        {
                            Id = 15,
                            Name = "Classical"
                        });
                });

            modelBuilder.Entity("Spotify.Playlist", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(56)
                        .HasColumnType("nvarchar(56)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Playlists");
                });

            modelBuilder.Entity("Spotify.Producer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CountryId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.ToTable("Producers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CountryId = 1,
                            Name = "Dr. Dre"
                        },
                        new
                        {
                            Id = 2,
                            CountryId = 1,
                            Name = "Rick Rubin"
                        },
                        new
                        {
                            Id = 3,
                            CountryId = 3,
                            Name = "Max Martin"
                        },
                        new
                        {
                            Id = 4,
                            CountryId = 1,
                            Name = "Quincy Jones"
                        },
                        new
                        {
                            Id = 5,
                            CountryId = 4,
                            Name = "George Martin"
                        },
                        new
                        {
                            Id = 6,
                            CountryId = 1,
                            Name = "Timbaland"
                        },
                        new
                        {
                            Id = 7,
                            CountryId = 1,
                            Name = "The Alchemist"
                        },
                        new
                        {
                            Id = 8,
                            CountryId = 1,
                            Name = "DJ Premier"
                        },
                        new
                        {
                            Id = 9,
                            CountryId = 1,
                            Name = "Pharrell Williams"
                        },
                        new
                        {
                            Id = 10,
                            CountryId = 1,
                            Name = "Kanye West"
                        },
                        new
                        {
                            Id = 11,
                            CountryId = 1,
                            Name = "Travis Scott"
                        });
                });

            modelBuilder.Entity("Spotify.Track", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AlbumId")
                        .HasColumnType("int");

                    b.Property<int>("CountOfListening")
                        .HasColumnType("int");

                    b.Property<TimeSpan>("Duration")
                        .HasColumnType("time");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<double>("Rating")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("AlbumId");

                    b.ToTable("Tracks");
                });

            modelBuilder.Entity("Spotify.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nickname")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "zhenya24@gmail.com",
                            Nickname = "Zhenya",
                            Password = "998vcf25A"
                        },
                        new
                        {
                            Id = 2,
                            Email = "viktor1433@gmail.com",
                            Nickname = "Viktor",
                            Password = "EEag435"
                        });
                });

            modelBuilder.Entity("PlaylistTrack", b =>
                {
                    b.HasOne("Spotify.Playlist", null)
                        .WithMany()
                        .HasForeignKey("PlaylistsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Spotify.Track", null)
                        .WithMany()
                        .HasForeignKey("TracksId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PlaylistUser", b =>
                {
                    b.HasOne("Spotify.Playlist", null)
                        .WithMany()
                        .HasForeignKey("PlaylistsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Spotify.User", null)
                        .WithMany()
                        .HasForeignKey("UsersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Spotify.Album", b =>
                {
                    b.HasOne("Spotify.Artist", "Artist")
                        .WithMany("Albums")
                        .HasForeignKey("ArtistId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Spotify.Genre", "Genre")
                        .WithMany("Albums")
                        .HasForeignKey("GenreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Artist");

                    b.Navigation("Genre");
                });

            modelBuilder.Entity("Spotify.Artist", b =>
                {
                    b.HasOne("Spotify.Country", "Country")
                        .WithMany("Artists")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Spotify.Producer", "Producer")
                        .WithMany("Artists")
                        .HasForeignKey("ProducerId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Country");

                    b.Navigation("Producer");
                });

            modelBuilder.Entity("Spotify.Playlist", b =>
                {
                    b.HasOne("Spotify.Category", "Category")
                        .WithMany("Playlists")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("Spotify.Producer", b =>
                {
                    b.HasOne("Spotify.Country", "Country")
                        .WithMany("Producers")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Country");
                });

            modelBuilder.Entity("Spotify.Track", b =>
                {
                    b.HasOne("Spotify.Album", "Album")
                        .WithMany("Tracks")
                        .HasForeignKey("AlbumId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Album");
                });

            modelBuilder.Entity("Spotify.Album", b =>
                {
                    b.Navigation("Tracks");
                });

            modelBuilder.Entity("Spotify.Artist", b =>
                {
                    b.Navigation("Albums");
                });

            modelBuilder.Entity("Spotify.Category", b =>
                {
                    b.Navigation("Playlists");
                });

            modelBuilder.Entity("Spotify.Country", b =>
                {
                    b.Navigation("Artists");

                    b.Navigation("Producers");
                });

            modelBuilder.Entity("Spotify.Genre", b =>
                {
                    b.Navigation("Albums");
                });

            modelBuilder.Entity("Spotify.Producer", b =>
                {
                    b.Navigation("Artists");
                });
#pragma warning restore 612, 618
        }
    }
}
