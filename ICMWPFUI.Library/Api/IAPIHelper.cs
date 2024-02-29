using ICMWPFUI.Models;
using System.Threading.Tasks;

namespace ICMWPFUI.Library.Api
{
    public interface IAPIHelper
    {
        System.Threading.Tasks.Task<AuthenticatedUser> Authenticate(string username, string password);

        Task GetLoggedInUserInfo(string token);
    }
}