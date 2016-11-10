using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CopyAviziaUsers.DsToTableAdapters;
namespace CopyAviziaUsers
{
    public class dbCommandsTo
    {
        public static Exception Exception;

        public static DataTable GetTotals()
        {
            DsToTableAdapters.ToCountersTableAdapter dd = new ToCountersTableAdapter();
            DataTable dt2 = dd.GetData();
            return dt2;
        }
        public static DataTable GetGroupsList()
        {
            DsToTableAdapters.rz_GroupTableAdapter dd = new rz_GroupTableAdapter();
            return dd.GetData();
        }

        public static DataTable GetStaffUsersList()
        {
            DsToTableAdapters.StaffUsersListTableAdapter dd = new StaffUsersListTableAdapter();
            return dd.GetData();
        }

        public static void CreateUser(string GroupName, 
                    string Description, 
                    global::System.Nullable<bool> IsPublic, 
                    global::System.Nullable<int> MembershipTermInDays, 
                    global::System.Nullable<bool> IsDomain, 
                    global::System.Nullable<int> DefaultRole, 
                    global::System.Nullable<int> IsRegistrationDefault, 
                    object CustomAttributes
                    ,string InviteEmailText
                    ,string TermsOfUse 
                    ,string IconUrl 
                    ,global::System.Nullable<int> IsEndUserRegistrationDefault 
                    ,global::System.Nullable<int> IsStaffRegistrationDefault, 
                    global::System.Nullable<bool> IsOpen, 
                    global::System.Nullable<bool> IsPatientCareTeam
                    ,string ImageUrl
                    ,global::System.Nullable<bool> IsOpenStaff, 
                    global::System.Nullable<bool> IsServiceLine, 
                    global::System.Nullable<bool> IsCommunity, 
                    global::System.Nullable<bool> IsCoreGroup, 
                    string FaxNumber, 
                    string FacilityID, 
                    global::System.Nullable<int> DisplayOrder, 
                    string CopayDiscount, 
                    string ServiceLineCopayAmount
                    ,byte[] BinaryImageValue
                    ,string ProviderNoteTemplate, 
                    global::System.Nullable<int> MinutesBeforeEscalating, 
                    string CustomCSS
                    ,global::System.Nullable<int> MinutesBeforeAdminEscalating, 
                    global::System.Nullable<bool> CheckForOnCallDoctor, 
                    string OffDutyWarningMessage, 
                    string NoFutureSchedulesWarningMessage, 
                    string ApptReminderNoticeTextPatient, 
                    string ApptReminderNoticePeriodPatient, 
                    string ApptReminderNoticeTextStaff, 
                    string ApptReminderNoticePeriodStaff
                    ,global::System.Nullable<bool> IsPageRequired, 
                    global::System.Nullable<bool> IsEnableForCart, 
                    string AtomIconUrl
            )
        {
            DsToTableAdapters.zz_CopyGroupTableAdapter dd = new zz_CopyGroupTableAdapter();
            dd.GetData(GroupName, Description, IsPublic, MembershipTermInDays, IsDomain, DefaultRole, IsRegistrationDefault, CustomAttributes, InviteEmailText, TermsOfUse,
                    IconUrl, IsEndUserRegistrationDefault, IsStaffRegistrationDefault, IsOpen, IsPatientCareTeam, ImageUrl, IsOpenStaff, IsServiceLine, IsCommunity,
                    IsCoreGroup, FaxNumber, FacilityID, DisplayOrder, CopayDiscount, ServiceLineCopayAmount, BinaryImageValue, ProviderNoteTemplate, MinutesBeforeEscalating,
                    CustomCSS, MinutesBeforeAdminEscalating, CheckForOnCallDoctor, OffDutyWarningMessage, NoFutureSchedulesWarningMessage, ApptReminderNoticeTextPatient,
                    ApptReminderNoticePeriodPatient, ApptReminderNoticeTextStaff, ApptReminderNoticePeriodStaff, IsPageRequired, IsEnableForCart, AtomIconUrl);
        }
    }
}
