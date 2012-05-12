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
	public unsafe partial class MCNotifications  {
		
		static IntPtr __Internal_libraryHandle = Dlfcn.dlopen (null, 0);
		static NSString _MCBrowserWillShowNotification;
		public static NSString MCBrowserWillShowNotification {
			get {
				if (_MCBrowserWillShowNotification == null)
					_MCBrowserWillShowNotification = Dlfcn.GetStringConstant (__Internal_libraryHandle, "MCBrowserWillShowNotification");
				return _MCBrowserWillShowNotification;
			}
		}
		static NSString _MCBrowserDidHideNotification;
		public static NSString MCBrowserDidHideNotification {
			get {
				if (_MCBrowserDidHideNotification == null)
					_MCBrowserDidHideNotification = Dlfcn.GetStringConstant (__Internal_libraryHandle, "MCBrowserDidHideNotification");
				return _MCBrowserDidHideNotification;
			}
		}
		static NSString _MCAdsErrorDomain;
		public static NSString MCAdsErrorDomain {
			get {
				if (_MCAdsErrorDomain == null)
					_MCAdsErrorDomain = Dlfcn.GetStringConstant (__Internal_libraryHandle, "MCAdsErrorDomain");
				return _MCAdsErrorDomain;
			}
		}
	} /* class MCNotifications */
}
