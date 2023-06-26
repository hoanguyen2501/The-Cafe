using Microsoft.EntityFrameworkCore.Migrations;
using System;

#nullable disable

namespace CoffeeBook.Migrations
{
    public partial class UpdateMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Supplier",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LinkGG",
                table: "Store",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "District",
                table: "Store",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "ShoppingCart_Product",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 18, 10, 21, 48, 450, DateTimeKind.Local).AddTicks(3925),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 12, 28, 20, 40, 32, 287, DateTimeKind.Local).AddTicks(3842));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "ShoppingCart",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 18, 10, 21, 48, 450, DateTimeKind.Local).AddTicks(2342),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 12, 28, 20, 40, 32, 280, DateTimeKind.Local).AddTicks(5343));

            migrationBuilder.AlterColumn<string>(
                name: "Photo",
                table: "ProductType",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Photo",
                table: "Product",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ExpiredDate",
                table: "Discount",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AlterColumn<string>(
                name: "Role",
                table: "Customer",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Time",
                table: "Bill",
                type: "varchar(100)",
                maxLength: 100,
                nullable: true,
                defaultValue: "15 - 20 phút",
                oldClrType: typeof(string),
                oldType: "varchar(100)",
                oldMaxLength: 100,
                oldNullable: true,
                oldDefaultValue: "15-20 phút");

            migrationBuilder.AlterColumn<string>(
                name: "Phone",
                table: "Bill",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "PayBy",
                table: "Bill",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "Note",
                table: "Bill",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Bill",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Bill",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 18, 10, 21, 48, 449, DateTimeKind.Local).AddTicks(1780),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2021, 12, 28, 20, 40, 32, 265, DateTimeKind.Local).AddTicks(8239));

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Bill",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: 1,
                column: "Password",
                value: "$2a$11$XqIRWIXb0g29JbPl7wemxuyi8ZJI1OLUiMZGV8LDkApxxv5Fm9i/a");

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: 2,
                column: "Password",
                value: "$2a$11$6Q1ZDsmtbVFRTEO61JUwzOMAzGUjVb/hKCEbbgPOk82RtBv78lfmC");

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: 3,
                column: "Password",
                value: "$2a$11$A7HbiSB/y3E9xx9Jj9EUWOGV3MM3B39R6uci7fwOgAInnxzWDS2Ae");

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: 4,
                column: "Password",
                value: "$2a$11$wki8Z5hSVQ1FbCtR/a.BL.UuMru.DMjWBT0VHZIZHWBTPgBMGjUTy");

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 1,
                column: "Password",
                value: "$2a$11$it98kuFEAYps1LsIAfZ1gegnkwC.vxmYEYlnlcu.HvlperLs3hYBG");

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 2,
                column: "Password",
                value: "$2a$11$Vol7fKLI7I5TvAHMEe4Hqu2WvX1SCL3t4WAtDG4jFtghUBSEKUmRu");

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 3,
                column: "Password",
                value: "$2a$11$wKBe3JATRVyA6Y6U1ZJJG.NsGWUc83sm7ocCd/DTkzDy4TNk1iPwu");

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 4,
                column: "Password",
                value: "$2a$11$YGMvjGq5HSDdyQjTwMvG1u9VwVKdEgBVRC.bjQmqQipL4iB3fL4rK");

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1,
                column: "Content",
                value: "Truyền thuyết về quả cà phê\r\nCó rất nhiều truyền thuyết về nguồn gốc của cà phê.Tuy nhiên,câu chuyện người đàn ông chăn dê tên Kaldi phát hiện ra cây cà phê ở khu rừng cổ của cao nguyên Ethiopia là phổ biến và được nhiều người tin nhất.\r\nKaldi đã khám phá ra cà phê sau khi những con dê của anh ta ăn một loại quả màu đỏ từ cái cây có những bông hoa trắng và chúng trở nên hăng hái đến mức không đi ngủ vào ban đêm. Anh ta cũng đã ăn thử và nó giúp anh tỉnh táo trong suốt nhiều giờ cầu nguyện vào buổi tối. Sau đó, Kaldi đã báo cáo phát hiện của mình với giáo sĩ của tu viện địa phương. Vị giáo sĩ chia sẻ khám phá của Kaldi với nhiều người khác và kết quả là thông tin về một loại quả tràn đầy năng lượng nhanh chóng được lan truyền.\r\nLịch sử và hành trình du nhập của cà phê\r\nTuy nhiên, không chỉ có truyền thuyết, những ghi chép và dấu tích còn lại cũng khiến người ta tin rằng Kaffa - Ethiopia chính là vùng đất khởi nguyên của cây cà phê từ thế kỷ thứ 9. Và đến thế kỷ 14, những người buôn nô lệ đã mang cà phê từ Ethiopia sang xứ Ả Rập. Cà phê trở thành thức uống phổ biến của người Ả Rập với cách chế biến đầu tiên chỉ đơn giản là tách lấy hạt và cho vào nấu trong nước sôi. Ả Rập đã trở thành nơi trồng cà phê độc quyền với trung tâm giao dịch cà phê là thành phố cảng Mocha, hay còn được gọi là Mokka, tức là thành phố Al Mukha thuộc Yemen ngày nay.\r\nNgười Ả Rập rất tự hào và giữ bí mật để bảo tồn độc quyền loại thức uống được chế biến từ hạt cà phê. Họ đưa ra những quy định rất chặt chẽ để gìn giữ sự độc quyền về cà phê của mình như chỉ được phép mang hạt cà phê đã rang ra khỏi xứ, cũng như không cho người ngoại quốc bén mảng đến các đồn điền cà phê. Thế nhưng, dù nghiêm ngặt đến mức nào thì cũng có người vượt qua được, những khách hành hương được thưởng thức nước cà phê đã lén lút mang hạt giống về trồng, chẳng bao lâu khắp khu vực Trung Đông đều có trồng và truyền đi mỗi lúc một xa hơn. Bước sang thế kỷ 15 thì cà phê đến Armenia, Persia, Thổ Nhĩ Kỳ và phía bắc Châu Phi, phổ biến trong thế giới Hồi giáo và lan tỏa đến Ý, sau đó là phần còn lại của Châu Âu, Indonesia, Mĩ.\r\nBắt nguồn tên gọi “Cà phê”\r\nNhiều nhà nghiên cứu cho rằng, chữ “Cà phê” có thể bắt nguồn từ chữ “Qahwa” (theo tiếng Ả Rập thì “Qahwa” có nghĩa là thức uống được tạo ra từ nước của hạt quả). Qua đến người Thổ Nhĩ Kỳ được đọc là “Kahve” và nó đã được sử dụng rộng rãi khắp nơi. Một số người khác thì lại cho rằng, chữ “Cà phê” được đặt theo tên của thị trấn “Kaffa” của Ethiopia. Tuy nhiên, một số khác lại nói thị trấn “Kaffa” được đặt theo tên “Cà phê”. Và từ “cà phê” mà Việt Nam ta vẫn hay dùng có gốc từ chữ Café trong tiếng Pháp, một loại thức uống màu đen có chứa chất caffeine.\r\nNhư vậy, có thể thấy cà phê đã xuất hiện từ rất lâu đời và có những thông tin còn hoài nghi chưa được xác thực. Thế nhưng, không còn quá quan trọng vì nó đã lan khắp thế giới và ngày càng hiện diện, hoà nhịp trong cuộc sống của tất cả chúng ta. Mỗi ngày, thế giới ước tính có 2,25 tỷ tách cà phê được bán ra và đối với nhiều người, cà phê đã trở thành một phần không thể thiếu.\r\nĐặc biệt, không thể phủ nhận những giá trị vô hình mà cà phê đang mang lại. Ngoài là một thức uống thú vị và yêu thích của rất nhiều người, nó là một sự khởi đầu của ngày mới, khởi đầu của những câu chuyện, sự gắn kết của những mối quan hệ, đưa chúng ta gần nhau hơn, sẻ chia và kết nối tình cảm. Và đó cũng chính là những giá trị mà The Coffee House luôn hướng đến và đem lại bên cạnh những tách cà phê tinh túy và chất lượng, những ly trà đượm hương cùng cảm hứng về lối sống hiện đại, năng động mà gần gũi. ");

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2,
                column: "Content",
                value: "Ở Mỹ, cà phê được xuất hiện từ những năm 1600 tại New Amsterdam - thành phố New York nổi tiếng ngày nay. Từ đó cà phê dần được sử dụng và gần gũi hơn. Tuy nhiên, phong cách cà phê hiện đại của Mỹ như hiện nay được cho rằng bắt nguồn từ Ý và phát triển mạnh mẽ trong khoảng 20 năm trở lại đây.\r\nDù chịu ảnh hưởng bởi văn hóa cà phê du nhập từ Ý với lối pha dùng máy Barista nhanh chóng phổ biến,\r\n                    tuy nhiên lại có sự khác biệt rõ rệt giữa hai nền văn hoá cà phê của Ý và Mỹ.Đến với Ý bạn sẽ thấy sự chờ đợi một cách chậm rãi,\r\n                    nhẹ nhàng và sành điệu.Còn với người Mỹ thì luôn trong tâm thái nhanh gọn,\r\n                    tranh thủ thời gian.Điều này hoàn toàn dễ hiểu khi Mỹ là một quốc gia làm việc với cường độ cao,\r\n                    con người rất quý trọng thời gian và yêu cầu sự gọn lẹ.\r\nLà quốc gia trẻ và đầy sức sống, con người ở Mỹ chuộng lối sống tự do, tất cả đều theo sở thích cá nhân và văn hóa cà phê cũng không ngoại lệ. Người Mỹ sử dụng cà phê hoàn toàn theo ý thích, không sành điệu như người châu Âu, cũng không cầu kì như người Ả Rập, mà đề cao tính thoải mái.\r\nCà phê Việt thì luôn đậm đà, còn cà phê của người Mỹ được cho là nhạt từ màu sắc đến cả hương vị. Cà phê Mỹ là chất nước loãng màu nâu nhạt, có vị hơi khét, vậy nên người ta thường bảo cho thêm hai, thậm chí ba gói đường và nửa ly sữa cũng không làm chất nước ấy ngọt và thơm hơn.\r\nNgười Mỹ uống cà phê mọi lúc mọi nơi và nhiều lần trong ngày. Cà phê đối với họ là thức uống giúp tập trung đầu óc, tỉnh táo, chống buồn ngủ. Món Americano, một thức uống được biến tấu nhẹ nhàng từ món Espresso của người Ý được xem là thức uống truyền thống của người Mỹ. Ngoài ra, ở đất nước này phổ biến với Iced Coffee – cà phê đặc, nóng, thêm đường được rót vào một ly đựng đá.\r\nVào quán cà phê, người Mỹ không chỉ đơn thuần là tán gẫu. Đôi lúc họ làm việc trong quán cà phê. Đây vừa là cách tận dụng thời gian, hoặc thay đổi không gian làm việc để đầu óc tự do hơn là ngồi trong văn phòng nhàm chán. Hơn thế nữa, người ta còn vào cà phê để bàn bạc công việc, thảo luận, trao đổi và dĩ nhiên là có cả hẹn hò! Và những điều này thì chúng ta cũng thấy thân thuộc đối với người Việt và phong cách đi cà phê hiện nay.\r\nCũng giống khi bước vào không gian của The Coffee House, bạn sẽ bắt gặp hình ảnh quen thuộc của những đôi bạn trẻ trò chuyện bên tách cà phê, ai đó làm việc hăng say hay chú tâm đọc sách bất kể những âm thanh rì rào bên cạnh, cũng như những cuộc gặp gỡ niềm nở giữa đối tác và khách hàng, hay những người bạn lâu ngày mới gặp lại nhưng rất đỗi thân tình...\r\nĐối với The Coffee House đó là một niềm thật hạnh phúc. Hạnh phúc khi luôn được đồng hành và gắn liền trong những câu chuyện, những lần gặp gỡ đong đầy tình cảm. Góp mặt trong hành trình sống của mỗi người và là nơi lưu giữ những kỷ niệm. The Coffee House tự hào mang đến những trải nghiệm khác biệt, thoải mái, những hương vị tinh tế và quyến rũ cho khách hàng thân yêu, đặc biệt biệt là góp phần kiến tạo nên phong cách và văn hóa thưởng thức cà phê của người Việt.");

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 3,
                column: "Content",
                value: "Uống cà phê là một thú vui và đến với mỗi quốc gia, bạn sẽ thấy rằng thú vui này sẽ mang những nét khác biệt. The Coffee House chia sẻ đến bạn những phong cách uống cà phê nổi tiếng của các nước trên thế giới, cùng xem để hiểu hơn về văn hoá độc đáo này, hay kể cả tự pha chế để thưởng thức xem cảm nhận mới lạ như thế nào nhé!\r\nItaly\r\nLà “thủ phủ” cà phê nổi tiếng trên thế giới, thức uống này là món không thể thiếu đối với người dân Italy.Họ thường bắt đầu ngày mới với một ly cà phê và loại thường được dùng nhiều nhất chính là Espresso.\r\nĐây là loại cà phê có thể phục vụ nhanh, có cho bạn ngay lập tức và thường được đựng trong những chiếc ly nhỏ. Người Italy khi thưởng thức sẽ cầm ly trong tay, hít hà mùi thơm quyến rũ rồi uống trong 3-4 hơi. Cả quá trình diễn ra nhanh gọn nhưng đầy thanh lịch theo đúng phong cách người Italy.\r\n\r\nPháp\r\nỞ Pháp thường dùng Café Au Lait, nghe thôi đã rất Pháp rồi đúng không? Đây là loại cà phê được pha chế hết sức đơn giản.\r\nLà sự pha trộn giữa cà phê espresso và sữa tươi nóng. Café Au Lait là thức uống yêu thích của người Pháp vào buổi sáng và thường được dùng cùng bánh mì Baguette. Café Au Lait và Baguette, sự kết hợp biểu tượng của ẩm thực Pháp.\r\n\r\nĐức\r\nEiskaffee là món cà phê quen thuộc của người Đức. Nó đích thị dành cho những ai thích sự ngọt ngào. Eiskaffee trong tiếng Đức có nghĩa là “cà phê kem lạnh”. Vị beo béo của kem lạnh lơ lửng trong lớp cà phê đắng kết hợp cùng tầng kem whipping ngọt ngào và một ít vụn choco đã tạo nên thứ đồ uống hấp dẫn khó cưỡng.\r\nVậy nên Eiskaffee đã đã chinh phục khẩu vị không chỉ của người dân nước Đức, trở thành món đồ uống “quốc dân” của đất nước này mà còn thu hút cả những khách du lịch đến nơi đây.\r\n\r\nBồ Đào Nha\r\nNgười Bồ Đào Nha cực kì ưa chuộng và phổ biến với món cà phê pha chanh mát lạnh Mazagran. Để thưởng thức món cà phê này hết sức đơn giản, bạn chỉ cần đổ hai tách espresso và nước cốt chanh vào một ly cao, thêm đường cho vừa uống và một ít đá viên.\r\nVới sự kết hợp đặc biệt từ vị chua của chanh khiến món cà phê này có vị khác hẳn so với các loại cà phê khác trên thế giới. Đây cũng là một thức uống lý tưởng và sảng khoái cho những ngày hè.\r\n\r\nHy Lạp\r\nKhá giống như người Bồ Đào Nha, người Hy Lạp cũng có một thức uống cà phê được yêu chuộng vào những ngày hè nhằm xua đi cái nóng nực. Đó chính là Frappé. Trong tiếng Pháp nó có nghĩa “ướp lạnh”, là loại cà phê hòa tan đánh sủi bọt hết sức độc đáo và được biết đến như biểu tượng của đất nước Hy Lạp.\r\nĐể pha Frappé, đầu tiên cho cà phê bột vào ly, thêm một thìa cà phê đường và một ít nước đá. Dùng máy trộn tay (handmixer) khuấy mạnh cho đến khi cà phê sủi bọt. Cuối cùng cho đá và rót một thêm một ít nước lạnh là bạn đã hoàn thành. Frappe thường được pha chế khá đậm và sử dụng cà phê hoà tan mạnh, nếu dùng không quen, bạn có thể thêm nước để pha loãng cà phê hoặc thêm đường vào để thưởng thức ngọt hơn.\r\n\r\nCà phê sữa Việt Nam\r\nMỗi đất nước đều có loại cà phê yêu thích đặc trưng. Và đối với người Việt đó là món cà phê sữa. Bạn thường thưởng thức cà phê sữa như thế nào? Mỗi buổi sáng tự pha cho mình hay ra cửa hàng gọi một ly cà phê sữa theo ý thích. Không chỉ quen thuộc với người Việt, cà phê sữa là món đồ uống mà khách du lịch các nước rất hứng thú thưởng thức khi đặt chân đến mảnh đất hình chữ S. Và nhiều thực khách nước ngoài khi vào cửa hàng của The Coffee House cũng thường xuyên lựa chọn cà phê sữa.\r\nKhông giống những nước khác thường sử dụng cà phê pha sẵn, cà phê bột,…Việt Nam sử dụng loại cà phê xay nhuyễn, cho vào loại phin đặc trưng của bản xứ, sau đó đổ nước sôi vào. Từng giọt cà phê đậm đặc, sóng sánh, chảy qua chiếc phin đặc biệt hòa cùng sữa đặc, cho thêm đá đã tạo nên ly cà phê sữa đá đậm đà, đắng đót nhưng cũng thanh ngọt nơi hậu vị.\r\nKhông chỉ mỗi quốc gia sẽ có một loại cà phê đặc trưng và cách thưởng thức riêng biệt, mà mỗi cá nhận lại còn có cả phong cách uống cà phê rất khác. Phong cách thưởng thức cà phê của bạn là gì? Cà phê đen hay cà phê sữa, nhiều đường hay ít sữa, nóng hay đá, pha phin hay dùng sẵn, lựa chọn Espresso hay Capuccino, bạn có muốn thưởng thức thêm vị Matcha hay Macchiato... Mỗi người mỗi sở thích, mỗi người mỗi phong cách và cá tính, nhưng The Coffee House lại luôn tự tin mang đến sự hài lòng cho khách hàng bởi những trải nghiệm độc đáo, sự đa dạng, phá cách và hơn hết là những hương vị tuyệt vời nhất.");

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 4,
                column: "Content",
                value: "GỢI Ý NHỮNG LOẠI CÀ PHÊ CHO NGÀY BẬN RỘN\r\nĐối với những người đã yêu thích cà phê rồi thì hôm nào cũng cần phải có ít nhất một ly.Và đặc biệt đối với những người đã là tín đồ của cà phê thì họ lại rất khó tính,\r\n                    yêu cầu cao về hương vị và sự nguyên chất,\r\n                    đậm đà của loại cà phê mà mình thưởng thức mỗi ngày.Bạn có đang nằm trong số đó,\r\n                    và nếu những ngày bận rộn,\r\n                    bạn không có thời gian để tự tay pha cho mình một ly cà phê hay ghé đến quán cà phê quen thuộc để thưởng thức thì như thế nào ?\r\n\r\nĐừng nói rằng bạn sẽ tạm hoãn cái ghiền cà phê của bản thân lại nhé.Vì đó thật sự là một điều rất khó chịu,\r\n                    đặc biệt nữa là khi bạn đã quá quen với việc bắt đầu buổi sáng với một ly cà phê để giúp tỉnh táo,\r\n                    tập trung và có cảm hứng hơn khi bắt đầu bước vào công việc.\r\n\r\nThe Coffee House gợi ý những loại cà phê đậm đà,\r\n                    thơm ngon và hương vị đúng nghĩa cà phê tinh túy.Hãy cùng lựa chọn cho những ngày bận rộn trong guồng quay của công việc và cuộc sống nhé.Với những dòng cà phê được giới thiệu dưới đây,\r\n                    The Coffee House tin chắc dù thời gian hạn hẹp đến đâu thì bạn cũng có thể ưu ái và phục vụ bản thân mình bằng một tách cà phê thơm ngon đúng “gu” nhất.\r\n\r\nCà phê sữa đá hoà tan\r\n\r\nVới cà phê sữa đá hoà tan thì thật dễ dàng để bạn bắt đầu ngày mới với ly cà phê sóng sánh,\r\n                    thơm lừng và lựa chọn uống nóng hay uống lạnh theo sở thích của bản thân.Chắc chắn ai cũng phải công nhận sự tiện lợi của cà phê sữa đá hoà tan vì không cần phải mất nhiều thời gian pha chế hay phải chuẩn bị những dụng cụ pha chế.Thay vào đó chỉ cần pha theo hướng dẫn trên bao bì là đã có ngay một ly cà phê thơm ngon,\r\n                    chuẩn vị.The Coffee House gợi ý 3 dòng sản phẩm để bạn lựa chọn: cà phê sữa đá hoà tan dạng túi,\r\n                    cà phê sữa đá hoà tan dạng hộp và cà phê hoà tan 3in1 đậm vị Việt.\r\nCà phê sữa đá hoà tan dạng túi và hộp: Đây là 02 phiên bản giống nhau về chất lượng cà phê, giữ được hương vị thơm ngon thuần tuý như cà phê pha phin với sữa đặc. Vị đắng thanh của cà phê hoà quyện với vị ngọt béo của sữa, giúp bạn luôn tỉnh táo và hứng khởi cho ngày làm việc thật hiệu quả. Thật sự là lựa chọn lý tưởng cho những ngày hối hả của nhịp sống hiện đại.\r\nCà phê hoà tan 3in1 đậm vị Việt: đây là dòng sản phẩm với vị đậm đà, đặc biệt phù hợp với những ai có gu cà phê mạnh. 3in1 đậm vị Việt giữ trọn vẹn hương vị đắng thơm tinh tế từ hạt cà phê, là sự lựa chọn đậm đà và mạnh mẽ hơn so với hai phiên bản cà phê sữa dạng hộp và túi được The Coffee House chia sẻ trên.\r\n\r\nCà phê sữa đá dạng lon\r\n\r\nCà phê sữa đá dạng lon của The Coffee House mang phong cách hiện đại, đồng hành cùng nhịp sống sôi nổi của người trẻ và tiện dụng trong cuộc sống tất bật . Sản phẩm được sản xuất từ những hạt cà phê Việt thượng hạng và công thức phối trộn độc đáo mang đến hương vị đậm đà, thơm béo.\r\nVới thiết kế lon cao trẻ trung, đơn giản và tiện lợi, dù ở đâu, bạn vẫn có thể tận hưởng vị cà phê sữa thơm ngon đến ngụm cuối cùng. Sản phù hợp cả khi bạn ở nhà, văn phòng, đặc biệt là những lúc di chuyển trên đường làm việc, công tác và cả những nẻo đường đi phượt, du lịch cùng bạn bè,...\r\n\r\nCà phê pha phin\r\n\r\nNếu bạn là người dành tình yêu cuồng nhiệt với cà phê pha phin, khi có thời gian nhiều hơn một chút bạn có thể tạt ngang hoặc nhấc điện thoại đặt một ly cà phê sữa, cà phê đen của The Coffee House nhé. Với lợi thế cửa hàng phủ sóng rộng khắp cùng đội ngũ nhân viên pha chế, giao hàng chuyên nghiệp, The Coffee House sẽ nhanh chóng gửi đến bạn hương vị cà phê yêu thích mà không cần phải đợi chờ quá lâu.\r\n\r\nNhư vậy, bạn vừa có thể làm việc vừa thưởng thức hương vị cà phê chuẩn gu hoặc tự bù đắp sau khi công việc đã xong xuôi bằng ly cà phê The Coffee House được pha phin truyền thống với hương vị đậm đà, hài hòa giữa vị ngọt đầu lưỡi và vị đắng thanh thoát nơi hậu vị.\r\nBạn biết không, theo nhiều nghiên cứu đã chứng minh rằng uống cà phê mỗi ngày với một lượng vừa đủ sẽ rất tốt cho cơ thể vì nó giảm nguy cơ mắc những bệnh nguy hiểm như: cao huyết áp, tiểu đường tuýp 2, xơ gan, parkinson, hen suyễn, sỏi mật.... Vậy nên, nếu bạn là người rất đam mê với cà phê thì vẫn nên giữ thói quen đó mỗi ngày. Thế nhưng, nên dừng ở mức 3-4 ly, vì liều lượng caffeine khuyến nghị mỗi ngày để giữ mức an toàn là 400mg, tương đương khoảng 4 ly cà phê 240ml.\r\n\r\nDo đó, đối với những ngày bận rộn, bạn có thể lựa chọn những loại cà phê tiện lợi và chất lượng tuyệt vời được The Coffee House gợi ý trên để vừa thỏa mãn tình yêu với cà phê, vừa đảm bảo một ngày làm việc tập trung tinh thần, hăng say và hiệu quả. Đặc biệt, giúp cơ thể nhận được những lợi ích bất ngờ từ cà phê và tránh nguy cơ mắc các bệnh nguy hiểm. ");

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 5,
                column: "Content",
                value: "Nghe đến trà sữa chắc hẳn bạn sẽ nghĩ nó là món thức uống được giới trẻ yêu thích và chỉ mới nổi lên trong những năm gần đây. Tuy nhiên, The Coffee House chia sẻ với bạn rằng hoàn toàn không phải như vậy. Bởi vì trà sữa đã có mặt từ rất lâu đời, minh chứng rõ ràng nhất chính là Trà sữa Masala Chai Ấn Độ. Đây là loại thức uống được người dân Ấn từ người già đến trẻ nhỏ đều yêu thích, nó đã có mặt hàng nghìn năm nay và ngày càng trở nên nổi tiếng trên thế giới.\r\n\r\nBạn biết không, “Chai” trong tiếng Hindi của Ấn có nghĩa là “Trà”, và Masala Chai có nghĩa là “Trà hỗn hợp gia vị”. Nghe đến đây thôi cũng phần nào hình dung được sự đặc biệt của loại trà sữa này khi nó có sự kết hợp của nhiều gia vị khác nhau. Bạn có đang tò mò về những gia vị có trong Masala Chai?\r\n\r\nNguyên liệu chính của Masala Chai cũng giống như nhiều loại trà sữa khác đó chính là sữa tươi và trà đen. Tuy nhiên, sự độc đáo của Masala chai nằm ở chỗ kết hợp đặc biệt với những loại thảo dược có vị cay nồng nàn. Nhóm nguyên liệu chính tạo nên Trà sữa Masala Chai khác biệt với những loại trà sữa trên thị trường hiện nay đó chính là: tiêu đen, vỏ quế, đinh hương, thảo quả, bạch đậu khấu, bột gừng khô, bột nhục đậu khấu,... Đúng như tên gọi, đây quả thật là “trà hỗn hợp gia vị”.\r\nĐể làm nên món trà sữa Masala Chai đúng chuẩn thì người Ấn sẽ đun sữa tươi trên bếp cho thật nóng, song song đó giã nát các loại nguyên liệu ra thành bột mịn rồi cho vào đun cùng với sữa. Tiếp đến, cho trà đen cùng lượng đường vừa phải vào và đun cho tan. Sau khi trà sữa sôi đều sẽ tắt bếp, đổ trà sữa vào ray lọc để loại bỏ xác trà cũng như các cặn thảo dược. Cuối cùng sẽ tạo nên một thức uống hòa quyện giữa vị ngọt ngào là vị nồng ấm, và đối với Masala Chai dù uống nóng hay lạnh đều rất tuyệt vời với những cảm nhận khó quên.\r\n\r\nVới danh sách một loạt các thảo dược nổi bật như trên, Masala Chai không chỉ đơn giản là một thức uống giải khát, mà ở Ấn Độ đây được xem như một bài thuốc cổ truyền rất tốt cho sức khỏe. Thưởng thức một ly Trà sữa Masala Chai có thể giúp làm ấm cơ thể, lưu thông máu huyết, ngoài ra còn giúp tăng cường tiêu hoá, tăng cường trí nhớ, trị viêm khớp và các bệnh đau đầu kinh niên... Có lẽ vì chính những lý do đó mà Masala Chai tồn tại qua hàng ngàn năm, đến bây giờ càng được ưa chuộng và ngày càng được thế giới biết đến nhiều hơn.\r\n\r\nDù chưa xác định được thời gian ra đời của món thức uống truyền thống đặc biệt có nguồn gốc từ Ấn Độ này (có truyền thuyết ghi lại Masala Chai đã xuất hiện 9.000 năm trước, cũng có tài liệu cho rằng nó xuất hiện cách đây khoảng 5.000 năm), tuy nhiên với bề dày và ngày càng nổi tiếng như thế, có thể khẳng định Masala Chai là một phần linh hồn của ẩm thực Ấn, một phần văn hoá và không thể thiếu trong nhịp sống của những con người nơi đây. Hơn thế nữa, Masala Chai góp phần tạo nên sự đa dạng, ấn tượng và độc đáo cho nền ẩm thực của thế giới.\r\nBạn nghĩ sao nếu trong lúc tiết trời se lạnh, trong không khí rộn ràng của mùa Lễ hội cuối năm như thế này được cầm trên tay ly trà sữa Masala Chai cay nồng ấm áp, nhấp từng ngụm và chuyện trò với bạn bè về một năm đã qua? Masala Chai đã chính thức được The Coffee House ra mắt trong giai điệu háo hức của khúc nhạc Giáng sinh an lành, như là một “người bạn dễ thương” mà The Coffee House mang đến để góp mặt cùng bạn trong những câu chuyện hàn huyên, tăng thêm cảm xúc và hương vị giữa những không gian ngập tràn âm thanh và sắc màu để tạm biệt một năm đầy những “nốt lặng”, chào đón năm mới với những điều tươi đẹp hơn.\r\n\r\nBạn yêu quý, đừng quên rủ bạn bè đến thăm The Coffee House để thưởng thức hương vị ngọt ngào, thơm béo của sữa, cùng vị trà đen mạnh mẽ, vị nồng ấm của những thảo mộc có trong món Trà sữa Masala Chai vào những ngày đặc biệt của mùa Giáng sinh và năm mới này nhé!");

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 6,
                column: "Content",
                value: "Để có một cơ thể khỏe khoắn và một vóc dáng chuẩn chỉn thì việc ăn uống khoa học và điều độ đóng vai trò rất quan trọng. Trong đó, những sản phẩm từ tự nhiên thường xuyên được nhắc đến và ưu tiên sử dụng. The Coffee House khuyên các chị em nên dùng thường xuyên 05 loại trà thảo mộc quen thuộc dưới đây, vừa thơm ngon dễ uống mà lại chăm sóc cho sức khoẻ và dưỡng nhan cực kỳ hiệu quả.\r\n\r\nTrà hoa cúc\r\n\r\nHoa cúc là thảo dược có nhiều tác dụng tốt cho sức khỏe. Có vị ngọt, đắng nhẹ, tính mát, nó có tác dụng thanh nhiệt, giải độc, giải cảm, mát gan, làm sáng mắt. Ngoài ra, nếu bạn là người hay bị các chứng mất ngủ, tinh thần căng thẳng, dễ cáu gắt, khó tập trung thì uống trà hoa cúc sẽ giúp làm dịu thần kinh và giúp ngủ ngon hơn.\r\nĐây là loại trà phù hợp cho cả trẻ em và người trưởng thành. Theo các nghiên cứu hiện đại, nó còn có thể giúp kháng khuẩn, kháng siêu vi gây cảm cúm, làm giãn mạch máu, hạ huyết áp, giảm mỡ trong máu. Vậy nên, nếu chị em là những người bận rộn, thường xuyên phải ngồi trước máy tính, ít có thời gian vận động,... nên pha cho mình tách trà hoa cúc để thưởng thức, vừa uống vừa thư giãn nhé!\r\n\r\nTrà atiso\r\n\r\nAtiso có giá trị dinh dưỡng rất lớn. Chứa khoảng 17 chất khác nhau từ chất xơ, vitamin C, K, B6, Folate, sắt, kẽm,... đồng thời rất giàu chất chống oxy hóa nên sẽ giúp làm chậm quá trình lão hoá, điều mà chị em nào cũng ước ao.\r\nĐặc biệt, trà atiso có khả năng thải độc cho gan, bảo vệ gan khỏi tổn thương và thúc đẩy sự phát triển của tế bào mới. Trong một nghiên cứu lên các đối tượng gan nhiễm mỡ cho thấy việc hấp thụ atiso mỗi ngày trong vòng 2 tháng đã giúp giảm viêm và giảm lượng mỡ hiệu quả. Ngoài ra, dùng trà atiso liên tục trong 6 tuần sẽ làm giảm lượng cholesterol xấu trong cơ thể (khoảng 18.5 ~ 22.9%).\r\n\r\nTrà gừng\r\n\r\nVào những ngày đông lạnh, hay những lúc bị cảm và đau họng thì một tách trà gừng sẽ giúp làm ấm cơ thể, chữa cảm lạnh, ngăn ngừa virus hợp bào hô hấp gây bệnh. Ngoài ra, lợi thế lớn nhất của trà gừng là tốt cho dạ dày, điều trị các bệnh về đường tiêu hoá, thậm chí cả ung thư ruột kết.\r\nMột tác dụng bất ngờ của trà gừng nói riêng và các món có chứa gừng đó là chống lại hiệu ứng phá hủy tế bào bởi các gốc tự do, thủ phạm gây nhiều bệnh nan y trong đó có cả bệnh ung thư, tim mạch và đột quỵ. Trong gừng có chứa nhiều hợp chất pararadol và gingerol, có tác dụng tiêu diệt tế bào ung thư, hạn chế khối u di căn sang các tế bào, mô và các bộ phận khỏe mạnh khác.\r\n\r\nTrà bạc hà\r\n\r\nTrà bạc hà được nhiều người yêu thích bởi vị the mát của nó, kết hợp với vị trái cây thơm ngọt sẽ tạo nên một thức sảng khoái và đầy năng lượng. Hơn thế, trà bạc hà từ lâu được biết đến là loại thức uống thảo dược nóng, tốt cho sức khỏe, nó sẽ giúp bạn cảm thấy thư giãn, cũng như chống lại chứng mất ngủ.\r\nNgoài ra, trà bạc hà sẽ có nhiều tác dụng khác như cải thiện dòng chảy của mật, cho phép cơ thể tiêu hóa chất béo. Khi sử dụng trà bạc hà còn giúp bạn chữa chứng khó tiêu, các loại rối loạn tiêu hóa khác như buồn nôn, đau bụng, và tiêu chảy.\r\n\r\nTrà xanh\r\n\r\nTrà xanh khá quen thuộc và đặc biệt đây là loại trà thảo mộc có rất nhiều công dụng hữu ích đối với các chị em. Trong trà xanh chứa chất chống oxy hóa có hiệu lực mạnh hơn nhiều so với vitamin C và vitamin E, nhờ đó giúp bảo vệ các tế bào không bị phá hủy bởi bệnh ung thư, giảm lượng cholesterol, ngăn ngừa bệnh tim mạch và nguy cơ đột quỵ.\r\nĐặc biệt, uống trà xanh thường xuyên sẽ giúp phái đẹp làm chậm quá trình lão hóa, mờ các nếp nhăn trên khuôn mặt vì trong trà xanh có chứa polyphenols, một chất chống oxy hóa chống lại các gốc tự do. Ngoài ra, đây là một thức uống tự nhiên có tác dụng hữu hiệu trong việc giảm cân, giúp đốt cháy mỡ thừa và tăng cường khả năng trao đổi chất một cách tự nhiên. Bên cạnh đó, trà xanh sẽ giúp hệ xương khỏe mạnh nhờ chứa florua cao, giảm nguy cơ viêm khớp dạng thấp.\r\n\r\nNếu băn khoăn trong việc lựa chọn sản phẩm trà xanh chất lượng, chị em có thể tham khảo dòng sản phẩm trà xanh Tearoma của The Coffee House. Hương vị trà thanh mát, tinh tế và dễ chịu, có thể lựa chọn mùi vị của đào, sen, nhài nếu chị em yêu thích. Đồng thời, các sản phẩm chế biến từ trà của The Coffee House như trà đào cam sả, trà hạt sen, trà phúc bồn tử, trà macchiato... vừa thơm ngon, lại mang đến các hiệu quả làm đẹp và tốt cho sức khỏe như đã nói trên.\r\nVới những lợi ích của các loại trà thảo mộc đã được The Coffee House chia sẻ, bạn hãy thường xuyên sử dụng nó để đem lại những thay đổi tuyệt vời cho sức khỏe và sắc đẹp của mình nhé. Thế nhưng, cũng đừng quên việc tập luyện thể thao và thiết lập lối sống khoa học. The Coffee House chúc các chị em luôn khoẻ đẹp và rạng ngời!");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 18, 10, 21, 49, 793, DateTimeKind.Local).AddTicks(3858));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 18, 10, 21, 49, 793, DateTimeKind.Local).AddTicks(3866));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 18, 10, 21, 49, 793, DateTimeKind.Local).AddTicks(3867));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 18, 10, 21, 49, 793, DateTimeKind.Local).AddTicks(3868));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 18, 10, 21, 49, 793, DateTimeKind.Local).AddTicks(3869));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 18, 10, 21, 49, 793, DateTimeKind.Local).AddTicks(3870));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 18, 10, 21, 49, 793, DateTimeKind.Local).AddTicks(3871));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 18, 10, 21, 49, 793, DateTimeKind.Local).AddTicks(3872));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 18, 10, 21, 49, 793, DateTimeKind.Local).AddTicks(3873));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2023, 6, 18, 10, 21, 49, 793, DateTimeKind.Local).AddTicks(3874), "Trà sữa Mắc ca Trân châu trắng – Làn gió mới của các tín đồ trà sữa\r\nTrà sữa Mắc ca Trân châu trắng là sự kết hợp giữa nền trà Oolong hảo hạng thơm lừng, cùng sữa hạt Mắc Ca bổ dưỡng ngọt dịu ít béo, đặc biệt là topping trân châu trắng dai giòn hấp dẫn.\r\nĐây là một 'làn gió mới' mà The Coffee House mang đến cho bạn hương vị mới, trải nghiệm mới cho để bạn đổi vị tươi mới hơn và thú vị hơn.\r\nThe Coffee House tin rằng,\r\nmỗi ngày sẽ là điều tươi mới hơn với sữa hạt mắc ca thơm ngon,\r\nbổ dưỡng quyện cùng nền trà oolong cho vị cân bằng,\r\nngọt dịu đi kèm cùng Trân châu trắng giòn dai mang lại cảm giác “đã” trong từng ngụm Trà sữa Mắc ca Trân châu trắng.\r\nĐặt một ly và cho The Coffee House biết cảm nhận nhé!" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 18, 10, 21, 49, 793, DateTimeKind.Local).AddTicks(3875));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2023, 6, 18, 10, 21, 49, 793, DateTimeKind.Local).AddTicks(3876), "Cà Phê Đá Xay – Phiên bản Upgrade từ ly cà phê sữa quen thuộcNếu là một Fan cà phê chân chính, chắc hẳn bạn sẽ không bỏ qua phiên bản 'upgrade' từ ly cà phê sữa quen thuộc này của The Coffee House.\r\nThức uống tuy quen mà lạ\r\nNằm trong dòng thức uống đá xay quen thuộc của Nhà.Dòng thức uống kết hợp sữa tươi,\r\nđá viên với nhiều nguyên liệu khác.Đặc điểm “nhận dạng” dòng thức uống này chính là phần kem tươi xốp mịn bên trên.Cà phê đá xay là món gắn liền với sự xuất hiện của dòng thức uống này ngay từ những ngày đầu xuất hiện tại The Coffee House.Cà phê đá xay với hương vị cà phê sữa quen thuộc,\r\nđi kèm lớp kem và đá xay mang đến cảm giác mát lạnh,\r\nthơm béo thêm phần quyến rũ.\r\nMột ly cà phê đá xay đạt chuẩn Nhà:\r\nĐậm đà hương vị,không bị nhạt do đá quá tan.\r\nKhi uống cảm nhận được hương thơm của cà phê, thơm béo của sữa.\r\nĐá viên được xay nhuyễn mịn, không bị lẫn các viên đá còn to.\r\nLớp kem tươi xốp, béo và được xịt vừa đủ lên trên ly.\r\nNhững lợi ích khi gọi một ly cà phê đá xay\r\nBên cạnh hương vị thơm ngon khó cưỡng, một ly cà phê đá xay còn là một món quà ngọt ngào cho tâm hồn, bất cứ khi nào bạn cần “kéo mood”. Một ngụm đá xay mát lạnh giúp bạn hoàn toàn tỉnh táo. Lượng cafein trong một ly đá xay không quá nhiều, đặc biệt phù hợp với các bạn yêu thích hương vị cà phê nhưng lại dễ say.\r\nCần tỉnh táo, một ly cà phê đá xay nhé!" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2023, 6, 18, 10, 21, 49, 793, DateTimeKind.Local).AddTicks(3877), "Cookie Đá Xay – Món uống phá cách dễ thươngCookie đá xay - món uống phá cách dễ thương đầy mê hoặc từ The Coffee House có gì đặc biệt?\r\nThức uống “Top trending” của dòng đá xay\r\nNằm trong dòng thức uống đá xay (Ice Blended) quen thuộc của Nhà. Dòng thức uống kết hợp sữa tươi, đá viên với nhiều nguyên liệu khác. Đặc điểm “nhận dạng” dòng thức uống này chính là phần kem tươi xốp mịn bên trên. Cookie đá xay với những mẩu bánh cookies giòn rụm kết hợp ăn ý với sữa tươi, kem tươi béo ngọt và đá xay mát lành, đem đến cảm giác lạ miệng gây thích thú và không thể cưỡng lại. Một món uống phá cách dễ thương đầy mê hoặc.\r\nMột ly cookie đá xay đạt chuẩn Nhà:\r\nĐậm đà hương vị, không bị nhạt do đá quá tan.\r\nKhi uống cảm nhận được hương thơm, độ giòn của cookie, thơm béo của sữa.\r\nĐá viên được xay nhuyễn mịn, không bị lẫn các viên đá còn to.\r\nLớp kem tươi xốp, béo và được xịt vừa đủ lên trên ly.\r\nTừng ngụm thú vị\r\nKhông giống các thức uống còn lại, cookie đá xay không chỉ ngon mà còn vui miệng, với từng mẩu cookie giòn thơm kết hợp với đá xay. Với hương vị ngọt nhưng không ngấy, thơm béo vừa phải đây là thức uống thích hợp mỗi khi bạn cần giải nhiệt, cần sự tỉnh táo hay đơn giản một loại thức uống thú vị cho những ngày bỗng nhiên buồn chán.\r\nOrder ngay một ly cookie đá xay mát lạnh nhé!" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2023, 6, 18, 10, 21, 49, 793, DateTimeKind.Local).AddTicks(3878), "Sinh tố Việt quất – Uống ngon, uống “đẹp”\r\nSự phối hợp hợp tinh tế của Barista Nhà\r\nSinh tố là tên gọi chung của những món trai cây xay. Ở Đây chúng ta có sinh tố việt quất với thành phần chính là mứt việt quất, sữa chua và Foam cheese. Mứt Việt Quất chua thanh, ngòn ngọt, phối hợp nhịp nhàng với dòng sữa chua bổ dưỡng, thêm vào đó là vị béo của Foam cheese được Barista Nhà phối hợp tinh tế. Tất cả tạo món sinh tố thơm ngon mà cả đầu lưỡi và làn da đều thích.\r\nThức uống yêu thích của làn da\r\nVới thành phần chính là mứt việt quất - loại trái cây được nhiều yêu thích vì công dụng cho sức khoẻ và đặc biệt làn da. Sinh tố việt quất có nhiều lợi ích có thể kể đến như:\r\nTốt cho làn da: Vitamin C trong việt quất được xem như là một dưỡng chất cần thiết giúp da tránh khỏi sự lão hóa da dưới tác động của ánh nắng mặt trời, ô nhiễm và khói bụi.\r\nNhững lợi ích đáng kể đối với sức khoẻ: Ngoài vitamin C, trong việt quất còn chứa các loại khoáng chất khác có ích như Vitamin K, Canxi, magie, kali… giúp xương chắc khoẻ, giảm nguy cơ mắc bệnh tiểu đường, tăng cường hệ tiêu hoá và giúp bạn kiểm soát cân nặng nhờ vào chất xơ có trong thành phần.\r\nTại the Coffee House, mỗi thức uống ra đời không chỉ đảm bảo tiêu chí ngon miệng mà còn quan tâm đến công dụng đối với sức khoẻ. Gọi ngay một ly sinh tố việt quất làm quà cho làn da bạn nhé!" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2023, 6, 18, 10, 21, 49, 793, DateTimeKind.Local).AddTicks(3879), "SÔ CÔ LA ĐÁ XAY – Thức uống cho tín đồ hảo ngọt​\r\nHương vị chocolate quyến rũ\r\nSữa và kem tươi béo ngọt được “cá tính hoá” bởi vị chocolate đăng đắng. Có thể nói đây là thức uống được sinh ra dành cho các tín đồ hảo ngọt. Giống như các thức uống khác của dòng đá xay như Cà phê đá xay, Matcha đá xay,…một ly Chocolate đá xay đạt chuẩn Barista Nhà phải:\r\nĐậm đà hương vị, không bị nhạt do đá quá tan.\r\nKhi uống cảm nhận được hương thơm, vị đăng đắng đặc trưng của chocolate, thơm béo của sữa.\r\nĐá viên được xay nhuyễn mịn, không bị lẫn các viên đá còn to.\r\nLớp kem tươi xốp, béo và được xịt vừa đủ lên trên ly.​\r\nNguồn năng lượng cho tinh thần\r\nChocolate là một loại thực phẩm có nhiều công dụng hữu ích, làm hưng phấn tâm trạng do có caffeine, tyrosine và tryptophan. Trong các loại chocolate, chocolate đen được Barista Nhà dùng trong món chocolate đá xay có hàm lượng ca cao cao cùng với chất chống oxy hóa, ít chất béo nên có lợi cho sức khỏe hơn. Chỉ một lượng nhỏ chocolate cũng giúp bạn tràn đầy năng lượng? Không chỉ thế, chocolate còn được các chuyên gia sức khoẻ công nhận do có nhiều lợi ích có thể kể đến như:\r\nCải thiện sức khỏe tim mạch: Chocolate có thể giúp giảm huyết áo và chống viêm. Theo các nghiên cứu, chocolate có hàm lượng flavonoid cao. Flavonoid có thể kích thích cơ thể tạo ra nhiều oxit nitric hơn, giúp mở rộng và “thư giãn” mạch máu, do đó làm giảm huyết áp.\r\nGiống như trà xanh, chocolate cũng có epicatechin, giúp não chống lại quá trình hình thành các protein kết dích hay các mảng amyloid. Đây là những yếu tố nguy cơ gây ra bệnh Alzheimer.\r\nCó hiểu lầm cho rằng dùng chocolate sẽ gây tăng cân hay các tình trạng sức khỏe khác. Tuy nhiên, theo các nghiên cứu, chỉ cần bạn dùng một lượng nhỏ sẽ không có tác hại xấu đến cơ thể.\r\nCòn có lựa chọn nào tốt hơn cho tinh thần hơn là một ly chocolate đá xay. Order ngay!" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 18, 10, 21, 49, 793, DateTimeKind.Local).AddTicks(3880));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 18, 10, 21, 49, 793, DateTimeKind.Local).AddTicks(3881));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 18, 10, 21, 49, 793, DateTimeKind.Local).AddTicks(3883));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 18, 10, 21, 49, 793, DateTimeKind.Local).AddTicks(3884));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 18, 10, 21, 49, 793, DateTimeKind.Local).AddTicks(3885));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 18, 10, 21, 49, 793, DateTimeKind.Local).AddTicks(3886));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 18, 10, 21, 49, 793, DateTimeKind.Local).AddTicks(3887));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 18, 10, 21, 49, 793, DateTimeKind.Local).AddTicks(3888));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 18, 10, 21, 49, 793, DateTimeKind.Local).AddTicks(3889));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 18, 10, 21, 49, 793, DateTimeKind.Local).AddTicks(3890));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 18, 10, 21, 49, 793, DateTimeKind.Local).AddTicks(3891));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 18, 10, 21, 49, 793, DateTimeKind.Local).AddTicks(3892));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 18, 10, 21, 49, 793, DateTimeKind.Local).AddTicks(3893));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 18, 10, 21, 49, 793, DateTimeKind.Local).AddTicks(3894));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 18, 10, 21, 49, 793, DateTimeKind.Local).AddTicks(3895));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 18, 10, 21, 49, 793, DateTimeKind.Local).AddTicks(3896));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2023, 6, 18, 10, 21, 49, 793, DateTimeKind.Local).AddTicks(3897), "Trà đào cam sả - Thức uống nhất định phải thử 1 lần khi đến The Coffee House\r\nCó thể bạn chưa biết, Trà Đào Cam Sả chính là một trong những món đồ uống được rất nhiều thực khách gọi mỗi khi ghé thăm The Coffee House.\r\nHương vị tuy quen mà lạ, tuy lạ mà quen\r\nKhi sáng chế ra thức uống này, Barista tại Nhà đã để lại dấu ấn riêng rất Việt trong món trà đào vốn đã quen thuộc đối với mọi người bằng một nguyên liệu rất đỗi dân dã - Sả, một loại cây vốn được trồng và sử dụng rộng rãi như là một gia vị thường thấy trong bữa ăn hằng ngày tại các nước châu Á. Sả có hương thơm của chanh, tính ấm, kết hợp với tính hàn của Cam vàng Mỹ, tạo nên sự kết hợp cân bằng, vừa mang dấu ấn riêng của Việt Nam, vừa có sự pha trộn phương Tây trong ly Trà đào Cam Sả The Coffee House. Vị thanh ngọt của đào Hy Lạp, vị chua dịu của Cam Vàng nguyên vỏ, vị chát của trà đen tươi được ủ mới mỗi 4 tiếng, cùng hương thơm nồng đặc trưng của sả chính là điểm sáng làm nên sức hấp dẫn của thức uống này.\r\nBổ sung thêm C, Tăng cường sức đề kháng\r\nKhông chỉ hương vị thơm ngon, Trà đào cam sả còn có các tác dụng tuyệt vời cho cơ thể. Có thể kể đến như:\r\nChống oxy hóa: Trong trà đào có chất chống oxy hóa mạnh mẽ và các hợp chất có thể ngăn ngừa quá trình lão hóa của da.\r\nTăng cường hệ miễn dịch: Chất chống oxy hóa có trong sả và cam còn góp phần nâng cao hệ thống miễn dịch, làm giảm căng thẳng và mệt mỏi. Một ly trà đào mỗi ngày sẽ bổ sung lượng lớn vitamin C giúp cơ thể\r\nGiảm cân: Tin vui cho bạn là trà đào có thể hỗ trợ đốt cháy chất béo góp phần và quá trình giảm cân hiệu quả. Vừa là thức uống ngon miệng, thời thượng lại vừa có thể giảm béo thì quả là tuyệt vời .\r\nĐể hiểu vì sao mỗi ngày có đến hơn 20,000 ly Trà Đào Cam Sả được The Coffee House trao đến tay khách hàng, order một ly Trà đào cam sả 'trứ danh' để cảm nhận, bạn nhé!" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2023, 6, 18, 10, 21, 49, 793, DateTimeKind.Local).AddTicks(3898), "Trà hạt sen – Sự tinh tế của những điều đơn giản\r\nNền trà oolong hảo hạng kết hợp cùng hạt sen tươi, bùi bùi và lớp foam cheese béo ngậy. Thức uống gây thương nhớ tại The Coffee House có gì đặc biệt?\r\nSự kết hợp tinh tế của những nguyên liệu giản đơn\r\nSự kết hợp của Trà Oolong thanh mát với hương thơm nhẹ nhàng cùng vị nồng hậu của Hạt sen tươi mềm có vị ngọt, bùi. Đặc biệt, lớp kem sữa phô mai được phủ lên bề mặt ly sẽ cho bạn một trải nghiệm cân bằng hơn về hương vị.\r\nHình thức cực kỳ bắt mắt\r\nMột ly trà hạt sen chuẩn Nhà, bạn có thể nhìn thấy rõ ràng 3 lớp riêng biệt. Lớp đầu tiên là lớp “milk foam”béo ngậy, lớp ở giữa là trà oolong màu vàng sáng và lắng đọng ở lớp đáy là những “hạt ngọc” sen vàng.\r\nTrà hạt sen bồi bổ sức khoẻ:\r\nTrà Oolong – thảo dược quý giúp bạn bồi bổ sức khoẻ: Trong trà ô long có chứa rất nhiều vitamin, khoáng chất và những chất chống oxy hóa rất tốt.\r\n Hạt sen  cung cấp một lượng lớn gluxit, lipit, canxi, chất xơ và các vitamin mang đến nhiều lợi ích ch người dùng từ tác dụng chống viêm, giúp an thần, đến công dụng đẹp da, chống lão hoá, điều hoà cholesterol và đường huyết.\r\nMột loại thức uống phù hợp cho cả buổi sớm ban mai hay chiều tối với nhiều công dụng tuyệt vời chơ sức khoẻ, bạn đã thử chưa?" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2023, 6, 18, 10, 21, 49, 793, DateTimeKind.Local).AddTicks(3899), "Trà hạt sen – Sự tinh tế của những điều đơn giản\r\nNền trà oolong hảo hạng kết hợp cùng hạt sen tươi, bùi bùi và lớp foam cheese béo ngậy. Thức uống gây thương nhớ tại The Coffee House có gì đặc biệt?\r\nSự kết hợp tinh tế của những nguyên liệu giản đơn\r\nSự kết hợp của Trà Oolong thanh mát với hương thơm nhẹ nhàng cùng vị nồng hậu của Hạt sen tươi mềm có vị ngọt, bùi. Đặc biệt, lớp kem sữa phô mai được phủ lên bề mặt ly sẽ cho bạn một trải nghiệm cân bằng hơn về hương vị.\r\nHình thức cực kỳ bắt mắt\r\nMột ly trà hạt sen chuẩn Nhà, bạn có thể nhìn thấy rõ ràng 3 lớp riêng biệt. Lớp đầu tiên là lớp “milk foam”béo ngậy, lớp ở giữa là trà oolong màu vàng sáng và lắng đọng ở lớp đáy là những “hạt ngọc” sen vàng.\r\nTrà hạt sen bồi bổ sức khoẻ:\r\nTrà Oolong – thảo dược quý giúp bạn bồi bổ sức khoẻ: Trong trà ô long có chứa rất nhiều vitamin, khoáng chất và những chất chống oxy hóa rất tốt.\r\n Hạt sen  cung cấp một lượng lớn gluxit, lipit, canxi, chất xơ và các vitamin mang đến nhiều lợi ích ch người dùng từ tác dụng chống viêm, giúp an thần, đến công dụng đẹp da, chống lão hoá, điều hoà cholesterol và đường huyết.\r\nMột loại thức uống phù hợp cho cả buổi sớm ban mai hay chiều tối với nhiều công dụng tuyệt vời chơ sức khoẻ, bạn đã thử chưa?" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 18, 10, 21, 49, 793, DateTimeKind.Local).AddTicks(3900));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 18, 10, 21, 49, 793, DateTimeKind.Local).AddTicks(3901));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 18, 10, 21, 49, 793, DateTimeKind.Local).AddTicks(3902));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2023, 6, 18, 10, 21, 49, 793, DateTimeKind.Local).AddTicks(3903), "Trà sữa Mắc ca Trân châu trắng – Làn gió mới của các tín đồ trà sữa\r\nTrà sữa Mắc ca Trân châu trắng là sự kết hợp giữa nền trà Oolong hảo hạng thơm lừng, cùng sữa hạt Mắc Ca bổ dưỡng ngọt dịu ít béo, đặc biệt là topping trân châu trắng dai giòn hấp dẫn.\r\nĐây là một 'làn gió mới' mà The Coffee House mang đến cho bạn hương vị mới, trải nghiệm mới cho để bạn đổi vị tươi mới hơn và thú vị hơn.\r\nThe Coffee House tin rằng,\r\nmỗi ngày sẽ là điều tươi mới hơn với sữa hạt mắc ca thơm ngon,\r\nbổ dưỡng quyện cùng nền trà oolong cho vị cân bằng,\r\nngọt dịu đi kèm cùng Trân châu trắng giòn dai mang lại cảm giác “đã” trong từng ngụm Trà sữa Mắc ca Trân châu trắng.\r\nĐặt một ly và cho The Coffee House biết cảm nhận nhé!" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2023, 6, 18, 10, 21, 49, 793, DateTimeKind.Local).AddTicks(3904), "Đào Việt Quất Đá Xay –  Sự Pha Trộn Hoàn Hảo Giữa Đào & Việt Quất\r\nMột trong những món đá xay phá cách được yêu thích nhất tại The Coffee House\r\nSự pha trộn tinh tế\r\nLà phiên bản “upgrade” từ ly trà đào quen thuộc của nhà, tuy là “em út” trong giá đình đá xay nhưng món đào việt quất đá xay lại nhanh chóng quen mặt, sau thời gian thử thách đã chính thức từ thức uống theo mùa trở thành món uống trên menu chính thức của Nhà. Được khoác lên mình ngoại hình xịn sò, mang đến sự phấn khích và tươi mát ngay từ cái nhìn đầu tiên, ở giữa là vịđào huyền thoại ngọt thanh, lớp việt quất chua ngọt vui miệng ở tầng cuối, đặc biệt kéo theo lớp kem bồng bềnh béo ngậy trên cùng nữa mang đến hương vị kích thích vị giác đầy lôi cuốn và khoan khoái ngay từ ngụm đầu tiên.\r\nNgon miệng, ngon mắt lại còn chứa nhiều vitamin\r\nQuả đào chứa nguồn vitamin dồi dào, đặc biệt là những loại vitamin thiết yếu. Các loại vitamin và khoáng chất có thể kể đến như: Vitamin K, canxi, phốt pho, đồng, kẽm. Các vitamin & khoáng chất này có nhiều công dụng tốt cho sức khỏe, đặc biệt là khả năng cải thiện thị lực, các vấn đề về xương và thần kinh.\r\nMứt việt quất chứa vitamin C, Vitamin K, Canxi, magie, kali… giúp xương chắc khoẻ, giảm nguy cơ mắc bệnh tiểu đường, tăng cường hệ tiêu hoá và giúp bạn kiểm soát cân nặng nhờ vào chất xơ có trong thành phần.\r\nĐặc biệt cả 2 loại quả đều có công dụng giúp da tránh khỏi sự lão hoá.\r\nNắng nóng, sức lực làm việc bỗng nhiên bị “bốc hơi”, tự nhiên thèm một thứ gì đó hạ hỏa và lên tinh thần ngay lúc này, order một ly đào việt quất đá xay và thưởng thức nhé!" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2023, 6, 18, 10, 21, 49, 793, DateTimeKind.Local).AddTicks(3905), "CHANH SẢ ĐÁ XAY – Thức uống thanh mát, giải nhiệt\r\nSự kết hợp của các nguyên liệu mộc mạc\r\nNước cốt sả (sả ngâm) xay cùng với chanh tươi, thêm vào chút đường tạo nên thức ống với hương vị thanh chua, ngọt ngọt, thơm nhẹ thoảng nhẹ mùi sả. Tuy thành phần đơn giản nhưng để có một ly chanh sả đá xay đúng điệu cùng cần tay nghề khéo léo của Barista Nhà từ sự kết hợp giữa các thành phần đến độ nhuyễn mịn của đá xay.\r\nThức uống giải nhiệt cơ thể\r\nTuy là những nguyên liệu đơn giản nhưng sả và chanh lại có những công dụng cực kỳ tốt đối với sức khoẻ:\r\nSả rất tốt cho hệ tiêu hoá, hỗ trợ tốt cho hệ thần kinh, có tính kháng viêm và đăc biệt tốt cho cho người muốn giảm cân do sả có tác dụng đốt cháy mỡ thừa, làm thúc đẩy quá trình trao đổi giúp máu lưu thông tốt hơn.\r\nTrong khi đó Chanh lại là loại quả cung cấp rất nhiều vitamin C, chất xơ và các hợp chất thực vật có lợi khác nhau. Những chất dinh dưỡng này đem lại một số lợi ích cho sức khỏe. Trên thực tế, chanh có thể hỗ trợ sức khỏe tim mạch, kiểm soát cân nặng và sức khỏe hệ tiêu hóa.\r\nGọi một ly chanh sả đá xay để giải nhiệt ngay thôi nào!" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 18, 10, 21, 49, 793, DateTimeKind.Local).AddTicks(3906));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 18, 10, 21, 49, 793, DateTimeKind.Local).AddTicks(3907));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 18, 10, 21, 49, 793, DateTimeKind.Local).AddTicks(3908));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 18, 10, 21, 49, 793, DateTimeKind.Local).AddTicks(3909));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 18, 10, 21, 49, 793, DateTimeKind.Local).AddTicks(3910));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 18, 10, 21, 49, 793, DateTimeKind.Local).AddTicks(3911));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 18, 10, 21, 49, 793, DateTimeKind.Local).AddTicks(3912));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 18, 10, 21, 49, 793, DateTimeKind.Local).AddTicks(3913));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 18, 10, 21, 49, 793, DateTimeKind.Local).AddTicks(3914));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedDate",
                value: new DateTime(2023, 6, 18, 10, 21, 49, 793, DateTimeKind.Local).AddTicks(3915));

            migrationBuilder.UpdateData(
                table: "Store",
                keyColumn: "Id",
                keyValue: 1,
                column: "District",
                value: "Quận 1");

            migrationBuilder.UpdateData(
                table: "Store",
                keyColumn: "Id",
                keyValue: 2,
                column: "District",
                value: "Quận 1");

            migrationBuilder.UpdateData(
                table: "Store",
                keyColumn: "Id",
                keyValue: 3,
                column: "District",
                value: "Quận Bình Thạnh");

            migrationBuilder.UpdateData(
                table: "Store",
                keyColumn: "Id",
                keyValue: 4,
                column: "District",
                value: "Quận Bình Thạnh");

            migrationBuilder.UpdateData(
                table: "Store",
                keyColumn: "Id",
                keyValue: 5,
                column: "District",
                value: "Quận Bình Thạnh");

            migrationBuilder.UpdateData(
                table: "Store",
                keyColumn: "Id",
                keyValue: 6,
                column: "District",
                value: "Quận Bình Thạnh");

            migrationBuilder.UpdateData(
                table: "Store",
                keyColumn: "Id",
                keyValue: 7,
                column: "District",
                value: "Quận 10");

            migrationBuilder.UpdateData(
                table: "Store",
                keyColumn: "Id",
                keyValue: 8,
                column: "District",
                value: "Quận 10");

            migrationBuilder.UpdateData(
                table: "Store",
                keyColumn: "Id",
                keyValue: 9,
                column: "District",
                value: "Quận 2");

            migrationBuilder.UpdateData(
                table: "Store",
                keyColumn: "Id",
                keyValue: 10,
                column: "District",
                value: "Quận 2");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Supplier",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LinkGG",
                table: "Store",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "District",
                table: "Store",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "ShoppingCart_Product",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 12, 28, 20, 40, 32, 287, DateTimeKind.Local).AddTicks(3842),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2023, 6, 18, 10, 21, 48, 450, DateTimeKind.Local).AddTicks(3925));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "ShoppingCart",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 12, 28, 20, 40, 32, 280, DateTimeKind.Local).AddTicks(5343),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2023, 6, 18, 10, 21, 48, 450, DateTimeKind.Local).AddTicks(2342));

            migrationBuilder.AlterColumn<string>(
                name: "Photo",
                table: "ProductType",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Photo",
                table: "Product",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ExpiredDate",
                table: "Discount",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AlterColumn<string>(
                name: "Role",
                table: "Customer",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Time",
                table: "Bill",
                type: "varchar(100)",
                maxLength: 100,
                nullable: true,
                defaultValue: "15-20 phút",
                oldClrType: typeof(string),
                oldType: "varchar(100)",
                oldMaxLength: 100,
                oldNullable: true,
                oldDefaultValue: "15 - 20 phút");

            migrationBuilder.AlterColumn<string>(
                name: "Phone",
                table: "Bill",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext");

            migrationBuilder.AlterColumn<string>(
                name: "PayBy",
                table: "Bill",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext");

            migrationBuilder.AlterColumn<string>(
                name: "Note",
                table: "Bill",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Bill",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Bill",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2021, 12, 28, 20, 40, 32, 265, DateTimeKind.Local).AddTicks(8239),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2023, 6, 18, 10, 21, 48, 449, DateTimeKind.Local).AddTicks(1780));

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Bill",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext");

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: 1,
                column: "Password",
                value: "$2a$11$xg6Znw0ZOeqk.J0zUvpxwOV/KAnumvXoG8vkZKXvwj1WEFNc9j1Ve");

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: 2,
                column: "Password",
                value: "$2a$11$fiEK4PkAzyTcCGHPKhRg7eWLhF8NPj1/cD0Y.cMN7bxua6/mWNaxa");

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: 3,
                column: "Password",
                value: "$2a$11$Bikb2UC.WVZlROKwma.r8ewxYAf2h2JIk6Q1QXhe9eZmde423lV7W");

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: 4,
                column: "Password",
                value: "$2a$11$UHZ/F13UrRYmTWosmj1uY.1PPunJi7NofCkYKzgGEtWNeqVPDj8W6");

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 1,
                column: "Password",
                value: "$2a$11$f1KOWdYjre5NQosO7/LvXuaNDdO3eBRcWBFk2N0Vr4ByimjWQVQmu");

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 2,
                column: "Password",
                value: "$2a$11$rsWmaeyH96/et8cJfOtYvOQA0ZRE7/Bao1gQlTfhHyFW63G.VFxPm");

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 3,
                column: "Password",
                value: "$2a$11$8znOX0NaqFMXlvj.CObj1.HAc3pnUHZmW5xS4AWH692r3fgxqd0fW");

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 4,
                column: "Password",
                value: "$2a$11$WJJS7jXjrPRSqqMXjR7K9ur3e4eg0nI4OaBQaZ.lckYg7/Xv3Eov2");

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1,
                column: "Content",
                value: "Truyền thuyết về quả cà phê\r\nCó rất nhiều truyền thuyết về nguồn gốc của cà phê.Tuy nhiên,câu chuyện người đàn ông chăn dê tên Kaldi phát hiện ra cây cà phê ở khu rừng cổ của cao nguyên Ethiopia là phổ biến và được nhiều người tin nhất.\r\nKaldi đã khám phá ra cà phê sau khi những con dê của anh ta ăn một loại quả màu đỏ từ cái cây có những bông hoa trắng và chúng trở nên hăng hái đến mức không đi ngủ vào ban đêm. Anh ta cũng đã ăn thử và nó giúp anh tỉnh táo trong suốt nhiều giờ cầu nguyện vào buổi tối. Sau đó, Kaldi đã báo cáo phát hiện của mình với giáo sĩ của tu viện địa phương. Vị giáo sĩ chia sẻ khám phá của Kaldi với nhiều người khác và kết quả là thông tin về một loại quả tràn đầy năng lượng nhanh chóng được lan truyền.\r\nLịch sử và hành trình du nhập của cà phê\r\nTuy nhiên, không chỉ có truyền thuyết, những ghi chép và dấu tích còn lại cũng khiến người ta tin rằng Kaffa - Ethiopia chính là vùng đất khởi nguyên của cây cà phê từ thế kỷ thứ 9. Và đến thế kỷ 14, những người buôn nô lệ đã mang cà phê từ Ethiopia sang xứ Ả Rập. Cà phê trở thành thức uống phổ biến của người Ả Rập với cách chế biến đầu tiên chỉ đơn giản là tách lấy hạt và cho vào nấu trong nước sôi. Ả Rập đã trở thành nơi trồng cà phê độc quyền với trung tâm giao dịch cà phê là thành phố cảng Mocha, hay còn được gọi là Mokka, tức là thành phố Al Mukha thuộc Yemen ngày nay. \r\nNgười Ả Rập rất tự hào và giữ bí mật để bảo tồn độc quyền loại thức uống được chế biến từ hạt cà phê. Họ đưa ra những quy định rất chặt chẽ để gìn giữ sự độc quyền về cà phê của mình như chỉ được phép mang hạt cà phê đã rang ra khỏi xứ, cũng như không cho người ngoại quốc bén mảng đến các đồn điền cà phê. Thế nhưng, dù nghiêm ngặt đến mức nào thì cũng có người vượt qua được, những khách hành hương được thưởng thức nước cà phê đã lén lút mang hạt giống về trồng, chẳng bao lâu khắp khu vực Trung Đông đều có trồng và truyền đi mỗi lúc một xa hơn. Bước sang thế kỷ 15 thì cà phê đến Armenia, Persia, Thổ Nhĩ Kỳ và phía bắc Châu Phi, phổ biến trong thế giới Hồi giáo và lan tỏa đến Ý, sau đó là phần còn lại của Châu Âu, Indonesia, Mĩ. \r\nBắt nguồn tên gọi “Cà phê”\r\nNhiều nhà nghiên cứu cho rằng, chữ “Cà phê” có thể bắt nguồn từ chữ “Qahwa” (theo tiếng Ả Rập thì “Qahwa” có nghĩa là thức uống được tạo ra từ nước của hạt quả). Qua đến người Thổ Nhĩ Kỳ được đọc là “Kahve” và nó đã được sử dụng rộng rãi khắp nơi. Một số người khác thì lại cho rằng, chữ “Cà phê” được đặt theo tên của thị trấn “Kaffa” của Ethiopia. Tuy nhiên, một số khác lại nói thị trấn “Kaffa” được đặt theo tên “Cà phê”. Và từ “cà phê” mà Việt Nam ta vẫn hay dùng có gốc từ chữ Café trong tiếng Pháp, một loại thức uống màu đen có chứa chất caffeine.\r\nNhư vậy, có thể thấy cà phê đã xuất hiện từ rất lâu đời và có những thông tin còn hoài nghi chưa được xác thực. Thế nhưng, không còn quá quan trọng vì nó đã lan khắp thế giới và ngày càng hiện diện, hoà nhịp trong cuộc sống của tất cả chúng ta. Mỗi ngày, thế giới ước tính có 2,25 tỷ tách cà phê được bán ra và đối với nhiều người, cà phê đã trở thành một phần không thể thiếu. \r\nĐặc biệt, không thể phủ nhận những giá trị vô hình mà cà phê đang mang lại. Ngoài là một thức uống thú vị và yêu thích của rất nhiều người, nó là một sự khởi đầu của ngày mới, khởi đầu của những câu chuyện, sự gắn kết của những mối quan hệ, đưa chúng ta gần nhau hơn, sẻ chia và kết nối tình cảm. Và đó cũng chính là những giá trị mà The Coffee House luôn hướng đến và đem lại bên cạnh những tách cà phê tinh túy và chất lượng, những ly trà đượm hương cùng cảm hứng về lối sống hiện đại, năng động mà gần gũi. ");

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2,
                column: "Content",
                value: "Ở Mỹ, cà phê được xuất hiện từ những năm 1600 tại New Amsterdam - thành phố New York nổi tiếng ngày nay. Từ đó cà phê dần được sử dụng và gần gũi hơn. Tuy nhiên, phong cách cà phê hiện đại của Mỹ như hiện nay được cho rằng bắt nguồn từ Ý và phát triển mạnh mẽ trong khoảng 20 năm trở lại đây.\r\nDù chịu ảnh hưởng bởi văn hóa cà phê du nhập từ Ý với lối pha dùng máy Barista nhanh chóng phổ biến,\r\n                    tuy nhiên lại có sự khác biệt rõ rệt giữa hai nền văn hoá cà phê của Ý và Mỹ.Đến với Ý bạn sẽ thấy sự chờ đợi một cách chậm rãi,\r\n                    nhẹ nhàng và sành điệu.Còn với người Mỹ thì luôn trong tâm thái nhanh gọn,\r\n                    tranh thủ thời gian.Điều này hoàn toàn dễ hiểu khi Mỹ là một quốc gia làm việc với cường độ cao,\r\n                    con người rất quý trọng thời gian và yêu cầu sự gọn lẹ. \r\nLà quốc gia trẻ và đầy sức sống, con người ở Mỹ chuộng lối sống tự do, tất cả đều theo sở thích cá nhân và văn hóa cà phê cũng không ngoại lệ. Người Mỹ sử dụng cà phê hoàn toàn theo ý thích, không sành điệu như người châu Âu, cũng không cầu kì như người Ả Rập, mà đề cao tính thoải mái.\r\nCà phê Việt thì luôn đậm đà, còn cà phê của người Mỹ được cho là nhạt từ màu sắc đến cả hương vị. Cà phê Mỹ là chất nước loãng màu nâu nhạt, có vị hơi khét, vậy nên người ta thường bảo cho thêm hai, thậm chí ba gói đường và nửa ly sữa cũng không làm chất nước ấy ngọt và thơm hơn.\r\nNgười Mỹ uống cà phê mọi lúc mọi nơi và nhiều lần trong ngày. Cà phê đối với họ là thức uống giúp tập trung đầu óc, tỉnh táo, chống buồn ngủ. Món Americano, một thức uống được biến tấu nhẹ nhàng từ món Espresso của người Ý được xem là thức uống truyền thống của người Mỹ. Ngoài ra, ở đất nước này phổ biến với Iced Coffee – cà phê đặc, nóng, thêm đường được rót vào một ly đựng đá. \r\nVào quán cà phê, người Mỹ không chỉ đơn thuần là tán gẫu. Đôi lúc họ làm việc trong quán cà phê. Đây vừa là cách tận dụng thời gian, hoặc thay đổi không gian làm việc để đầu óc tự do hơn là ngồi trong văn phòng nhàm chán. Hơn thế nữa, người ta còn vào cà phê để bàn bạc công việc, thảo luận, trao đổi và dĩ nhiên là có cả hẹn hò! Và những điều này thì chúng ta cũng thấy thân thuộc đối với người Việt và phong cách đi cà phê hiện nay. \r\nCũng giống khi bước vào không gian của The Coffee House, bạn sẽ bắt gặp hình ảnh quen thuộc của những đôi bạn trẻ trò chuyện bên tách cà phê, ai đó làm việc hăng say hay chú tâm đọc sách bất kể những âm thanh rì rào bên cạnh, cũng như những cuộc gặp gỡ niềm nở giữa đối tác và khách hàng, hay những người bạn lâu ngày mới gặp lại nhưng rất đỗi thân tình... \r\nĐối với The Coffee House đó là một niềm thật hạnh phúc. Hạnh phúc khi luôn được đồng hành và gắn liền trong những câu chuyện, những lần gặp gỡ đong đầy tình cảm. Góp mặt trong hành trình sống của mỗi người và là nơi lưu giữ những kỷ niệm. The Coffee House tự hào mang đến những trải nghiệm khác biệt, thoải mái, những hương vị tinh tế và quyến rũ cho khách hàng thân yêu, đặc biệt biệt là góp phần kiến tạo nên phong cách và văn hóa thưởng thức cà phê của người Việt.");

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 3,
                column: "Content",
                value: "Uống cà phê là một thú vui và đến với mỗi quốc gia, bạn sẽ thấy rằng thú vui này sẽ mang những nét khác biệt. The Coffee House chia sẻ đến bạn những phong cách uống cà phê nổi tiếng của các nước trên thế giới, cùng xem để hiểu hơn về văn hoá độc đáo này, hay kể cả tự pha chế để thưởng thức xem cảm nhận mới lạ như thế nào nhé!\r\nItaly\r\nLà “thủ phủ” cà phê nổi tiếng trên thế giới, thức uống này là món không thể thiếu đối với người dân Italy.Họ thường bắt đầu ngày mới với một ly cà phê và loại thường được dùng nhiều nhất chính là Espresso. \r\nĐây là loại cà phê có thể phục vụ nhanh, có cho bạn ngay lập tức và thường được đựng trong những chiếc ly nhỏ. Người Italy khi thưởng thức sẽ cầm ly trong tay, hít hà mùi thơm quyến rũ rồi uống trong 3-4 hơi. Cả quá trình diễn ra nhanh gọn nhưng đầy thanh lịch theo đúng phong cách người Italy.\r\n\r\nPháp\r\nỞ Pháp thường dùng Café Au Lait, nghe thôi đã rất Pháp rồi đúng không? Đây là loại cà phê được pha chế hết sức đơn giản. \r\nLà sự pha trộn giữa cà phê espresso và sữa tươi nóng. Café Au Lait là thức uống yêu thích của người Pháp vào buổi sáng và thường được dùng cùng bánh mì Baguette. Café Au Lait và Baguette, sự kết hợp biểu tượng của ẩm thực Pháp.\r\n\r\nĐức\r\nEiskaffee là món cà phê quen thuộc của người Đức. Nó đích thị dành cho những ai thích sự ngọt ngào. Eiskaffee trong tiếng Đức có nghĩa là “cà phê kem lạnh”. Vị beo béo của kem lạnh lơ lửng trong lớp cà phê đắng kết hợp cùng tầng kem whipping ngọt ngào và một ít vụn choco đã tạo nên thứ đồ uống hấp dẫn khó cưỡng. \r\nVậy nên Eiskaffee đã đã chinh phục khẩu vị không chỉ của người dân nước Đức, trở thành món đồ uống “quốc dân” của đất nước này mà còn thu hút cả những khách du lịch đến nơi đây.\r\n\r\nBồ Đào Nha\r\nNgười Bồ Đào Nha cực kì ưa chuộng và phổ biến với món cà phê pha chanh mát lạnh Mazagran. Để thưởng thức món cà phê này hết sức đơn giản, bạn chỉ cần đổ hai tách espresso và nước cốt chanh vào một ly cao, thêm đường cho vừa uống và một ít đá viên. \r\nVới sự kết hợp đặc biệt từ vị chua của chanh khiến món cà phê này có vị khác hẳn so với các loại cà phê khác trên thế giới. Đây cũng là một thức uống lý tưởng và sảng khoái cho những ngày hè.\r\n\r\nHy Lạp\r\nKhá giống như người Bồ Đào Nha, người Hy Lạp cũng có một thức uống cà phê được yêu chuộng vào những ngày hè nhằm xua đi cái nóng nực. Đó chính là Frappé. Trong tiếng Pháp nó có nghĩa “ướp lạnh”, là loại cà phê hòa tan đánh sủi bọt hết sức độc đáo và được biết đến như biểu tượng của đất nước Hy Lạp. \r\nĐể pha Frappé, đầu tiên cho cà phê bột vào ly, thêm một thìa cà phê đường và một ít nước đá. Dùng máy trộn tay (handmixer) khuấy mạnh cho đến khi cà phê sủi bọt. Cuối cùng cho đá và rót một thêm một ít nước lạnh là bạn đã hoàn thành. Frappe thường được pha chế khá đậm và sử dụng cà phê hoà tan mạnh, nếu dùng không quen, bạn có thể thêm nước để pha loãng cà phê hoặc thêm đường vào để thưởng thức ngọt hơn.\r\n\r\nCà phê sữa Việt Nam\r\nMỗi đất nước đều có loại cà phê yêu thích đặc trưng. Và đối với người Việt đó là món cà phê sữa. Bạn thường thưởng thức cà phê sữa như thế nào? Mỗi buổi sáng tự pha cho mình hay ra cửa hàng gọi một ly cà phê sữa theo ý thích. Không chỉ quen thuộc với người Việt, cà phê sữa là món đồ uống mà khách du lịch các nước rất hứng thú thưởng thức khi đặt chân đến mảnh đất hình chữ S. Và nhiều thực khách nước ngoài khi vào cửa hàng của The Coffee House cũng thường xuyên lựa chọn cà phê sữa.\r\nKhông giống những nước khác thường sử dụng cà phê pha sẵn, cà phê bột,…Việt Nam sử dụng loại cà phê xay nhuyễn, cho vào loại phin đặc trưng của bản xứ, sau đó đổ nước sôi vào. Từng giọt cà phê đậm đặc, sóng sánh, chảy qua chiếc phin đặc biệt hòa cùng sữa đặc, cho thêm đá đã tạo nên ly cà phê sữa đá đậm đà, đắng đót nhưng cũng thanh ngọt nơi hậu vị.\r\nKhông chỉ mỗi quốc gia sẽ có một loại cà phê đặc trưng và cách thưởng thức riêng biệt, mà mỗi cá nhận lại còn có cả phong cách uống cà phê rất khác. Phong cách thưởng thức cà phê của bạn là gì? Cà phê đen hay cà phê sữa, nhiều đường hay ít sữa, nóng hay đá, pha phin hay dùng sẵn, lựa chọn Espresso hay Capuccino, bạn có muốn thưởng thức thêm vị Matcha hay Macchiato... Mỗi người mỗi sở thích, mỗi người mỗi phong cách và cá tính, nhưng The Coffee House lại luôn tự tin mang đến sự hài lòng cho khách hàng bởi những trải nghiệm độc đáo, sự đa dạng, phá cách và hơn hết là những hương vị tuyệt vời nhất.");

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 4,
                column: "Content",
                value: "GỢI Ý NHỮNG LOẠI CÀ PHÊ CHO NGÀY BẬN RỘN\r\nĐối với những người đã yêu thích cà phê rồi thì hôm nào cũng cần phải có ít nhất một ly.Và đặc biệt đối với những người đã là tín đồ của cà phê thì họ lại rất khó tính,\r\n                    yêu cầu cao về hương vị và sự nguyên chất,\r\n                    đậm đà của loại cà phê mà mình thưởng thức mỗi ngày.Bạn có đang nằm trong số đó,\r\n                    và nếu những ngày bận rộn,\r\n                    bạn không có thời gian để tự tay pha cho mình một ly cà phê hay ghé đến quán cà phê quen thuộc để thưởng thức thì như thế nào ?\r\n\r\nĐừng nói rằng bạn sẽ tạm hoãn cái ghiền cà phê của bản thân lại nhé.Vì đó thật sự là một điều rất khó chịu,\r\n                    đặc biệt nữa là khi bạn đã quá quen với việc bắt đầu buổi sáng với một ly cà phê để giúp tỉnh táo,\r\n                    tập trung và có cảm hứng hơn khi bắt đầu bước vào công việc.\r\n\r\nThe Coffee House gợi ý những loại cà phê đậm đà,\r\n                    thơm ngon và hương vị đúng nghĩa cà phê tinh túy.Hãy cùng lựa chọn cho những ngày bận rộn trong guồng quay của công việc và cuộc sống nhé.Với những dòng cà phê được giới thiệu dưới đây,\r\n                    The Coffee House tin chắc dù thời gian hạn hẹp đến đâu thì bạn cũng có thể ưu ái và phục vụ bản thân mình bằng một tách cà phê thơm ngon đúng “gu” nhất.\r\n\r\nCà phê sữa đá hoà tan\r\n\r\nVới cà phê sữa đá hoà tan thì thật dễ dàng để bạn bắt đầu ngày mới với ly cà phê sóng sánh,\r\n                    thơm lừng và lựa chọn uống nóng hay uống lạnh theo sở thích của bản thân.Chắc chắn ai cũng phải công nhận sự tiện lợi của cà phê sữa đá hoà tan vì không cần phải mất nhiều thời gian pha chế hay phải chuẩn bị những dụng cụ pha chế.Thay vào đó chỉ cần pha theo hướng dẫn trên bao bì là đã có ngay một ly cà phê thơm ngon,\r\n                    chuẩn vị.The Coffee House gợi ý 3 dòng sản phẩm để bạn lựa chọn: cà phê sữa đá hoà tan dạng túi,\r\n                    cà phê sữa đá hoà tan dạng hộp và cà phê hoà tan 3in1 đậm vị Việt. \r\nCà phê sữa đá hoà tan dạng túi và hộp: Đây là 02 phiên bản giống nhau về chất lượng cà phê, giữ được hương vị thơm ngon thuần tuý như cà phê pha phin với sữa đặc. Vị đắng thanh của cà phê hoà quyện với vị ngọt béo của sữa, giúp bạn luôn tỉnh táo và hứng khởi cho ngày làm việc thật hiệu quả. Thật sự là lựa chọn lý tưởng cho những ngày hối hả của nhịp sống hiện đại. \r\nCà phê hoà tan 3in1 đậm vị Việt: đây là dòng sản phẩm với vị đậm đà, đặc biệt phù hợp với những ai có gu cà phê mạnh. 3in1 đậm vị Việt giữ trọn vẹn hương vị đắng thơm tinh tế từ hạt cà phê, là sự lựa chọn đậm đà và mạnh mẽ hơn so với hai phiên bản cà phê sữa dạng hộp và túi được The Coffee House chia sẻ trên. \r\n\r\nCà phê sữa đá dạng lon\r\n\r\nCà phê sữa đá dạng lon của The Coffee House mang phong cách hiện đại, đồng hành cùng nhịp sống sôi nổi của người trẻ và tiện dụng trong cuộc sống tất bật . Sản phẩm được sản xuất từ những hạt cà phê Việt thượng hạng và công thức phối trộn độc đáo mang đến hương vị đậm đà, thơm béo. \r\nVới thiết kế lon cao trẻ trung, đơn giản và tiện lợi, dù ở đâu, bạn vẫn có thể tận hưởng vị cà phê sữa thơm ngon đến ngụm cuối cùng. Sản phù hợp cả khi bạn ở nhà, văn phòng, đặc biệt là những lúc di chuyển trên đường làm việc, công tác và cả những nẻo đường đi phượt, du lịch cùng bạn bè,...  \r\n\r\nCà phê pha phin \r\n\r\nNếu bạn là người dành tình yêu cuồng nhiệt với cà phê pha phin, khi có thời gian nhiều hơn một chút bạn có thể tạt ngang hoặc nhấc điện thoại đặt một ly cà phê sữa, cà phê đen của The Coffee House nhé. Với lợi thế cửa hàng phủ sóng rộng khắp cùng đội ngũ nhân viên pha chế, giao hàng chuyên nghiệp, The Coffee House sẽ nhanh chóng gửi đến bạn hương vị cà phê yêu thích mà không cần phải đợi chờ quá lâu. \r\n\r\nNhư vậy, bạn vừa có thể làm việc vừa thưởng thức hương vị cà phê chuẩn gu hoặc tự bù đắp sau khi công việc đã xong xuôi bằng ly cà phê The Coffee House được pha phin truyền thống với hương vị đậm đà, hài hòa giữa vị ngọt đầu lưỡi và vị đắng thanh thoát nơi hậu vị.\r\nBạn biết không, theo nhiều nghiên cứu đã chứng minh rằng uống cà phê mỗi ngày với một lượng vừa đủ sẽ rất tốt cho cơ thể vì nó giảm nguy cơ mắc những bệnh nguy hiểm như: cao huyết áp, tiểu đường tuýp 2, xơ gan, parkinson, hen suyễn, sỏi mật.... Vậy nên, nếu bạn là người rất đam mê với cà phê thì vẫn nên giữ thói quen đó mỗi ngày. Thế nhưng, nên dừng ở mức 3-4 ly, vì liều lượng caffeine khuyến nghị mỗi ngày để giữ mức an toàn là 400mg, tương đương khoảng 4 ly cà phê 240ml. \r\n\r\nDo đó, đối với những ngày bận rộn, bạn có thể lựa chọn những loại cà phê tiện lợi và chất lượng tuyệt vời được The Coffee House gợi ý trên để vừa thỏa mãn tình yêu với cà phê, vừa đảm bảo một ngày làm việc tập trung tinh thần, hăng say và hiệu quả. Đặc biệt, giúp cơ thể nhận được những lợi ích bất ngờ từ cà phê và tránh nguy cơ mắc các bệnh nguy hiểm. ");

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 5,
                column: "Content",
                value: "Nghe đến trà sữa chắc hẳn bạn sẽ nghĩ nó là món thức uống được giới trẻ yêu thích và chỉ mới nổi lên trong những năm gần đây. Tuy nhiên, The Coffee House chia sẻ với bạn rằng hoàn toàn không phải như vậy. Bởi vì trà sữa đã có mặt từ rất lâu đời, minh chứng rõ ràng nhất chính là Trà sữa Masala Chai Ấn Độ. Đây là loại thức uống được người dân Ấn từ người già đến trẻ nhỏ đều yêu thích, nó đã có mặt hàng nghìn năm nay và ngày càng trở nên nổi tiếng trên thế giới. \r\n\r\nBạn biết không, “Chai” trong tiếng Hindi của Ấn có nghĩa là “Trà”, và Masala Chai có nghĩa là “Trà hỗn hợp gia vị”. Nghe đến đây thôi cũng phần nào hình dung được sự đặc biệt của loại trà sữa này khi nó có sự kết hợp của nhiều gia vị khác nhau. Bạn có đang tò mò về những gia vị có trong Masala Chai?\r\n\r\nNguyên liệu chính của Masala Chai cũng giống như nhiều loại trà sữa khác đó chính là sữa tươi và trà đen. Tuy nhiên, sự độc đáo của Masala chai nằm ở chỗ kết hợp đặc biệt với những loại thảo dược có vị cay nồng nàn. Nhóm nguyên liệu chính tạo nên Trà sữa Masala Chai khác biệt với những loại trà sữa trên thị trường hiện nay đó chính là: tiêu đen, vỏ quế, đinh hương, thảo quả, bạch đậu khấu, bột gừng khô, bột nhục đậu khấu,... Đúng như tên gọi, đây quả thật là “trà hỗn hợp gia vị”. \r\nĐể làm nên món trà sữa Masala Chai đúng chuẩn thì người Ấn sẽ đun sữa tươi trên bếp cho thật nóng, song song đó giã nát các loại nguyên liệu ra thành bột mịn rồi cho vào đun cùng với sữa. Tiếp đến, cho trà đen cùng lượng đường vừa phải vào và đun cho tan. Sau khi trà sữa sôi đều sẽ tắt bếp, đổ trà sữa vào ray lọc để loại bỏ xác trà cũng như các cặn thảo dược. Cuối cùng sẽ tạo nên một thức uống hòa quyện giữa vị ngọt ngào là vị nồng ấm, và đối với Masala Chai dù uống nóng hay lạnh đều rất tuyệt vời với những cảm nhận khó quên.\r\n\r\nVới danh sách một loạt các thảo dược nổi bật như trên, Masala Chai không chỉ đơn giản là một thức uống giải khát, mà ở Ấn Độ đây được xem như một bài thuốc cổ truyền rất tốt cho sức khỏe. Thưởng thức một ly Trà sữa Masala Chai có thể giúp làm ấm cơ thể, lưu thông máu huyết, ngoài ra còn giúp tăng cường tiêu hoá, tăng cường trí nhớ, trị viêm khớp và các bệnh đau đầu kinh niên... Có lẽ vì chính những lý do đó mà Masala Chai tồn tại qua hàng ngàn năm, đến bây giờ càng được ưa chuộng và ngày càng được thế giới biết đến nhiều hơn. \r\n\r\nDù chưa xác định được thời gian ra đời của món thức uống truyền thống đặc biệt có nguồn gốc từ Ấn Độ này (có truyền thuyết ghi lại Masala Chai đã xuất hiện 9.000 năm trước, cũng có tài liệu cho rằng nó xuất hiện cách đây khoảng 5.000 năm), tuy nhiên với bề dày và ngày càng nổi tiếng như thế, có thể khẳng định Masala Chai là một phần linh hồn của ẩm thực Ấn, một phần văn hoá và không thể thiếu trong nhịp sống của những con người nơi đây. Hơn thế nữa, Masala Chai góp phần tạo nên sự đa dạng, ấn tượng và độc đáo cho nền ẩm thực của thế giới. \r\nBạn nghĩ sao nếu trong lúc tiết trời se lạnh, trong không khí rộn ràng của mùa Lễ hội cuối năm như thế này được cầm trên tay ly trà sữa Masala Chai cay nồng ấm áp, nhấp từng ngụm và chuyện trò với bạn bè về một năm đã qua? Masala Chai đã chính thức được The Coffee House ra mắt trong giai điệu háo hức của khúc nhạc Giáng sinh an lành, như là một “người bạn dễ thương” mà The Coffee House mang đến để góp mặt cùng bạn trong những câu chuyện hàn huyên, tăng thêm cảm xúc và hương vị giữa những không gian ngập tràn âm thanh và sắc màu để tạm biệt một năm đầy những “nốt lặng”, chào đón năm mới với những điều tươi đẹp hơn. \r\n\r\nBạn yêu quý, đừng quên rủ bạn bè đến thăm The Coffee House để thưởng thức hương vị ngọt ngào, thơm béo của sữa, cùng vị trà đen mạnh mẽ, vị nồng ấm của những thảo mộc có trong món Trà sữa Masala Chai vào những ngày đặc biệt của mùa Giáng sinh và năm mới này nhé!");

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 6,
                column: "Content",
                value: "Để có một cơ thể khỏe khoắn và một vóc dáng chuẩn chỉn thì việc ăn uống khoa học và điều độ đóng vai trò rất quan trọng. Trong đó, những sản phẩm từ tự nhiên thường xuyên được nhắc đến và ưu tiên sử dụng. The Coffee House khuyên các chị em nên dùng thường xuyên 05 loại trà thảo mộc quen thuộc dưới đây, vừa thơm ngon dễ uống mà lại chăm sóc cho sức khoẻ và dưỡng nhan cực kỳ hiệu quả. \r\n\r\nTrà hoa cúc \r\n\r\nHoa cúc là thảo dược có nhiều tác dụng tốt cho sức khỏe. Có vị ngọt, đắng nhẹ, tính mát, nó có tác dụng thanh nhiệt, giải độc, giải cảm, mát gan, làm sáng mắt. Ngoài ra, nếu bạn là người hay bị các chứng mất ngủ, tinh thần căng thẳng, dễ cáu gắt, khó tập trung thì uống trà hoa cúc sẽ giúp làm dịu thần kinh và giúp ngủ ngon hơn.\r\nĐây là loại trà phù hợp cho cả trẻ em và người trưởng thành. Theo các nghiên cứu hiện đại, nó còn có thể giúp kháng khuẩn, kháng siêu vi gây cảm cúm, làm giãn mạch máu, hạ huyết áp, giảm mỡ trong máu. Vậy nên, nếu chị em là những người bận rộn, thường xuyên phải ngồi trước máy tính, ít có thời gian vận động,... nên pha cho mình tách trà hoa cúc để thưởng thức, vừa uống vừa thư giãn nhé!\r\n\r\nTrà atiso\r\n\r\nAtiso có giá trị dinh dưỡng rất lớn. Chứa khoảng 17 chất khác nhau từ chất xơ, vitamin C, K, B6, Folate, sắt, kẽm,... đồng thời rất giàu chất chống oxy hóa nên sẽ giúp làm chậm quá trình lão hoá, điều mà chị em nào cũng ước ao.\r\nĐặc biệt, trà atiso có khả năng thải độc cho gan, bảo vệ gan khỏi tổn thương và thúc đẩy sự phát triển của tế bào mới. Trong một nghiên cứu lên các đối tượng gan nhiễm mỡ cho thấy việc hấp thụ atiso mỗi ngày trong vòng 2 tháng đã giúp giảm viêm và giảm lượng mỡ hiệu quả. Ngoài ra, dùng trà atiso liên tục trong 6 tuần sẽ làm giảm lượng cholesterol xấu trong cơ thể (khoảng 18.5 ~ 22.9%).\r\n\r\nTrà gừng\r\n\r\nVào những ngày đông lạnh, hay những lúc bị cảm và đau họng thì một tách trà gừng sẽ giúp làm ấm cơ thể, chữa cảm lạnh, ngăn ngừa virus hợp bào hô hấp gây bệnh. Ngoài ra, lợi thế lớn nhất của trà gừng là tốt cho dạ dày, điều trị các bệnh về đường tiêu hoá, thậm chí cả ung thư ruột kết.\r\nMột tác dụng bất ngờ của trà gừng nói riêng và các món có chứa gừng đó là chống lại hiệu ứng phá hủy tế bào bởi các gốc tự do, thủ phạm gây nhiều bệnh nan y trong đó có cả bệnh ung thư, tim mạch và đột quỵ. Trong gừng có chứa nhiều hợp chất pararadol và gingerol, có tác dụng tiêu diệt tế bào ung thư, hạn chế khối u di căn sang các tế bào, mô và các bộ phận khỏe mạnh khác.\r\n\r\nTrà bạc hà\r\n\r\nTrà bạc hà được nhiều người yêu thích bởi vị the mát của nó, kết hợp với vị trái cây thơm ngọt sẽ tạo nên một thức sảng khoái và đầy năng lượng. Hơn thế, trà bạc hà từ lâu được biết đến là loại thức uống thảo dược nóng, tốt cho sức khỏe, nó sẽ giúp bạn cảm thấy thư giãn, cũng như chống lại chứng mất ngủ.\r\nNgoài ra, trà bạc hà sẽ có nhiều tác dụng khác như cải thiện dòng chảy của mật, cho phép cơ thể tiêu hóa chất béo. Khi sử dụng trà bạc hà còn giúp bạn chữa chứng khó tiêu, các loại rối loạn tiêu hóa khác như buồn nôn, đau bụng, và tiêu chảy. \r\n\r\nTrà xanh\r\n\r\nTrà xanh khá quen thuộc và đặc biệt đây là loại trà thảo mộc có rất nhiều công dụng hữu ích đối với các chị em. Trong trà xanh chứa chất chống oxy hóa có hiệu lực mạnh hơn nhiều so với vitamin C và vitamin E, nhờ đó giúp bảo vệ các tế bào không bị phá hủy bởi bệnh ung thư, giảm lượng cholesterol, ngăn ngừa bệnh tim mạch và nguy cơ đột quỵ. \r\nĐặc biệt, uống trà xanh thường xuyên sẽ giúp phái đẹp làm chậm quá trình lão hóa, mờ các nếp nhăn trên khuôn mặt vì trong trà xanh có chứa polyphenols, một chất chống oxy hóa chống lại các gốc tự do. Ngoài ra, đây là một thức uống tự nhiên có tác dụng hữu hiệu trong việc giảm cân, giúp đốt cháy mỡ thừa và tăng cường khả năng trao đổi chất một cách tự nhiên. Bên cạnh đó, trà xanh sẽ giúp hệ xương khỏe mạnh nhờ chứa florua cao, giảm nguy cơ viêm khớp dạng thấp.\r\n\r\nNếu băn khoăn trong việc lựa chọn sản phẩm trà xanh chất lượng, chị em có thể tham khảo dòng sản phẩm trà xanh Tearoma của The Coffee House. Hương vị trà thanh mát, tinh tế và dễ chịu, có thể lựa chọn mùi vị của đào, sen, nhài nếu chị em yêu thích. Đồng thời, các sản phẩm chế biến từ trà của The Coffee House như trà đào cam sả, trà hạt sen, trà phúc bồn tử, trà macchiato... vừa thơm ngon, lại mang đến các hiệu quả làm đẹp và tốt cho sức khỏe như đã nói trên.\r\nVới những lợi ích của các loại trà thảo mộc đã được The Coffee House chia sẻ, bạn hãy thường xuyên sử dụng nó để đem lại những thay đổi tuyệt vời cho sức khỏe và sắc đẹp của mình nhé. Thế nhưng, cũng đừng quên việc tập luyện thể thao và thiết lập lối sống khoa học. The Coffee House chúc các chị em luôn khoẻ đẹp và rạng ngời!");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 12, 28, 20, 40, 33, 480, DateTimeKind.Local).AddTicks(5066));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2021, 12, 28, 20, 40, 33, 480, DateTimeKind.Local).AddTicks(6050));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2021, 12, 28, 20, 40, 33, 480, DateTimeKind.Local).AddTicks(6119));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2021, 12, 28, 20, 40, 33, 480, DateTimeKind.Local).AddTicks(6156));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2021, 12, 28, 20, 40, 33, 480, DateTimeKind.Local).AddTicks(6192));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2021, 12, 28, 20, 40, 33, 480, DateTimeKind.Local).AddTicks(6236));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2021, 12, 28, 20, 40, 33, 480, DateTimeKind.Local).AddTicks(6268));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2021, 12, 28, 20, 40, 33, 480, DateTimeKind.Local).AddTicks(6300));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2021, 12, 28, 20, 40, 33, 480, DateTimeKind.Local).AddTicks(6331));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 12, 28, 20, 40, 33, 480, DateTimeKind.Local).AddTicks(6363), "Trà sữa Mắc ca Trân châu trắng – Làn gió mới của các tín đồ trà sữa\r\nTrà sữa Mắc ca Trân châu trắng là sự kết hợp giữa nền trà Oolong hảo hạng thơm lừng, cùng sữa hạt Mắc Ca bổ dưỡng ngọt dịu ít béo, đặc biệt là topping trân châu trắng dai giòn hấp dẫn.\r\nĐây là một 'làn gió mới' mà The Coffee House mang đến cho bạn hương vị mới, trải nghiệm mới cho để bạn đổi vị tươi mới hơn và thú vị hơn. \r\nThe Coffee House tin rằng,\r\nmỗi ngày sẽ là điều tươi mới hơn với sữa hạt mắc ca thơm ngon,\r\nbổ dưỡng quyện cùng nền trà oolong cho vị cân bằng,\r\nngọt dịu đi kèm cùng Trân châu trắng giòn dai mang lại cảm giác “đã” trong từng ngụm Trà sữa Mắc ca Trân châu trắng.\r\nĐặt một ly và cho The Coffee House biết cảm nhận nhé!" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2021, 12, 28, 20, 40, 33, 480, DateTimeKind.Local).AddTicks(6393));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 12, 28, 20, 40, 33, 480, DateTimeKind.Local).AddTicks(6446), "Cà Phê Đá Xay – Phiên bản Upgrade từ ly cà phê sữa quen thuộcNếu là một Fan cà phê chân chính, chắc hẳn bạn sẽ không bỏ qua phiên bản 'upgrade' từ ly cà phê sữa quen thuộc này của The Coffee House.\r\nThức uống tuy quen mà lạ\r\nNằm trong dòng thức uống đá xay quen thuộc của Nhà.Dòng thức uống kết hợp sữa tươi,\r\nđá viên với nhiều nguyên liệu khác.Đặc điểm “nhận dạng” dòng thức uống này chính là phần kem tươi xốp mịn bên trên.Cà phê đá xay là món gắn liền với sự xuất hiện của dòng thức uống này ngay từ những ngày đầu xuất hiện tại The Coffee House.Cà phê đá xay với hương vị cà phê sữa quen thuộc,\r\nđi kèm lớp kem và đá xay mang đến cảm giác mát lạnh,\r\nthơm béo thêm phần quyến rũ.\r\nMột ly cà phê đá xay đạt chuẩn Nhà:\r\nĐậm đà hương vị,không bị nhạt do đá quá tan.\r\nKhi uống cảm nhận được hương thơm của cà phê, thơm béo của sữa.\r\nĐá viên được xay nhuyễn mịn, không bị lẫn các viên đá còn to.\r\nLớp kem tươi xốp, béo và được xịt vừa đủ lên trên ly.\r\nNhững lợi ích khi gọi một ly cà phê đá xay\r\nBên cạnh hương vị thơm ngon khó cưỡng, một ly cà phê đá xay còn là một món quà ngọt ngào cho tâm hồn, bất cứ khi nào bạn cần “kéo mood”. Một ngụm đá xay mát lạnh giúp bạn hoàn toàn tỉnh táo. Lượng cafein trong một ly đá xay không quá nhiều, đặc biệt phù hợp với các bạn yêu thích hương vị cà phê nhưng lại dễ say. \r\nCần tỉnh táo, một ly cà phê đá xay nhé!" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 12, 28, 20, 40, 33, 480, DateTimeKind.Local).AddTicks(6478), "Cookie Đá Xay – Món uống phá cách dễ thươngCookie đá xay - món uống phá cách dễ thương đầy mê hoặc từ The Coffee House có gì đặc biệt?\r\nThức uống “Top trending” của dòng đá xay \r\nNằm trong dòng thức uống đá xay (Ice Blended) quen thuộc của Nhà. Dòng thức uống kết hợp sữa tươi, đá viên với nhiều nguyên liệu khác. Đặc điểm “nhận dạng” dòng thức uống này chính là phần kem tươi xốp mịn bên trên. Cookie đá xay với những mẩu bánh cookies giòn rụm kết hợp ăn ý với sữa tươi, kem tươi béo ngọt và đá xay mát lành, đem đến cảm giác lạ miệng gây thích thú và không thể cưỡng lại. Một món uống phá cách dễ thương đầy mê hoặc.\r\nMột ly cookie đá xay đạt chuẩn Nhà:\r\nĐậm đà hương vị, không bị nhạt do đá quá tan.\r\nKhi uống cảm nhận được hương thơm, độ giòn của cookie, thơm béo của sữa.\r\nĐá viên được xay nhuyễn mịn, không bị lẫn các viên đá còn to.\r\nLớp kem tươi xốp, béo và được xịt vừa đủ lên trên ly.\r\nTừng ngụm thú vị\r\nKhông giống các thức uống còn lại, cookie đá xay không chỉ ngon mà còn vui miệng, với từng mẩu cookie giòn thơm kết hợp với đá xay. Với hương vị ngọt nhưng không ngấy, thơm béo vừa phải đây là thức uống thích hợp mỗi khi bạn cần giải nhiệt, cần sự tỉnh táo hay đơn giản một loại thức uống thú vị cho những ngày bỗng nhiên buồn chán.\r\nOrder ngay một ly cookie đá xay mát lạnh nhé!" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 12, 28, 20, 40, 33, 480, DateTimeKind.Local).AddTicks(6509), "Sinh tố Việt quất – Uống ngon, uống “đẹp”\r\nSự phối hợp hợp tinh tế của Barista Nhà\r\nSinh tố là tên gọi chung của những món trai cây xay. Ở Đây chúng ta có sinh tố việt quất với thành phần chính là mứt việt quất, sữa chua và Foam cheese. Mứt Việt Quất chua thanh, ngòn ngọt, phối hợp nhịp nhàng với dòng sữa chua bổ dưỡng, thêm vào đó là vị béo của Foam cheese được Barista Nhà phối hợp tinh tế. Tất cả tạo món sinh tố thơm ngon mà cả đầu lưỡi và làn da đều thích. \r\nThức uống yêu thích của làn da\r\nVới thành phần chính là mứt việt quất - loại trái cây được nhiều yêu thích vì công dụng cho sức khoẻ và đặc biệt làn da. Sinh tố việt quất có nhiều lợi ích có thể kể đến như:\r\nTốt cho làn da: Vitamin C trong việt quất được xem như là một dưỡng chất cần thiết giúp da tránh khỏi sự lão hóa da dưới tác động của ánh nắng mặt trời, ô nhiễm và khói bụi. \r\nNhững lợi ích đáng kể đối với sức khoẻ: Ngoài vitamin C, trong việt quất còn chứa các loại khoáng chất khác có ích như Vitamin K, Canxi, magie, kali… giúp xương chắc khoẻ, giảm nguy cơ mắc bệnh tiểu đường, tăng cường hệ tiêu hoá và giúp bạn kiểm soát cân nặng nhờ vào chất xơ có trong thành phần.\r\nTại the Coffee House, mỗi thức uống ra đời không chỉ đảm bảo tiêu chí ngon miệng mà còn quan tâm đến công dụng đối với sức khoẻ. Gọi ngay một ly sinh tố việt quất làm quà cho làn da bạn nhé!" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 12, 28, 20, 40, 33, 480, DateTimeKind.Local).AddTicks(6539), "SÔ CÔ LA ĐÁ XAY – Thức uống cho tín đồ hảo ngọt​\r\nHương vị chocolate quyến rũ\r\nSữa và kem tươi béo ngọt được “cá tính hoá” bởi vị chocolate đăng đắng. Có thể nói đây là thức uống được sinh ra dành cho các tín đồ hảo ngọt. Giống như các thức uống khác của dòng đá xay như Cà phê đá xay, Matcha đá xay,…một ly Chocolate đá xay đạt chuẩn Barista Nhà phải: \r\nĐậm đà hương vị, không bị nhạt do đá quá tan.\r\nKhi uống cảm nhận được hương thơm, vị đăng đắng đặc trưng của chocolate, thơm béo của sữa.\r\nĐá viên được xay nhuyễn mịn, không bị lẫn các viên đá còn to.\r\nLớp kem tươi xốp, béo và được xịt vừa đủ lên trên ly.​\r\nNguồn năng lượng cho tinh thần\r\nChocolate là một loại thực phẩm có nhiều công dụng hữu ích, làm hưng phấn tâm trạng do có caffeine, tyrosine và tryptophan. Trong các loại chocolate, chocolate đen được Barista Nhà dùng trong món chocolate đá xay có hàm lượng ca cao cao cùng với chất chống oxy hóa, ít chất béo nên có lợi cho sức khỏe hơn. Chỉ một lượng nhỏ chocolate cũng giúp bạn tràn đầy năng lượng? Không chỉ thế, chocolate còn được các chuyên gia sức khoẻ công nhận do có nhiều lợi ích có thể kể đến như:\r\nCải thiện sức khỏe tim mạch: Chocolate có thể giúp giảm huyết áo và chống viêm. Theo các nghiên cứu, chocolate có hàm lượng flavonoid cao. Flavonoid có thể kích thích cơ thể tạo ra nhiều oxit nitric hơn, giúp mở rộng và “thư giãn” mạch máu, do đó làm giảm huyết áp.\r\nGiống như trà xanh, chocolate cũng có epicatechin, giúp não chống lại quá trình hình thành các protein kết dích hay các mảng amyloid. Đây là những yếu tố nguy cơ gây ra bệnh Alzheimer.\r\nCó hiểu lầm cho rằng dùng chocolate sẽ gây tăng cân hay các tình trạng sức khỏe khác. Tuy nhiên, theo các nghiên cứu, chỉ cần bạn dùng một lượng nhỏ sẽ không có tác hại xấu đến cơ thể.\r\nCòn có lựa chọn nào tốt hơn cho tinh thần hơn là một ly chocolate đá xay. Order ngay!" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2021, 12, 28, 20, 40, 33, 480, DateTimeKind.Local).AddTicks(6569));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2021, 12, 28, 20, 40, 33, 480, DateTimeKind.Local).AddTicks(6599));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2021, 12, 28, 20, 40, 33, 480, DateTimeKind.Local).AddTicks(6629));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2021, 12, 28, 20, 40, 33, 480, DateTimeKind.Local).AddTicks(6661));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2021, 12, 28, 20, 40, 33, 480, DateTimeKind.Local).AddTicks(6692));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2021, 12, 28, 20, 40, 33, 480, DateTimeKind.Local).AddTicks(6724));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2021, 12, 28, 20, 40, 33, 480, DateTimeKind.Local).AddTicks(6754));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2021, 12, 28, 20, 40, 33, 480, DateTimeKind.Local).AddTicks(6796));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2021, 12, 28, 20, 40, 33, 480, DateTimeKind.Local).AddTicks(6823));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2021, 12, 28, 20, 40, 33, 480, DateTimeKind.Local).AddTicks(6850));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2021, 12, 28, 20, 40, 33, 480, DateTimeKind.Local).AddTicks(6906));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2021, 12, 28, 20, 40, 33, 480, DateTimeKind.Local).AddTicks(6926));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2021, 12, 28, 20, 40, 33, 480, DateTimeKind.Local).AddTicks(6945));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2021, 12, 28, 20, 40, 33, 480, DateTimeKind.Local).AddTicks(6975));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2021, 12, 28, 20, 40, 33, 480, DateTimeKind.Local).AddTicks(7018));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2021, 12, 28, 20, 40, 33, 480, DateTimeKind.Local).AddTicks(7020));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 12, 28, 20, 40, 33, 480, DateTimeKind.Local).AddTicks(7021), "Trà đào cam sả - Thức uống nhất định phải thử 1 lần khi đến The Coffee House\r\nCó thể bạn chưa biết, Trà Đào Cam Sả chính là một trong những món đồ uống được rất nhiều thực khách gọi mỗi khi ghé thăm The Coffee House. \r\nHương vị tuy quen mà lạ, tuy lạ mà quen\r\nKhi sáng chế ra thức uống này, Barista tại Nhà đã để lại dấu ấn riêng rất Việt trong món trà đào vốn đã quen thuộc đối với mọi người bằng một nguyên liệu rất đỗi dân dã - Sả, một loại cây vốn được trồng và sử dụng rộng rãi như là một gia vị thường thấy trong bữa ăn hằng ngày tại các nước châu Á. Sả có hương thơm của chanh, tính ấm, kết hợp với tính hàn của Cam vàng Mỹ, tạo nên sự kết hợp cân bằng, vừa mang dấu ấn riêng của Việt Nam, vừa có sự pha trộn phương Tây trong ly Trà đào Cam Sả The Coffee House. Vị thanh ngọt của đào Hy Lạp, vị chua dịu của Cam Vàng nguyên vỏ, vị chát của trà đen tươi được ủ mới mỗi 4 tiếng, cùng hương thơm nồng đặc trưng của sả chính là điểm sáng làm nên sức hấp dẫn của thức uống này. \r\nBổ sung thêm C, Tăng cường sức đề kháng\r\nKhông chỉ hương vị thơm ngon, Trà đào cam sả còn có các tác dụng tuyệt vời cho cơ thể. Có thể kể đến như:\r\nChống oxy hóa: Trong trà đào có chất chống oxy hóa mạnh mẽ và các hợp chất có thể ngăn ngừa quá trình lão hóa của da. \r\nTăng cường hệ miễn dịch: Chất chống oxy hóa có trong sả và cam còn góp phần nâng cao hệ thống miễn dịch, làm giảm căng thẳng và mệt mỏi. Một ly trà đào mỗi ngày sẽ bổ sung lượng lớn vitamin C giúp cơ thể \r\nGiảm cân: Tin vui cho bạn là trà đào có thể hỗ trợ đốt cháy chất béo góp phần và quá trình giảm cân hiệu quả. Vừa là thức uống ngon miệng, thời thượng lại vừa có thể giảm béo thì quả là tuyệt vời .\r\nĐể hiểu vì sao mỗi ngày có đến hơn 20,000 ly Trà Đào Cam Sả được The Coffee House trao đến tay khách hàng, order một ly Trà đào cam sả 'trứ danh' để cảm nhận, bạn nhé!" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 12, 28, 20, 40, 33, 480, DateTimeKind.Local).AddTicks(7023), "Trà hạt sen – Sự tinh tế của những điều đơn giản\r\nNền trà oolong hảo hạng kết hợp cùng hạt sen tươi, bùi bùi và lớp foam cheese béo ngậy. Thức uống gây thương nhớ tại The Coffee House có gì đặc biệt?\r\nSự kết hợp tinh tế của những nguyên liệu giản đơn \r\nSự kết hợp của Trà Oolong thanh mát với hương thơm nhẹ nhàng cùng vị nồng hậu của Hạt sen tươi mềm có vị ngọt, bùi. Đặc biệt, lớp kem sữa phô mai được phủ lên bề mặt ly sẽ cho bạn một trải nghiệm cân bằng hơn về hương vị.\r\nHình thức cực kỳ bắt mắt\r\nMột ly trà hạt sen chuẩn Nhà, bạn có thể nhìn thấy rõ ràng 3 lớp riêng biệt. Lớp đầu tiên là lớp “milk foam”béo ngậy, lớp ở giữa là trà oolong màu vàng sáng và lắng đọng ở lớp đáy là những “hạt ngọc” sen vàng.\r\nTrà hạt sen bồi bổ sức khoẻ:\r\nTrà Oolong – thảo dược quý giúp bạn bồi bổ sức khoẻ: Trong trà ô long có chứa rất nhiều vitamin, khoáng chất và những chất chống oxy hóa rất tốt. \r\n Hạt sen  cung cấp một lượng lớn gluxit, lipit, canxi, chất xơ và các vitamin mang đến nhiều lợi ích ch người dùng từ tác dụng chống viêm, giúp an thần, đến công dụng đẹp da, chống lão hoá, điều hoà cholesterol và đường huyết. \r\nMột loại thức uống phù hợp cho cả buổi sớm ban mai hay chiều tối với nhiều công dụng tuyệt vời chơ sức khoẻ, bạn đã thử chưa?" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 12, 28, 20, 40, 33, 480, DateTimeKind.Local).AddTicks(7024), "Trà hạt sen – Sự tinh tế của những điều đơn giản\r\nNền trà oolong hảo hạng kết hợp cùng hạt sen tươi, bùi bùi và lớp foam cheese béo ngậy. Thức uống gây thương nhớ tại The Coffee House có gì đặc biệt?\r\nSự kết hợp tinh tế của những nguyên liệu giản đơn \r\nSự kết hợp của Trà Oolong thanh mát với hương thơm nhẹ nhàng cùng vị nồng hậu của Hạt sen tươi mềm có vị ngọt, bùi. Đặc biệt, lớp kem sữa phô mai được phủ lên bề mặt ly sẽ cho bạn một trải nghiệm cân bằng hơn về hương vị.\r\nHình thức cực kỳ bắt mắt\r\nMột ly trà hạt sen chuẩn Nhà, bạn có thể nhìn thấy rõ ràng 3 lớp riêng biệt. Lớp đầu tiên là lớp “milk foam”béo ngậy, lớp ở giữa là trà oolong màu vàng sáng và lắng đọng ở lớp đáy là những “hạt ngọc” sen vàng.\r\nTrà hạt sen bồi bổ sức khoẻ:\r\nTrà Oolong – thảo dược quý giúp bạn bồi bổ sức khoẻ: Trong trà ô long có chứa rất nhiều vitamin, khoáng chất và những chất chống oxy hóa rất tốt. \r\n Hạt sen  cung cấp một lượng lớn gluxit, lipit, canxi, chất xơ và các vitamin mang đến nhiều lợi ích ch người dùng từ tác dụng chống viêm, giúp an thần, đến công dụng đẹp da, chống lão hoá, điều hoà cholesterol và đường huyết. \r\nMột loại thức uống phù hợp cho cả buổi sớm ban mai hay chiều tối với nhiều công dụng tuyệt vời chơ sức khoẻ, bạn đã thử chưa?" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedDate",
                value: new DateTime(2021, 12, 28, 20, 40, 33, 480, DateTimeKind.Local).AddTicks(7026));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedDate",
                value: new DateTime(2021, 12, 28, 20, 40, 33, 480, DateTimeKind.Local).AddTicks(7027));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedDate",
                value: new DateTime(2021, 12, 28, 20, 40, 33, 480, DateTimeKind.Local).AddTicks(7029));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 12, 28, 20, 40, 33, 480, DateTimeKind.Local).AddTicks(7030), "Trà sữa Mắc ca Trân châu trắng – Làn gió mới của các tín đồ trà sữa\r\nTrà sữa Mắc ca Trân châu trắng là sự kết hợp giữa nền trà Oolong hảo hạng thơm lừng, cùng sữa hạt Mắc Ca bổ dưỡng ngọt dịu ít béo, đặc biệt là topping trân châu trắng dai giòn hấp dẫn.\r\nĐây là một 'làn gió mới' mà The Coffee House mang đến cho bạn hương vị mới, trải nghiệm mới cho để bạn đổi vị tươi mới hơn và thú vị hơn. \r\nThe Coffee House tin rằng,\r\nmỗi ngày sẽ là điều tươi mới hơn với sữa hạt mắc ca thơm ngon,\r\nbổ dưỡng quyện cùng nền trà oolong cho vị cân bằng,\r\nngọt dịu đi kèm cùng Trân châu trắng giòn dai mang lại cảm giác “đã” trong từng ngụm Trà sữa Mắc ca Trân châu trắng.\r\nĐặt một ly và cho The Coffee House biết cảm nhận nhé!" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 12, 28, 20, 40, 33, 480, DateTimeKind.Local).AddTicks(7032), "Đào Việt Quất Đá Xay –  Sự Pha Trộn Hoàn Hảo Giữa Đào & Việt Quất\r\nMột trong những món đá xay phá cách được yêu thích nhất tại The Coffee House\r\nSự pha trộn tinh tế\r\nLà phiên bản “upgrade” từ ly trà đào quen thuộc của nhà, tuy là “em út” trong giá đình đá xay nhưng món đào việt quất đá xay lại nhanh chóng quen mặt, sau thời gian thử thách đã chính thức từ thức uống theo mùa trở thành món uống trên menu chính thức của Nhà. Được khoác lên mình ngoại hình xịn sò, mang đến sự phấn khích và tươi mát ngay từ cái nhìn đầu tiên, ở giữa là vịđào huyền thoại ngọt thanh, lớp việt quất chua ngọt vui miệng ở tầng cuối, đặc biệt kéo theo lớp kem bồng bềnh béo ngậy trên cùng nữa mang đến hương vị kích thích vị giác đầy lôi cuốn và khoan khoái ngay từ ngụm đầu tiên.\r\nNgon miệng, ngon mắt lại còn chứa nhiều vitamin\r\nQuả đào chứa nguồn vitamin dồi dào, đặc biệt là những loại vitamin thiết yếu. Các loại vitamin và khoáng chất có thể kể đến như: Vitamin K, canxi, phốt pho, đồng, kẽm. Các vitamin & khoáng chất này có nhiều công dụng tốt cho sức khỏe, đặc biệt là khả năng cải thiện thị lực, các vấn đề về xương và thần kinh.\r\nMứt việt quất chứa vitamin C, Vitamin K, Canxi, magie, kali… giúp xương chắc khoẻ, giảm nguy cơ mắc bệnh tiểu đường, tăng cường hệ tiêu hoá và giúp bạn kiểm soát cân nặng nhờ vào chất xơ có trong thành phần. \r\nĐặc biệt cả 2 loại quả đều có công dụng giúp da tránh khỏi sự lão hoá. \r\nNắng nóng, sức lực làm việc bỗng nhiên bị “bốc hơi”, tự nhiên thèm một thứ gì đó hạ hỏa và lên tinh thần ngay lúc này, order một ly đào việt quất đá xay và thưởng thức nhé!" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2021, 12, 28, 20, 40, 33, 480, DateTimeKind.Local).AddTicks(7034), "CHANH SẢ ĐÁ XAY – Thức uống thanh mát, giải nhiệt\r\nSự kết hợp của các nguyên liệu mộc mạc\r\nNước cốt sả (sả ngâm) xay cùng với chanh tươi, thêm vào chút đường tạo nên thức ống với hương vị thanh chua, ngọt ngọt, thơm nhẹ thoảng nhẹ mùi sả. Tuy thành phần đơn giản nhưng để có một ly chanh sả đá xay đúng điệu cùng cần tay nghề khéo léo của Barista Nhà từ sự kết hợp giữa các thành phần đến độ nhuyễn mịn của đá xay. \r\nThức uống giải nhiệt cơ thể\r\nTuy là những nguyên liệu đơn giản nhưng sả và chanh lại có những công dụng cực kỳ tốt đối với sức khoẻ:\r\nSả rất tốt cho hệ tiêu hoá, hỗ trợ tốt cho hệ thần kinh, có tính kháng viêm và đăc biệt tốt cho cho người muốn giảm cân do sả có tác dụng đốt cháy mỡ thừa, làm thúc đẩy quá trình trao đổi giúp máu lưu thông tốt hơn.\r\nTrong khi đó Chanh lại là loại quả cung cấp rất nhiều vitamin C, chất xơ và các hợp chất thực vật có lợi khác nhau. Những chất dinh dưỡng này đem lại một số lợi ích cho sức khỏe. Trên thực tế, chanh có thể hỗ trợ sức khỏe tim mạch, kiểm soát cân nặng và sức khỏe hệ tiêu hóa.\r\nGọi một ly chanh sả đá xay để giải nhiệt ngay thôi nào!" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedDate",
                value: new DateTime(2021, 12, 28, 20, 40, 33, 480, DateTimeKind.Local).AddTicks(7036));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedDate",
                value: new DateTime(2021, 12, 28, 20, 40, 33, 480, DateTimeKind.Local).AddTicks(7037));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedDate",
                value: new DateTime(2021, 12, 28, 20, 40, 33, 480, DateTimeKind.Local).AddTicks(7039));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedDate",
                value: new DateTime(2021, 12, 28, 20, 40, 33, 480, DateTimeKind.Local).AddTicks(7041));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedDate",
                value: new DateTime(2021, 12, 28, 20, 40, 33, 480, DateTimeKind.Local).AddTicks(7043));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedDate",
                value: new DateTime(2021, 12, 28, 20, 40, 33, 480, DateTimeKind.Local).AddTicks(7094));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedDate",
                value: new DateTime(2021, 12, 28, 20, 40, 33, 480, DateTimeKind.Local).AddTicks(7096));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedDate",
                value: new DateTime(2021, 12, 28, 20, 40, 33, 480, DateTimeKind.Local).AddTicks(7097));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedDate",
                value: new DateTime(2021, 12, 28, 20, 40, 33, 480, DateTimeKind.Local).AddTicks(7099));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedDate",
                value: new DateTime(2021, 12, 28, 20, 40, 33, 480, DateTimeKind.Local).AddTicks(7101));

            migrationBuilder.UpdateData(
                table: "Store",
                keyColumn: "Id",
                keyValue: 1,
                column: "District",
                value: "1");

            migrationBuilder.UpdateData(
                table: "Store",
                keyColumn: "Id",
                keyValue: 2,
                column: "District",
                value: "1");

            migrationBuilder.UpdateData(
                table: "Store",
                keyColumn: "Id",
                keyValue: 3,
                column: "District",
                value: "Bình Thạnh");

            migrationBuilder.UpdateData(
                table: "Store",
                keyColumn: "Id",
                keyValue: 4,
                column: "District",
                value: "Bình Thạnh");

            migrationBuilder.UpdateData(
                table: "Store",
                keyColumn: "Id",
                keyValue: 5,
                column: "District",
                value: "Bình Thạnh");

            migrationBuilder.UpdateData(
                table: "Store",
                keyColumn: "Id",
                keyValue: 6,
                column: "District",
                value: "Bình Thạnh");

            migrationBuilder.UpdateData(
                table: "Store",
                keyColumn: "Id",
                keyValue: 7,
                column: "District",
                value: "10");

            migrationBuilder.UpdateData(
                table: "Store",
                keyColumn: "Id",
                keyValue: 8,
                column: "District",
                value: "10");

            migrationBuilder.UpdateData(
                table: "Store",
                keyColumn: "Id",
                keyValue: 9,
                column: "District",
                value: "2");

            migrationBuilder.UpdateData(
                table: "Store",
                keyColumn: "Id",
                keyValue: 10,
                column: "District",
                value: "2");
        }
    }
}