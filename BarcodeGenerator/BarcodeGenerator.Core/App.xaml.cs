using BarcodeGenerator.Core.ViewModels;
using BarcodeGenerator.Core.Views;
using Prism;
using Prism.Ioc;
using Prism.Modularity;
using Xamarin.Essentials.Implementation;
using Xamarin.Essentials.Interfaces;
using Xamarin.Forms;

namespace BarcodeGenerator.Core
{
	public partial class App
	{
		public App(IPlatformInitializer initializer)
			: base(initializer)
		{
		}

		protected override async void OnInitialized()
		{
			InitializeComponent();

			await NavigationService.NavigateAsync("NavigationPage/MainPage");
		}

		protected override void RegisterTypes(IContainerRegistry containerRegistry)
		{
			containerRegistry.RegisterSingleton<IAppInfo, AppInfoImplementation>();

			containerRegistry.RegisterForNavigation<NavigationPage>();
			containerRegistry.RegisterForNavigation<MainPage, MainPageViewModel>();
		}

		protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
		{
		}
	}
}
