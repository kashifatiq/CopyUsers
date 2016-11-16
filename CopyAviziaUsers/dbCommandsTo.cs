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

        public static void CreateGroup(string GroupName, 
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

        public static int CreateUser(string UserName,
                    string Password,
                    string Email,
                    string FirstName,
                    string LastName,
                    string MiddleName,
                    string CellPhone,
                    string WorkPhone,
                    string HomePhone,
                    global::System.Nullable<global::System.DateTime> DOB,
                    string GUID,
                    global::System.Nullable<global::System.DateTime> DateCreated,
                    global::System.Nullable<global::System.DateTime> dateedited,
                    global::System.Nullable<global::System.DateTime> DateDeleted,
                    global::System.Nullable<int> CreatedBy,
                    global::System.Nullable<int> IsPublic,
                    global::System.Nullable<bool> IsDomain,
                    string Inactive,
                    string ReasonInactive,
                    global::System.Nullable<bool> ChangePassword,
                    string Verified,
                    string Online,
                    global::System.Nullable<bool> IsDeleted,
                    global::System.Nullable<bool> agreed_terms,
                    global::System.Nullable<int> ResponseID,
                    string PreferredLanguage,
                    global::System.Nullable<int> FailedLoginAttempts,
                    global::System.Nullable<global::System.DateTime> LastLogin,
                    global::System.Nullable<global::System.DateTime> LastActive,
                    string GoogleUserName,
                    string GooglePassword,
                    string ConferencingUserName,
                    string ConferencingPassword,
                    global::System.Nullable<bool> IsLocked,
                    string City,
                    string State,
                    string ZipCode,
                    string Sex,
                    string StaffNPI,
                    string StaffDEANumber,
                    string StaffMedicalLicenseNumber,
                    string PagerNumber,
                    string FaxNumber,
                    string Address1,
                    string Address2,
                    global::System.Nullable<int> onepassuserid,
                    string MRN,
                    global::System.Nullable<bool> CellPhoneVerified,
                    string ExternalID,
                    string ExternalUserID,
                    string SourceFacility,
                    global::System.Nullable<int> SourceFacility_FacilityID,
                    global::System.Nullable<bool> onepass_agreed_terms,
                    string XmppUserName,
                    string XmppPassword,
                    string GroupPager,
                    string AnsweringServicePhone,
                    string AdditionalLocationPhone,
                    string ContactPrefVoiceOnCall,
                    string ContactPrefVoiceOffCall,
                    string ContactPrefNotificationOnCall,
                    string ContactPrefNotificationOffCall,
                    string UniquePatientGUID,
                    string vCard,
                    string PracticeAreas,
                    string PracticeFacilities,
                    string PracticeZipCodes,
                    string SSN,
                    string Race,
                    string VideoAddress,
                    string UniqueValue,
                    string Photo,
                    string Country,
                    string FileServiceKey,
                    string ExternalAuthUserName,
                    string VideoType,
                    string PrimarySpecialty
           )
        {
            DsToTableAdapters.zz_CopyUsersTableAdapter dd = new zz_CopyUsersTableAdapter();
          DataTable dt =  dd.GetData(UserName,
                    Password,
                    Email,
                    FirstName,
                    LastName,
                    MiddleName,
                    CellPhone,
                    WorkPhone,
                    HomePhone,
                    DOB,
                    GUID,
                    DateCreated,
                    dateedited,
                    DateDeleted,
                    CreatedBy,
                    IsPublic,
                    IsDomain,
                    Inactive,
                    ReasonInactive,
                    ChangePassword,
                    Verified,
                    Online,
                    IsDeleted,
                    agreed_terms,
                    ResponseID,
                    PreferredLanguage,
                    FailedLoginAttempts,
                    LastLogin,
                    LastActive,
                    GoogleUserName,
                    GooglePassword,
                    ConferencingUserName,
                    ConferencingPassword,
                    IsLocked,
                    City,
                    State,
                    ZipCode,
                    Sex,
                    StaffNPI,
                    StaffDEANumber,
                    StaffMedicalLicenseNumber,
                    PagerNumber,
                    FaxNumber,
                    Address1,
                    Address2,
                    onepassuserid,
                    MRN,
                    CellPhoneVerified,
                    ExternalID,
                    ExternalUserID,
                    SourceFacility,
                    SourceFacility_FacilityID,
                    onepass_agreed_terms,
                    XmppUserName,
                    XmppPassword,
                    GroupPager,
                    AnsweringServicePhone,
                    AdditionalLocationPhone,
                    ContactPrefVoiceOnCall,
                    ContactPrefVoiceOffCall,
                    ContactPrefNotificationOnCall,
                    ContactPrefNotificationOffCall,
                    UniquePatientGUID,
                    vCard,
                    PracticeAreas,
                    PracticeFacilities,
                    PracticeZipCodes,
                    SSN,
                    Race,
                    VideoAddress,
                    UniqueValue,
                    Photo,
                    Country,
                    FileServiceKey,
                    ExternalAuthUserName,
                    VideoType,
                    PrimarySpecialty
                    );
          if (dt.Rows.Count > 0)
              return Convert.ToInt32(dt.Rows[0]["Column1"].ToString());
          else
              return 0;
        }

        public static void CopyGroupMap(int UserID,string GroupName)
        {
            DsToTableAdapters.zz_CopyUserGroupTableAdapter dd = new zz_CopyUserGroupTableAdapter();
            dd.GetData(UserID, GroupName);
        }
    }
}
