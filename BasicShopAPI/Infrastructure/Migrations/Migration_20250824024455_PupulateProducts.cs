using FluentMigrator;

namespace BasicShopAPI.Infrastructure.Migrations
{
    [Migration(20250824024455)]
    public class Migration_20250824024455_PupulateProducts : Migration
    {
        public override void Up()
        {
            Insert.IntoTable("Products").Row(new { Name = "Men's T-Shirt Classic", Description = "Cotton crew-neck t-shirt, available in black, white, and navy.", Price = 15.99, Stock = 50, Gender = "men" });
            Insert.IntoTable("Products").Row(new { Name = "Women's T-Shirt Basic", Description = "Soft cotton t-shirt with round neckline.", Price = 14.99, Stock = 5, Gender = "women" });
            Insert.IntoTable("Products").Row(new { Name = "Kid's Polo Shirt", Description = "Cotton polo shirt with short sleeves.", Price = 12.00m, Stock = 10, Gender = "kids" });
            Insert.IntoTable("Products").Row(new { Name = "Men's Polo Shirt Slim Fit", Description = "Slim fit polo shirt with breathable fabric.", Price = 22.50, Stock = 8, Gender = "men" });
            Insert.IntoTable("Products").Row(new { Name = "Women's Blouse Elegant", Description = "Silk blouse with long sleeves and v-neckline.", Price = 45.20, Stock = 40, Gender = "women" });
            Insert.IntoTable("Products").Row(new { Name = "Kid's Hoodie Fun", Description = "Hoodie with playful graphics and pouch pocket.", Price = 20.55, Stock = 19, Gender = "kids" });
            Insert.IntoTable("Products").Row(new { Name = "Men's Dress Shirt Formal", Description = "Long-sleeve dress shirt, ideal for office or formal wear.", Price = 35.77, Stock = 50, Gender = "men" });
            Insert.IntoTable("Products").Row(new { Name = "Women's Crop Top", Description = "Trendy crop top made with stretchy cotton blend.", Price = 18.00, Stock = 8, Gender = "women" });
            Insert.IntoTable("Products").Row(new { Name = "Kid's Jacket Puffer", Description = "Lightweight puffer jacket for cold weather.", Price = 45.15, Stock = 17, Gender = "kids" });
            Insert.IntoTable("Products").Row(new { Name = "Men's Hoodie Sport", Description = "Casual hoodie with front pocket and adjustable hood.", Price = 29.90, Stock = 6, Gender = "men" });
            Insert.IntoTable("Products").Row(new { Name = "Women's Hoodie Oversized", Description = "Oversized hoodie with kangaroo pocket.", Price = 32.70, Stock = 50, Gender = "women" });
            Insert.IntoTable("Products").Row(new { Name = "Kid's Jeans Regular", Description = "Durable denim jeans for everyday use.", Price = 22.06, Stock = 1, Gender = "kids" });
            Insert.IntoTable("Products").Row(new { Name = "Men's Leather Jacket", Description = "Genuine leather jacket with zip closure.", Price = 120.77, Stock = 10, Gender = "men" });
            Insert.IntoTable("Products").Row(new { Name = "Women's Denim Jacket", Description = "Classic denim jacket with button closure.", Price = 60.42, Stock = 30, Gender = "women" });
            Insert.IntoTable("Products").Row(new { Name = "Kid's Shorts Active", Description = "Breathable shorts suitable for sports.", Price = 14.99, Stock = 12, Gender = "kids" });
            Insert.IntoTable("Products").Row(new { Name = "Men's Bomber Jacket", Description = "Lightweight bomber jacket with ribbed cuffs.", Price = 75.81, Stock = 3, Gender = "men" });
            Insert.IntoTable("Products").Row(new { Name = "Women's Leather Jacket", Description = "Faux leather jacket with slim fit design.", Price = 95.97, Stock = 25, Gender = "women" });
            Insert.IntoTable("Products").Row(new { Name = "Kid's Pajamas Set", Description = "Soft cotton pajamas with fun prints.", Price = 18.68, Stock = 100, Gender = "kids" });
            Insert.IntoTable("Products").Row(new { Name = "Men's Jeans Regular Fit", Description = "Classic straight-leg jeans made of durable denim.", Price = 40.30, Stock = 9, Gender = "men" });
            Insert.IntoTable("Products").Row(new { Name = "Women's Dress Summer", Description = "Casual summer dress with floral print.", Price = 35.07, Stock = 75, Gender = "women" });
            Insert.IntoTable("Products").Row(new { Name = "Kid's Sneakers Play", Description = "Comfortable sneakers for active kids.", Price = 32.82, Stock = 11, Gender = "kids" });
            Insert.IntoTable("Products").Row(new { Name = "Men's Jeans Skinny Fit", Description = "Slim and modern skinny fit jeans with stretch fabric.", Price = 42.42, Stock = 9, Gender = "men" });
            Insert.IntoTable("Products").Row(new { Name = "Women's Dress Evening", Description = "Elegant evening dress with chiffon fabric.", Price = 80.50, Stock = 20, Gender = "women" });
            Insert.IntoTable("Products").Row(new { Name = "Kid's Sandals Summer", Description = "Open-toe sandals with adjustable straps.", Price = 16.40, Stock = 80, Gender = "kids" });
            Insert.IntoTable("Products").Row(new { Name = "Men's Shorts Casual", Description = "Cotton casual shorts, ideal for summer.", Price = 18.50, Stock = 10, Gender = "men" });
            Insert.IntoTable("Products").Row(new { Name = "Women's Jeans Skinny Fit", Description = "Skinny jeans with high-rise waist.", Price = 42.77, Stock = 7, Gender = "women" });
            Insert.IntoTable("Products").Row(new { Name = "Kid's Dress Party", Description = "Girls' party dress with lace details.", Price = 28.09, Stock = 4, Gender = "kids" });
            Insert.IntoTable("Products").Row(new { Name = "Men's Suit Jacket", Description = "Tailored suit jacket for formal occasions.", Price = 150.80, Stock = 15, Gender = "men" });
            Insert.IntoTable("Products").Row(new { Name = "Women's Jeans Mom Fit", Description = "Relaxed fit mom jeans with retro style.", Price = 40.00, Stock = 50, Gender = "women" });
            Insert.IntoTable("Products").Row(new { Name = "Kid's Leggings Colorful", Description = "Stretchy leggings with colorful patterns.", Price = 12.37, Stock = 110, Gender = "kids" });
            Insert.IntoTable("Products").Row(new { Name = "Men's Suit Pants", Description = "Matching pants for suit jacket, slim fit.", Price = 65.80, Stock = 25, Gender = "men" });
            Insert.IntoTable("Products").Row(new { Name = "Women's Skirt Midi", Description = "Midi-length skirt with pleated design.", Price = 28.00, Stock = 15, Gender = "women" });
            Insert.IntoTable("Products").Row(new { Name = "Kid's Winter Coat", Description = "Warm coat with faux fur hood.", Price = 50.36, Stock = 13, Gender = "kids" });
            Insert.IntoTable("Products").Row(new { Name = "Men's Sweatpants", Description = "Comfortable sweatpants with elastic waistband.", Price = 25.49, Stock = 7, Gender = "men" });
            Insert.IntoTable("Products").Row(new { Name = "Women's Leggings Sport", Description = "High-waist leggings for workouts.", Price = 22.08, Stock = 90, Gender = "women" });
            Insert.IntoTable("Products").Row(new { Name = "Kid's Beanie Hat", Description = "Wool beanie hat to keep warm.", Price = 9.00, Stock = 4, Gender = "kids" });
            Insert.IntoTable("Products").Row(new { Name = "Men's Sneakers Casual", Description = "Everyday sneakers with cushioned sole.", Price = 55.15, Stock = 15, Gender = "men" });
            Insert.IntoTable("Products").Row(new { Name = "Women's Heels Classic", Description = "Classic pumps with 7cm heel.", Price = 65.99, Stock = 35, Gender = "women" });
            Insert.IntoTable("Products").Row(new { Name = "Kid's Gloves Knit", Description = "Knitted gloves for winter activities.", Price = 8.76, Stock = 130, Gender = "kids" });
            Insert.IntoTable("Products").Row(new { Name = "Men's Formal Shoes", Description = "Polished leather shoes for business wear.", Price = 85.05, Stock = 7, Gender = "men" });
            Insert.IntoTable("Products").Row(new { Name = "Women's Sneakers Fashion", Description = "Fashion sneakers with metallic details.", Price = 58.30, Stock = 40, Gender = "women" });
            Insert.IntoTable("Products").Row(new { Name = "Kid's Backpack Mini", Description = "Small backpack with cartoon design.", Price = 20.28, Stock = 70, Gender = "kids" });
            Insert.IntoTable("Products").Row(new { Name = "Men's Belt Leather", Description = "Adjustable leather belt with metal buckle.", Price = 20.99, Stock = 12, Gender = "men" });
            Insert.IntoTable("Products").Row(new { Name = "Women's Handbag Leather", Description = "Leather handbag with adjustable strap.", Price = 110.05, Stock = 9, Gender = "women" });
            Insert.IntoTable("Products").Row(new { Name = "Kid's T-Shirt Cartoon", Description = "Colorful t-shirt with cartoon print.", Price = 10.00, Stock = 11, Gender = "kids" });
            Insert.IntoTable("Products").Row(new { Name = "Men's Cap Sporty", Description = "Baseball cap with embroidered logo.", Price = 12.01, Stock = 2, Gender = "men" });
            Insert.IntoTable("Products").Row(new { Name = "Women's Scarf Silk", Description = "Lightweight silk scarf with printed design.", Price = 25.75, Stock = 27, Gender = "women" });
            Insert.IntoTable("Products").Row(new { Name = "Kid's Socks 5-Pack", Description = "Set of 5 cotton socks with playful patterns.", Price = 10.45, Stock = 160, Gender = "kids" });
            Insert.IntoTable("Products").Row(new { Name = "Men's Scarf Winter", Description = "Wool scarf to keep warm in cold weather.", Price = 18.00, Stock = 5, Gender = "men" });
            Insert.IntoTable("Products").Row(new { Name = "Women's Hat Wide Brim", Description = "Summer hat with wide brim for sun protection.", Price = 30.44, Stock = 15, Gender = "women" });            
        }
        public override void Down()
        {
            Delete.FromTable("Products").AllRows();
        }
    }
}
