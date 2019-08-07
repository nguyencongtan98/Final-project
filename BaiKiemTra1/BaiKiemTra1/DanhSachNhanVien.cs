using System;
using System.Collections.Generic;
using System.Text;

namespace BaiKiemTra1
{
    class DanhSachNhanVien
    {
        Dictionary<string, NhanVien> list;

        internal Dictionary<string, NhanVien> List { get => list; set => list = value; }

        public DanhSachNhanVien()
        {
            List = new Dictionary<string, NhanVien>();
        }

        public void Nhap()
        {
            char c = ' ';
            do
            {
                Console.WriteLine("---------------------------------------------------------------");
                Console.WriteLine("Nhap vao b de nhap nhan vien bien che hoac h nhan vien hop dong");
                Console.WriteLine("Nhap t de tim nhan vien");
                Console.WriteLine("Nhap x de xoa nhan vien");
                Console.WriteLine("Nhap l de in tong quy luong");
                Console.WriteLine("Nhap i de In nhan vien");
                Console.WriteLine("Nhap e de thoat chuong trinh\n");
                c = char.Parse(Console.ReadLine().ToLower());
                switch (c)
                {
                    case 'b':
                            Console.WriteLine("Moi nhap nhan vien bien che:\n ");
                            NhanVienBienChe nvbc = new NhanVienBienChe();
                            nvbc.Nhap();
                            List.Add(nvbc.MaNV, nvbc);
                            break;
                    case 'h':
                            Console.WriteLine("Moi nhap nhan vien hop dong:\n ");
                            NhanVienHopDong nvhd = new NhanVienHopDong();
                            nvhd.Nhap();
                            List.Add(nvhd.MaNV, nvhd);
                            break;
                    case 't':
                             Console.WriteLine("Nhap ma nhan vien can Tim: ");
                             NhanVien nv = Tim(Console.ReadLine());
                             if (nv != null)
                             {
                                Console.WriteLine("Nhan vien can tim la:\n");
                                nv.Xuat();
                             }
                             break;
                    case 'x':
                            Console.WriteLine("Nhap ma nhan vien can xoa: ");
                            string maNV = Console.ReadLine();
                            Xoa(maNV);
                            Console.WriteLine("Da xoa nhan vien co maNV: {0} ",maNV);
                            In();
                            break;
                    case 'l':
                            Console.WriteLine("Tong luong: {0}", TongQuyLuong()); 
                            break;
                    case 'i':
                            In();
                            break;

                }
            } while (c != 'e');
        }

        public void In()
        {
            foreach (NhanVien nv in List.Values)
            {
                nv.Xuat();
            }
        }

        public double TongQuyLuong()
        {
            double tong =0;
            foreach (NhanVien nv in List.Values)
            {
                if (nv is NhanVienBienChe)
                {
                    tong = tong + ((NhanVienBienChe)nv).ThucLich() + ((NhanVienBienChe)nv).PhucCap();
                   
                }else
                {
                    tong = tong + ((NhanVienHopDong)nv).ThucLich() + ((NhanVienHopDong)nv).PhucCap();
                }
            }
            return tong;
        }

        public NhanVien Tim(string maNV)
        {
            if (this.List.ContainsKey(maNV))
                return this.List[maNV];
            else return null;
        }

        public void Xoa(string maNV)
        {
            List.Remove(maNV);
        }

    }
}
