using System;

namespace CoffeeBook.Models
{
    public class Discount
    {
        private int id;
        private string name;
        private int value;
        private int quantity;
        private DateTime expiredDate;
        private string photo;
        private int minPrice;
        //private int maxValue;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public int Value { get => value; set => this.value = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public DateTime ExpiredDate { get => expiredDate; set => expiredDate = value; }
        public string Photo { get => photo; set => photo = value; }
        public int MinPrice { get => minPrice; set => minPrice = value; }
        //public int MaxValue { get => maxValue; set => maxValue = value; }
    }
}