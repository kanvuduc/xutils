using System;

using Xamarin.Forms;
using Kan.XUtils.Forms;

namespace Kan.Sample
{
	public class App : Application
	{
		public App ()
		{
			var webView = new XWebView {
				Source = "http://vnexpress.net",
				HorizontalOptions = LayoutOptions.Fill,
				VerticalOptions = LayoutOptions.Fill
			};

			webView.PageStarted += delegate {
				MainPage.DisplayAlert("Page Started", "Page started event handling", "Ok");
			};

			webView.PageFinished += delegate {
				MainPage.DisplayAlert("Page Finished", "Page finished event handling", "Ok");
			};

			// The root page of your application
			MainPage = new ContentPage {
				Content = webView
			};
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}

