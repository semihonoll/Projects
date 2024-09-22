using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _2_BookingMVCApp.Infrastructure.Migrations
{
    public partial class initialCatalog : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Villas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Sqft = table.Column<int>(type: "int", nullable: false),
                    Occupancy = table.Column<int>(type: "int", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Villas", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Villas",
                columns: new[] { "Id", "CreatedDate", "Description", "ImageUrl", "Name", "Occupancy", "Price", "Sqft", "UpdatedDate" },
                values: new object[] { 1, new DateTime(2024, 8, 21, 10, 2, 13, 63, DateTimeKind.Local).AddTicks(904), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed dictum porttitor semper. Fusce arcu justo, venenatis ac hendrerit ac, mollis a nisl. Vestibulum sagittis tellus justo, et hendrerit ligula vulputate eleifend. Duis mollis leo in augue malesuada, et congue purus elementum. Donec rutrum, erat nec pulvinar efficitur, odio sapien suscipit massa, id mattis libero massa rhoncus est. Suspendisse faucibus molestie posuere. Cras ut purus a urna fermentum dapibus. Pellentesque ut nibh mollis, venenatis ex sit amet, volutpat nisl. Maecenas elit tellus, cursus id placerat a, gravida vitae sem. Vestibulum vestibulum, tortor maximus dapibus ultricies, justo ligula tempor magna, eu aliquam sapien nunc vel nunc. Pellentesque a ullamcorper ligula. Cras nec finibus justo, non feugiat justo. Sed at tincidunt massa, a gravida neque. Curabitur ac rutrum mauris.", "https://via.placeholder.com/600x400", "Royal Villa", 4, 200m, 550, null });

            migrationBuilder.InsertData(
                table: "Villas",
                columns: new[] { "Id", "CreatedDate", "Description", "ImageUrl", "Name", "Occupancy", "Price", "Sqft", "UpdatedDate" },
                values: new object[] { 2, new DateTime(2024, 8, 21, 10, 2, 13, 63, DateTimeKind.Local).AddTicks(918), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed dictum porttitor semper. Fusce arcu justo, venenatis ac hendrerit ac, mollis a nisl. Vestibulum sagittis tellus justo, et hendrerit ligula vulputate eleifend. Duis mollis leo in augue malesuada, et congue purus elementum. Donec rutrum, erat nec pulvinar efficitur, odio sapien suscipit massa, id mattis libero massa rhoncus est. Suspendisse faucibus molestie posuere. Cras ut purus a urna fermentum dapibus. Pellentesque ut nibh mollis, venenatis ex sit amet, volutpat nisl. Maecenas elit tellus, cursus id placerat a, gravida vitae sem. Vestibulum vestibulum, tortor maximus dapibus ultricies, justo ligula tempor magna, eu aliquam sapien nunc vel nunc. Pellentesque a ullamcorper ligula. Cras nec finibus justo, non feugiat justo. Sed at tincidunt massa, a gravida neque. Curabitur ac rutrum mauris.", "https://via.placeholder.com/600x400", "Premium Royal Villa", 4, 300m, 550, null });

            migrationBuilder.InsertData(
                table: "Villas",
                columns: new[] { "Id", "CreatedDate", "Description", "ImageUrl", "Name", "Occupancy", "Price", "Sqft", "UpdatedDate" },
                values: new object[] { 3, new DateTime(2024, 8, 21, 10, 2, 13, 63, DateTimeKind.Local).AddTicks(919), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed dictum porttitor semper. Fusce arcu justo, venenatis ac hendrerit ac, mollis a nisl. Vestibulum sagittis tellus justo, et hendrerit ligula vulputate eleifend. Duis mollis leo in augue malesuada, et congue purus elementum. Donec rutrum, erat nec pulvinar efficitur, odio sapien suscipit massa, id mattis libero massa rhoncus est. Suspendisse faucibus molestie posuere. Cras ut purus a urna fermentum dapibus. Pellentesque ut nibh mollis, venenatis ex sit amet, volutpat nisl. Maecenas elit tellus, cursus id placerat a, gravida vitae sem. Vestibulum vestibulum, tortor maximus dapibus ultricies, justo ligula tempor magna, eu aliquam sapien nunc vel nunc. Pellentesque a ullamcorper ligula. Cras nec finibus justo, non feugiat justo. Sed at tincidunt massa, a gravida neque. Curabitur ac rutrum mauris.", "https://via.placeholder.com/600x400", "Luxury Royal Villa", 4, 400m, 750, null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Villas");
        }
    }
}
