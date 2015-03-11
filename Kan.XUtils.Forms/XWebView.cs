using System;
using Xamarin.Forms;

namespace Kan.XUtils.Forms
{
	public class XWebView : WebView 
	{
		public event EventHandler<WebViewEventArgs> PageFinished;
		public event EventHandler<WebViewEventArgs> PageStarted;

		public void InvokePageFinished(object sender, WebViewEventArgs e)
		{
			var handler = PageFinished;

			if(handler != null){
				handler(sender, e);
			}
		}

		public void InvokePageStarted(object sender, WebViewEventArgs e)
		{
			var handler = PageStarted;

			if(handler != null){
				handler(sender, e);

			}
		}
	}
}

