using Patterns_3.Observer.Interfaces;

namespace Patterns_3.Observer.Subjects;

public class NewsPublisher : ISubject
{
    private List<IObserver> _observers = new List<IObserver>();
    private string _latestNews;

    public void RegisterObserver(IObserver observer)
    {
        if (!_observers.Contains(observer))
        {
            _observers.Add(observer);
        }
    }

    public void RemoveObserver(IObserver observer)
    {
        _observers.Remove(observer);
    }
    public void NotifyObservers(string message)
    {
        foreach (var observer in _observers)
        {
            observer.Update(_latestNews);
        }
    }

    public void SetLatestNews(string news)
    {
        _latestNews = news;
        NotifyObservers(_latestNews);
    }
}