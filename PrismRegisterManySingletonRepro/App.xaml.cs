using Prism.Ioc;
using PrismRegisterManySingletonRepro.Domain;
using PrismRegisterManySingletonRepro.Views;
using System.Windows;

namespace PrismRegisterManySingletonRepro
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterManySingleton<FooBar>(typeof(IFoo), typeof(IBar));
        }
    }
}
