using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCongTy
{
    class Employer
    {
        public enum PhongBan
        {
            Production,
            Accounting,
            Sales
        }
        public enum Role
        {
            SalesEmployer = 0,
            Developper = 1,
            Accounting = 2
        }
        public string Ma;
        public string Ten;
        public string Tuoi;
        public PhongBan Phong;
        public Role VaiTro;

        public void NhapDuLieu()
        {
            Console.WriteLine("\n\tNhap ma: ");
            Ma = Console.ReadLine();
            Console.WriteLine("\n\tNhap ten: ");
            Ten = Console.ReadLine();
            Console.WriteLine("\n\tNhap tuoi: ");
            Tuoi = Console.ReadLine();
            Console.WriteLine("\n\tNhap phong ban: ");
            Phong = NhapPhongBan();
            Console.WriteLine("\n\tNhap vai tro: ");
            VaiTro = NhapVaiTro();

            Console.WriteLine("\nDa nhap: ");
            XemThongTin();
        }
        private Role NhapVaiTro()
        {
            ConsoleKeyInfo key;
            Console.WriteLine("\nSalesEmployer = 0");
            Console.WriteLine("Developper = 1");
            Console.WriteLine("Accounting = 2");

            nhap:
            key = Console.ReadKey();

            if (key.Key != ConsoleKey.D0 && key.Key != ConsoleKey.D1 && key.Key != ConsoleKey.D2)
            {
                Console.WriteLine("Nhap sai! Moi nhap lai!");
                goto nhap;
            }

            if (key.Key == ConsoleKey.D0)
                return Role.SalesEmployer;
            if (key.Key == ConsoleKey.D1)
                return Role.Developper;
            if (key.Key == ConsoleKey.D2)
                return Role.Accounting;

            return 0;
        }
        private PhongBan NhapPhongBan()
        {
            ConsoleKeyInfo key;
            Console.WriteLine("\nProduction = 0");
            Console.WriteLine("Accounting = 1");
            Console.WriteLine("Sales = 2");

            nhap:
            key = Console.ReadKey();

            if (key.Key != ConsoleKey.D0 && key.Key != ConsoleKey.D1 && key.Key != ConsoleKey.D2)
            {
                Console.WriteLine("\nNhap sai! Moi nhap lai!");
                goto nhap;
            }

            if (key.Key == ConsoleKey.D0)
                return PhongBan.Production;
            if (key.Key == ConsoleKey.D1)
                return PhongBan.Accounting;
            if (key.Key == ConsoleKey.D2)
                return PhongBan.Sales;

            return 0;
        }
        public void XemThongTin()
        {
            Console.WriteLine("\n\tMa: " + Ma);
            Console.WriteLine("\tTen: " + Ten);
            Console.WriteLine("\tTuoi: " + Tuoi);
            Console.WriteLine("\tPhong Ban: " + Phong.ToString());
            Console.WriteLine("\tVai tro: " + VaiTro.ToString());
        }
    }

}
