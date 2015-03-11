using System;
using Xamarin.Forms.Platform.Android;
using Xamarin.Forms;
using NativeWebView = Android.Webkit.WebView;
using Kan.XUtils.Droid;
using Kan.XUtils.Forms;

[assembly: ExportRenderer(typeof(XWebView), typeof(XWebViewRenderer))]
namespace Kan.XUtils.Droid
{
	public class XWebViewRenderer : WebViewRenderer	{
		protected override void OnElementChanged (ElementChangedEventArgs<WebView> e)
		{
			base.OnElementChanged (e);

			if (Control == null) {
				//It should never be null 
				return;
			}

			var webViewClient = new XWebViewClient ();

			webViewClient.PageFinished += (sender, webViewEventArgs) => {
				var element = Element as XWebView;
				if (element == null){
					return;
				}

				//TODO: Find another way to invoke event from XF inside renderer
				element.InvokePageFinished(element, webViewEventArgs);
			};

			webViewClient.PageStarted += (sender, webViewEventArgs) => {
				var element = Element as XWebView;
				if (element == null){
					return;
				}

				//TODO: Find another way to invoke event from XF inside renderer
				element.InvokePageStarted(element, webViewEventArgs);
			};

			Control.SetWebViewClient (webViewClient);
		}
	}

	
}

