alter PROCEDURE dbo.zz_CopyUserGroup
(
@UserId int,
@GroupName varchar(max)
	)
	AS
begin

declare @GroupID int
set @GroupID = (select top(1) GroupID from rz_Group where GroupName = REPLACE( @GroupName,'@@',''''))
if (@GroupID is not null)
begin
	INSERT INTO rz_UserGroupMap
                         (GroupID, UserID, DateAdded, AddedBy, IsActive, DateActive, ActiveBy)
VALUES        (@GroupID,@UserId,GETDATE(),1,1,GETDATE(),1)
end
end
