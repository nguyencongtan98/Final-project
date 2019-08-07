using System;
using System.Collections.Generic;
using System.Text;

namespace BaiKiemTra1
{
    class NhanVienHopDong : NhanVien,ILUONG
    {
        double mucLuong;

        public double MucLuong { get => mucLuong; set => mucLuong = value; }

        public double PhucCap()
        {
            return MucLuong / 10;
        }

        public double ThucLich()
        {
            return MucLuong + PhucCap();
        }

        public override void Nhap()
        {
            base.Nhap();
            Console.WriteLine("Nhap muc luong: ");
            MucLuong = double.Parse(Console.ReadLine());
        }

        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine("He muc luong: {0}\n------------------------------------", MucLuong);
           
        }
    }
}
