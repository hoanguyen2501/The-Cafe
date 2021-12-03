using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CoffeeBook.Migrations
{
    public partial class DataSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Customer",
                columns: new[] { "Id", "Address", "Avata", "City", "Country", "Email", "Gender", "Name", "Password", "Phone", "Username" },
                values: new object[,]
                {
                    { 1, "167/19 Đặng Thùy Trâm", "nhat.png", "Hồ Chí Minh", "Việt Nam", "khachhang1@gmail.com", 1, "Võ Hoàng Nhật", "khachhang1", "0942400722", "khachhang1" },
                    { 2, "167/19 Đặng Thùy Trâm", "qhuy.png", "Hồ Chí Minh", "Việt Nam", "khachhang2@gmail.com", 1, "Bùi Quốc Huy", "khachhang2", "0942400723", "khachhang2" },
                    { 3, "167/19 Đặng Thùy Trâm", "hoang.png", "Hồ Chí Minh", "Việt Nam", "khachhang3@gmail.com", 1, "Nguyễn Bá Hoàng", "khachhang3", "0942400724", "khachhang3" },
                    { 4, "167/19 Đặng Thùy Trâm", "nhuy.png", "Hồ Chí Minh", "Việt Nam", "khachhang4@gmail.com", 1, "Nguyễn Văn Nhật Huy", "khachhang4", "0942400725", "khachhang4" }
                });

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
                    { 6, "Bạn mua 5 ly cà phê - Nhà tặng thêm 2 (Hạn sử dụng 10 ngày kể từ ngày mua).", "https://feed.thecoffeehouse.com/content/images/2021/08/img_8668_grande.jpg", "Nghệ thuật pha chế - Espresso 3" },
                    { 5, "Bạn mua 5 ly cà phê - Nhà tặng thêm 2 (Hạn sử dụng 10 ngày kể từ ngày mua).", "https://feed.thecoffeehouse.com/content/images/2021/08/img_8668_grande.jpg", "Nghệ thuật pha chế - Cold Brew 3" },
                    { 4, "Bạn mua 5 ly cà phê - Nhà tặng thêm 2 (Hạn sử dụng 10 ngày kể từ ngày mua).", "https://feed.thecoffeehouse.com/content/images/2021/08/img_8668_grande.jpg", "Nghệ thuật pha chế - Espresso 2" },
                    { 2, "Bạn mua 5 ly cà phê - Nhà tặng thêm 2 (Hạn sử dụng 10 ngày kể từ ngày mua).", "https://feed.thecoffeehouse.com/content/images/2021/08/img_8668_grande.jpg", "Nghệ thuật pha chế - Espresso 1" },
                    { 1, "Bạn mua 5 ly cà phê - Nhà tặng thêm 2 (Hạn sử dụng 10 ngày kể từ ngày mua).", "https://feed.thecoffeehouse.com/content/images/2021/08/img_8668_grande.jpg", "Nghệ thuật pha chế - Cold Brew 1" },
                    { 3, "Bạn mua 5 ly cà phê - Nhà tặng thêm 2 (Hạn sử dụng 10 ngày kể từ ngày mua).", "https://feed.thecoffeehouse.com/content/images/2021/08/img_8668_grande.jpg", "Nghệ thuật pha chế - Cold Brew 2" }
                });

            migrationBuilder.InsertData(
                table: "ProductType",
                columns: new[] { "Id", "Description", "Name", "Photo" },
                values: new object[,]
                {
                    { 1, "Cà phê đóng gói", "Cà phê gói - Uống liền", "https://minio.thecoffeehouse.com/image/tch-web-order/category-thumbnails/cg_cpg_web.png" },
                    { 2, "Cà phê pha", "Cà phê pha", "https://minio.thecoffeehouse.com/image/tch-web-order/category-thumbnails/cg_coffee_web.png" },
                    { 3, "Trà Trái Cây - Trà sữa", "Trà Trái Cây - Trà sữa", "https://minio.thecoffeehouse.com/image/tch-web-order/category-thumbnails/cg_tea_milk_tea_web.png" },
                    { 4, "Đá xay", "Đá xay - Choco - Matcha", "https://minio.thecoffeehouse.com/image/tch-web-order/category-thumbnails/cg_frappu_web.png" },
                    { 5, "Bánh", "Bánh - snack", "https://minio.thecoffeehouse.com/image/tch-web-order/category-thumbnails/cg_snack_web.png" },
                    { 6, "Đồ lưu niệm", "Bộ sưu tập - quà tặng", "https://minio.thecoffeehouse.com/image/tch-web-order/category-thumbnails/cg_merchandise_web.png" }
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
                    { 2, "Quận 1", "Hồ Chí Minh", "Việt Nam", "Chuyên phân phối nguyên liệu, sản phầm đồ ăn", "Nhà phân phối sản phẩm đồ ăn", "11122334455", "supplier2.com" },
                    { 1, "Quận 1", "Hồ Chí Minh", "Việt Nam", "Chuyên phân phối nguyên liệu, sản phầm đồ uống", "Nhà phân phối sản phẩm đồ uống", "01122334455", "supplier1.com" },
                    { 3, "Quận 1", "Hồ Chí Minh", "Việt Nam", "Chuyên phân phối đồ sưu tập, quà lưu niệm", "Nhà phân phối đồ sưu tập, quà lưu niệm", "21122334455", "supplier3.com" }
                });

            migrationBuilder.InsertData(
                table: "Account",
                columns: new[] { "Id", "Password", "RoleId", "Username" },
                values: new object[] { 1, "admin123", 1, "admin" });

            migrationBuilder.InsertData(
                table: "Bill",
                columns: new[] { "Id", "Address", "CustomerId", "Name", "Note", "PayBy", "Phone", "Status", "Time", "TotalPrice", "Validated" },
                values: new object[,]
                {
                    { 1, "167/19 Đặng Thùy Trâm, quận Bình Thạnh", 1, "Nhật", "Để đá riêng", "momo", "0942400722", "Paid", "20-30 phút", 100000L, 1 },
                    { 2, "167/19 Đặng Thùy Trâm, quận Bình Thạnh", 1, "Nhật", "Để đá riêng", "momo", "0942400722", "Pending", "20-30 phút", 120000L, 0 },
                    { 3, "167/19 Đặng Thùy Trâm, quận Bình Thạnh", 1, "Nhật", "Để đá riêng", "momo", "0942400722", "Active", "20-30 phút", 50000L, 1 },
                    { 4, "167/19 Đặng Thùy Trâm, quận Bình Thạnh", 1, "Nhật", "Để đá riêng", "momo", "0942400722", "Pending", "20-30 phút", 80000L, 1 }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "CreatedDate", "Description", "Name", "Photo", "Price", "ProductTypeId", "Size", "SupplierId" },
                values: new object[,]
                {
                    { 17, new DateTime(2021, 12, 3, 11, 27, 37, 847, DateTimeKind.Local).AddTicks(4309), "Caramel Macchiato sẽ mang đến một sự ngạc nhiên thú vị khi vị thơm béo của bọt sữa, sữa tươi, vị đắng thanh thoát của cà phê Espresso hảo hạng và vị ngọt đậm của sốt caramel được gói gọn trong một tách cà phê.", "Mochi Kem Phúc Bồn Tử", "https://minio.thecoffeehouse.com/image/admin/mochi-phucbontu_097500_400x400.jpg", 19000, 5, 0, 2 },
                    { 16, new DateTime(2021, 12, 3, 11, 27, 37, 847, DateTimeKind.Local).AddTicks(4307), "Caramel Macchiato sẽ mang đến một sự ngạc nhiên thú vị khi vị thơm béo của bọt sữa, sữa tươi, vị đắng thanh thoát của cà phê Espresso hảo hạng và vị ngọt đậm của sốt caramel được gói gọn trong một tách cà phê.", "Mochi Kem Việt Quất", "https://minio.thecoffeehouse.com/image/admin/mochi-vietqwuoc_130861_400x400.jpg", 19000, 5, 0, 2 },
                    { 15, new DateTime(2021, 12, 3, 11, 27, 37, 847, DateTimeKind.Local).AddTicks(4305), "Caramel Macchiato sẽ mang đến một sự ngạc nhiên thú vị khi vị thơm béo của bọt sữa, sữa tươi, vị đắng thanh thoát của cà phê Espresso hảo hạng và vị ngọt đậm của sốt caramel được gói gọn trong một tách cà phê.", "Chocolate Đá Xay", "https://minio.thecoffeehouse.com/image/admin/Chocolate-ice-blended_400940_400x400.jpg", 59000, 4, 0, 1 },
                    { 14, new DateTime(2021, 12, 3, 11, 27, 37, 847, DateTimeKind.Local).AddTicks(4304), "Caramel Macchiato sẽ mang đến một sự ngạc nhiên thú vị khi vị thơm béo của bọt sữa, sữa tươi, vị đắng thanh thoát của cà phê Espresso hảo hạng và vị ngọt đậm của sốt caramel được gói gọn trong một tách cà phê.", "Sinh Tố Việt Quất", "https://minio.thecoffeehouse.com/image/admin/sinh-to-viet-quoc_145138_400x400.jpg", 59000, 4, 0, 1 },
                    { 13, new DateTime(2021, 12, 3, 11, 27, 37, 847, DateTimeKind.Local).AddTicks(4301), "Caramel Macchiato sẽ mang đến một sự ngạc nhiên thú vị khi vị thơm béo của bọt sữa, sữa tươi, vị đắng thanh thoát của cà phê Espresso hảo hạng và vị ngọt đậm của sốt caramel được gói gọn trong một tách cà phê.", "Cookie Đá Xay", "https://minio.thecoffeehouse.com/image/admin/Chocolate-ice-blended_183602_400x400.jpg", 59000, 4, 0, 1 },
                    { 12, new DateTime(2021, 12, 3, 11, 27, 37, 847, DateTimeKind.Local).AddTicks(4299), "Caramel Macchiato sẽ mang đến một sự ngạc nhiên thú vị khi vị thơm béo của bọt sữa, sữa tươi, vị đắng thanh thoát của cà phê Espresso hảo hạng và vị ngọt đậm của sốt caramel được gói gọn trong một tách cà phê.", "Cà Phê Đá Xay-Lạnh", "https://minio.thecoffeehouse.com/image/admin/cf-da-xay-(1)_158038_400x400.jpg", 59000, 4, 0, 1 },
                    { 11, new DateTime(2021, 12, 3, 11, 27, 37, 847, DateTimeKind.Local).AddTicks(4298), "Caramel Macchiato sẽ mang đến một sự ngạc nhiên thú vị khi vị thơm béo của bọt sữa, sữa tươi, vị đắng thanh thoát của cà phê Espresso hảo hạng và vị ngọt đậm của sốt caramel được gói gọn trong một tách cà phê.", "Trà Long Nhãn Hạt Chia", "https://minio.thecoffeehouse.com/image/admin/tra-nhan-da_484810_400x400.jpg", 45000, 3, 0, 1 },
                    { 10, new DateTime(2021, 12, 3, 11, 27, 37, 847, DateTimeKind.Local).AddTicks(4296), "Caramel Macchiato sẽ mang đến một sự ngạc nhiên thú vị khi vị thơm béo của bọt sữa, sữa tươi, vị đắng thanh thoát của cà phê Espresso hảo hạng và vị ngọt đậm của sốt caramel được gói gọn trong một tách cà phê.", "Hồng Trà Latte Macchiato", "https://minio.thecoffeehouse.com/image/admin/hong-tra-latte_618293_400x400.jpg", 55000, 3, 0, 1 },
                    { 9, new DateTime(2021, 12, 3, 11, 27, 37, 847, DateTimeKind.Local).AddTicks(4293), "Caramel Macchiato sẽ mang đến một sự ngạc nhiên thú vị khi vị thơm béo của bọt sữa, sữa tươi, vị đắng thanh thoát của cà phê Espresso hảo hạng và vị ngọt đậm của sốt caramel được gói gọn trong một tách cà phê.", "Hồng Trà Sữa Trân Châu", "https://minio.thecoffeehouse.com/image/admin/tra-nhan-da_484810_400x400.jpg", 55000, 3, 0, 1 },
                    { 8, new DateTime(2021, 12, 3, 11, 27, 37, 847, DateTimeKind.Local).AddTicks(4291), "Caramel Macchiato sẽ mang đến một sự ngạc nhiên thú vị khi vị thơm béo của bọt sữa, sữa tươi, vị đắng thanh thoát của cà phê Espresso hảo hạng và vị ngọt đậm của sốt caramel được gói gọn trong một tách cà phê.", "Trà sữa Oolong Nướng Trân Châu", "https://minio.thecoffeehouse.com/image/admin/olong-nuong-tran-chau_017573_400x400.jpg", 55000, 3, 0, 1 },
                    { 5, new DateTime(2021, 12, 3, 11, 27, 37, 847, DateTimeKind.Local).AddTicks(4210), "Bạc sỉu chính là 'Ly sữa trắng kèm một chút cà phê'. Thức uống này rất phù hợp những ai vừa muốn trải nghiệm chút vị đắng của cà phê vừa muốn thưởng thức vị ngọt béo ngậy từ sữa.", "Bạc Sỉu", "https://minio.thecoffeehouse.com/image/admin/caphe-suada--bacsiu_063797_400x400.jpg", 32000, 2, 0, 1 },
                    { 6, new DateTime(2021, 12, 3, 11, 27, 37, 847, DateTimeKind.Local).AddTicks(4287), "Caramel Macchiato sẽ mang đến một sự ngạc nhiên thú vị khi vị thơm béo của bọt sữa, sữa tươi, vị đắng thanh thoát của cà phê Espresso hảo hạng và vị ngọt đậm của sốt caramel được gói gọn trong một tách cà phê.", "Caramel Macchiato Đá", "https://minio.thecoffeehouse.com/image/admin/caramel-macchiato_143623_400x400.jpg", 50000, 2, 0, 1 },
                    { 18, new DateTime(2021, 12, 3, 11, 27, 37, 847, DateTimeKind.Local).AddTicks(4311), "Caramel Macchiato sẽ mang đến một sự ngạc nhiên thú vị khi vị thơm béo của bọt sữa, sữa tươi, vị đắng thanh thoát của cà phê Espresso hảo hạng và vị ngọt đậm của sốt caramel được gói gọn trong một tách cà phê.", "Mochi Kem Dừa Dứa", "https://minio.thecoffeehouse.com/image/admin/mochi-dua_975992_400x400.jpg", 19000, 5, 0, 2 },
                    { 4, new DateTime(2021, 12, 3, 11, 27, 37, 847, DateTimeKind.Local).AddTicks(4208), "Cà phê được pha phin truyền thống kết hợp với sữa đặc tạo nên hương vị đậm đà, hài hòa giữa vị ngọt đầu lưỡi và vị đắng thanh thoát nơi hậu vị.", "Cà Phê Sữa Đá", "https://minio.thecoffeehouse.com/image/admin/rich-finish-nopromo_485968.jpg", 90000, 1, 0, 1 },
                    { 3, new DateTime(2021, 12, 3, 11, 27, 37, 847, DateTimeKind.Local).AddTicks(4205), "Được rang dưới nhiệt độ vàng, Cà phê Peak Flavor - Hương thơm đỉnh cao lưu giữ trọn vẹn hương thơm tinh tế đặc trưng của cà phê Robusta Đăk Nông và Arabica Cầu Đất. Với sự hòa trộn nhiều cung bậc giữa hương và vị sẽ mang đến cho bạn một ngày mới tràn đầy cảm hứng.", "Cà Phê Peak Flavor Hương Thơm Đỉnh Cao (350G)", "https://minio.thecoffeehouse.com/image/admin/peak-plavor-nopromo_715372_400x400.jpg", 90000, 1, 0, 1 },
                    { 2, new DateTime(2021, 12, 3, 11, 27, 37, 847, DateTimeKind.Local).AddTicks(4156), "Với thiết kế lon cao trẻ trung, hiện đại và tiện lợi, Cà phê sữa đá lon thơm ngon đậm vị của The Coffee House sẽ đồng hành cùng nhịp sống sôi nổi của tuổi trẻ và giúp bạn có được một ngày làm việc đầy hứng khởi.", "Cà Phê Sữa Đá Hòa Tan", "https://minio.thecoffeehouse.com/image/admin/cpsd-3in1_971575_400x400.jpg", 44000, 1, 0, 1 },
                    { 1, new DateTime(2021, 12, 3, 11, 27, 37, 846, DateTimeKind.Local).AddTicks(4654), "Cà phê được pha phin truyền thống kết hợp với sữa đặc tạo nên hương vị đậm đà, hài hòa giữa vị ngọt đầu lưỡi và vị đắng thanh thoát nơi hậu vị.", "Thùng 24 Lon Cà Phê Sữa Đá", "https://minio.thecoffeehouse.com/image/admin/24-lon-cpsd_225680_400x400.jpg", 336000, 1, 0, 1 },
                    { 7, new DateTime(2021, 12, 3, 11, 27, 37, 847, DateTimeKind.Local).AddTicks(4289), "Caramel Macchiato sẽ mang đến một sự ngạc nhiên thú vị khi vị thơm béo của bọt sữa, sữa tươi, vị đắng thanh thoát của cà phê Espresso hảo hạng và vị ngọt đậm của sốt caramel được gói gọn trong một tách cà phê.", "Cà Phê Đá Xay-Lạnh", "https://minio.thecoffeehouse.com/image/admin/cf-da-xay-(1)_158038_400x400.jpg", 59000, 2, 0, 1 },
                    { 19, new DateTime(2021, 12, 3, 11, 27, 37, 847, DateTimeKind.Local).AddTicks(4312), "Caramel Macchiato sẽ mang đến một sự ngạc nhiên thú vị khi vị thơm béo của bọt sữa, sữa tươi, vị đắng thanh thoát của cà phê Espresso hảo hạng và vị ngọt đậm của sốt caramel được gói gọn trong một tách cà phê.", "Mochi Kem Xoài", "https://minio.thecoffeehouse.com/image/admin/mochi-xoai_355815_400x400.jpg", 19000, 5, 0, 2 }
                });

            migrationBuilder.InsertData(
                table: "ShoppingCart",
                columns: new[] { "Id", "CustomerId" },
                values: new object[,]
                {
                    { 4, 4 },
                    { 3, 3 },
                    { 2, 2 },
                    { 1, 1 }
                });

            migrationBuilder.InsertData(
                table: "ShoppingCart_Product",
                columns: new[] { "ProductId", "ShoppingCartId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 2 },
                    { 1, 4 },
                    { 2, 1 },
                    { 2, 3 },
                    { 3, 2 },
                    { 3, 3 },
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
                table: "Customer",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ProductType",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Supplier",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
