using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanTS.Model
{
    public class Bill
    {
        private int billid;
        private int userid;
        private int foodid;
        private int counts;
        internal static Bill instance;

        public int Billid { get => billid; set => billid = value; }
        public int Userid { get => userid; set => userid = value; }
        public int Foodid { get => foodid; set => foodid = value; }
        public int Counts { get => counts; set => counts = value; }
        public Bill()
        {

        }
        public Bill(int id,int userid,int foodid,int counts)
        {
            this.billid = id;
            this.userid = userid;
            this.foodid = foodid;
            this.counts = counts;
        }
        public Bill(DataRow row)
        {
            this.billid = (int)row["billid"];
            this.userid = (int)row["userid"];
            this.foodid = (int)row["foodid"];
            this.counts = (int)row["counts"];
         
        }
    }
}
