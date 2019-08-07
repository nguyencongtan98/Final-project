using System;

namespace BaiKiemTra1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("......................KIEM TRA.........................");
            Console.WriteLine("Ten: Nguyen Cong Tan");
            Console.WriteLine("Lop: CS 414 SA");
            Console.WriteLine("MSSV: 2221123545");
            DanhSachNhanVien ds = new DanhSachNhanVien();
            ds.Nhap();
            Console.ReadLine();
        }
    }
}
