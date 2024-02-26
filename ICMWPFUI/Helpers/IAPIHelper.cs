using ICMWPFUI.Models;

namespace ICMWPFUI.Helpers
{
    public interface IAPIHelper
    {
        System.Threading.Tasks.Task<AuthenticatedUser> Authenticate(string username, string password);
    }
}