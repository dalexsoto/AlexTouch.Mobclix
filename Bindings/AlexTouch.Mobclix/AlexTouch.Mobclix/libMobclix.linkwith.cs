using System;
using MonoTouch.ObjCRuntime;

[assembly: LinkWith ("libMobclix.a", LinkTarget.Simulator | LinkTarget.ArmV6 | LinkTarget.ArmV7, ForceLoad = true, Frameworks = "CoreGraphics AddressBook AVFoundation MediaPlayer SystemConfiguration AddressBookUI MessageUI AudioToolbox QuartzCore", WeakFrameworks = "EventKit CoreMotion")]
