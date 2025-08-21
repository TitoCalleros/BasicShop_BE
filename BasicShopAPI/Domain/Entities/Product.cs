using static System.Runtime.InteropServices.JavaScript.JSType;

namespace BasicShopAPI.Domain.Entities
{
    public class Product
    {

        public int Id { get; private set; }
        public string Name { get; private set; }
        public string Description { get; private set; }
        public decimal Price { get; private set; }
        public int Stock { get; private set; }

        public Product(string name, string description, decimal price, int stock) => Update(name, description, price, stock);

        public void Update(string name, string description, decimal price, int stock)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Name cannot be null");

            if (price <= 0)
                throw new ArgumentException("Price must be greater than 0");

            if (stock < 0)
                throw new ArgumentException("stock cannot be negative");

            Name = name;
            Description = description;
            Price = price;
            Stock = stock;
        }

        public void DecreaseStock(int quantity)
        {
            if (quantity <= 0) throw new ArgumentException("Invalid quantity");
            if (Stock < quantity) throw new InvalidOperationException("Insufficient stock");

            Stock -= quantity;
        }

        public void IncreaseStock(int quantity)
        {
            if (quantity <= 0) throw new ArgumentException("Invalid quantity");
            Stock += quantity;
        }
    }
}
