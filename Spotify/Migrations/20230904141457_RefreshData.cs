using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Spotify.Migrations
{
    /// <inheritdoc />
    public partial class RefreshData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.InsertData(
                table: "Albums",
                columns: new[] { "Id", "ArtistId", "CountOfListening", "Description", "GenreId", "Name", "Rating", "ReleaseDate" },
                values: new object[,]
                {
                    { 2, 2, 800000, "Lemonade is the sixth solo studio album by American singer Beyoncé.It was released on April 23, 2016 by Parkwood Entertainment and Columbia Records.", 5, "Lemonade", 8.0, new DateTime(2016, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, 3, 700000, "1989 is the fifth studio album by American singer - songwriter Taylor Swift.It was released on October 27, 2014, through Big Machine Records.", 3, "1989", 7.0, new DateTime(2014, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, 4, 1500000, "Thriller is the sixth studio album by American singer Michael Jackson.It was released on November 30, 1982 by Epic Records.", 3, "Thriller", 10.0, new DateTime(1982, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, 5, 900000, "Abbey Road is the eleventh studio album by the English rock band the Beatles.It was released on September 26, 1969 by Apple Records.", 2, "Abbey Road", 9.0, new DateTime(1969, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BirthDate", "Nickname", "OverallRating", "ProducerId" },
                values: new object[] { new DateTime(1981, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Beyoncé", 9.0, 9 });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BirthDate", "Nickname", "OverallRating", "ProducerId" },
                values: new object[] { new DateTime(1989, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Taylor Swift", 8.0, 3 });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "BirthDate", "Nickname", "OverallRating", "ProducerId" },
                values: new object[] { new DateTime(1958, 8, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Michael Jackson", 10.0, 4 });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "BirthDate", "CountryId", "Nickname", "ProducerId" },
                values: new object[] { new DateTime(1960, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "The Beatles", 5 });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "BirthDate", "CountryId", "Nickname", "OverallRating", "ProducerId" },
                values: new object[] { new DateTime(1981, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Justin Timberlake", 8.0, 6 });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "BirthDate", "Nickname", "OverallRating", "ProducerId" },
                values: new object[] { new DateTime(1983, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Action Bronson", 7.0, 7 });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "BirthDate", "Nickname", "OverallRating", "ProducerId" },
                values: new object[] { new DateTime(1973, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nas", 9.0, 8 });

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "Id", "BirthDate", "CountryId", "Nickname", "OverallRating", "ProducerId" },
                values: new object[] { 1, new DateTime(1972, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Eminem", 10.0, 1 });

            migrationBuilder.InsertData(
                table: "Albums",
                columns: new[] { "Id", "ArtistId", "CountOfListening", "Description", "GenreId", "Name", "Rating", "ReleaseDate" },
                values: new object[] { 1, 1, 1000000, "The Marshall Mathers LP is the third studio album by American rapper Eminem, released on May 23, 2000, by Aftermath Entertainment and Interscope Records.", 1, "The Marshall Mathers LP", 9.0, new DateTime(2000, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BirthDate", "Nickname", "OverallRating", "ProducerId" },
                values: new object[] { new DateTime(1972, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Eminem", 10.0, 1 });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BirthDate", "Nickname", "OverallRating", "ProducerId" },
                values: new object[] { new DateTime(1981, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Beyoncé", 9.0, 9 });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "BirthDate", "Nickname", "OverallRating", "ProducerId" },
                values: new object[] { new DateTime(1989, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Taylor Swift", 8.0, 3 });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "BirthDate", "CountryId", "Nickname", "ProducerId" },
                values: new object[] { new DateTime(1958, 8, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Michael Jackson", 4 });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "BirthDate", "CountryId", "Nickname", "OverallRating", "ProducerId" },
                values: new object[] { new DateTime(1960, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "The Beatles", 10.0, 5 });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "BirthDate", "Nickname", "OverallRating", "ProducerId" },
                values: new object[] { new DateTime(1981, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Justin Timberlake", 8.0, 6 });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "BirthDate", "Nickname", "OverallRating", "ProducerId" },
                values: new object[] { new DateTime(1983, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Action Bronson", 7.0, 7 });

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "Id", "BirthDate", "CountryId", "Nickname", "OverallRating", "ProducerId" },
                values: new object[] { 9, new DateTime(1973, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Nas", 9.0, 8 });
        }
    }
}
