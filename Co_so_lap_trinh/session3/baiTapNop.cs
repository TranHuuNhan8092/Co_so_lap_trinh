using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;
using System.Globalization;
using Unidecode.NET;



namespace Co_so_lap_trinh.session3
{
    internal class baiTapNop
    {
      
        public static void MainBT(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            Bai4();
            
        }
    

           
           
        

        



        static void Bai1()
        {
            /*Tình huống thực tế: Tập đoàn Điện lực Việt Nam (EVN) áp dụng biểu giá điện sinh hoạt bậc thang lũy tiến
            để khuyến khích người dân tiết kiệm điện. Hãy viết chương trình tính hóa đơn tiền điện hàng tháng cho một
 hộ gia đình.
Kiến thức trọng tâm: Kiểu decimal, ép kiểu dữ liệu, định dạng tiền tệ ({0:C} hoặc #,##0 VNĐ), tính toán toán
học.
Yêu cầu bài toán:
• Nhập vào chỉ số điện cũ (kWh) và chỉ số điện mới (kWh). Kiểm tra điều kiện chỉ số mới phải lớn hơn hoặc
bằng chỉ số cũ.
• Tính lượng điện tiêu thụ trong tháng = Chỉ số mới - Chỉ số cũ.
• Tính tiền điện theo các bậc giá chưa thuế (Giá giả định năm 2026):
• + Bậc 1: Cho 50 kWh đầu tiên (từ 0 - 50 kWh): 1.806 VNĐ/kWh
• + Bậc 2: Cho 50 kWh tiếp theo (từ 51 - 100 kWh): 1.866 VNĐ/kWh
• + Bậc 3: Cho 100 kWh tiếp theo (từ 101 - 200 kWh): 2.167 VNĐ/kWh
• + Bậc 4: Cho 100 kWh tiếp theo (từ 201 - 300 kWh): 2.729 VNĐ/kWh
• + Bậc 5: Cho toàn bộ kWh từ 301 kWh trở lên: 3.050 VNĐ/kWh
• Cộng thêm 8% Thuế Giá trị gia tăng (VAT).
• In hóa đơn chi tiết gồm: Số kWh tiêu thụ, Tiền điện chưa thuế, Tiền thuế VAT và Tổng tiền phải thanh toán
(làm tròn đến hàng đơn vị decimal).
Ví dụ minh họa Input / Output:
--- INPUT ---
Nhập chỉ số điện cũ (kWh): 1250
Nhập chỉ số điện mới (kWh): 1520
--- OUTPUT ---
Số điện tiêu thụ: 270 kWh
Tiền điện chưa thuế: 636,650 VNĐ
Thuế VAT (8%): 50,932 VNĐ
Tổng thanh toán: 687,582 VNĐ
*/

            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Nhập chỉ số điện cũ (kWh): ");
            int chiSoCu = int.Parse(Console.ReadLine());
            int chiSoMoi;
            decimal tienDienChuaThue;
            decimal thueVAT;
            decimal tongThanhToan;
            do
            {
                Console.Write("Nhập chỉ số điện mới (kWh): ");
                int chiSo = int.Parse(Console.ReadLine());
                chiSoMoi = chiSo;
                if (chiSoMoi <= chiSoCu)
                { Console.WriteLine("Chỉ số mới phải lớn hơn hoặc bằng chỉ số cũ."); }
            } while (chiSoMoi <= chiSoCu);

            int luongDienTieuThu = chiSoMoi - chiSoCu;

            if (luongDienTieuThu <= 50)
            {
                tienDienChuaThue = (decimal)(luongDienTieuThu * 1806);

            }
            else if (luongDienTieuThu <= 100)
            {
                tienDienChuaThue = (decimal)(50 * 1806 + (luongDienTieuThu - 50) * 1866);
            }
            else if (luongDienTieuThu <= 200)
            {
                tienDienChuaThue = (decimal)(50 * 1806 + 50 * 1866 + (luongDienTieuThu - 100) * 2167);
            }
            else if (luongDienTieuThu <= 300)
            {
                tienDienChuaThue = (decimal)(50 * 1806 + 50 * 1866 + 100 * 2167 + (luongDienTieuThu - 200) * 2729);
            }
            else
            {
                tienDienChuaThue = (decimal)(50 * 1806 + 50 * 1866 + 100 * 2167 + 100 * 2729 + (luongDienTieuThu - 300) * 3050);
            }

            thueVAT = tienDienChuaThue * 0.08m;
            tongThanhToan = tienDienChuaThue + thueVAT;

            Console.WriteLine($"Số điện tiêu thụ: {luongDienTieuThu} kWh");
            Console.WriteLine($"Tiền điện chưa thuế: {tienDienChuaThue:N0} VNĐ");
            Console.WriteLine($"Thuế VAT (8%): {thueVAT:N0} VNĐ");
            Console.WriteLine($"Tổng thanh toán: {tongThanhToan:N0} VNĐ");


            Console.ReadKey();
        }
        
