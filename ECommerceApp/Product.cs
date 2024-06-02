using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceApp
{
    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public double Price { get; set; }
        public int Stock { get; set; }

        public Product(int productID, string productName, double price, int stock)
        {
            ProductID = productID;
            ProductName = productName;
            Price = price;
            Stock = stock;
        }

        public void IncreaseStock(int amount)
        {
            var addedValue = Stock + amount;

            if (amount >= 0 && addedValue <= 1000)
            {
                Stock += amount;
            }
        }

        public void DecreaseStock(int amount)
        {
            var decreasedValue = Stock - amount;

            if (amount > 0 && decreasedValue >= 0)
            {
                Stock -= amount;
            }
        }
    }
}
