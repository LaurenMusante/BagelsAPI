using Microsoft.EntityFrameworkCore.Migrations;

namespace Bagels.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Bagels",
                columns: new[] { "BagelId", "Flavor", "SuggestedToppings" },
                values: new object[,]
                {
                    { 1, "Plain", "Butter" },
                    { 2, "Sesame", "Cream cheese, tomato, onion" },
                    { 3, "Asiago", "Cream cheese, cheddar cheese, and parmesan cheese" },
                    { 4, "Salt", "Extra cream cheese" },
                    { 5, "Everything", "Hummus, avocado, sprouts" }
                });

            migrationBuilder.InsertData(
                table: "Toppings",
                columns: new[] { "ToppingId", "Name" },
                values: new object[,]
                {
                    { 1, "Cream Cheese" },
                    { 2, "Slice of Pizza" },
                    { 3, "Salmon (whole fish)" },
                    { 4, "Butter" },
                    { 5, "Avocado" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Bagels",
                keyColumn: "BagelId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Bagels",
                keyColumn: "BagelId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Bagels",
                keyColumn: "BagelId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Bagels",
                keyColumn: "BagelId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Bagels",
                keyColumn: "BagelId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Toppings",
                keyColumn: "ToppingId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Toppings",
                keyColumn: "ToppingId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Toppings",
                keyColumn: "ToppingId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Toppings",
                keyColumn: "ToppingId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Toppings",
                keyColumn: "ToppingId",
                keyValue: 5);
        }
    }
}
