using Abp.Authorization;
using helpthem-back.Authorization.Roles;
using helpthem-back.Authorization.Users;

namespace helpthem-back.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
