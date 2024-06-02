using Microsoft.AspNetCore.Identity;
using QuestionProjectCore.Models;

namespace QuestionProjectCore.Repository.Main
{
    public interface IAdminRepo : IRepository<ApplicationUser>
    {
         string GetUsername();
         string GetRoleName();
    }
}
