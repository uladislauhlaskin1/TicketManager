using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TicketManager.Data.Migrations
{
    public partial class MigrationV4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "a3266ed2-4930-47fc-add6-dfb3a87f1c43", "AQAAAAEAACcQAAAAEJ4HfoEcu03WequDtM/8xlxxY+m2/c7P3rU+IBM26/IVCNtUVndsz4lpbYvk8ooT/w==", "b47f4318-5510-4e10-a89e-f9160238bef0", "user2@mail.com" });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                column: "ConcurrencyStamp",
                value: "b5e752ae-8210-4bc3-be94-4e42cb5d0261");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5c9b1c79-8cb8-4d85-b693-f8b1f6560dcd",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d2dcadf0-c9d0-4121-9345-b28fe1271482", "AQAAAAEAACcQAAAAEP1iIgr+b3e+G3hRMgdiUCDUWbnPuD00oFiXzz9ojv0QtLS7GQ7VyWcWPidBJpSgVw==", "4b19bb34-f8fe-4817-9a94-1923dc4f0791" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "79e3f8c0-d2cb-4fc0-b688-df6a4079cbec",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "ec80b441-4bf6-465f-a03b-4dfb93372de5", "AQAAAAEAACcQAAAAEFLYyVLK/q480LsrnqZxsDZ1PFsqr6ODN5rm3o5RXMtDHLZBVayPv8lFW2J0yiUTHw==", "23eacf5e-f6e2-4346-ac97-b84f5a009e68", "user2@concerts.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "79e3f8c0-d3cb-4fc0-b688-df6a4079cbec",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "715773fe-1802-44cc-8105-758a89da2a65", "AQAAAAEAACcQAAAAEKS4sIB2HNApg/z+qEQwgNIqWW0DstwN188n7b+qh58x9S4zcERDCBNnV4DrhlDJhg==", "308314a1-f583-4c5c-aa55-e2cba068fd0a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ab07a835-1db0-4610-8661-380134b7d361",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "89192eae-1fe5-49b5-a25a-7b3b6c9bd6b6", "AQAAAAEAACcQAAAAEJGScSMtJZzl7wmrX6ZxPVZQ/dPUxpRe5SRTPWErXm6OgnFqwRhv/kJswkfy8ABPLg==", "f068f9a2-528e-44f3-be9b-96b80a01cec8" });

            migrationBuilder.UpdateData(
                table: "Concerts",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2021, 9, 27, 15, 13, 53, 902, DateTimeKind.Local).AddTicks(2921));

            migrationBuilder.UpdateData(
                table: "Concerts",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2021, 11, 27, 15, 13, 53, 903, DateTimeKind.Local).AddTicks(8624));

            migrationBuilder.UpdateData(
                table: "Concerts",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2021, 10, 27, 15, 13, 53, 903, DateTimeKind.Local).AddTicks(7666));

            migrationBuilder.UpdateData(
                table: "Concerts",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2021, 9, 27, 15, 13, 53, 903, DateTimeKind.Local).AddTicks(8024));
        }
    }
}
