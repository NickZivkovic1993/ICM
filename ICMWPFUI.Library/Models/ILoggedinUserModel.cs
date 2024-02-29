namespace ICMWPFUI.Library.Models
{
    public interface ILoggedinUserModel
    {
        string CreatedDate { get; set; }
        string EmailAddresse { get; set; }
        string FirstName { get; set; }
        string Id { get; set; }
        string LastName { get; set; }
        string Token { get; set; }
    }
}