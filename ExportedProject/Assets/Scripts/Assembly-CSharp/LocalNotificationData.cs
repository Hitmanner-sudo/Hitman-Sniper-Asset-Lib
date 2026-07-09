using System;
using Il2CppDummyDll;
using UnityEngine;

[Serializable]
[Token(Token = "0x200024F")]
public abstract class LocalNotificationData
{
	[Token(Token = "0x4000CD2")]
	[FieldOffset(Offset = "0x10")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5B3708", Offset = "0x5B3708")]
	[SerializeField]
	private int _id;

	[Token(Token = "0x4000CD3")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	public string _androidTitle;

	[Token(Token = "0x4000CD4")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private string _action;

	[Token(Token = "0x1700023E")]
	public int Id
	{
		[Token(Token = "0x6000DEF")]
		[Address(RVA = "0x9D6318", Offset = "0x9D6318", VA = "0x9D6318")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x1700023F")]
	public string AndroidTitle
	{
		[Token(Token = "0x6000DF0")]
		[Address(RVA = "0x9D6320", Offset = "0x9D6320", VA = "0x9D6320")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000240")]
	public string Action
	{
		[Token(Token = "0x6000DF1")]
		[Address(RVA = "0x9D6328", Offset = "0x9D6328", VA = "0x9D6328")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000241")]
	public abstract string Body
	{
		[Token(Token = "0x6000DF2")]
		get;
	}

	[Token(Token = "0x6000DF3")]
	[Address(RVA = "0x9D6330", Offset = "0x9D6330", VA = "0x9D6330")]
	protected LocalNotificationData()
	{
	}
}
