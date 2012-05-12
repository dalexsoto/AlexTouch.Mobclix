//
// Auto-generated from generator.cs, do not edit
//
// We keep references to objects, so warning 414 is expected

#pragma warning disable 414

using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MonoTouch;
using MonoTouch.CoreFoundation;
using MonoTouch.CoreMedia;
using MonoTouch.CoreMotion;
using MonoTouch.Foundation;
using MonoTouch.ObjCRuntime;
using MonoTouch.CoreAnimation;
using MonoTouch.CoreLocation;
using MonoTouch.MapKit;
using MonoTouch.UIKit;
using MonoTouch.CoreGraphics;
using MonoTouch.NewsstandKit;
using MonoTouch.GLKit;
using OpenTK;

namespace AlexTouch.Mobclix {
	[Register("MCBrowserViewController", true)]
	public unsafe partial class MCBrowserViewController : MonoTouch.UIKit.UIViewController {
		static IntPtr selWebView = Selector.GetHandle ("webView");
		static IntPtr selDelegate = Selector.GetHandle ("delegate");
		static IntPtr selSetDelegate_ = Selector.GetHandle ("setDelegate:");
		static IntPtr selAutoDismissOnResignActive = Selector.GetHandle ("autoDismissOnResignActive");
		static IntPtr selSetAutoDismissOnResignActive_ = Selector.GetHandle ("setAutoDismissOnResignActive:");
		static IntPtr selInitWithURLRequest_ = Selector.GetHandle ("initWithURLRequest:");
		static IntPtr selInitWithURLRequestBrowserStyle_ = Selector.GetHandle ("initWithURLRequest:browserStyle:");
		static IntPtr selInitWithEmbeddedHTMLBaseURL_ = Selector.GetHandle ("initWithEmbeddedHTML:baseURL:");
		static IntPtr selInitWithEmbeddedHTMLBaseURLBrowserStyle_ = Selector.GetHandle ("initWithEmbeddedHTML:baseURL:browserStyle:");
		static IntPtr selStopLoading = Selector.GetHandle ("stopLoading");
		static IntPtr selPreloadRequest = Selector.GetHandle ("preloadRequest");
		
