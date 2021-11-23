using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeBook.Models
{
    public class Bill
    {
        private int id;
        private int customerId;
        private int validated;
        private string status;
        private long totalPrice;
        private Customer customer;

        public int Id { get => id; set => id = value; }
        public int CustomerId { get => customerId; set => customerId = value; }
        public int Validated { get => validated; set => validated = value; }
        public string Status { get => status; set => status = value; }
        public long TotalPrice { get => totalPrice; set => totalPrice = value; }
        public Customer Customer { get => customer; set => customer = value; }
    }
}
