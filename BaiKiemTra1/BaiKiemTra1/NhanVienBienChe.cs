using System;
using System.Collections.Generic;
using System.Text;

namespace BaiKiemTra1
{
    class NhanVienBienChe : NhanVien,ILUONG
    {
        double heSoLuong;
        double luongCoBan;

        public double HeSoLuong { get => heSoLuong; set => heSoLuong = value; }
        public double LuongCoBan { get => luongCoBan; set => luongCoBan = value; }

        public double PhucCap()
        {
            return LuongCoBan / 10;
        }

        public double ThucLich()
        {
            return HeSoLuong * LuongCoBan + PhucCap();
        }

        public override void Nhap()
        {
            base.Nhap();
            Console.WriteLine("Nhap he so luong: ");
            HeSoLuong = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap muc luong: ");
            LuongCoBan = double.Parse(Console.ReadLine());
        }

        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine("He so luong: {0}", HeSoLuong);
            Console.WriteLine("Luong co ban: {0}\n----------------------------------", LuongCoBan);
        }
    }
}
