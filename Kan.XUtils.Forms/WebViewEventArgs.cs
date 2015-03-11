using System;
using Xamarin.Forms;

namespace Kan.XUtils.Forms
{
	public class WebViewEventArgs : EventArgs {
		public string Url {
			get;
			set;
		}
	}

	public class WebViewScaleChangeEventArgs: EventArgs {
		public float OldScale {
			get;
			set;
		}

		public float NewScale {
			get;
			set;
		}
	}

}
