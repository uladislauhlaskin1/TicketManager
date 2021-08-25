using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TicketManagerTask.Data.Migrations
{
    public partial class MigrationV2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CustomerInfo",
                table: "Tickets");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Tickets");

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Tickets",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5c9b1c79-8cb8-4d85-b693-f8b1f6560dcd",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bf741f1d-d4e8-4c3e-aa39-90320ab6fe80", "AQAAAAEAACcQAAAAEBlg0xpyEOrDwWLz6Fe/wFC7vnLmEfTYAhwfmPGBE99B+WBEBCgdOWG8kqZGOhX/iw==", "3565e871-1911-407c-862d-9c1450f5c9eb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "79e3f8c0-d2cb-4fc0-b688-df6a4079cbec",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0c24fb81-625e-4553-b332-99f99e90bde7", "AQAAAAEAACcQAAAAEC1rPrUwmUtNS4rejhkbcjsXLYORVlRJREHyP04PBNWRJ6pYQm80P4yPGq21GHrzdA==", "94680905-ba00-4f62-9516-f03f2df0beda" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ab07a835-1db0-4610-8661-380134b7d361",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "44ff4c14-5809-45f2-833f-8297582daeb4", "AQAAAAEAACcQAAAAEFmbU5cNJq9mCqvYZiicWuiNxKBHUyGYF7iEw5cQCFU/MTjhIlhyTdu0MGjsMmySKA==", "5460329a-9ca8-4e60-8e0d-8ce4ddc2eb30" });

            migrationBuilder.UpdateData(
                table: "Concerts",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2021, 9, 25, 10, 31, 56, 225, DateTimeKind.Local).AddTicks(8289));

            migrationBuilder.UpdateData(
                table: "Concerts",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2021, 11, 25, 10, 31, 56, 227, DateTimeKind.Local).AddTicks(3442));

            migrationBuilder.UpdateData(
                table: "Concerts",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2021, 10, 25, 10, 31, 56, 227, DateTimeKind.Local).AddTicks(2575));

            migrationBuilder.UpdateData(
                table: "Concerts",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2021, 9, 25, 10, 31, 56, 227, DateTimeKind.Local).AddTicks(2927));

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_UserId",
                table: "Tickets",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_AspNetUsers_UserId",
                table: "Tickets",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_AspNetUsers_UserId",
                table: "Tickets");

            migrationBuilder.DropIndex(
                name: "IX_Tickets_UserId",
                table: "Tickets");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Tickets");

            migrationBuilder.AddColumn<string>(
                name: "CustomerInfo",
                table: "Tickets",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Price",
                table: "Tickets",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5c9b1c79-8cb8-4d85-b693-f8b1f6560dcd",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a91e5c5c-f212-4044-821a-333a6f807f12", "AQAAAAEAACcQAAAAEMry3Xdix6XuZ4tWvjoNxRiELEvJxgpzjSIz1V04Wi8H5vJTg1rOlySyTYbcbp/URQ==", "68484c7d-b322-4c58-92db-ed3f3a67fae1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "79e3f8c0-d2cb-4fc0-b688-df6a4079cbec",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3867e8f6-6f12-429a-8bf0-df2c28daae13", "AQAAAAEAACcQAAAAEI9wg9PR4ygeQLVUWCpGaco7VJCrphT4IdYP3mFEvw+KrPnyGvlEOAOZy2hmk6KfSA==", "f49bcb10-565f-411e-b529-fb5f71b9a24b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ab07a835-1db0-4610-8661-380134b7d361",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e97a7f78-2f35-4555-9165-03c0aee4f0a0", "AQAAAAEAACcQAAAAEFialYN2kxpqQPFsBEvNS6yOisTqazzNpdMcK9fJIMXf+HnZ/5HLu01oVv4eZNZ83w==", "ebbaf5c6-4301-4c0a-9b33-5489d8b1b26f" });

            migrationBuilder.UpdateData(
                table: "Concerts",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2021, 9, 24, 11, 38, 44, 594, DateTimeKind.Local).AddTicks(1465));

            migrationBuilder.UpdateData(
                table: "Concerts",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2021, 11, 24, 11, 38, 44, 595, DateTimeKind.Local).AddTicks(8983));

            migrationBuilder.UpdateData(
                table: "Concerts",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2021, 10, 24, 11, 38, 44, 595, DateTimeKind.Local).AddTicks(7942));

            migrationBuilder.UpdateData(
                table: "Concerts",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2021, 9, 24, 11, 38, 44, 595, DateTimeKind.Local).AddTicks(8365));

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CustomerInfo", "Price" },
                values: new object[] { " - ", 5.0 });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CustomerInfo", "Price" },
                values: new object[] { " - ", 5.0 });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CustomerInfo", "Price" },
                values: new object[] { " - ", 5.0 });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CustomerInfo", "Price" },
                values: new object[] { " - ", 5.0 });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CustomerInfo", "Price" },
                values: new object[] { " - ", 5.0 });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CustomerInfo", "Price" },
                values: new object[] { " - ", 5.0 });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CustomerInfo", "Price" },
                values: new object[] { " - ", 5.0 });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CustomerInfo", "Price" },
                values: new object[] { " - ", 5.0 });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CustomerInfo", "Price" },
                values: new object[] { " - ", 5.0 });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CustomerInfo", "Price" },
                values: new object[] { " - ", 5.0 });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CustomerInfo", "Price" },
                values: new object[] { " - ", 5.0 });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CustomerInfo", "Price" },
                values: new object[] { " - ", 5.0 });
        }
    }
}
