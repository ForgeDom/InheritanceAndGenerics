namespace Patterns_3.MVC;

public class UserController
{
    private readonly UserModel _model;
    private readonly UserView _view;

    public UserController(UserModel model, UserView view)
    {
        _model = model;
        _view = view;
    }

    public void ShowAllUsers()
    {
        var users = _model.GetAllUsers();
        _view.ShowUsers(users);
    }

    public void ShowUser(int id)
    {
        var user = _model.GetUser(id);
        _view.ShowUser(user);
    }

    public void AddUser()
    {
        var user = _view.GetUserInput();
        _model.AddUser(user);
        Console.WriteLine("Користувача додано успішно!");
    }
}