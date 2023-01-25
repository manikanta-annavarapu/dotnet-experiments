using Autofac;
using System;
using System.Collections.Generic;
using System.Text;

namespace AMK.Exp.Autofac
{
    internal class ProgramModule : Module
    {
        protected override void Load(ContainerBuilder containerBuilder)
        {
            containerBuilder.RegisterType<ConsoleNotification>().As<INotificationService>();
            containerBuilder.RegisterType<UserService>().AsSelf();
        }
    }
}
