using System;
using System.Collections.Generic;
using System.Text;

namespace AMK.Exp.Autofac
{
    internal class ConsoleNotification : INotificationService
    {
        public void NotifyUsernameChanged(string username)
        {
            Console.WriteLine($"Changed the username to {username}");
        }
    }
}
