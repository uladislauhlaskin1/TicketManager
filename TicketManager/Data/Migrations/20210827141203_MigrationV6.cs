using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TicketManager.Data.Migrations
{
    public partial class MigrationV6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                column: "ConcurrencyStamp",
                value: "b50f7131-75df-42a5-a871-3ab7be4689dc");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5c9b1c79-8cb8-4d85-b693-f8b1f6560dcd",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b7e09835-e475-46c9-b263-bcfeccf44aca", "AQAAAAEAACcQAAAAEJpQOlxl7FHyYo15tNl2WW1IOIX4mNmXTlVhS2dYNzwDiEMqddEoRn0cZK5meCze1Q==", "34accdd0-d7cf-4b37-8fd2-704c56aa8b8e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "79e3f8c0-d2cb-4fc0-b688-df6a4079cbec",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "601f3903-663b-40b3-b25a-32105c1faf97", "AQAAAAEAACcQAAAAEGxOk+BFJ/8vRzvYlD94fKUzjlHgKvhNQWVuE2tXSGZQPmD2cOz4ly3BZ0v8KZdHgA==", "49a059c3-6619-4624-a479-941546c3be42" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "79e3f8c0-d3cb-4fc0-b688-df6a4079cbec",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0be0159c-08ca-4961-8ec3-269d2e219d0c", "AQAAAAEAACcQAAAAEPon/w+/+UY4aA6XRvp3NbekyGFqTDl9T20nylIJpDlfX71RBKJhiNXB/uQZXvqmNw==", "81797369-4342-4956-82d2-102c66598ff5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ab07a835-1db0-4610-8661-380134b7d361",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "baaa4ece-87b7-4000-af53-abae63ab399e", "AQAAAAEAACcQAAAAENiIW1jA/So8cESTJ8OWbdBoHENjCFyyz/WhVKjQMEQ/6jYKIfF9ZScoqQYF4dJCMw==", "0cbf08c3-325c-406f-a8b5-d30bf67bdce2" });

            migrationBuilder.UpdateData(
                table: "Concerts",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2021, 9, 27, 17, 12, 2, 494, DateTimeKind.Local).AddTicks(7124));

            migrationBuilder.UpdateData(
                table: "Concerts",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2021, 11, 27, 17, 12, 2, 496, DateTimeKind.Local).AddTicks(5128));

            migrationBuilder.UpdateData(
                table: "Concerts",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2021, 10, 27, 17, 12, 2, 496, DateTimeKind.Local).AddTicks(4077));

            migrationBuilder.UpdateData(
                table: "Concerts",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2021, 9, 27, 17, 12, 2, 496, DateTimeKind.Local).AddTicks(4440));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                column: "ConcurrencyStamp",
                value: "e31cdf4f-e1d2-4e70-8d64-7db57d8b6fe0");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5c9b1c79-8cb8-4d85-b693-f8b1f6560dcd",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f584a65c-2bc5-46f3-a376-be83f7394427", "AQAAAAEAACcQAAAAEGQpwSn7znHULzfTz3Z8YbqrKJf++f3JiTx10yV8PZsmaai9dlcwSB17o0Y1s17jrg==", "5057ba7d-86de-452a-9e84-7c43d35dd161" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "79e3f8c0-d2cb-4fc0-b688-df6a4079cbec",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4f9991cf-d0e7-455b-8a81-fcabdc940456", "AQAAAAEAACcQAAAAEBlUThONCgDzZv3ZuGE/GkY8XVH4lo7St0s8n/3yuC0NG5OfbLtlINvGo1kULu7USQ==", "6f984fec-daa4-4e16-8f4d-2a6fc8b38026" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "79e3f8c0-d3cb-4fc0-b688-df6a4079cbec",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fddc547e-0916-45ae-a7be-8fc1dbf4b8e6", "AQAAAAEAACcQAAAAENjmF8cQSd2gKYU1JcPBMB3+EIcpG4MxDlX11HrR6Xjf1WowHvd14z8UqLXH8c+C+A==", "672aafb1-b225-4e42-8585-1301612af6b5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ab07a835-1db0-4610-8661-380134b7d361",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2bdf0fae-eb6e-455c-8898-01243899df50", "AQAAAAEAACcQAAAAEFQF99yjEIOJuOFCgB6WbqW/kB3ukuNc4HG5oVOep49Aa3Ed+5juydAK/kTqUMfPdw==", "2b27053f-afa1-4f3a-a973-cc05cefd4199" });

            migrationBuilder.UpdateData(
                table: "Concerts",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2021, 9, 27, 15, 55, 45, 564, DateTimeKind.Local).AddTicks(8111));

            migrationBuilder.UpdateData(
                table: "Concerts",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2021, 11, 27, 15, 55, 45, 566, DateTimeKind.Local).AddTicks(9583));

            migrationBuilder.UpdateData(
                table: "Concerts",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2021, 10, 27, 15, 55, 45, 566, DateTimeKind.Local).AddTicks(8402));

            migrationBuilder.UpdateData(
                table: "Concerts",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2021, 9, 27, 15, 55, 45, 566, DateTimeKind.Local).AddTicks(8853));
        }
    }
}
