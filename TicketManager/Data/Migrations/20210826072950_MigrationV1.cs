using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TicketManager.Data.Migrations
{
    public partial class MigrationV1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5c9b1c79-8cb8-4d85-b693-f8b1f6560dcd",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "658b0f2e-8b28-4382-aec6-8cf10da1afa3", "AQAAAAEAACcQAAAAEKCjnGUTLmes6oDPXaC52WfuR43XVOoc2V/6MOWDcQbh+DNp3pylguW/5flNf/X+jQ==", "33115a14-e40a-432b-9c2d-9a2097caee7f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "79e3f8c0-d2cb-4fc0-b688-df6a4079cbec",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1e0b422a-b695-4a1d-bef3-8509869ee15a", "AQAAAAEAACcQAAAAENoeXRI7/RuDajU5K5Bw0zb1/JV1VySPEu+DUINnR3YEFsbMmDFErUvO1jJ1ofYslA==", "476dd426-ca7b-41d1-ad50-faef670f37d1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "79e3f8c0-d3cb-4fc0-b688-df6a4079cbec",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "49c63850-d710-4d06-aa65-002b17d76b2e", "AQAAAAEAACcQAAAAEOCrEcFejTfQf9ZGxHHkYWo3ftcE8oOHdyycxQBzxlZTsQQWW5X0ruLPPKkpN+qk/Q==", "6993e1e4-7273-4224-a5e2-f01f6624aff4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ab07a835-1db0-4610-8661-380134b7d361",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3bf1f4e6-bcea-45ca-bd90-1f334c81b6d5", "AQAAAAEAACcQAAAAEHpoEXZxpGUMhEVvchTBHqxBOhfdAfv2ppixXtNLdU7y4B+CmEusNa0o0ghS/gAJFQ==", "d620e4a7-41ae-4b24-b03a-7a166073d390" });

            migrationBuilder.UpdateData(
                table: "Concerts",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2021, 9, 25, 17, 28, 42, 167, DateTimeKind.Local).AddTicks(7472));

            migrationBuilder.UpdateData(
                table: "Concerts",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2021, 11, 25, 17, 28, 42, 169, DateTimeKind.Local).AddTicks(741));

            migrationBuilder.UpdateData(
                table: "Concerts",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2021, 10, 25, 17, 28, 42, 168, DateTimeKind.Local).AddTicks(9825));

            migrationBuilder.UpdateData(
                table: "Concerts",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2021, 9, 25, 17, 28, 42, 169, DateTimeKind.Local).AddTicks(171));
        }
    }
}
