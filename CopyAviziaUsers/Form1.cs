using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CopyAviziaUsers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtDbFromCon.Text = DbConnection.con1.ConnectionString;
            txtDbTo.Text = DbConnection.con2.ConnectionString;

            DataTable dtUserFromCount = dbCommandsFrom.GetTotals();
            txtTotalUsersFrom.Text = dtUserFromCount.Rows[0]["StaffUsersCount"].ToString();
            txtTotalGroupsFrom.Text = dtUserFromCount.Rows[0]["GroupsCount"].ToString();

            DataTable dtUserToCount = dbCommandsTo.GetTotals();
            txtTotalUsersTo.Text = dtUserToCount.Rows[0]["StaffUsersCount"].ToString();
            txtTotalGroupsTo.Text = dtUserToCount.Rows[0]["GroupsCount"].ToString();
        }

        private void btnGetMisingGroups_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dtGroupFrom = dbCommandsFrom.GetGroupsList();
                DataTable dtGroupTo = dbCommandsTo.GetGroupsList();
                DataTable dtMissingGroups = dtGroupFrom.Clone();
                foreach (DataRow dr in dtGroupFrom.Rows)
                {
                    string vrGroupName = dr["GroupName"].ToString().Replace("'", "");
                    DataRow[] dr2 = dtGroupTo.Select("GroupName = '" + vrGroupName + "'");
                    if (dr2.Count() == 0)
                    {
                        dtMissingGroups.ImportRow(dr);
                    }
                }
                gvMissingGroups.DataSource = null;
                gvMissingGroups.Refresh();
                gvMissingGroups.DataSource = dtMissingGroups;
                lblTotalMissingGroups.Text = "Missing Groups Count :" + dtMissingGroups.Rows.Count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnLoadMissingUsers_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dtUsersFrom = dbCommandsFrom.GetStaffUsersList();
                DataTable dtUsersTo = dbCommandsTo.GetStaffUsersList();
                DataTable dtMissingUsers = dtUsersFrom.Clone();
                foreach (DataRow dr in dtUsersFrom.Rows)
                {
                    string vrGroupName = dr["UserName"].ToString().Replace("'", "");
                    DataRow[] dr2 = dtUsersTo.Select("UserName = '" + vrGroupName + "'");
                    if (dr2.Count() == 0)
                    {
                        dtMissingUsers.ImportRow(dr);
                    }
                }
                gvMissingUsers.DataSource = null;
                gvMissingUsers.Refresh();
                gvMissingUsers.DataSource = dtMissingUsers;
                lblMissingUsersCount.Text = "Missing Users Count :" + dtMissingUsers.Rows.Count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void gvMissingGroups_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 0)
            {
                DataGridViewRow dr = gvMissingGroups.Rows[e.RowIndex];
            }
        }
    }
}
