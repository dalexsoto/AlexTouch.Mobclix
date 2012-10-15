using System;
using System.Drawing;

using MonoTouch.ObjCRuntime;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using MonoTouch.CoreLocation;

namespace AlexTouch.Mobclix
{
	[BaseType (typeof (UIViewController),
	Delegates=new string [] {"WeakDelegate"},
	Events=new Type [] { typeof (MCBrowserViewControllerDelegate) })]
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

		[Field ("MCBrowserWillShowNotification", "__Internal")]
		NSString MCBrowserWillShowNotification { get; }
		
		[Field ("MCBrowserDidHideNotification", "__Internal")]
		NSString MCBrowserDidHideNotification { get; }
	}
	
	[BaseType (typeof (NSObject))]
	[Model]
	interface MCBrowserViewControllerDelegate 
	{
		[Export ("browserViewControllerFinishedPreloading:"), EventArgs ("MCBrowserViewControllerDelegateFinishedPreloading")]
		void FinishedPreloading (MCBrowserViewController browserViewController);
		
		[Export ("browserViewController:failedToPreloadWithError:"), EventArgs ("MCBrowserViewControllerDelegateFailedToPreload")]
		void FailedToPreload (MCBrowserViewController browserViewController, NSError error);
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
		bool IsApplicationCracked { get; }

		[Static, Export ("version")]
		string Version { get; }
	}
	
	[BaseType (typeof (UIView),
	Delegates=new string [] {"WeakDelegate"},
	Events=new Type [] { typeof (MobclixAdViewDelegate) })]
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

		[Field ("MCAdsErrorDomain", "__Internal")]
		NSString MCAdsErrorDomain { get; }
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
		[Export ("adViewDidFinishLoad:"), EventArgs ("MobclixAdViewDelegateParams")]
		void DidFinishLoad (MobclixAdView adView);
		
		[Export ("adView:didFailLoadWithError:"), EventArgs ("MobclixAdViewDelegateDidFailLoad")]
		void DidFailLoad (MobclixAdView adView, NSError error);
		
		[Export ("adViewCanAutoplay:"), DelegateName("MobclixAdViewDelegateAdDel"), DefaultValue(true)]
		bool CanAutoplay (MobclixAdView adView);
		
		[Export ("richMediaRequiresUserInteraction:"), DelegateName("MobclixAdViewDelegateAdDel"), DefaultValue(false)]
		bool RichMediaRequiresUserInteraction (MobclixAdView adView);
		
		[Export ("adView:shouldHandleSuballocationRequest:"), DelegateName("MobclixAdViewDelegateAdViewSuballocationType"), DefaultValue(true)]
		bool ShouldHandleSuballocationRequest (MobclixAdView adView, MCAdsSuballocationType suballocationType);
		
		[Export ("adView:didReceiveSuballocationRequest:"), EventArgs ("MobclixAdViewDelegateAdSuballocationType")]
		void DidReceiveSuballocationRequest (MobclixAdView adView, MCAdsSuballocationType suballocationType);
		
		[Export ("adView:publisherKeyForSuballocationRequest:"), DelegateName("MobclixAdViewDelegatePublisherKeyForSuballocationRequest"), DefaultValue(null)]
		string PublisherKeyForSuballocationRequest (MobclixAdView adView, MCAdsSuballocationType suballocationType);
		
		[Export ("adViewWillTouchThrough:"), EventArgs ("MobclixAdViewDelegateParams")]
		void WillTouchThrough (MobclixAdView adView);
		
		[Export ("adViewDidFinishTouchThrough:"), EventArgs ("MobclixAdViewDelegateParams")]
		void DidFinishTouchThrough (MobclixAdView adView);
		
		[Export ("adView:didTouchCustomAdWithString:"), EventArgs ("MobclixAdViewDelegateDidTouchCustomAd")]
		void DidTouchCustomAd (MobclixAdView adView , string text);
		
		[Export ("mcKeywords"), DelegateName("MobclixAdViewDelegateKeyQuery"), DefaultValue(null)]
		string McKeywords (bool fakeArg);
		
		[Export ("query"), DelegateName("MobclixAdViewDelegateKeyQuery"), DefaultValue(null)]
		string Query (bool fakeArg);
	}
	
	[BaseType (typeof (NSObject))]
    interface MobclixDemographics
	{	
		[Static, Export ("updateDemographics:birthday:")]
	    void UpdateDemographicsBirthday (MCDemographics demographics, NSDate birthday);
		
		[Static, Export ("demographics")]
		MCDemographics Demographics { get; }
		
		[Static, Export ("birthday")]
		NSDate Birthday { get; }
	}
	
	[BaseType (typeof (NSObject),
	Delegates=new string [] {"WeakDelegate"},
	Events=new Type [] { typeof (MobclixFeedbackDelegate) })]
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
		[Export ("mobclixFeedbackSentComment:"), EventArgs ("MobclixFeedbackDelegateArgs")]
		void SentComment (MobclixFeedback feedback);
		
		[Export ("MobclixFeedbackFailedToSendComment:withError:"), EventArgs ("MobclixFeedbackDelegateErrorArgs")]
		void FailedToSendComment (MobclixFeedback feedback, NSError error);
		
		[Export ("mobclixFeedbackSentRatings:"), EventArgs ("MobclixFeedbackDelegateArgs")]
		void SentRatings (MobclixFeedback feedback);
		
		[Export ("mobclixFeedbackFailedToSendRatings:withError:"), EventArgs ("MobclixFeedbackDelegateErrorArgs")]
		void FailedToSendRatings (MobclixFeedback feedback, NSError error);
	}
	
	[BaseType (typeof (UIViewController),
	Delegates=new string [] {"WeakDelegate"},
	Events=new Type [] { typeof (MobclixFullScreenAdDelegate) })]
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
		[Export ("fullScreenAdViewControllerDidFinishLoad:"), EventArgs ("MobclixFullScreenAdDelegateArgs")]
		void DidFinishLoad (MobclixFullScreenAdViewController fullScreenAdViewController);
		
		[Export ("fullScreenAdViewController:didFailToLoadWithError:"), EventArgs ("MobclixFullScreenAdDelegateError")]
		void DidFailToLoad (MobclixFullScreenAdViewController fullScreenAdViewController, NSError error);
		
		[Export ("fullScreenAdViewControllerWillPresentAd:"), EventArgs ("MobclixFullScreenAdDelegateArgs")]
		void WillPresentAd (MobclixFullScreenAdViewController fullScreenAdViewController);
		
		[Export ("fullScreenAdViewControllerDidDismissAd:"), EventArgs ("MobclixFullScreenAdDelegateArgs")]
		void DidDismissAd (MobclixFullScreenAdViewController fullScreenAdViewController);
	}
	
}

