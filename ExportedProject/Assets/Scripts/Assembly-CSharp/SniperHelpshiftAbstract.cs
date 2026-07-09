using System;
using Il2CppDummyDll;

[Token(Token = "0x200024B")]
public abstract class SniperHelpshiftAbstract
{
	[Token(Token = "0x17000234")]
	public abstract bool Installed
	{
		[Token(Token = "0x6000DCB")]
		get;
	}

	[Token(Token = "0x17000235")]
	public abstract string PushNotificationToken
	{
		[Token(Token = "0x6000DCC")]
		get;
	}

	[Token(Token = "0x14000035")]
	[method: Token(Token = "0x6000DC9")]
	[method: AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x614EA4", Offset = "0x614EA4")]
	public abstract event Action<string> OnRegisteredForPushNotifications;

	[Token(Token = "0x6000DCD")]
	public abstract void OnInitialize();

	[Token(Token = "0x6000DCE")]
	public abstract void ShowSupport();

	[Token(Token = "0x6000DCF")]
	public abstract void RegisterDeviceTokenWithSdk(string token);

	[Token(Token = "0x6000DD0")]
	[Address(RVA = "0xA5E80C", Offset = "0xA5E80C", VA = "0xA5E80C")]
	public void Initialize()
	{
	}

	[Token(Token = "0x6000DD1")]
	[Address(RVA = "0xA5F1B4", Offset = "0xA5F1B4", VA = "0xA5F1B4", Slot = "11")]
	public virtual void LoginSDK()
	{
	}

	[Token(Token = "0x6000DD2")]
	[Address(RVA = "0xA5EA24", Offset = "0xA5EA24", VA = "0xA5EA24")]
	public void QueryNotificationCount(bool async)
	{
	}

	[Token(Token = "0x6000DD3")]
	[Address(RVA = "0xA5F2DC", Offset = "0xA5F2DC", VA = "0xA5F2DC")]
	protected void OnLanguageChanged(object sender, EventArgs eventArgs)
	{
	}

	[Token(Token = "0x6000DD4")]
	[Address(RVA = "0xA5F4D8", Offset = "0xA5F4D8", VA = "0xA5F4D8")]
	protected void RegisterForNotificationsAndShowFaqs()
	{
	}

	[Token(Token = "0x6000DD5")]
	[Address(RVA = "0xA5F53C", Offset = "0xA5F53C", VA = "0xA5F53C")]
	private void ShowFaqAndConversation()
	{
	}

	[Token(Token = "0x6000DD6")]
	[Address(RVA = "0xA5F37C", Offset = "0xA5F37C", VA = "0xA5F37C")]
	private static string GetHelpshiftLocaleFromLangauge()
	{
		return null;
	}

	[Token(Token = "0x6000DD7")]
	[Address(RVA = "0xA5F5C8", Offset = "0xA5F5C8", VA = "0xA5F5C8")]
	protected SniperHelpshiftAbstract()
	{
	}
}
