using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TicketManager.Data.Migrations
{
    public partial class MigrationV5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4f9991cf-d0e7-455b-8a81-fcabdc940456", "USER2@MAIL.COM", "AQAAAAEAACcQAAAAEBlUThONCgDzZv3ZuGE/GkY8XVH4lo7St0s8n/3yuC0NG5OfbLtlINvGo1kULu7USQ==", "6f984fec-daa4-4e16-8f4d-2a6fc8b38026" });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                column: "ConcurrencyStamp",
                value: "1e738193-5680-44c8-b51e-185a70f2560c");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5c9b1c79-8cb8-4d85-b693-f8b1f6560dcd",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e6c46411-63d9-423d-9700-16b2b6388296", "AQAAAAEAACcQAAAAEK9/dA1RpABIqS62f5mOMnRnRqRO5DcJvmlKBC51wFpH/mjvDZHOu0fZMg0r/WY9Iw==", "dc34fbef-10e0-4b0f-8fad-8e6a0368536f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "79e3f8c0-d2cb-4fc0-b688-df6a4079cbec",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a3266ed2-4930-47fc-add6-dfb3a87f1c43", "USER2@CONCERTS.COM", "AQAAAAEAACcQAAAAEJ4HfoEcu03WequDtM/8xlxxY+m2/c7P3rU+IBM26/IVCNtUVndsz4lpbYvk8ooT/w==", "b47f4318-5510-4e10-a89e-f9160238bef0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "79e3f8c0-d3cb-4fc0-b688-df6a4079cbec",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6285405c-45c6-4c42-9f85-ff7feea3072a", "AQAAAAEAACcQAAAAEKVpRvEL/ZggxY36bF6lRzQ4TTiuRj1RCaFN0yTC1Gq50FogBV28dVtVe0TbPksjFA==", "5e53ae89-47dc-4d9e-9faa-f82e7781d16f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ab07a835-1db0-4610-8661-380134b7d361",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b13cd812-80ed-4736-be1e-9f63698ed835", "AQAAAAEAACcQAAAAEEWLrnaLX2eQZm75JlAsUdx8vBV2DtP3MB7Do4sJE5orAqrAXtdsRTsSOEXB44xN+A==", "17a56e64-9b7a-44f9-b7fe-4f8f709b0220" });

            migrationBuilder.UpdateData(
                table: "Concerts",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2021, 9, 27, 15, 53, 54, 363, DateTimeKind.Local).AddTicks(3986));

            migrationBuilder.UpdateData(
                table: "Concerts",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2021, 11, 27, 15, 53, 54, 364, DateTimeKind.Local).AddTicks(9991));

            migrationBuilder.UpdateData(
                table: "Concerts",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2021, 10, 27, 15, 53, 54, 364, DateTimeKind.Local).AddTicks(9021));

            migrationBuilder.UpdateData(
                table: "Concerts",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2021, 9, 27, 15, 53, 54, 364, DateTimeKind.Local).AddTicks(9385));
        }
    }
}
