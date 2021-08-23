using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TicketManager.Migrations
{
    public partial class Test4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                columns: new[] { "BandId", "ConcertTypeId", "Date" },
                values: new object[] { 1, 1, new DateTime(2021, 10, 23, 14, 38, 19, 965, DateTimeKind.Local).AddTicks(9448) });

            migrationBuilder.InsertData(
                table: "Concerts",
                columns: new[] { "Id", "BandId", "ConcertTypeId", "Date", "LocationId" },
                values: new object[,]
                {
                    { 3, 2, 2, new DateTime(2021, 9, 23, 14, 38, 19, 965, DateTimeKind.Local).AddTicks(9478), 2 },
                    { 4, 3, 3, new DateTime(2021, 11, 23, 14, 38, 19, 965, DateTimeKind.Local).AddTicks(9481), 1 }
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
                    { 6, 2, " - ", false, 5.0 }
                });

            migrationBuilder.InsertData(
                table: "Tickets",
                columns: new[] { "Id", "ConcertId", "CustomerInfo", "IsReserved", "Price" },
                values: new object[,]
                {
                    { 7, 3, " - ", false, 5.0 },
                    { 8, 3, " - ", false, 5.0 },
                    { 9, 3, " - ", false, 5.0 },
                    { 10, 4, " - ", false, 5.0 },
                    { 11, 4, " - ", false, 5.0 },
                    { 12, 4, " - ", false, 5.0 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Concerts",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Concerts",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.UpdateData(
                table: "Concerts",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2021, 9, 23, 14, 14, 13, 690, DateTimeKind.Local).AddTicks(7493));

            migrationBuilder.UpdateData(
                table: "Concerts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BandId", "ConcertTypeId", "Date" },
                values: new object[] { 2, 2, new DateTime(2021, 9, 23, 14, 14, 13, 692, DateTimeKind.Local).AddTicks(1549) });
        }
    }
}
