﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopyAviziaUsers
{
    public class dbCommandsFrom
    {
        public static DataTable GetTotals()
        {
            DataTable dt = new DataTable();
            try
            {
                DbConnection.con1.Open();
                SqlCommand cmd = new SqlCommand("select (select COUNT(1) from AppSettings) StaffUsersCount, (select COUNT(1) from BredadaOrderItems) GroupsCount", DbConnection.con1);
                SqlDataAdapter dap = new SqlDataAdapter(cmd);
                dap.Fill(dt);
                return dt;
            }
            finally
            {
                DbConnection.con1.Close();
            }
        }
        public static DataTable GetUsersList()
        {
            DataTable dt = new DataTable();
            try
            {
                DbConnection.con1.Open();
                SqlCommand cmd = new SqlCommand("select * from AppSettings", DbConnection.con1);
                SqlDataAdapter dap = new SqlDataAdapter(cmd);
                dap.Fill(dt);
                return dt;
            }
            finally
            {
                DbConnection.con1.Close();
            }
        }
    }
}
