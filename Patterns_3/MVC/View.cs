namespace Patterns_3.MVC;

public class UserView
{
    public void ShowUsers(List<UserModel> users)
    {
        Console.WriteLine("Список користувачів:");
        foreach (var user in users)
        {
            Console.WriteLine($"ID: {user.Id}, Ім'я: {user.Name}, Email: {user.Email}");
        }
    }

    public void ShowUser(UserModel user)
    {
        if (user != null)
        {
            Console.WriteLine($"Деталі користувача:\nID: {user.Id}\nІм'я: {user.Name}\nEmail: {user.Email}");
        }
        else
        {
            Console.WriteLine("Користувача не знайдено");
        }
    }

    public UserModel GetUserInput()
    {
        Console.Write("Введіть ім'я: ");
        string name = Console.ReadLine();
        Console.Write("Введіть email: ");
        string email = Console.ReadLine();
        return new UserModel { Name = name, Email = email };
    }
}