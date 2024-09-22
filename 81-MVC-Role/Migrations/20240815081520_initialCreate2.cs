using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _81_MVC_Role.Migrations
{
    public partial class initialCreate2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8e4d71b4-0b7a-4b3a-93ee-0e85b672646f");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8e4d71b4-0b7a-4b3a-93ee-0e85b672646f", "d9aed44f-fd33-407e-a7e2-f64fa41601c5", "admin", "ADMIN" });
        }
    }
}
