# Framwork_IS220.M11.HTCL_2


<!-- PROJECT LOGO -->
<br />
<div align="center">
  <a href="">
  </a>

  <h3 align="center">Cofffe & Book</h3>

  <p align="center">
    Website quản lý chỗi coffee bán lẻ hàng đầu Việt Nam
    <br />
    <a href="https://github.com/VHNhat/framwork_IS220.M11.HTCL_2"><strong>Khám phá »</strong></a>
    <br />
    <br />
    <a href="https://coffee-huybui.vercel.app/">Xem Demo</a>
    ·
    <a href="https://github.com/VHNhat/framwork_IS220.M11.HTCL_2/issues">Báo lỗi</a>
    ·
    <a href="https://github.com/VHNhat/framwork_IS220.M11.HTCL_2/issues">Các yêu cầu</a>
  </p>
</div>



<!-- TABLE OF CONTENTS -->
<details>
  <summary>Mục lục</summary>
  <ol>
    <li>
      <a href="#muctieu">Mục tiêu đồ án</a>
    </li>
    <li>
      <a href="#dsthanhvien">Danh sách thành viên</a>
    </li>
    <li><a href="#framework">Các Framework</a></li>
    <li>
      <a href="#chucnang">Các chức năng</a>
    </li>
    <li><a href="#yeucau">Yêu cầu hệ thống</a></li>
    <li>
      <a href="#caidat">Cài đặt và sử dụng</a>
      <ul><a href="#setup">Setup môi trường</a></ul>
      <ul><a href="#start">Khởi động dự </a></ul>
    </li>
    <li><a href="#lienhe">Liên hệ</a></li>
    <li><a href="#banquyen">Bản quyền</a></li>
    <li><a href="#thamkhao">Tài liệu tham khảo</a></li>
  </ol>
</details>



<!-- ABOUT THE PROJECT -->
## <h2 id="muctieu">Mục tiêu của đồ án</h2>
Đây là project của môn học Xây dựng hệ thống thông tin trên các Framework - UIT. Nội dung là tạo một trang web quản lý chuỗi bán lẻ cà phê và sách

Trang web phải đảm bảo được các mục tiêu:
- Giúp khách hàng mua hàng được nhanh chóng và đúng sản phẩm mình cần.
- Tiện lợi cho người bán hàng dễ dàng quản lý cửa hàng của mình.
- Giao diện đơn giản, load nhanh.
## <h2 id="dsthanhvien">Các thành viên tham gia project</h2>
 
