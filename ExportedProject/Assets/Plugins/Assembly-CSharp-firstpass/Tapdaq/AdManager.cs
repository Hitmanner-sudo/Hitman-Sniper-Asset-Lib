using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Tapdaq
{
	[Token(Token = "0x2000066")]
	public class AdManager
	{
		[Token(Token = "0x40001DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static AdManager reference;

		[Token(Token = "0x40001DF")]
		private const string unsupportedPlatformMessage = "We support iOS and Android platforms only.";

		[Token(Token = "0x40001E0")]
		private const string TAPDAQ_PLACEMENT_DEFAULT = "default";

		[Token(Token = "0x40001E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private TDSettings settings;

		[Token(Token = "0x1700002B")]
		public static AdManager instance
		{
			[Token(Token = "0x600023F")]
			[Address(RVA = "0x10D29A8", Offset = "0x10D29A8", VA = "0x10D29A8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000240")]
		[Address(RVA = "0x10D2A24", Offset = "0x10D2A24", VA = "0x10D2A24")]
		internal AdManager()
		{
		}

		[Token(Token = "0x6000241")]
		[Address(RVA = "0x10D2A2C", Offset = "0x10D2A2C", VA = "0x10D2A2C")]
		public static void Init()
		{
		}

		[Token(Token = "0x6000242")]
		[Address(RVA = "0x10D30BC", Offset = "0x10D30BC", VA = "0x10D30BC")]
		[Attribute(Name = "ObsoleteAttribute", RVA = "0x6FA6A0", Offset = "0x6FA6A0")]
		public static void Init([Optional][DefaultParameterValue(2)] TDStatus isUserSubjectToGDPR, [Optional][DefaultParameterValue(2)] TDStatus isConsentGiven, [Optional][DefaultParameterValue(2)] TDStatus isAgeRestrictedUser, [Optional] string userId, bool shouldForwardUserId = false)
		{
		}

		[Token(Token = "0x6000243")]
		[Address(RVA = "0x10D3118", Offset = "0x10D3118", VA = "0x10D3118")]
		[Attribute(Name = "ObsoleteAttribute", RVA = "0x6FA6D8", Offset = "0x6FA6D8")]
		public static void InitWithConsent(TDStatus isUserSubjectToGDPR, TDStatus isConsentGiven, TDStatus isAgeRestrictedUser)
		{
		}

		[Token(Token = "0x6000244")]
		[Address(RVA = "0x10D3164", Offset = "0x10D3164", VA = "0x10D3164")]
		[Attribute(Name = "ObsoleteAttribute", RVA = "0x6FA710", Offset = "0x6FA710")]
		public static void InitWithConsent(bool isConsentGiven)
		{
		}

		[Token(Token = "0x6000245")]
		[Address(RVA = "0x10D31A0", Offset = "0x10D31A0", VA = "0x10D31A0")]
		[Attribute(Name = "ObsoleteAttribute", RVA = "0x6FA748", Offset = "0x6FA748")]
		public static void InitWithConsent(TDStatus isConsentGiven)
		{
		}

		[Token(Token = "0x6000246")]
		[Address(RVA = "0x10D31DC", Offset = "0x10D31DC", VA = "0x10D31DC")]
		[Attribute(Name = "ObsoleteAttribute", RVA = "0x6FA780", Offset = "0x6FA780")]
		public static void InitWithConsent(bool isConsentGiven, bool isAgeRestrictedUser)
		{
		}

		[Token(Token = "0x6000247")]
		[Address(RVA = "0x10D2F64", Offset = "0x10D2F64", VA = "0x10D2F64")]
		private void _Init(TDStatus isUserSubjectToGDPR, TDStatus isConsentGiven, TDStatus isAgeRestrictedUser, string userId, bool shouldForwardUserId)
		{
		}

		[Token(Token = "0x6000248")]
		[Address(RVA = "0x10D32C8", Offset = "0x10D32C8", VA = "0x10D32C8")]
		private void Initialize(string appID, string clientKey, TDStatus isUserSubjectToGDPR, TDStatus isConsentGiven, TDStatus isAgeRestrictedUser, string userId, bool shouldForwardUserId)
		{
		}

		[Token(Token = "0x6000249")]
		private static T GetAndroidStatic<T>(string methodName, params object[] paramList)
		{
			return (T)null;
		}

		[Token(Token = "0x600024A")]
		[Address(RVA = "0x10D37A4", Offset = "0x10D37A4", VA = "0x10D37A4")]
		private static void CallAndroidStaticMethod(string methodName, params object[] paramList)
		{
		}

		[Token(Token = "0x600024B")]
		[Address(RVA = "0x10D388C", Offset = "0x10D388C", VA = "0x10D388C")]
		private static void CallAndroidStaticMethodFromClass(string className, string methodName, bool logException, params object[] paramList)
		{
		}

		[Token(Token = "0x600024C")]
		[Address(RVA = "0x10D3DC4", Offset = "0x10D3DC4", VA = "0x10D3DC4")]
		private static void LogObsoleteWithTagMethod(string methodName)
		{
		}

		[Token(Token = "0x600024D")]
		[Address(RVA = "0x10D3734", Offset = "0x10D3734", VA = "0x10D3734")]
		private static void LogUnsupportedPlatform()
		{
		}

		[Token(Token = "0x600024E")]
		[Address(RVA = "0x10D3FE0", Offset = "0x10D3FE0", VA = "0x10D3FE0")]
		public void _UnexpectedErrorHandler(string msg)
		{
		}

		[Token(Token = "0x600024F")]
		[Address(RVA = "0x10D3228", Offset = "0x10D3228", VA = "0x10D3228")]
		public static void LogMessage(TDLogSeverity severity, string message)
		{
		}

		[Token(Token = "0x6000250")]
		[Address(RVA = "0x10D40C8", Offset = "0x10D40C8", VA = "0x10D40C8")]
		public void FetchFailed(string msg)
		{
		}

		[Token(Token = "0x6000251")]
		[Address(RVA = "0x10D411C", Offset = "0x10D411C", VA = "0x10D411C")]
		public static void OnApplicationPause(bool isPaused)
		{
		}

		[Token(Token = "0x6000252")]
		[Address(RVA = "0x10D4220", Offset = "0x10D4220", VA = "0x10D4220")]
		public static bool IsInitialised()
		{
			return default(bool);
		}

		[Token(Token = "0x6000253")]
		[Address(RVA = "0x10D4314", Offset = "0x10D4314", VA = "0x10D4314")]
		public static void LaunchMediationDebugger()
		{
		}

		[Token(Token = "0x6000254")]
		[Address(RVA = "0x10D43F0", Offset = "0x10D43F0", VA = "0x10D43F0")]
		[Attribute(Name = "ObsoleteAttribute", RVA = "0x6FA7B8", Offset = "0x6FA7B8")]
		public static void SetUserSubjectToGDPR(TDStatus isUserSubjectToGDPR)
		{
		}

		[Token(Token = "0x6000255")]
		[Address(RVA = "0x10D43F4", Offset = "0x10D43F4", VA = "0x10D43F4")]
		public static void SetUserSubjectToGdprStatus(TDStatus status)
		{
		}

		[Token(Token = "0x6000256")]
		[Address(RVA = "0x10D44DC", Offset = "0x10D44DC", VA = "0x10D44DC")]
		[Attribute(Name = "ObsoleteAttribute", RVA = "0x6FA7F0", Offset = "0x6FA7F0")]
		public static TDStatus IsUserSubjectToGDPR()
		{
			return default(TDStatus);
		}

		[Token(Token = "0x6000257")]
		[Address(RVA = "0x10D2AA0", Offset = "0x10D2AA0", VA = "0x10D2AA0")]
		public static TDStatus GetUserSubjectToGdprStatus()
		{
			return default(TDStatus);
		}

		[Token(Token = "0x6000258")]
		[Address(RVA = "0x10D44E0", Offset = "0x10D44E0", VA = "0x10D44E0")]
		[Attribute(Name = "ObsoleteAttribute", RVA = "0x6FA828", Offset = "0x6FA828")]
		public static void SetConsentGiven(bool isConsentGiven)
		{
		}

		[Token(Token = "0x6000259")]
		[Address(RVA = "0x10D44E8", Offset = "0x10D44E8", VA = "0x10D44E8")]
		public static void SetConsentStatus(TDStatus status)
		{
		}

		[Token(Token = "0x600025A")]
		[Address(RVA = "0x10D45D0", Offset = "0x10D45D0", VA = "0x10D45D0")]
		[Attribute(Name = "ObsoleteAttribute", RVA = "0x6FA860", Offset = "0x6FA860")]
		public static bool IsConsentGiven()
		{
			return default(bool);
		}

		[Token(Token = "0x600025B")]
		[Address(RVA = "0x10D2B94", Offset = "0x10D2B94", VA = "0x10D2B94")]
		public static TDStatus GetConsentStatus()
		{
			return default(TDStatus);
		}

		[Token(Token = "0x600025C")]
		[Address(RVA = "0x10D45EC", Offset = "0x10D45EC", VA = "0x10D45EC")]
		[Attribute(Name = "ObsoleteAttribute", RVA = "0x6FA898", Offset = "0x6FA898")]
		public static void SetIsAgeRestrictedUser(bool isAgeRestrictedUser)
		{
		}

		[Token(Token = "0x600025D")]
		[Address(RVA = "0x10D45F4", Offset = "0x10D45F4", VA = "0x10D45F4")]
		public static void SetAgeRestrictedUserStatus(TDStatus status)
		{
		}

		[Token(Token = "0x600025E")]
		[Address(RVA = "0x10D46DC", Offset = "0x10D46DC", VA = "0x10D46DC")]
		[Attribute(Name = "ObsoleteAttribute", RVA = "0x6FA8D0", Offset = "0x6FA8D0")]
		public static bool IsAgeRestrictedUser()
		{
			return default(bool);
		}

		[Token(Token = "0x600025F")]
		[Address(RVA = "0x10D2C88", Offset = "0x10D2C88", VA = "0x10D2C88")]
		public static TDStatus GetAgeRestrictedUserStatus()
		{
			return default(TDStatus);
		}

		[Token(Token = "0x6000260")]
		[Address(RVA = "0x10D46F8", Offset = "0x10D46F8", VA = "0x10D46F8")]
		public static void SetUserSubjectToUSPrivacyStatus(TDStatus status)
		{
		}

		[Token(Token = "0x6000261")]
		[Address(RVA = "0x10D47E0", Offset = "0x10D47E0", VA = "0x10D47E0")]
		public static TDStatus GetUserSubjectToUSPrivacyStatus()
		{
			return default(TDStatus);
		}

		[Token(Token = "0x6000262")]
		[Address(RVA = "0x10D48D4", Offset = "0x10D48D4", VA = "0x10D48D4")]
		public static void SetUSPrivacyStatus(TDStatus status)
		{
		}

		[Token(Token = "0x6000263")]
		[Address(RVA = "0x10D49BC", Offset = "0x10D49BC", VA = "0x10D49BC")]
		public static TDStatus GetUSPrivacyStatus()
		{
			return default(TDStatus);
		}

		[Token(Token = "0x6000264")]
		[Address(RVA = "0x10D4AB0", Offset = "0x10D4AB0", VA = "0x10D4AB0")]
		public static void SetAdMobContentRating(string rating)
		{
		}

		[Token(Token = "0x6000265")]
		[Address(RVA = "0x10D4B64", Offset = "0x10D4B64", VA = "0x10D4B64")]
		public static string GetAdMobContentRating()
		{
			return null;
		}

		[Token(Token = "0x6000266")]
		[Address(RVA = "0x10D4C58", Offset = "0x10D4C58", VA = "0x10D4C58")]
		public static void SetAdvertiserTrackingEnabled(TDStatus status)
		{
		}

		[Token(Token = "0x6000267")]
		[Address(RVA = "0x10D4C5C", Offset = "0x10D4C5C", VA = "0x10D4C5C")]
		public static TDStatus GetAdvertiserTrackingEnabled()
		{
			return default(TDStatus);
		}

		[Token(Token = "0x6000268")]
		[Address(RVA = "0x10D4C64", Offset = "0x10D4C64", VA = "0x10D4C64")]
		public static void SetUserId(string userId)
		{
		}

		[Token(Token = "0x6000269")]
		[Address(RVA = "0x10D2D7C", Offset = "0x10D2D7C", VA = "0x10D2D7C")]
		public static string GetUserId()
		{
			return null;
		}

		[Token(Token = "0x600026A")]
		[Address(RVA = "0x10D4D18", Offset = "0x10D4D18", VA = "0x10D4D18")]
		public static void SetForwardUserId(bool forwardUserId)
		{
		}

		[Token(Token = "0x600026B")]
		[Address(RVA = "0x10D2E70", Offset = "0x10D2E70", VA = "0x10D2E70")]
		public static bool ShouldForwardUserId()
		{
			return default(bool);
		}

		[Token(Token = "0x600026C")]
		[Address(RVA = "0x10D4E00", Offset = "0x10D4E00", VA = "0x10D4E00")]
		public static void SetMuted(bool muted)
		{
		}

		[Token(Token = "0x600026D")]
		[Address(RVA = "0x10D4EE8", Offset = "0x10D4EE8", VA = "0x10D4EE8")]
		public static bool IsMuted()
		{
			return default(bool);
		}

		[Token(Token = "0x600026E")]
		[Address(RVA = "0x10D4FDC", Offset = "0x10D4FDC", VA = "0x10D4FDC")]
		public static void SetUserData(string key, string value)
		{
		}

		[Token(Token = "0x600026F")]
		[Address(RVA = "0x10D50C4", Offset = "0x10D50C4", VA = "0x10D50C4")]
		public static void SetUserData(string key, int value)
		{
		}

		[Token(Token = "0x6000270")]
		[Address(RVA = "0x10D51D8", Offset = "0x10D51D8", VA = "0x10D51D8")]
		public static void SetUserData(string key, bool value)
		{
		}

		[Token(Token = "0x6000271")]
		[Address(RVA = "0x10D52F0", Offset = "0x10D52F0", VA = "0x10D52F0")]
		public static string GetUserDataString(string key)
		{
			return null;
		}

		[Token(Token = "0x6000272")]
		[Address(RVA = "0x10D53BC", Offset = "0x10D53BC", VA = "0x10D53BC")]
		public static int GetUserDataInteger(string key)
		{
			return default(int);
		}

		[Token(Token = "0x6000273")]
		[Address(RVA = "0x10D5488", Offset = "0x10D5488", VA = "0x10D5488")]
		public static bool GetUserDataBoolean(string key)
		{
			return default(bool);
		}

		[Token(Token = "0x6000274")]
		[Address(RVA = "0x10D5554", Offset = "0x10D5554", VA = "0x10D5554")]
		public static Dictionary<string, object> GetAllUserData()
		{
			return null;
		}

		[Token(Token = "0x6000275")]
		[Address(RVA = "0x10D5664", Offset = "0x10D5664", VA = "0x10D5664")]
		public static void RemoveUserData(string key)
		{
		}

		[Token(Token = "0x6000276")]
		[Address(RVA = "0x10D5718", Offset = "0x10D5718", VA = "0x10D5718")]
		public static void LoadInterstitial(string tag = "default")
		{
		}

		[Token(Token = "0x6000277")]
		[Address(RVA = "0x10D57CC", Offset = "0x10D57CC", VA = "0x10D57CC")]
		[Attribute(Name = "ObsoleteAttribute", RVA = "0x6FA908", Offset = "0x6FA908")]
		public static void LoadInterstitialWithTag(string tag)
		{
		}

		[Token(Token = "0x6000278")]
		[Address(RVA = "0x10D581C", Offset = "0x10D581C", VA = "0x10D581C")]
		public static void ShowInterstitial(string tag = "default")
		{
		}

		[Token(Token = "0x6000279")]
		[Address(RVA = "0x10D58D0", Offset = "0x10D58D0", VA = "0x10D58D0")]
		public static bool IsInterstitialReady(string tag = "default")
		{
			return default(bool);
		}

		[Token(Token = "0x600027A")]
		[Address(RVA = "0x10D599C", Offset = "0x10D599C", VA = "0x10D599C")]
		[Attribute(Name = "ObsoleteAttribute", RVA = "0x6FA940", Offset = "0x6FA940")]
		public static bool IsInterstitialReadyWithTag(string tag)
		{
			return default(bool);
		}

		[Token(Token = "0x600027B")]
		[Address(RVA = "0x10D59EC", Offset = "0x10D59EC", VA = "0x10D59EC")]
		public static TDAdError GetInterstitialFrequencyCapError(string tag = "default")
		{
			return null;
		}

		[Token(Token = "0x600027C")]
		[Address(RVA = "0x10D5B00", Offset = "0x10D5B00", VA = "0x10D5B00")]
		public static bool IsBannerReady(string tag = "default")
		{
			return default(bool);
		}

		[Token(Token = "0x600027D")]
		[Address(RVA = "0x10D5BCC", Offset = "0x10D5BCC", VA = "0x10D5BCC")]
		public static void RequestBanner(TDMBannerSize size, string tag = "default")
		{
		}

		[Token(Token = "0x600027E")]
		[Address(RVA = "0x10D5D00", Offset = "0x10D5D00", VA = "0x10D5D00")]
		public static void RequestBanner(int width, int height, string tag = "default")
		{
		}

		[Token(Token = "0x600027F")]
		[Address(RVA = "0x10D5E5C", Offset = "0x10D5E5C", VA = "0x10D5E5C")]
		public static void ShowBanner(TDBannerPosition position, string tag = "default")
		{
		}

		[Token(Token = "0x6000280")]
		[Address(RVA = "0x10D5F90", Offset = "0x10D5F90", VA = "0x10D5F90")]
		public static void ShowBanner(int x, int y, string tag = "default")
		{
		}

		[Token(Token = "0x6000281")]
		[Address(RVA = "0x10D60EC", Offset = "0x10D60EC", VA = "0x10D60EC")]
		public static void HideBanner(string tag = "default")
		{
		}

		[Token(Token = "0x6000282")]
		[Address(RVA = "0x10D61A0", Offset = "0x10D61A0", VA = "0x10D61A0")]
		public static void DestroyBanner(string tag = "default")
		{
		}

		[Token(Token = "0x6000283")]
		[Address(RVA = "0x10D6254", Offset = "0x10D6254", VA = "0x10D6254")]
		public static void LoadVideo(string tag = "default")
		{
		}

		[Token(Token = "0x6000284")]
		[Address(RVA = "0x10D6308", Offset = "0x10D6308", VA = "0x10D6308")]
		[Attribute(Name = "ObsoleteAttribute", RVA = "0x6FA978", Offset = "0x6FA978")]
		public static void LoadVideoWithTag(string tag)
		{
		}

		[Token(Token = "0x6000285")]
		[Address(RVA = "0x10D6358", Offset = "0x10D6358", VA = "0x10D6358")]
		public static void ShowVideo(string tag = "default")
		{
		}

		[Token(Token = "0x6000286")]
		[Address(RVA = "0x10D640C", Offset = "0x10D640C", VA = "0x10D640C")]
		public static bool IsVideoReady(string tag = "default")
		{
			return default(bool);
		}

		[Token(Token = "0x6000287")]
		[Address(RVA = "0x10D64D8", Offset = "0x10D64D8", VA = "0x10D64D8")]
		[Attribute(Name = "ObsoleteAttribute", RVA = "0x6FA9B0", Offset = "0x6FA9B0")]
		public static bool IsVideoReadyWithTag(string tag)
		{
			return default(bool);
		}

		[Token(Token = "0x6000288")]
		[Address(RVA = "0x10D6528", Offset = "0x10D6528", VA = "0x10D6528")]
		public static TDAdError GetVideoFrequencyCapError(string tag = "default")
		{
			return null;
		}

		[Token(Token = "0x6000289")]
		[Address(RVA = "0x10D663C", Offset = "0x10D663C", VA = "0x10D663C")]
		public static void LoadRewardedVideo(string tag = "default")
		{
		}

		[Token(Token = "0x600028A")]
		[Address(RVA = "0x10D66F0", Offset = "0x10D66F0", VA = "0x10D66F0")]
		[Attribute(Name = "ObsoleteAttribute", RVA = "0x6FA9E8", Offset = "0x6FA9E8")]
		public static void LoadRewardedVideoWithTag(string tag)
		{
		}

		[Token(Token = "0x600028B")]
		[Address(RVA = "0x10D6740", Offset = "0x10D6740", VA = "0x10D6740")]
		[Attribute(Name = "ObsoleteAttribute", RVA = "0x6FAA20", Offset = "0x6FAA20")]
		public static void ShowRewardVideo(string tag, string hashedUserId)
		{
		}

		[Token(Token = "0x600028C")]
		[Address(RVA = "0x10D6828", Offset = "0x10D6828", VA = "0x10D6828")]
		public static void ShowRewardVideo(string tag = "default")
		{
		}

		[Token(Token = "0x600028D")]
		[Address(RVA = "0x10D6830", Offset = "0x10D6830", VA = "0x10D6830")]
		public static bool IsRewardedVideoReady(string tag = "default")
		{
			return default(bool);
		}

		[Token(Token = "0x600028E")]
		[Address(RVA = "0x10D68FC", Offset = "0x10D68FC", VA = "0x10D68FC")]
		[Attribute(Name = "ObsoleteAttribute", RVA = "0x6FAA58", Offset = "0x6FAA58")]
		public static bool IsRewardedVideoReadyWithTag(string tag)
		{
			return default(bool);
		}

		[Token(Token = "0x600028F")]
		[Address(RVA = "0x10D694C", Offset = "0x10D694C", VA = "0x10D694C")]
		public static TDAdError GetRewardedVideoFrequencyCapError(string tag = "default")
		{
			return null;
		}

		[Token(Token = "0x6000290")]
		[Address(RVA = "0x10D6A60", Offset = "0x10D6A60", VA = "0x10D6A60")]
		[Attribute(Name = "ObsoleteAttribute", RVA = "0x6FAA90", Offset = "0x6FAA90")]
		public static void SendIAP(string name, double price, string locale)
		{
		}

		[Token(Token = "0x6000291")]
		[Address(RVA = "0x10D6C4C", Offset = "0x10D6C4C", VA = "0x10D6C4C")]
		public static void SendIAP_iOS(string transactionId, string productId, string name, double price, string currency, string locale)
		{
		}

		[Token(Token = "0x6000292")]
		[Address(RVA = "0x10D6A78", Offset = "0x10D6A78", VA = "0x10D6A78")]
		public static void SendIAP_Android(string in_app_purchase_data, string in_app_purchase_signature, string name, double price, string currency, string locale)
		{
		}

		[Token(Token = "0x6000293")]
		[Address(RVA = "0x10D6C50", Offset = "0x10D6C50", VA = "0x10D6C50")]
		public static string GetRewardId(string tag)
		{
			return null;
		}

		[Token(Token = "0x6000294")]
		[Address(RVA = "0x10D6D1C", Offset = "0x10D6D1C", VA = "0x10D6D1C")]
		public static List<TDNetworkStatus> GetNetworkStatuses()
		{
			return null;
		}
	}
}
