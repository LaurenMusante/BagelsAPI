using Microsoft.EntityFrameworkCore;

namespace Bagels.Models
{
    public class BagelsContext : DbContext
    {
        public BagelsContext(DbContextOptions<BagelsContext> options) : base(options)
        {
        }

        public DbSet<Bagel> Bagels { get; set; }
        public DbSet<Topping> Toppings { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Bagel>()
                .HasData(
                    new Bagel { BagelId = 1, Flavor = "Plain", SuggestedToppings = "Butter"},
                    new Bagel { BagelId = 2, Flavor = "Sesame", SuggestedToppings = "Cream cheese, tomato, onion"},
                    new Bagel { BagelId = 3, Flavor = "Asiago", SuggestedToppings = "Cream cheese, cheddar cheese, and parmesan cheese"},
                    new Bagel { BagelId = 4, Flavor = "Salt", SuggestedToppings = "Extra cream cheese"},
                    new Bagel { BagelId = 5, Flavor = "Everything", SuggestedToppings = "Hummus, avocado, sprouts"},
                    new Bagel { BagelId = 6, Flavor = "Pumpernickle", SuggestedToppings = "Cream cheese, lox, capers, onion" },
                    new Bagel { BagelId = 7, Flavor = "Poppy Seed", SuggestedToppings = "Avocado, tomato, salt, capers" },
                    new Bagel { BagelId = 8, Flavor = "Bialy", SuggestedToppings = "Cream cheese, butter, salt, pepper" },
                    new Bagel { BagelId = 9, Flavor = "Multigrain", SuggestedToppings = "Butter, cinnamon-sugar" },
                    new Bagel { BagelId = 10, Flavor = "Whole Wheat", SuggestedToppings = "Extra avocado, cream cheese" },
                    new Bagel { BagelId = 11, Flavor = "Jalapeno", SuggestedToppings = "Cheddar cheese, hummus, pickled jalapenos" },
                    new Bagel { BagelId = 12, Flavor = "Cinnamon Raisin", SuggestedToppings = "Cream Cheese, extra raisins" },
                    new Bagel { BagelId = 13, Flavor = "Onion", SuggestedToppings = "Cream cheese, whole salmon"},
                    new Bagel { BagelId = 14, Flavor = "Garlic", SuggestedToppings = "Mayonnaise" },
                    new Bagel { BagelId = 15, Flavor = "Chocolate Chip", SuggestedToppings = "Nothing, just plain" },
                    new Bagel { BagelId = 16, Flavor = "Egg", SuggestedToppings = "Scambled egg, cheddar, bacon"},
                    new Bagel { BagelId = 17, Flavor = "Gluten-free Bagel", SuggestedToppings = "Spinach, lowfat Cream Cheese, avocado" }
                );

            builder.Entity<Topping>()
                .HasData(
                    new Topping { ToppingId = 1, Name = "Cream Cheese"},
                    new Topping { ToppingId = 2, Name = "Slice of Pizza"},
                    new Topping { ToppingId = 3, Name = "Salmon (whole fish)"},
                    new Topping { ToppingId = 4, Name = "Stick of Butter"},
                    new Topping { ToppingId = 5, Name = "Avocado"},
                    new Topping { ToppingId = 6, Name = "Burrito" },
                    new Topping { ToppingId = 7, Name = "Sushi Rolls" },
                    new Topping { ToppingId = 8, Name = "Noodles" },
                    new Topping { ToppingId = 9, Name = "Tomato" },
                    new Topping { ToppingId = 10, Name = "Sloppy Joes" },
                    new Topping { ToppingId = 11, Name = "Pesto" },
                    new Topping { ToppingId = 12, Name = "Lettuce" },
                    new Topping { ToppingId = 13, Name = "Alfredo Sauce" },
                    new Topping { ToppingId = 14, Name = "Bagel" },
                    new Topping { ToppingId = 15, Name = "Grilled Cheese Sandwich" },
                    new Topping { ToppingId = 16, Name = "Dumplings" },
                    new Topping { ToppingId = 17, Name = "Pickled Jalapenos" },
                    new Topping { ToppingId = 18, Name = "Cucumber" },
                    new Topping { ToppingId = 19, Name = "Pickles" },
                    new Topping { ToppingId = 20, Name = "Jasmine Rice" }

                );
        }
    }
}