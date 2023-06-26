using CoffeeBook.Dto;
using CoffeeBook.Models;
using System;
using System.Collections.Generic;
using System.Data;

namespace CoffeeBook.Contracts
{
    public interface IBillService
    {
        List<Bill> GetAll();

        List<Bill> GetBillsByCustomerId(int customerId);

        int AddNewBill(Bill bill);

        int Purchase(BillDto dto);

        int UpdateBill(int id, Bill model);

        int DeleteById(int id);

        int Delivery(int id);

        DataTable GetRevenueByYear(int year);

        DataTable GetRevenueByMonth(int month, int year);

        DataTable GetRevenueByDay(DateTime date);

        DataTable GetTotalSaleByYear(int year);

        DataTable GetTotalListBill(int year);

        DataTable GetCountBill(int year);

        DataTable GetSaleByYear(int year);
    }
}