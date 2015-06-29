using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UnamiSushi.Models;

namespace UnamiSushi.DAL
{
    public class PrototypeInitializer : System.Data.Entity.DropCreateDatabaseAlways<PrimaryContext>
    {
        protected override void Seed(PrimaryContext context)
        {
             var menuCategories = new List<MenuCategory>
            {
                new MenuCategory{CategoryID=1, CategoryName="Sushi-Burritos", CategoryDescription="Sushi combined into a burrito rice wrap"},
                new MenuCategory{CategoryID=2, CategoryName="Sushi-Rolls", CategoryDescription="Contains your classic california roll to special rolls"},
                new MenuCategory{CategoryID=3, CategoryName="Asian-Grill", CategoryDescription="Asian Grills are your traditional cooked japansese foods like teryaki, stir-fry, and curries"},
                new MenuCategory{CategoryID=4, CategoryName="Appetizers", CategoryDescription="A wide selection of our delicious appetizers"},
            };
            menuCategories.ForEach(s => context.MenuCategories.Add(s));
            context.SaveChanges();

            var subcategories = new List<Subcategory>
            {
                new Subcategory{SubcategoryID=1, SubcategoryName="Classic Sushidos", CategoryID=1, SubcategoryDescription="Based on classic sushi rolls"},//1
                new Subcategory{SubcategoryID=2, SubcategoryName="Premium Sushidos", CategoryID=1, SubcategoryDescription="Based on special sushi rolls"},//2
                new Subcategory{SubcategoryID=3, SubcategoryName="Veggie Sushidos", CategoryID=1, SubcategoryDescription="Sushidos for vegearians"},//3

                new Subcategory{SubcategoryID=4, SubcategoryName="Original Rolls",CategoryID=2, SubcategoryDescription="Classic simple rolls"},//4
                new Subcategory{SubcategoryID=5, SubcategoryName="Special Rolls", CategoryID=2, SubcategoryDescription="Sushi rolls with a twist"},//5
                new Subcategory{SubcategoryID=6, SubcategoryName="Tempura Rolls", CategoryID=2, SubcategoryDescription="Don't even know"},//6

                new Subcategory{SubcategoryID=7, SubcategoryName="Teryaki", CategoryID=3, SubcategoryDescription="Marinated in our delicious blend of garlic, ginger, brown sugar, Fuji apples, sherry, and soy sauce. Grilled and served with rices"},
                new Subcategory{SubcategoryID=8, SubcategoryName="Stir-Fry", CategoryID=3, SubcategoryDescription="Stir-fried onions, mushroom, red bell peppers, broccoli, carrots, and celery in a garlic rice wine soy. Choice of white rice or noodles. Served with a side of sriracha "},
                new Subcategory{SubcategoryID=9, SubcategoryName="Japanese Curry", CategoryID=3, SubcategoryDescription="Stir-fried onions, mushroom, red bell peppers, broccoli, and carrots, in a delicious brown curry sauce. Served with white rice and a side of sriracha chili sauce"},
                new Subcategory{SubcategoryID=10, SubcategoryName="Sweet & Sour", CategoryID=3, SubcategoryDescription="Hand battered and tossed in our delicious sweet & sour sauce with stir-fried onions, mushrooms, bell peppers, and broccoli. Served with  choice of white rice or noodles"},
                new Subcategory{SubcategoryID=11, SubcategoryName="General Tso’s", CategoryID=3, SubcategoryDescription="Hand battered and tossed in our delicious spicy General Tso’s sauce with stir-fried onions, mushrooms, bell peppers, and broccoli. Served with choice of steamed white rice or noodles"},
                new Subcategory{SubcategoryID=12, SubcategoryName="Orange", CategoryID=3, SubcategoryDescription="Stir-fried onions, mushroom, red bell peppers, and broccoli in our delicious ginger orange sauce. Served with choice of steamed white rice or noodles"},
            
                new Subcategory{SubcategoryID=13, SubcategoryName="Appetizers", CategoryID=4, SubcategoryDescription="A varied selection of small starter dishes."}
            };
            subcategories.ForEach(s => context.Subcategories.Add(s));
            context.SaveChanges();

            var menuItems = new List<MenuItem>
            {
                // Classic Sushidos
                new MenuItem{MenuItemID=1, SubcategoryID=1, MenuItemName="Califronia", Piece=0, Cooked=true, Vegetarian=false,
                MenuItemDescription="Surimi crab, avocado, cream cheese, cucumber, tempura flakes, carrot, seaweed salad, sweet soy reduction",
                MenuItemPrice= 8.95},
                new MenuItem{MenuItemID=2, SubcategoryID=1, MenuItemName="Neptune", Piece=0, Cooked=true, Vegetarian=false, 
                MenuItemDescription="Tempura calamri, spicy cream cheese, avacado, cucumber, tempura flakes, shredded carrot, seaweed salad, spicy sauce, sweet soy reduction",
                MenuItemPrice= 10.95},
                new MenuItem{MenuItemID=3, SubcategoryID=1, MenuItemName="Spicy Tuna", Piece=0, Cooked=false, Vegetarian=false,
                MenuItemDescription="Avacado, cucumber, spicey tuna, tempura flakes, carrot, seaweed salad, spicy sauce, sweet soy reduction",
                MenuItemPrice= 12.95},
                new MenuItem{MenuItemID=4, SubcategoryID=1, MenuItemName="Ginger Sake", Piece=0, Cooked=false, Vegetarian=false,
                MenuItemDescription="Fresh salmon, grated ginger, tempura shrimp, avocado, cucumber, shredded carrot, seaweed salad, sesame ginger poke` sauce, sweet soy reduction",
                MenuItemPrice= 11.49},
                new MenuItem{MenuItemID=5, SubcategoryID=1, MenuItemName="MGM", Piece=0, Cooked=false, Vegetarian=false,
                MenuItemDescription="Cream Cheese, avocado, fresh salmon, tempura asparagus, cucumber, pickled jalapeno, seaweed salad, carrot, sweet soy reduction, dynamite sauce",
                MenuItemPrice= 12.95},

                // Premium Sushidos
                new MenuItem{MenuItemID=6, SubcategoryID=2, MenuItemName="Big Foot", Piece=0, Cooked=false, Vegetarian=false,
                MenuItemDescription="Spicy cream cheese, spicy tuna, grilled gulf shrimp, surimi crab, tempura flakes, avocado, cucumber, seaweed salad, sweet garlic sauce, spicy sauce, sweet soy reduction",
                MenuItemPrice= 14.95},
                new MenuItem{MenuItemID=7, SubcategoryID=2, MenuItemName="#Bacon", Piece=0, Cooked=true, Vegetarian=false,
                MenuItemDescription="Cream cheese, Roasted jalapeno, spicy tuna, fresh salmon, tempura Applewood smoked bacon, avocado, cucumber,  sriracha maple sauce",
                MenuItemPrice= 15.49},
                new MenuItem{MenuItemID=8, SubcategoryID=2, MenuItemName="Mt. Hood", Piece=0, Cooked=true, Vegetarian=false, 
                MenuItemDescription="Cream cheese, smoked salmon, tempura flakes, avocado, cucumber, surimi crab, seaweed salad, carrots, sweet wasabi sauce",
                MenuItemPrice = 15.49},
                new MenuItem{MenuItemID=9, SubcategoryID=2, MenuItemName="Samurai", Piece=0, Cooked=false, Vegetarian=false,
                MenuItemDescription="Fresh salmon, yellowtail, yellow fin tuna, and seared pacific albacore tuna sashimi, avocado, cucumber, tempura green onion, shaved red cabbage, refreshing lemon ginger vinegar",
                MenuItemPrice = 16.49},
                new MenuItem{MenuItemID=10, SubcategoryID=2, MenuItemName="Caribbean", Piece=0, Cooked=false, Vegetarian=false,
                MenuItemDescription="Cream cheese, fresh salmon, coconut shrimp, avocado, cucumber, mango, coconut, sweet chili sauce",
                MenuItemPrice = 12.49},
                new MenuItem{MenuItemID=11, SubcategoryID=2, MenuItemName="Black Widow", Piece=0, Cooked=false, Vegetarian=false, 
                MenuItemDescription="Sesame seared albacore tuna, grilled shrimp, surimi crab, spicy cream cheese, avocado, cucumber, shredded carrot, seaweed salad, dynamite sauce, sweet soy reduction",
                MenuItemPrice = 12.95},
                new MenuItem{MenuItemID=12, SubcategoryID=2, MenuItemName="Ling Ling", Piece=0, Cooked=false, Vegetarian=false, 
                MenuItemDescription="Tempura soft shell crab, spicy cream cheese, fresh salmon, teriyaki eel, surimi crab, avocado, cucumber, shredded carrot, seaweed salad, sriracha, sweet soy reduction",
                MenuItemPrice = 16.49},
                new MenuItem{MenuItemID=13, SubcategoryID=2, MenuItemName="M-80", Piece=0, Cooked=false, Vegetarian=false, 
                MenuItemDescription="Pepper seared ahi tuna, panko sea scallop, masago, roasted jalapeno, pickled jalapeno, avocado, cucumber, green onions, seaweed salad, spicy chili garlic sauce, spicy sauce ",
                MenuItemPrice = 15.49},
                new MenuItem{MenuItemID=14, SubcategoryID=2, MenuItemName="Dan Klein", Piece=0, Cooked=false, Vegetarian=false,  
                MenuItemDescription="Half a pound of lemon pepper seared salmon, avocado, cucumber, grilled shrimp, pickled jalapeno, sweet soy reduction, sriracha, wrapped in seaweed",
                MenuItemPrice = 14.49},
                new MenuItem{MenuItemID=15, SubcategoryID=2, MenuItemName="Panda", Piece=0, Cooked=true, Vegetarian=false, 
                MenuItemDescription="Tempura shrimp, surimi crab, avocado, cucumber, carrot, seaweed salad, sweet garlic sauce, sweet soy reduction",
                MenuItemPrice = 12.49},
                new MenuItem{MenuItemID=16, SubcategoryID=2, MenuItemName="Magic Cap", Piece=0, Cooked=false, Vegetarian=false,
                MenuItemDescription="Spicy cream cheese, avocado, cucumber, crispy panko mushroom, spicy tuna, seaweed salad, carrot, sweet garlic sauce, sweet soy reduction",
                MenuItemPrice = 13.95},
                new MenuItem{MenuItemID=17, SubcategoryID=2, MenuItemName="Caterpillar", Piece=0, Cooked=true, Vegetarian=false, 
                MenuItemDescription="Cream cheese, teriyaki eel, tempura shrimp, surimi crab, avocado, cucumber, tempura flakes, seaweed salad, sweet soy reduction",
                MenuItemPrice = 15.49},

                //Veggie Sushidos
                new MenuItem{MenuItemID=18, SubcategoryID=3, MenuItemName="Hipster", Piece=0, Cooked=false, Vegetarian=true,
                MenuItemDescription="Grilled asparagus, grilled mushrooms, red bell pepper, avocado, carrots, cucumber, pickled daikon radish, pickled burdock root, seaweed salad, sweet soy reduction, sweet garlic sauce",
                MenuItemPrice = 8.95},
                new MenuItem{MenuItemID=19, SubcategoryID=3, MenuItemName="Sweet Deandra", Piece=0, Cooked=false, Vegetarian=true,
                MenuItemDescription="Tempura asparagus, cream cheese, avocado, cucumber, shredded carrot, seaweed salad, sweet soy reduction",
                MenuItemPrice = 8.49},

                // Sushi Rolls
                new MenuItem{MenuItemID=20, SubcategoryID=4, MenuItemName="California", Piece=8, Cooked=true, Vegetarian=false,
                MenuItemDescription="Avocado, cucumber, crab cake",
                MenuItemPrice = 4.25},
                new MenuItem{MenuItemID=21, SubcategoryID=4, MenuItemName="Philly", Piece=8, Cooked=false, Vegetarian=false,
                MenuItemDescription="Fresh salmon, cream cheese, scallions, and cucumbers",
                MenuItemPrice = 4.25},
                new MenuItem{MenuItemID=22, SubcategoryID=4, MenuItemName="Spicy Roll", Piece=8, Cooked=false, Vegetarian=false,
                MenuItemDescription="Choice of tuna, salmon,or scallop, and avocado",
                MenuItemPrice = 5.25},
                new MenuItem{MenuItemID=23, SubcategoryID=4, MenuItemName="Ducks Roll", Piece=5, Cooked=true, Vegetarian=false,
                MenuItemDescription="Tempura shrimp, masago & veggies w/ Japanese mayo",
                MenuItemPrice = 5.49},
                new MenuItem{MenuItemID=24, SubcategoryID=4, MenuItemName="Assorted Veggie", Piece=8, Cooked=true, Vegetarian=false,
                MenuItemDescription="Avocado, cucumber, asparagus, scallion, carrots",
                MenuItemPrice = 3.95},
                new MenuItem{MenuItemID=25, SubcategoryID=4, MenuItemName="Sweet Dee", Piece=8, Cooked=true, Vegetarian=false,
                MenuItemDescription="Tempura asparagus, cream cheese, sweet soy reduction",
                MenuItemPrice = 3.95},
                new MenuItem{MenuItemID=26, SubcategoryID=4, MenuItemName="Garden", Piece=8, Cooked=true, Vegetarian=false,
                MenuItemDescription="Cream cheese, asparagus, pickled burdock root, cucumber, pickled daikon radish, scallions, red bell pepper, avocado, garlic sauce",
                MenuItemPrice = 6.95},
                new MenuItem{MenuItemID=27, SubcategoryID=4, MenuItemName="Squidward", Piece=8, Cooked=true, Vegetarian=false,
                MenuItemDescription="Spicy tempura fried calamari, scallions, masago, avocado",
                MenuItemPrice = 6.49},
                new MenuItem{MenuItemID=28, SubcategoryID=5, MenuItemName="Trident", Piece=6, Cooked=true, Vegetarian=false,
                MenuItemDescription="Tempura calamari, snow crab, spicy cream cheese, avocado, cucumber, scallions, spicy sauce",
                MenuItemPrice = 7.95},
                new MenuItem{MenuItemID=29, SubcategoryID=5, MenuItemName="Florida", Piece=8, Cooked=false, Vegetarian=false,
                MenuItemDescription="Creamy scallop and avocado topped with fresh salmon, masago, and lemon zest",
                MenuItemPrice = 10.95},
                new MenuItem{MenuItemID=30, SubcategoryID=5, MenuItemName="Super Panda", Piece=6, Cooked=true, Vegetarian=false,
                MenuItemDescription="Tempura shrimp, avocado, cucumber, snow crab, topped with sweet roasted garlic sauce",
                MenuItemPrice = 8.49},
                new MenuItem{MenuItemID=31, SubcategoryID=5, MenuItemName="Spider", Piece=6, Cooked=true, Vegetarian=false,
                MenuItemDescription="Tempura soft shell crab, avocado, cucumber, tare,",
                MenuItemPrice = 8.95},
                new MenuItem{MenuItemID=32, SubcategoryID=5, MenuItemName="Tiger", Piece=6, Cooked=false, Vegetarian=false,
                MenuItemDescription="Spicy tuna, cucumber, topped with avocado, shrimp, tempura flakes, chili sauce, chili spices",
                MenuItemPrice = 10.95},
                new MenuItem{MenuItemID=33, SubcategoryID=5, MenuItemName="Rainbow", Piece=8, Cooked=false, Vegetarian=false,
                MenuItemDescription="Snow crab, avocado, cucumber, top with 5 fish and mango sauce",
                MenuItemPrice = 13.49},
                new MenuItem{MenuItemID=34, SubcategoryID=5, MenuItemName="Alaskan", Piece=8, Cooked=false, Vegetarian=false,
                MenuItemDescription="Hard Smoked salmon, cream cheese, cucumber, top w/avocado, salmon and sweet wasabi sauce",
                MenuItemPrice = 12.49},
                new MenuItem{MenuItemID=35, SubcategoryID=5, MenuItemName="Dynamite", Piece=8, Cooked=false, Vegetarian=false,
                MenuItemDescription="Tempura shrimp, cucumber, top with avocado, yellowtail, spicy tuna, jalapeño, dynamite sauce",
                MenuItemPrice = 15.95},
                new MenuItem{MenuItemID=36, SubcategoryID=5, MenuItemName="Atlantis", Piece=8, Cooked=false, Vegetarian=false,
                MenuItemDescription="Tempura soft shell crab topped with avocado, fresh salmon, eel, snow crab, and spicy tare` sauce",
                MenuItemPrice = 16.49},
                new MenuItem{MenuItemID=37, SubcategoryID=5, MenuItemName="Electric Eel", Piece=8, Cooked=false, Vegetarian=false,
                MenuItemDescription="Tempura eel, sea scallop, topwith avocado, snow crab, spicy chili garlic, and sweet sauce",
                MenuItemPrice = 15.95},

                //Tempura Rolls
                new MenuItem{MenuItemID=38, SubcategoryID=6, MenuItemName="Wonton", Piece=6, Cooked=true, Vegetarian=false,
                MenuItemDescription="Cream cheese, avocado, scallions, choice of shrimp or surimi crab",
                MenuItemPrice = 7.49},
                new MenuItem{MenuItemID=39, SubcategoryID=6, MenuItemName="Wolverine", Piece=6, Cooked=false, Vegetarian=false,
                MenuItemDescription="Spicy tuna, snow crab, spicy cream cheese, avocado, cucumber, top with sweet garlic and spicy sauces",
                MenuItemPrice = 8.95},
                new MenuItem{MenuItemID=40, SubcategoryID=6, MenuItemName="Vegas", Piece=10, Cooked=false, Vegetarian=false,
                MenuItemDescription="Fresh salmon, cream cheese, avocado, scallions, jalapeño, top with dynamite and sweet sauces",
                MenuItemPrice = 7.25},
                new MenuItem{MenuItemID=41, SubcategoryID=6, MenuItemName="Eskimo	", Piece=6, Cooked=true, Vegetarian=false,
                MenuItemDescription="Smoked salmon, snow crab, cream cheese, avocado, cucumber, topped with sweet wasabi sauce",
                MenuItemPrice = 8.95},
                new MenuItem{MenuItemID=42, SubcategoryID=6, MenuItemName="Cali Crunch", Piece=10, Cooked=true, Vegetarian=false,
                MenuItemDescription="California roll with sweet sauce",
                MenuItemPrice = 5.25},

                // Grills 

                // Teryaki
                new MenuItem{MenuItemID=43, SubcategoryID=7, MenuItemName="Chicken", Piece=0, Cooked=true, Vegetarian=false,
                MenuItemDescription="Marinated in our delicious blend of garlic, ginger, brown sugar, Fuji apples, sherry, and soy sauce. Grilled and served with rice",
                MenuItemPrice = 9.95},
                new MenuItem{MenuItemID=44, SubcategoryID=7, MenuItemName="Sirloin Steak", Piece=0, Cooked=true, Vegetarian=false,
                MenuItemDescription="Marinated in our delicious blend of garlic, ginger, brown sugar, Fuji apples, sherry, and soy sauce. Grilled and served with rice",
                MenuItemPrice = 10.95},
                new MenuItem{MenuItemID=45, SubcategoryID=7, MenuItemName="Tiger Shrimp", Piece=0, Cooked=true, Vegetarian=false,
                MenuItemDescription="Marinated in our delicious blend of garlic, ginger, brown sugar, Fuji apples, sherry, and soy sauce. Grilled and served with rice",
                MenuItemPrice = 10.95},

                // Stiry Fry
                new MenuItem{MenuItemID=46, SubcategoryID=8, MenuItemName="Tofu", Piece=0, Cooked=true, Vegetarian=false,
                MenuItemDescription="Stir-fried onions, mushroom, red bell peppers, broccoli, carrots, and celery in a garlic rice wine soy. Choice of white rice or noodles. Served with a side of sriracha ",
                MenuItemPrice = 8.95},
                new MenuItem{MenuItemID=47, SubcategoryID=8, MenuItemName="Chicken", Piece=0, Cooked=true, Vegetarian=false,
                MenuItemDescription="Stir-fried onions, mushroom, red bell peppers, broccoli, carrots, and celery in a garlic rice wine soy. Choice of white rice or noodles. Served with a side of sriracha ",
                MenuItemPrice = 9.95},
                new MenuItem{MenuItemID=48, SubcategoryID=8, MenuItemName="Sirloin Steak", Piece=0, Cooked=true, Vegetarian=false,
                MenuItemDescription="Stir-fried onions, mushroom, red bell peppers, broccoli, carrots, and celery in a garlic rice wine soy. Choice of white rice or noodles. Served with a side of sriracha ",
                MenuItemPrice = 10.95},
                new MenuItem{MenuItemID=49, SubcategoryID=8, MenuItemName="Tiger Shrimp", Piece=0, Cooked=true, Vegetarian=false,
                MenuItemDescription="Stir-fried onions, mushroom, red bell peppers, broccoli, carrots, and celery in a garlic rice wine soy. Choice of white rice or noodles. Served with a side of sriracha ",
                MenuItemPrice = 10.95},

                // Japenese Curry
                new MenuItem{MenuItemID=50, SubcategoryID=9, MenuItemName="Tofu Japansese", Piece=0, Cooked=true, Vegetarian=false,
                MenuItemDescription="Stir-fried onions, mushroom, red bell peppers, broccoli, and carrots, in a delicious brown curry sauce. Served with white rice and a side of sriracha chili sauce",
                MenuItemPrice = 8.95},
                new MenuItem{MenuItemID=51, SubcategoryID=9, MenuItemName="Chicken", Piece=0, Cooked=true, Vegetarian=false,
                MenuItemDescription="Stir-fried onions, mushroom, red bell peppers, broccoli, and carrots, in a delicious brown curry sauce. Served with white rice and a side of sriracha chili sauce",
                MenuItemPrice = 9.95},
                new MenuItem{MenuItemID=52, SubcategoryID=9, MenuItemName="Sirloin Steak", Piece=0, Cooked=true, Vegetarian=false,
                MenuItemDescription="Stir-fried onions, mushroom, red bell peppers, broccoli, and carrots, in a delicious brown curry sauce. Served with white rice and a side of sriracha chili sauce",
                MenuItemPrice = 10.95},
                new MenuItem{MenuItemID=53, SubcategoryID=9, MenuItemName="Tiger Shrimp", Piece=0, Cooked=true, Vegetarian=false,
                MenuItemDescription="Stir-fried onions, mushroom, red bell peppers, broccoli, and carrots, in a delicious brown curry sauce. Served with white rice and a side of sriracha chili sauce",
                MenuItemPrice = 10.95},

                // Sweet & Sour 
                new MenuItem{MenuItemID=54, SubcategoryID=10, MenuItemName="Tofu", Piece=0, Cooked=true, Vegetarian=false,
                MenuItemDescription="Hand battered and tossed in our delicious sweet & sour sauce with stir-fried onions, mushrooms, bell peppers, and broccoli. Served with  choice of white rice or noodles",
                MenuItemPrice = 8.95},
                new MenuItem{MenuItemID=55, SubcategoryID=10, MenuItemName="Chicken", Piece=0, Cooked=true, Vegetarian=false,
                MenuItemDescription="Hand battered and tossed in our delicious sweet & sour sauce with stir-fried onions, mushrooms, bell peppers, and broccoli. Served with  choice of white rice or noodles",
                MenuItemPrice = 9.95},
                new MenuItem{MenuItemID=56, SubcategoryID=10, MenuItemName="Tiger Shrimp", Piece=0, Cooked=true, Vegetarian=false,
                MenuItemDescription="Hand battered and tossed in our delicious sweet & sour sauce with stir-fried onions, mushrooms, bell peppers, and broccoli. Served with  choice of white rice or noodles",
                MenuItemPrice = 10.95},

                // General TSO's 
                new MenuItem{MenuItemID=57, SubcategoryID=11, MenuItemName="Tofu", Piece=0, Cooked=true, Vegetarian=false,
                MenuItemDescription="Hand battered and tossed in our delicious spicy General Tso’s sauce with stir-fried onions, mushrooms, bell peppers, and broccoli. Served with  choice of white rice or noodles",
                MenuItemPrice = 8.95},
                new MenuItem{MenuItemID=58, SubcategoryID=11, MenuItemName="Chicken", Piece=0, Cooked=true, Vegetarian=false,
                MenuItemDescription="Hand battered and tossed in our delicious spicy General Tso’s sauce with stir-fried onions, mushrooms, bell peppers, and broccoli. Served with  choice of white rice or noodles",
                MenuItemPrice = 9.95},
                new MenuItem{MenuItemID=59, SubcategoryID=11, MenuItemName="Tiger Shrimp", Piece=0, Cooked=true, Vegetarian=false,
                MenuItemDescription="Hand battered and tossed in our delicious spicy General Tso’s sauce with stir-fried onions, mushrooms, bell peppers, and broccoli. Served with  choice of white rice or noodles",
                MenuItemPrice = 10.95},

                // Orange
                new MenuItem{MenuItemID=60, SubcategoryID=12, MenuItemName="Tofu", Piece=0, Cooked=true, Vegetarian=false,
                MenuItemDescription="Stir-fried onions, mushroom, red bell peppers, and broccoli in our delicious ginger orange sauce. Served with choice of steamed white rice or noodles",
                MenuItemPrice = 8.95},
                new MenuItem{MenuItemID=61, SubcategoryID=12, MenuItemName="Chicken", Piece=0, Cooked=true, Vegetarian=false,
                MenuItemDescription="Stir-fried onions, mushroom, red bell peppers, and broccoli in our delicious ginger orange sauce. Served with choice of steamed white rice or noodles",
                MenuItemPrice = 9.95},
                new MenuItem{MenuItemID=62, SubcategoryID=12, MenuItemName="Tiger Shrimp", Piece=0, Cooked=true, Vegetarian=false,
                MenuItemDescription="Stir-fried onions, mushroom, red bell peppers, and broccoli in our delicious ginger orange sauce. Served with choice of steamed white rice or noodles",
                MenuItemPrice = 10.95},

                // Appetizers
                new MenuItem{MenuItemID=63, SubcategoryID=13, MenuItemName="Crispy Stuffed Shrooms", Piece=0, Cooked=true, Vegetarian=false,
                MenuItemDescription="Fresh mushrooms panko breaded and quick fried, stuffed with chili cream cheese, spicy tuna and topped with a roasted garlic sauce",
                MenuItemPrice = 7.95},
                new MenuItem{MenuItemID=64, SubcategoryID=13, MenuItemName="Pork Gyozas", Piece=6, Cooked=true, Vegetarian=false,
                MenuItemDescription="Pork and vegetable pot stickers, choose steamed or deep fried. Served with sweet chili sauce and sriracha chili vinegar soy sauce",
                MenuItemPrice = 5.25},
                new MenuItem{MenuItemID=65, SubcategoryID=13, MenuItemName="Coconut Shrimp", Piece=6, Cooked=true, Vegetarian=false,
                MenuItemDescription="Coconut breaded shrimp fried and served with sweet mango sauce",
                MenuItemPrice = 6.95},
                new MenuItem{MenuItemID=66, SubcategoryID=13, MenuItemName="Tempura", Piece=6, Cooked=true, Vegetarian=false,
                MenuItemDescription="Your choice of shrimp, calamari, or vegetables hand battered and lightly fried. Served with sweet sake soy sauce",
                MenuItemPrice = 5.49},
                new MenuItem{MenuItemID=67, SubcategoryID=13, MenuItemName="Vegetable Spring Rolls", Piece=6, Cooked=true, Vegetarian=false,
                MenuItemDescription="Vegetables rolled in a thin spring roll wrap and fried until crispy. Served with sweet chili sauce",
                MenuItemPrice = 5.25},
                new MenuItem{MenuItemID=68, SubcategoryID=13, MenuItemName="Edamame", Piece=0, Cooked=true, Vegetarian=false,
                MenuItemDescription="Boiled soybeans sprinkled with kosher salt",
                MenuItemPrice = 3.49},
                new MenuItem{MenuItemID=69, SubcategoryID=13, MenuItemName="Ginger Poke` Salad", Piece=0, Cooked=true, Vegetarian=false,
                MenuItemDescription="Chopped salmon poke, avocado, cucumber, and wakame salad",
                MenuItemPrice = 9.95},
            };
            menuItems.ForEach(s => context.MenuItems.Add(s));
            context.SaveChanges();

            var menuPictures = new List<MenuPicture>
            {
                //Sushidos
                new MenuPicture{PictureID=1, MenuItemID=1, PicturePathname="~/Photos/Normal/CaliforniaSushiBurrito.jpg", 
                                ThumbnailPathname="~/Photos/Normal/CaliforniaSushiBurritoThumb.jpg"},
                new MenuPicture{PictureID=2, MenuItemID=7, PicturePathname="~/Photos/Normal/BaconSushiBurrito.jpg",
                                ThumbnailPathname="~/Photos/Normal/BaconSushiBurritoThumb.jpg"},
                //Sushi Rolls
                new MenuPicture{PictureID=3, MenuItemID=20, PicturePathname="~/Photos/Normal/CaliforniaRoll.jpg",
                                ThumbnailPathname="~/Photos/Normal/CaliforniaRollThumb.jpg"},
                new MenuPicture{PictureID=4, MenuItemID=21, PicturePathname="~/Photos/Normal/PhillyRoll.jpg",
                                ThumbnailPathname="~/Photos/Normal/PhillyRollThumb.jpg"},
                new MenuPicture{PictureID=5, MenuItemID=22, PicturePathname="~/Photos/Normal/SpicySalmonRoll.jpg",
                                ThumbnailPathname="~/Photos/Normal/SpicySalmonRollThumb.jpg"},
                new MenuPicture{PictureID=6, MenuItemID=27, PicturePathname="~/Photos/Normal/SquidwardRoll.jpg",
                                ThumbnailPathname="~/Photos/Normal/SquidwardRollThumb.jpg"},
                new MenuPicture{PictureID=7, MenuItemID=28, PicturePathname="~/Photos/Normal/TridentRoll.jpg",
                                ThumbnailPathname="~/Photos/Normal/TridentRollThumb.jpg"},
                new MenuPicture{PictureID=8, MenuItemID=29, PicturePathname="~/Photos/Normal/FloridaRoll.jpg",
                                ThumbnailPathname="~/Photos/Normal/FloridaRollThumb.jpg"},
                new MenuPicture{PictureID=9, MenuItemID=30, PicturePathname="~/Photos/Normal/SuperPandaRoll.jpg",
                                ThumbnailPathname="~/Photos/Normal/SuperPandaRollThumb.jpg"},
                new MenuPicture{PictureID=10, MenuItemID=32, PicturePathname="~/Photos/Normal/TigerRoll.jpg",
                                ThumbnailPathname="~/Photos/Normal/TigerRollThumb.jpg"},
                new MenuPicture{PictureID=11, MenuItemID=34, PicturePathname="~/Photos/Normal/AlaskanRoll.jpg",
                                ThumbnailPathname="~/Photos/Normal/AlaskanRollThumb.jpg"},
                new MenuPicture{PictureID=12, MenuItemID=38, PicturePathname="~/Photos/Normal/CaliforniaWontonRoll.jpg",
                                ThumbnailPathname="~/Photos/Normal/CaliforniaWontonRollThumb.jpg"},
                new MenuPicture{PictureID=13, MenuItemID=39, PicturePathname="~/Photos/Normal/WolverineRoll.jpg",
                                ThumbnailPathname="~/Photos/Normal/WolverineRollThumb.jpg"},
                new MenuPicture{PictureID=14, MenuItemID=40, PicturePathname="~/Photos/Normal/VegasRoll.jpg",
                                ThumbnailPathname="~/Photos/Normal/VegasRollThumb.jpg"},
                new MenuPicture{PictureID=15, MenuItemID=41, PicturePathname="~/Photos/Normal/EskimoRoll.jpg",
                                ThumbnailPathname="~/Photos/Normal/EskimoRollThumb.jpg"},
                new MenuPicture{PictureID=16, MenuItemID=42, PicturePathname="~/Photos/Normal/CaliforniaCrunchRoll.jpg",
                                ThumbnailPathname="~/Photos/Normal/CaliforniaCrunchRollThumb.jpg"},

                //Asian Grills
                new MenuPicture{PictureID=17, MenuItemID=46, PicturePathname="~/Photos/Normal/TofuStirfry.jpg",
                                ThumbnailPathname="~/Photos/Normal/TofuStirfryThumb.jpg"},
                new MenuPicture{PictureID=18, MenuItemID=49, PicturePathname="~/Photos/Normal/ShrimpStirfry.jpg",
                                ThumbnailPathname="~/Photos/Normal/ShrimpStirfryThumb.jpg"},

                //Appetizers
                new MenuPicture{PictureID=19, MenuItemID=69, PicturePathname="~/Photos/Normal/gingerpokesalad.jpg",
                                ThumbnailPathname="~/Photos/Normal/gingerpokesaladThumb.jpg"},

            };
            menuPictures.ForEach(s => context.MenuPictures.Add(s));
            context.SaveChanges();

        }
    }
}
