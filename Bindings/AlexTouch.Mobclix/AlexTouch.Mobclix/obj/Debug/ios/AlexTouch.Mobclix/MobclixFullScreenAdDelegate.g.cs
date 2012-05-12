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
	[Register("MobclixFullScreenAdDelegate", true)]
	[Model]
	public unsafe partial class MobclixFullScreenAdDelegate : NSObject {
		
		static IntPtr class_ptr = Class.GetHandle ("NSObject");
		
		[CompilerGenerated]
		[Export ("init")]
		public  MobclixFullScreenAdDelegate () : base (NSObjectFlag.Empty)
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
		public MobclixFullScreenAdDelegate (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.InitWithCoder, coder.Handle);
			} else {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.InitWithCoder, coder.Handle);
			}
		}

		[CompilerGenerated]
		public MobclixFullScreenAdDelegate (NSObjectFlag t) : base (t) {}

		[CompilerGenerated]
		public MobclixFullScreenAdDelegate (IntPtr handle) : base (handle) {}

		[Export ("fullScreenAdViewControllerDidFinishLoad:")]
		[CompilerGenerated]
		public virtual void FullScreenAdViewControllerDidFinishLoad (MobclixFullScreenAdViewController fullScreenAdViewController)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("fullScreenAdViewController:didFailToLoadWithError:")]
		[CompilerGenerated]
		public virtual void FullScreenAdViewController (MobclixFullScreenAdViewController fullScreenAdViewController, NSError error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("fullScreenAdViewControllerWillPresentAd:")]
		[CompilerGenerated]
		public virtual void FullScreenAdViewControllerWillPresentAd (MobclixFullScreenAdViewController fullScreenAdViewController)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("fullScreenAdViewControllerDidDismissAd:")]
		[CompilerGenerated]
		public virtual void FullScreenAdViewControllerDidDismissAd (MobclixFullScreenAdViewController fullScreenAdViewController)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
	} /* class MobclixFullScreenAdDelegate */
}
