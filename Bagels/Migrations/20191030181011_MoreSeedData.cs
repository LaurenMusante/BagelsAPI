using Microsoft.EntityFrameworkCore.Migrations;

namespace Bagels.Migrations
{
    public partial class MoreSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Bagels",
                columns: new[] { "BagelId", "Flavor", "SuggestedToppings" },
                values: new object[,]
                {
                    { 6, "Pumpernickle", "Cream cheese, lox, capers, onion" },
                    { 17, "Gluten-free Bagel", "Spinach, lowfat Cream Cheese, avocado" },
                    { 16, "Egg", "Scambled egg, cheddar, bacon" },
                    { 14, "Garlic", "Mayonnaise" },
                    { 13, "Onion", "Cream cheese, whole salmon" },
                    { 12, "Cinnamon Raisin", "Cream Cheese, extra raisins" },
                    { 15, "Chocolate Chip", "Nothing, just plain" },
                    { 10, "Whole Wheat", "Extra avocado, cream cheese" },
                    { 9, "Multigrain", "Butter, cinnamon-sugar" },
                    { 8, "Bialy", "Cream cheese, butter, salt, pepper" },
                    { 7, "Poppy Seed", "Avocado, tomato, salt, capers" },
                    { 11, "Jalapeno", "Cheddar cheese, hummus, pickled jalapenos" }
                });

            migrationBuilder.UpdateData(
                table: "Toppings",
                keyColumn: "ToppingId",
                keyValue: 4,
                column: "Name",
                value: "Stick of Butter");

            migrationBuilder.InsertData(
                table: "Toppings",
                columns: new[] { "ToppingId", "Name" },
                values: new object[,]
                {
                    { 14, "Bagel" },
                    { 18, "Cucumber" },
                    { 17, "Pickled Jalapenos" },
                    { 16, "Dumplings" },
                    { 15, "Grilled Cheese Sandwich" },
                    { 13, "Alfredo Sauce" },
                    { 6, "Burrito" },
                    { 11, "Pesto" },
                    { 10, "Sloppy Joes" },
                    { 9, "Tomato" },
                    { 8, "Noodles" },
                    { 7, "Sushi Rolls" },
                    { 19, "Pickles" },
                    { 12, "Lettuce" },
                    { 20, "Jasmine Rice" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Bagels",
                keyColumn: "BagelId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Bagels",
                keyColumn: "BagelId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Bagels",
                keyColumn: "BagelId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Bagels",
                keyColumn: "BagelId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Bagels",
                keyColumn: "BagelId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Bagels",
                keyColumn: "BagelId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Bagels",
                keyColumn: "BagelId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Bagels",
                keyColumn: "BagelId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Bagels",
                keyColumn: "BagelId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Bagels",
                keyColumn: "BagelId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Bagels",
                keyColumn: "BagelId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Bagels",
                keyColumn: "BagelId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Toppings",
                keyColumn: "ToppingId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Toppings",
                keyColumn: "ToppingId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Toppings",
                keyColumn: "ToppingId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Toppings",
                keyColumn: "ToppingId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Toppings",
                keyColumn: "ToppingId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Toppings",
                keyColumn: "ToppingId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Toppings",
                keyColumn: "ToppingId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Toppings",
                keyColumn: "ToppingId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Toppings",
                keyColumn: "ToppingId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Toppings",
                keyColumn: "ToppingId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Toppings",
                keyColumn: "ToppingId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Toppings",
                keyColumn: "ToppingId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Toppings",
                keyColumn: "ToppingId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Toppings",
                keyColumn: "ToppingId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Toppings",
                keyColumn: "ToppingId",
                keyValue: 20);

            migrationBuilder.UpdateData(
                table: "Toppings",
                keyColumn: "ToppingId",
                keyValue: 4,
                column: "Name",
                value: "Butter");
        }
    }
}
