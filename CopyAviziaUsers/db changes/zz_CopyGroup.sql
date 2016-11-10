ALTER PROCEDURE [dbo].[zz_CopyGroup]
(@GroupName varchar(255), 
@Description varchar(255),
@IsPublic bit, 
@MembershipTermInDays int,
@IsDomain bit, 
@DefaultRole int, 
@IsRegistrationDefault int, 
@CustomAttributes xml,
@InviteEmailText varchar(max), 
@TermsOfUse varchar(max), 
@IconUrl varchar(max), 
@IsEndUserRegistrationDefault int, 
@IsStaffRegistrationDefault int, 
@IsOpen bit, 
@IsPatientCareTeam bit, 
@ImageUrl varchar(max), 
@IsOpenStaff bit, 
@IsServiceLine bit, 
@IsCommunity bit, 
@IsCoreGroup bit, 
@FaxNumber varchar(max), 
@FacilityID varchar(max), 
@DisplayOrder int, 
@CopayDiscount varchar(max), 
@ServiceLineCopayAmount varchar(250), 
@BinaryImageValue varbinary(max), 
@ProviderNoteTemplate varchar(max), 
@MinutesBeforeEscalating int, 
@CustomCSS varchar(max), 
@MinutesBeforeAdminEscalating int, 
@CheckForOnCallDoctor bit, 
@OffDutyWarningMessage varchar(max), 
@NoFutureSchedulesWarningMessage varchar(max), 
@ApptReminderNoticeTextPatient varchar(max), 
@ApptReminderNoticePeriodPatient varchar(max), 
@ApptReminderNoticeTextStaff varchar(max), 
@ApptReminderNoticePeriodStaff varchar(max), 
@IsPageRequired bit, 
@IsEnableForCart bit, 
@AtomIconUrl varchar(max))               
AS 
BEGIN   
set @GroupName = REPLACE(@GroupName,'@@','''')
set @Description = REPLACE(@Description,'@@','''')
if NOT EXISTS (select GroupID from rz_Group where GroupName = @GroupName)
	BEGIN
		INSERT INTO rz_Group
								 (GroupName, Description, DateCreated, CreatedBy, IsPublic, MembershipTermInDays, IsDomain, DefaultRole, IsRegistrationDefault, 
								 CustomAttributes,InviteEmailText, TermsOfUse, IconUrl, IsEndUserRegistrationDefault, IsStaffRegistrationDefault, 
								 IsOpen, IsPatientCareTeam, ImageUrl, IsOpenStaff, IsServiceLine, IsCommunity, IsCoreGroup, 
								 FaxNumber, FacilityID, DisplayOrder, CopayDiscount, ServiceLineCopayAmount, BinaryImageValue, ProviderNoteTemplate, 
								 MinutesBeforeEscalating, CustomCSS, MinutesBeforeAdminEscalating, CheckForOnCallDoctor, OffDutyWarningMessage, 
								 NoFutureSchedulesWarningMessage, ApptReminderNoticeTextPatient, ApptReminderNoticePeriodPatient, 
								 ApptReminderNoticeTextStaff, ApptReminderNoticePeriodStaff, IsPageRequired, IsEnableForCart, AtomIconUrl)
		VALUES         (@GroupName,@Description, GETDATE(), 1, @IsPublic, @MembershipTermInDays, @IsDomain, @DefaultRole, @IsRegistrationDefault, 
								 @CustomAttributes,@InviteEmailText, @TermsOfUse, @IconUrl, @IsEndUserRegistrationDefault, @IsStaffRegistrationDefault, 
								 @IsOpen, @IsPatientCareTeam, @ImageUrl, @IsOpenStaff, @IsServiceLine, @IsCommunity, @IsCoreGroup, 
								 @FaxNumber, @FacilityID, @DisplayOrder, @CopayDiscount, @ServiceLineCopayAmount, @BinaryImageValue, @ProviderNoteTemplate, 
								 @MinutesBeforeEscalating, @CustomCSS, @MinutesBeforeAdminEscalating, @CheckForOnCallDoctor, @OffDutyWarningMessage, 
								 @NoFutureSchedulesWarningMessage, @ApptReminderNoticeTextPatient, @ApptReminderNoticePeriodPatient, 
								 @ApptReminderNoticeTextStaff, @ApptReminderNoticePeriodStaff, @IsPageRequired, @IsEnableForCart, @AtomIconUrl)
	END
END