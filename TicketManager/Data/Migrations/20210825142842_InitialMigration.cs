using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TicketManager.Data.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "Locations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Latitude = table.Column<double>(type: "float", nullable: false),
                    Longitude = table.Column<double>(type: "float", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    NameRu = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true)
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
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
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
                    VoiceType = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    ConcertName = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    Composer = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    Headliner = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    LocationInstruction = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    DocumentAgeConfirmation = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true)
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
                    Code = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
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
                    IsReserved = table.Column<bool>(type: "bit", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tickets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tickets_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Tickets_Concerts_ConcertId",
                        column: x => x.ConcertId,
                        principalTable: "Concerts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "ab07a835-1db0-4610-8661-380134b7d361", 0, "3bf1f4e6-bcea-45ca-bd90-1f334c81b6d5", "ApplicationUser", null, true, false, null, null, "ADMIN@CONCERTS.COM", "AQAAAAEAACcQAAAAEHpoEXZxpGUMhEVvchTBHqxBOhfdAfv2ppixXtNLdU7y4B+CmEusNa0o0ghS/gAJFQ==", null, false, "d620e4a7-41ae-4b24-b03a-7a166073d390", false, "admin@concerts.com" },
                    { "5c9b1c79-8cb8-4d85-b693-f8b1f6560dcd", 0, "658b0f2e-8b28-4382-aec6-8cf10da1afa3", "ApplicationUser", null, true, false, null, null, "USER1@MAIL.COM", "AQAAAAEAACcQAAAAEKCjnGUTLmes6oDPXaC52WfuR43XVOoc2V/6MOWDcQbh+DNp3pylguW/5flNf/X+jQ==", null, false, "33115a14-e40a-432b-9c2d-9a2097caee7f", false, "user1@mail.com" },
                    { "79e3f8c0-d2cb-4fc0-b688-df6a4079cbec", 0, "1e0b422a-b695-4a1d-bef3-8509869ee15a", "ApplicationUser", null, true, false, null, null, "USER2@CONCERTS.COM", "AQAAAAEAACcQAAAAENoeXRI7/RuDajU5K5Bw0zb1/JV1VySPEu+DUINnR3YEFsbMmDFErUvO1jJ1ofYslA==", null, false, "476dd426-ca7b-41d1-ad50-faef670f37d1", false, "user2@concerts.com" },
                    { "79e3f8c0-d3cb-4fc0-b688-df6a4079cbec", 0, "49c63850-d710-4d06-aa65-002b17d76b2e", "ApplicationUser", null, true, false, null, null, "TEST@MAIL.COM", "AQAAAAEAACcQAAAAEOCrEcFejTfQf9ZGxHHkYWo3ftcE8oOHdyycxQBzxlZTsQQWW5X0ruLPPKkpN+qk/Q==", null, false, "6993e1e4-7273-4224-a5e2-f01f6624aff4", false, "test@mail.com" }
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
                values: new object[] { 1, "Unknown", "Classic#1", new DateTime(2021, 9, 25, 17, 28, 42, 167, DateTimeKind.Local).AddTicks(7472), "ClassicMusic", 1, 1, "Tenor" });

            migrationBuilder.InsertData(
                table: "Concerts",
                columns: new[] { "Id", "Date", "Discriminator", "DocumentAgeConfirmation", "LocationId", "SingerId" },
                values: new object[,]
                {
                    { 2, new DateTime(2021, 10, 25, 17, 28, 42, 168, DateTimeKind.Local).AddTicks(9825), "Party", "Passport", 2, 1 },
                    { 3, new DateTime(2021, 9, 25, 17, 28, 42, 169, DateTimeKind.Local).AddTicks(171), "Party", "Passport", 2, 1 }
                });

            migrationBuilder.InsertData(
                table: "Concerts",
                columns: new[] { "Id", "Date", "Discriminator", "Headliner", "LocationId", "LocationInstruction", "SingerId" },
                values: new object[] { 4, new DateTime(2021, 11, 25, 17, 28, 42, 169, DateTimeKind.Local).AddTicks(741), "OpenAir", "YOOO HEADLINER", 1, "Turn left, turn right", 3 });

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
                columns: new[] { "Id", "ConcertId", "IsReserved", "UserId" },
                values: new object[,]
                {
                    { 1, 1, false, null },
                    { 2, 1, false, null },
                    { 3, 1, false, null },
                    { 4, 2, false, null },
                    { 5, 2, false, null },
                    { 6, 2, false, null },
                    { 7, 3, false, null },
                    { 8, 3, false, null },
                    { 9, 3, false, null },
                    { 10, 4, false, null },
                    { 11, 4, false, null },
                    { 12, 4, false, null }
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

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_UserId",
                table: "Tickets",
                column: "UserId");
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
                keyValue: "79e3f8c0-d3cb-4fc0-b688-df6a4079cbec");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ab07a835-1db0-4610-8661-380134b7d361");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "AspNetUsers");
        }
    }
}
