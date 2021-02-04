using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanTS.BS_Layer
{
    public class Account
    {
        public Account(string username, string type, string password = null)
        {
            this.UserName = username;
            this.Type = type;
            this.PassWord = password;

        }

        public Account(DataRow row)
        {
            this.UserName = row["username"].ToString();
            this.Type = row["typeAccount"].ToString();
            this.PassWord = row["pass"].ToString();
        }
        private string userName;
        private string passWord;
        private string type;

        public string UserName { get => userName; set => userName = value; }
        public string PassWord { get => passWord; set => passWord = value; }
        public string Type { get => type; set => type = value; }
    }
}
