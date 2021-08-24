using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TicketManagerTask.Data.Migrations
{
    public partial class MigrationV1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Locations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Latitude = table.Column<double>(type: "float", nullable: false),
                    Longitude = table.Column<double>(type: "float", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NameRu = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Singers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Singers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Concerts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SingerId = table.Column<int>(type: "int", nullable: false),
                    LocationId = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VoiceType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcertName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Composer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Headliner = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LocationInstruction = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DocumentAgeConfirmation = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Concerts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Concerts_Locations_LocationId",
                        column: x => x.LocationId,
                        principalTable: "Locations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Concerts_Singers_SingerId",
                        column: x => x.SingerId,
                        principalTable: "Singers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PromoCodes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Coefficient = table.Column<double>(type: "float", nullable: false),
                    ConcertId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PromoCodes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PromoCodes_Concerts_ConcertId",
                        column: x => x.ConcertId,
                        principalTable: "Concerts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tickets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ConcertId = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    IsReserved = table.Column<bool>(type: "bit", nullable: false),
                    CustomerInfo = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tickets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tickets_Concerts_ConcertId",
                        column: x => x.ConcertId,
                        principalTable: "Concerts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "ab07a835-1db0-4610-8661-380134b7d361", 0, "e97a7f78-2f35-4555-9165-03c0aee4f0a0", null, true, false, null, null, "ADMIN@CONCERTS.COM", "AQAAAAEAACcQAAAAEFialYN2kxpqQPFsBEvNS6yOisTqazzNpdMcK9fJIMXf+HnZ/5HLu01oVv4eZNZ83w==", null, false, "ebbaf5c6-4301-4c0a-9b33-5489d8b1b26f", false, "admin@concerts.com" },
                    { "5c9b1c79-8cb8-4d85-b693-f8b1f6560dcd", 0, "a91e5c5c-f212-4044-821a-333a6f807f12", null, true, false, null, null, "USER1@MAIL.COM", "AQAAAAEAACcQAAAAEMry3Xdix6XuZ4tWvjoNxRiELEvJxgpzjSIz1V04Wi8H5vJTg1rOlySyTYbcbp/URQ==", null, false, "68484c7d-b322-4c58-92db-ed3f3a67fae1", false, "user1@mail.com" },
                    { "79e3f8c0-d2cb-4fc0-b688-df6a4079cbec", 0, "3867e8f6-6f12-429a-8bf0-df2c28daae13", null, true, false, null, null, "USER2@CONCERTS.COM", "AQAAAAEAACcQAAAAEI9wg9PR4ygeQLVUWCpGaco7VJCrphT4IdYP3mFEvw+KrPnyGvlEOAOZy2hmk6KfSA==", null, false, "f49bcb10-565f-411e-b529-fb5f71b9a24b", false, "user2@concerts.com" }
                });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "Id", "Latitude", "Longitude", "Name", "NameRu" },
                values: new object[,]
                {
                    { 1, 33.333300000000001, 44.444400000000002, "Unknown location", null },
                    { 2, 22.222200000000001, 55.555500000000002, "Another location", null }
                });

            migrationBuilder.InsertData(
                table: "Singers",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Nightwish" },
                    { 2, "Dio" },
                    { 3, "The Offspring" },
                    { 4, "Some classic singer" },
                    { 5, "Another singer" }
                });

            migrationBuilder.InsertData(
                table: "Concerts",
                columns: new[] { "Id", "Composer", "ConcertName", "Date", "Discriminator", "LocationId", "SingerId", "VoiceType" },
                values: new object[] { 1, "Unknown", "Classic#1", new DateTime(2021, 9, 24, 11, 38, 44, 594, DateTimeKind.Local).AddTicks(1465), "ClassicMusic", 1, 1, "Tenor" });

            migrationBuilder.InsertData(
                table: "Concerts",
                columns: new[] { "Id", "Date", "Discriminator", "DocumentAgeConfirmation", "LocationId", "SingerId" },
                values: new object[,]
                {
                    { 2, new DateTime(2021, 10, 24, 11, 38, 44, 595, DateTimeKind.Local).AddTicks(7942), "Party", "Passport", 2, 1 },
                    { 3, new DateTime(2021, 9, 24, 11, 38, 44, 595, DateTimeKind.Local).AddTicks(8365), "Party", "Passport", 2, 1 }
                });

            migrationBuilder.InsertData(
                table: "Concerts",
                columns: new[] { "Id", "Composer", "ConcertName", "Date", "Discriminator", "LocationId", "SingerId", "VoiceType" },
                values: new object[] { 4, null, null, new DateTime(2021, 11, 24, 11, 38, 44, 595, DateTimeKind.Local).AddTicks(8983), "ClassicMusic", 1, 3, null });

            migrationBuilder.InsertData(
                table: "PromoCodes",
                columns: new[] { "Id", "Code", "Coefficient", "ConcertId" },
                values: new object[,]
                {
                    { 1, "QWERTY", 0.90000000000000002, 1 },
                    { 2, "PromoCode420", 0.80000000000000004, 1 },
                    { 3, "SuperCode", 0.75, 2 },
                    { 4, "McCode", 0.90000000000000002, 3 }
                });

            migrationBuilder.InsertData(
                table: "Tickets",
                columns: new[] { "Id", "ConcertId", "CustomerInfo", "IsReserved", "Price" },
                values: new object[,]
                {
                    { 1, 1, " - ", false, 5.0 },
                    { 2, 1, " - ", false, 5.0 },
                    { 3, 1, " - ", false, 5.0 },
                    { 4, 2, " - ", false, 5.0 },
                    { 5, 2, " - ", false, 5.0 },
                    { 6, 2, " - ", false, 5.0 },
                    { 7, 3, " - ", false, 5.0 },
                    { 8, 3, " - ", false, 5.0 },
                    { 9, 3, " - ", false, 5.0 },
                    { 10, 4, " - ", false, 5.0 },
                    { 11, 4, " - ", false, 5.0 },
                    { 12, 4, " - ", false, 5.0 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Concerts_LocationId",
                table: "Concerts",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_Concerts_SingerId",
                table: "Concerts",
                column: "SingerId");

            migrationBuilder.CreateIndex(
                name: "IX_PromoCodes_ConcertId",
                table: "PromoCodes",
                column: "ConcertId");

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_ConcertId",
                table: "Tickets",
                column: "ConcertId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PromoCodes");

            migrationBuilder.DropTable(
                name: "Tickets");

            migrationBuilder.DropTable(
                name: "Concerts");

            migrationBuilder.DropTable(
                name: "Locations");

            migrationBuilder.DropTable(
                name: "Singers");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5c9b1c79-8cb8-4d85-b693-f8b1f6560dcd");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "79e3f8c0-d2cb-4fc0-b688-df6a4079cbec");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ab07a835-1db0-4610-8661-380134b7d361");
        }
    }
}
