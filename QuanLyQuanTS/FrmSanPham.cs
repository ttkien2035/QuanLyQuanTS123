using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyQuanTS.BS_Layer;

namespace QuanLyQuanTS
{
    public partial class FrmSanPham : Form
    {
        DataTable dtbFood = new DataTable();
        BLFood food = new BLFood();
        public FrmSanPham()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmSanPham_Load(object sender, EventArgs e)
        {
            LoadFood();
        }
        public void LoadFood()
        {
            dtbFood.Clear();
            DataSet ds = food.LayDanhSachFood();
            dtbFood = ds.Tables[0];
            //dua data len datagirdview
            dgvFood.DataSource = dtbFood;
            //thay doi do rong cot
            dgvFood.AutoResizeColumns();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadFood();
        }

        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            dgvFood.DataSource = food.SearchFoodbyName(txtSearch.Text.Trim());
        }
    }
}
