using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DE_vo_xuong
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }
        static void Menu()
        {
            SinhVienService sinhvienQL = new SinhVienService();   
            int chon = -1;
                do
            {
                Console.WriteLine("------------SinhVien-------------");
                Console.WriteLine("1.nhap thong tin sinh vien");
                Console.WriteLine("2.Xuat thong tin ");
                Console.WriteLine("3.Xuat danh sach cac sinh vien co ve vip  HappyBee(Diem>=8}");
                Console.WriteLine("4.Xoa nhung sinh vien khong duoc tham gia (Tuoi>25)");
                Console.WriteLine("5.Ke thua");
                Console.WriteLine("0.Thoat");
                Console.WriteLine("Moi nhap chuc nang:");
                chon=int.Parse(Console.ReadLine());
                switch(chon) {
                    case 1:
                        sinhvienQL.NhapSV();

                        break; case 2:
                        sinhvienQL.XuatDanhSach();
                        break;
                        case 3:
                        sinhvienQL.XUatSinhVienHappyBee();
                        break;
                        case 4:
                        sinhvienQL.XoaThongTin();

                    break;
                        case 5:
                        CN5(sinhvienQL);
                        
                       
                            break;
                        default: Console.WriteLine("CHi duoc nhap tu 0 den 5");
                        break;
                }

            } while(chon!=0);
        }
        static void CN5(SinhVienService sinhvienQL)
        {
            Console.WriteLine("Moi nhap Ma:");
            string ma = Console.ReadLine();
            Console.WriteLine("Moi nhap ten:");
            string ten = Console.ReadLine();
            Console.WriteLine("Moi nhap nam");
            int nam = int.Parse(Console.ReadLine());
            Console.WriteLine("Diem:");
            double diem = double.Parse(Console.ReadLine());
            Console.WriteLine("Ki hoc hien tai:");
            int ki=int.Parse(Console.ReadLine());
          SinhVienUD   sinhvienUD =new SinhVienUD(ma,ten,nam,diem,ki);
            sinhvienUD.InThongTin();


          
        }
    }
}
