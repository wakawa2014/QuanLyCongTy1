using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace QuanLyCongTy
{
    class Program
    {
        //Bam Ctrl+F5 de chay.

        List<Employer> _employers = new List<Employer>();
        List<Manager> _managers = new List<Manager>();

        static void Main(string[] args)
        {

            Program program = new Program();
            program.MainMenu();

            Console.ReadKey();
        }

        public void MainMenu()
        {
            //Console.Clear();
            Console.WriteLine("\n1. Them Employer, manager.");
            Console.WriteLine("2. Thong ke so Employer, manager.");
            Console.WriteLine("3. Thong ke danh sach Manager.(ten, tuoi, so nguoi...).");
            Console.WriteLine("4. Hien thi thong tin nhan vien theo ma.\n");
            switch (Console.ReadKey().Key)
            {
                case ConsoleKey.D1:
                    Menu1();
                    break;
                case ConsoleKey.D2:
                    Menu2();
                    break;
                case ConsoleKey.D3:
                    Menu3();
                    break;
                case ConsoleKey.D4:
                    Menu4();
                    break;
            }
        }
        private void Menu1()
        {
            //Console.Clear();
            Console.WriteLine("\n0. Quay lai.");
            Console.WriteLine("1. Them Employer.");
            Console.WriteLine("2. Them Manager.\n");

            switch (Console.ReadKey().Key)
            {
                case ConsoleKey.D1:

                    if (_managers.Count < 1)
                    {
                        Console.WriteLine("\nChua co Manager nao!\nMoi nhap manager truoc!");
                        goto NhapManager;
                    }

                    Employer employer = new Employer();
                    employer.NhapDuLieu();
                    _employers.Add(employer);
                    ChonManager(employer);

                    Menu1();
                    break;

                case ConsoleKey.D2:
                    NhapManager:

                    Manager manager = new Manager();
                    manager.NhapDuLieu();
                    _managers.Add(manager);

                    Menu1();
                    break;
                case ConsoleKey.D0:
                    MainMenu();
                    break;

            }
        }
        private void Menu2()
        {
            Console.WriteLine("\nSo Manager la: " + _managers.Count);
            Console.WriteLine("\nSo Employer la: " + _employers.Count);
            MainMenu();
        }
        private void Menu3()
        {
            for (int i = 0; i < _managers.Count; i++)
            {
                Console.WriteLine("\nManger thu " + i + " la: ");
                _managers[i].XemThongTin();
                Console.WriteLine("\tSo nguoi quan ly la: " + _managers[i].Employers.Count);
            }
            MainMenu();
        }
        private void Menu4()
        {
            Console.WriteLine("\nMoi nhap ma:");
            string ma = Console.ReadLine();
            int count = 0;

            foreach (var item in _employers)
            {
                if (ma == item.Ma)
                {
                    item.XemThongTin();
                    count++;
                }
            }
            foreach (var item in _managers)
            {
                if (ma == item.Ma)
                {
                    item.XemThongTin();
                    count++;
                }
            }
            if (count == 0)
                Console.WriteLine("Khong tim thay nhan vien nao co ma: " + ma);
            MainMenu();
        }

        private void ChonManager(Employer employer)
        {

            Console.Write("\nChon manager cho: " + employer.Ten);
            for (int i = 0; i < _managers.Count; i++)
            {
                Console.WriteLine("\n" + i + ". " + _managers[i].Ten);
            }

            nhap:
            char j = Convert.ToChar(Console.ReadLine());

            int a = (int)Char.GetNumericValue(j);
            //Console.Write("\n" + a);
            if (a < 0 || a > _managers.Count - 1)
            {
                Console.Write("\nKhong co Manager nao nhu vay! Moi nhap lai!");
                goto nhap;
            }

            _managers[a].Employers.Add(employer);
            Console.WriteLine("\nDa cho Manager: " + _managers[a].Ten + " quan ly: " + employer.Ten);
        }

    }
}
