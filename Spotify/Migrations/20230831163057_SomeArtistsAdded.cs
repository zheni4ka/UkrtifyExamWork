using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Spotify.Migrations
{
    /// <inheritdoc />
    public partial class SomeArtistsAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 1);

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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "Id", "BirthDate", "CountryId", "Nickname", "OverallRating", "ProducerId" },
                values: new object[] { 1, new DateTime(1991, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Travis Scott", 9.0, 11 });
        }
    }
}
