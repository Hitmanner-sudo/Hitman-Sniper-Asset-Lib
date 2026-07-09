using System;
using Il2CppDummyDll;
using Technology.Ads;
using UnityEngine;

[Token(Token = "0x200051F")]
public class InsufficientFundsWatchAdItemController : UIController
{
	[Token(Token = "0x4001B08")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	private BlinkButtonHandler _button;

	[Token(Token = "0x4001B09")]
	[FieldOffset(Offset = "0x68")]
	private Ad _ad;

	[Token(Token = "0x170004D3")]
	public bool IsButtonColliderEnabled
	{
		[Token(Token = "0x6001FA7")]
		[Address(RVA = "0xB14EC0", Offset = "0xB14EC0", VA = "0xB14EC0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x14000084")]
	public event Action<bool> AdClosed
	{
		[Token(Token = "0x6001FA3")]
		[Address(RVA = "0xB14C40", Offset = "0xB14C40", VA = "0xB14C40")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x619238", Offset = "0x619238")]
		add
		{
		}
		[Token(Token = "0x6001FA4")]
		[Address(RVA = "0xB14CE0", Offset = "0xB14CE0", VA = "0xB14CE0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x619248", Offset = "0x619248")]
		remove
		{
		}
	}

	[Token(Token = "0x14000085")]
	public event Action<string> AdFailedToOpen
	{
		[Token(Token = "0x6001FA5")]
		[Address(RVA = "0xB14D80", Offset = "0xB14D80", VA = "0xB14D80")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x619258", Offset = "0x619258")]
		add
		{
		}
		[Token(Token = "0x6001FA6")]
		[Address(RVA = "0xB14E20", Offset = "0xB14E20", VA = "0xB14E20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x619268", Offset = "0x619268")]
		remove
		{
		}
	}

	[Token(Token = "0x6001FA8")]
	[Address(RVA = "0xB14ECC", Offset = "0xB14ECC", VA = "0xB14ECC", Slot = "11")]
	protected override void OnEnable()
	{
	}

	[Token(Token = "0x6001FA9")]
	[Address(RVA = "0xB14F78", Offset = "0xB14F78", VA = "0xB14F78", Slot = "12")]
	protected override void OnDisable()
	{
	}

	[Token(Token = "0x6001FAA")]
	[Address(RVA = "0xB15024", Offset = "0xB15024", VA = "0xB15024")]
	private void OnButtonPressed(object sender, BlinkButtonHandler.ButtonBlinkFinishedHandlerEventArgs e)
	{
	}

	[Token(Token = "0x6001FAB")]
	[Address(RVA = "0xB1518C", Offset = "0xB1518C", VA = "0xB1518C")]
	private void OnAdClosed(bool success)
	{
	}

	[Token(Token = "0x6001FAC")]
	[Address(RVA = "0xB15450", Offset = "0xB15450", VA = "0xB15450")]
	private void OnAdFailedToOpen(string error)
	{
	}

	[Token(Token = "0x6001FAD")]
	[Address(RVA = "0xB15320", Offset = "0xB15320", VA = "0xB15320")]
	private void CleanupAfterAd()
	{
	}

	[Token(Token = "0x6001FAE")]
	[Address(RVA = "0xB154B4", Offset = "0xB154B4", VA = "0xB154B4")]
	public InsufficientFundsWatchAdItemController()
	{
	}
}
