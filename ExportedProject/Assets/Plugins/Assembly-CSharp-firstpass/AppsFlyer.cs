using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000005")]
public class AppsFlyer : MonoBehaviour
{
	[Token(Token = "0x4000044")]
	[FieldOffset(Offset = "0x0")]
	private static AndroidJavaClass obj;

	[Token(Token = "0x4000045")]
	[FieldOffset(Offset = "0x8")]
	private static AndroidJavaObject cls_AppsFlyer;

	[Token(Token = "0x4000046")]
	[FieldOffset(Offset = "0x10")]
	private static AndroidJavaClass cls_AppsFlyerHelper;

	[Token(Token = "0x4000047")]
	[FieldOffset(Offset = "0x18")]
	private static string devKey;

	[Token(Token = "0x600000D")]
	[Address(RVA = "0x10D7FC0", Offset = "0x10D7FC0", VA = "0x10D7FC0")]
	public static void trackEvent(string eventName, string eventValue)
	{
	}

	[Token(Token = "0x600000E")]
	[Address(RVA = "0x10D8008", Offset = "0x10D8008", VA = "0x10D8008")]
	public static void setCurrencyCode(string currencyCode)
	{
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0x10D8108", Offset = "0x10D8108", VA = "0x10D8108")]
	public static void setCustomerUserID(string customerUserID)
	{
	}

	[Token(Token = "0x6000010")]
	[Address(RVA = "0x10D8208", Offset = "0x10D8208", VA = "0x10D8208")]
	public static void loadConversionData(string callbackObject)
	{
	}

	[Token(Token = "0x6000011")]
	[Address(RVA = "0x10D8578", Offset = "0x10D8578", VA = "0x10D8578")]
	[Attribute(Name = "ObsoleteAttribute", RVA = "0x6F98D8", Offset = "0x6F98D8")]
	public static void loadConversionData(string callbackObject, string callbackMethod, string callbackFailedMethod)
	{
	}

	[Token(Token = "0x6000012")]
	[Address(RVA = "0x10D85D8", Offset = "0x10D85D8", VA = "0x10D85D8")]
	public static void setCollectIMEI(bool shouldCollect)
	{
	}

	[Token(Token = "0x6000013")]
	[Address(RVA = "0x10D8704", Offset = "0x10D8704", VA = "0x10D8704")]
	public static void setCollectAndroidID(bool shouldCollect)
	{
	}

	[Token(Token = "0x6000014")]
	[Address(RVA = "0x10D8850", Offset = "0x10D8850", VA = "0x10D8850")]
	public static void init(string key)
	{
	}

	[Token(Token = "0x6000015")]
	[Address(RVA = "0x10D8BD8", Offset = "0x10D8BD8", VA = "0x10D8BD8")]
	private static void init_cb()
	{
	}

	[Token(Token = "0x6000016")]
	[Address(RVA = "0x10D9408", Offset = "0x10D9408", VA = "0x10D9408")]
	public static void setAppsFlyerKey(string key)
	{
	}

	[Token(Token = "0x6000017")]
	[Address(RVA = "0x10D9070", Offset = "0x10D9070", VA = "0x10D9070")]
	public static void trackAppLaunch()
	{
	}

	[Token(Token = "0x6000018")]
	[Address(RVA = "0x10D9488", Offset = "0x10D9488", VA = "0x10D9488")]
	public static void setAppID(string packageName)
	{
	}

	[Token(Token = "0x6000019")]
	[Address(RVA = "0x10D9588", Offset = "0x10D9588", VA = "0x10D9588")]
	public static void createValidateInAppListener(string aObject, string callbackMethod, string callbackFailedMethod)
	{
	}

	[Token(Token = "0x600001A")]
	[Address(RVA = "0x10D99B0", Offset = "0x10D99B0", VA = "0x10D99B0")]
	public static void validateReceipt(string publicKey, string purchaseData, string signature, string price, string currency, Dictionary<string, string> extraParams)
	{
	}

	[Token(Token = "0x600001B")]
	[Address(RVA = "0x10DA724", Offset = "0x10DA724", VA = "0x10DA724")]
	public static void trackRichEvent(string eventName, Dictionary<string, string> eventValues)
	{
	}

	[Token(Token = "0x600001C")]
	[Address(RVA = "0x10DA084", Offset = "0x10DA084", VA = "0x10DA084")]
	private static AndroidJavaObject ConvertHashMap(Dictionary<string, string> dict)
	{
		return null;
	}

	[Token(Token = "0x600001D")]
	[Address(RVA = "0x10DAAF4", Offset = "0x10DAAF4", VA = "0x10DAAF4")]
	public static void setImeiData(string imeiData)
	{
	}

	[Token(Token = "0x600001E")]
	[Address(RVA = "0x10DAC14", Offset = "0x10DAC14", VA = "0x10DAC14")]
	public static void setAndroidIdData(string androidIdData)
	{
	}

	[Token(Token = "0x600001F")]
	[Address(RVA = "0x10DAD34", Offset = "0x10DAD34", VA = "0x10DAD34")]
	public static void setIsDebug(bool isDebug)
	{
	}

	[Token(Token = "0x6000020")]
	[Address(RVA = "0x10DAE80", Offset = "0x10DAE80", VA = "0x10DAE80")]
	public static void setIsSandbox(bool isSandbox)
	{
	}

	[Token(Token = "0x6000021")]
	[Address(RVA = "0x10DAE84", Offset = "0x10DAE84", VA = "0x10DAE84")]
	public static void getConversionData()
	{
	}

	[Token(Token = "0x6000022")]
	[Address(RVA = "0x10DAE88", Offset = "0x10DAE88", VA = "0x10DAE88")]
	public static void handleOpenUrl(string url, string sourceApplication, string annotation)
	{
	}

	[Token(Token = "0x6000023")]
	[Address(RVA = "0x10DAE8C", Offset = "0x10DAE8C", VA = "0x10DAE8C")]
	public static string getAppsFlyerId()
	{
		return null;
	}

	[Token(Token = "0x6000024")]
	[Address(RVA = "0x10DB1DC", Offset = "0x10DB1DC", VA = "0x10DB1DC")]
	public static void setGCMProjectNumber(string googleGCMNumber)
	{
	}

	[Token(Token = "0x6000025")]
	[Address(RVA = "0x10DB2DC", Offset = "0x10DB2DC", VA = "0x10DB2DC")]
	public AppsFlyer()
	{
	}
}
