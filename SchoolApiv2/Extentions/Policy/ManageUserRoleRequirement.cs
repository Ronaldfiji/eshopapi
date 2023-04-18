using Microsoft.AspNetCore.Authorization;

namespace SchoolApiv2.Extentions.Policy
{
    public class ManageUserRoleRequirement : IAuthorizationRequirement
    {
        public string UserName { get; private set; }
        public ManageUserRoleRequirement(string username)
        {
            UserName = username;
        }
    }
}
