XUtils
===================

While working with Xamarin, I found that there are stuff that we could use very often but it doesn't exist inside the release of Xamarin libraries. So I created this repository to store my handy stuff.

----------


Android: XWebViewClient
-------------

When working with **Android** `WebView`, we usually have to create a subclass of `WebViewClient` to capture page loading events. I think the reason is the nature of its original Java way when we could create an anonymous class inline very easily. However, we are in C# world, we have the beautiful feature of handling event with `EventHandler<>`. So I did create class `XWebViewClient` to expose 
*PageFinished/PageStarted* just like we could find when using `UIWebView` in **iOS**

Xamarin.Forms: XWebView & XWebViewRenderer
-------------

Current version of **Xamarin.Forms** `WebView` doesn't allow us to handle page events which we could do easily with **iOS** `UIWebView` and the above **Android** custom `XWebViewClient`. So, I created `XWebView` class and its associated renderers in order to provide that goal.
