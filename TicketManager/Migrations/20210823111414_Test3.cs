using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TicketManager.Migrations
{
    public partial class Test3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Concerts_Locations_LocationId",
                table: "Concerts");

            migrationBuilder.AlterColumn<int>(
                name: "LocationId",
                table: "Concerts",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Concerts",
                columns: new[] { "Id", "BandId", "ConcertTypeId", "Date", "LocationId" },
                values: new object[] { 1, 1, 1, new DateTime(2021, 9, 23, 14, 14, 13, 690, DateTimeKind.Local).AddTicks(7493), 1 });

            migrationBuilder.InsertData(
                table: "Concerts",
                columns: new[] { "Id", "BandId", "ConcertTypeId", "Date", "LocationId" },
                values: new object[] { 2, 2, 2, new DateTime(2021, 9, 23, 14, 14, 13, 692, DateTimeKind.Local).AddTicks(1549), 2 });

            migrationBuilder.AddForeignKey(
                name: "FK_Concerts_Locations_LocationId",
                table: "Concerts",
                column: "LocationId",
                principalTable: "Locations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Concerts_Locations_LocationId",
                table: "Concerts");

            migrationBuilder.DeleteData(
                table: "Concerts",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Concerts",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.AlterColumn<int>(
                name: "LocationId",
                table: "Concerts",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Concerts_Locations_LocationId",
                table: "Concerts",
                column: "LocationId",
                principalTable: "Locations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
