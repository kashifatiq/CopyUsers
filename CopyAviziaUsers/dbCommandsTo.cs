using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopyAviziaUsers
{
    public class dbCommandsTo
    {
        public static Exception Exception;

        public static DataTable GetTotals()
        {
            Exception = null;
            DataTable dt = new DataTable();
            try
            {
                DbConnection.con2.Open();
                SqlCommand cmd = new SqlCommand("select (select COUNT(1) from AppSettings) StaffUsersCount, (select COUNT(1) from BredadaOrderItems) GroupsCount", DbConnection.con2);
                SqlDataAdapter dap = new SqlDataAdapter(cmd);
                dap.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                Exception = ex;
                return dt;
            }
            finally
            {
                DbConnection.con2.Close();
            }
        }
        public static DataTable GetUsersList()
        {
            Exception = null;
            DataTable dt = new DataTable();
            try
            {
                DbConnection.con1.Open();
                SqlCommand cmd = new SqlCommand("select * from AppSettings", DbConnection.con2);
                SqlDataAdapter dap = new SqlDataAdapter(cmd);
                dap.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                Exception = ex;
                return dt;
            }
            finally
            {
                DbConnection.con1.Close();
            }
        }

        public static void CreateUser()
        {
            Exception = null;
            DataTable dt = new DataTable();
            try
            {
                DbConnection.con1.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO AppSettings (SettingKey, SettingValue) VALUES ('test','test')", DbConnection.con2);
                SqlDataAdapter dap = new SqlDataAdapter(cmd);
                dap.Fill(dt);
                
            }
            catch (Exception ex)
            {
                Exception = ex;
            }
            finally
            {
                DbConnection.con1.Close();
            }
        }
    }
}
