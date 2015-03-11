using System;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using Kan.XUtils.Forms;
using Kan.XUtils.iOS;

[assembly:ExportRenderer(typeof(XWebView), typeof(XWebViewRenderer))]
namespace Kan.XUtils.iOS
{
	public class XWebViewRenderer : WebViewRenderer
	{
		protected override void OnElementChanged (VisualElementChangedEventArgs e)
		{
			base.OnElementChanged (e);

			if (e.OldElement == null) {
				LoadFinished += (sender, evt) => {
					var element = Element as XWebView;
					if (element != null) {
						element.InvokePageFinished(element, new WebViewEventArgs());
					}
				};

				LoadStarted += (sender, evt) => {
					var element = Element as XWebView;
					if (element != null) {
						element.InvokePageStarted (element, new WebViewEventArgs ());
					}
				};
			}
		}
	}
}

