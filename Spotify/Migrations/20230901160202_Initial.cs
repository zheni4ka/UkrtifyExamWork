using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Spotify.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Genres",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genres", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nickname = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Playlists",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(56)", maxLength: 56, nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Playlists", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Playlists_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Producers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    CountryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Producers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Producers_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PlaylistUser",
                columns: table => new
                {
                    PlaylistsId = table.Column<int>(type: "int", nullable: false),
                    UsersId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlaylistUser", x => new { x.PlaylistsId, x.UsersId });
                    table.ForeignKey(
                        name: "FK_PlaylistUser_Playlists_PlaylistsId",
                        column: x => x.PlaylistsId,
                        principalTable: "Playlists",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PlaylistUser_Users_UsersId",
                        column: x => x.UsersId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Artists",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nickname = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CountryId = table.Column<int>(type: "int", nullable: false),
                    OverallRating = table.Column<double>(type: "float", nullable: false),
                    ProducerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Artists", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Artists_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Artists_Producers_ProducerId",
                        column: x => x.ProducerId,
                        principalTable: "Producers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Albums",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReleaseDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GenreId = table.Column<int>(type: "int", nullable: false),
                    Rating = table.Column<double>(type: "float", nullable: false),
                    CountOfListening = table.Column<int>(type: "int", nullable: false),
                    ArtistId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Albums", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Albums_Artists_ArtistId",
                        column: x => x.ArtistId,
                        principalTable: "Artists",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Albums_Genres_GenreId",
                        column: x => x.GenreId,
                        principalTable: "Genres",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tracks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Duration = table.Column<TimeSpan>(type: "time", nullable: false),
                    Rating = table.Column<double>(type: "float", nullable: false),
                    AlbumId = table.Column<int>(type: "int", nullable: false),
                    CountOfListening = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tracks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tracks_Albums_AlbumId",
                        column: x => x.AlbumId,
                        principalTable: "Albums",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PlaylistTrack",
                columns: table => new
                {
                    PlaylistsId = table.Column<int>(type: "int", nullable: false),
                    TracksId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlaylistTrack", x => new { x.PlaylistsId, x.TracksId });
                    table.ForeignKey(
                        name: "FK_PlaylistTrack_Playlists_PlaylistsId",
                        column: x => x.PlaylistsId,
                        principalTable: "Playlists",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PlaylistTrack_Tracks_TracksId",
                        column: x => x.TracksId,
                        principalTable: "Tracks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Relaxing" },
                    { 2, "Energetic" },
                    { 3, "Motivational" },
                    { 4, "Productive" },
                    { 5, "Romantic" },
                    { 6, "Sad" },
                    { 7, "Happy" },
                    { 8, "Party" },
                    { 9, "Meditative" },
                    { 10, "Classical" }
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "USA" },
                    { 2, "Ukraine" },
                    { 3, "Germany" },
                    { 4, "UK" },
                    { 5, "Poland" },
                    { 6, "Japan" },
                    { 7, "South Korea" },
                    { 8, "China" },
                    { 9, "India" },
                    { 10, "Russia" },
                    { 11, "France" },
                    { 12, "Italy" },
                    { 13, "Spain" },
                    { 14, "Canada" },
                    { 15, "Brazil" },
                    { 16, "Mexico" },
                    { 17, "Australia" },
                    { 18, "New Zealand" },
                    { 19, "Egypt" },
                    { 20, "South Africa" },
                    { 21, "Nigeria" },
                    { 22, "Kenya" },
                    { 23, "Turkey" },
                    { 24, "Iran" },
                    { 25, "Iraq" },
                    { 26, "Saudi Arabia" },
                    { 27, "Israel" },
                    { 28, "Sweden" },
                    { 29, "Norway" },
                    { 30, "Finland" }
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Hip-hop" },
                    { 2, "Rock" },
                    { 3, "Pop" },
                    { 4, "Jazz" },
                    { 5, "R&B" },
                    { 6, "Country" },
                    { 7, "Reggae" },
                    { 8, "Metal" },
                    { 9, "Blues" },
                    { 10, "Folk" },
                    { 11, "Electronic" },
                    { 12, "Soul" },
                    { 13, "Funk" },
                    { 14, "Punk" },
                    { 15, "Classical" }
                });

            migrationBuilder.InsertData(
                table: "Producers",
                columns: new[] { "Id", "CountryId", "Name" },
                values: new object[,]
                {
                    { 1, 1, "Dr. Dre" },
                    { 2, 1, "Rick Rubin" },
                    { 3, 3, "Max Martin" },
                    { 4, 1, "Quincy Jones" },
                    { 5, 4, "George Martin" },
                    { 6, 1, "Timbaland" },
                    { 7, 1, "The Alchemist" },
                    { 8, 1, "DJ Premier" },
                    { 9, 1, "Pharrell Williams" },
                    { 10, 1, "Kanye West" },
                    { 11, 1, "Travis Scott" }
                });

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "Id", "BirthDate", "CountryId", "Nickname", "OverallRating", "ProducerId" },
                values: new object[,]
                {
                    { 2, new DateTime(1972, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Eminem", 10.0, 1 },
                    { 3, new DateTime(1981, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Beyoncé", 9.0, 9 },
                    { 4, new DateTime(1989, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Taylor Swift", 8.0, 3 },
                    { 5, new DateTime(1958, 8, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Michael Jackson", 10.0, 4 },
                    { 6, new DateTime(1960, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "The Beatles", 10.0, 5 },
                    { 7, new DateTime(1981, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Justin Timberlake", 8.0, 6 },
                    { 8, new DateTime(1983, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Action Bronson", 7.0, 7 },
                    { 9, new DateTime(1973, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Nas", 9.0, 8 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Albums_ArtistId",
                table: "Albums",
                column: "ArtistId");

            migrationBuilder.CreateIndex(
                name: "IX_Albums_GenreId",
                table: "Albums",
                column: "GenreId");

            migrationBuilder.CreateIndex(
                name: "IX_Artists_CountryId",
                table: "Artists",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_Artists_ProducerId",
                table: "Artists",
                column: "ProducerId");

            migrationBuilder.CreateIndex(
                name: "IX_Playlists_CategoryId",
                table: "Playlists",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_PlaylistTrack_TracksId",
                table: "PlaylistTrack",
                column: "TracksId");

            migrationBuilder.CreateIndex(
                name: "IX_PlaylistUser_UsersId",
                table: "PlaylistUser",
                column: "UsersId");

            migrationBuilder.CreateIndex(
                name: "IX_Producers_CountryId",
                table: "Producers",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_Tracks_AlbumId",
                table: "Tracks",
                column: "AlbumId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PlaylistTrack");

            migrationBuilder.DropTable(
                name: "PlaylistUser");

            migrationBuilder.DropTable(
                name: "Tracks");

            migrationBuilder.DropTable(
                name: "Playlists");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Albums");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Artists");

            migrationBuilder.DropTable(
                name: "Genres");

            migrationBuilder.DropTable(
                name: "Producers");

            migrationBuilder.DropTable(
                name: "Countries");
        }
    }
}
