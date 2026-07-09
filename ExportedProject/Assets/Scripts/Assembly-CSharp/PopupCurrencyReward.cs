using System;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000725")]
public class PopupCurrencyReward : PopupOverlayView
{
	[Token(Token = "0x400286B")]
	[FieldOffset(Offset = "0x100")]
	[SerializeField]
	private UILabel _amountLabel;

	[Token(Token = "0x17000625")]
	public UILabel AmountLabel
	{
		[Token(Token = "0x6002FAA")]
		[Address(RVA = "0x93091C", Offset = "0x93091C", VA = "0x93091C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6002FAB")]
	[Address(RVA = "0x930924", Offset = "0x930924", VA = "0x930924")]
	public void SetupPopupOverlay(string title, string message, Action okCallback, string okText, Action cancelCallback, int amount)
	{
	}

	[Token(Token = "0x6002FAC")]
	[Address(RVA = "0x930A68", Offset = "0x930A68", VA = "0x930A68")]
	public PopupCurrencyReward()
	{
	}
}
