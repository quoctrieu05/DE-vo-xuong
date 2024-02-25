using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DE_vo_xuong
{
    internal class SinhVienService
    {
        public List<SinhVIEN> DanhSachSV { get; set; }
        public SinhVienService()
        {
            DanhSachSV = new List<SinhVIEN>();
        }
        public void NhapSV()
        {
            int tieptuc = -1;
            do
            {
                Console.WriteLine("Moi nhap Ma:");
                string ma = Console.ReadLine();
                Console.WriteLine("Moi nhap ten:");
                string ten = Console.ReadLine();
                Console.WriteLine("Moi nhap nam");
                int nam = int.Parse(Console.ReadLine());
                Console.WriteLine("Diem:");
                double diem = double.Parse(Console.ReadLine());
                SinhVIEN sinhvien = new SinhVIEN(ma, ten, nam, diem);
                this.DanhSachSV.Add(sinhvien);
                Console.WriteLine("Muon nhap tiep khong (1-co/2-khong)");
                tieptuc=int.Parse(Console.ReadLine());
            } while (tieptuc==1);
            }
        public void XuatDanhSach()
        {
            foreach  (SinhVIEN sinhvien in this.DanhSachSV)
            {
                sinhvien.InThongTin();
            }
        }
        public void XUatSinhVienHappyBee() {
          
            foreach  (SinhVIEN item in this.DanhSachSV)
            {
                if (item.DiemSinhVIEN() >= 8)
                {
                    item.InThongTin();
                }
            }


        }
        public void XoaThongTin()
        {
          
            foreach (SinhVIEN item in this.DanhSachSV)
            {
                if (item.Tuoi() > 25)
                {
                    DanhSachSV.Remove(item);
                    item.InThongTin();
                }
                else item.InThongTin();
            }

        }
    }
}
