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
        private List<SinhVien> list;
        public static List<SinhVien> listSinhVien;
        public static ListSinhVien Instance
        {
            get
            {
                if (instance == null)
                    instance = new ListSinhVien();
                return instance;
            }

            set => instance = value;
        }
        public List<SinhVien> ListSinhVien2 { get => listSinhVien; set => listSinhVien = value; }
        public ListSinhVien()
        {
            listSinhVien = new List<SinhVien>();
            listSinhVien.Add(new SinhVien(1,"Tan Phuc", new DateTime(2000,3,14),"Ho Chi Minh city"));
            listSinhVien.Add(new SinhVien(2,"Chi Luan", new DateTime(2000,3,7),"Ca Mau province"));
        }
    }
}
