using Microsoft.EntityFrameworkCore.Migrations;

namespace UsuariosApi.Migrations
{
    public partial class AdicionandoCustomIdentityUservalidation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 99997,
                column: "ConcurrencyStamp",
                value: "96c13b1c-c8d7-48ab-a110-f09d6a6f5c68");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 99999,
                column: "ConcurrencyStamp",
                value: "08a187b1-9364-44fb-91c7-5bf29b1e69f2");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 99999,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1372ccec-f41c-418a-9f29-2e5a7a059c72", "AQAAAAEAACcQAAAAEPtMhXRknEWRwh4VVa5BAWMCmIiInuKyF5uz04kdXba3RplHnNCIHAdUM47De8d+Lw==", "1c53f7ba-99a5-4e08-b208-93df39993a39" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 99997,
                column: "ConcurrencyStamp",
                value: "2217d886-0657-439b-af72-5c02049fe8d3");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 99999,
                column: "ConcurrencyStamp",
                value: "fc3a8e3b-05ad-4004-be1e-43c719d628a0");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 99999,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "407e2da0-b8e8-4d59-a931-6898d4ef6520", "AQAAAAEAACcQAAAAELsjBhi2+ZD2776iXr8jJGqrkWYIUBEukv+zdrncAcGmKLARfj/HsOi7miR5kjyO3g==", "e59bcb4d-d84f-40d3-8a05-477db33abd0f" });
        }
    }
}
