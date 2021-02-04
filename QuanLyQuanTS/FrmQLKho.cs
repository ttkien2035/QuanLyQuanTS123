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
    public partial class FrmQLKho : Form
    {
        DataTable dtbkho = new DataTable();
        Kho kho = Kho.Instance;
        public FrmQLKho()
        {
            InitializeComponent();
        }

        private void FrmQLKho_Load(object sender, EventArgs e)
        {
            Reload();


        }

        private void Reload()
        {
            dtbkho = kho.getKho();
            dataGridViewKho.DataSource = dtbkho;
        }


        private void buttonEx_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonReload_Click_1(object sender, EventArgs e)
        {
            Reload();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            FormThemKho f = new FormThemKho();
            f.ShowDialog(); Reload();
        }

        private void dataGridViewKho_Click(object sender, EventArgs e)
        {
            string id = dataGridViewKho.CurrentRow.Cells[0].Value.ToString();
            string name = dataGridViewKho.CurrentRow.Cells[1].Value.ToString();
            string type = dataGridViewKho.CurrentRow.Cells[2].Value.ToString();
            string count = dataGridViewKho.CurrentRow.Cells[3].Value.ToString();
            string cost = dataGridViewKho.CurrentRow.Cells[4].Value.ToString();
            DateTime date = Convert.ToDateTime(dataGridViewKho.CurrentRow.Cells[5].Value.ToString());
            string pro = dataGridViewKho.CurrentRow.Cells[7].Value.ToString();
            FormEditRemoveKho f = new FormEditRemoveKho(id, name, type, count, cost, date.ToString("yyyy-MM-dd"), pro);
            f.ShowDialog(); Reload();
        }

        private void textBoxsearch_KeyUp(object sender, KeyEventArgs e)
        {
            dataGridViewKho.DataSource = kho.getKhowithsearch(textBoxsearch.Text);
        }

        private void buttonAdd_Click_1(object sender, EventArgs e)
        {
            FormThemKho f = new FormThemKho();
            f.ShowDialog(); Reload();
        }

        private void textBoxsearch_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
