using QuanLyQuanTS.BS_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanTS
{
    public partial class FrmBanHang : Form
    {
        DataTable dtbill= null;
        // Khai báo biến kiểm tra việc Thêm hay Sửa dữ liệu 
        bool Them;
        string err;
        BLBill blbill = new BLBill();
        public FrmBanHang()
        {
            InitializeComponent();
            loadDataBill();
        }
        private void loadDataBill()
        {
            dtbill = new DataTable();
            dtbill.Clear();
            DataSet ds = blbill.LayThongTinDonHang();
            dtbill = ds.Tables[0];
            //dua data len datagirdview
            dgvBanHang.DataSource = dtbill;
            //thay doi do rong cot
            dgvBanHang.AutoResizeColumns();
            /* try
             {
                 dtbill = new DataTable();
                 dtbill.Clear();
                 DataSet ds = blbill.LayThongTinDonHang();
                 dtbill = ds.Tables[0];
                 //dua data len datagirdview
                 dgvBanHang.DataSource = dtbill;
                 //thay doi do rong cot
                 dgvBanHang.AutoResizeColumns();
             }
             catch(SqlException)
             {
                 MessageBox.Show("Không lấy được thong tin don hang. Lỗi rồi!!!");
             } */
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            loadDataBill();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void thanhToan_Click(object sender, EventArgs e)
        {
            FrmHoaDonChiTiet hoaDonChiTiet = new FrmHoaDonChiTiet();
            hoaDonChiTiet.ShowDialog();
            this.Show();
        }

        private void addBill_Click(object sender, EventArgs e)
        {
            FrmThemHoaDon themHoaDon = new FrmThemHoaDon();
            themHoaDon.ShowDialog();
            this.Show();
        }

        private void FrmBanHang_Load(object sender, EventArgs e)
        {

        }
    }
}
