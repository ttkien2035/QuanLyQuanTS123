using QuanLyQuanTS.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanTS.BS_Layer
{
    public class BLBill
    {
        DBMain db = null;
        private static BLBill instance;
        public static BLBill Instance
        {
            get { if (instance == null) instance = new BLBill(); return BLBill.instance; }
            private set { BLBill.instance = value; }
        }
        public BLBill()
        {
            db = new DBMain();
        }
        public DataSet LayDanhSachBill()
        {
            
            return db.ExecuteQueryDataSet("select * from Bill", CommandType.Text);
        }
        public List<Bill> GetListBill(int billid)
        {
            List<Bill> listBill = new List<Bill>();
            DataSet ds = LayDanhSachBill();
            foreach(DataRow item in ds.Tables[0].Rows)
            {
                Bill bill = new Bill(item);
                listBill.Add(bill);
            }
            return listBill;
        }
        public bool UpdateBill(int userid,int foodid,int counts, ref string err)
        {
            string query = "insert into Bill values(" + userid + "," + foodid + "," + counts + ")";
            return db.MyExecuteNonQuery(query, CommandType.Text, ref err);
        }
        public bool insertBill(int foodid, int count, int userid)
        {
            int result = DBMain.Instance.ExecuteNoneQuery("InsertBill @foodid , " +
                "@count , @userid", new object[] { foodid, count, userid });
            return result > 0;
        }
        public DataSet LayThongTinDonHang()
        {
            string query=("SELECT  u.nameuser AS name, u.classify AS classify, f.foodname AS food, b.counts AS counts FROM Bill_Detail as bd, Bill AS b, Users AS u, Food AS f WHERE b.detailid=bd.detailid AND bd.userid=u.userid AND b.foodid=f.foodid");
            return db.ExecuteQueryDataSet(query, CommandType.Text);
        }
        public DataSet LayDanhSachFood()
        {
            string query = ("SELECT  f.foodid AS name, f.foodname AS Foodname, f.price AS Price, b.counts AS counts FROM  Bill AS b, Food AS f WHERE b.foodid=f.foodid");
            return db.ExecuteQueryDataSet(query, CommandType.Text);
        }
        public DataSet GetIdMax()
        {
            string query = "SELECT MAX(billid) FROM Bill";
            return db.ExecuteQueryDataSet(query, CommandType.Text); 
        }
        public int getIdMax()
        {
            BLBill bill = new BLBill();
            DataSet data =bill.GetIdMax() ;
            DataTable dt = data.Tables[0];
            string id = dt.Rows[0][0].ToString();
            int idmax = Int32.Parse(id);
            return idmax;
        }

        
       
       

    }
}
