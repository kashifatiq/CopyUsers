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
            GetMissingGroups();
        }

        private void GetMissingGroups()
        {
            try
            {
                DataTable dtGroupFrom = dbCommandsFrom.GetGroupsList();
                DataTable dtGroupTo = dbCommandsTo.GetGroupsList();
                DataTable dtMissingGroups = dtGroupFrom.Clone();
                foreach (DataRow dr in dtGroupFrom.Rows)
                {
                    string vrGroupName = dr["GroupName"].ToString();//.Replace("'", "");
                    DataRow[] dr2 = dtGroupTo.Select("GroupName = '" + vrGroupName + "'");
                    if (dr2.Count() == 0)
                    {
                        dr["GroupName"] = dr["GroupName"].ToString().Replace("@@", "'");
                        dr["Description"] = dr["Description"].ToString().Replace("@@", "'");
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
            try
            {
                if (e.ColumnIndex == 0)
                {

                    DataGridViewRow dr = gvMissingGroups.Rows[e.RowIndex];
                    Byte[] binaryimagevalue = null;
                    if (!string.IsNullOrEmpty(dr.Cells["binaryimagevalue"].Value.ToString()))
                        binaryimagevalue = (byte[])dr.Cells["binaryimagevalue"].Value;
                    dbCommandsTo.CreateUser(dr.Cells["groupname"].Value.ToString().Replace("'","@@"),
                                          dr.Cells["description"].Value.ToString().Replace("'","@@"),
                                          Convert.ToBoolean(dr.Cells["ispublic"].Value),
                                          Convert.ToInt32(dr.Cells["membershiptermindays"].Value),
                                          Convert.ToBoolean(dr.Cells["isdomain"].Value),
                                          Convert.ToInt32(dr.Cells["defaultrole"].Value),
                                          Convert.ToInt32(dr.Cells["isregistrationdefault"].Value),
                                          dr.Cells["customattributes"].Value.ToString()
                                          , (dr.Cells["inviteemailtext"].Value == null) ? null : dr.Cells["inviteemailtext"].Value.ToString()
                                          , (dr.Cells["termsofuse"].Value == null) ? null : dr.Cells["termsofuse"].Value.ToString()
                                          , (dr.Cells["iconurl"].Value == null) ? null : dr.Cells["iconurl"].Value.ToString()
                                          , (string.IsNullOrEmpty(dr.Cells["isenduserregistrationdefault"].Value.ToString())) ? 0 : Convert.ToInt32(dr.Cells["isenduserregistrationdefault"].Value)
                                          , (string.IsNullOrEmpty(dr.Cells["isstaffregistrationdefault"].Value.ToString())) ? 0 : Convert.ToInt32(dr.Cells["isstaffregistrationdefault"].Value),
                                            (string.IsNullOrEmpty(dr.Cells["isopen"].Value.ToString())) ? false : Convert.ToBoolean(dr.Cells["isopen"].Value),
                                            Convert.ToBoolean(dr.Cells["ispatientcareteam"].Value)
                                        , dr.Cells["imageurl"].Value.ToString()
                                        , (string.IsNullOrEmpty(dr.Cells["isopenstaff"].Value.ToString())) ? false : Convert.ToBoolean(dr.Cells["isopenstaff"].Value)
                                        , (string.IsNullOrEmpty(dr.Cells["isserviceline"].Value.ToString())) ? false : Convert.ToBoolean(dr.Cells["isserviceline"].Value)
                                        , (string.IsNullOrEmpty(dr.Cells["iscommunity"].Value.ToString())) ? false : Convert.ToBoolean(dr.Cells["iscommunity"].Value)
                                        , (string.IsNullOrEmpty(dr.Cells["iscoregroup"].Value.ToString())) ? false : Convert.ToBoolean(dr.Cells["iscoregroup"].Value),
                                        dr.Cells["faxnumber"].Value.ToString(),
                                        dr.Cells["facilityid"].Value.ToString()
                                        , (string.IsNullOrEmpty(dr.Cells["displayorder"].Value.ToString())) ? 0 : Convert.ToInt32(dr.Cells["displayorder"].Value),
                                        dr.Cells["copaydiscount"].Value.ToString(),
                                        dr.Cells["servicelinecopayamount"].Value.ToString()
                                        , binaryimagevalue
                                        , dr.Cells["providernotetemplate"].Value.ToString(),
                                        (string.IsNullOrEmpty(dr.Cells["minutesbeforeescalating"].Value.ToString())) ? null : (global::System.Nullable<int>)dr.Cells["minutesbeforeescalating"].Value,
                                        dr.Cells["customcss"].Value.ToString()
                                        , (string.IsNullOrEmpty(dr.Cells["minutesbeforeadminescalating"].Value.ToString())) ? null : (global::System.Nullable<int>)dr.Cells["minutesbeforeadminescalating"].Value
                                        , (string.IsNullOrEmpty(dr.Cells["checkforoncalldoctor"].Value.ToString())) ? false : Convert.ToBoolean(dr.Cells["checkforoncalldoctor"].Value),
                                        dr.Cells["offdutywarningmessage"].Value.ToString(),
                                        dr.Cells["nofuturescheduleswarningmessage"].Value.ToString(),
                                        dr.Cells["apptremindernoticetextpatient"].Value.ToString(),
                                        dr.Cells["apptremindernoticeperiodpatient"].Value.ToString(),
                                        dr.Cells["apptremindernoticetextstaff"].Value.ToString(),
                                        dr.Cells["apptremindernoticeperiodstaff"].Value.ToString()
                                        , (string.IsNullOrEmpty(dr.Cells["ispagerequired"].Value.ToString())) ? false : Convert.ToBoolean(dr.Cells["ispagerequired"].Value)
                                        , (string.IsNullOrEmpty(dr.Cells["isenableforcart"].Value.ToString())) ? false : Convert.ToBoolean(dr.Cells["isenableforcart"].Value),
                                        dr.Cells["atomiconurl"].Value.ToString()
                                          );
                    GetMissingGroups();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.ExitThread();
        }
    }
}
