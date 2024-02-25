using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DE_vo_xuong
{
    internal class SinhVIEN
    {
        private string maSV;
        private string TenSV;
        private int NamSinh;
        private double Diem;
        public SinhVIEN()
        {
                
        }
        public SinhVIEN(string masv,string ten,int nam,double diem)
        {
            maSV = masv;
            TenSV = ten;
            NamSinh = nam;
            Diem = diem;
            
        }
        public virtual void InThongTin()
        {
            Console.WriteLine($"Ma:{this.maSV} -Ten:{this.TenSV}- Nam:{this.NamSinh} -Diem:{this.Diem}");
        }
        public  double DiemSinhVIEN()
        {
            return this.Diem;
        }
        public int Tuoi()
        {
            return 2024 - this.NamSinh;
        }


    }
}
