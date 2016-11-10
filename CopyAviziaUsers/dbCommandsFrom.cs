using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CopyAviziaUsers.DsFromTableAdapters;
namespace CopyAviziaUsers
{
    public class dbCommandsFrom
    {
        public static DataTable GetTotals()
        {
            DsFromTableAdapters.FromCountersTableAdapter dd = new FromCountersTableAdapter();
            DataTable dt2 = dd.GetData();
            return dt2;
        }

        public static DataTable GetGroupsList()
        {
            DsFromTableAdapters.rz_GroupTableAdapter dd = new rz_GroupTableAdapter();
            return dd.GetData();
        }

        public static DataTable GetStaffUsersList()
        {
            DsFromTableAdapters.StaffUsersListTableAdapter dd = new StaffUsersListTableAdapter();
            return dd.GetData();
        }
    }
}
