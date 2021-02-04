
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanTS.BS_Layer
{
    class BLAccount
    {
        private static BLAccount instance;


        public static BLAccount Instance
        {
            get { if (instance == null) instance = new BLAccount(); return instance; }
            private set { instance = value; }
        }

        private BLAccount() { }

        //Kiểm tra trong Database nếu có tài khoản trùng khớp với tài khoản trong database thì mới đằng nhập vào được
        public bool Login(string userName, string passWord)
        {
            string query = "select * from dbo.Account where username = N'"
                + userName + "' and pass = N'" + passWord + "'  ";
            DataTable result = DBMain.Instance.ExecuteQuery(query);
            return result.Rows.Count > 0;
        }
        public bool AddAcount(string user, string pass, string type)
        {
            string query = "insert into Account values ('" + user + "','" + pass + "','" + type + "')";
            int temp = DBMain.Instance.ExecuteNoneQuery(query);
            if (temp !=0)
            {
                return true;
            }
            return false;
        }
        //kếu có thi trả về account còn nếu không trả về null
        public Account GetAccountByUserName(string userName)
        {
            DataTable data = DBMain.Instance.ExecuteQuery("select *from dbo.Account where username = '"
                + userName + "'");
            foreach (DataRow item in data.Rows)
            {
                return new Account(item);
            }
            return null;
        }

        public bool UpdateAccount(string userName, string pass, string NewPass)
        {
            int result = DBMain.Instance.ExecuteNoneQuery("UpdateAccount @userName , " +
                "@OldPassword , @NewPassword", new object[] { userName, pass, NewPass });
            return result > 0;
        }

    }
}
