using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SinhVien
{
    public partial class Form2 : Form
    {
        Sinhvien dataFromList;
        public Form2()
        {
            InitializeComponent();
        }

        public Form2(Sinhvien data)
        {
            InitializeComponent();
            dataFromList = data;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label1.Text = dataFromList.Hotensinhvien;
            label2.Text = dataFromList.DatePicker.ToString();
            label3.Text = dataFromList.Diachi;
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
    