using System;
using System.Drawing;

using MonoTouch.ObjCRuntime;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using MonoTouch.CoreLocation;

namespace AlexTouch.Mobclix
{
	// The first step to creating a binding is to add your native library ("libNativeLibrary.a")
	// to the project by right-clicking (or Control-clicking) the folder containing this source
	// file and clicking "Add files..." and then simply select the native library (or libraries)
	// that you want to bind.
	//
	// When you do that, you'll notice that MonoDevelop generates a code-behind file for each
	// native library which will contain a [LinkWith] attribute. MonoDevelop auto-detects the
	// architectures that the native library supports and fills in that information for you,
	// however, it cannot auto-detect any Frameworks or other system libraries that the
	// native library may depend on, so you'll need to fill in that information yourself.
	//
	// Once you've done that, you're ready to move on to binding the API...
	//
	//
	// Here is where you'd define your API definition for the native Objective-C library.
	//
	// For example, to bind the following Objective-C class:
	//
	//     @interface Widget : NSObject {
	//     }
	//
	// The C# binding would look like this:
	//
	//     [BaseType (typeof (NSObject))]
	//     interface Widget {
	//     }
	//
	// To bind Objective-C properties, such as:
	//
	//     @property (nonatomic, readwrite, assign) CGPoint center;
	//
	// You would add a property definition in the C# interface like so:
	//
	//     [Export ("center")]
	//     PointF Center { get; set; }
	//
	// To bind an Objective-C method, such as:
	//
	//     -(void) doSomething:(NSObject *)object atIndex:(NSInteger)index;
	//
	// You would add a method definition to the C# interface like so:
	//
	//     [Export ("doSomething:atIndex:")]
	//     void DoSomething (NSObject object, int index);
	//
	// Objective-C "constructors" such as:
	//
	//     -(id)initWithElmo:(ElmoMuppet *)elmo;
	//
	// Can be bound as:
	//
	//     [Export ("initWithElmo:")]
	//     IntPtr Constructor (ElmoMuppet elmo);
	//
	// For more information, see http://docs.xamarin.com/ios/advanced_topics/binding_objective-c_types
	//
	
	[BaseType (typeof (UIViewController))]
    interface MCBrowserViewController
	{
		[Export ("initWithURLRequest:")]
	    IntPtr Constructor (NSUrlRequest urlRequest);
		
		[Export ("initWithURLRequest:browserStyle:")]
	    IntPtr Constructor (NSUrlRequest urlRequest, MCBrowserStyle browserStyle);
		
		[Export ("initWithEmbeddedHTML:baseURL:")]
	    IntPtr Constructor (string embeddedHTML, NSUrl baseURL);
		
		[Export ("initWithEmbeddedHTML:baseURL:browserStyle:")]
	    IntPtr Constructor (string embeddedHTML, NSUrl baseURL, MCBrowserStyle browserStyle);
		
		[Export ("stopLoading")]
	    void StopLoading ();
		
		[Export ("preloadRequest")]
	    void PreloadRequest ();

		[Export ("webView")]
		UIWebView WebView { get; }
		
		[Wrap ("WeakDelegate")][NullAllowed]
		MCBrowserViewControllerDelegate Delegate { get; set; }
		
		[Export ("delegate", ArgumentSemantic.Assign)][NullAllowed]
		NSObject WeakDelegate { get; set; }
		
		[Export ("autoDismissOnResignActive", ArgumentSemantic.Assign)]
		bool AutoDismissOnResignActive { get; set; }
	}
	
	[BaseType (typeof (NSObject))]
	[Model]
	interface MCBrowserViewControllerDelegate 
	{
		[Export ("browserViewControllerFinishedPreloading:")]
		void BrowserViewControllerFinishedPreloading (MCBrowserViewController browserViewController);
		
		[Export ("browserViewController:failedToPreloadWithError:")]
		void BrowserViewControllerFailedToPreloadWithError (MCBrowserViewController browserViewController, NSError error);
	}
	
	[Static]
	interface MCNotifications 
	{
    	[Field ("MCBrowserWillShowNotification", "__Internal")]
    	NSString MCBrowserWillShowNotification { get; }
		
