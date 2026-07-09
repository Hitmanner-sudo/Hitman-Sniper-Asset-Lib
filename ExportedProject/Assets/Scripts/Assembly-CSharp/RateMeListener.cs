using System;
using Il2CppDummyDll;
using Technology;
using UnityEngine;

[Token(Token = "0x200091C")]
public class RateMeListener : MonoBehaviour
{
	[Token(Token = "0x17000750")]
	private static RateMeConfiguration Config
	{
		[Token(Token = "0x6003A19")]
		[Address(RVA = "0xB3FD90", Offset = "0xB3FD90", VA = "0xB3FD90")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x140000B3")]
	public static event Action OnRemindMeClickedEvent
	{
		[Token(Token = "0x6003A13")]
		[Address(RVA = "0xB3F918", Offset = "0xB3F918", VA = "0xB3F918")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6248B0", Offset = "0x6248B0")]
		add
		{
		}
		[Token(Token = "0x6003A14")]
		[Address(RVA = "0xB3F9D4", Offset = "0xB3F9D4", VA = "0xB3F9D4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6248C0", Offset = "0x6248C0")]
		remove
		{
		}
	}

	[Token(Token = "0x140000B4")]
	public static event Action OnRateClickedEvent
	{
		[Token(Token = "0x6003A15")]
		[Address(RVA = "0xB3FA90", Offset = "0xB3FA90", VA = "0xB3FA90")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6248D0", Offset = "0x6248D0")]
		add
		{
		}
		[Token(Token = "0x6003A16")]
		[Address(RVA = "0xB3FB50", Offset = "0xB3FB50", VA = "0xB3FB50")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6248E0", Offset = "0x6248E0")]
		remove
		{
		}
	}

	[Token(Token = "0x140000B5")]
	public static event Action OnCancelClickedEvent
	{
		[Token(Token = "0x6003A17")]
		[Address(RVA = "0xB3FC10", Offset = "0xB3FC10", VA = "0xB3FC10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6248F0", Offset = "0x6248F0")]
		add
		{
		}
		[Token(Token = "0x6003A18")]
		[Address(RVA = "0xB3FCD0", Offset = "0xB3FCD0", VA = "0xB3FCD0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x624900", Offset = "0x624900")]
		remove
		{
		}
	}

	[Token(Token = "0x6003A1A")]
	[Address(RVA = "0xB3FE1C", Offset = "0xB3FE1C", VA = "0xB3FE1C")]
	protected void Start()
	{
	}

	[Token(Token = "0x6003A1B")]
	[Address(RVA = "0xB3FF20", Offset = "0xB3FF20", VA = "0xB3FF20")]
	protected void OnDestroy()
	{
	}

	[Token(Token = "0x6003A1C")]
	[Address(RVA = "0xB3FF98", Offset = "0xB3FF98", VA = "0xB3FF98")]
	private static void OnAnimationsCompleted(object sender, EventArgs args)
	{
	}

	[Token(Token = "0x6003A1D")]
	[Address(RVA = "0xB40180", Offset = "0xB40180", VA = "0xB40180")]
	protected void OnRemindMeClicked(string dummy)
	{
	}

	[Token(Token = "0x6003A1E")]
	[Address(RVA = "0xB40218", Offset = "0xB40218", VA = "0xB40218")]
	protected void OnRateClicked(string dummy)
	{
	}

	[Token(Token = "0x6003A1F")]
	[Address(RVA = "0xB4029C", Offset = "0xB4029C", VA = "0xB4029C")]
	protected void OnCancelClicked(string dummy)
	{
	}

	[Token(Token = "0x6003A20")]
	[Address(RVA = "0xB40320", Offset = "0xB40320", VA = "0xB40320")]
	public RateMeListener()
	{
	}
}