		static IntPtr class_ptr = Class.GetHandle ("MCBrowserViewController");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[Export ("init")]
		public  MCBrowserViewController () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.Init);
			} else {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.Init);
			}
		}

		[CompilerGenerated]
		[Export ("initWithCoder:")]
		public MCBrowserViewController (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.InitWithCoder, coder.Handle);
			} else {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.InitWithCoder, coder.Handle);
			}
		}

		[CompilerGenerated]
		public MCBrowserViewController (NSObjectFlag t) : base (t) {}

		[CompilerGenerated]
		public MCBrowserViewController (IntPtr handle) : base (handle) {}

		[Export ("initWithURLRequest:")]
		[CompilerGenerated]
		public MCBrowserViewController (NSUrlRequest urlRequest) : base (NSObjectFlag.Empty)
		{
			if (urlRequest == null)
				throw new ArgumentNullException ("urlRequest");
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, selInitWithURLRequest_, urlRequest.Handle);
			} else {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, selInitWithURLRequest_, urlRequest.Handle);
			}
		}
		
		[Export ("initWithURLRequest:browserStyle:")]
		[CompilerGenerated]
		public MCBrowserViewController (NSUrlRequest urlRequest, MCBrowserStyle browserStyle) : base (NSObjectFlag.Empty)
		{
			if (urlRequest == null)
				throw new ArgumentNullException ("urlRequest");
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_int (this.Handle, selInitWithURLRequestBrowserStyle_, urlRequest.Handle, (int)browserStyle);
			} else {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr_int (this.SuperHandle, selInitWithURLRequestBrowserStyle_, urlRequest.Handle, (int)browserStyle);
			}
		}
		
		[Export ("initWithEmbeddedHTML:baseURL:")]
		[CompilerGenerated]
		public MCBrowserViewController (string embeddedHTML, NSUrl baseURL) : base (NSObjectFlag.Empty)
		{
			if (embeddedHTML == null)
				throw new ArgumentNullException ("embeddedHTML");
			if (baseURL == null)
				throw new ArgumentNullException ("baseURL");
			var nsembeddedHTML = NSString.CreateNative (embeddedHTML);
			
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (this.Handle, selInitWithEmbeddedHTMLBaseURL_, nsembeddedHTML, baseURL.Handle);
			} else {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, selInitWithEmbeddedHTMLBaseURL_, nsembeddedHTML, baseURL.Handle);
			}
			NSString.ReleaseNative (nsembeddedHTML);
		}
		
		[Export ("initWithEmbeddedHTML:baseURL:browserStyle:")]
		[CompilerGenerated]
		public MCBrowserViewController (string embeddedHTML, NSUrl baseURL, MCBrowserStyle browserStyle) : base (NSObjectFlag.Empty)
		{
			if (embeddedHTML == null)
				throw new ArgumentNullException ("embeddedHTML");
			if (baseURL == null)
				throw new ArgumentNullException ("baseURL");
			var nsembeddedHTML = NSString.CreateNative (embeddedHTML);
			
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_int (this.Handle, selInitWithEmbeddedHTMLBaseURLBrowserStyle_, nsembeddedHTML, baseURL.Handle, (int)browserStyle);
			} else {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_int (this.SuperHandle, selInitWithEmbeddedHTMLBaseURLBrowserStyle_, nsembeddedHTML, baseURL.Handle, (int)browserStyle);
			}
			NSString.ReleaseNative (nsembeddedHTML);
		}
		
		[Export ("stopLoading")]
		[CompilerGenerated]
		public virtual void StopLoading ()
		{
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selStopLoading);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper (this.SuperHandle, selStopLoading);
			}
		}
		
		[Export ("preloadRequest")]
		[CompilerGenerated]
		public virtual void PreloadRequest ()
		{
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selPreloadRequest);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper (this.SuperHandle, selPreloadRequest);
			}
		}
		
		object __mt_WebView_var;
		[CompilerGenerated]
		public virtual MonoTouch.UIKit.UIWebView WebView {
			[Export ("webView")]
			get {
				MonoTouch.UIKit.UIWebView ret;
				if (IsDirectBinding) {
					ret = (MonoTouch.UIKit.UIWebView) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selWebView));
				} else {
					ret = (MonoTouch.UIKit.UIWebView) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selWebView));
				}
				MarkDirty ();
				__mt_WebView_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public MCBrowserViewControllerDelegate Delegate {
			get { return WeakDelegate as MCBrowserViewControllerDelegate; }
			set { WeakDelegate = value; }
		}
		
		object __mt_WeakDelegate_var;
		[CompilerGenerated]
		public virtual NSObject WeakDelegate {
			[Export ("delegate", ArgumentSemantic.Assign)]
			get {
				NSObject ret;
				if (IsDirectBinding) {
					ret = (NSObject) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selDelegate));
				} else {
					ret = (NSObject) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selDelegate));
				}
				MarkDirty ();
				__mt_WeakDelegate_var = ret;
				return ret;
			}
			
			[Export ("setDelegate:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetDelegate_, value == null ? IntPtr.Zero : value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetDelegate_, value == null ? IntPtr.Zero : value.Handle);
				}
				MarkDirty ();
				__mt_WeakDelegate_var = value;
			}
		}
		
		[CompilerGenerated]
		public virtual bool AutoDismissOnResignActive {
			[Export ("autoDismissOnResignActive", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selAutoDismissOnResignActive);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selAutoDismissOnResignActive);
				}
			}
			
			[Export ("setAutoDismissOnResignActive:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetAutoDismissOnResignActive_, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetAutoDismissOnResignActive_, value);
				}
			}
		}
		
		protected override void Dispose (bool disposing)
		{
			__mt_WebView_var = null;
			__mt_WeakDelegate_var = null;
			base.Dispose (disposing);
		}
	} /* class MCBrowserViewController */
}
