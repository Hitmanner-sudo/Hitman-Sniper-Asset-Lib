using System;
using Il2CppDummyDll;
using Technology.Shop;
using UnityEngine;

[Token(Token = "0x2000515")]
public class CurrencyItemController : UIController
{
	[Token(Token = "0x4001AE3")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	private BlinkButtonHandler _backgroundBlinkButtonHandler;

	[Token(Token = "0x170004CD")]
	public bool IsButtonColliderEnabled
	{
		[Token(Token = "0x6001F48")]
		[Address(RVA = "0xD88790", Offset = "0xD88790", VA = "0xD88790")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x14000081")]
	public event Action<bool> OnPurchaseComplete
	{
		[Token(Token = "0x6001F46")]
		[Address(RVA = "0xD88650", Offset = "0xD88650", VA = "0xD88650")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x619048", Offset = "0x619048")]
		add
		{
		}
		[Token(Token = "0x6001F47")]
		[Address(RVA = "0xD886F0", Offset = "0xD886F0", VA = "0xD886F0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x619058", Offset = "0x619058")]
		remove
		{
		}
	}

	[Token(Token = "0x6001F49")]
	[Address(RVA = "0xD8879C", Offset = "0xD8879C", VA = "0xD8879C", Slot = "11")]
	protected override void OnEnable()
	{
	}

	[Token(Token = "0x6001F4A")]
	[Address(RVA = "0xD888D8", Offset = "0xD888D8", VA = "0xD888D8", Slot = "12")]
	protected override void OnDisable()
	{
	}

	[Token(Token = "0x6001F4B")]
	[Address(RVA = "0xD889D0", Offset = "0xD889D0", VA = "0xD889D0")]
	private void OnBackgroundButtonPressed(object sender, BlinkButtonHandler.ButtonBlinkFinishedHandlerEventArgs args)
	{
	}

	[Token(Token = "0x6001F4C")]
	[Address(RVA = "0xD88B08", Offset = "0xD88B08", VA = "0xD88B08")]
	private void RegisterShopEvents()
	{
	}

	[Token(Token = "0x6001F4D")]
	[Address(RVA = "0xD88C14", Offset = "0xD88C14", VA = "0xD88C14")]
	private void UnregisterShopEvents()
	{
	}

	[Token(Token = "0x6001F4E")]
	[Address(RVA = "0xD88D18", Offset = "0xD88D18", VA = "0xD88D18")]
	private void OnPurchaseSuccess(object sender, ShopEvent args)
	{
	}

	[Token(Token = "0x6001F4F")]
	[Address(RVA = "0xD88F44", Offset = "0xD88F44", VA = "0xD88F44")]
	private void OnPurchaseFailure(object sender, ShopEvent args)
	{
	}

	[Token(Token = "0x6001F50")]
	[Address(RVA = "0xD88E70", Offset = "0xD88E70", VA = "0xD88E70")]
	private void OnPurchase()
	{
	}

	[Token(Token = "0x6001F51")]
	[Address(RVA = "0xD890A0", Offset = "0xD890A0", VA = "0xD890A0")]
	public CurrencyItemController()
	{
	}
}
