using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TicketManagerTask.Data.Migrations
{
    public partial class MigrationV3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Concerts",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5c9b1c79-8cb8-4d85-b693-f8b1f6560dcd",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f7943b4e-6c53-4eef-a2e9-746b0581d639", "AQAAAAEAACcQAAAAEOk9JbjYI7IyUhgnl6405NTLBx+QxiWToEEF8PaX4g5mkWmF8zBcGIIIlyIVxj3l9w==", "7ca1027f-dcec-4638-817c-41a76f1060d0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "79e3f8c0-d2cb-4fc0-b688-df6a4079cbec",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f4d222f1-8fa7-48b5-9d51-3f9eaa38c580", "AQAAAAEAACcQAAAAEIn2cel9PgIFrWAv0kogNO5loI5Fhyfod6laboxCSyJx9SHH6CFL/w3V1kMRzOZmkw==", "1b5e0957-c256-43b1-8afb-5caf2e2b5fe2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ab07a835-1db0-4610-8661-380134b7d361",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "83b55c08-15b0-4489-93ce-a4a932cc3766", "AQAAAAEAACcQAAAAEGz8kbY0qie0tok7GjUyzkHRx/vxa5TmynUJjXwL9BAyp2/sKVOBtf8e8FJGhnNJsQ==", "ac73e202-98fe-4807-82a2-d0c28fb0f8d6" });

            migrationBuilder.UpdateData(
                table: "Concerts",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2021, 9, 25, 10, 57, 11, 657, DateTimeKind.Local).AddTicks(8715));

            migrationBuilder.UpdateData(
                table: "Concerts",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2021, 10, 25, 10, 57, 11, 659, DateTimeKind.Local).AddTicks(6456));

            migrationBuilder.UpdateData(
                table: "Concerts",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2021, 9, 25, 10, 57, 11, 659, DateTimeKind.Local).AddTicks(7096));

            migrationBuilder.InsertData(
                table: "Concerts",
                columns: new[] { "Id", "Date", "Discriminator", "Headliner", "LocationId", "LocationInstruction", "SingerId" },
                values: new object[] { 4, new DateTime(2021, 11, 25, 10, 57, 11, 659, DateTimeKind.Local).AddTicks(7713), "OpenAir", "YOOO HEADLINER", 1, "Turn left, turn right", 3 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Concerts",
                keyColumn: "Id",
                keyValue: 4);

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
                keyValue: 2,
                column: "Date",
                value: new DateTime(2021, 10, 25, 10, 31, 56, 227, DateTimeKind.Local).AddTicks(2575));

            migrationBuilder.UpdateData(
                table: "Concerts",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2021, 9, 25, 10, 31, 56, 227, DateTimeKind.Local).AddTicks(2927));

            migrationBuilder.InsertData(
                table: "Concerts",
                columns: new[] { "Id", "Composer", "ConcertName", "Date", "Discriminator", "LocationId", "SingerId", "VoiceType" },
                values: new object[] { 4, null, null, new DateTime(2021, 11, 25, 10, 31, 56, 227, DateTimeKind.Local).AddTicks(3442), "ClassicMusic", 1, 3, null });
        }
    }
}
