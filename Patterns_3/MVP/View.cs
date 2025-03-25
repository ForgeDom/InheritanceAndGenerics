namespace Patterns_3.MVP;

public interface IUserView
{
    string FirstName { get; set; }
    string LastName { get; set; }
    string FullName { get; set; }
    
    event EventHandler SaveClicked;
}