﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CoffeeBook.Migrations
{
    public partial class DataSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Discount",
                columns: new[] { "Id", "ExpiredDate", "Name", "Photo", "Quantity", "Value" },
                values: new object[,]
                {
                    { 1, new DateTime(2021, 12, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Phiếu giảm giá 20k cho đơn hàng trên 100k", "https://minio.thecoffeehouse.com/image/admin/storage/852__C4_90o_CC_82_CC_80ng-gia_CC_81-29K_coupon.jpg", 10, 20000 },
                    { 2, new DateTime(2021, 12, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ưu đãi 30% (tối đa 35k) đơn từ 2 món bất kỳ", "https://minio.thecoffeehouse.com/image/admin/Coupondelivery30_684527.jpg", 10, 20000 },
                    { 3, new DateTime(2021, 12, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ưu đãi 20% đơn Pickup 2 món bất kỳ", "https://minio.thecoffeehouse.com/image/admin/storage/696_Coupon_20Pickup_2020_.jpg", 10, 20000 },
                    { 4, new DateTime(2021, 12, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ưu đãi 30% (tối đa 35k) đơn từ 2 món bất kỳ", "https://minio.thecoffeehouse.com/image/admin/Coupondelivery30_684527.jpg", 10, 20000 },
                    { 5, new DateTime(2021, 12, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ưu đãi 30% (tối đa 35k) đơn từ 2 món bất kỳ", "https://minio.thecoffeehouse.com/image/admin/storage/696_Coupon_20Pickup_2020_.jpg", 10, 20000 }
                });

            migrationBuilder.InsertData(
                table: "News",
                columns: new[] { "Id", "Content", "Thumbnail", "Title" },
                values: new object[,]
                {
                    { 1, "Bạn mua 5 ly cà phê - Nhà tặng thêm 2 (Hạn sử dụng 10 ngày kể từ ngày mua).", "https://feed.thecoffeehouse.com/content/images/2021/08/img_8668_grande.jpg", "Nghệ thuật pha chế - Cold Brew 1" },
                    { 2, "Bạn mua 5 ly cà phê - Nhà tặng thêm 2 (Hạn sử dụng 10 ngày kể từ ngày mua).", "https://feed.thecoffeehouse.com/content/images/2021/08/img_8668_grande.jpg", "Nghệ thuật pha chế - Espresso 1" },
                    { 3, "Bạn mua 5 ly cà phê - Nhà tặng thêm 2 (Hạn sử dụng 10 ngày kể từ ngày mua).", "https://feed.thecoffeehouse.com/content/images/2021/08/img_8668_grande.jpg", "Nghệ thuật pha chế - Cold Brew 2" },
                    { 4, "Bạn mua 5 ly cà phê - Nhà tặng thêm 2 (Hạn sử dụng 10 ngày kể từ ngày mua).", "https://feed.thecoffeehouse.com/content/images/2021/08/img_8668_grande.jpg", "Nghệ thuật pha chế - Espresso 2" },
                    { 5, "Bạn mua 5 ly cà phê - Nhà tặng thêm 2 (Hạn sử dụng 10 ngày kể từ ngày mua).", "https://feed.thecoffeehouse.com/content/images/2021/08/img_8668_grande.jpg", "Nghệ thuật pha chế - Cold Brew 3" },
                    { 6, "Bạn mua 5 ly cà phê - Nhà tặng thêm 2 (Hạn sử dụng 10 ngày kể từ ngày mua).", "https://feed.thecoffeehouse.com/content/images/2021/08/img_8668_grande.jpg", "Nghệ thuật pha chế - Espresso 3" }
                });

            migrationBuilder.InsertData(
                table: "ProductType",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 6, "Đồ lưu niệm", "Bộ sưu tập - quà tặng" },
                    { 5, "Bánh", "Bánh - snack" },
                    { 4, "Đá xay", "Đá xay - Choco - Matcha" },
                    { 2, "Cà phê pha", "Cà phê pha" },
                    { 1, "Cà phê đóng gói", "Cà phê gói - Uống liền" },
                    { 3, "Trà Trái Cây - Trà sữa", "Trà Trái Cây - Trà sữa" }
                });

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "Description", "RoleName" },
                values: new object[] { 1, "Administrator", "admin" });

            migrationBuilder.InsertData(
                table: "Supplier",
                columns: new[] { "Id", "Address", "City", "Country", "Description", "Name", "Phone", "Url" },
                values: new object[,]
                {
                    { 1, "Quận 1", "Hồ Chí Minh", "Việt Nam", "Chuyên phân phối nguyên liệu, sản phầm đồ uống", "Nhà phân phối sản phẩm đồ uống", "01122334455", "supplier1.com" },
                    { 2, "Quận 1", "Hồ Chí Minh", "Việt Nam", "Chuyên phân phối nguyên liệu, sản phầm đồ ăn", "Nhà phân phối sản phẩm đồ ăn", "11122334455", "supplier2.com" },
                    { 3, "Quận 1", "Hồ Chí Minh", "Việt Nam", "Chuyên phân phối đồ sưu tập, quà lưu niệm", "Nhà phân phối đồ sưu tập, quà lưu niệm", "21122334455", "supplier3.com" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "Address", "Avata", "City", "Country", "Email", "Gender", "Name", "Password", "Phone", "Username" },
                values: new object[,]
                {
                    { 3, "167/19 Đặng Thùy Trâm", "hoang.png", "Hồ Chí Minh", "Việt Nam", "khachhang3@gmail.com", 1ul, "Nguyễn Bá Hoàng", "khachhang3", "0942400724", "khachhang3" },
                    { 1, "167/19 Đặng Thùy Trâm", "nhat.png", "Hồ Chí Minh", "Việt Nam", "khachhang1@gmail.com", 1ul, "Võ Hoàng Nhật", "khachhang1", "0942400722", "khachhang1" },
                    { 2, "167/19 Đặng Thùy Trâm", "qhuy.png", "Hồ Chí Minh", "Việt Nam", "khachhang2@gmail.com", 1ul, "Bùi Quốc Huy", "khachhang2", "0942400723", "khachhang2" },
                    { 4, "167/19 Đặng Thùy Trâm", "nhuy.png", "Hồ Chí Minh", "Việt Nam", "khachhang4@gmail.com", 1ul, "Nguyễn Văn Nhật Huy", "khachhang4", "0942400725", "khachhang4" }
                });

            migrationBuilder.InsertData(
                table: "Account",
                columns: new[] { "Id", "Password", "RoleId", "Username" },
                values: new object[] { 1, "admin123", 1, "admin" });

            migrationBuilder.InsertData(
                table: "Bill",
                columns: new[] { "Id", "Status", "TotalPrice", "UserId", "Validated" },
                values: new object[,]
                {
                    { 4, "Pending", 80000L, 1, 1 },
                    { 3, "Active", 50000L, 1, 1 },
                    { 2, "Pending", 120000L, 1, 0 },
                    { 1, "Paid", 100000L, 1, 1 }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "CreatedDate", "Description", "Name", "Photo", "Price", "ProductTypeId", "Size", "SupplierId" },
                values: new object[,]
                {
                    { 19, new DateTime(2021, 11, 18, 14, 42, 29, 112, DateTimeKind.Local).AddTicks(9351), "Caramel Macchiato sẽ mang đến một sự ngạc nhiên thú vị khi vị thơm béo của bọt sữa, sữa tươi, vị đắng thanh thoát của cà phê Espresso hảo hạng và vị ngọt đậm của sốt caramel được gói gọn trong một tách cà phê.", "Mochi Kem Xoài", "https://minio.thecoffeehouse.com/image/admin/mochi-xoai_355815_400x400.jpg", 19000, 5, 0, 2 },
                    { 18, new DateTime(2021, 11, 18, 14, 42, 29, 112, DateTimeKind.Local).AddTicks(9349), "Caramel Macchiato sẽ mang đến một sự ngạc nhiên thú vị khi vị thơm béo của bọt sữa, sữa tươi, vị đắng thanh thoát của cà phê Espresso hảo hạng và vị ngọt đậm của sốt caramel được gói gọn trong một tách cà phê.", "Mochi Kem Dừa Dứa", "https://minio.thecoffeehouse.com/image/admin/mochi-dua_975992_400x400.jpg", 19000, 5, 0, 2 },
                    { 17, new DateTime(2021, 11, 18, 14, 42, 29, 112, DateTimeKind.Local).AddTicks(9348), "Caramel Macchiato sẽ mang đến một sự ngạc nhiên thú vị khi vị thơm béo của bọt sữa, sữa tươi, vị đắng thanh thoát của cà phê Espresso hảo hạng và vị ngọt đậm của sốt caramel được gói gọn trong một tách cà phê.", "Mochi Kem Phúc Bồn Tử", "https://minio.thecoffeehouse.com/image/admin/mochi-phucbontu_097500_400x400.jpg", 19000, 5, 0, 2 },
                    { 16, new DateTime(2021, 11, 18, 14, 42, 29, 112, DateTimeKind.Local).AddTicks(9346), "Caramel Macchiato sẽ mang đến một sự ngạc nhiên thú vị khi vị thơm béo của bọt sữa, sữa tươi, vị đắng thanh thoát của cà phê Espresso hảo hạng và vị ngọt đậm của sốt caramel được gói gọn trong một tách cà phê.", "Mochi Kem Việt Quất", "https://minio.thecoffeehouse.com/image/admin/mochi-vietqwuoc_130861_400x400.jpg", 19000, 5, 0, 2 },
                    { 15, new DateTime(2021, 11, 18, 14, 42, 29, 112, DateTimeKind.Local).AddTicks(9344), "Caramel Macchiato sẽ mang đến một sự ngạc nhiên thú vị khi vị thơm béo của bọt sữa, sữa tươi, vị đắng thanh thoát của cà phê Espresso hảo hạng và vị ngọt đậm của sốt caramel được gói gọn trong một tách cà phê.", "Chocolate Đá Xay", "https://minio.thecoffeehouse.com/image/admin/Chocolate-ice-blended_400940_400x400.jpg", 59000, 4, 0, 1 },
                    { 14, new DateTime(2021, 11, 18, 14, 42, 29, 112, DateTimeKind.Local).AddTicks(9342), "Caramel Macchiato sẽ mang đến một sự ngạc nhiên thú vị khi vị thơm béo của bọt sữa, sữa tươi, vị đắng thanh thoát của cà phê Espresso hảo hạng và vị ngọt đậm của sốt caramel được gói gọn trong một tách cà phê.", "Sinh Tố Việt Quất", "https://minio.thecoffeehouse.com/image/admin/sinh-to-viet-quoc_145138_400x400.jpg", 59000, 4, 0, 1 },
                    { 12, new DateTime(2021, 11, 18, 14, 42, 29, 112, DateTimeKind.Local).AddTicks(9338), "Caramel Macchiato sẽ mang đến một sự ngạc nhiên thú vị khi vị thơm béo của bọt sữa, sữa tươi, vị đắng thanh thoát của cà phê Espresso hảo hạng và vị ngọt đậm của sốt caramel được gói gọn trong một tách cà phê.", "Cà Phê Đá Xay-Lạnh", "https://minio.thecoffeehouse.com/image/admin/cf-da-xay-(1)_158038_400x400.jpg", 59000, 4, 0, 1 },
                    { 13, new DateTime(2021, 11, 18, 14, 42, 29, 112, DateTimeKind.Local).AddTicks(9340), "Caramel Macchiato sẽ mang đến một sự ngạc nhiên thú vị khi vị thơm béo của bọt sữa, sữa tươi, vị đắng thanh thoát của cà phê Espresso hảo hạng và vị ngọt đậm của sốt caramel được gói gọn trong một tách cà phê.", "Cookie Đá Xay", "https://minio.thecoffeehouse.com/image/admin/Chocolate-ice-blended_183602_400x400.jpg", 59000, 4, 0, 1 },
                    { 10, new DateTime(2021, 11, 18, 14, 42, 29, 112, DateTimeKind.Local).AddTicks(9334), "Caramel Macchiato sẽ mang đến một sự ngạc nhiên thú vị khi vị thơm béo của bọt sữa, sữa tươi, vị đắng thanh thoát của cà phê Espresso hảo hạng và vị ngọt đậm của sốt caramel được gói gọn trong một tách cà phê.", "Hồng Trà Latte Macchiato", "https://minio.thecoffeehouse.com/image/admin/hong-tra-latte_618293_400x400.jpg", 55000, 3, 0, 1 },
                    { 9, new DateTime(2021, 11, 18, 14, 42, 29, 112, DateTimeKind.Local).AddTicks(9333), "Caramel Macchiato sẽ mang đến một sự ngạc nhiên thú vị khi vị thơm béo của bọt sữa, sữa tươi, vị đắng thanh thoát của cà phê Espresso hảo hạng và vị ngọt đậm của sốt caramel được gói gọn trong một tách cà phê.", "Hồng Trà Sữa Trân Châu", "https://minio.thecoffeehouse.com/image/admin/tra-nhan-da_484810_400x400.jpg", 55000, 3, 0, 1 },
                    { 8, new DateTime(2021, 11, 18, 14, 42, 29, 112, DateTimeKind.Local).AddTicks(9331), "Caramel Macchiato sẽ mang đến một sự ngạc nhiên thú vị khi vị thơm béo của bọt sữa, sữa tươi, vị đắng thanh thoát của cà phê Espresso hảo hạng và vị ngọt đậm của sốt caramel được gói gọn trong một tách cà phê.", "Trà sữa Oolong Nướng Trân Châu", "https://minio.thecoffeehouse.com/image/admin/olong-nuong-tran-chau_017573_400x400.jpg", 55000, 3, 0, 1 },
                    { 7, new DateTime(2021, 11, 18, 14, 42, 29, 112, DateTimeKind.Local).AddTicks(9329), "Caramel Macchiato sẽ mang đến một sự ngạc nhiên thú vị khi vị thơm béo của bọt sữa, sữa tươi, vị đắng thanh thoát của cà phê Espresso hảo hạng và vị ngọt đậm của sốt caramel được gói gọn trong một tách cà phê.", "Cà Phê Đá Xay-Lạnh", "https://minio.thecoffeehouse.com/image/admin/cf-da-xay-(1)_158038_400x400.jpg", 59000, 2, 0, 1 },
                    { 6, new DateTime(2021, 11, 18, 14, 42, 29, 112, DateTimeKind.Local).AddTicks(9328), "Caramel Macchiato sẽ mang đến một sự ngạc nhiên thú vị khi vị thơm béo của bọt sữa, sữa tươi, vị đắng thanh thoát của cà phê Espresso hảo hạng và vị ngọt đậm của sốt caramel được gói gọn trong một tách cà phê.", "Caramel Macchiato Đá", "https://minio.thecoffeehouse.com/image/admin/caramel-macchiato_143623_400x400.jpg", 50000, 2, 0, 1 },
                    { 5, new DateTime(2021, 11, 18, 14, 42, 29, 112, DateTimeKind.Local).AddTicks(9325), "Bạc sỉu chính là 'Ly sữa trắng kèm một chút cà phê'. Thức uống này rất phù hợp những ai vừa muốn trải nghiệm chút vị đắng của cà phê vừa muốn thưởng thức vị ngọt béo ngậy từ sữa.", "Bạc Sỉu", "https://minio.thecoffeehouse.com/image/admin/caphe-suada--bacsiu_063797_400x400.jpg", 32000, 2, 0, 1 },
                    { 4, new DateTime(2021, 11, 18, 14, 42, 29, 112, DateTimeKind.Local).AddTicks(9323), "Cà phê được pha phin truyền thống kết hợp với sữa đặc tạo nên hương vị đậm đà, hài hòa giữa vị ngọt đầu lưỡi và vị đắng thanh thoát nơi hậu vị.", "Cà Phê Sữa Đá", "https://minio.thecoffeehouse.com/image/admin/rich-finish-nopromo_485968.jpg", 90000, 1, 0, 1 },
                    { 3, new DateTime(2021, 11, 18, 14, 42, 29, 112, DateTimeKind.Local).AddTicks(9320), "Được rang dưới nhiệt độ vàng, Cà phê Peak Flavor - Hương thơm đỉnh cao lưu giữ trọn vẹn hương thơm tinh tế đặc trưng của cà phê Robusta Đăk Nông và Arabica Cầu Đất. Với sự hòa trộn nhiều cung bậc giữa hương và vị sẽ mang đến cho bạn một ngày mới tràn đầy cảm hứng.", "Cà Phê Peak Flavor Hương Thơm Đỉnh Cao (350G)", "https://minio.thecoffeehouse.com/image/admin/peak-plavor-nopromo_715372_400x400.jpg", 90000, 1, 0, 1 },
                    { 2, new DateTime(2021, 11, 18, 14, 42, 29, 112, DateTimeKind.Local).AddTicks(9269), "Với thiết kế lon cao trẻ trung, hiện đại và tiện lợi, Cà phê sữa đá lon thơm ngon đậm vị của The Coffee House sẽ đồng hành cùng nhịp sống sôi nổi của tuổi trẻ và giúp bạn có được một ngày làm việc đầy hứng khởi.", "Cà Phê Sữa Đá Hòa Tan", "https://minio.thecoffeehouse.com/image/admin/cpsd-3in1_971575_400x400.jpg", 44000, 1, 0, 1 },
                    { 1, new DateTime(2021, 11, 18, 14, 42, 29, 111, DateTimeKind.Local).AddTicks(8665), "Cà phê được pha phin truyền thống kết hợp với sữa đặc tạo nên hương vị đậm đà, hài hòa giữa vị ngọt đầu lưỡi và vị đắng thanh thoát nơi hậu vị.", "Thùng 24 Lon Cà Phê Sữa Đá", "https://minio.thecoffeehouse.com/image/admin/24-lon-cpsd_225680_400x400.jpg", 336000, 1, 0, 1 },
                    { 11, new DateTime(2021, 11, 18, 14, 42, 29, 112, DateTimeKind.Local).AddTicks(9336), "Caramel Macchiato sẽ mang đến một sự ngạc nhiên thú vị khi vị thơm béo của bọt sữa, sữa tươi, vị đắng thanh thoát của cà phê Espresso hảo hạng và vị ngọt đậm của sốt caramel được gói gọn trong một tách cà phê.", "Trà Long Nhãn Hạt Chia", "https://minio.thecoffeehouse.com/image/admin/tra-nhan-da_484810_400x400.jpg", 45000, 3, 0, 1 }
                });

            migrationBuilder.InsertData(
                table: "ShoppingCart",
                columns: new[] { "Id", "UserId" },
                values: new object[,]
                {
                    { 3, 3 },
                    { 1, 1 },
                    { 2, 2 },
                    { 4, 4 }
                });

            migrationBuilder.InsertData(
                table: "ShoppingCart_Product",
                columns: new[] { "ProductId", "ShoppingCartId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 1 },
                    { 1, 2 },
                    { 3, 2 },
                    { 3, 3 },
                    { 2, 3 },
                    { 1, 4 },
                    { 4, 4 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Account",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Bill",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Bill",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Bill",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Bill",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Discount",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Discount",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Discount",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Discount",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Discount",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "ProductType",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "ShoppingCart_Product",
                keyColumns: new[] { "ProductId", "ShoppingCartId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "ShoppingCart_Product",
                keyColumns: new[] { "ProductId", "ShoppingCartId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "ShoppingCart_Product",
                keyColumns: new[] { "ProductId", "ShoppingCartId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "ShoppingCart_Product",
                keyColumns: new[] { "ProductId", "ShoppingCartId" },
                keyValues: new object[] { 3, 2 });

            migrationBuilder.DeleteData(
                table: "ShoppingCart_Product",
                keyColumns: new[] { "ProductId", "ShoppingCartId" },
                keyValues: new object[] { 2, 3 });

            migrationBuilder.DeleteData(
                table: "ShoppingCart_Product",
                keyColumns: new[] { "ProductId", "ShoppingCartId" },
                keyValues: new object[] { 3, 3 });

            migrationBuilder.DeleteData(
                table: "ShoppingCart_Product",
                keyColumns: new[] { "ProductId", "ShoppingCartId" },
                keyValues: new object[] { 1, 4 });

            migrationBuilder.DeleteData(
                table: "ShoppingCart_Product",
                keyColumns: new[] { "ProductId", "ShoppingCartId" },
                keyValues: new object[] { 4, 4 });

            migrationBuilder.DeleteData(
                table: "Supplier",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ProductType",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ProductType",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ProductType",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ProductType",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ShoppingCart",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ShoppingCart",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ShoppingCart",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ShoppingCart",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Supplier",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ProductType",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Supplier",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
