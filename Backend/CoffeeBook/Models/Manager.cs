﻿namespace CoffeeBook.Models
{
    public class Manager
    {
        private int id;
        private string name;
        private int age;
        private int? gender;
        private string email;
        private string phone;
        private string address;
        private string city;
        private string country;
        private long salary;
        private string status;
        private int bonus;

        private Store store;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }
        public int? Gender { get => gender; set => gender = value; }
        public string Email { get => email; set => email = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Address { get => address; set => address = value; }
        public string City { get => city; set => city = value; }
        public string Country { get => country; set => country = value; }
        public long Salary { get => salary; set => salary = value; }
        public string Status { get => status; set => status = value; }
        public int Bonus { get => bonus; set => bonus = value; }
        public Store Store { get => store; set => store = value; }
    }
}