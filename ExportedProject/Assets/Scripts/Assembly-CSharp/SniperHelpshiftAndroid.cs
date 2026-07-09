using System;
using Il2CppDummyDll;

[Token(Token = "0x200024C")]
public class SniperHelpshiftAndroid : SniperHelpshiftAbstract
{
	[Token(Token = "0x4000CCB")]
	private const string NOTIFICATION_ORIGIN_KEY = "origin";

	[Token(Token = "0x4000CCC")]
	private const string NOTIFICATION_ORIGIN_HELPSHIFT = "helpshift";

	[Token(Token = "0x4000CCD")]
	[FieldOffset(Offset = "0x10")]
	private bool _installed;

	[Token(Token = "0x17000236")]
	public override bool Installed
	{
		[Token(Token = "0x6000DDA")]
		[Address(RVA = "0xA5F6F0", Offset = "0xA5F6F0", VA = "0xA5F6F0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000237")]
	public override string PushNotificationToken
	{
		[Token(Token = "0x6000DDB")]
		[Address(RVA = "0xA5F6F8", Offset = "0xA5F6F8", VA = "0xA5F6F8", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x14000036")]
	public override event Action<string> OnRegisteredForPushNotifications
	{
		[Token(Token = "0x6000DD8")]
		[Address(RVA = "0xA5F5D0", Offset = "0xA5F5D0", VA = "0xA5F5D0", Slot = "4")]
		add
		{
		}
		[Token(Token = "0x6000DD9")]
		[Address(RVA = "0xA5F660", Offset = "0xA5F660", VA = "0xA5F660", Slot = "5")]
		remove
		{
		}
	}

	[Token(Token = "0x6000DDC")]
	[Address(RVA = "0xA5F778", Offset = "0xA5F778", VA = "0xA5F778", Slot = "8")]
	public override void OnInitialize()
	{
	}

	[Token(Token = "0x6000DDD")]
	[Address(RVA = "0xA5F970", Offset = "0xA5F970", VA = "0xA5F970", Slot = "11")]
	public override void LoginSDK()
	{
	}

	[Token(Token = "0x6000DDE")]
	[Address(RVA = "0xA5FA4C", Offset = "0xA5FA4C", VA = "0xA5FA4C", Slot = "9")]
	public override void ShowSupport()
	{
	}

	[Token(Token = "0x6000DDF")]
	[Address(RVA = "0xA5FA50", Offset = "0xA5FA50", VA = "0xA5FA50", Slot = "10")]
	public override void RegisterDeviceTokenWithSdk(string token)
	{
	}

	[Token(Token = "0x6000DE0")]
	[Address(RVA = "0xA5FAC4", Offset = "0xA5FAC4", VA = "0xA5FAC4")]
	private static void OnReceivePushNotification(string notificationJsonStr)
	{
	}

	[Token(Token = "0x6000DE1")]
	[Address(RVA = "0xA5E804", Offset = "0xA5E804", VA = "0xA5E804")]
	public SniperHelpshiftAndroid()
	{
	}
}
