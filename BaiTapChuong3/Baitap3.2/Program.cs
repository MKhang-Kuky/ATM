using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitap3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("NGƯỜI LAO ĐỘNG BIÊN CHẾ");
            BienChe BC1 = new BienChe();
            BC1.Nhap();
            BC1.Xuat();
            BC1.TinhLuong();
            Console.WriteLine();
            Console.WriteLine("NGƯỜI LAO ĐỘNG THEO HỢP ĐỒNG");
            HopDong HD1 = new HopDong();
            HD1.Nhap();
            HD1.Xuat();
            HD1.TinhLuong();

            Console.Read();

        }
    }
}
