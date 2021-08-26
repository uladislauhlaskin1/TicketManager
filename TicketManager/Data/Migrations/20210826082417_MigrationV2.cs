using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TicketManager.Data.Migrations
{
    public partial class MigrationV2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetUserTokens",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserTokens",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "ProviderKey",
                table: "AspNetUserLogins",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserLogins",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7210", "7689a8c1-982e-4cd1-9425-8f156fbc9f20", "Administrator", "ADMINISTRATOR" });

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
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ade4f8f4-3fc6-4397-a0a6-d7e9f4bb015b", "AQAAAAEAACcQAAAAEMht5d/rv1mSXKar5Kpug6mwZ9CHzzhp0akF5npx8sMfZM+i89bE4ZqMpIWzu4LLRQ==", "e8983378-ce38-43dc-94f5-d38bc0d851b9" });

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

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7210", "ab07a835-1db0-4610-8661-380134b7d361" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7210", "ab07a835-1db0-4610-8661-380134b7d361" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetUserTokens",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserTokens",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "ProviderKey",
                table: "AspNetUserLogins",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserLogins",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5c9b1c79-8cb8-4d85-b693-f8b1f6560dcd",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "20e9aa4f-bde8-4bf3-bb19-c9b74238d28c", "AQAAAAEAACcQAAAAEG066ACnO7Pe3JWrtW9/Xv7E3wVmPkPDDKzilniraysOh8gRKXSaYgEyiL/XqF5zhA==", "acbf103b-05c7-4f0d-b64a-5ca663f140f7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "79e3f8c0-d2cb-4fc0-b688-df6a4079cbec",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d6a5afe4-7e6c-4850-b33d-f6da17f7e471", "AQAAAAEAACcQAAAAEPB7NBK/JWcy09rgwGeOXWC1ix69P+ubHHfbtoxkp8Aq3n8VhQzYBvTO7hnX0c61rA==", "fa2d822d-a09b-47f7-bc1c-dba620e63c22" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "79e3f8c0-d3cb-4fc0-b688-df6a4079cbec",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ad96f93b-9a1a-42b0-a4f2-0ba65e7e7965", "AQAAAAEAACcQAAAAEJY8MjXFHHKboBJdQsh879cbaz7ISt1cv3RH7LkbpU0kKRGt10mzogwPTaDt8qQyFA==", "c8e1646f-0679-43a6-ace8-8b45cb87a688" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ab07a835-1db0-4610-8661-380134b7d361",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6acd4474-1cff-4a41-ae57-3ea0918c9938", "AQAAAAEAACcQAAAAEDxdknSoSe/5vy5G7Q0DQ1nnLD4RgnvF6EKOY5abo466zd59E0MHy9l9tHmmf41YcA==", "cf72a5af-8574-4e87-a5b1-cf0f42ab2a89" });

            migrationBuilder.UpdateData(
                table: "Concerts",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2021, 9, 26, 10, 29, 49, 895, DateTimeKind.Local).AddTicks(4027));

            migrationBuilder.UpdateData(
                table: "Concerts",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2021, 11, 26, 10, 29, 49, 897, DateTimeKind.Local).AddTicks(4358));

            migrationBuilder.UpdateData(
                table: "Concerts",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2021, 10, 26, 10, 29, 49, 897, DateTimeKind.Local).AddTicks(3424));

            migrationBuilder.UpdateData(
                table: "Concerts",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2021, 9, 26, 10, 29, 49, 897, DateTimeKind.Local).AddTicks(3784));
        }
    }
}