		[Field ("MCBrowserDidHideNotification", "__Internal")]
    	NSString MCBrowserDidHideNotification { get; }
		
		[Field ("MCAdsErrorDomain", "__Internal")]
    	NSString MCAdsErrorDomain { get; }
	}
	
	[BaseType (typeof (NSObject))]
    interface Mobclix
	{	
		[Static, Export ("start")]
	    void Start ();
		
		[Static, Export ("startWithApplicationId:")]
	    void StartWithApplicationId (string applicationId);
		
		[Static, Export ("updateLocation:")]
	    void UpdateLocation (CLLocation locaion);
		
		[Static, Export ("isApplicationCracked")]
	    bool IsApplicationCracked ();
	}
	
	[BaseType (typeof (UIView))]
    interface MobclixAdView
	{	
		[Export ("getAd")]
	    void GetAd ();
		
		[Export ("continueRequest")]
	    void ContinueRequest ();
		
		[Export ("pauseAdAutoRefresh")]
	    void PauseAdAutoRefresh ();
		
		[Export ("resumeAdAutoRefresh")]
	    void ResumeAdAutoRefresh ();
		
		[Export ("cancelAd")]
	    void CancelAd ();
		
		[Wrap ("WeakDelegate")][NullAllowed]
		MobclixAdViewDelegate Delegate { get; set; }
		
		[Export ("delegate", ArgumentSemantic.Assign)][NullAllowed]
		NSObject WeakDelegate { get; set; }
		
		[Export ("refreshTime", ArgumentSemantic.Assign)]
		double RefreshTime { get; set; }
		
		[Export ("viewController", ArgumentSemantic.Assign)]
		UIViewController ViewController { get; set; }
	}
	
	[BaseType (typeof (MobclixAdView))]
	interface MobclixAdViewiPhone_320x50
	{	
		
	}
	
	[BaseType (typeof (MobclixAdView))]
    interface MobclixAdViewiPhone_300x250
	{	
		
	}
	
	[BaseType (typeof (MobclixAdView))]
    interface MobclixAdViewiPad_300x250
	{	
		
	}
	
	[BaseType (typeof (MobclixAdView))]
    interface MobclixAdViewiPad_728x90
	{	
		
	}
	
	[BaseType (typeof (MobclixAdView))]
    interface MobclixAdViewiPad_120x600
	{	
		
	}
	
	[BaseType (typeof (MobclixAdView))]
    interface MobclixAdViewiPad_468x60
	{	
		
	}
	
	[BaseType (typeof (NSObject))]
	[Model]
	interface MobclixAdViewDelegate 
	{
		[Export ("adViewDidFinishLoad:")]
		void AdViewDidFinishLoad (MobclixAdView adView);
		
		[Export ("adView:didFailLoadWithError:")]
		void AdViewDidFailLoadWithError (MobclixAdView adView, NSError error);
		
		[Export ("adViewCanAutoplay:")]
		bool AdViewCanAutoplay (MobclixAdView adView);
		
		[Export ("richMediaRequiresUserInteraction:")]
		bool RichMediaRequiresUserInteraction (MobclixAdView adView);
		
		[Export ("adView:shouldHandleSuballocationRequest:")]
		bool AdViewShouldHandleSuballocationRequest (MobclixAdView adView, MCAdsSuballocationType suballocationType);
		
		[Export ("adView:didReceiveSuballocationRequest:")]
		void AdViewDidReceiveSuballocationRequest (MobclixAdView adView, MCAdsSuballocationType suballocationType);
		
		[Export ("adView:publisherKeyForSuballocationRequest:")]
		string AdViewPublisherKeyForSuballocationRequest (MobclixAdView adView, MCAdsSuballocationType suballocationType);
		
		[Export ("adViewWillTouchThrough:")]
		void AdViewWillTouchThrough (MobclixAdView adView);
		
		[Export ("adViewDidFinishTouchThrough:")]
		void AdViewDidFinishTouchThrough (MobclixAdView adView);
		
		[Export ("adView:didTouchCustomAdWithString:")]
		void AdViewDidTouchCustomAdWithString (MobclixAdView adView , string text);
		
		[Export ("mcKeywords")]
		string McKeywords ();
		
