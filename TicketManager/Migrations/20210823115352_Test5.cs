using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TicketManager.Migrations
{
    public partial class Test5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.UpdateData(
                table: "Concerts",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2021, 9, 23, 14, 53, 51, 380, DateTimeKind.Local).AddTicks(4491));

            migrationBuilder.UpdateData(
                table: "Concerts",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2021, 10, 23, 14, 53, 51, 381, DateTimeKind.Local).AddTicks(7570));

            migrationBuilder.UpdateData(
                table: "Concerts",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2021, 9, 23, 14, 53, 51, 381, DateTimeKind.Local).AddTicks(7611));

            migrationBuilder.UpdateData(
                table: "Concerts",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2021, 11, 23, 14, 53, 51, 381, DateTimeKind.Local).AddTicks(7615));

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

            migrationBuilder.CreateIndex(
                name: "IX_PromoCodes_ConcertId",
                table: "PromoCodes",
                column: "ConcertId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PromoCodes");

            migrationBuilder.UpdateData(
                table: "Concerts",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2021, 9, 23, 14, 38, 19, 964, DateTimeKind.Local).AddTicks(7640));

            migrationBuilder.UpdateData(
                table: "Concerts",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2021, 10, 23, 14, 38, 19, 965, DateTimeKind.Local).AddTicks(9448));

            migrationBuilder.UpdateData(
                table: "Concerts",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2021, 9, 23, 14, 38, 19, 965, DateTimeKind.Local).AddTicks(9478));

            migrationBuilder.UpdateData(
                table: "Concerts",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2021, 11, 23, 14, 38, 19, 965, DateTimeKind.Local).AddTicks(9481));
        }
    }
}
