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
    public partial class FrmXuatKho : Form
    {
        DataTable dtbkho = new DataTable();
        Kho kho = Kho.Instance;
        public FrmXuatKho()
        {
            InitializeComponent();
            Reload();
        }
        private void Reload()
        {
            dtbkho = kho.getXuatKho();
            dgvXuatKho.DataSource = dtbkho;
        }

        private void dgvXuatKho_Click(object sender, EventArgs e)
        {
            string id = dgvXuatKho.CurrentRow.Cells[0].Value.ToString();
            string name = dgvXuatKho.CurrentRow.Cells[1].Value.ToString();
            string type = dgvXuatKho.CurrentRow.Cells[2].Value.ToString();
            string count = dgvXuatKho.CurrentRow.Cells[3].Value.ToString();
            string cost = dgvXuatKho.CurrentRow.Cells[4].Value.ToString();
            string pro = dgvXuatKho.CurrentRow.Cells[5].Value.ToString();
            FrmLayHang f = new FrmLayHang(id, name, type, count, cost, pro);
            f.ShowDialog(); Reload();
        }

        private void button_Refresh_Click(object sender, EventArgs e)
        {
            Reload();
        }
    }
    
}
