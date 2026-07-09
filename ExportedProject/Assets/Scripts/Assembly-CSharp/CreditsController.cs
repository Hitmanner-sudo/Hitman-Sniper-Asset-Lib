using System;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000514")]
public class CreditsController : UIController
{
	[Token(Token = "0x4001AE0")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private BlinkButtonHandler _closeButton;

	[Token(Token = "0x4001AE1")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	private ButtonHandler _backgroundButton;

	[Token(Token = "0x6001F42")]
	[Address(RVA = "0xD838F8", Offset = "0xD838F8", VA = "0xD838F8", Slot = "11")]
	protected override void OnEnable()
	{
	}

	[Token(Token = "0x6001F43")]
	[Address(RVA = "0xD83A08", Offset = "0xD83A08", VA = "0xD83A08", Slot = "12")]
	protected override void OnDisable()
	{
	}

	[Token(Token = "0x6001F44")]
	[Address(RVA = "0xD83B18", Offset = "0xD83B18", VA = "0xD83B18")]
	private void OnCloseClicked(object sender, EventArgs e)
	{
	}

	[Token(Token = "0x6001F45")]
	[Address(RVA = "0xD83B8C", Offset = "0xD83B8C", VA = "0xD83B8C")]
	public CreditsController()
	{
	}
}
