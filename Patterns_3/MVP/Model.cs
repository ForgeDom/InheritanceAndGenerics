namespace Patterns_3.MVP;

public class UserModel
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    
    public string FullName => $"{FirstName} {LastName}";
}