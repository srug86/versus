using System;
using Autofac;
using Versus.Core.ViewModels;
using Versus.Core.Services.General;
using Versus.Core.Services.Data;
using Versus.Core.Contracts.Services.General;
using Versus.Core.Contracts.Services.Data;

namespace Versus.Core.Bootstrap
{
    public class AppContainer
    {
        private static IContainer _container;

        public static void RegisterDependencies()
        {
            var builder = new ContainerBuilder();

            //ViewModels
            builder.RegisterType<SignInViewModel>();
            builder.RegisterType<MainViewModel>();

            //services - data

            //services - general
            builder.RegisterType<ConnectionService>().As<IConnectionService>();
            builder.RegisterType<NavigationService>().As<INavigationService>();
            builder.RegisterType<AuthenticationService>().As<IAuthenticationService>();
            builder.RegisterType<DialogService>().As<IDialogService>();

            //General

            _container = builder.Build();
        }

        public static object Resolve(Type typeName)
        {
            return _container.Resolve(typeName);
        }

        public static T Resolve<T>()
        {
            return _container.Resolve<T>();
        }
    }
}
