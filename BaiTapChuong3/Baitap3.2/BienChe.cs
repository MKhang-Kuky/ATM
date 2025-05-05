using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitap3._2
{
    class BienChe :Nguoi
    {
        //cac bien thanh vien
        float HeSoLuong;
        float HeSoPhuCap;
        //cac thuoc tinh
        public float HSLuong
        {
            get { return  HeSoLuong;}
            set { HeSoLuong = value; }
        }
        public float HSPhuCap
        {
            get { return HeSoPhuCap; }
            set { HeSoPhuCap = value; }
        }
        // Cac phuong thuc
        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Nhap he so luong: ");
            HeSoLuong = System.Convert.ToSingle(Console.ReadLine());
            Console.Write("Nhap he so phu cap: ");
            HeSoPhuCap = System.Convert.ToSingle(Console.ReadLine());
        }
        public void xuat()
        {
            Console.Write("Ho Ten: {0}", cHoTen);
            Console.Write("Ma So: {0}", cMaSo);
            
        }
        public override void TinhLuong()
        {
            fLuong = 1000 * ( 1 + HeSoLuong +HeSoPhuCap);
            Console.Write("Luong: {0}", fLuong);
        }
       
        
    }
}
