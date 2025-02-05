using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SinhVien
{
    public partial class Form1 : Form
    {

        ListSinhVien lstSinhVien;
        public Form1()
        {
            InitializeComponent();
           /* userClassBindingSource.DataSource = GetUserClassData.GetAll();   */
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lstSinhVien = new ListSinhVien();

            dataGridView1.DataSource = lstSinhVien.ListSinhVien2;
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Times new Roman", 12, FontStyle.Bold);
            /*   if(File.Exists("hotensinhvien1.txt"))
               {
                   using (StreamReader SR = new StreamReader("hotensinhvien1.txt"))
                   {
                       txtBxhotensinhvien.Text = SR.ReadLine();
                   }
               } */

            ColumnSelector sel = new ColumnSelector(dataGridView1);
        //    sel.Columns.Add();
             sel.MaxHeight = 100;
             sel.MinHeight = 100;
            try
            {
                DataGridViewLayoutSettings.ReadDataGridViewSettings(dataGridView1);
            }
            catch(Exception ex)
            {

            }

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Sinhvien newSV = new Sinhvien(int.Parse(txtBxID.Text), txtBxhotensinhvien.Text, DateTime.Parse(txtBxdatePicker.Text), txtBxdiachi.Text);
            lstSinhVien.ListSinhVien2.Add(newSV);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = lstSinhVien.ListSinhVien2;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Click(object sender, EventArgs e)
        {
            /*  this.Hide();
              Form2 form2 = new Form2();
              form2.ShowDialog();
              this.Show(); */
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {
            //this.Hide();
            //Form2 form2 = new Form2();
            //form2.ShowDialog();
            //this.Show();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            int col = e.ColumnIndex;
            int row = e.RowIndex;
            Sinhvien rowClick = lstSinhVien.ListSinhVien2[row];
            Form2 newFrom = new Form2(rowClick);
            newFrom.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
         /*  if ((txtBxhotensinhvien.Text == "Phuc") && (txtBxdatePicker.Text == "14/3/2000"))
            {
                using (StreamWriter sw = new StreamWriter(txtBxdatePicker.Text))
                {
                    sw.WriteLine(txtBxdatePicker.Text);
                }
            }*/

         if((txtBxID.Text == "1") && (txtBxhotensinhvien.Text == "Phuc")
                && (txtBxdatePicker.Text == "14/3/2000")
                && (txtBxdiachi.Text == "Ho Chi Minh city"))
            {
                using (StreamWriter sw = new StreamWriter("txtBxID.txt,txtBxhotensinhvien.txt," +
                    "txtBxdatePicker.txt,txtBxdiachi.txt"))
                {
                    sw.WriteLine(txtBxID.Text,txtBxhotensinhvien.Text,txtBxdatePicker.Text,
                        txtBxdiachi.Text);
                    sw.Close();
                }
                this.Hide();
                Form2 form = new Form2();
                form.Show();
            }

         else
            {
                MessageBox.Show("Wrong!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                txtBxID.Clear();
                txtBxhotensinhvien.Clear();
                txtBxdatePicker.Clear();
                txtBxdiachi.Clear();
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            DataGridViewLayoutSettings.WriteDataGridViewSettings(dataGridView1);

        }
    }
}
