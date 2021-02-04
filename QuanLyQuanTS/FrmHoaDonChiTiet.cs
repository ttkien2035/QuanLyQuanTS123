using QuanLyQuanTS.BS_Layer;
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
    public partial class FrmHoaDonChiTiet : Form
    {
        string err;
        DataTable dtbilldetail = null;
        BLBill_Detail blbilldetail = new BLBill_Detail();
        int billid;
        public FrmHoaDonChiTiet()
        {
            InitializeComponent();
            loadDataBillDetail();
        }
        private void loadDataBillDetail()
        {
            dtbilldetail = new DataTable();
            dtbilldetail.Clear();
            DataSet ds = blbilldetail.LayDSHoaDonChiTiet();
            dtbilldetail = ds.Tables[0];
            //dua data len datagirdview
            dgvHoaDonChiTiet.DataSource = dtbilldetail;

            //thay doi do rong cot
            dgvHoaDonChiTiet.AutoResizeColumns();
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
            loadDataBillDetail();
        }

        private void dgvHoaDonChiTiet_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvHoaDonChiTiet.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    billid = Convert.ToInt32(dgvHoaDonChiTiet.Rows[e.RowIndex].Cells[0].Value);

                }
            }
            catch
            {
                MessageBox.Show("Vui long click vao table");
            }
           
            
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            string error = "";
            bool check = blbilldetail.updateBillDetail(billid,ref error);
            if(error!="")
            {
                MessageBox.Show(error);
            }
            loadDataBillDetail(); 
        }
    }
}
