using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaiKhoanNganHang
{
    class TaiKhoanNganHang
    {
        //Khai báo biến thành viên
        int soTK;
        string tenTK;
        float soDuTK;
        //Các thuộc tính
        public int sTK
        {
            get { return soTK; }
            set { soTK = value; }
        }
        public string tTK
        {
            get { return tenTK; }
            set { tenTK = value; }
        }
        public float sdTK
        {
            get { return soDuTK; }
            set { soDuTK = value; }
        }
        //Các phương thức
       
        public void guiTien(float soTien)
        {
            if (soTien <= 0)
            {
                Console.WriteLine("Loi nap tien");
            }
            else
            {
                soDuTK += soTien;
            }
              
             Console.Write("So tien trong tai khoan cua ban la: " +soDuTK);
        }
        public void rutTien(float soTien)
        {
            if (soTien > soDuTK || soTien < 0)
            {
                Console.Write("Loi rut tien");
            }
            else
            {
                 soDuTK -= soTien;
            }
            Console.Write("So tien trong tai khoan cua ban la: " + soDuTK);
        }
        public void chuyenKhoan(int SoTK, string tenTK, float soSuTK)
        {
            SoTK = sTK;
            tenTK = tTK;
            soDuTK = sdTK;
        }
    }
}
