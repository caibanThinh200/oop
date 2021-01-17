using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class ViTinh:CongNghe
    {
        private int namSX;
        public ViTinh()
        {
           
        }
        public ViTinh(int namSX, string maSp, string tenSp, int gia) : base(maSp, tenSp, gia) 
        {
            this.NamSX = namSX;
        }

        public int NamSX { get => namSX; set => namSX = value; }

        public void suDung()
        {
            Console.WriteLine("Su dung may tinh " + TenSp + " san xuat tu nam " + NamSX + "");
        }

        public override void Input()
        {
            base.Input();
            Console.WriteLine("Nhap nam sx: ");
            namSX = int.Parse(Console.ReadLine());
        }

        public override void Output()
        {
            base.Output();
            Console.WriteLine("Nam sx : " + namSX);
        }

        public override void BaoTri()
        {
            base.BaoTri();
        }
    }
}
