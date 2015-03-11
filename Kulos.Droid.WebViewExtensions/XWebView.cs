using System;
using Android.Webkit;

namespace Kulos.Droid.WebViewExtensions
{
	public class WebViewEventArgs : EventArgs {
		public string Url {
			get;
			set;
		}
	}

	internal class XWebViewClient : WebViewClient {
		public event EventHandler<WebViewEventArgs> PageFinished;

		public override void OnPageFinished (WebView view, string url)
		{
			base.OnPageFinished (view, url);

			var handler = PageFinished;
			if (handler != null) {
				handler (view, new WebViewEventArgs { 
					Url = url
				});
			}
		}
	}

	public class XWebView : Xamarin.Forms.WebView {
		public event EventHandler<WebViewEventArgs> PageFinished;
	}

}