        static void Bai2()
        {
            /*Tình huống thực tế: Một ứng dụng theo dõi sức khỏe cá nhân cần tính chỉ số khối cơ thể (BMI - Body Mass
Index) dựa trên chiều cao và cân nặng do người dùng cung cấp, đồng thời đưa ra lời khuyên về cân nặng lý
tưởng.
Kiến thức trọng tâm: Kiểu double, ép kiểu, Math.Pow(), định dạng số thập phân ({0:F2}), cấu trúc rẽ nhánh.
Yêu cầu bài toán:
• Nhập vào chiều cao (tính bằng mét, ví dụ 1.72) và cân nặng (tính bằng kg, ví dụ 68.5).
• Tính chỉ số BMI theo công thức: BMI = Cân nặng / (Chiều cao ^ 2).
• Phân loại tình trạng sức khỏe theo chuẩn WHO dành cho người châu Á:
• + BMI < 18.5: Gầy (Thiếu cân)
• + 18.5 <= BMI < 23.0: Bình thường (Lý tưởng)
• + 23.0 <= BMI < 25.0: Thừa cân (Tiền béo phì)
• + BMI >= 25.0: Béo phì
• Tính dải cân nặng lý tưởng cho chiều cao đó (Cân nặng tối thiểu = 18.5 * Chiều cao^2; Cân nặng tối đa =
22.9 * Chiều cao^2).
• Xuất ra chỉ số BMI (lấy 2 chữ số thập phân), phân loại và khoảng cân nặng lý tưởng.
Ví dụ minh họa Input / Output:
BÀI TẬP LẬP TRÌNH C# | CHỦ ĐỀ: KIỂU DỮ LIỆU (DATA TYPES)
Trang 4 / 14
--- INPUT ---
Chiều cao (m): 1.68
Cân nặng (kg): 72.0
--- OUTPUT ---
Chỉ số BMI của bạn: 25.51
Phân loại sức khỏe: Béo phì
Khuyên dùng: Cân nặng lý tưởng của bạn nên từ 52.21 kg đến 64.63 kg*/
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Chiều cao (m): ");
            double chieuCao = double.Parse(Console.ReadLine());
            Console.Write("Cân nặng (kg): ");
            double canNang = double.Parse(Console.ReadLine());
            double BMI = canNang / Math.Pow(chieuCao, 2);
            string tinhTrang = "";
            double canNangToiThieu;
            double canNangToiDa;
            if (BMI < 18.5)
            {
                tinhTrang = "Gầy (Thiếu cân)";
            }
            else if (BMI < 23.0)
            {
                tinhTrang = "Bình thường (Lý tưởng)";
            }
            else if (BMI < 25)
            {
                tinhTrang = "Thừa cân (Tiền béo phì)";
            }
            else
            {
                tinhTrang = "Béo phì";
            }
            canNangToiThieu = 18.5 * Math.Pow(chieuCao, 2);
            canNangToiDa = 22.9 * Math.Pow(chieuCao, 2);

            Console.WriteLine($"Chỉ số BMI của bạn: {BMI:F2}");
            Console.WriteLine($"Phân loại sức khỏe: {tinhTrang}");
            Console.WriteLine($"Khuyên dùng: Cân nặng lý tưởng của bạn nên từ {canNangToiThieu:F2} kg đến {canNangToiDa:F2} kg");

            Console.ReadKey();
        }
       
        static void Bai3()
        {
            /*Bài 3: Ứng Dụng Quy Đổi Tiền Tệ Ngoại Tệ Đa Tỷ Giá Ngân Hàng
Tình huống thực tế: Một quầy đổi tiền tại sân bay cần ứng dụng tính toán nhanh số tiền khách hàng nhận
được khi đổi từ Việt Nam Đồng (VND) sang các loại ngoại tệ phổ biến (USD, EUR, JPY, GBP) có tính phí dịch
vụ.
Kiến thức trọng tâm: Kiểu decimal, enum (CurrencyType), switch-case, định dạng tiền tệ quốc tế.
Yêu cầu bài toán:
• Tạo một enum tên CurrencyType gồm: USD, EUR, JPY, GBP.
• Khai báo tỷ giá cố định (Ví dụ: 1 USD = 25,400 VNĐ; 1 EUR = 27,200 VNĐ; 1 JPY = 165 VNĐ; 1 GBP =
32,100 VNĐ).
• Nhập vào số tiền VNĐ cần đổi (decimal) và chọn loại ngoại tệ muốn đổi.
• Phí dịch vụ quy đổi là 0.5% trên tổng số tiền VNĐ.
• Tính số tiền VNĐ thực tế sau khi trừ phí, sau đó quy đổi ra ngoại tệ tương ứng.
• In kết quả chính xác đến 2 chữ số thập phân kèm ký hiệu tiền tệ.
Ví dụ minh họa Input / Output:
--- INPUT ---
Nhập số tiền VNĐ: 10,000,000
Chọn ngoại tệ (1-USD, 2-EUR, 3-JPY, 4-GBP): 1
--- OUTPUT ---
Phí dịch vụ (0.5%): 50,000 VNĐ
Số tiền VNĐ tính đổi: 9,950,000 VNĐ
Số tiền USD nhận được: 391.73 USD*/
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Nhập số tiền VNĐ: ");
            decimal soTien = decimal.Parse(Console.ReadLine());
            Console.Write("Chọn ngoại tệ (1-USD, 2-EUR, 3-JPY, 4-GBP): ");
            int chonNgoaiTe = int.Parse(Console.ReadLine());
            decimal phiDichVu = 0.005m * soTien;
            decimal soTienTinhDoi = soTien - phiDichVu;
            decimal soTienNgoaiTe = 0;
            string tenNgoaiTe = "";
            int[] tyGiaCoDinh = { 25400, 27200, 165, 32100 };
            switch (chonNgoaiTe)
            {
                case 1:
                    tenNgoaiTe = "USD";
                    soTienNgoaiTe = soTienTinhDoi / tyGiaCoDinh[0];
                    break;

                case 2:
                    tenNgoaiTe = "Euro";
                    soTienNgoaiTe = soTienTinhDoi / tyGiaCoDinh[1];
                    break;

                case 3:
                    tenNgoaiTe = "JPY";
                    soTienNgoaiTe = soTienTinhDoi / tyGiaCoDinh[2];
                    break;

                case 4:
                    tenNgoaiTe = "GBP";
                    soTienNgoaiTe = soTienTinhDoi / tyGiaCoDinh[3];
                    break;
            }
            Console.WriteLine($"Phí dịch vụ (0.5%): {phiDichVu:N0} VNĐ");
            Console.WriteLine($"Số tiền VNĐ tính đổi: {soTienTinhDoi:N0} VNĐ");
            Console.WriteLine($"Số tiền {tenNgoaiTe} nhận được: {soTienNgoaiTe:N2} {tenNgoaiTe}");

            Console.ReadKey();
        }
        
