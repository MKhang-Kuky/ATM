using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitap3._2
{
    class Nguoi
        //Khai báo các biến thành viên
    {
            char[] HoTen = new char[50];
            char[] MaSo = new char[5];    
            float Luong;
            
            

        //Các thuộc tính 
        
            public char[] cHoTen
             {
                 get { return HoTen; }
                 set { HoTen = value; }
             }
            public char[] cMaSo
             {
                 get { return MaSo; }
                 set { MaSo = value; }
             } 
            public float fLuong
             {
                get { return Luong; }
                set { Luong = value; }
             }
        //Cac phuong thuc
            public virtual void Nhap( )
            {
                    Console.Write("Nhap ten: ");
                    HoTen = Console.ReadLine().ToCharArray();
                    Console.Write("Nhap ma so: ");
                    MaSo = Console.ReadLine().ToCharArray();
                   
                
            }
            public void Xuat()
            {
                Console.Write("ho ten: ");
                foreach (char c in HoTen)
                {
                    Console.Write(c);
                }
                Console.WriteLine();

                Console.Write("ma so: ");
                foreach (char c in MaSo)
                {
                    Console.Write(c);
                }
                Console.WriteLine();

               
            }
            public virtual void TinhLuong()
            {
                Luong = 0;
            }
    }
}
