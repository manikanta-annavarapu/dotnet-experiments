using Autofac;
using System;
using System.Collections.ObjectModel;

namespace AMK.Exp.Autofac
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ReadOnlyCollection<TimeZoneInfo> tz;
            tz = TimeZoneInfo.GetSystemTimeZones();
            
            foreach(var t in tz)
            {
                Console.WriteLine(t.StandardName);
            }
            //var containerBuilder = new ContainerBuilder();

            //containerBuilder.RegisterModule<ProgramModule>();

            //var container = containerBuilder.Build();


            //var notificationService = container.Resolve<INotificationService>();
            //var userService = container.Resolve<UserService>();

            //var user1 = new User("Manik");

            //userService.ChangeUsername(user1, "Mani");

            //Console.ReadKey();
        }
    }
}
