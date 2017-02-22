// /*******************************************************************
//  *
//  * SharedApp.cs copyright 2017 ben, 42nd Parallel - ALL RIGHTS RESERVED.
//  *
//  *******************************************************************/
using System;

using Xamarin.Forms;

namespace SharedApp
{
	public class App : Application
	{
		public App()
		{
			// The root page of your application
			MainPage = new Forms9Patch.RootPage(new NavigationPage(new HomePage()));
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
