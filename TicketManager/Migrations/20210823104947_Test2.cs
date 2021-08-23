using Microsoft.EntityFrameworkCore.Migrations;

namespace TicketManager.Migrations
{
    public partial class Test2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Locations",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NameRu",
                table: "Locations",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Bands",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Nightwish" },
                    { 2, "Dio" },
                    { 3, "The Offspring" },
                    { 4, "Some classic singer" },
                    { 5, "Another singer" }
                });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Latitude", "Longitude", "Name" },
                values: new object[] { 33.333300000000001, 44.444400000000002, "Unknown location" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "Id", "Latitude", "Longitude", "Name", "NameRu" },
                values: new object[] { 2, 22.222200000000001, 55.555500000000002, "Another location", null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Bands",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Bands",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Bands",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Bands",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Bands",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Locations");

            migrationBuilder.DropColumn(
                name: "NameRu",
                table: "Locations");

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 2.1110000000000002, 3.1122999999999998 });
        }
    }
}
