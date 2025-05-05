using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaiKhoanNganHang
{
    class Program
    {
        static void Main(string[] args)
        {
            TaiKhoanNganHang TK = new TaiKhoanNganHang();
            TK.sTK = 100;
            TK.tTK = "Nguyen Van A";
            TK.sdTK = 200;
            Console.Write("So Tien Can Gui: ");
            int n = System.Convert.ToInt32(Console.ReadLine());
            TK.guiTien(n);
            Console.WriteLine();
            Console.Write("So Tien Can rut: ");
            float m = System.Convert.ToInt32(Console.ReadLine());
            TK.rutTien(m);
            Console.Read();
        }
    }
}