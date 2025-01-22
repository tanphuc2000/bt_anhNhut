using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinhVien
{
    public class SinhVien
    {
        private int ID;
        public int Id { get =>ID; set =>ID = value; }
        private String hotensinhvien;
        public String Hotensinhvien { get => hotensinhvien;set=>hotensinhvien = value; }
        private DateTime datePicker;
        public DateTime DatePicker { get=>datePicker; set => datePicker = value; }
        private String diachi;
        public String Diachi { get => diachi; set => diachi = value; }
        // tao ham sinh vien k co tham so
        public SinhVien() { 
        }
        // tao ham sinh vien co tham so
        public SinhVien(int ID, String hotensinhvien, DateTime datePicker, String Diachi)
        {
            ID = Id;
            Hotensinhvien= Hotensinhvien;
            DatePicker = datePicker;
            Diachi = diachi;
        }
    }
}
