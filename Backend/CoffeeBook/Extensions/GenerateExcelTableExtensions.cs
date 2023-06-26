using CoffeeBook.Models;
using OfficeOpenXml;
using OfficeOpenXml.Style;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.IO;

namespace CoffeeBook.Extensions
{
    public static class GenerateExcelTableExtensions
    {
        public static void ExportRevenueByDay(MemoryStream stream, DataTable revenue, DateTime date)
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            var currentDate = DateTime.Now;
            int count;
            using ExcelPackage package = new(stream);
            string sheetName = $"Doanh thu ngay {date.Day}/{date.Month}/{date.Year}";
            var sheet = package.Workbook.Worksheets.Add(sheetName);
            sheet.Cells["A1:W99"].Style.Font.Name = "Times New Roman";

            sheet.Cells["A1:F1"].Merge = true;
            sheet.Cells["A1:F1"].Value = "COFFEE & BOOK";
            sheet.Cells["A1:F1"].Style.Font.Bold = true;
            sheet.Cells["A1:F1"].Style.Font.Size = 14;
            sheet.Cells["A1:F1"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Left;
            sheet.Cells["A1:F1"].Style.VerticalAlignment = ExcelVerticalAlignment.Center;

            sheet.Cells["A2:D2"].Merge = true;
            sheet.Cells["A2:D2"].Value = "Trụ sở chính: Thành phố HCM";
            sheet.Cells["A2:D2"].Style.Font.Size = 13
                ;
            sheet.Cells["A2:D2"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Left;
            sheet.Cells["A2:D2"].Style.VerticalAlignment = ExcelVerticalAlignment.Center;
            sheet.Cells["A3:C3"].Merge = true;
            sheet.Cells["A3:C3"].Value = "SĐT: 0901234567";
            sheet.Cells["A3:C3"].Style.Font.Size = 13;
            sheet.Cells["A3:C3"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Left;

            sheet.Cells["G2:J2"].Merge = true;
            sheet.Cells["G2:J2"].Value = "BỘ PHẬN KẾ TOÁN";
            sheet.Cells["G2:J2"].Style.Font.UnderLine = true;
            sheet.Cells["G2:J2"].Style.Font.Size = 13;
            sheet.Cells["G2:J2"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
            sheet.Cells["G2:J2"].Style.VerticalAlignment = ExcelVerticalAlignment.Center;

            sheet.Cells["G3:J3"].Merge = true;
            sheet.Cells["G3:J3"].Value = $"Ngày xuất: {currentDate.Day}/{currentDate.Month}/{currentDate.Year} " +
                                            $"{currentDate.Hour}:{currentDate.Minute}:{currentDate.Second}";
            sheet.Cells["G3:J3"].Style.Font.Italic = true;
            sheet.Cells["G3:J3"].Style.Font.Size = 13;
            sheet.Cells["G3:J3"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
            sheet.Cells["G3:J3"].Style.VerticalAlignment = ExcelVerticalAlignment.Center;

            sheet.Cells["A5:E5"].Merge = true;
            sheet.Cells["A5:E5"].Value = $"THỐNG KÊ DOANH THU NGÀY {date.Day}/{date.Month}/{date.Year}";
            sheet.Cells["A5:E5"].Style.Font.Bold = true;
            sheet.Cells["A5:E5"].Style.Font.Size = 18;
            sheet.Cells["A5:E5"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
            sheet.Cells["A5:E5"].Style.VerticalAlignment = ExcelVerticalAlignment.Center;
            sheet.Row(5).Height = 35;

            sheet.Row(6).Style.WrapText = true;
            sheet.Row(6).Height = 30;

            sheet.Cells["A6:E6"].Style.Border.Left.Style = ExcelBorderStyle.Thin;
            sheet.Cells["A6:E6"].Style.Border.Right.Style = ExcelBorderStyle.Thin;
            sheet.Cells["A6:E6"].Style.Border.Bottom.Style = ExcelBorderStyle.Thin;
            sheet.Cells["A6:E6"].Style.Border.Top.Style = ExcelBorderStyle.Thin;
            sheet.Cells["A6:E6"].Style.Font.Size = 11;
            sheet.Cells["A6:E6"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
            sheet.Cells["A6:E6"].Style.VerticalAlignment = ExcelVerticalAlignment.Center;

            sheet.Column(1).Width = 7;
            sheet.Cells["A6:A6"].Value = "STT";
            sheet.Cells["A6:A6"].Style.Font.Bold = true;
            sheet.Cells["A6:A6"].Style.Fill.PatternType = ExcelFillStyle.Solid;
            sheet.Cells["A6:A6"].Style.Fill.BackgroundColor.SetColor(0, 169, 208, 142);
            sheet.Column(2).Width = 15;
            sheet.Cells["B6:B6"].Value = "Mã hóa đơn";
            sheet.Cells["B6:B6"].Style.Font.Bold = true;
            sheet.Cells["B6:B6"].Style.Fill.PatternType = ExcelFillStyle.Solid;
            sheet.Cells["B6:B6"].Style.Fill.BackgroundColor.SetColor(0, 169, 208, 142);
            sheet.Column(3).Width = 17;
            sheet.Cells["C6:C6"].Value = "Giờ";
            sheet.Cells["C6:C6"].Style.Font.Bold = true;
            sheet.Cells["C6:C6"].Style.Fill.PatternType = ExcelFillStyle.Solid;
            sheet.Cells["C6:C6"].Style.Fill.BackgroundColor.SetColor(0, 169, 208, 142);
            sheet.Column(4).Width = 25;
            sheet.Cells["D6:D6"].Value = "Tiền HĐ";
            sheet.Cells["D6:D6"].Style.Font.Bold = true;
            sheet.Cells["D6:D6"].Style.Fill.PatternType = ExcelFillStyle.Solid;
            sheet.Cells["D6:D6"].Style.Fill.BackgroundColor.SetColor(0, 169, 208, 142);
            sheet.Column(5).Width = 15;
            sheet.Cells["E6:E6"].Value = "Thanh toán bằng";
            sheet.Cells["E6:E6"].Style.Font.Bold = true;
            sheet.Cells["E6:E6"].Style.Fill.PatternType = ExcelFillStyle.Solid;
            sheet.Cells["E6:E6"].Style.Fill.BackgroundColor.SetColor(0, 169, 208, 142);
            sheet.Column(6).Width = 10;
            sheet.Cells["F6:F6"].Value = "Ghi chú";
            sheet.Cells["F6:F6"].Style.Font.Bold = true;
            sheet.Cells["F6:F6"].Style.Fill.PatternType = ExcelFillStyle.Solid;
            sheet.Cells["F6:F6"].Style.Fill.BackgroundColor.SetColor(0, 169, 208, 142);

            int numOfRow = revenue.Rows.Count;

            long total = 0;
            int dem = 1;
            int dong = 7;
            count = numOfRow + dong - 1;
            string table = $"A7:F{count}";
            if (count >= 1)
            {
                sheet.Cells[table].Style.Border.Left.Style = ExcelBorderStyle.Thin;
                sheet.Cells[table].Style.Border.Right.Style = ExcelBorderStyle.Thin;
                sheet.Cells[table].Style.Border.Top.Style = ExcelBorderStyle.Thin;
                sheet.Cells[table].Style.Border.Bottom.Style = ExcelBorderStyle.Thin;
                //revenue = _service.GetRevenueByMonth(month, year);
                foreach (DataRow row in revenue.Rows)
                {
                    string stt = $"A{dong}:A{dong}";
                    string maHd = $"B{dong}:B{dong}";
                    string gioHd = $"C{dong}:C{dong}";
                    string tienHd = $"D{dong}:D{dong}";
                    string thanhToan = $"E{dong}:E{dong}";
                    string ghiChu = $"F{dong}:F{dong}";

                    sheet.Cells[stt].Value = dem;
                    sheet.Cells[stt].Style.HorizontalAlignment = ExcelHorizontalAlignment.Right;
                    sheet.Cells[stt].Style.VerticalAlignment = ExcelVerticalAlignment.Center;

                    sheet.Cells[maHd].Value = row[0].ToString();
                    sheet.Cells[maHd].Style.HorizontalAlignment = ExcelHorizontalAlignment.Right;
                    sheet.Cells[maHd].Style.VerticalAlignment = ExcelVerticalAlignment.Center;

                    sheet.Cells[gioHd].Value = DateTime.Parse(row[1].ToString()).ToLongTimeString();
                    sheet.Cells[gioHd].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                    sheet.Cells[gioHd].Style.VerticalAlignment = ExcelVerticalAlignment.Center;

                    total += long.Parse(row[2].ToString());
                    sheet.Cells[tienHd].Value = long.Parse(row[2].ToString()).ToString("C2", CultureInfo.CreateSpecificCulture("vi-VN"));
                    sheet.Cells[tienHd].Style.HorizontalAlignment = ExcelHorizontalAlignment.Right;
                    sheet.Cells[tienHd].Style.VerticalAlignment = ExcelVerticalAlignment.Center;

                    sheet.Cells[thanhToan].Value = row[3].ToString();
                    sheet.Cells[thanhToan].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                    sheet.Cells[thanhToan].Style.VerticalAlignment = ExcelVerticalAlignment.Center;

                    sheet.Cells[ghiChu].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                    sheet.Cells[ghiChu].Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                    dem++;
                    dong++;
                }
            }
            sheet.Cells[$"C{dong}:C{dong}"].Value = "Doanh thu:";
            sheet.Cells[$"C{dong}:C{dong}"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Right;
            sheet.Cells[$"C{dong}:C{dong}"].Style.VerticalAlignment = ExcelVerticalAlignment.Center;
            sheet.Cells[$"D{dong}:D{dong}"].Value = total.ToString("C2", CultureInfo.CreateSpecificCulture("vi-VN"));
            sheet.Cells[$"D{dong}:D{dong}"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Right;
            sheet.Cells[$"D{dong}:D{dong}"].Style.VerticalAlignment = ExcelVerticalAlignment.Center;
            sheet.Cells[$"F{dong + 2}:J{dong + 2}"].Merge = true;
            sheet.Cells[$"F{dong + 2}:J{dong + 2}"].Value = $"Hồ Chí Minh, " +
                                                            $"ngày {currentDate.Day} tháng {currentDate.Month} năm {currentDate.Year}";
            sheet.Cells[$"F{dong + 2}:J{dong + 2}"].Style.Font.Italic = true;
            sheet.Cells[$"F{dong + 2}:J{dong + 2}"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
            sheet.Cells[$"F{dong + 2}:J{dong + 2}"].Style.VerticalAlignment = ExcelVerticalAlignment.Center;

            sheet.Cells[$"G{dong + 3}:I{dong + 3}"].Merge = true;
            sheet.Cells[$"G{dong + 3}:I{dong + 3}"].Value = "KẾ TOÁN TRƯỞNG";
            sheet.Cells[$"G{dong + 3}:I{dong + 3}"].Style.Font.Bold = true;
            sheet.Cells[$"G{dong + 3}:I{dong + 3}"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
            sheet.Cells[$"G{dong + 3}:I{dong + 3}"].Style.VerticalAlignment = ExcelVerticalAlignment.Center;

            sheet.Cells[$"G{dong + 9}:I{dong + 9}"].Merge = true;
            sheet.Cells[$"G{dong + 9}:I{dong + 9}"].Value = "Võ Hoàng Nhật";
            sheet.Cells[$"G{dong + 9}:I{dong + 9}"].Style.Font.Bold = true;
            sheet.Cells[$"G{dong + 9}:I{dong + 9}"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
            sheet.Cells[$"G{dong + 9}:I{dong + 9}"].Style.VerticalAlignment = ExcelVerticalAlignment.Center;

            package.Save();

            stream.Position = 0;
        }

        public static void ExportRevenueByMonth(MemoryStream stream, DataTable revenue, int month, int year)
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            var currentDate = DateTime.Now;
            int count;

            using ExcelPackage package = new(stream);
            string sheetName = $"Doanh thu thang {month}/{year}";
            var sheet = package.Workbook.Worksheets.Add(sheetName);
            sheet.Cells["A1:W99"].Style.Font.Name = "Times New Roman";

            sheet.Cells["A1:E1"].Merge = true;
            sheet.Cells["A1:E1"].Value = "COFFEE & BOOK";
            sheet.Cells["A1:E1"].Style.Font.Bold = true;
            sheet.Cells["A1:E1"].Style.Font.Size = 14;
            sheet.Cells["A1:E1"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Left;
            sheet.Cells["A1:E1"].Style.VerticalAlignment = ExcelVerticalAlignment.Center;

            sheet.Cells["A2:D2"].Merge = true;
            sheet.Cells["A2:D2"].Value = "Trụ sở chính: Thành phố HCM";
            sheet.Cells["A2:D2"].Style.Font.Size = 13;
            sheet.Cells["A2:D2"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Left;
            sheet.Cells["A2:D2"].Style.VerticalAlignment = ExcelVerticalAlignment.Center;
            sheet.Cells["A3:C3"].Merge = true;
            sheet.Cells["A3:C3"].Value = "SĐT: 0901234567";
            sheet.Cells["A3:C3"].Style.Font.Size = 13;
            sheet.Cells["A3:C3"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Left;

            sheet.Cells["G2:J2"].Merge = true;
            sheet.Cells["G2:J2"].Value = "BỘ PHẬN KẾ TOÁN";
            sheet.Cells["G2:J2"].Style.Font.UnderLine = true;
            sheet.Cells["G2:J2"].Style.Font.Size = 13;
            sheet.Cells["G2:J2"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
            sheet.Cells["G2:J2"].Style.VerticalAlignment = ExcelVerticalAlignment.Center;

            sheet.Cells["G3:J3"].Merge = true;
            sheet.Cells["G3:J3"].Value = $"Ngày xuất: {currentDate.Day}/{currentDate.Month}/{currentDate.Year} " +
                                            $"{currentDate.Hour}:{currentDate.Minute}:{currentDate.Second}";
            sheet.Cells["G3:J3"].Style.Font.Italic = true;
            sheet.Cells["G3:J3"].Style.Font.Size = 13;
            sheet.Cells["G3:J3"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
            sheet.Cells["G3:J3"].Style.VerticalAlignment = ExcelVerticalAlignment.Center;

            sheet.Cells["A5:E5"].Merge = true;
            sheet.Cells["A5:E5"].Value = $"THỐNG KÊ DOANH THU THÁNG {month}/{year}";
            sheet.Cells["A5:E5"].Style.Font.Bold = true;
            sheet.Cells["A5:E5"].Style.Font.Size = 18;
            sheet.Cells["A5:E5"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
            sheet.Cells["A5:E5"].Style.VerticalAlignment = ExcelVerticalAlignment.Center;
            sheet.Row(5).Height = 35;

            sheet.Row(6).Style.WrapText = true;
            sheet.Row(6).Height = 30;

            sheet.Cells["A6:E6"].Style.Border.Left.Style = ExcelBorderStyle.Thin;
            sheet.Cells["A6:E6"].Style.Border.Right.Style = ExcelBorderStyle.Thin;
            sheet.Cells["A6:E6"].Style.Border.Bottom.Style = ExcelBorderStyle.Thin;
            sheet.Cells["A6:E6"].Style.Border.Top.Style = ExcelBorderStyle.Thin;
            sheet.Cells["A6:E6"].Style.Font.Size = 11;
            sheet.Cells["A6:E6"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
            sheet.Cells["A6:E6"].Style.VerticalAlignment = ExcelVerticalAlignment.Center;

            sheet.Column(1).Width = 7;
            sheet.Cells["A6:A6"].Value = "STT";
            sheet.Cells["A6:A6"].Style.Font.Bold = true;
            sheet.Cells["A6:A6"].Style.Fill.PatternType = ExcelFillStyle.Solid;
            sheet.Cells["A6:A6"].Style.Fill.BackgroundColor.SetColor(0, 169, 208, 142);
            sheet.Column(2).Width = 20;
            sheet.Cells["B6:B6"].Value = "Ngày hóa đơn";
            sheet.Cells["B6:B6"].Style.Font.Bold = true;
            sheet.Cells["B6:B6"].Style.Fill.PatternType = ExcelFillStyle.Solid;
            sheet.Cells["B6:B6"].Style.Fill.BackgroundColor.SetColor(0, 169, 208, 142);
            sheet.Column(3).Width = 10;
            sheet.Cells["C6:C6"].Value = "Sl hóa đơn";
            sheet.Cells["C6:C6"].Style.Font.Bold = true;
            sheet.Cells["C6:C6"].Style.Fill.PatternType = ExcelFillStyle.Solid;
            sheet.Cells["C6:C6"].Style.Fill.BackgroundColor.SetColor(0, 169, 208, 142);
            sheet.Column(4).Width = 25;
            sheet.Cells["D6:D6"].Value = "DThu trong ngày";
            sheet.Cells["D6:D6"].Style.Font.Bold = true;
            sheet.Cells["D6:D6"].Style.Fill.PatternType = ExcelFillStyle.Solid;
            sheet.Cells["D6:D6"].Style.Fill.BackgroundColor.SetColor(0, 169, 208, 142);
            sheet.Column(5).Width = 10;
            sheet.Cells["E6:E6"].Value = "Đánh giá";
            sheet.Cells["E6:E6"].Style.Font.Bold = true;
            sheet.Cells["E6:E6"].Style.Fill.PatternType = ExcelFillStyle.Solid;
            sheet.Cells["E6:E6"].Style.Fill.BackgroundColor.SetColor(0, 169, 208, 142);

            int numOfRow = revenue.Rows.Count;

            long totalOfMonth = 0;
            int dem = 1;
            int dong = 7;
            count = numOfRow + dong - 1;
            string table = $"A7:E{count}";
            if (count >= 1)
            {
                sheet.Cells[table].Style.Border.Left.Style = ExcelBorderStyle.Thin;
                sheet.Cells[table].Style.Border.Right.Style = ExcelBorderStyle.Thin;
                sheet.Cells[table].Style.Border.Top.Style = ExcelBorderStyle.Thin;
                sheet.Cells[table].Style.Border.Bottom.Style = ExcelBorderStyle.Thin;
                //revenue = _service.GetRevenueByMonth(month, year);
                foreach (DataRow row in revenue.Rows)
                {
                    string stt = $"A{dong}:A{dong}";
                    string ngayHd = $"B{dong}:B{dong}";
                    string sluongHd = $"C{dong}:C{dong}";
                    string doanhThu = $"D{dong}:D{dong}";
                    string ghichu = $"E{dong}:E{dong}";

                    sheet.Cells[stt].Value = dem;
                    sheet.Cells[stt].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                    sheet.Cells[stt].Style.VerticalAlignment = ExcelVerticalAlignment.Center;

                    sheet.Cells[ngayHd].Value = row[0].ToString() + $"/{month}/{year}";
                    sheet.Cells[ngayHd].Style.HorizontalAlignment = ExcelHorizontalAlignment.Right;
                    sheet.Cells[ngayHd].Style.VerticalAlignment = ExcelVerticalAlignment.Center;

                    sheet.Cells[sluongHd].Value = int.Parse(row[1].ToString());
                    sheet.Cells[sluongHd].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                    sheet.Cells[sluongHd].Style.VerticalAlignment = ExcelVerticalAlignment.Center;

                    totalOfMonth += long.Parse(row[2].ToString());
                    sheet.Cells[doanhThu].Value = long.Parse(row[2].ToString()).ToString("C2", CultureInfo.CreateSpecificCulture("vi-VN"));
                    sheet.Cells[doanhThu].Style.HorizontalAlignment = ExcelHorizontalAlignment.Right;
                    sheet.Cells[doanhThu].Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                    if (long.Parse(row[2].ToString()) > 2000000)
                    {
                        sheet.Cells[ghichu].Value = "Cao";
                        sheet.Cells[ghichu].Style.Font.Color.SetColor(0, 0, 255, 0);
                    }
                    else if (long.Parse(row[2].ToString()) > 1000000)
                    {
                        sheet.Cells[ghichu].Value = "Trung bình";
                        sheet.Cells[ghichu].Style.Font.Color.SetColor(0, 0, 0, 255);
                    }
                    else
                    {
                        sheet.Cells[ghichu].Value = "Thấp";
                        sheet.Cells[ghichu].Style.Font.Color.SetColor(0, 255, 0, 0);
                    }

                    sheet.Cells[ghichu].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                    sheet.Cells[ghichu].Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                    dem++;
                    dong++;
                }
            }
            sheet.Cells[$"C{dong}:C{dong}"].Value = "Doanh thu:";
            sheet.Cells[$"C{dong}:C{dong}"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Right;
            sheet.Cells[$"C{dong}:C{dong}"].Style.VerticalAlignment = ExcelVerticalAlignment.Center;
            sheet.Cells[$"D{dong}:D{dong}"].Value = totalOfMonth.ToString("C2", CultureInfo.CreateSpecificCulture("vi-VN"));
            sheet.Cells[$"D{dong}:D{dong}"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Right;
            sheet.Cells[$"D{dong}:D{dong}"].Style.VerticalAlignment = ExcelVerticalAlignment.Center;
            sheet.Cells[$"F{dong + 2}:J{dong + 2}"].Merge = true;
            sheet.Cells[$"F{dong + 2}:J{dong + 2}"].Value = $"Hồ Chí Minh, " +
                                                            $"ngày {currentDate.Day} tháng {currentDate.Month} năm {currentDate.Year}";
            sheet.Cells[$"F{dong + 2}:J{dong + 2}"].Style.Font.Italic = true;
            sheet.Cells[$"F{dong + 2}:J{dong + 2}"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
            sheet.Cells[$"F{dong + 2}:J{dong + 2}"].Style.VerticalAlignment = ExcelVerticalAlignment.Center;

            sheet.Cells[$"G{dong + 3}:I{dong + 3}"].Merge = true;
            sheet.Cells[$"G{dong + 3}:I{dong + 3}"].Value = "KẾ TOÁN TRƯỞNG";
            sheet.Cells[$"G{dong + 3}:I{dong + 3}"].Style.Font.Bold = true;
            sheet.Cells[$"G{dong + 3}:I{dong + 3}"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
            sheet.Cells[$"G{dong + 3}:I{dong + 3}"].Style.VerticalAlignment = ExcelVerticalAlignment.Center;

            sheet.Cells[$"G{dong + 9}:I{dong + 9}"].Merge = true;
            sheet.Cells[$"G{dong + 9}:I{dong + 9}"].Value = "Võ Hoàng Nhật";
            sheet.Cells[$"G{dong + 9}:I{dong + 9}"].Style.Font.Bold = true;
            sheet.Cells[$"G{dong + 9}:I{dong + 9}"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
            sheet.Cells[$"G{dong + 9}:I{dong + 9}"].Style.VerticalAlignment = ExcelVerticalAlignment.Center;

            package.Save();
        }

        public static void ExportRevenueByYear(MemoryStream stream, DataTable revenue, int year)
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            var currentDate = DateTime.Now;
            int count;

            using ExcelPackage package = new(stream);
            string sheetName = $"Doanh thu năm {year}";
            var sheet = package.Workbook.Worksheets.Add(sheetName);
            sheet.Cells["A1:W99"].Style.Font.Name = "Times New Roman";

            sheet.Cells["A1:E1"].Merge = true;
            sheet.Cells["A1:E1"].Value = "COFFEE & BOOK";
            sheet.Cells["A1:E1"].Style.Font.Bold = true;
            sheet.Cells["A1:E1"].Style.Font.Size = 14;
            sheet.Cells["A1:E1"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Left;
            sheet.Cells["A1:E1"].Style.VerticalAlignment = ExcelVerticalAlignment.Center;

            sheet.Cells["A2:D2"].Merge = true;
            sheet.Cells["A2:D2"].Value = "Trụ sở chính: Thành phố HCM";
            sheet.Cells["A2:D2"].Style.Font.Size = 13;
            sheet.Cells["A2:D2"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Left;
            sheet.Cells["A2:D2"].Style.VerticalAlignment = ExcelVerticalAlignment.Center;
            sheet.Cells["A3:C3"].Merge = true;
            sheet.Cells["A3:C3"].Value = "SĐT: 0901234567";
            sheet.Cells["A3:C3"].Style.Font.Size = 13;
            sheet.Cells["A3:C3"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Left;

            sheet.Cells["G2:J2"].Merge = true;
            sheet.Cells["G2:J2"].Value = "BỘ PHẬN KẾ TOÁN";
            sheet.Cells["G2:J2"].Style.Font.UnderLine = true;
            sheet.Cells["G2:J2"].Style.Font.Size = 13;
            sheet.Cells["G2:J2"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
            sheet.Cells["G2:J2"].Style.VerticalAlignment = ExcelVerticalAlignment.Center;

            sheet.Cells["G3:J3"].Merge = true;
            sheet.Cells["G3:J3"].Value = $"Ngày xuất: {currentDate.Day}/{currentDate.Month}/{currentDate.Year} " +
                                            $"{currentDate.Hour}:{currentDate.Minute}:{currentDate.Second}";
            sheet.Cells["G3:J3"].Style.Font.Italic = true;
            sheet.Cells["G3:J3"].Style.Font.Size = 13;
            sheet.Cells["G3:J3"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
            sheet.Cells["G3:J3"].Style.VerticalAlignment = ExcelVerticalAlignment.Center;

            sheet.Cells["A5:E5"].Merge = true;
            sheet.Cells["A5:E5"].Value = $"THỐNG KÊ DOANH THU NĂM {year}";
            sheet.Cells["A5:E5"].Style.Font.Bold = true;
            sheet.Cells["A5:E5"].Style.Font.Size = 18;
            sheet.Cells["A5:E5"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
            sheet.Cells["A5:E5"].Style.VerticalAlignment = ExcelVerticalAlignment.Center;
            sheet.Row(5).Height = 35;

            sheet.Row(6).Style.WrapText = true;
            sheet.Row(6).Height = 30;

            sheet.Cells["A6:E6"].Style.Border.Left.Style = ExcelBorderStyle.Thin;
            sheet.Cells["A6:E6"].Style.Border.Right.Style = ExcelBorderStyle.Thin;
            sheet.Cells["A6:E6"].Style.Border.Bottom.Style = ExcelBorderStyle.Thin;
            sheet.Cells["A6:E6"].Style.Border.Top.Style = ExcelBorderStyle.Thin;
            sheet.Cells["A6:E6"].Style.Font.Size = 11;
            sheet.Cells["A6:E6"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
            sheet.Cells["A6:E6"].Style.VerticalAlignment = ExcelVerticalAlignment.Center;

            sheet.Column(1).Width = 7;
            sheet.Cells["A6:A6"].Value = "STT";
            sheet.Cells["A6:A6"].Style.Font.Bold = true;
            sheet.Cells["A6:A6"].Style.Fill.PatternType = ExcelFillStyle.Solid;
            sheet.Cells["A6:A6"].Style.Fill.BackgroundColor.SetColor(0, 169, 208, 142);
            sheet.Column(2).Width = 9;
            sheet.Cells["B6:B6"].Value = "Tháng";
            sheet.Cells["B6:B6"].Style.Font.Bold = true;
            sheet.Cells["B6:B6"].Style.Fill.PatternType = ExcelFillStyle.Solid;
            sheet.Cells["B6:B6"].Style.Fill.BackgroundColor.SetColor(0, 169, 208, 142);
            sheet.Column(3).Width = 10;
            sheet.Cells["C6:C6"].Value = "SL hóa đơn";
            sheet.Cells["C6:C6"].Style.Font.Bold = true;
            sheet.Cells["C6:C6"].Style.Fill.PatternType = ExcelFillStyle.Solid;
            sheet.Cells["C6:C6"].Style.Fill.BackgroundColor.SetColor(0, 169, 208, 142);
            sheet.Column(4).Width = 25;
            sheet.Cells["D6:D6"].Value = "DThu trong tháng";
            sheet.Cells["D6:D6"].Style.Font.Bold = true;
            sheet.Cells["D6:D6"].Style.Fill.PatternType = ExcelFillStyle.Solid;
            sheet.Cells["D6:D6"].Style.Fill.BackgroundColor.SetColor(0, 169, 208, 142);
            sheet.Column(5).Width = 10;
            sheet.Cells["E6:E6"].Value = "Đánh giá";
            sheet.Cells["E6:E6"].Style.Font.Bold = true;
            sheet.Cells["E6:E6"].Style.Fill.PatternType = ExcelFillStyle.Solid;
            sheet.Cells["E6:E6"].Style.Fill.BackgroundColor.SetColor(0, 169, 208, 142);

            int numOfRow = revenue.Rows.Count;

            long totalOfMonth = 0;
            int dem = 1;
            int dong = 7;
            count = numOfRow + dong - 1;
            string table = $"A7:E{count}";
            if (count >= 1)
            {
                sheet.Cells[table].Style.Border.Left.Style = ExcelBorderStyle.Thin;
                sheet.Cells[table].Style.Border.Right.Style = ExcelBorderStyle.Thin;
                sheet.Cells[table].Style.Border.Top.Style = ExcelBorderStyle.Thin;
                sheet.Cells[table].Style.Border.Bottom.Style = ExcelBorderStyle.Thin;
                //revenue = _service.GetRevenueByMonth(month, year);
                foreach (DataRow row in revenue.Rows)
                {
                    string stt = $"A{dong}:A{dong}";
                    string thangHd = $"B{dong}:B{dong}";
                    string sluongHd = $"C{dong}:C{dong}";
                    string doanhThu = $"D{dong}:D{dong}";
                    string ghichu = $"E{dong}:E{dong}";

                    sheet.Cells[stt].Value = dem;
                    sheet.Cells[stt].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                    sheet.Cells[stt].Style.VerticalAlignment = ExcelVerticalAlignment.Center;

                    sheet.Cells[thangHd].Value = row[0].ToString();
                    sheet.Cells[thangHd].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                    sheet.Cells[thangHd].Style.VerticalAlignment = ExcelVerticalAlignment.Center;

                    sheet.Cells[sluongHd].Value = int.Parse(row[1].ToString());
                    sheet.Cells[sluongHd].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                    sheet.Cells[sluongHd].Style.VerticalAlignment = ExcelVerticalAlignment.Center;

                    totalOfMonth += long.Parse(row[2].ToString());
                    sheet.Cells[doanhThu].Value = long.Parse(row[2].ToString()).ToString("C2", CultureInfo.CreateSpecificCulture("vi-VN"));
                    sheet.Cells[doanhThu].Style.HorizontalAlignment = ExcelHorizontalAlignment.Right;
                    sheet.Cells[doanhThu].Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                    if (long.Parse(row[2].ToString()) > 50_000_000)
                    {
                        sheet.Cells[ghichu].Value = "Cao";
                        sheet.Cells[ghichu].Style.Font.Color.SetColor(0, 0, 255, 0);
                    }
                    else if (long.Parse(row[2].ToString()) > 20_000_000)
                    {
                        sheet.Cells[ghichu].Value = "Trung bình";
                        sheet.Cells[ghichu].Style.Font.Color.SetColor(0, 0, 0, 255);
                    }
                    else
                    {
                        sheet.Cells[ghichu].Value = "Thấp";
                        sheet.Cells[ghichu].Style.Font.Color.SetColor(0, 255, 0, 0);
                    }

                    sheet.Cells[ghichu].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                    sheet.Cells[ghichu].Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                    dem++;
                    dong++;
                }
            }
            sheet.Cells[$"C{dong}:C{dong}"].Value = "Doanh thu:";
            sheet.Cells[$"C{dong}:C{dong}"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Right;
            sheet.Cells[$"C{dong}:C{dong}"].Style.VerticalAlignment = ExcelVerticalAlignment.Center;
            sheet.Cells[$"D{dong}:D{dong}"].Value = totalOfMonth.ToString("C2", CultureInfo.CreateSpecificCulture("vi-VN"));
            sheet.Cells[$"D{dong}:D{dong}"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Right;
            sheet.Cells[$"D{dong}:D{dong}"].Style.VerticalAlignment = ExcelVerticalAlignment.Center;
            sheet.Cells[$"F{dong + 2}:J{dong + 2}"].Merge = true;
            sheet.Cells[$"F{dong + 2}:J{dong + 2}"].Value = $"Hồ Chí Minh, " +
                                                            $"ngày {currentDate.Day} tháng {currentDate.Month} năm {currentDate.Year}";
            sheet.Cells[$"F{dong + 2}:J{dong + 2}"].Style.Font.Italic = true;
            sheet.Cells[$"F{dong + 2}:J{dong + 2}"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
            sheet.Cells[$"F{dong + 2}:J{dong + 2}"].Style.VerticalAlignment = ExcelVerticalAlignment.Center;

            sheet.Cells[$"G{dong + 3}:I{dong + 3}"].Merge = true;
            sheet.Cells[$"G{dong + 3}:I{dong + 3}"].Value = "KẾ TOÁN TRƯỞNG";
            sheet.Cells[$"G{dong + 3}:I{dong + 3}"].Style.Font.Bold = true;
            sheet.Cells[$"G{dong + 3}:I{dong + 3}"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
            sheet.Cells[$"G{dong + 3}:I{dong + 3}"].Style.VerticalAlignment = ExcelVerticalAlignment.Center;

            sheet.Cells[$"G{dong + 9}:I{dong + 9}"].Merge = true;
            sheet.Cells[$"G{dong + 9}:I{dong + 9}"].Value = "Võ Hoàng Nhật";
            sheet.Cells[$"G{dong + 9}:I{dong + 9}"].Style.Font.Bold = true;
            sheet.Cells[$"G{dong + 9}:I{dong + 9}"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
            sheet.Cells[$"G{dong + 9}:I{dong + 9}"].Style.VerticalAlignment = ExcelVerticalAlignment.Center;

            package.Save();
        }

        public static void ExportEmployeeList(MemoryStream stream, List<Employee> employees)
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            int count = employees.Count;
            var currentDate = DateTime.Now;
            using (var package = new ExcelPackage(stream))
            {
                var sheet = package.Workbook.Worksheets.Add("Danh sach nhan vien");
                sheet.Cells["A1:W99"].Style.Font.Name = "Times New Roman";

                sheet.Cells["A1:E1"].Merge = true;
                sheet.Cells["A1:E1"].Value = "COFFEE & BOOK";
                sheet.Cells["A1:E1"].Style.Font.Bold = true;
                sheet.Cells["A1:E1"].Style.Font.Size = 14;
                sheet.Cells["A1:E1"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Left;

                sheet.Cells["A2:C2"].Merge = true;
                sheet.Cells["A2:C2"].Value = "Trụ sở chính: Thành phố HCM";
                sheet.Cells["A2:C2"].Style.Font.Size = 13;
                sheet.Cells["A2:C2"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Left;

                sheet.Cells["A3:C3"].Merge = true;
                sheet.Cells["A3:C3"].Value = "SĐT: 0901234567";
                sheet.Cells["A3:C3"].Style.Font.Size = 13;
                sheet.Cells["A3:C3"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Left;

                sheet.Cells["I2:L2"].Merge = true;
                sheet.Cells["I2:L2"].Value = "BỘ PHẬN NHÂN SỰ";
                sheet.Cells["I2:L2"].Style.Font.UnderLine = true;
                sheet.Cells["I2:L2"].Style.Font.Size = 13;
                sheet.Cells["I2:L2"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                sheet.Cells["I2:L2"].Style.VerticalAlignment = ExcelVerticalAlignment.Center;

                sheet.Cells["I3:L3"].Merge = true;
                sheet.Cells["I3:L3"].Value = $"Ngày xuất: {currentDate.Day}/{currentDate.Month}/{currentDate.Year} " +
                                                $"{currentDate.Hour}:{currentDate.Minute}:{currentDate.Second}";
                sheet.Cells["I3:L3"].Style.Font.Italic = true;
                sheet.Cells["I3:L3"].Style.Font.Size = 13;
                sheet.Cells["I3:L3"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                sheet.Cells["I3:L3"].Style.VerticalAlignment = ExcelVerticalAlignment.Center;

                sheet.Cells["A5:M5"].Merge = true;
                sheet.Cells["A5:M5"].Value = "DANH SÁCH NHÂN VIÊN";
                sheet.Cells["A5:M5"].Style.Font.Bold = true;
                sheet.Cells["A5:M5"].Style.Font.Size = 20;
                sheet.Cells["A5:M5"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                sheet.Cells["A5:M5"].Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                sheet.Row(5).Height = 40;

                sheet.Row(6).Style.WrapText = true;
                sheet.Row(6).Height = 30;

                sheet.Cells["A6:M6"].Style.Border.Left.Style = ExcelBorderStyle.Thin;
                sheet.Cells["A6:M6"].Style.Border.Right.Style = ExcelBorderStyle.Thin;
                sheet.Cells["A6:M6"].Style.Border.Bottom.Style = ExcelBorderStyle.Thin;
                sheet.Cells["A6:M6"].Style.Border.Top.Style = ExcelBorderStyle.Thin;
                sheet.Cells["A6:M6"].Style.Font.Size = 13;
                sheet.Cells["A6:M6"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                sheet.Cells["A6:M6"].Style.VerticalAlignment = ExcelVerticalAlignment.Center;

                sheet.Column(1).Width = 7;
                sheet.Cells["A6:A6"].Value = "STT";
                sheet.Cells["A6:A6"].Style.Font.Bold = true;
                sheet.Cells["A6:A6"].Style.Fill.PatternType = ExcelFillStyle.Solid;
                sheet.Cells["A6:A6"].Style.Fill.BackgroundColor.SetColor(0, 91, 155, 213);
                sheet.Column(2).Width = 12;
                sheet.Cells["B6:B6"].Value = "Mã nhân viên";
                sheet.Cells["B6:B6"].Style.Font.Bold = true;
                sheet.Cells["B6:B6"].Style.Fill.PatternType = ExcelFillStyle.Solid;
                sheet.Cells["B6:B6"].Style.Fill.BackgroundColor.SetColor(0, 91, 155, 213);
                sheet.Column(3).Width = 20;
                sheet.Cells["C6:C6"].Value = "Tên nhân viên";
                sheet.Cells["C6:C6"].Style.Font.Bold = true;
                sheet.Cells["C6:C6"].Style.Fill.PatternType = ExcelFillStyle.Solid;
                sheet.Cells["C6:C6"].Style.Fill.BackgroundColor.SetColor(0, 91, 155, 213);
                sheet.Column(4).Width = 8;
                sheet.Cells["D6:D6"].Value = "Tuổi";
                sheet.Cells["D6:D6"].Style.Font.Bold = true;
                sheet.Cells["D6:D6"].Style.Fill.PatternType = ExcelFillStyle.Solid;
                sheet.Cells["D6:D6"].Style.Fill.BackgroundColor.SetColor(0, 91, 155, 213);
                sheet.Column(5).Width = 10;
                sheet.Cells["E6:E6"].Value = "Giới tính";
                sheet.Cells["E6:E6"].Style.Font.Bold = true;
                sheet.Cells["E6:E6"].Style.Fill.PatternType = ExcelFillStyle.Solid;
                sheet.Cells["E6:E6"].Style.Fill.BackgroundColor.SetColor(0, 91, 155, 213);
                sheet.Column(6).Width = 25;
                sheet.Cells["F6:F6"].Value = "Email";
                sheet.Cells["F6:F6"].Style.Font.Bold = true;
                sheet.Cells["F6:F6"].Style.Fill.PatternType = ExcelFillStyle.Solid;
                sheet.Cells["F6:F6"].Style.Fill.BackgroundColor.SetColor(0, 91, 155, 213);
                sheet.Column(7).Width = 20;
                sheet.Cells["G6:G6"].Value = "Số điện thoại";
                sheet.Cells["G6:G6"].Style.Font.Bold = true;
                sheet.Cells["G6:G6"].Style.Fill.PatternType = ExcelFillStyle.Solid;
                sheet.Cells["G6:G6"].Style.Fill.BackgroundColor.SetColor(0, 91, 155, 213);
                sheet.Column(8).Width = 30;
                sheet.Cells["H6:H6"].Value = "Địa chỉ";
                sheet.Cells["H6:H6"].Style.Font.Bold = true;
                sheet.Cells["H6:H6"].Style.Fill.PatternType = ExcelFillStyle.Solid;
                sheet.Cells["H6:H6"].Style.Fill.BackgroundColor.SetColor(0, 91, 155, 213);
                sheet.Column(9).Width = 15;
                sheet.Cells["I6:I6"].Value = "Thành phố";
                sheet.Cells["I6:I6"].Style.Font.Bold = true;
                sheet.Cells["I6:I6"].Style.Fill.PatternType = ExcelFillStyle.Solid;
                sheet.Cells["I6:I6"].Style.Fill.BackgroundColor.SetColor(0, 91, 155, 213);
                sheet.Column(10).Width = 15;
                sheet.Cells["J6:J6"].Value = "Quốc tịch";
                sheet.Cells["J6:J6"].Style.Font.Bold = true;
                sheet.Cells["J6:J6"].Style.Fill.PatternType = ExcelFillStyle.Solid;
                sheet.Cells["J6:J6"].Style.Fill.BackgroundColor.SetColor(0, 91, 155, 213);
                sheet.Column(11).Width = 20;
                sheet.Cells["K6:K6"].Value = "Lương/tháng";
                sheet.Cells["K6:K6"].Style.Font.Bold = true;
                sheet.Cells["K6:K6"].Style.Fill.PatternType = ExcelFillStyle.Solid;
                sheet.Cells["K6:K6"].Style.Fill.BackgroundColor.SetColor(0, 91, 155, 213);
                sheet.Column(12).Width = 20;
                sheet.Cells["L6:L6"].Value = "Cửa hàng làm việc";
                sheet.Cells["L6:L6"].Style.Font.Bold = true;
                sheet.Cells["L6:L6"].Style.Fill.PatternType = ExcelFillStyle.Solid;
                sheet.Cells["L6:L6"].Style.Fill.BackgroundColor.SetColor(0, 91, 155, 213);
                sheet.Column(13).Width = 10;
                sheet.Cells["M6:M6"].Value = "Trạng thái";
                sheet.Cells["M6:M6"].Style.Font.Bold = true;
                sheet.Cells["M6:M6"].Style.Fill.PatternType = ExcelFillStyle.Solid;
                sheet.Cells["M6:M6"].Style.Fill.BackgroundColor.SetColor(0, 91, 155, 213);

                int dem = 1;
                int dong = 7;
                count = count + dong - 1;
                string table = $"A7:M{count}";
                if (count >= 1)
                {
                    sheet.Cells[table].Style.Border.Left.Style = ExcelBorderStyle.Thin;
                    sheet.Cells[table].Style.Border.Right.Style = ExcelBorderStyle.Thin;
                    sheet.Cells[table].Style.Border.Top.Style = ExcelBorderStyle.Thin;
                    sheet.Cells[table].Style.Border.Bottom.Style = ExcelBorderStyle.Thin;
                    sheet.Cells[table].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                    sheet.Cells[table].Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                    sheet.Cells[table].Style.WrapText = true;

                    foreach (var emp in employees)
                    {
                        string stt = $"A{dong}:A{dong}";
                        string manv = $"B{dong}:B{dong}";
                        string tennv = $"C{dong}:C{dong}";
                        string tuoi = $"D{dong}:D{dong}";
                        string gioitinh = $"E{dong}:E{dong}";
                        string email = $"F{dong}:F{dong}";
                        string sdt = $"G{dong}:G{dong}";
                        string diachi = $"H{dong}:H{dong}";
                        string thanhpho = $"I{dong}:I{dong}";
                        string quoctich = $"J{dong}:J{dong}";
                        string luong = $"K{dong}:K{dong}";
                        string tench = $"L{dong}:L{dong}";
                        string trangthai = $"M{dong}:M{dong}";

                        sheet.Cells[stt].Value = dem;
                        sheet.Cells[manv].Value = emp.Id;
                        sheet.Cells[tennv].Value = emp.Name;
                        sheet.Cells[tuoi].Value = emp.Age;
                        sheet.Cells[gioitinh].Value = emp.Gender == 1 ? "Nam" : "Nữ";
                        sheet.Cells[email].Value = emp.Email;
                        sheet.Cells[sdt].Value = emp.Phone;
                        sheet.Cells[diachi].Value = emp.Address;
                        sheet.Cells[thanhpho].Value = emp.City;
                        sheet.Cells[quoctich].Value = emp.Country;
                        sheet.Cells[luong].Value = emp.Salary.ToString("C2", CultureInfo.CreateSpecificCulture("vi-VN"));
                        var store = emp.Store;
                        if (store != null)
                            sheet.Cells[tench].Value = store.StoreName;
                        else
                            sheet.Cells[tench].Value = "";
                        sheet.Cells[trangthai].Value = emp.Status;

                        dong++;
                        dem++;
                    }

                    sheet.Cells[$"I{dong + 1}:M{dong + 1}"].Merge = true;
                    sheet.Cells[$"I{dong + 1}:M{dong + 1}"].Value = $"Hồ Chí Minh, " +
                                                                    $"ngày {currentDate.Day} tháng {currentDate.Month} năm {currentDate.Year}";
                    sheet.Cells[$"I{dong + 1}:M{dong + 1}"].Style.Font.Italic = true;
                    sheet.Cells[$"I{dong + 1}:M{dong + 1}"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                    sheet.Cells[$"I{dong + 1}:M{dong + 1}"].Style.VerticalAlignment = ExcelVerticalAlignment.Center;

                    sheet.Cells[$"J{dong + 2}:L{dong + 2}"].Merge = true;
                    sheet.Cells[$"J{dong + 2}:L{dong + 2}"].Value = "QUẢN LÝ VIÊN";
                    sheet.Cells[$"J{dong + 2}:L{dong + 2}"].Style.Font.Bold = true;
                    sheet.Cells[$"J{dong + 2}:L{dong + 2}"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                    sheet.Cells[$"J{dong + 2}:L{dong + 2}"].Style.VerticalAlignment = ExcelVerticalAlignment.Center;

                    sheet.Cells[$"J{dong + 9}:L{dong + 9}"].Merge = true;
                    sheet.Cells[$"J{dong + 9}:L{dong + 9}"].Value = "Võ Hoàng Nhật";
                    sheet.Cells[$"J{dong + 9}:L{dong + 9}"].Style.Font.Bold = true;
                    sheet.Cells[$"J{dong + 9}:L{dong + 9}"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                    sheet.Cells[$"J{dong + 9}:L{dong + 9}"].Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                }
                package.Save();
            }
        }
    }
}