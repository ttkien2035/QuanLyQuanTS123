using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanTS
{
    public partial class FrmQLKhachHang : Form
    {
        Khach khach = Khach.Instance;
        string sort = "asc";
        public FrmQLKhachHang()
        {
            InitializeComponent();
        }

        private void FrmQLKhachHang_Load(object sender, EventArgs e)
        {
            Reload();
        }
        private void Reload()
        {
            dataGridViewKhach.DataSource = khach.getKhach();
            foreach (DataGridViewColumn column in dataGridViewKhach.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            dataGridViewKhach.DataSource = khach.getKhachwithsearch(textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonReload_Click(object sender, EventArgs e)
        {
            Reload();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridViewKhach.DataSource = khach.getKhachwithorder(ref sort);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormThemKhach f = new FormThemKhach();
            f.ShowDialog();Reload();
        }

        private void dataGridViewKhach_Click(object sender, EventArgs e)
        {
            string id = dataGridViewKhach.CurrentRow.Cells[0].Value.ToString();
            string name = dataGridViewKhach.CurrentRow.Cells[1].Value.ToString();
            DateTime date = Convert.ToDateTime(dataGridViewKhach.CurrentRow.Cells[2].Value.ToString());
            string phone = dataGridViewKhach.CurrentRow.Cells[3].Value.ToString();
            string point = dataGridViewKhach.CurrentRow.Cells[4].Value.ToString();
            string rank = dataGridViewKhach.CurrentRow.Cells[5].Value.ToString();
            FormEdiRemoveKhack f = new FormEdiRemoveKhack(id,phone,name,date.ToString("yyyy-MM-dd"), rank,point);
            f.ShowDialog();Reload();
        }
    }
}
