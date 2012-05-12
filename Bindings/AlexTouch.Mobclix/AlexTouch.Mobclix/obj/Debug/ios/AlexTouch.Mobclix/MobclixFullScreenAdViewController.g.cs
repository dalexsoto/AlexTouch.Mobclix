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
	[Register("MobclixFullScreenAdViewController", true)]
	public unsafe partial class MobclixFullScreenAdViewController : MonoTouch.UIKit.UIViewController {
		static IntPtr selHasAd = Selector.GetHandle ("hasAd");
		static IntPtr selDelegate = Selector.GetHandle ("delegate");
		static IntPtr selSetDelegate_ = Selector.GetHandle ("setDelegate:");
		static IntPtr selRequestAd = Selector.GetHandle ("requestAd");
		static IntPtr selDisplayRequestedAdFromViewController_ = Selector.GetHandle ("displayRequestedAdFromViewController:");
		static IntPtr selRequestAndDisplayAdFromViewController_ = Selector.GetHandle ("requestAndDisplayAdFromViewController:");
		
		static IntPtr class_ptr = Class.GetHandle ("MobclixFullScreenAdViewController");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[Export ("init")]
		public  MobclixFullScreenAdViewController () : base (NSObjectFlag.Empty)
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
		public MobclixFullScreenAdViewController (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.InitWithCoder, coder.Handle);
			} else {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.InitWithCoder, coder.Handle);
			}
		}

		[CompilerGenerated]
		public MobclixFullScreenAdViewController (NSObjectFlag t) : base (t) {}

		[CompilerGenerated]
		public MobclixFullScreenAdViewController (IntPtr handle) : base (handle) {}

		[Export ("requestAd")]
		[CompilerGenerated]
		public virtual void RequestAd ()
		{
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selRequestAd);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper (this.SuperHandle, selRequestAd);
			}
		}
		
		[Export ("displayRequestedAdFromViewController:")]
		[CompilerGenerated]
		public virtual bool DisplayRequestedAdFromViewController (MonoTouch.UIKit.UIViewController viewController)
		{
			if (viewController == null)
				throw new ArgumentNullException ("viewController");
			if (IsDirectBinding) {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend_IntPtr (this.Handle, selDisplayRequestedAdFromViewController_, viewController.Handle);
			} else {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper_IntPtr (this.SuperHandle, selDisplayRequestedAdFromViewController_, viewController.Handle);
			}
		}
		
		[Export ("requestAndDisplayAdFromViewController:")]
		[CompilerGenerated]
		public virtual void RequestAndDisplayAdFromViewController (MonoTouch.UIKit.UIViewController viewController)
		{
			if (viewController == null)
				throw new ArgumentNullException ("viewController");
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selRequestAndDisplayAdFromViewController_, viewController.Handle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selRequestAndDisplayAdFromViewController_, viewController.Handle);
			}
		}
		
		[CompilerGenerated]
		public virtual bool HasAd {
			[Export ("hasAd")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selHasAd);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selHasAd);
				}
			}
			
		}
		
		[CompilerGenerated]
		public MobclixFullScreenAdDelegate Delegate {
			get { return WeakDelegate as MobclixFullScreenAdDelegate; }
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
		
		protected override void Dispose (bool disposing)
		{
			__mt_WeakDelegate_var = null;
			base.Dispose (disposing);
		}
	} /* class MobclixFullScreenAdViewController */
}
