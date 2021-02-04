using System;
using System.Collections.Generic;
using System.Data;
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
    }
}
