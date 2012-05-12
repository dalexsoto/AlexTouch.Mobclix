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
	[Register("Mobclix", true)]
	public unsafe partial class Mobclix : NSObject {
		static IntPtr selStart = Selector.GetHandle ("start");
		static IntPtr selStartWithApplicationId_ = Selector.GetHandle ("startWithApplicationId:");
		static IntPtr selUpdateLocation_ = Selector.GetHandle ("updateLocation:");
		static IntPtr selIsApplicationCracked = Selector.GetHandle ("isApplicationCracked");
		
		static IntPtr class_ptr = Class.GetHandle ("Mobclix");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[Export ("init")]
		public  Mobclix () : base (NSObjectFlag.Empty)
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
		public Mobclix (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.InitWithCoder, coder.Handle);
			} else {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.InitWithCoder, coder.Handle);
			}
		}

		[CompilerGenerated]
		public Mobclix (NSObjectFlag t) : base (t) {}

		[CompilerGenerated]
		public Mobclix (IntPtr handle) : base (handle) {}

		[Export ("start")]
		[CompilerGenerated]
		public static void Start ()
		{
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend (class_ptr, selStart);
		}
		
		[Export ("startWithApplicationId:")]
		[CompilerGenerated]
		public static void StartWithApplicationId (string applicationId)
		{
			if (applicationId == null)
				throw new ArgumentNullException ("applicationId");
			var nsapplicationId = NSString.CreateNative (applicationId);
			
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (class_ptr, selStartWithApplicationId_, nsapplicationId);
			NSString.ReleaseNative (nsapplicationId);
		}
		
		[Export ("updateLocation:")]
		[CompilerGenerated]
		public static void UpdateLocation (MonoTouch.CoreLocation.CLLocation locaion)
		{
			if (locaion == null)
				throw new ArgumentNullException ("locaion");
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (class_ptr, selUpdateLocation_, locaion.Handle);
		}
		
		[Export ("isApplicationCracked")]
		[CompilerGenerated]
		public static bool IsApplicationCracked ()
		{
			return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (class_ptr, selIsApplicationCracked);
		}
		
	} /* class Mobclix */
}
