using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            List<Tivi> tvs = new List<Tivi>();
            List<ViTinh> vts = new List<ViTinh>();
            Tivi tv1 = new Tivi();
            
            tvs.Add(tv1);

            Tivi tv2 = new Tivi();
            
            tvs.Add(tv2);

            Tivi tv3 = new Tivi();
            
            tvs.Add(tv3);

            ViTinh vt1 = new ViTinh();
        
            vts.Add(vt1);

            ViTinh vt2 = new ViTinh();
         
            vts.Add(vt2);

            ViTinh vt3 = new ViTinh();
         
            vts.Add(vt3);
            Console.WriteLine("Ban muon them sp cong nghe ? (Nhap T neu chon tivi)");
            string check = Console.ReadLine();
            if (check == "T")
            {
                foreach (Tivi tv in tvs)
                {
                    Console.WriteLine("Moi nhap sp tivi:");
                    tv.Input();

                }
                List<Tivi> list = tvs.OrderByDescending(size => size.Size).ToList();
               foreach(Tivi tv in list)
                {
                    tv.Output();
                }
            }
            
            else
            {
                foreach(ViTinh vt in vts)
                {
                    Console.WriteLine("Moi nhap sp vi tinh:");
                    vt.Input();
                    vt.Output();
                }
            }
            */
            Tivi tv = new Tivi();
            tv.muaTivi();
        }
    }
}
