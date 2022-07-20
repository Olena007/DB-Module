using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace final_db.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Artists",
                columns: table => new
                {
                    ArtistId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InstagramURL = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Artists", x => x.ArtistId);
                });

            migrationBuilder.CreateTable(
                name: "Genres",
                columns: table => new
                {
                    GenreId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genres", x => x.GenreId);
                });

            migrationBuilder.CreateTable(
                name: "Songs",
                columns: table => new
                {
                    SongId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Duration = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ReleasedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GenreId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Songs", x => x.SongId);
                    table.ForeignKey(
                        name: "FK_Songs_Genres_GenreId",
                        column: x => x.GenreId,
                        principalTable: "Genres",
                        principalColumn: "GenreId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Performances",
                columns: table => new
                {
                    PerformanceId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ArtistId = table.Column<int>(type: "int", nullable: false),
                    SongId = table.Column<int>(type: "int", nullable: false),
                    DateOfPerformance = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LocationPlatform = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Performances", x => x.PerformanceId);
                    table.ForeignKey(
                        name: "FK_Performances_Artists_ArtistId",
                        column: x => x.ArtistId,
                        principalTable: "Artists",
                        principalColumn: "ArtistId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Performances_Songs_SongId",
                        column: x => x.SongId,
                        principalTable: "Songs",
                        principalColumn: "SongId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "ArtistId", "DateOfBirth", "Email", "InstagramURL", "Name", "Phone" },
                values: new object[,]
                {
                    { 1, new DateTime(1988, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "adele@gmail.com", "www.instagram.com/adele/", "Adele", "+3800991234576" },
                    { 2, new DateTime(1988, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "avicii@gmail.com", "www.instagram.com/avicii/", "Avicii", "+3800991679976" },
                    { 3, new DateTime(1981, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "coldplay@gmail.com", "www.instagram.com/coldplay/", "Chris Martin", "+3800951234576" }
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "GenreId", "Title" },
                values: new object[,]
                {
                    { 1, "pop" },
                    { 2, "alternative" },
                    { 3, "house" }
                });

            migrationBuilder.InsertData(
                table: "Performances",
                columns: new[] { "PerformanceId", "ArtistId", "DateOfPerformance", "LocationPlatform", "SongId" },
                values: new object[] { 1, 1, new DateTime(2020, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Instagram", 1 });

            migrationBuilder.InsertData(
                table: "Songs",
                columns: new[] { "SongId", "Duration", "GenreId", "ReleasedDate", "Title" },
                values: new object[] { 2, new DateTime(2022, 7, 19, 0, 5, 13, 0, DateTimeKind.Unspecified), 1, new DateTime(2015, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Love in the dark" });

            migrationBuilder.InsertData(
                table: "Songs",
                columns: new[] { "SongId", "Duration", "GenreId", "ReleasedDate", "Title" },
                values: new object[] { 3, new DateTime(2022, 7, 19, 0, 4, 13, 0, DateTimeKind.Unspecified), 3, new DateTime(1960, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Wake me up" });

            migrationBuilder.InsertData(
                table: "Performances",
                columns: new[] { "PerformanceId", "ArtistId", "DateOfPerformance", "LocationPlatform", "SongId" },
                values: new object[] { 2, 2, null, null, 2 });

            migrationBuilder.InsertData(
                table: "Performances",
                columns: new[] { "PerformanceId", "ArtistId", "DateOfPerformance", "LocationPlatform", "SongId" },
                values: new object[] { 3, 3, new DateTime(2021, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Instagram", 3 });

            migrationBuilder.CreateIndex(
                name: "IX_Performances_ArtistId",
                table: "Performances",
                column: "ArtistId");

            migrationBuilder.CreateIndex(
                name: "IX_Performances_SongId",
                table: "Performances",
                column: "SongId");

            migrationBuilder.CreateIndex(
                name: "IX_Songs_GenreId",
                table: "Songs",
                column: "GenreId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Performances");

            migrationBuilder.DropTable(
                name: "Artists");

            migrationBuilder.DropTable(
                name: "Songs");

            migrationBuilder.DropTable(
                name: "Genres");
        }
    }
}
