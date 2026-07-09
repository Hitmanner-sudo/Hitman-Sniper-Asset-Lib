using System;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000641")]
public class BaseLoadingView : View
{
	[Token(Token = "0x4002269")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	private LazyTexture _defaultIconTexture;

	[Token(Token = "0x400226A")]
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	private LazyTexture _zombieIconTexture;

	[Token(Token = "0x400226B")]
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	private LazyTexture _defaultBackgroundTexture;

	[Token(Token = "0x400226C")]
	[FieldOffset(Offset = "0x78")]
	[SerializeField]
	private LazyTexture _zombieBackgroundTexture;

	[Token(Token = "0x400226D")]
	[FieldOffset(Offset = "0x80")]
	[SerializeField]
	protected UITexture MainIcon;

	[Token(Token = "0x400226E")]
	[FieldOffset(Offset = "0x88")]
	[SerializeField]
	protected UITexture Background;

	[Token(Token = "0x14000093")]
	public static event EventHandler OnLoadingViewDisable
	{
		[Token(Token = "0x6002858")]
		[Address(RVA = "0xC0D2C8", Offset = "0xC0D2C8", VA = "0xC0D2C8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61D778", Offset = "0x61D778")]
		add
		{
		}
		[Token(Token = "0x6002859")]
		[Address(RVA = "0xC0D384", Offset = "0xC0D384", VA = "0xC0D384")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61D788", Offset = "0x61D788")]
		remove
		{
		}
	}

	[Token(Token = "0x14000094")]
	public static event EventHandler OnPostLoadingViewDisable
	{
		[Token(Token = "0x600285A")]
		[Address(RVA = "0xC0D440", Offset = "0xC0D440", VA = "0xC0D440")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61D798", Offset = "0x61D798")]
		add
		{
		}
		[Token(Token = "0x600285B")]
		[Address(RVA = "0xC0D500", Offset = "0xC0D500", VA = "0xC0D500")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61D7A8", Offset = "0x61D7A8")]
		remove
		{
		}
	}

	[Token(Token = "0x14000095")]
	public static event EventHandler OnLoadingViewEnable
	{
		[Token(Token = "0x600285C")]
		[Address(RVA = "0xC0D5C0", Offset = "0xC0D5C0", VA = "0xC0D5C0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61D7B8", Offset = "0x61D7B8")]
		add
		{
		}
		[Token(Token = "0x600285D")]
		[Address(RVA = "0xC0D680", Offset = "0xC0D680", VA = "0xC0D680")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61D7C8", Offset = "0x61D7C8")]
		remove
		{
		}
	}

	[Token(Token = "0x600285E")]
	[Address(RVA = "0xC0D740", Offset = "0xC0D740", VA = "0xC0D740", Slot = "11")]
	protected override void OnEnable()
	{
	}

	[Token(Token = "0x600285F")]
	[Address(RVA = "0xC0D81C", Offset = "0xC0D81C", VA = "0xC0D81C", Slot = "12")]
	protected override void OnDisable()
	{
	}

	[Token(Token = "0x6002860")]
	[Address(RVA = "0xC0D904", Offset = "0xC0D904", VA = "0xC0D904")]
	private static void OnViewChanged(object sender, EventArgs args)
	{
	}

	[Token(Token = "0x6002861")]
	[Address(RVA = "0xC0D968", Offset = "0xC0D968", VA = "0xC0D968", Slot = "10")]
	protected override void OnDestroy()
	{
	}

	[Token(Token = "0x6002862")]
	[Address(RVA = "0xC0DA90", Offset = "0xC0DA90", VA = "0xC0DA90", Slot = "15")]
	protected virtual void SetUpBackground()
	{
	}

	[Token(Token = "0x6002863")]
	[Address(RVA = "0xC0D9F8", Offset = "0xC0D9F8", VA = "0xC0D9F8")]
	private void UnloadTexture(UITexture texture)
	{
	}

	[Token(Token = "0x6002864")]
	[Address(RVA = "0xC0DD40", Offset = "0xC0DD40", VA = "0xC0DD40")]
	public BaseLoadingView()
	{
	}
}
