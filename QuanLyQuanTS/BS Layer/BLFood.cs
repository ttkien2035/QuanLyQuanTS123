using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanTS.BS_Layer
{
    class BLFood
    {
        DBMain db = null;
        public BLFood()
        {
            db = new DBMain();
        }
        public DataSet LayDanhSachFood()
        {
            return db.ExecuteQueryDataSet("select * from Food", CommandType.Text);
        }

        public string getNameFood(int foodid)
        {

            string query = ("select foodname from Food where foodid=" + foodid.ToString());
            DataSet ds = db.ExecuteQueryDataSet(query, CommandType.Text);
            DataTable tb = ds.Tables[0];
            string foodname = tb.Rows[0][0].ToString();
            return foodname;
        }
        public DataTable SearchFoodbyName(string name)
        {
            return DBMain.Instance.ExecuteQuery("EXEC get_Food_By_Name @protest", new object[] { name });
        }
        public bool ThemFood(int FoodID, string FoodName,int price, int categoryID, ref string err)
        {
            string query = "insert into Food values(" + FoodID + ",N'" + FoodName + "','" + price + "','" + categoryID + "')";
            return db.MyExecuteNonQuery(query, CommandType.Text, ref err);


        }
        public bool XoaFood(ref string err, int FoodID)
        {
            string sqlString = "Delete From Food Where foodid='" + FoodID + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool CapNhatFood(int FoodID, string FoodName, int price, int categoryID, ref string err)
        {
            string query = "update dbo.Food set foodname=N'" + FoodName + "'," + " price = " + price + "," + " categoryid = " + categoryID + " where foodid = " + FoodID;
            //string query = "update Food set foodname=N'" + FoodName + "'," + " price = " + price + "," + " categoryid = " + categoryID + " where foodid = " + FoodID ;


            return db.MyExecuteNonQuery(query, CommandType.Text, ref err);
        }
        public int getPriceFood(int foodid)
        {
            string query = "SELECT price From Food Where foodid='" + foodid + "'";
            DataSet dt = db.ExecuteQueryDataSet(query , CommandType.Text);
            DataTable data = dt.Tables[0];
            string pr = data.Rows[0][0].ToString();
            int price = Int32.Parse(pr);
            return price;
        }
    }
}
