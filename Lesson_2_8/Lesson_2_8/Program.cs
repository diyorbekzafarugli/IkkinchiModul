using Lesson_2_8.Services;

namespace Lesson_2_8;

internal class Program
{
    static void Main(string[] args)
    {
        INotificationService notification = GetNotification();
        notification.SendNotification();

    }


    public static INotificationService GetNotification()
    {
        INotificationService otherNotification = new AccountService();
        //INotificationService otherNotification = new TeamService();
        //INotificationService otherNotification = new EmailService();

        return otherNotification;
    }
}
