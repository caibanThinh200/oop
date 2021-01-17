using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class CongNghe
    {
        private string maSp;
        private string tenSp;
        private int gia;
        public CongNghe()
        {

        }
        public CongNghe(string maSp, string tenSp, int gia)
        {
            this.MaSp = maSp;
            this.TenSp = tenSp;
            this.Gia = gia;
        }

        public string MaSp { get => maSp; set => maSp = value; }
        public string TenSp { get => tenSp; set => tenSp = value; }
        public int Gia { get => gia; set => gia = value; }

        public virtual void Input()
        {
            Console.WriteLine("Nhap ma sp");
            maSp = Console.ReadLine();
            Console.WriteLine("Nhap ten sp");
            tenSp = Console.ReadLine();
            Console.WriteLine("Nhap gia");
            gia = int.Parse(Console.ReadLine());
        }

         public virtual void Output()
        {
            Console.WriteLine("Thong tin sp :");
            Console.WriteLine("Ma sp: " + maSp);
            Console.WriteLine("Ten sp: " + tenSp);
            Console.WriteLine("Gia sp: " + gia);
        }

        public virtual void BaoTri()
        {
            Console.WriteLine("Bao tri san pham " + tenSp + "");
        }
    }
}
