using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;




namespace DemoMetroUI.userControl.search
{
    public static class ketnoi
    {
        //workstation id = QLGIAOVU.mssql.somee.com; packet size = 4096; user id = nhoxliaryeuem1_SQLLogin_1; pwd=8l5ab41xg8;data source = QLGIAOVU.mssql.somee.com; persist security info=False;initial catalog = QLGIAOVU
        //public static string chuoiketnoi = @"Data Source=.\SQLEXPRESS;Initial Catalog=QLHOCVU;User ID=sa;password=123456";

        public static string chuoiketnoi = @"workstation id = QLGIAOVU.mssql.somee.com; packet size = 4096; user id = nhoxliaryeuem1_SQLLogin_1; pwd=8l5ab41xg8;data source = QLGIAOVU.mssql.somee.com; persist security info=False;initial catalog = QLGIAOVU";
        public static SqlConnection con;
        public static SqlCommand cmd;
        public static SqlDataAdapter da;

        public static void openketnoi()
        {
            con = new SqlConnection(chuoiketnoi);
            con.Open();
        }
        public static void dongketnoi()
        {
            con.Close();
        }
        // phuong thuc get
        public static DataTable gettable(string sql)
        {
            cmd = new SqlCommand(sql, con);
            da = new SqlDataAdapter(cmd);
            DataTable db = new DataTable();
            da.Fill(db);
            return db;
        }
        public static void executeQuery(string sql)
        {
            cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
        }
    }


}
