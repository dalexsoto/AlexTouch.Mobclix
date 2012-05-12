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
	[Register("MobclixAdViewDelegate", true)]
	[Model]
	public unsafe partial class MobclixAdViewDelegate : NSObject {
		
		static IntPtr class_ptr = Class.GetHandle ("NSObject");
		
		[CompilerGenerated]
		[Export ("init")]
		public  MobclixAdViewDelegate () : base (NSObjectFlag.Empty)
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
		public MobclixAdViewDelegate (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.InitWithCoder, coder.Handle);
			} else {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.InitWithCoder, coder.Handle);
			}
		}

		[CompilerGenerated]
		public MobclixAdViewDelegate (NSObjectFlag t) : base (t) {}

		[CompilerGenerated]
		public MobclixAdViewDelegate (IntPtr handle) : base (handle) {}

		[Export ("adViewDidFinishLoad:")]
		[CompilerGenerated]
		public virtual void AdViewDidFinishLoad (MobclixAdView adView)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("adView:didFailLoadWithError:")]
		[CompilerGenerated]
		public virtual void AdViewDidFailLoadWithError (MobclixAdView adView, NSError error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("adViewCanAutoplay:")]
		[CompilerGenerated]
		public virtual bool AdViewCanAutoplay (MobclixAdView adView)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("richMediaRequiresUserInteraction:")]
		[CompilerGenerated]
		public virtual bool RichMediaRequiresUserInteraction (MobclixAdView adView)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("adView:shouldHandleSuballocationRequest:")]
		[CompilerGenerated]
		public virtual bool AdViewShouldHandleSuballocationRequest (MobclixAdView adView, MCAdsSuballocationType suballocationType)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("adView:didReceiveSuballocationRequest:")]
		[CompilerGenerated]
		public virtual void AdViewDidReceiveSuballocationRequest (MobclixAdView adView, MCAdsSuballocationType suballocationType)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("adView:publisherKeyForSuballocationRequest:")]
		[CompilerGenerated]
		public virtual string AdViewPublisherKeyForSuballocationRequest (MobclixAdView adView, MCAdsSuballocationType suballocationType)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("adViewWillTouchThrough:")]
		[CompilerGenerated]
		public virtual void AdViewWillTouchThrough (MobclixAdView adView)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("adViewDidFinishTouchThrough:")]
		[CompilerGenerated]
		public virtual void AdViewDidFinishTouchThrough (MobclixAdView adView)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("adView:didTouchCustomAdWithString:")]
		[CompilerGenerated]
		public virtual void AdViewDidTouchCustomAdWithString (MobclixAdView adView, string text)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("mcKeywords")]
		[CompilerGenerated]
		public virtual string McKeywords ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("query")]
		[CompilerGenerated]
		public virtual string Query ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
	} /* class MobclixAdViewDelegate */
}
