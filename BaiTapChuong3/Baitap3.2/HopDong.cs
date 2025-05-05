using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitap3._2
{
    class HopDong : Nguoi
    {
        float TienCong;
        float NgayCong;
        float HeSoVuotGio;
        public float tiencong
        {
            get { return TienCong; }
            set { TienCong = value; }
        }
        public float ngaycong
        {
            get { return NgayCong; }
            set { NgayCong = value; }
        }
        public float hesovuotgio
        {
            get { return HeSoVuotGio; }
            set { HeSoVuotGio = value; }
        }
        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Tien cong: ");
            TienCong = System.Convert.ToSingle(Console.ReadLine());
            Console.Write("Ngay cong: ");
            NgayCong = System.Convert.ToSingle(Console.ReadLine());
            Console.Write("He so vuot gio: ");
            HeSoVuotGio = System.Convert.ToSingle(Console.ReadLine());
        }
       public void xuat(){

       
            Console.Write("Ho Ten: {0}", cHoTen);
            Console.Write("Ma So: {0}", cMaSo);
            Console.Write("Tien Cong: {0}", TienCong);
            Console.Write("Ngay Cong: {0}", NgayCong);
            Console.Write("He so vuot gio: {0}", HeSoVuotGio);

        }
        public override void TinhLuong()
        {
             fLuong = TienCong * NgayCong *(1 + HeSoVuotGio);
             Console.Write("Luong: {0}", fLuong);
        }
    }
}
