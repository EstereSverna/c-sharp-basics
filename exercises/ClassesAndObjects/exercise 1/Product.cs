using System;

namespace exercise_1
{
    public class Product
    {
        public string Name { get; private set; }
        public double Price { get; private set; }
        public int Amount { get; private set; }

        public Product(string name, double priceAtStart, int amountAtStart)
        {
            Name = name;
            Price = priceAtStart;
            Amount = amountAtStart;
        }

        public double ChangePrice(double price)
        {
            Price = price;
            return price;
        }

        public int ChangeQuantity(int quantity)
        {
            Amount = quantity;
            return quantity;
        }

        public string PrintProduct()
        {
            return $"{Name}, price {Price}, amount {Amount}";
        }
    }
}
