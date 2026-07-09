using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000779")]
public class WeaponSuggestionPopupView : PopupOverlayViewBase
{
	[Token(Token = "0x4002A4F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	[SerializeField]
	private UILocalize _subtitleLocalize;

	[Token(Token = "0x4002A50")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	[SerializeField]
	private string _singleRifleSubtitleLocalizationKey;

	[Token(Token = "0x4002A51")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	[SerializeField]
	private string _multiRifleSubtitleLocalizationKey;

	[Token(Token = "0x4002A52")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	[SerializeField]
	private UIAlignedList _itemsList;

	[Token(Token = "0x4002A53")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	[SerializeField]
	private WeaponSuggestionItemView _itemTemplate;

	[Token(Token = "0x4002A54")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	[SerializeField]
	private int _itemOffset;

	[Token(Token = "0x4002A55")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	private Action _onClose;

	[Token(Token = "0x60031BD")]
	[Address(RVA = "0x98F608", Offset = "0x98F608", VA = "0x98F608")]
	public void SetupPopupOverlay(WeaponUnlockable[] weapons, [Optional] Action onClose)
	{
	}

	[Token(Token = "0x60031BE")]
	[Address(RVA = "0x98FAE0", Offset = "0x98FAE0", VA = "0x98FAE0", Slot = "10")]
	protected override void OnDestroy()
	{
	}

	[Token(Token = "0x60031BF")]
	[Address(RVA = "0x98FB6C", Offset = "0x98FB6C", VA = "0x98FB6C")]
	public WeaponSuggestionPopupView()
	{
	}
}
