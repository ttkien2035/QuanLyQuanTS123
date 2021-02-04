using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanTS
{
    class Khach
    {
        private static Khach instance;
        DBMain db = null;
        public static Khach Instance
        {
            get { if (instance == null) instance = new Khach(); return Khach.instance; }
            private set { Khach.instance = value; }
        }
        public Khach()
        {
            db = new DBMain();
        }
        public DataTable getKhach()
        {
            string sql = "select * from Khach";
            DataSet a = db.ExecuteQueryDataSet(sql, CommandType.Text);
            return a.Tables[0];
        }
        public DataTable getKhachwithsearch(string text)
        {
            string sql = "select * from Khach  WHERE CONCAT(Tên,Số_điện_thoại) LIKE '%" + text + "%'";
            DataSet a = db.ExecuteQueryDataSet(sql, CommandType.Text);
            return a.Tables[0];
        }
        public DataTable getKhachwithorder(ref string order)
        {
            if (order=="desc")
            {
                string sql = "select * from Khach order by Điểm DESC";
                DataSet a = db.ExecuteQueryDataSet(sql, CommandType.Text);
                order = "asc";
                return a.Tables[0];
            }
            else
            {
                string sql = "select * from Khach order by Điểm asc";
                DataSet a = db.ExecuteQueryDataSet(sql, CommandType.Text);
                order = "desc";
                return a.Tables[0];
            }
            
        }
        public string AddKhach(string intid, string name, string rank, int point, string bdate, string phone,int accid,string uname,string pass)
        {
            try
            {
                List<string> sql = new List<string>();
                string query = "SET IDENTITY_INSERT Account ON;INSERT INTO Account(accountid,username,pass,typeAccount ) values(" + accid + ",'" +
                                                           uname + "','" +
                                                           pass + "','" +
                                                           "customer"+
                                                           "');SET IDENTITY_INSERT Account OFF;";
                sql.Add(query);
                string query2= "insert into Users values(" + intid + ",'" +
                                                           name + "','" +
                                                           bdate + "','" +
                                                           phone + "','" +
                                                           point + "','" +
                                                           rank + "','" +
                                                           accid +
                                                           "')";
                sql.Add(query2);
                var a = db.Transaction(sql);
                return a.ToString();
            }
            catch (Exception e)
            {
                return e.ToString();
            }

        }
        public string EditKhach(string intid, string name, string rank, int point, string bdate, string phone)
        {
            try
            {
                string query = "update Users set nameuser='" + name + "'," +
                                        " birthday = '" + bdate + "'," +
                                        " phoneNumber = '" + phone + "'," +
                                        " rewardpoint = " + point + "," +
                                        " classify = '" + rank +
                                        "' where userid = " + intid;

                var a = db.Transaction(query);
                return "Chỉnh sửa thành công";
            }
            catch (Exception e)
            {
                return e.ToString();
            }

        }
        public string DeleteKhach(string ID)
        {
            try
            {
                string query = "Delete from Users where userid = " + ID;
                var a = db.Transaction(query);
                return "Xóa thành công";
            }
            catch (Exception e)
            {
                return e.ToString();
            }

        }
        public static bool CheckUserID(int id)
        {
            SqlConnection sqlcon = DBMain.Instance.GetSqlConnection();

            string sql = "select dbo.check_user_id(" + id.ToString() + ")";
            SqlCommand cmd = new SqlCommand(sql, sqlcon);
            return (bool)cmd.ExecuteScalar();
        }
        public static bool CheckUserName(string id)
        {
            SqlConnection sqlcon = DBMain.Instance.GetSqlConnection();

            string sql = "select dbo.check_username('" + id.ToString() + "')";
            SqlCommand cmd = new SqlCommand(sql, sqlcon);
            return (bool)cmd.ExecuteScalar();
        }
    }
}