		[Export ("query")]
		string Query ();
	}
	
	//---------------- Beta Code
	
	[BaseType (typeof (NSObject))]
    interface MobclixDemographics
	{	
		[Static, Export ("updateDemographics:birthday:")]
	    void UpdateDemographicsBirthday (MCDemographics demographics, NSDate birthday);
		
		[Static, Export ("demographics")]
	    MCDemographics Demographics ();
		
		[Static, Export ("birthday")]
	    NSDate Birthday ();
	}
	
	[BaseType (typeof (NSObject))]
    interface MobclixFeedback
	{	
		[Export ("sendComment:")]
	    void SendComment (string comment);
		
		[Export ("sendRatings:")]
	    void SendRatings (MCFeedbackRatings ratings);
		
		[Wrap ("WeakDelegate")][NullAllowed]
		MobclixFeedbackDelegate Delegate { get; set; }
		
		[Export ("delegate", ArgumentSemantic.Assign)][NullAllowed]
		NSObject WeakDelegate { get; set; }
		
		[Export ("sendingComment", ArgumentSemantic.Assign)]
		bool SendingComment { [Bind ("isSendingComment")] get; }
		
		[Export ("sendingRatings", ArgumentSemantic.Assign)]
		bool SendingRatings { [Bind ("isSendingRatings")] get; }
		
		[Static, Export ("sendComment"), Obsolete("deprecated as of Mobclix SDK 4.2 and will be removed")]
	    void SendCommentMC (string comment);
		
		[Static, Export ("sendRatings"), Obsolete("deprecated as of Mobclix SDK 4.2 and will be removed")]
	    void SendRatingsMC (MCFeedbackRatings ratings);
		
	}
	
	[BaseType (typeof (NSObject))]
	[Model]
	interface MobclixFeedbackDelegate 
	{
		[Export ("mobclixFeedbackSentComment:")]
		void MobclixFeedbackSentComment (MobclixFeedback feedback);
		
		[Export ("MobclixFeedbackFailedToSendComment:withError:")]
		void MobclixFeedbackFailedToSendComment (MobclixFeedback feedback, NSError error);
		
		[Export ("mobclixFeedbackSentRatings:")]
		void MobclixFeedbackSentRatings (MobclixFeedback feedback);
		
		[Export ("mobclixFeedbackFailedToSendRatings:withError:")]
		void MobclixFeedbackFailedToSendRatings (MobclixFeedback feedback, NSError error);
	}
	
	//------------- End Beta Code
	
	[BaseType (typeof (UIViewController))]
    interface MobclixFullScreenAdViewController
	{	
		[Export ("requestAd")]
	    void RequestAd ();
		
		[Export ("displayRequestedAdFromViewController:")]
	    bool DisplayRequestedAdFromViewController (UIViewController viewController);
		
		[Export ("requestAndDisplayAdFromViewController:")]
	    void RequestAndDisplayAdFromViewController (UIViewController viewController);
		
		[Export ("hasAd")]
		bool HasAd { get; }
		
		[Wrap ("WeakDelegate")][NullAllowed]
		MobclixFullScreenAdDelegate Delegate { get; set; }
		
		[Export ("delegate", ArgumentSemantic.Assign)][NullAllowed]
		NSObject WeakDelegate { get; set; }
		
	}
	
	[BaseType (typeof (NSObject))]
	[Model]
	interface MobclixFullScreenAdDelegate 
	{
		[Export ("fullScreenAdViewControllerDidFinishLoad:")]
		void FullScreenAdViewControllerDidFinishLoad (MobclixFullScreenAdViewController fullScreenAdViewController);
		
		[Export ("fullScreenAdViewController:didFailToLoadWithError:")]
		void FullScreenAdViewController (MobclixFullScreenAdViewController fullScreenAdViewController, NSError error);
		
		[Export ("fullScreenAdViewControllerWillPresentAd:")]
		void FullScreenAdViewControllerWillPresentAd (MobclixFullScreenAdViewController fullScreenAdViewController);
		
		[Export ("fullScreenAdViewControllerDidDismissAd:")]
		void FullScreenAdViewControllerDidDismissAd (MobclixFullScreenAdViewController fullScreenAdViewController);
	}
	
}

