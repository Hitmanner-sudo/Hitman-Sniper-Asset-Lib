using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Helpshift
{
	[Token(Token = "0x20012D1")]
	public class HelpshiftSdk
	{
		[Token(Token = "0x4005A27")]
		public const string HS_RATE_ALERT_CLOSE = "HS_RATE_ALERT_CLOSE";

		[Token(Token = "0x4005A28")]
		public const string HS_RATE_ALERT_FEEDBACK = "HS_RATE_ALERT_FEEDBACK";

		[Token(Token = "0x4005A29")]
		public const string HS_RATE_ALERT_SUCCESS = "HS_RATE_ALERT_SUCCESS";

		[Token(Token = "0x4005A2A")]
		public const string HS_RATE_ALERT_FAIL = "HS_RATE_ALERT_FAIL";

		[Token(Token = "0x4005A2B")]
		public const string HSTAGSKEY = "hs-tags";

		[Token(Token = "0x4005A2C")]
		public const string HSCUSTOMMETADATAKEY = "hs-custom-metadata";

		[Token(Token = "0x4005A2D")]
		public const string UNITY_GAME_OBJECT = "unityGameObject";

		[Token(Token = "0x4005A2E")]
		public const string ENABLE_IN_APP_NOTIFICATION = "enableInAppNotification";

		[Token(Token = "0x4005A2F")]
		public const string ENABLE_DEFAULT_FALLBACK_LANGUAGE = "enableDefaultFallbackLanguage";

		[Token(Token = "0x4005A30")]
		public const string ENABLE_LOGGING = "enableLogging";

		[Token(Token = "0x4005A31")]
		public const string ENABLE_INBOX_POLLING = "enableInboxPolling";

		[Token(Token = "0x4005A32")]
		public const string ENABLE_AUTOMATIC_THEME_SWITCHING = "enableAutomaticThemeSwitching";

		[Token(Token = "0x4005A33")]
		public const string DISABLE_ENTRY_EXIT_ANIMATIONS = "disableEntryExitAnimations";

		[Token(Token = "0x4005A34")]
		public const string DISABLE_ERROR_REPORTING = "disableErrorReporting";

		[Token(Token = "0x4005A35")]
		public const string HSCUSTOMISSUEFIELDKEY = "hs-custom-issue-field";

		[Token(Token = "0x4005A36")]
		public const string HSTAGSMATCHINGKEY = "withTagsMatching";

		[Token(Token = "0x4005A37")]
		public const string CONTACT_US_ALWAYS = "always";

		[Token(Token = "0x4005A38")]
		public const string CONTACT_US_NEVER = "never";

		[Token(Token = "0x4005A39")]
		public const string CONTACT_US_AFTER_VIEWING_FAQS = "after_viewing_faqs";

		[Token(Token = "0x4005A3A")]
		public const string CONTACT_US_AFTER_MARKING_ANSWER_UNHELPFUL = "after_marking_answer_unhelpful";

		[Token(Token = "0x4005A3B")]
		public const string HSUserAcceptedTheSolution = "User accepted the solution";

		[Token(Token = "0x4005A3C")]
		public const string HSUserRejectedTheSolution = "User rejected the solution";

		[Token(Token = "0x4005A3D")]
		public const string HSUserSentScreenShot = "User sent a screenshot";

		[Token(Token = "0x4005A3E")]
		public const string HSUserReviewedTheApp = "User reviewed the app";

		[Token(Token = "0x4005A3F")]
		public const string HsFlowTypeDefault = "defaultFlow";

		[Token(Token = "0x4005A40")]
		public const string HsFlowTypeConversation = "conversationFlow";

		[Token(Token = "0x4005A41")]
		public const string HsFlowTypeFaqs = "faqsFlow";

		[Token(Token = "0x4005A42")]
		public const string HsFlowTypeFaqSection = "faqSectionFlow";

		[Token(Token = "0x4005A43")]
		public const string HsFlowTypeSingleFaq = "singleFaqFlow";

		[Token(Token = "0x4005A44")]
		public const string HsFlowTypeNested = "dynamicFormFlow";

		[Token(Token = "0x4005A45")]
		public const string HsCustomContactUsFlows = "customContactUsFlows";

		[Token(Token = "0x4005A46")]
		public const string HsFlowType = "type";

		[Token(Token = "0x4005A47")]
		public const string HsFlowConfig = "config";

		[Token(Token = "0x4005A48")]
		public const string HsFlowData = "data";

		[Token(Token = "0x4005A49")]
		public const string HsFlowTitle = "title";

		[Token(Token = "0x4005A4A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static HelpshiftSdk instance;

		[Token(Token = "0x4005A4B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static HelpshiftAndroid nativeSdk;

		[Token(Token = "0x6006DCF")]
		[Address(RVA = "0xA11E8C", Offset = "0xA11E8C", VA = "0xA11E8C")]
		private HelpshiftSdk()
		{
		}

		[Token(Token = "0x6006DD0")]
		[Address(RVA = "0xA0FFC8", Offset = "0xA0FFC8", VA = "0xA0FFC8")]
		public static HelpshiftSdk getInstance()
		{
			return null;
		}

		[Token(Token = "0x6006DD1")]
		[Address(RVA = "0xA103BC", Offset = "0xA103BC", VA = "0xA103BC")]
		public void install(string apiKey, string domainName, string appId, [Optional] Dictionary<string, object> config)
		{
		}

		[Token(Token = "0x6006DD2")]
		[Address(RVA = "0xA105FC", Offset = "0xA105FC", VA = "0xA105FC")]
		public void requestUnreadMessagesCount(bool isAsync)
		{
		}

		[Token(Token = "0x6006DD3")]
		[Address(RVA = "0xA11E94", Offset = "0xA11E94", VA = "0xA11E94")]
		[Attribute(Name = "ObsoleteAttribute", RVA = "0x62C2D8", Offset = "0x62C2D8")]
		public void setNameAndEmail(string userName, string email)
		{
		}

		[Token(Token = "0x6006DD4")]
		[Address(RVA = "0xA11F18", Offset = "0xA11F18", VA = "0xA11F18")]
		[Attribute(Name = "ObsoleteAttribute", RVA = "0x62C2E8", Offset = "0x62C2E8")]
		public void setUserIdentifier(string identifier)
		{
		}

		[Token(Token = "0x6006DD5")]
		[Address(RVA = "0xA11F8C", Offset = "0xA11F8C", VA = "0xA11F8C")]
		[Attribute(Name = "ObsoleteAttribute", RVA = "0x62C2F8", Offset = "0x62C2F8")]
		public void login(string identifier, string name, string email)
		{
		}

		[Token(Token = "0x6006DD6")]
		[Address(RVA = "0xA12018", Offset = "0xA12018", VA = "0xA12018")]
		public void login(HelpshiftUser helpshiftUser)
		{
		}

		[Token(Token = "0x6006DD7")]
		[Address(RVA = "0xA1208C", Offset = "0xA1208C", VA = "0xA1208C")]
		public void clearAnonymousUser()
		{
		}

		[Token(Token = "0x6006DD8")]
		[Address(RVA = "0xA120F8", Offset = "0xA120F8", VA = "0xA120F8")]
		public void logout()
		{
		}

		[Token(Token = "0x6006DD9")]
		[Address(RVA = "0xA12164", Offset = "0xA12164", VA = "0xA12164")]
		public void registerDeviceToken(string deviceToken)
		{
		}

		[Token(Token = "0x6006DDA")]
		[Address(RVA = "0xA121D8", Offset = "0xA121D8", VA = "0xA121D8")]
		public void leaveBreadCrumb(string breadCrumb)
		{
		}

		[Token(Token = "0x6006DDB")]
		[Address(RVA = "0xA1224C", Offset = "0xA1224C", VA = "0xA1224C")]
		public void clearBreadCrumbs()
		{
		}

		[Token(Token = "0x6006DDC")]
		[Address(RVA = "0xA1118C", Offset = "0xA1118C", VA = "0xA1118C")]
		public void showConversation([Optional] Dictionary<string, object> configMap)
		{
		}

		[Token(Token = "0x6006DDD")]
		[Address(RVA = "0xA113F8", Offset = "0xA113F8", VA = "0xA113F8")]
		public void showFAQSection(string sectionPublishId, [Optional] Dictionary<string, object> configMap)
		{
		}

		[Token(Token = "0x6006DDE")]
		[Address(RVA = "0xA11674", Offset = "0xA11674", VA = "0xA11674")]
		public void showSingleFAQ(string questionPublishId, [Optional] Dictionary<string, object> configMap)
		{
		}

		[Token(Token = "0x6006DDF")]
		[Address(RVA = "0xA106FC", Offset = "0xA106FC", VA = "0xA106FC")]
		public void showFAQs([Optional] Dictionary<string, object> configMap)
		{
		}

		[Token(Token = "0x6006DE0")]
		[Address(RVA = "0xA0EF80", Offset = "0xA0EF80", VA = "0xA0EF80")]
		public void updateMetaData(Dictionary<string, object> metaData)
		{
		}

		[Token(Token = "0x6006DE1")]
		[Address(RVA = "0xA122B8", Offset = "0xA122B8", VA = "0xA122B8")]
		public void handlePushNotification(Dictionary<string, object> pushNotificationData)
		{
		}

		[Token(Token = "0x6006DE2")]
		[Address(RVA = "0xA1174C", Offset = "0xA1174C", VA = "0xA1174C")]
		public void showAlertToRateAppWithURL(string url)
		{
		}

		[Token(Token = "0x6006DE3")]
		[Address(RVA = "0xA125D4", Offset = "0xA125D4", VA = "0xA125D4")]
		public void setSDKLanguage(string locale)
		{
		}

		[Token(Token = "0x6006DE4")]
		[Address(RVA = "0xA12648", Offset = "0xA12648", VA = "0xA12648")]
		public void setTheme(string themeName)
		{
		}

		[Token(Token = "0x6006DE5")]
		[Address(RVA = "0xA10590", Offset = "0xA10590", VA = "0xA10590")]
		public void registerDelegates()
		{
		}

		[Token(Token = "0x6006DE6")]
		[Address(RVA = "0xA10E44", Offset = "0xA10E44", VA = "0xA10E44")]
		public void showDynamicForm(string title, Dictionary<string, object>[] flows)
		{
		}

		[Token(Token = "0x6006DE7")]
		[Address(RVA = "0xA126BC", Offset = "0xA126BC", VA = "0xA126BC")]
		public void showDynamicForm(string title, Dictionary<string, object>[] flows, [Optional] Dictionary<string, object> configMap)
		{
		}

		[Token(Token = "0x6006DE8")]
		[Address(RVA = "0xA12740", Offset = "0xA12740", VA = "0xA12740")]
		public void onApplicationQuit()
		{
		}

		[Token(Token = "0x6006DE9")]
		[Address(RVA = "0xA127AC", Offset = "0xA127AC", VA = "0xA127AC")]
		public void checkIfConversationActive()
		{
		}
	}
}
