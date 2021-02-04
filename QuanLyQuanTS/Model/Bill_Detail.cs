using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanTS.Model
{
    public class Bill_Detail
    {
        private int detailid;
        private int cost;
        private DateTime billdate;
        private int billid;
        private bool status;
        public int Detailid { get => detailid; set => detailid = value; }
        public int Cost { get => cost; set => cost = value; }
        public DateTime Billdate { get => billdate; set => billdate = value; }
        public int Billid { get => billid; set => billid = value; }
        public bool Status { get => status; set => status = value; }
        public Bill_Detail()
        {

        }
        public Bill_Detail(int id,int cost,DateTime billdate,int billid,bool status)
        {
            this.detailid = id;
            this.cost = cost;
            this.billdate = billdate;
            this.billid = billid;
            this.status = status;
        }
        public Bill_Detail(DataRow row)
        {
            this.detailid = (int)row["detailid"];
            this.cost = (int)row["cost"];
            this.billdate = (DateTime)row["billdate"];
            this.billid = (int)row["billid"];
            this.status = (bool)row["status"];
        }
    }
}
