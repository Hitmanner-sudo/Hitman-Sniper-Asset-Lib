using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Helpshift
{
	[Token(Token = "0x20012CF")]
	public class HelpshiftAndroid
	{
		[Token(Token = "0x4005A22")]
		[FieldOffset(Offset = "0x10")]
		private AndroidJavaClass jc;

		[Token(Token = "0x4005A23")]
		[FieldOffset(Offset = "0x18")]
		private AndroidJavaObject currentActivity;

		[Token(Token = "0x4005A24")]
		[FieldOffset(Offset = "0x20")]
		private AndroidJavaObject application;

		[Token(Token = "0x4005A25")]
		[FieldOffset(Offset = "0x28")]
		private AndroidJavaClass hsHelpshiftClass;

		[Token(Token = "0x6006DAC")]
		[Address(RVA = "0xA0C508", Offset = "0xA0C508", VA = "0xA0C508")]
		public HelpshiftAndroid()
		{
		}

		[Token(Token = "0x6006DAD")]
		[Address(RVA = "0xA0C6E8", Offset = "0xA0C6E8", VA = "0xA0C6E8")]
		public void install(string apiKey, string domain, string appId, Dictionary<string, object> configMap)
		{
		}

		[Token(Token = "0x6006DAE")]
		[Address(RVA = "0xA0CA3C", Offset = "0xA0CA3C", VA = "0xA0CA3C")]
		public void requestUnreadMessagesCount(bool isAsync)
		{
		}

		[Token(Token = "0x6006DAF")]
		[Address(RVA = "0xA0CBB0", Offset = "0xA0CBB0", VA = "0xA0CBB0")]
		[Attribute(Name = "ObsoleteAttribute", RVA = "0x62C280", Offset = "0x62C280")]
		public void setNameAndEmail(string userName, string email)
		{
		}

		[Token(Token = "0x6006DB0")]
		[Address(RVA = "0xA0CCAC", Offset = "0xA0CCAC", VA = "0xA0CCAC")]
		[Attribute(Name = "ObsoleteAttribute", RVA = "0x62C290", Offset = "0x62C290")]
		public void setUserIdentifier(string identifier)
		{
		}

		[Token(Token = "0x6006DB1")]
		[Address(RVA = "0xA0CD7C", Offset = "0xA0CD7C", VA = "0xA0CD7C")]
		public void registerDeviceToken(string deviceToken)
		{
		}

		[Token(Token = "0x6006DB2")]
		[Address(RVA = "0xA0CED8", Offset = "0xA0CED8", VA = "0xA0CED8")]
		public void leaveBreadCrumb(string breadCrumb)
		{
		}

		[Token(Token = "0x6006DB3")]
		[Address(RVA = "0xA0CFA8", Offset = "0xA0CFA8", VA = "0xA0CFA8")]
		public void clearBreadCrumbs()
		{
		}

		[Token(Token = "0x6006DB4")]
		[Address(RVA = "0xA0D0A4", Offset = "0xA0D0A4", VA = "0xA0D0A4")]
		[Attribute(Name = "ObsoleteAttribute", RVA = "0x62C2A0", Offset = "0x62C2A0")]
		public void login(string identifier, string userName, string email)
		{
		}

		[Token(Token = "0x6006DB5")]
		[Address(RVA = "0xA0D234", Offset = "0xA0D234", VA = "0xA0D234")]
		public void login(HelpshiftUser helpshiftUser)
		{
		}

		[Token(Token = "0x6006DB6")]
		[Address(RVA = "0xA0D4B0", Offset = "0xA0D4B0", VA = "0xA0D4B0")]
		public void clearAnonymousUser()
		{
		}

		[Token(Token = "0x6006DB7")]
		[Address(RVA = "0xA0D5AC", Offset = "0xA0D5AC", VA = "0xA0D5AC")]
		public void logout()
		{
		}

		[Token(Token = "0x6006DB8")]
		[Address(RVA = "0xA0D6A8", Offset = "0xA0D6A8", VA = "0xA0D6A8")]
		private string serializeApiConfig(Dictionary<string, object> configMap)
		{
			return null;
		}

		[Token(Token = "0x6006DB9")]
		[Address(RVA = "0xA0D7C8", Offset = "0xA0D7C8", VA = "0xA0D7C8")]
		public void showConversation(Dictionary<string, object> configMap)
		{
		}

		[Token(Token = "0x6006DBA")]
		[Address(RVA = "0xA0D8DC", Offset = "0xA0D8DC", VA = "0xA0D8DC")]
		public void showFAQSection(string sectionPublishId, Dictionary<string, object> configMap)
		{
		}

		[Token(Token = "0x6006DBB")]
		[Address(RVA = "0xA0DA1C", Offset = "0xA0DA1C", VA = "0xA0DA1C")]
		public void showSingleFAQ(string questionPublishId, Dictionary<string, object> configMap)
		{
		}

		[Token(Token = "0x6006DBC")]
		[Address(RVA = "0xA0DB5C", Offset = "0xA0DB5C", VA = "0xA0DB5C")]
		public void showFAQs(Dictionary<string, object> configMap)
		{
		}

		[Token(Token = "0x6006DBD")]
		[Address(RVA = "0xA0DC70", Offset = "0xA0DC70", VA = "0xA0DC70")]
		public void updateMetaData(Dictionary<string, object> metaData)
		{
		}

		[Token(Token = "0x6006DBE")]
		[Address(RVA = "0xA0D6CC", Offset = "0xA0D6CC", VA = "0xA0D6CC")]
		private Dictionary<string, object> cleanConfig(Dictionary<string, object> configMap)
		{
			return null;
		}

		[Token(Token = "0x6006DBF")]
		[Address(RVA = "0xA0DD50", Offset = "0xA0DD50", VA = "0xA0DD50")]
		public void handlePushNotification(Dictionary<string, object> pushNotificationData)
		{
		}

		[Token(Token = "0x6006DC0")]
		[Address(RVA = "0xA0DED4", Offset = "0xA0DED4", VA = "0xA0DED4")]
		public void showAlertToRateAppWithURL(string url)
		{
		}

		[Token(Token = "0x6006DC1")]
		[Address(RVA = "0xA0DFA4", Offset = "0xA0DFA4", VA = "0xA0DFA4")]
		public void registerDelegates()
		{
		}

		[Token(Token = "0x6006DC2")]
		[Address(RVA = "0xA0E0E8", Offset = "0xA0E0E8", VA = "0xA0E0E8")]
		public void setSDKLanguage(string locale)
		{
		}

		[Token(Token = "0x6006DC3")]
		[Address(RVA = "0xA0E1B8", Offset = "0xA0E1B8", VA = "0xA0E1B8")]
		public void setTheme(string themeResourceName)
		{
		}

		[Token(Token = "0x6006DC4")]
		[Address(RVA = "0xA0E288", Offset = "0xA0E288", VA = "0xA0E288")]
		public void showDynamicForm(string title, Dictionary<string, object>[] flows)
		{
		}

		[Token(Token = "0x6006DC5")]
		[Address(RVA = "0xA0E3C8", Offset = "0xA0E3C8", VA = "0xA0E3C8")]
		public void checkIfConversationActive()
		{
		}

		[Token(Token = "0x6006DC6")]
		[Address(RVA = "0xA0E4C4", Offset = "0xA0E4C4", VA = "0xA0E4C4")]
		public void onApplicationQuit()
		{
		}

		[Token(Token = "0x6006DC7")]
		[Address(RVA = "0xA0D374", Offset = "0xA0D374", VA = "0xA0D374")]
		private string jsonifyHelpshiftUser(HelpshiftUser helpshiftUser)
		{
			return null;
		}
	}
}
