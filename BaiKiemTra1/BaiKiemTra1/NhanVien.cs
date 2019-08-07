using System;
using System.Collections.Generic;
using System.Text;

namespace BaiKiemTra1
{
    class NhanVien
    {
        string hoTen;
        DateTime namSinh;
        string goiTinh;
        long soCMND;
        string maNV;

        public string HoTen { get => hoTen; set => hoTen = value; }
        public DateTime NamSinh { get => namSinh; set => namSinh = value; }
        public string GoiTinh { get => goiTinh; set => goiTinh = value; }
        public long SoCMND { get => soCMND; set => soCMND = value; }
        public string MaNV { get => maNV; set => maNV = value; }

        public virtual void Nhap() { 
            Console.WriteLine("Nhap Ho ten:");
            HoTen = Console.ReadLine();
            Console.WriteLine("Nhap nam sinh:");
            NamSinh = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Nhap Goi tinh:");
            GoiTinh = Console.ReadLine();
            Console.WriteLine("Nhap so CMND:");
            SoCMND = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap ma nhan vien:");
            MaNV = Console.ReadLine();
        }

        public virtual void Xuat()
        {
            Console.WriteLine("Ho ten: {0}", HoTen);
            Console.WriteLine("Nam sinh: {0}", NamSinh);
            Console.WriteLine("Goi tinh: {0}", GoiTinh);
            Console.WriteLine("So CMND: {0}", SoCMND);
            Console.WriteLine("Ma nhan vien: {0}", MaNV);
        }
    }
}
