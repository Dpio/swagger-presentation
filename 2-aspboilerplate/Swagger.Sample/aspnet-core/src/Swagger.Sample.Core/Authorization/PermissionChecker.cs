using Abp.Authorization;
using Swagger.Sample.Authorization.Roles;
using Swagger.Sample.Authorization.Users;

namespace Swagger.Sample.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
