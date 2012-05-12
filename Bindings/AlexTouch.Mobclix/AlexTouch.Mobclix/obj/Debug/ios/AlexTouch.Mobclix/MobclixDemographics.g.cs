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
	[Register("MobclixDemographics", true)]
	public unsafe partial class MobclixDemographics : NSObject {
		static IntPtr selUpdateDemographicsBirthday_ = Selector.GetHandle ("updateDemographics:birthday:");
		static IntPtr selDemographics = Selector.GetHandle ("demographics");
		static IntPtr selBirthday = Selector.GetHandle ("birthday");
		
		static IntPtr class_ptr = Class.GetHandle ("MobclixDemographics");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[Export ("init")]
		public  MobclixDemographics () : base (NSObjectFlag.Empty)
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
		public MobclixDemographics (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.InitWithCoder, coder.Handle);
			} else {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.InitWithCoder, coder.Handle);
			}
		}

		[CompilerGenerated]
		public MobclixDemographics (NSObjectFlag t) : base (t) {}

		[CompilerGenerated]
		public MobclixDemographics (IntPtr handle) : base (handle) {}

		[Export ("updateDemographics:birthday:")]
		[CompilerGenerated]
		public static void UpdateDemographicsBirthday (MCDemographics demographics, NSDate birthday)
		{
			if (birthday == null)
				throw new ArgumentNullException ("birthday");
			ApiDefinition.Messaging.void_objc_msgSend_MCDemographics_IntPtr (class_ptr, selUpdateDemographicsBirthday_, demographics, birthday.Handle);
		}
		
		[Export ("demographics")]
		[CompilerGenerated]
		public static MCDemographics Demographics ()
		{
			MCDemographics ret;
			ApiDefinition.Messaging.MCDemographics_objc_msgSend_stret (out ret, class_ptr, selDemographics);
			return ret;
		}
		
		[Export ("birthday")]
		[CompilerGenerated]
		public static NSDate Birthday ()
		{
			return (NSDate) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (class_ptr, selBirthday));
		}
		
	} /* class MobclixDemographics */
}
