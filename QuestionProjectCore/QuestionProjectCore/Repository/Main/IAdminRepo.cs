using Microsoft.AspNetCore.Identity;

namespace QuestionProjectCore.Repository.Main
{
    public interface IAdminRepo : IRepository<IdentityUser>
    {
         string GetUsername();
         string GetRoleName();
    }
}
