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
	[Register("MobclixFeedback", true)]
	public unsafe partial class MobclixFeedback : NSObject {
		static IntPtr selDelegate = Selector.GetHandle ("delegate");
		static IntPtr selSetDelegate_ = Selector.GetHandle ("setDelegate:");
		static IntPtr selIsSendingComment = Selector.GetHandle ("isSendingComment");
		static IntPtr selIsSendingRatings = Selector.GetHandle ("isSendingRatings");
		static IntPtr selSendComment_ = Selector.GetHandle ("sendComment:");
		static IntPtr selSendRatings_ = Selector.GetHandle ("sendRatings:");
		static IntPtr selSendComment = Selector.GetHandle ("sendComment");
		static IntPtr selSendRatings = Selector.GetHandle ("sendRatings");
		
		static IntPtr class_ptr = Class.GetHandle ("MobclixFeedback");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[Export ("init")]
		public  MobclixFeedback () : base (NSObjectFlag.Empty)
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
		public MobclixFeedback (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.InitWithCoder, coder.Handle);
			} else {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.InitWithCoder, coder.Handle);
			}
		}

		[CompilerGenerated]
		public MobclixFeedback (NSObjectFlag t) : base (t) {}

		[CompilerGenerated]
		public MobclixFeedback (IntPtr handle) : base (handle) {}

		[Export ("sendComment:")]
		[CompilerGenerated]
		public virtual void SendComment (string comment)
		{
			if (comment == null)
				throw new ArgumentNullException ("comment");
			var nscomment = NSString.CreateNative (comment);
			
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSendComment_, nscomment);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSendComment_, nscomment);
			}
			NSString.ReleaseNative (nscomment);
		}
		
		[Export ("sendRatings:")]
		[CompilerGenerated]
		public virtual void SendRatings (MCFeedbackRatings ratings)
		{
			if (IsDirectBinding) {
				ApiDefinition.Messaging.void_objc_msgSend_MCFeedbackRatings (this.Handle, selSendRatings_, ratings);
			} else {
				ApiDefinition.Messaging.void_objc_msgSendSuper_MCFeedbackRatings (this.SuperHandle, selSendRatings_, ratings);
			}
		}
		
		[Export ("sendComment")]
		[Obsolete ("deprecated as of Mobclix SDK 4.2 and will be removed", false)]
		[CompilerGenerated]
		public static void SendCommentMC (string comment)
		{
			if (comment == null)
				throw new ArgumentNullException ("comment");
			var nscomment = NSString.CreateNative (comment);
			
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (class_ptr, selSendComment, nscomment);
			NSString.ReleaseNative (nscomment);
		}
		
		[Export ("sendRatings")]
		[Obsolete ("deprecated as of Mobclix SDK 4.2 and will be removed", false)]
		[CompilerGenerated]
		public static void SendRatingsMC (MCFeedbackRatings ratings)
		{
			ApiDefinition.Messaging.void_objc_msgSend_MCFeedbackRatings (class_ptr, selSendRatings, ratings);
		}
		
		[CompilerGenerated]
		public MobclixFeedbackDelegate Delegate {
			get { return WeakDelegate as MobclixFeedbackDelegate; }
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
		public virtual bool SendingComment {
			[Export ("isSendingComment", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsSendingComment);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selIsSendingComment);
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual bool SendingRatings {
			[Export ("isSendingRatings", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsSendingRatings);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selIsSendingRatings);
				}
			}
			
		}
		
		protected override void Dispose (bool disposing)
		{
			__mt_WeakDelegate_var = null;
			base.Dispose (disposing);
		}
	} /* class MobclixFeedback */
}
