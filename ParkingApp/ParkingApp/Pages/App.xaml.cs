﻿using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
[assembly: ExportFont("Roboto-Light.ttf", Alias = "RobotoLight")]
[assembly: ExportFont("Roboto-Medium.ttf", Alias = "RobotoMedium")]

namespace ParkingApp.Pages
{
	/// <summary>
	/// Основной класс приложения.
	/// </summary>
	public partial class App : Application
	{
		public App()
		{
			InitializeComponent();
			MainPage = new NavigationPage(new MainPage());
		}
	
		protected override void OnStart()
		{
			// Handle when your app starts
		}

		protected override void OnSleep()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume()
		{
			// Handle when your app resumes
		}
	}
}