using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanTS
{
    public class DBMain
    {
        private static DBMain instance;
        private static string user;
        private static string pass;

        public static DBMain Instance
        {
            get { if (instance == null) instance = new DBMain(); instance.OpenSql(); return DBMain.instance; }
            private set { DBMain.instance = value; }
        }

        public static string User { get => user; set => user = value; }
        public static string Pass { get => pass; set => pass = value; }

        //string ConnStr = "Data Source=LAPTOP-J137F8J1\\SQLEXPRESS;" +
        //       "Initial Catalog=TraSuaDB;" +
        //      "User id=" + user + ";" +
        //      "Password=" + pass + ";";
        //string ConnStr = "Data Source = DESKTOP-AO3VGGP\\KHOAPHAN;" +
        //       "Initial Catalog=TraSuaDB10;" +
        //       "User id=sa;" +
        //       "Password=thienhoan719;";
        string ConnStr = "Data Source=DESKTOP-2U55O00\\TRUNGKIEN;" +
               "Initial Catalog=TraSuaDB;" +
              "User id=sa;" +
              "Password=ttkien2035;";
        //string ConnStr = "Data source=LAPTOP-O687HM47\\SQLEXPRESS; Initial Catalog=TraSuaDB;Integrated Security=true";
        SqlConnection conn = null;
        SqlCommand comm = null;
        SqlDataAdapter da = null;
        public DBMain()
        {
            conn = new SqlConnection(ConnStr);
            comm = conn.CreateCommand();
            da = null;
        }
        public SqlConnection GetSqlConnection()
        {
            return conn;
        }

        public DataTable ExecuteQuery(string query, object[] parameter = null)
        {
            DataTable data = new DataTable();
            using (SqlConnection connection1 = new SqlConnection(ConnStr)) // su dung using de  tu giai phong bo nho 
            {
                connection1.Open();
                SqlCommand command = new SqlCommand(query, connection1);
                //command.CommandType = CommandType.StoredProcedure;
                if (parameter != null)
                {
                    string[] listPara = query.Split();
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }
                // command.CommandType = CommandType.Text;


                SqlDataAdapter adapter = new SqlDataAdapter(command);

                adapter.Fill(data);
                connection1.Close();
            }

            return data;
        }
        public void ExecuteQuery1(string qr)
        {
            using (SqlConnection connection1 = new SqlConnection(ConnStr)) // su dung using de  tu giai phong bo nho 
            {
                connection1.Open();
                SqlCommand command = new SqlCommand(qr, connection1);
                int x = command.ExecuteNonQuery();
                connection1.Close();
            }
        }
        public int ExecuteNoneQuery(string query, object[] parameter = null) //số dòng thành công
        {
            int data = 0;

            using (SqlConnection connection1 = new SqlConnection(ConnStr)) // su dung using de  tu giai phong bo nho 
            {
                connection1.Open();
                SqlCommand command = new SqlCommand(query, connection1);
                if (parameter != null)
                {
                    string[] listPara = query.Split();
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

                data = command.ExecuteNonQuery();
                command.CommandType = CommandType.Text;


                SqlDataAdapter adapter = new SqlDataAdapter(command);


                connection1.Close();
            }

            return data;
        }
        public  DataSet ExecuteQueryDataSet(string strSQL, CommandType ct)
        {
            if (conn.State == ConnectionState.Open)
                conn.Close();
            conn.Open();
            comm.CommandText = strSQL;
            comm.CommandType = ct;
            da = new SqlDataAdapter(comm);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }
        
        public bool MyExecuteNonQuery(string strSQL, CommandType ct, ref string error)
        {
            bool f = false;
            if (conn.State == ConnectionState.Open)
                conn.Close();
            conn.Open();
            comm.CommandText = strSQL;
            comm.CommandType = ct;
            try
            {
                comm.ExecuteNonQuery();
                f = true;
            }
            catch (SqlException ex)
            {
                error = ex.Message;
            }
            finally
            {
                conn.Close();
            }
            return f;
        }
        public string Transaction(List<string> sql)
        {
            SqlTransaction sqlTran = conn.BeginTransaction();
            try
            {
                foreach (string item in sql)
                {
                    comm.Transaction = sqlTran;
                    comm.CommandText = item;
                    comm.CommandType = CommandType.Text;
                    comm.ExecuteNonQuery();
                }
                sqlTran.Commit();
                return "Thành công";
            }
            catch(Exception e)
            {
                try
                {
                    sqlTran.Rollback();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(e);
                    Console.WriteLine(ex);
                }
                return e.ToString();
            }
        }
        public string Transaction(string sql)
        {
            SqlTransaction sqlTran = conn.BeginTransaction();
            try
            {
                comm.Transaction = sqlTran;
                comm.CommandText = sql;
                comm.CommandType = CommandType.Text;
                comm.ExecuteNonQuery();
                sqlTran.Commit();
                return "Thành công";
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return ex.ToString();
            }
        }
        public void OpenSql()
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
        }
        public void CloseSql()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }
    }

}
