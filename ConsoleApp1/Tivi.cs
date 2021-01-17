using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Tivi:CongNghe
    {
        private int size;

        public Tivi(int size, string maSp, string tenSp, int gia) : base(maSp, tenSp, gia)
        {
            this.Size = size;
        }

        public Tivi()
        {

        }

        public int Size { get => size; set => size = value; }

        public void moTivi()
        {
            Console.WriteLine("Mo ti vi " + TenSp + " co kich thuoc " + size + "");
        }

        public override void Input()
        {
            base.Input();
            Console.WriteLine("Nhập kich thuoc:");
            size = int.Parse(Console.ReadLine());
        }

        public override void Output()
        {
            base.Output();
            Console.WriteLine("Kich thuoc tivi: " + size);
        }

        public override void BaoTri()
        {
            base.BaoTri();
        }
        public void muaTivi()
        {
            
            Console.WriteLine("Moi nhap khuyen mai");
            string km = Console.ReadLine();
            Console.Write("Mua tivi ");
            if (km == "1")
            {
                Console.WriteLine("Dinh kem loa ngoai");
            }
            if (km == "2")
            {
                Console.WriteLine("Dinh kem chan ghe");
            }
            if(km == "3")
            {
                Console.WriteLine("Khuyen mai ca 2");
            }
        }
    }
}
