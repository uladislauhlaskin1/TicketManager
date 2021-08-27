using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TicketManager.Data.Migrations
{
    public partial class MigrationV3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ec80b441-4bf6-465f-a03b-4dfb93372de5", "AQAAAAEAACcQAAAAEFLYyVLK/q480LsrnqZxsDZ1PFsqr6ODN5rm3o5RXMtDHLZBVayPv8lFW2J0yiUTHw==", "23eacf5e-f6e2-4346-ac97-b84f5a009e68" });

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
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "89192eae-1fe5-49b5-a25a-7b3b6c9bd6b6", "ADMIN@MAIL.COM", "AQAAAAEAACcQAAAAEJGScSMtJZzl7wmrX6ZxPVZQ/dPUxpRe5SRTPWErXm6OgnFqwRhv/kJswkfy8ABPLg==", "f068f9a2-528e-44f3-be9b-96b80a01cec8", "admin@mail.com" });

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

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 53.915047999999999, 27.6980264 });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 53.836269000000001, 27.413867 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                column: "ConcurrencyStamp",
                value: "7689a8c1-982e-4cd1-9425-8f156fbc9f20");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5c9b1c79-8cb8-4d85-b693-f8b1f6560dcd",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8dfc84b7-a02f-41d4-9582-febad7616be8", "AQAAAAEAACcQAAAAEO9SftK50OYGBEodir6vIHPt3a3ISlBtooxyAUtJJB3RqJL40U6RjUGT3IcMC5JUVw==", "6f0af889-567d-498d-9ffe-f3ecd421c21d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "79e3f8c0-d2cb-4fc0-b688-df6a4079cbec",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "356e0fa0-6003-4737-8036-f3bd6716a662", "AQAAAAEAACcQAAAAEIw6GSc2+MaeJUy3oLIWDMJuQuq4+uobx9yulCONY7aAiicgSUntO0j9vxIieHEN8Q==", "e5d2d128-5788-45c2-9298-eaf1a8942c78" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "79e3f8c0-d3cb-4fc0-b688-df6a4079cbec",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a9ee7805-9312-4ea0-91c7-1cf5bb627f97", "AQAAAAEAACcQAAAAEBOIlnAOzwjQOgLcAswuIzEfb83Os7XHS6vqbSm8c8GfhLqapdydurcKg3dxq3Hx1Q==", "88cd7478-d559-4adc-9c9f-49b48ed783f5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ab07a835-1db0-4610-8661-380134b7d361",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "ade4f8f4-3fc6-4397-a0a6-d7e9f4bb015b", "ADMIN@CONCERTS.COM", "AQAAAAEAACcQAAAAEMht5d/rv1mSXKar5Kpug6mwZ9CHzzhp0akF5npx8sMfZM+i89bE4ZqMpIWzu4LLRQ==", "e8983378-ce38-43dc-94f5-d38bc0d851b9", "admin@concerts.com" });

            migrationBuilder.UpdateData(
                table: "Concerts",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2021, 9, 26, 11, 24, 16, 460, DateTimeKind.Local).AddTicks(854));

            migrationBuilder.UpdateData(
                table: "Concerts",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2021, 11, 26, 11, 24, 16, 461, DateTimeKind.Local).AddTicks(8711));

            migrationBuilder.UpdateData(
                table: "Concerts",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2021, 10, 26, 11, 24, 16, 461, DateTimeKind.Local).AddTicks(7760));

            migrationBuilder.UpdateData(
                table: "Concerts",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2021, 9, 26, 11, 24, 16, 461, DateTimeKind.Local).AddTicks(8111));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 33.333300000000001, 44.444400000000002 });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 22.222200000000001, 55.555500000000002 });
        }
    }
}
