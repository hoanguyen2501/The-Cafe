using CoffeeBook.Contracts;
using CoffeeBook.DataAccess;
using CoffeeBook.Dto;
using CoffeeBook.Models;
using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace CoffeeBook.Services
{
    public class BillService : IBillService
    {
        private readonly IConfiguration _config;
        private readonly string sqlDataSource;
        private readonly CoffeeBookDbContext _context;

        public BillService(IConfiguration config, CoffeeBookDbContext context)
        {
            _config = config;
            sqlDataSource = _config.GetConnectionString("CoffeeBook");
            _context = context;
        }

        public List<Bill> GetAll()
        {
            return _context.Bills.Where(s => s.CustomerId > 0).OrderByDescending(o => o.Id).ToList();
        }

        public int AddNewBill(Bill bill)
        {
            try
            {
                Bill newBill = new()
                {
                    Address = bill.Address,
                    Name = bill.Name,
                    Note = bill.Note,
                    Validated = bill.Validated,
                    Status = bill.Status,
                    PayBy = bill.PayBy,
                    Phone = bill.Phone,
                    Time = bill.Time,
                    TotalPrice = bill.TotalPrice,
                    CreatedDate = DateTime.Now,
                    CustomerId = bill.CustomerId
                };
                _context.Bills.Add(newBill);
                return _context.SaveChanges();
            }
            catch
            {
                return -1;
            }
        }

        public DataTable GetSaleByYear(int year)
        {
            string query = @"select Month(CreatedDate) as 'Month', sum(TotalPrice) as 'Sales'
                             from Bill b
                             where Validated = 1 and Year(CreatedDate) = @YEAR
                             group by Month(CreatedDate)
                             order by Month(CreatedDate) asc";

            DataTable table = new();
            MySqlDataReader myreader;
            using (MySqlConnection myCon = new(sqlDataSource))
            {
                myCon.Open();
                using MySqlCommand myCommand = new MySqlCommand(query, myCon);
                myCommand.Parameters.AddWithValue("YEAR", year);
                myreader = myCommand.ExecuteReader();
                table.Load(myreader);

                myreader.Close();
                myCon.Close();
            }

            return table;
        }

        public DataTable GetCountBill(int year)
        {
            string query = @"select count(*) as count
                             from Bill
                             where year(CreatedDate) = @YEAR
                                   and Validated = 1;";

            DataTable table = new();
            MySqlDataReader myreader;
            using (MySqlConnection myCon = new(sqlDataSource))
            {
                myCon.Open();
                using MySqlCommand myCommand = new MySqlCommand(query, myCon);
                myCommand.Parameters.AddWithValue("YEAR", year);
                myreader = myCommand.ExecuteReader();
                table.Load(myreader);

                myreader.Close();
                myCon.Close();
            }

            return table;
        }

        public DataTable GetTotalListBill(int year)
        {
            string query = @"select count(*) as count
                             from ShoppingCart_Product
                             where year(CreatedDate) = @YEAR;";

            DataTable table = new();
            string sqlDataSource = _config.GetConnectionString("CoffeeBook");
            MySqlDataReader myreader;
            using (MySqlConnection myCon = new(sqlDataSource))
            {
                myCon.Open();
                using MySqlCommand myCommand = new(query, myCon);
                myCommand.Parameters.AddWithValue("YEAR", year);
                myreader = myCommand.ExecuteReader();
                table.Load(myreader);

                myreader.Close();
                myCon.Close();
            }

            return table;
        }

        public DataTable GetTotalSaleByYear(int year)
        {
            string query = @"select sum(TotalPrice) as TotalSale
                             from Bill
                             where year(CreatedDate) = @YEAR
                                   and Validated = 1;";

            DataTable table = new();
            MySqlDataReader myreader;
            using (MySqlConnection myCon = new(sqlDataSource))
            {
                myCon.Open();
                using MySqlCommand myCommand = new(query, myCon);
                myCommand.Parameters.AddWithValue("YEAR", year);
                myreader = myCommand.ExecuteReader();
                table.Load(myreader);

                myreader.Close();
                myCon.Close();
            }

            return table;
        }

        public DataTable GetRevenueByDay(DateTime date)
        {
            string strDate = date.ToString("yyyy-MM-dd");
            var query = @"SELECT Id, CreatedDate, TotalPrice, PayBy
                          FROM Bill
                          WHERE DATE(CreatedDate) = @Date and Validated = 1
                          ORDER BY TIME(CreatedDate)";
            var table = new DataTable();
            using (MySqlConnection connection = new(sqlDataSource))
            {
                MySqlCommand command = new(query, connection)
                {
                    CommandText = query
                };
                command.Parameters.AddWithValue("Date", strDate);

                connection.Open();
                var reader = command.ExecuteReader(CommandBehavior.CloseConnection);
                if (reader.HasRows)
                    table.Load(reader);
            }
            return table;
        }

        public DataTable GetRevenueByMonth(int month, int year)
        {
            var query = @"SELECT DAY(CreatedDate), COUNT(*), SUM(TotalPrice)
                          FROM Bill
                          WHERE MONTH(CreatedDate) = @Month AND YEAR(CreatedDate) = @Year and Validated = 1
                          GROUP BY DAY(CreatedDate)
                          ORDER BY DAY(CreatedDate)";
            DataTable table = new();
            using (MySqlConnection connection = new(sqlDataSource))
            {
                MySqlCommand command = new(query, connection)
                {
                    CommandText = query
                };
                command.Parameters.AddWithValue("Month", month);
                command.Parameters.AddWithValue("Year", year);

                connection.Open();
                var reader = command.ExecuteReader(CommandBehavior.CloseConnection);
                if (reader.HasRows)
                    table.Load(reader);
            }
            return table;
        }

        public DataTable GetRevenueByYear(int year)
        {
            string query = @"SELECT MONTH(CreatedDate) AS Month, COUNT(*) AS SLHD, SUM(TotalPrice) AS Revenue
                             FROM Bill
                             WHERE YEAR(CreatedDate) = @Year and Validated = 1
                             GROUP BY MONTH(CreatedDate)
                             ORDER BY MONTH(CreatedDate)";
            var table = new DataTable();
            using (MySqlConnection connection = new(sqlDataSource))
            {
                MySqlCommand command = new(query, connection)
                {
                    CommandText = query
                };
                command.Parameters.AddWithValue("Year", year);

                connection.Open();
                MySqlDataReader myreader = command.ExecuteReader(CommandBehavior.CloseConnection);
                if (myreader.HasRows)
                {
                    table.Load(myreader);
                }
            }
            return table;
        }

        public List<Bill> GetBillsByCustomerId(int customerId)
        {
            try
            {
                List<Bill> bills = _context.Bills.Where(e => e.CustomerId == customerId).ToList();

                return bills;
            }
            catch
            {
                return null;
            }
        }

        public int Purchase(BillDto dto)
        {
            try
            {
                if (dto.CheckDiscount)
                {
                    Discount discount = _context.Discounts.FirstOrDefault(s => s.Id == dto.DiscountId);
                    discount.Quantity--;
                }
                Bill bill = new()
                {
                    Address = dto.Address,
                    Name = dto.Name,
                    Note = dto.Note,
                    PayBy = dto.PayBy,
                    Phone = dto.Phone,
                    TotalPrice = dto.TotalPrice,
                    CreatedDate = DateTime.Now,
                    CustomerId = dto.CustomerId,
                    Status = "Nhận đơn"
                };
                if (dto.Time == "")
                    bill.Time = "15-30 phút";
                else bill.Time = dto.Time;
                _context.Bills.Add(bill);

                var billResult = _context.SaveChanges();
                if (billResult >= 1)
                {
                    ShoppingCart shoppingCart = new()
                    {
                        CustomerId = dto.CustomerId,
                        CreatedDate = DateTime.Now,
                        ProductQuantity = dto.ListBill.Count
                    };

                    _context.ShoppingCarts.Add(shoppingCart);
                    var shoppingCartsResult = _context.SaveChanges();
                    if (shoppingCartsResult >= 1)
                    {
                        var shoppingId = _context.ShoppingCarts.OrderByDescending(u => u.Id).FirstOrDefault().Id;

                        foreach (ShoppingCart_Product item in dto.ListBill)
                        {
                            ShoppingCart_Product checkout = new()
                            {
                                ProductId = item.ProductId,
                                ShoppingCartId = shoppingId,
                                TilteSize = item.TilteSize,
                                Count = item.Count,
                                CreatedDate = DateTime.Now
                            };
                            _context.ShoppingCart_Products.Add(checkout);
                        }
                        return _context.SaveChanges();
                    }
                    return 0;
                }
                return 0;
            }
            catch
            {
                return -1;
            }
        }

        public int Delivery(int id)
        {
            try
            {
                Bill bill = _context.Bills.Find(id);
                bill.Validated = 1;
                bill.Status = "Đã thanh toán";
                return _context.SaveChanges();
            }
            catch
            {
                return -1;
            }
        }

        public int UpdateBill(int id, Bill model)
        {
            try
            {
                Bill bill = _context.Bills.Find(id);
                bill.Address = model.Address;
                bill.Name = model.Name;
                bill.Note = model.Note;
                bill.Validated = model.Validated;
                bill.Status = model.Status;
                bill.PayBy = model.PayBy;
                bill.Phone = model.Phone;
                bill.Time = model.Time;
                bill.TotalPrice = model.TotalPrice;
                bill.CustomerId = model.CustomerId;
                return _context.SaveChanges();
            }
            catch
            {
                return -1;
            }
        }

        public int DeleteById(int id)
        {
            try
            {
                Bill bill = _context.Bills.Find(id);
                _context.Bills.Remove(bill);
                return _context.SaveChanges();
            }
            catch
            {
                return -1;
            }
        }
    }
}