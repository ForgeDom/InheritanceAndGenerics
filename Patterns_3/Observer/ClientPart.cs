using Patterns_3.Observer.Observers;
using Patterns_3.Observer.Subjects;
namespace Patterns_3.Observer;

public class ClientPart
{
    public void Main()
    {
        Console.WriteLine("Демонстрація патерну Observer");

        var publisher = new NewsPublisher();

        var emailSub = new EmailSubscriber("user@example.com");
        var smsSub = new SmsSubscriber("+380991234567");

        publisher.RegisterObserver(emailSub);
        publisher.RegisterObserver(smsSub);

        publisher.SetLatestNews("Перша новина: Вийшов новий .NET 6!");

        publisher.RemoveObserver(smsSub);
        publisher.SetLatestNews("Оновлена новина: Виправлені баги в .NET 6");

        Console.ReadKey();
    }
}