        static void Bai4()
        {
            /*Bài 4: Tính Tuổi Chính Xác & Đếm Ngược Ngày Sinh Nhật
Tình huống thực tế: Hệ thống chăm sóc khách hàng của một công ty bán lẻ cần tự động tính tuổi chính xác
của khách hàng và đếm số ngày còn lại đến sinh nhật tiếp theo để gửi voucher ưu đãi.
Kiến thức trọng tâm: Kiểu DateTime, TimeSpan, DateTime.ParseExact, toán tử trừ hai ngày, ép kiểu.
Yêu cầu bài toán:
• Nhập ngày tháng năm sinh của người dùng dưới dạng chuỗi 'dd/MM/yyyy' (ví dụ: '25/10/2002').
• Chuyển đổi chuỗi thành DateTime sử dụng DateTime.TryParseExact để đảm bảo không bị lỗi định dạng.
• Lấy ngày hiện tại hệ thống (DateTime.Now.Date).
• Tính tuổi chính xác tính theo số năm.
• Xác định ngày sinh nhật tiếp theo trong năm nay hoặc năm sau. Tính số ngày còn lại đến sinh nhật đó.
• Hiển thị: Tuổi hiện tại, Tổng số ngày đã sống từ lúc sinh ra, và Số ngày còn lại đến sinh nhật kế tiếp.
Ví dụ minh họa Input / Output:
--- INPUT ---
Nhập ngày sinh (dd/MM/yyyy): 15/09/2003
--- OUTPUT ---
Tuổi hiện tại: 22 tuổi
Bạn đã sống tổng cộng: 8,376 ngày
Sinh nhật tiếp theo còn: 25 ngày nữa*/
            Console.OutputEncoding = Encoding.UTF8;

            Console.Write("Nhập ngày sinh (dd/MM/yyyy):");
            string ngaySinh = Console.ReadLine();

            DateTime birthday = DateTime.ParseExact(ngaySinh, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            DateTime currentDate = DateTime.Now.Date;
            int age = currentDate.Year - birthday.Year;
            DateTime nextBirthday = new DateTime(currentDate.Year, birthday.Month, birthday.Day);
            if (nextBirthday > currentDate)
            {
                age--;
            }
            TimeSpan span = currentDate - birthday;
            int totalDays = (int)span.TotalDays;

            if (nextBirthday <= currentDate)
            { nextBirthday = nextBirthday.AddYears(1); }
            TimeSpan birthdaySpan = nextBirthday - currentDate;
            Console.WriteLine($"Tuổi hiện tại: {age} tuổi");
            Console.WriteLine($"Bạn đã sống tổng cộng: {totalDays}");
            Console.WriteLine($"Sinh nhật tiếp theo còn: {(int)birthdaySpan.TotalDays} ngày nữa");

            Console.ReadKey();
        }

        static void Bai5()
        {/*Quản Lý Điểm Học Phần & Quy Đổi Thang Điểm GPA (4.0)
Tình huống thực tế: Hệ thống quản lý đào tạo đại học cần tính điểm trung bình tín chỉ (GPA) học kỳ cho
sinh viên dựa trên điểm số các môn học và quy đổi sang thang điểm chữ (A, B, C, D, F) cùng thang điểm 4.
Kiến thức trọng tâm: Kiểu float hoặc double, char, enum, ép kiểu điểm số, định dạng bảng xuất.
Yêu cầu bài toán:
• Nhập điểm số (thang 10, kiểu double) và số tín chỉ (int) của 3 môn học: Lập trình C#, Toán rời rạc, Tiếng
Anh.
• Tính điểm trung bình trọng số (Weighted Average Score):
 Score_Avg = (Điểm1*TC1 + Điểm2*TC2 + Điểm3*TC3) / (TC1 + TC2 + TC3).
• Quy đổi Score_Avg sang Điểm chữ (char/string) và Thang điểm 4 (double):
• + [8.5 - 10.0]: Điểm A | Thang 4: 4.0 | Xếp loại: Xuất sắc / Giỏi
BÀI TẬP LẬP TRÌNH C# | CHỦ ĐỀ: KIỂU DỮ LIỆU (DATA TYPES)
Trang 6 / 14
• + [7.0 - 8.4] : Điểm B | Thang 4: 3.0 | Xếp loại: Khá
• + [5.5 - 6.9] : Điểm C | Thang 4: 2.0 | Xếp loại: Trung bình
• + [4.0 - 5.4] : Điểm D | Thang 4: 1.0 | Xếp loại: Yếu
• + [< 4.0] : Điểm F | Thang 4: 0.0 | Xếp loại: Kém (Trượt)
• Xuất bảng điểm chi tiết và GPA làm tròn 2 chữ số thập phân.
Ví dụ minh họa Input / Output:
--- INPUT ---
C# (4 TC): 8.8
Toán (3 TC): 7.2
Tiếng Anh (2 TC): 6.5
--- OUTPUT ---
Điểm TB Thang 10: 7.76
Điểm Chữ Quy Đổi: B
Điểm GPA Thang 4: 3.0
Xếp Loại Học Lực: Khá*/
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("C# (4 TC): ");
            double diemCSharp = double.Parse(Console.ReadLine());

            Console.Write("Toán (3 TC): ");
            double diemToan = double.Parse(Console.ReadLine());

            Console.Write("Tiếng Anh (2 TC): ");
            double diemEng = double.Parse(Console.ReadLine());

            int tongTC = 9;
            double gpa = 0.0;
            char diemChu = '\0';
            string xepLoai = "";
            double diemSo = (diemCSharp * 4 + diemToan * 3 + diemEng * 2) / tongTC;

            if (diemSo >= 8.5)
            {
                diemChu = 'A';
                gpa = 4.0;
                if (diemSo >= 9.0)
                {
                    xepLoai = "Xuất sắc";
                }
                else
                {
                    xepLoai = "Giỏi";
                }

            }
            else if (diemSo >= 7.0)
            {
                diemChu = 'B';
                gpa = 3.0;
                xepLoai = "Khá";
            }
            else if (diemSo >= 5.5)
            {
                diemChu = 'C';
                gpa = 2.0;
                xepLoai = "Trung bình";
            }
            else if (diemSo >= 4.0)
            {
                diemChu = 'D';
                gpa = 1.0;
                xepLoai = "Yếu";
            }
            else
            {
                diemChu = 'F';
                xepLoai = "Kém (Trượt)";
            }

            Console.WriteLine($"Điểm TB Thang 10: {diemSo:N2}");
            Console.WriteLine($"Điểm TB Thang 4: {gpa}");
            Console.WriteLine($"Điểm chữ: {diemChu}");
            Console.WriteLine($"Xếp loại: {xepLoai}");

            Console.ReadKey();
        }

        static void Bai6()
        {
            /*Tình huống thực tế: Bộ phận Nhân sự (HR) cần một công cụ xử lý dữ liệu thô nhập vào từ biểu mẫu đăng
ký. Họ tên nhập vào thường bị lỗi thừa khoảng trắng, hoa thường lộn xộn. Cần chuẩn hóa tên và tạo tài
khoản công ty.
Kiến thức trọng tâm: Kiểu string, các phương thức Trim(), Split(), Substring(), ToLower(), ToUpper(),
string.Join().
Yêu cầu bài toán:
• Nhập vào một chuỗi họ tên thô từ bàn phím (Ví dụ: " ngUYỄN vĂn aN ").
• Loại bỏ khoảng trắng thừa ở đầu, cuối và giữa các từ (chỉ giữ lại 1 khoảng trắng giữa các từ).
• Chuyển đổi chuỗi thành dạng Viết Hoa Chữ Cái Đầu Mỗi Từ (Title Case): "Nguyễn Văn An".
• Tách thành Họ, Tên Đệm và Tên chính.
• Tạo Username không dấu theo quy tắc: ten.hovatenm. (Ví dụ: an.nguyenvan).
• Tạo Email công ty: username + "@company.edu.vn".
Ví dụ minh họa Input / Output:
--- INPUT ---
Nhập họ tên thô: tRẦN qUỐC tUẤN
BÀI TẬP LẬP TRÌNH C# | CHỦ ĐỀ: KIỂU DỮ LIỆU (DATA TYPES)
Trang 7 / 14
--- OUTPUT ---
Họ tên chuẩn hóa: Trần Quốc Tuấn
Họ: Trần | Tên đệm: Quốc | Tên: Tuấn
Username tạo tự động: tuan.tranquoc
Email cấp phát: tuan.tranquoc@company.edu.vn*/
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Nhập họ tên thô: ");
            string hoTenTho = Console.ReadLine();

            //Chuẩn hóa họ tên
            string[] chinhTen = hoTenTho.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            string hoTen = string.Join(" ", chinhTen);
            string hoTenThuong = hoTen.ToLower();
            string hoTenChuan = new CultureInfo("vi-VN").TextInfo.ToTitleCase(hoTenThuong);

            // Tach Ho, Ten dem, Ten
            int viTriHo = hoTenChuan.IndexOf(' ');
            int viTriTen = hoTenChuan.LastIndexOf(' ');
            string ho = hoTenChuan.Substring(0, viTriHo);
            string tenDem = hoTenChuan.Substring(viTriHo + 1, viTriTen - 1 - viTriHo);
            string ten = hoTenChuan.Substring(viTriTen + 1);

            //tao username va email
            string[] user = new string[4];
            user[0] = $"{ten.Unidecode().ToLower()}.";
            user[1] = $"{ho.Unidecode().ToLower()}";
            user[2] = $"{tenDem.Unidecode().Replace(" ", "").ToLower()}";
            user[3] = "@company.edu.vn";
            string userName = string.Join("", user.Take(3));
            string email = string.Join("", user);


            Console.WriteLine($"Họ tên chuẩn hóa: {hoTenChuan}");
            Console.WriteLine($"Họ: {ho} | Tên đệm: {tenDem} | Tên: {ten}");
            Console.WriteLine($"Username tạo tự động: {userName}");
            Console.WriteLine($"Email cấp phát: {email}");
            Console.ReadKey();
        }

        static void Bai7() {

            /*Tình huống thực tế: Một nhóm bạn lên kế hoạch đi phượt bằng xe ô tô cá nhân. Họ cần một máy tính bỏ
túi để ước tính tổng lượng nhiên liệu tiêu thụ, tổng chi phí xăng dầu và chia đều cho từng thành viên.
Kiến thức trọng tâm: Kiểu double, decimal, int, Math.Ceiling, định dạng tiền tệ.
Yêu cầu bài toán:
• Nhập khoảng cách chuyến đi (km - kiểu double).
• Nhập mức tiêu thụ nhiên liệu trung bình của xe (lít/100km - kiểu double).
• Nhập giá xăng hiện tại (VNĐ/lít - kiểu decimal).
• Nhập số lượng người tham gia chuyến đi (người - kiểu int).
• Tính tổng số lít xăng cần dùng = (Quãng đường / 100) * Mức tiêu thụ.
• Tính tổng chi phí tiền xăng = Tổng số lít xăng * Giá xăng.
• Tính số tiền mỗi người phải chi trả (làm tròn lên hàng nghìn VNĐ gần nhất bằng Math.Ceiling).
Ví dụ minh họa Input / Output:
--- INPUT ---
Quãng đường (km): 320.5
Mức tiêu hao (L/100km): 7.5
Giá xăng (VNĐ/Lít): 23,800
Số người đi: 4
--- OUTPUT ---
Tổng nhiên liệu tiêu thụ: 24.04 Lít
Tổng chi phí xăng dầu: 572,092 VNĐ
Chi phí mỗi người: 144,000 VNĐ
*/
            Console.Write("Quãng đường (km): ");
            double quangDuong = double.Parse(Console.ReadLine());
            Console.Write("Mức tiêu hao (L/100km): ");
            double mucTieuHao = double.Parse(Console.ReadLine());
            Console.Write("Giá xăng (VNĐ/Lít): ");
            decimal giaXang = decimal.Parse(Console.ReadLine());
            Console.Write("Số người đi: ");
            int soNguoi = int.Parse(Console.ReadLine());

            double nlTieuThu = (mucTieuHao * quangDuong) / 100;
            decimal chiPhiXang = (decimal)(nlTieuThu) * giaXang;
            decimal moiNguoi = chiPhiXang / (decimal)soNguoi;
            chiPhiXang = (int)chiPhiXang;
           
            moiNguoi = 1000 * (Math.Ceiling(moiNguoi / 1000));

            Console.WriteLine($"Tổng nhiên liệu tiêu thụ: {nlTieuThu:N2} Lít");
            Console.WriteLine($"Tổng chi phí xăng dầu: {chiPhiXang} VNĐ");
            Console.WriteLine($"Chi phí mỗi người: {moiNguoi} VNĐ");




            Console.ReadKey();
        }

        static void Bai9()
        {
            /*Tình huống thực tế: Phòng kế toán cần phần mềm tự động tính tiền lương thực nhận (Net Salary) từ lương
thỏa thuận (Gross Salary) sau khi trừ các khoản bảo hiểm bắt buộc và Thuế thu nhập cá nhân (TNCN).
Kiến thức trọng tâm: Kiểu decimal, double, bool, tính toán phần trăm, cấu trúc thuế lũy tiến.
Yêu cầu bài toán:
• Nhập Lương Gross (VNĐ) và Số người phụ thuộc (int).
• Tính các khoản Bảo hiểm bắt buộc theo tỷ lệ hiện hành (trên lương Gross):
• + Bảo hiểm xã hội (BHXH): 8%
• + Bảo hiểm y tế (BHYT): 1.5%
• + Bảo hiểm thất nghiệp (BHTN): 1%
• => Tổng giảm trừ bảo hiểm = 10.5% * Lương Gross.
BÀI TẬP LẬP TRÌNH C# | CHỦ ĐỀ: KIỂU DỮ LIỆU (DATA TYPES)
Trang 9 / 14
• Tính Thu nhập chịu thuế = Gross - Tổng bảo hiểm - Mức bản thân (11,000,000 VNĐ) - (Số người phụ thuộc
* 4,400,000 VNĐ). (Nếu <= 0 thì Thu nhập chịu thuế = 0).
• Tính Thuế TNCN theo biểu thuế lũy tiến từng phần (Bậc 1: 5% cho <=5tr, Bậc 2: 10% cho 5-10tr, Bậc 3: 15%
cho 10-18tr...).
• Tính Lương Net thực nhận = Gross - Tổng bảo hiểm - Thuế TNCN.
Ví dụ minh họa Input / Output:
--- INPUT ---
Lương Gross: 25,000,000 VNĐ
Số người phụ thuộc: 1
--- OUTPUT ---
Giảm trừ Bảo hiểm (10.5%): 2,625,000 VNĐ
Thu nhập chịu thuế: 6,975,000 VNĐ
Thuế TNCN phải nộp: 447,500 VNĐ
LƯƠNG NET THỰC NHẬN: 21,927,500 VNĐ*/
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            //khai bao luong
            Console.Write("Lương Gross (VNĐ): ");
            decimal gross = decimal.Parse(Console.ReadLine());
            Console.Write("Số người phụ thuộc: ");
            int soNguoi = int.Parse(Console.ReadLine());
            

            //
            decimal tongBaoHiem = 0.105m * gross;
            decimal tienNguoi = soNguoi * 4400000;
            decimal thue = gross - tongBaoHiem - 11000000 - tienNguoi;
            decimal thueTNCN = 0;
            int donViTien = (int)Math.Pow(10, 6);

            if (thue <= 0) { thue = 0; }

            if (thue <= 5000000) { thueTNCN = 0.05m * thue; }
            else if (thue <= 10 * donViTien) { thueTNCN = 0.25m * donViTien + (thue - 5 * donViTien) * 0.1m; }
            else if (thue <= 18 * donViTien) { thueTNCN = 0.75m * donViTien + (thue - 10 * donViTien) * 0.15m; }
            else if (thue <= 32 * donViTien) { thueTNCN = 1.95m * donViTien + (thue - 18 * donViTien) * 0.2m; }
            else if (thue <= 52 * donViTien) { thueTNCN = 4.75m * donViTien + (thue - 32 * donViTien) * 0.25m; }
            else if (thue <= 80 * donViTien) { thueTNCN = 9.75m * donViTien + (thue - 52 * donViTien) * 0.3m; }

            else { thueTNCN = 18.15m * donViTien + (thue - 80 * donViTien) * 0.35m; }

            decimal luongNet = gross - tongBaoHiem - thueTNCN;

            Console.WriteLine($"Giảm trừ Bảo hiểm (10.5%): {tongBaoHiem:N0} VNĐ ");
            Console.WriteLine($"Thu nhập chịu thuế: {thue:N0} VNĐ");
            Console.WriteLine($"Thuế TNCN phải nộp: {thueTNCN:N0} VNĐ");
            Console.WriteLine($"LƯƠNG NET THỰC NHẬN: {luongNet:N0}");



            Console.ReadKey();
        }

        //Bài 11 tính sai
        static void Bai11() {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            //Nhap va tach tien gui
            Console.Write("Số tiền gửi (VNĐ): ");
            
            decimal P = decimal.Parse(Console.ReadLine());

            //Nhap va tach lai suat
            Console.Write("Lãi suất năm (%/năm): ");

            double r = double.Parse(Console.ReadLine());

            //Nhap va tach ky han
            Console.Write("Thời gian gửi (tháng): ");
           
            int n = int.Parse(Console.ReadLine());

            //Lai don
            decimal laiDon = P * (decimal)(r / 100) * (decimal)(n / 12.0);

            //Lai kep

            decimal x = 1 + (decimal)(r / 100) / 12;
            decimal growthFactor = (decimal)Math.Pow((double)x, n);
            decimal laiKep = P * growthFactor;


            Console.WriteLine($"Tổng tiền lãi (Lãi đơn): {laiDon:N0} VNĐ");
            Console.WriteLine($"Tổng tiền lãi (Lãi kép): {laiKep - P:N0}");


            Console.WriteLine($"laiKep = {laiKep:N0}");
            if (laiDon < laiKep - P)
            {
                Console.WriteLine($"Lợi nhuận chênh lệch: {laiKep - P - laiDon:N0} VNĐ (Lãi kép tối ưu hơn)");

            }
            else { Console.WriteLine($"Lợi nhuận chênh lệch: {laiDon - (laiKep - P):N0} VNĐ (Lãi đơn tối ưu hơn)"); }


            Console.ReadKey();
        }

        static void Bai12()
        {
            /*Tình huống thực tế: Khách hàng muốn gửi tiết kiệm tại ngân hàng. Chương trình cần hỗ trợ tính toán tổng
số tiền cả gốc lẫn lãi thu được sau kỳ hạn gửi theo 2 phương thức: Lãi đơn và Lãi kép.
Kiến thức trọng tâm: Kiểu decimal, double, Math.Pow(), ép kiểu giữa decimal và double, định dạng số.
Yêu cầu bài toán:
• Nhập Số tiền gửi ban đầu P (decimal - VNĐ).
• Nhập Lãi suất năm r (%/năm - kiểu double, ví dụ 6.5%).
• Nhập Kỳ hạn gửi n (tháng - kiểu int, ví dụ 12 tháng).
• Tính Lãi Đơn (Simple Interest):
• + Tiền lãi đơn = P * (r / 100) * (n / 12.0).
• Tính Lãi Kép hàng tháng (Compound Interest):
• + Tổng tiền lãi kép A = P * (1 + (r / 100) / 12) ^ n.
• (Lưu ý: Công thức lũy thừa cần đổi P sang double để dùng Math.Pow, sau đó ép kiểu kết quả về decimal).
• In kết quả so sánh chênh lệch giữa Lãi kép và Lãi đơn.
Ví dụ minh họa Input / Output:
--- INPUT ---
Số tiền gửi: 100,000,000 VNĐ
Lãi suất năm: 6.8 %/năm
Thời gian gửi: 24 tháng
--- OUTPUT ---
BÀI TẬP LẬP TRÌNH C# | CHỦ ĐỀ: KIỂU DỮ LIỆU (DATA TYPES)
Trang 11 / 14
Tổng tiền lãi (Lãi đơn): 13,600,000 VNĐ
Tổng tiền lãi (Lãi kép): 14,548,220 VNĐ
Lợi nhuận chênh lệch: 948,220 VNĐ (Lãi kép tối ưu hơn)*/
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            Console.Write("Văn bản gốc: ");
            string origin = Console.ReadLine();
            string result = "";
            string decode = "";
            Console.Write("Khóa dịch chuyển (Shift Key k): ");
            int key = int.Parse(Console.ReadLine());
            char newChar = 'a';
            char decodeChar = 'a';

            foreach (char c in origin)
            {
                if (char.IsLetter(c) == true)
                {
                    if (char.IsUpper(c) == true)
                    {
                        newChar = (char)((int)'A' + ((int)(c - 'A' + key) % 26));
                        result += newChar;

                    }
                    else
                    {
                        newChar = (char)('a' + (c - 'a' + key) % 26);
                        result += newChar;
                    }

                }
                else
                {
                    result += c;
                }


            }

            foreach (char c in result)
            {
                if (char.IsLetter(c) == true)
                {
                    if (char.IsUpper(c) == true)
                    {
                        int x = c - 'A';
                        if (x < key )
                        {
                            decodeChar = (char)((int)'A' + (26 - key  + x));
                            decode += decodeChar;
                        }
                        else
                        {

                            decodeChar = (char)((int)'A' - (key  - x));
                            decode += decodeChar;
                        }
                    }
                    else
                    {
                        int y = c - 'a';
                        if (y < key )
                        {
                            decodeChar = (char)((int)'a' + (26 - key  + y));
                            decode += decodeChar;
                        }
                        else
                        {
                            decodeChar = (char)((int)'a' - (key - y));
                            decode += decodeChar;
                        }
                    }
                }
                else
                {
                    decode += c;
                }


            }

            Console.WriteLine($"Văn bản Mã hóa: {result}");
            Console.WriteLine($"Văn bản Giải mã: {decode}");
            Console.ReadKey();
        }
        
        
        static void Bai13()
        {
            /*Tình huống thực tế: Hệ thống thẻ từ bãi đỗ xe thông minh tự động ghi nhận thời điểm xe vào và xe ra để
tính chính xác phí gửi xe dựa trên loại phương tiện và thời lượng đỗ.
Kiến thức trọng tâm: Kiểu DateTime, TimeSpan, enum (VehicleType), Math.Ceiling, decimal.
Yêu cầu bài toán:
• Tạo enum VehicleType { Motorbike, Car, Truck }.
• Nhập loại xe, thời gian xe vào (CheckIn) và thời gian xe ra (CheckOut) dạng 'yyyy-MM-dd HH:mm'.
• Tính thời gian đỗ TotalHours = (CheckOut - CheckIn).TotalHours. Làm tròn lên số giờ nguyên bằng
Math.Ceiling.
• Quy tắc tính giá:
• + Motorbike: 5,000 VNĐ cho 2 giờ đầu; Mỗi giờ tiếp theo +2,000 VNĐ/giờ.
• + Car: 20,000 VNĐ cho 2 giờ đầu; Mỗi giờ tiếp theo +10,000 VNĐ/giờ.
• + Truck: 50,000 VNĐ cho 2 giờ đầu; Mỗi giờ tiếp theo +25,000 VNĐ/giờ.
• Phụ phí qua đêm: Nếu thời gian đỗ gửi qua thời điểm 00:00 đêm, cộng thêm phụ phí 30,000 VNĐ.
• Xuất hóa đơn gửi xe chi tiết.
Ví dụ minh họa Input / Output:
--- INPUT ---
Loại xe: Car (Ô tô)
Giờ vào: 2026-08-21 08:15
Giờ ra: 2026-08-21 13:40
--- OUTPUT ---
Tổng thời gian đỗ: 5.42 giờ -> Tính phí: 6 giờ
Phí 2 giờ đầu: 20,000 VNĐ
Phí 4 giờ tiếp theo: 40,000 VNĐ (10,000 x 4)
TỔNG PHÍ ĐỖ XE: 60,000 VNĐ
*/
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            Console.Write("Loại xe ( Motorbike, Car, Truck): ");
            string vehicle = Console.ReadLine();

            Console.Write("Giờ vào (yyyy-MM-dd HH:mm): ");
            string v = Console.ReadLine();
            DateTime gioVao = DateTime.ParseExact(v, "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture);


            Console.Write("Giờ ra (yyyy-MM-dd HH:mm): ");
            string r = Console.ReadLine();
            DateTime gioRa = DateTime.ParseExact(r, "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture);

            TimeSpan span = gioRa - gioVao;
            double hours = span.TotalHours;
            double parkingHours = Math.Ceiling(hours);
            DateTime tomorrow = new DateTime(gioRa.Year, gioRa.Month, gioRa.Day).AddDays(1);
            int[] haiGioDau = { 5000, 20000, 50, 000 };
            int[] sauHaiGio = { 2000, 10000, 25000 };

            decimal phiHaiGio = 0;
            decimal phiSauHaiGio = 0;
            decimal phiQuaNgay = 0;
            decimal tongPhi = 0;
            int i = 0;
            switch (vehicle)
            {
                case "Motorbike":
                    phiHaiGio = haiGioDau[0];
                    phiSauHaiGio = (decimal)((parkingHours - 2) * sauHaiGio[0]);

                    if (gioRa >= tomorrow)
                    {
                        phiQuaNgay = 30000;
                    }
                    tongPhi = phiHaiGio + phiSauHaiGio + phiQuaNgay;
                    break;
                case "Car":
                    i = 1;
                    phiHaiGio = haiGioDau[1];
                    phiSauHaiGio = (decimal)((parkingHours - 2) * sauHaiGio[1]);
                    if (gioRa >= tomorrow)
                    {
                        phiQuaNgay = 30000;
                    }
                    tongPhi = phiHaiGio + phiSauHaiGio + phiQuaNgay;
                    break;
                case "Truck":
                    i = 2;
                    phiHaiGio = haiGioDau[2];
                    phiSauHaiGio = (decimal)((parkingHours - 2) * sauHaiGio[2]);
                    if (gioRa >= tomorrow)
                    {
                        phiQuaNgay = 30000;
                    }
                    tongPhi = phiHaiGio + phiSauHaiGio + phiQuaNgay;
                    break;
            }
            Console.WriteLine($"Tổng thời gian đỗ: {hours:N2} giờ -> Tính phí: {parkingHours} giờ");
            Console.WriteLine($"Phí 2 giờ đầu: {phiHaiGio} VNĐ");
            Console.WriteLine($"Phí {parkingHours - 2} tiếp theo : {phiSauHaiGio} VNĐ ({sauHaiGio[i]} x {parkingHours - 2})");
            Console.WriteLine($"Phụ phí qua đêm: {phiQuaNgay} VNĐ");
            Console.WriteLine($"TỔNG PHÍ ĐỖ XE: {tongPhi} VNĐ");


            Console.ReadKey();
        }

        //Bài 14 chưa hiểu phép tính trong check;
        static void Bai14()
        {/*Tình huống thực tế: Trong các ứng dụng nhận dữ liệu từ người dùng hoặc file ngoại vi, dữ liệu nhập vào có
thể không phải là số hợp lệ hoặc vượt quá khả năng lưu trữ của kiểu dữ liệu. Cần xử lý an toàn.
Kiến thức trọng tâm: Kiểu int.TryParse, long.TryParse, byte, short, int, long, khối checked { } và
OverflowException.
Yêu cầu bài toán:
• Mời người dùng nhập vào một chuỗi bất kỳ từ bàn phím.
BÀI TẬP LẬP TRÌNH C# | CHỦ ĐỀ: KIỂU DỮ LIỆU (DATA TYPES)
Trang 13 / 14
• Sử dụng int.TryParse để kiểm tra xem chuỗi có phải là một số nguyên hợp lệ hay không. Nếu không, thông
báo lỗi và yêu cầu nhập lại.
• Nếu hợp lệ, hãy kiểm tra xem giá trị đó có thể lưu trữ vừa trong kiểu dữ liệu nhỏ hơn như byte (0-255)
hoặc short (-32,768 đến 32,767) hay không.
• Thực hiện tính Tổng các chữ số cấu thành nên số nguyên đó.
• Thực hiện đoạn mã thử nghiệm tính tích lũy lũy thừa/nhân số đó trong khối checked { ... } để bắt ngoại lệ
OverflowException nếu xảy ra tràn số trong C#.
Ví dụ minh họa Input / Output:
--- INPUT ---
Nhập chuỗi số: 250
--- OUTPUT ---
Kiểm tra Parse: Thành công! Giá trị int = 250
Phù hợp kiểu byte: CÓ (Vừa vặn trong dải 0-255)
Tổng các chữ số: 2 + 5 + 0 = 7
Kiểm tra Tràn số: An toàn trong phạm vi int32.
*/
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;


            bool kq = false;
            string chuoi = "";
            int tong = 0;

            string kl = "Tổng các chữ số: ";
            do
            {
                Console.Write("Nhập chuỗi số: ");
                string chuoiSo = Console.ReadLine();
                if (int.TryParse(chuoiSo, out int result) == false)
                {
                    Console.WriteLine("Lỗi - Yêu cầu nhập lại");
                }
                else
                {
                    chuoi = chuoiSo;

                    kq = true;
                    Console.WriteLine($"Kiểm tra Parse: Thành công! Giá trị int = {chuoi}");
                }
            } while (kq == false);

            if (byte.TryParse(chuoi, out byte by) == true) { Console.WriteLine("Phù hợp kiểu byte: CÓ (Vừa vặn trong dải 0-255)"); }
            else { Console.WriteLine("Phù hợp kiểu byte: Không thể lưu trữ trong byte"); }

            if (byte.TryParse(chuoi, out byte f) == false)
            {
                if (short.TryParse(chuoi, out short shrt) == true) { Console.WriteLine("Phù hợp kiểu short: CÓ (Vừa vặn trong dải (-32,768 - 32,767)"); }
                else { Console.WriteLine("Phù hợp kiểu short: Không thể lưu trữ trong short"); }
            }
            for (int c = 0; c < chuoi.Length; c++)
            {
                tong += chuoi[c] - '0';

                if (c == chuoi.Length - 1)
                {
                    kl += $"{chuoi[c]} = ";
                }
                else
                {
                    kl += $"{chuoi[c]} + ";
                }
            }
            kl += $"{tong}";

            Console.WriteLine(kl);

            int tich = 1;
            int so = int.Parse(chuoi);
            try
            {
                checked
                {
                    for (int j = 1; j <= so; j++)
                    {
                        tich *= j;
                        Console.WriteLine("Kiểm tra Tràn số: An toàn trong phạm vi int32.");
                    }
                }
            }



            catch (OverflowException)
            {
                Console.WriteLine("Kiểm tra Tràn số: Tràn số trong phạm vi int32.");

            }
            Console.WriteLine(tich);
            Console.ReadKey();
        }


    }
}
           

