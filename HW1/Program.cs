using System.Text;

namespace _12425TN_11225359_NguyenThienNhan_HW1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Đề bài: Viết chương trình có nhiệm vụ
            in ra màn hình thông tin cá nhân của bạn: Họ tên, mã sinh viên, lớp, username tài khoản github
            đã mở, địa chỉ email.Thông tin cần ghi theo đúng thứ tự đó, giữa hai thông tin có đúng 1 dấu
            tab('\t').Đẩy bài làm lên github.com theo quy trình như đã hướng dẫn ở trên.*/
            // Bài làm
            Console.OutputEncoding = Encoding.UTF8;         // Định dạng đầu ra của dữ liệu
            
            // In ra màn hình thông tin đề bài yêu cầu
            Console.WriteLine("Nguyễn Thiện Nhân\t11225359\t12425TN\tNhannt-15907\tntnhan.sr7055938@gmail.com");
        }
    }
}
