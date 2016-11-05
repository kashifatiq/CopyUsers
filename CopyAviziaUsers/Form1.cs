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

        }

        private void btnLoadMissingUsers_Click(object sender, EventArgs e)
        {

        }
    }
}
