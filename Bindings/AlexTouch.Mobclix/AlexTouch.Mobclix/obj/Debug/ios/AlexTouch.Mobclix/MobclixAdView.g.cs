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
	[Register("MobclixAdView", true)]
	public unsafe partial class MobclixAdView : MonoTouch.UIKit.UIView {
		static IntPtr selDelegate = Selector.GetHandle ("delegate");
		static IntPtr selSetDelegate_ = Selector.GetHandle ("setDelegate:");
		static IntPtr selRefreshTime = Selector.GetHandle ("refreshTime");
		static IntPtr selSetRefreshTime_ = Selector.GetHandle ("setRefreshTime:");
		static IntPtr selViewController = Selector.GetHandle ("viewController");
		static IntPtr selSetViewController_ = Selector.GetHandle ("setViewController:");
		static IntPtr selGetAd = Selector.GetHandle ("getAd");
		static IntPtr selContinueRequest = Selector.GetHandle ("continueRequest");
		static IntPtr selPauseAdAutoRefresh = Selector.GetHandle ("pauseAdAutoRefresh");
		static IntPtr selResumeAdAutoRefresh = Selector.GetHandle ("resumeAdAutoRefresh");
		static IntPtr selCancelAd = Selector.GetHandle ("cancelAd");
		
		static IntPtr class_ptr = Class.GetHandle ("MobclixAdView");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[Export ("init")]
		public  MobclixAdView () : base (NSObjectFlag.Empty)
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
		public MobclixAdView (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.InitWithCoder, coder.Handle);
			} else {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.InitWithCoder, coder.Handle);
			}
		}

		[CompilerGenerated]
		public MobclixAdView (NSObjectFlag t) : base (t) {}

		[CompilerGenerated]
		public MobclixAdView (IntPtr handle) : base (handle) {}

		[Export ("getAd")]
		[CompilerGenerated]
		public virtual void GetAd ()
		{
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selGetAd);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper (this.SuperHandle, selGetAd);
			}
		}
		
		[Export ("continueRequest")]
		[CompilerGenerated]
		public virtual void ContinueRequest ()
		{
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selContinueRequest);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper (this.SuperHandle, selContinueRequest);
			}
		}
		
		[Export ("pauseAdAutoRefresh")]
		[CompilerGenerated]
		public virtual void PauseAdAutoRefresh ()
		{
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selPauseAdAutoRefresh);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper (this.SuperHandle, selPauseAdAutoRefresh);
			}
		}
		
		[Export ("resumeAdAutoRefresh")]
		[CompilerGenerated]
		public virtual void ResumeAdAutoRefresh ()
		{
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selResumeAdAutoRefresh);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper (this.SuperHandle, selResumeAdAutoRefresh);
			}
		}
		
		[Export ("cancelAd")]
		[CompilerGenerated]
		public virtual void CancelAd ()
		{
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selCancelAd);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper (this.SuperHandle, selCancelAd);
			}
		}
		
		[CompilerGenerated]
		public MobclixAdViewDelegate Delegate {
			get { return WeakDelegate as MobclixAdViewDelegate; }
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
		public virtual System.Double RefreshTime {
			[Export ("refreshTime", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.Double_objc_msgSend (this.Handle, selRefreshTime);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.Double_objc_msgSendSuper (this.SuperHandle, selRefreshTime);
				}
			}
			
			[Export ("setRefreshTime:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_Double (this.Handle, selSetRefreshTime_, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_Double (this.SuperHandle, selSetRefreshTime_, value);
				}
			}
		}
		
		object __mt_ViewController_var;
		[CompilerGenerated]
		public virtual MonoTouch.UIKit.UIViewController ViewController {
			[Export ("viewController", ArgumentSemantic.Assign)]
			get {
				MonoTouch.UIKit.UIViewController ret;
				if (IsDirectBinding) {
					ret = (MonoTouch.UIKit.UIViewController) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selViewController));
				} else {
					ret = (MonoTouch.UIKit.UIViewController) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selViewController));
				}
				MarkDirty ();
				__mt_ViewController_var = ret;
				return ret;
			}
			
			[Export ("setViewController:", ArgumentSemantic.Assign)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetViewController_, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetViewController_, value.Handle);
				}
				MarkDirty ();
				__mt_ViewController_var = value;
			}
		}
		
		protected override void Dispose (bool disposing)
		{
			__mt_WeakDelegate_var = null;
			__mt_ViewController_var = null;
			base.Dispose (disposing);
		}
	} /* class MobclixAdView */
}
