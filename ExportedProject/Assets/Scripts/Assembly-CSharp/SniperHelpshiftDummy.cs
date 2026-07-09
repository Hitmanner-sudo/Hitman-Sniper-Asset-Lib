using System;
using Il2CppDummyDll;

[Token(Token = "0x200024D")]
public class SniperHelpshiftDummy : SniperHelpshiftAbstract
{
	[Token(Token = "0x17000238")]
	public override bool Installed
	{
		[Token(Token = "0x6000DE4")]
		[Address(RVA = "0xA5FBEC", Offset = "0xA5FBEC", VA = "0xA5FBEC", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000239")]
	public override string PushNotificationToken
	{
		[Token(Token = "0x6000DE5")]
		[Address(RVA = "0xA5FBF4", Offset = "0xA5FBF4", VA = "0xA5FBF4", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x14000037")]
	public override event Action<string> OnRegisteredForPushNotifications
	{
		[Token(Token = "0x6000DE2")]
		[Address(RVA = "0xA5FBE4", Offset = "0xA5FBE4", VA = "0xA5FBE4", Slot = "4")]
		add
		{
		}
		[Token(Token = "0x6000DE3")]
		[Address(RVA = "0xA5FBE8", Offset = "0xA5FBE8", VA = "0xA5FBE8", Slot = "5")]
		remove
		{
		}
	}

	[Token(Token = "0x6000DE6")]
	[Address(RVA = "0xA5FC38", Offset = "0xA5FC38", VA = "0xA5FC38", Slot = "8")]
	public override void OnInitialize()
	{
	}

	[Token(Token = "0x6000DE7")]
	[Address(RVA = "0xA5FC3C", Offset = "0xA5FC3C", VA = "0xA5FC3C", Slot = "9")]
	public override void ShowSupport()
	{
	}

	[Token(Token = "0x6000DE8")]
	[Address(RVA = "0xA605A4", Offset = "0xA605A4", VA = "0xA605A4", Slot = "10")]
	public override void RegisterDeviceTokenWithSdk(string token)
	{
	}

	[Token(Token = "0x6000DE9")]
	[Address(RVA = "0xA605A8", Offset = "0xA605A8", VA = "0xA605A8")]
	public SniperHelpshiftDummy()
	{
	}
}
