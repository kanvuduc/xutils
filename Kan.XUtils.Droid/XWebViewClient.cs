using System;
using Android.Webkit;
using Kan.XUtils.Forms;

namespace Kan.XUtils.Droid
{
	public class XWebChromeClient : WebChromeClient {

	}

	public class XWebViewClient : WebViewClient {
		public event EventHandler<WebViewEventArgs> PageFinished;
		public event EventHandler<WebViewEventArgs> PageStarted;
		public event EventHandler<WebViewEventArgs> LoadResource;

		public override void OnReceivedError (WebView view, ClientError errorCode, string description, string failingUrl)
		{
			base.OnReceivedError (view, errorCode, description, failingUrl);
		}

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

		public override void OnPageStarted (WebView view, string url, Android.Graphics.Bitmap favicon)
		{
			base.OnPageStarted (view, url, favicon);

			//TODO: favicon -> Should to send along with URL
			var handler = PageStarted;
			if (handler != null) {
				handler (view, new WebViewEventArgs { 
					Url = url
				});
			}
		}

	}

}

