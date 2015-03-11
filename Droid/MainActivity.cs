using System;

using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using ZXing.Mobile;
using System.Collections.Generic;
using ZXing;
using Android.Webkit;

namespace Kan.Sample.Droid
{
	[Activity (Label = "Kan.Sample.Droid", Icon = "@drawable/icon", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
	public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsApplicationActivity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

//			SetContentView (Resource.Layout.Main);
//
//			Button btnScan = FindViewById (Resource.Id.btnScan) as Button;
//			WebView webView = FindViewById (Resource.Id.webView) as WebView;
//			webView.LoadUrl ("http://vnexpress.net");
//
//			WebViewClient client = new WebViewClient (){
//			 };
//			webView.SetWebViewClient (client);
//
//
//
//
//			btnScan.Click += async (sender, e) =>  {
//				//NOTE: On Android you MUST pass a Context into the Constructor!
//				var scanner = new MobileBarcodeScanner(this);
//
////				var options = new MobileBarcodeScanningOptions {PossibleFormats = new List<BarcodeFormat> {
////						BarcodeFormat.QR_CODE
////					}
////				};
////
//				var result = await scanner.Scan();
//
//				if (result != null){
//					webView.LoadUrl(result.Text);
//				}
//			};

			global::Xamarin.Forms.Forms.Init (this, bundle);

			LoadApplication (new App ());
		}
	}
}

