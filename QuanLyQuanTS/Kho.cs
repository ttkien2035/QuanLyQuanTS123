using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanTS
{
    class Kho
    {
        private static Kho instance;
        DBMain db = null;
        public static Kho Instance
        {
            get { if (instance == null) instance = new Kho(); return Kho.instance; }
            private set {Kho.instance = value; }
        }
        public Kho()
        {
            db = new DBMain();
        }
        public DataTable getKho()
        {
            string sql = "select * from Kho";
            DataSet a = db.ExecuteQueryDataSet(sql, CommandType.Text);
            return a.Tables[0];
        }
        public DataTable getKhowithsearch(string text)
        {
            string sql = "select * from Kho  WHERE CONCAT(Name,Nhà_cung_cấp) LIKE '%"+text+"%'";
            DataSet a = db.ExecuteQueryDataSet(sql, CommandType.Text);
            return a.Tables[0];
        }
        public static bool CheckInputStoreID(int id)
        {
            SqlConnection sqlcon = DBMain.Instance.GetSqlConnection();
            
            string sql = "select dbo.check_input_store_id(" + id.ToString() + ")";
            SqlCommand cmd = new SqlCommand(sql, sqlcon);
            return (bool)cmd.ExecuteScalar();
        }
        public DataTable getType()
        {
            string sql = "select name from Category";
            DataSet a = db.ExecuteQueryDataSet(sql, CommandType.Text);
            return a.Tables[0];
        }
        public DataTable getPro()
        {
            string sql = "select name from Providers";
            DataSet a = db.ExecuteQueryDataSet(sql, CommandType.Text);
            return a.Tables[0];
        }

        public int GetProviderID(string pro)
        {
            SqlConnection sqlcon = DBMain.Instance.GetSqlConnection();
            string sql = "select providerid from Providers where name =@name ";
            SqlCommand cmd = new SqlCommand(sql, sqlcon);
            cmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = pro;
            return (int)cmd.ExecuteScalar();
        }

        //public int GetProviderName(int proid)
        //{
        //    SqlConnection sqlcon = DBMain.Instance.GetSqlConnection();
        //    string sql = "select providerid from Providers where name =@name ";
        //    SqlCommand cmd = new SqlCommand(sql, sqlcon);
        //    cmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = pro;
        //    return (int)cmd.ExecuteScalar();
        //}

        public string AddKho(string intid, string name, string type, string count, string intcost, string date, string intproid,ref string err)
        {
            try
            {
                string query = "insert into InputStore values(" + intid + ",'" +
                                                           name + "','" +
                                                           type + "'," +
                                                           count + "," +
                                                           intcost + ",'" +
                                                           date + "'," +
                                                           intproid +
                                                           ")";
                var a = db.Transaction(query);
                return a.ToString();
            }
            catch(Exception e)
            {
                return e.ToString();
            }
            
        }
        public string EditKho(string intid, string name, string type, string count, string intcost, string date, string intproid, ref string err)
        {
            try
            {
                string query = "update InputStore set foodname='" + name + "'," +
                                        " foodtype = '" + type + "'," +
                                        " foodcounts = " + count + "," +
                                        " cost = " + intcost + "," +
                                        " input_date = '" + date + "'," +
                                        " providerid = " + intproid + 
                                        " where inputid = " + intid;

                var a= db.Transaction(query);
                return "Chỉnh sửa thành công";
            }
            catch (Exception e)
            {
                return e.ToString();
            }

        }
        public string DeleteKho(string ID, ref string err)
        {
            try
            {
                string query = "Delete from InputStore where inputid = " + ID;
                var a = db.Transaction(query);
                return "Xóa thành công";
            }
            catch (Exception e)
            {
                return e.ToString();
            }

        }

    }
}
