using System;
using System.Runtime.InteropServices;

//namespace AlexTouch.Mobclix
//{
	public enum MCBrowserStyle
	{
		Toolbar, // Toolbar with back/forward/reload buttons, no navigation bar
		Navigation, // No toolbar, Navigation bar with "Done" button + self.title (Default: Advertisement)
		Widget, // No toolbar, No Navigation bar, Single "X" in top left corner
		Full // Contains toolbar and navigation bar. 
	}
	
	public enum MCLogLevel
	{
		LOG_LEVEL_VERBOSE =	1 << 0,
		LOG_LEVEL_DEBUG =	1 << 1,
		LOG_LEVEL_INFO	=	1 << 2,
		LOG_LEVEL_WARN	=	1 << 3,
		LOG_LEVEL_ERROR	=	1 << 4
	}
	
	public enum MCAdsError
	{
		UnknownError = 0,
		ServerError = -500,
		Unavailable = -503,
		NotStarted = -8888888,
		Disabled = -9999999
	}
	
	public enum MCAdsSuballocationType
	{
		Open		= -1006,
		IAd			= -275,
		AdMob		= -750,
		Google		= -10100,
		Millennial	= -1375
	}
	
	public enum MCDemographicsEducation
	{
		Unknown = 0,
		HighSchool,
		SomeCollege,
		InCollege,
		BachelorsDegree,
		MastersDegree,
		DoctoralDegree	
	}
	
	public enum MCDemographicsEthnicity
	{
		Unknown = 0,
		Mixed,
		Asian,
		Black,
		Hispanic,
		NativeAmerican,
		White	
	}
	
	public enum MCDemographicsReligion
	{
		Unknown = 0,
		Buddhism,
		Christianity,
		Hinduism,
		Islam,
		Judaism,
		Unaffiliated,
		Other
	}
	
	public enum MCDemographicsGender
	{
		Unknown = 0,
		Male,
		Female,
		Both	
	}
	
	public enum MCDemographicsMaritalStatus
	{
		Unknown = 0,
		SingleAvailable,
		SingleUnavailable,
		MaritalMarried	
	}
	
	public struct MCDemographics
	{
		public MCDemographicsEducation education;
		public MCDemographicsEthnicity ethnicity;
		public MCDemographicsReligion religion;
		public MCDemographicsGender gender; // MCDemographicsGenderBoth is not valid for this field.
		public MCDemographicsGender datingGender; // MCDemographicsGenderBoth is valid for this field.
		public MCDemographicsMaritalStatus maritalStatus;
		public uint income;
		public uint areaCode;
		public int dmaCode;
		public int metroCode;
		public string city;
		public string country;
		public string postalCode;
		public string regionCode;
		public double latitude;
		public double longitude;
	}
	
	public enum MCFeedbackRating
	{
		Unknown = 0,
		Poor,
		Fair,
		Good,
		VeryGood,
		Excellent	
	}
	
	public struct MCFeedbackRatings
	{
		public MCFeedbackRating categoryA;
		public MCFeedbackRating categoryB;
		public MCFeedbackRating categoryC;
		public MCFeedbackRating categoryD;
		public MCFeedbackRating categoryE;	
	}
	
	
//}
