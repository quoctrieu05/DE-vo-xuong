using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DE_vo_xuong
{
    internal class SinhVienUD:SinhVIEN
    {
        private int KihocHtai;
        public SinhVienUD()
        {
            
        }
        public SinhVienUD(string ma, string ten, int nam, double diem, int kihoc) : base(ma, ten, nam, diem)
        {
            KihocHtai= kihoc;
        }
        public override void InThongTin() {
            base.InThongTin();
            Console.WriteLine($"Kihoc:{this.KihocHtai}");

        }
    }
}
