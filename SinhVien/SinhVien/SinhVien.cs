using System;

namespace SinhVien
{
    public class Sinhvien
    {
        private int ID;
        public int Id { get => ID; set => ID = value; }
        private String hotensinhvien;
        public String Hotensinhvien { get => hotensinhvien; set => hotensinhvien = value; }
        private DateTime datePicker;
        public DateTime DatePicker { get => datePicker; set => datePicker = value; }
        private String diachi;
        public String Diachi { get => diachi; set => diachi = value; }
        // tao ham sinh vien k co tham so
       // public Sinhvien()
       // {

     //   }
        // tao ham sinh vien co tham so
        public Sinhvien(int Id, String hotensinhvien, DateTime datePicker, String diachi)
        {
            ID = Id;
            Hotensinhvien = hotensinhvien;
            DatePicker = datePicker;
            Diachi = diachi;
        }
    }
}
