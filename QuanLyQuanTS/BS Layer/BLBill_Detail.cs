using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanTS.BS_Layer
{
    public class BLBill_Detail
    {
        DBMain db = null;
        private static BLBill_Detail instance;
        public static BLBill_Detail Instance
        {
            get { if (instance == null) instance = new BLBill_Detail(); return BLBill_Detail.instance; }
            private set { BLBill_Detail.instance = value; }
        }
        public BLBill_Detail()
        {
            db = new DBMain();
        }
        public DataSet LayDSHoaDonChiTiet()
        {
            string query = ("Select * From ChiTietDon ");
            return db.ExecuteQueryDataSet(query, CommandType.Text);
        }
        public string LayTongTienTungUser(int userid)
        {

            string query = ("select cost from Bill_Detail where userid=" + userid.ToString());
            DataSet ds= db.ExecuteQueryDataSet(query, CommandType.Text);
            DataTable tb = ds.Tables[0];
            string totalcost = tb.Rows[0][0].ToString();
            return totalcost;
        }
        public bool updateBillDetail(int billid, ref string err)
        {
           
            string query = ("UPDATE Bill_Detail SET status = 1 WHERE detailid =" + billid+ " AND status = 0");
            return db.MyExecuteNonQuery(query, CommandType.Text, ref err);
            
        }
        public bool updateStatusBillDetail(int userid, ref string err)
        {
            string query = ("UPDATE Bill_Detail SET status = 1 WHERE userid =" + userid + " AND status = 0");
            return db.MyExecuteNonQuery(query, CommandType.Text, ref err);
        }
        
        public bool insertBillDetail(int cost, DateTime billdate, int userid,  ref string err)
        {
            int result = DBMain.Instance.ExecuteNoneQuery("InsertBilldetail @userid , " +
                   "@cost", new object[] { userid, cost});
            return result > 0;
        }
        public bool ThanhToanBill(int userid)
        {
            int result = DBMain.Instance.ExecuteNoneQuery("ThanhToanTien @userid " 
                   , new object[] { userid});
            return result > 0;
        }
        public bool updateUsers(int billid,ref string err)
        {
            return true;
        }
      
    }
}
