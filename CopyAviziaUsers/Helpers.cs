using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopyAviziaUsers
{
   public class Helpers
    {
       public const string QueryForCounters = "select (SELECT count(rz_User.UserID) FROM rz_User INNER JOIN rz_UserRoles ON rz_User.UserID = rz_UserRoles.UserID where Role = 2) StaffUsersCount,(select count(1) from rz_Group) GroupsCount";
       public const string QueryForAllGroups = "select * from rz_Group";
       public const string QueryForAllStaffUsers = "SELECT rz_User.* FROM rz_User INNER JOIN rz_UserRoles ON rz_User.UserID = rz_UserRoles.UserID where Role = 2";
    }
}