| STT| Họ tên         | MSSV                 | FB                                                   |   SĐT     |     Nhiệm vụ    |   Đánh giá % |
|:--:|----------------|------------------------|----------------------------------------------------|-----------|-----------------|--------------|
| 1  | Võ Hoàng Nhật       | 19521960 |[Hoàng Nhật](https://www.facebook.com/nhat.vo.98837)         |0942400722 |Trưởng nhóm      |     30       |
| 2  | Bùi Quốc Huy        | 19521598 |[Quốc Huy](https://www.facebook.com/BuiQuocHuyFST)           |0963639201 |Code frontend    |     30       | 
| 3  | Nguyễn Bá Hoàng     | 19521535 |[Bá Hoàng](https://www.facebook.com/hoang.nguyenba.10297701) |           |Code backend     |     20       |
| 4  | Nguyễn Văn Nhật Huy | 19521628 |[Nhật Huy](https://www.facebook.com/hoang.nguyenba.10297701) |0923109817 |Thiết kế database|     20       |


### <h2 id="framework">Các Framework sử dụng</h2>

Trang web được xây dựng bởi các thư viện, framwork hiện đại:
* Frontend: [React.js](https://reactjs.org/) + [Bootstrap](https://getbootstrap.com) + [JQuery](https://jquery.com)
* Backend: [ASP .NET](https://dotnet.microsoft.com)

# <h2 id="chucnang">Tóm tắt chức năng</h2>
-Khách hàng:
+ Đăng nhập,đăng ký
+ Mua và đặt hàng,sử dụng khuyến mãi
+ Xem thông tin vận đơn
+ Xem thông tin cơ bản của account khách hàng,Cập nhật thông tin mới 
+ Nhận Email cảm ơn
+ Tra cứu cửa hàng trên google map
+ Đọc tin tức 
-Admin:
Thêm sửa xóa các Mục sau:
+ Hóa đơn,đơn hàng 
+ Tài khoản(account)
+ Danh sách khách hàng,Nhân viên, quản lý
+ Danh sách các cửa hàng
+ Nhà cung cấp
+ danh sách sản phẩm,tin tức
+ Nhóm quyền
+ Loại sản phẩm
+ Khuyến mãi
-Doanh số:
+ Kiểm tra được thông tin theo từng năm,tháng,ngày
+ Xuất thông tin báo cáo theo năm,tháng,ngày
-Quản lý sẽ được cấp mục sau:
+ Hóa đơn,đơn hàng (Chỉ có thể xem và hủy đơn)
+ Danh sách khách hàng (chỉ xem)
+ Danh sách nhân viên(Thêm xóa sửa)
+ Danh sách các cửa hàng(Chỉ xem chính cửa hàng đang được sở hữu)
+ danh sách sản phẩm,tin tức(thêm xóa sửa)
+ Loại sản phẩm(thêm xóa sửa)
+ Khuyến mãi(thêm xóa sửa)
-Nhân viên sẽ được cấp mục sau:
+ Hóa đơn,đơn hàng (Chỉ có thể xem)
+ Danh sách khách hàng (chỉ xem)
+ danh sách sản phẩm,tin tức(chỉ xem)
+ Loại sản phẩm(chỉ xem)
+ Khuyến mãi(chỉ xem)
-Giao hàng sẽ được cấp mục sau:
+ Hóa đơn,đơn hàng (Xóa , Hoàn tất đơn hàng)
-Bảng thống kê doanh thu sẽ được tự động khi người dùng chọn ngày và thể hiện thông tin trên file excel đúng như người dùng thấy trên bảng kết quả.
-Khi admin muốn chuyển quản lý sang một cửa hàng khác thì tự động quản lý ở cửa hàng cũ sẽ trở về rỗng.
-Tạo account tương ứng cho quản lý sẽ chỉ được lựa chọn các nhân viên chưa có tài khoản và tự động phân quyền theo các role đã được định sẵn.

# <h2 id="bonus">Chức năng Bonus</h2>
+ Sử dụng kho lưu trữ firebase để lưu hình ảnh.
+ Emailjs để gửi mail đến khách hàng
+ Xuất Excel 
+ Xác thực, hân quyền tài khoản và hash Password
+ Ứng dụng Facebook developers (Messenger) liên kết với fanpage của CoffeeBook

# <h2 id="yeucau">Yêu cầu hệ thống:</>
- NodeJS 14.18.1
- ASP.NET: .Net 5.0

# <h2 id="caidat">Cài đặt và sử dụng</h2>
## <h3 id="setup">Setup môi trường</h3>
1. Tải và cài đặt NodeJs 14.18.1. Link tải [NodeJS](https://nodejs.org/dist/v14.18.1/node-v14.18.1-x64.msi)
+ Vào cmd gõ 
 ```sh
   npm install yarn -g
   ```
2. Tải mySQL:
- Cách tải bằng docker:

Bước 1: Tải và cài docker desktop
- Link tải: [Docker](https://docs.docker.com/desktop/windows/install/)

Bước 2: Tải MySql trên docker:
- Chạy lệnh Run as administrator Powershell -> gõ lệnh:
```sh
   docker run --name MySQLDB -e MYSQL_ROOT_PASSWORD=1234 -p 3306:3306 -d mysql
   ```
- Sau khi docker đã tải mySQL thì bấm nút run để khởi động mySQL

3. Tải mySQL Workbench - Công cụ làm việc với CSDL mySQL
- Link tải: [mySQL Workbench](https://www.mysql.com/products/workbench/)

4. Tải và cài đặt Visual Studio 2017 trở lên

## <h3 id="start">Khởi động dự án</h3>
### Backend 
- Bước 1: Mở file "CoffeeBook.sln" để khởi động dự án
- Bước 2: migration database 
+ Cách làm: Tools -> Nuget Package Manager -> Package Manager Console.
+ Gõ câu lệnh: 
```sh
   update-database
   ```
- Bước 3: Kiểm tra trong CSDL xem đã có database "CoffeeBook" chưa?
- Bước 4: Nếu đã xong bước migration database, tiếp theo ta chỉ cần run project.

### Frontend
1. Trang Admin (dành cho Admin, Manager, Staff sử dụng)
- Bước 1: tải node-module vào các thư mục "Admin" để chạy React
+ Cách tải: Trỏ đường dẫn vào folder Admin gõ cmd: yarn
- Bước 2: Sau khi đã tải xong node-module, để khởi động trang admin gõ cmd tại đường dẫn tại folder Admin: yarn start
- Bước 3: Nếu nó thông báo trùng port, muốn chạy trên port khác hay không? Thì nhấn "y" và enter.
- Bước 4: Chờ chương trình sẽ mở ra trang web của dự án.

2. Trang Main (dành cho các customer mua, đặt hàng)
- Bước 1: tải node-module vào các thư mục "Main" để chạy React
+ Cách tải: trỏ đường dẫn vào folder Main gõ cmd: yarn
- Bước 2: Sau khi đã tải xong node-module, để khởi động trang admin gõ cmd tại đường dẫn tại folder Main: yarn start
- Bước 3: Nếu nó thông báo trùng port, muốn chạy trên port khác hay không? Thì nhấn "y" và enter.
- Bước 4: Chờ chương trình sẽ mở ra trang web của dự án.

## <h2 id="lienhe">Liên hệ</h2>

Võ Hoàng Nhật - Bùi Quốc Huy

Project Link: [https://github.com/VHNhat/framwork_IS220.M11.HTCL_2)
Email: [Nhật](mailto:nhatvh.work@gmail.com)

# <h2 id="banquyen">Bản quyền</h3>
Copyright © 2021, [H&N ](https://github.com/VHNhat/framework_IS220.M11.HTCL_2).
# <h2 id="thamkhao">Tài liệu tham khảo</h2> 
- https://www.w3schools.com/
- https://www.reactjs.org/
- https://dotnet.microsoft.com/learn/aspnet/hello-world-tutorial/intro
