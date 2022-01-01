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
    <a href="https://github.com/VHNhat/framwork_IS220.M11.HTCL_2/issues">Cách yêu cầu</a>
  </p>
</div>



<!-- TABLE OF CONTENTS -->
<details>
  <summary>Mục lục</summary>
  <ol>
    <li>
      <a href="#">Mục tiêu đồ án</a>
      <ul>
        <li><a href="#">Các công nghệ</a></li>
      </ul>
    </li>
    <li>
      <a href="#getting-started">Các Modules</a>
    </li>
    <li><a href="#">Yêu cầu hệ thống</a></li>
    <li><a href="#">Liên hệ</a></li>
    <li><a href="#">Bản quyền</a></li>
    <li><a href="#">Cài đặt và sử dụng</a></li>
    <li><a href="#">Tài liệu tham khảo</a></li>
  </ol>
</details>



<!-- ABOUT THE PROJECT -->
## Mục tiêu của đồ án
Đây là project của môn học Xây dựng hệ thống thông tin trên các Framework - UIT. Nội dung là tạo một trang web quản lý chuỗi bán lẻ cà phê và sách

Trang web phải đảm bảo được các mục tiêu:
- Giúp khách hàng mua hàng được nhanh chóng và đúng sản phẩm mình cần.
- Tiện lợi cho người bán hàng dễ dàng quản lý cửa hàng của mình.
- Giao diện đơn giản, load nhanh.
## Các thành viên tham gia project

| STT| Họ tên         | MSSV                 | FB                                                   |   SĐT     |  Nhiệm vụ  |   Đánh giá % |
|:--:|----------------|------------------------|----------------------------------------------------|-----------|----------- |--------------|
| 1  | Võ Hoàng Nhật       | 19521960 |[Hoàng Nhật](https://www.facebook.com/nhat.vo.98837)         |0942400722 |            |              |
| 2  | Bùi Quốc Huy        | 19521598 |[Quốc Huy](https://www.facebook.com/BuiQuocHuyFST)           |           |            |              | 
| 3  | Nguyễn Bá Hoàng     | 19521535 |[Bá Hoàng](https://www.facebook.com/hoang.nguyenba.10297701) |           |            |              |
| 4  | Nguyễn Văn Nhật Huy | 19521628 |[Nhật Huy](https://www.facebook.com/hoang.nguyenba.10297701) |0923109817 |            |              |




### Xây dựng bởi

Trang web được xây dựng bởi các thư viện, framwork hiện đại:
* Frontend: [React.js](https://reactjs.org/) + [Bootstrap](https://getbootstrap.com) + [JQuery](https://jquery.com)
* Backend: [ASP .NET](https://dotnet.microsoft.com)


# Các modules
- Quản lý cửa hàng (thêm, sửa, xóa thông tin) dành cho người bán:
  + Người dùng: chỉnh sửa thông tin, thay đổi mật khẩu, ban hành lệnh cấm với người dùng, giải quyết khiếu nại của người dùng.
  + Đơn hàng: kiểm tra đơn hàng, xóa đơn hàng, chỉnh thông tin đơn hàng.
  + Sản phẩm: thêm hạng mục sản phẩm, thêm sản phẩm vào cửa hàng, xóa sản phẩm, cập nhật thông tin sản phẩm (giá cả, tình trạng còn hàng).
- Đặt hàng.
- Tìm kiếm sản phẩm.
- Vận chuyển
- Áp dụng các mã khuyến mãi

# Yêu cầu hệ thông:
- NodeJS 17.0.1
- ASP.NET: .Net 5.0
## Liên hệ

Võ Hoàng Nhật - Bùi Quốc Huy

Project Link: [https://github.com/VHNhat/framwork_IS220.M11.HTCL_2)



# Bản quyền

# Cài đặt và sử dụng
## Tải và cài đặt NodeJs 14.18.1
1. Link tải [NodeJS](https://nodejs.org/dist/v14.18.1/node-v14.18.1-x64.msi)
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

## Khởi động dự án
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

# Tài liệu tham khảo 
- https://www.w3schools.com/
- https://www.reactjs.org/
- https://dotnet.microsoft.com/learn/aspnet/hello-world-tutorial/intro
