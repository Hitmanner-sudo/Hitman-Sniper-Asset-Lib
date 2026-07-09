using System;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20006AA")]
public class PopupRankUpLootBox : PopupOverlayViewBase
{
	[Token(Token = "0x4002524")]
	[FieldOffset(Offset = "0xC0")]
	[SerializeField]
	private string _titleLoc;

	[Token(Token = "0x4002525")]
	[FieldOffset(Offset = "0xC8")]
	[SerializeField]
	private GameObject _rewardHolder;

	[Token(Token = "0x4002526")]
	[FieldOffset(Offset = "0xD0")]
	private LootBox _lootBox;

	[Token(Token = "0x4002527")]
	[FieldOffset(Offset = "0xD8")]
	private Action _onCompleted;

	[Token(Token = "0x6002BA7")]
	[Address(RVA = "0x93A748", Offset = "0x93A748", VA = "0x93A748")]
	public void SetupPopupOverlay(LootBox lootBox, Action onCompleted)
	{
	}

	[Token(Token = "0x6002BA8")]
	[Address(RVA = "0x93AAD4", Offset = "0x93AAD4", VA = "0x93AAD4")]
	public void Show()
	{
	}

	[Token(Token = "0x6002BA9")]
	[Address(RVA = "0x93AAFC", Offset = "0x93AAFC", VA = "0x93AAFC", Slot = "21")]
	protected virtual string GetDescriptionLocalization()
	{
		return null;
	}

	[Token(Token = "0x6002BAA")]
	[Address(RVA = "0x93AB48", Offset = "0x93AB48", VA = "0x93AB48")]
	private void OnOkClicked()
	{
	}

	[Token(Token = "0x6002BAB")]
	[Address(RVA = "0x937558", Offset = "0x937558", VA = "0x937558")]
	public PopupRankUpLootBox()
	{
	}
}
