using Autofac;
using System;

namespace AMK.Exp.Autofac
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var containerBuilder = new ContainerBuilder();

            containerBuilder.RegisterType<ConsoleNotification>().As<INotificationService>();
            containerBuilder.RegisterType<UserService>().AsSelf();
            //containerBuilder.RegisterModule<ProgramModule>();

            var container = containerBuilder.Build();


            var notificationService = container.Resolve<INotificationService>();
            var userService = container.Resolve<UserService>();

            var user1 = new User("Manik");

            userService.ChangeUsername(user1, "Mani");

            Console.ReadKey();
        }
    }
}
