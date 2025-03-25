namespace Patterns_3.MVC;

public class UserModel
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }

    private static List<UserModel> _users = new List<UserModel>
    {
        new UserModel { Id = 1, Name = "Іван Петренко", Email = "ivan@example.com" },
        new UserModel { Id = 2, Name = "Марія Сидоренко", Email = "maria@example.com" }
    };

    public List<UserModel> GetAllUsers() => _users;

    public UserModel GetUser(int id) => _users.FirstOrDefault(u => u.Id == id);

    public void AddUser(UserModel user)
    {
        user.Id = _users.Count + 1;
        _users.Add(user);
    }
}