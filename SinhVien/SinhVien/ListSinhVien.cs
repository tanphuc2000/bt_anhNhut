using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinhVien
{
    public class ListSinhVien
    {
       private static ListSinhVien instance;
        // List<Sinhvien> listSinhVien;
        public static List<Sinhvien> listSinhVien;
        public static ListSinhVien Instance { 
            get
            {
                if (instance == null)
                    instance = new ListSinhVien();
                  return instance;
             }
          
            set => instance  = value;
        }
        public List<Sinhvien> ListSinhVien2 { get => listSinhVien; set => listSinhVien = value; }
        public ListSinhVien()
        {
            listSinhVien=new List<Sinhvien>();
            listSinhVien.Add(new Sinhvien(1,"Tan Phuc", new DateTime(2000,3,14), "Ho Chi Minh city"));
            listSinhVien.Add(new Sinhvien(2,"Chi Luan", new DateTime(2000,3,7), "Ca Mau province"));
            listSinhVien.Add(new Sinhvien(3, "Hoang Phuc", new DateTime(1999,3,5), "Dong Thap province"));
            listSinhVien.Add(new Sinhvien(4, "Ngoc Toi", new DateTime(2000,9,4), "Binh Thuan province"));
            listSinhVien.Add(new Sinhvien(5,"Nguyen Thuc", new DateTime(1997,6,4),"An Giang province"));
        }
    }
}
 