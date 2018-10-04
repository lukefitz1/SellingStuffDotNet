using Microsoft.EntityFrameworkCore.Migrations;

namespace SellingStuffDotNet.Migrations
{
    public partial class SeedDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Products (Name, Sku, Price, SpecialPrice, Inventory, Description, Weight, Status) VALUES ('Product 1', 'product-1', 15, 10, 1000, 'Product 1 Description', 1, 1)");
            migrationBuilder.Sql("INSERT INTO Products (Name, Sku, Price, SpecialPrice, Inventory, Description, Weight, Status) VALUES ('Product 2', 'product-2', 20, 0, 1000, 'Product 2 Description', 2, 1)");
            migrationBuilder.Sql("INSERT INTO Products (Name, Sku, Price, SpecialPrice, Inventory, Description, Weight, Status) VALUES ('Product 3', 'product-3', 25, 0, 1000, 'Product 3 Description', 3, 1)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Products");
        }
    }
}
