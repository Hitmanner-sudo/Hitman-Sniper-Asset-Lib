using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Technology;

[Token(Token = "0x200024A")]
[AutoInstantiate]
[Scope]
public class SniperHelpshift : GameSingleton<SniperHelpshift>
{
	[Token(Token = "0x4000CC9")]
	[FieldOffset(Offset = "0x50")]
	private SniperHelpshiftAbstract _impl;

	[Token(Token = "0x4000CCA")]
	[FieldOffset(Offset = "0x58")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5B36B8", Offset = "0x5B36B8")]
	private int _003CNotificationCount_003Ek__BackingField;

	[Token(Token = "0x17000233")]
	public int NotificationCount
	{
		[Token(Token = "0x6000DBF")]
		[Address(RVA = "0xA5E78C", Offset = "0xA5E78C", VA = "0xA5E78C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x614E84", Offset = "0x614E84")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6000DC0")]
		[Address(RVA = "0xA5E794", Offset = "0xA5E794", VA = "0xA5E794")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x614E94", Offset = "0x614E94")]
		private set
		{
		}
	}

	[Token(Token = "0x14000034")]
	public event Action<int> NotificationCountChanged
	{
		[Token(Token = "0x6000DBD")]
		[Address(RVA = "0xA5E64C", Offset = "0xA5E64C", VA = "0xA5E64C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x614E64", Offset = "0x614E64")]
		add
		{
		}
		[Token(Token = "0x6000DBE")]
		[Address(RVA = "0xA5E6EC", Offset = "0xA5E6EC", VA = "0xA5E6EC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x614E74", Offset = "0x614E74")]
		remove
		{
		}
	}

	[Token(Token = "0x6000DC1")]
	[Address(RVA = "0xA5E79C", Offset = "0xA5E79C", VA = "0xA5E79C", Slot = "8")]
	protected override void Initialize()
	{
	}

	[Token(Token = "0x6000DC2")]
	[Address(RVA = "0xA5E928", Offset = "0xA5E928", VA = "0xA5E928")]
	public void ShowSupport()
	{
	}

	[Token(Token = "0x6000DC3")]
	[Address(RVA = "0xA5E97C", Offset = "0xA5E97C", VA = "0xA5E97C")]
	public void LoginSDK()
	{
	}

	[Token(Token = "0x6000DC4")]
	[Address(RVA = "0xA5E9D0", Offset = "0xA5E9D0", VA = "0xA5E9D0")]
	public void QueryNotificationCount(bool async)
	{
	}

	[Token(Token = "0x6000DC5")]
	[Address(RVA = "0xA5EA98", Offset = "0xA5EA98", VA = "0xA5EA98")]
	public void didReceiveUnreadMessagesCount(string count)
	{
	}

	[Token(Token = "0x6000DC6")]
	[Address(RVA = "0xA5EB20", Offset = "0xA5EB20", VA = "0xA5EB20")]
	public void helpshiftSessionEnded()
	{
	}

	[Token(Token = "0x6000DC7")]
	[Address(RVA = "0xA5EB4C", Offset = "0xA5EB4C", VA = "0xA5EB4C")]
	public static Dictionary<string, object> GetMetadata()
	{
		return null;
	}

	[Token(Token = "0x6000DC8")]
	[Address(RVA = "0xA5F13C", Offset = "0xA5F13C", VA = "0xA5F13C")]
	public SniperHelpshift()
	{
	}
}
