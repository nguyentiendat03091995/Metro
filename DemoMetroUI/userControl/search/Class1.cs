﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;



namespace DemoMetroUI.userControl.search
{
    public static class ketnoi
    {

        public static string chuoiketnoi = @"Data Source=.\SQLEXPRESS;Initial Catalog=QLHOCVU;User ID=sa;password=123456";
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
