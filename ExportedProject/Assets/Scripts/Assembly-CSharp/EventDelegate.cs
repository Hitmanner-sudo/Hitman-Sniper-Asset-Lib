using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Serializable]
[Token(Token = "0x2000050")]
public class EventDelegate
{
	[Token(Token = "0x2000051")]
	public delegate void Callback();

	[Token(Token = "0x40001B6")]
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	private MonoBehaviour mTarget;

	[Token(Token = "0x40001B7")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private string mMethodName;

	[Token(Token = "0x40001B8")]
	[FieldOffset(Offset = "0x20")]
	public bool oneShot;

	[Token(Token = "0x40001B9")]
	[FieldOffset(Offset = "0x28")]
	private Callback mCachedCallback;

	[Token(Token = "0x40001BA")]
	[FieldOffset(Offset = "0x30")]
	private bool mRawDelegate;

	[Token(Token = "0x40001BB")]
	[FieldOffset(Offset = "0x0")]
	private static int s_Hash;

	[Token(Token = "0x17000053")]
	public MonoBehaviour target
	{
		[Token(Token = "0x6000207")]
		[Address(RVA = "0xE1737C", Offset = "0xE1737C", VA = "0xE1737C")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000208")]
		[Address(RVA = "0xE17384", Offset = "0xE17384", VA = "0xE17384")]
		set
		{
		}
	}

	[Token(Token = "0x17000054")]
	public string methodName
	{
		[Token(Token = "0x6000209")]
		[Address(RVA = "0xE17394", Offset = "0xE17394", VA = "0xE17394")]
		get
		{
			return null;
		}
		[Token(Token = "0x600020A")]
		[Address(RVA = "0xE1739C", Offset = "0xE1739C", VA = "0xE1739C")]
		set
		{
		}
	}

	[Token(Token = "0x17000055")]
	public bool isValid
	{
		[Token(Token = "0x600020B")]
		[Address(RVA = "0xE173AC", Offset = "0xE173AC", VA = "0xE173AC")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000056")]
	public bool isEnabled
	{
		[Token(Token = "0x600020C")]
		[Address(RVA = "0xE17454", Offset = "0xE17454", VA = "0xE17454")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x600020D")]
	[Address(RVA = "0xE17500", Offset = "0xE17500", VA = "0xE17500")]
	public EventDelegate()
	{
	}

	[Token(Token = "0x600020E")]
	[Address(RVA = "0xE17508", Offset = "0xE17508", VA = "0xE17508")]
	public EventDelegate(Callback call)
	{
	}

	[Token(Token = "0x600020F")]
	[Address(RVA = "0xE17690", Offset = "0xE17690", VA = "0xE17690")]
	public EventDelegate(MonoBehaviour target, string methodName)
	{
	}

	[Token(Token = "0x6000210")]
	[Address(RVA = "0xE176E0", Offset = "0xE176E0", VA = "0xE176E0")]
	private static string GetMethodName(Callback callback)
	{
		return null;
	}

	[Token(Token = "0x6000211")]
	[Address(RVA = "0xE1770C", Offset = "0xE1770C", VA = "0xE1770C")]
	private static bool IsValid(Callback callback)
	{
		return default(bool);
	}

	[Token(Token = "0x6000212")]
	[Address(RVA = "0xE17734", Offset = "0xE17734", VA = "0xE17734", Slot = "0")]
	public override bool Equals(object obj)
	{
		return default(bool);
	}

	[Token(Token = "0x6000213")]
	[Address(RVA = "0xE1792C", Offset = "0xE1792C", VA = "0xE1792C", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6000214")]
	[Address(RVA = "0xE17990", Offset = "0xE17990", VA = "0xE17990")]
	private Callback Get()
	{
		return null;
	}

	[Token(Token = "0x6000215")]
	[Address(RVA = "0xE17538", Offset = "0xE17538", VA = "0xE17538")]
	private void Set(Callback call)
	{
	}

	[Token(Token = "0x6000216")]
	[Address(RVA = "0xE176D0", Offset = "0xE176D0", VA = "0xE176D0")]
	public void Set(MonoBehaviour target, string methodName)
	{
	}

	[Token(Token = "0x6000217")]
	[Address(RVA = "0xE17BA8", Offset = "0xE17BA8", VA = "0xE17BA8")]
	public bool Execute()
	{
		return default(bool);
	}

	[Token(Token = "0x6000218")]
	[Address(RVA = "0xE17BCC", Offset = "0xE17BCC", VA = "0xE17BCC")]
	public void Clear()
	{
	}

	[Token(Token = "0x6000219")]
	[Address(RVA = "0xE17BDC", Offset = "0xE17BDC", VA = "0xE17BDC", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x600021A")]
	[Address(RVA = "0xE17D34", Offset = "0xE17D34", VA = "0xE17D34")]
	public static void Execute(List<EventDelegate> list)
	{
	}

	[Token(Token = "0x600021B")]
	[Address(RVA = "0xE17E08", Offset = "0xE17E08", VA = "0xE17E08")]
	public static bool IsValid(List<EventDelegate> list)
	{
		return default(bool);
	}

	[Token(Token = "0x600021C")]
	[Address(RVA = "0xE17EB8", Offset = "0xE17EB8", VA = "0xE17EB8")]
	public static void Set(List<EventDelegate> list, Callback callback)
	{
	}

	[Token(Token = "0x600021D")]
	[Address(RVA = "0xE17F7C", Offset = "0xE17F7C", VA = "0xE17F7C")]
	public static void Add(List<EventDelegate> list, Callback callback)
	{
	}

	[Token(Token = "0x600021E")]
	[Address(RVA = "0xE17FF0", Offset = "0xE17FF0", VA = "0xE17FF0")]
	public static void Add(List<EventDelegate> list, Callback callback, bool oneShot)
	{
	}

	[Token(Token = "0x600021F")]
	[Address(RVA = "0xE18128", Offset = "0xE18128", VA = "0xE18128")]
	public static void Add(List<EventDelegate> list, EventDelegate ev)
	{
	}

	[Token(Token = "0x6000220")]
	[Address(RVA = "0xE1819C", Offset = "0xE1819C", VA = "0xE1819C")]
	public static void Add(List<EventDelegate> list, EventDelegate ev, bool oneShot)
	{
	}

	[Token(Token = "0x6000221")]
	[Address(RVA = "0xE182DC", Offset = "0xE182DC", VA = "0xE182DC")]
	public static bool Remove(List<EventDelegate> list, Callback callback)
	{
		return default(bool);
	}
}
