using System;
using Xamarin.Forms.Platform.Android;
using Xamarin.Forms;
using NativeWebView = Android.Webkit.WebView;
using Kulos.Droid.WebViewExtensions;

[assembly: ExportRenderer(typeof(NativeWebView), typeof(XWebViewRenderer))]
namespace Kulos.Droid.WebViewExtensions
{
	public class XWebViewRenderer : WebViewRenderer
	{
		protected override void OnElementChanged (ElementChangedEventArgs<WebView> e)
		{
			base.OnElementChanged (e);

			if (Control == null) {
				var control = new NativeWebView (Context);
				SetNativeControl (control);
			}
			var webViewClient = new XWebViewClient ();

			webViewClient.PageFinished += (sender, webViewEventArgs) => {
				var element = Element as XWebView;
				if (element == null){
					return;
				}

				var handler = element.PageFinished;

				if (handler != null) {
					handler(sender, webViewEventArgs);
				}
			};

			Control.SetWebViewClient (webViewClient);
		}
	}
}

