using Prism.Ioc;
using Prism.Modularity;
using PrismFullApp1.Modules.ModuleName;
using PrismFullApp1.Services;
using PrismFullApp1.Services.Interfaces;
using PrismFullApp1.Views;
using System.Windows;

namespace PrismFullApp1
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
            containerRegistry.RegisterSingleton<IMessageService, MessageService>();
        }

        protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
        {
            moduleCatalog.AddModule<ModuleNameModule>();
        }
    }
}
