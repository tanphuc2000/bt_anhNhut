using System.Windows.Forms;

namespace SinhVien
{
    internal class ColumnSelector
    {
        private DataGridView dataGridView1;

        public ColumnSelector(DataGridView dataGridView1)
        {
            this.dataGridView1 = dataGridView1;
        }

        public object Columns { get; internal set; }
        public int MinHeight { get; internal set; }
        public int MaxHeight { get; internal set; }
    }
}
