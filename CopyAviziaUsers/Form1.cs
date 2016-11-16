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
                    string vrGroupName = dr["GroupName"].ToString();
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
            LoadMissingUsers();
        }

        private void LoadMissingUsers()
        {
            try
            {
                DataTable dtUsersFrom = dbCommandsFrom.GetStaffUsersList();
                DataTable dtUsersTo = dbCommandsTo.GetStaffUsersList();
                DataTable dtMissingUsers = dtUsersFrom.Clone();
                foreach (DataRow dr in dtUsersFrom.Rows)
                {
                    string vrGroupName = dr["UserName"].ToString();
                    DataRow[] dr2 = dtUsersTo.Select("UserName = '" + vrGroupName + "'");
                    if (dr2.Count() == 0)
                    {
                        dr["UserName"] = dr["UserName"].ToString().Replace("@@", "'");
                        dr["FirstName"] = dr["FirstName"].ToString().Replace("@@", "'");
                        dr["LastName"] = dr["LastName"].ToString().Replace("@@", "'");
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
                    dbCommandsTo.CreateGroup(dr.Cells["groupname"].Value.ToString().Replace("'", "@@"),
                                          dr.Cells["description"].Value.ToString().Replace("'", "@@"),
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

        private void gvMissingUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 0)
                {
                    DataGridViewRow dr = gvMissingUsers.Rows[e.RowIndex];

                  int UserID =  dbCommandsTo.CreateUser(
                        dr.Cells["UserName"].Value.ToString().Replace("'", "@@"),
                        dr.Cells["Password"].Value.ToString(),
                        dr.Cells["Email"].Value.ToString(),
                        dr.Cells["FirstName"].Value.ToString().Replace("'", "@@"),
                        dr.Cells["LastName"].Value.ToString().Replace("'", "@@"),
                        dr.Cells["MiddleName"].Value.ToString(),
                        dr.Cells["CellPhone"].Value.ToString(),
                        dr.Cells["WorkPhone"].Value.ToString(),
                        dr.Cells["HomePhone"].Value.ToString(),
                        (string.IsNullOrEmpty(dr.Cells["DOB"].Value.ToString()))?null:(global::System.Nullable<global::System.DateTime>)dr.Cells["DOB"].Value,
                        dr.Cells["GUID"].Value.ToString(),
                        (string.IsNullOrEmpty(dr.Cells["DateCreated"].Value.ToString())) ? null : (global::System.Nullable<global::System.DateTime>)dr.Cells["DateCreated"].Value,
                        (string.IsNullOrEmpty(dr.Cells["dateedited"].Value.ToString())) ? null : (global::System.Nullable<global::System.DateTime>)dr.Cells["dateedited"].Value,
                        (string.IsNullOrEmpty(dr.Cells["DateDeleted"].Value.ToString())) ? null : (global::System.Nullable<global::System.DateTime>)dr.Cells["DateDeleted"].Value,
                        1,
                        (string.IsNullOrEmpty(dr.Cells["IsPublic"].Value.ToString())) ? null : (global::System.Nullable<int>)dr.Cells["IsPublic"].Value,
                        (string.IsNullOrEmpty(dr.Cells["IsDomain"].Value.ToString())) ? null : (global::System.Nullable<bool>)dr.Cells["IsDomain"].Value,
                        dr.Cells["Inactive"].Value.ToString(),
                        dr.Cells["ReasonInactive"].Value.ToString(),
                        (string.IsNullOrEmpty(dr.Cells["ChangePassword"].Value.ToString())) ? null : (global::System.Nullable<bool>)dr.Cells["ChangePassword"].Value,
                        dr.Cells["Verified"].Value.ToString(),
                        dr.Cells["Online"].Value.ToString(),
                        (string.IsNullOrEmpty(dr.Cells["IsDeleted"].Value.ToString())) ? null : (global::System.Nullable<bool>)dr.Cells["IsDeleted"].Value,
                        (string.IsNullOrEmpty(dr.Cells["agreed_terms"].Value.ToString())) ? null : (global::System.Nullable<bool>)dr.Cells["agreed_terms"].Value,
                        1,
                        dr.Cells["PreferredLanguage"].Value.ToString(),
                        (string.IsNullOrEmpty(dr.Cells["FailedLoginAttempts"].Value.ToString())) ? null : (global::System.Nullable<int>)dr.Cells["FailedLoginAttempts"].Value,
                        (string.IsNullOrEmpty(dr.Cells["LastLogin"].Value.ToString())) ? null : (global::System.Nullable<global::System.DateTime>)dr.Cells["LastLogin"].Value,
                        (string.IsNullOrEmpty(dr.Cells["LastActive"].Value.ToString())) ? null : (global::System.Nullable<global::System.DateTime>)dr.Cells["LastActive"].Value,
                        dr.Cells["GoogleUserName"].Value.ToString(),
                        dr.Cells["GooglePassword"].Value.ToString(),
                        dr.Cells["ConferencingUserName"].Value.ToString(),
                        dr.Cells["ConferencingPassword"].Value.ToString(),
                        (string.IsNullOrEmpty(dr.Cells["IsLocked"].Value.ToString())) ? null : (global::System.Nullable<bool>)dr.Cells["IsLocked"].Value,
                        dr.Cells["City"].Value.ToString(),
                        dr.Cells["State"].Value.ToString(),
                        dr.Cells["ZipCode"].Value.ToString(),
                        dr.Cells["Sex"].Value.ToString(),
                        dr.Cells["StaffNPI"].Value.ToString(),
                        dr.Cells["StaffDEANumber"].Value.ToString(),
                        dr.Cells["StaffMedicalLicenseNumber"].Value.ToString(),
                        dr.Cells["PagerNumber"].Value.ToString(),
                        dr.Cells["FaxNumber"].Value.ToString(),
                        dr.Cells["Address1"].Value.ToString(),
                        dr.Cells["Address2"].Value.ToString(),
                        (string.IsNullOrEmpty(dr.Cells["onepassuserid"].Value.ToString())) ? null : (global::System.Nullable<int>)dr.Cells["onepassuserid"].Value,
                        dr.Cells["MRN"].Value.ToString(),
                        (string.IsNullOrEmpty(dr.Cells["CellPhoneVerified"].Value.ToString())) ? null : (global::System.Nullable<bool>)dr.Cells["CellPhoneVerified"].Value,
                        dr.Cells["ExternalID"].Value.ToString(),
                        dr.Cells["ExternalUserID"].Value.ToString(),
                        dr.Cells["SourceFacility"].Value.ToString(),
                        (string.IsNullOrEmpty(dr.Cells["SourceFacility_FacilityID"].Value.ToString())) ? null : (global::System.Nullable<int>)dr.Cells["SourceFacility_FacilityID"].Value,
                        (string.IsNullOrEmpty(dr.Cells["onepass_agreed_terms"].Value.ToString())) ? null : (global::System.Nullable<bool>)dr.Cells["onepass_agreed_terms"].Value,
                        dr.Cells["XmppUserName"].Value.ToString(),
                        dr.Cells["XmppPassword"].Value.ToString(),
                        dr.Cells["GroupPager"].Value.ToString(),
                        dr.Cells["AnsweringServicePhone"].Value.ToString(),
                        dr.Cells["AdditionalLocationPhone"].Value.ToString(),
                        dr.Cells["ContactPrefVoiceOnCall"].Value.ToString(),
                        dr.Cells["ContactPrefVoiceOffCall"].Value.ToString(),
                        dr.Cells["ContactPrefNotificationOnCall"].Value.ToString(),
                        dr.Cells["ContactPrefNotificationOffCall"].Value.ToString(),
                        dr.Cells["UniquePatientGUID"].Value.ToString(),
                        dr.Cells["vCard"].Value.ToString(),
                        dr.Cells["PracticeAreas"].Value.ToString(),
                        dr.Cells["PracticeFacilities"].Value.ToString(),
                        dr.Cells["PracticeZipCodes"].Value.ToString(),
                        dr.Cells["SSN"].Value.ToString(),
                        dr.Cells["Race"].Value.ToString(),
                        dr.Cells["VideoAddress"].Value.ToString(),
                        dr.Cells["UniqueValue"].Value.ToString(),
                        dr.Cells["Photo"].Value.ToString(),
                        dr.Cells["Country"].Value.ToString(),
                        dr.Cells["FileServiceKey"].Value.ToString(),
                        dr.Cells["ExternalAuthUserName"].Value.ToString(),
                        dr.Cells["VideoType"].Value.ToString(),
                        dr.Cells["PrimarySpecialty"].Value.ToString()
                      );
                  if (UserID != 0)
                  {
                      string GroupNames = dr.Cells["Groups"].Value.ToString();
                      List<string> strList = GroupNames.Split(',').ToList();
                      foreach(string str in strList)
                      {
                          string groupName = str.Replace("'", "@@");
                          dbCommandsTo.CopyGroupMap(UserID, groupName);
                      }
                      
                  }
                    LoadMissingUsers();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
