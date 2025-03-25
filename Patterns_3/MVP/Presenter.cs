namespace Patterns_3.MVP;

public class UserPresenter
{
    private readonly IUserView _view;
    private readonly UserModel _model;

    public UserPresenter(IUserView view)
    {
        _view = view;
        _model = new UserModel();
        _view.SaveClicked += OnSave;
    }

    private void OnSave(object sender, EventArgs e)
    {
        _model.FirstName = _view.FirstName;
        _model.LastName = _view.LastName;
        _view.FullName = _model.FullName;
    }
}