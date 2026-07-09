using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20006FE")]
public class CustomizableModItemSlotView : ModItemSlotView
{
	[Token(Token = "0x40027AE")]
	[FieldOffset(Offset = "0xD0")]
	[SerializeField]
	private UISprite _emptySlotSprite;

	[Token(Token = "0x40027AF")]
	[FieldOffset(Offset = "0xD8")]
	[SerializeField]
	private string _emptySlotSpriteName;

	[Token(Token = "0x40027B0")]
	[FieldOffset(Offset = "0xE0")]
	[SerializeField]
	private string _lockedSlotSpriteName;

	[Token(Token = "0x40027B1")]
	[FieldOffset(Offset = "0xE8")]
	[SerializeField]
	private GameObject _backgroundOutline;

	[Token(Token = "0x40027B2")]
	[FieldOffset(Offset = "0xF0")]
	[SerializeField]
	private BlinkButtonHandler _button;

	[Token(Token = "0x40027B3")]
	[FieldOffset(Offset = "0xF8")]
	[SerializeField]
	private string _tooltipTitleKey;

	[Token(Token = "0x17000606")]
	protected override WeaponUnlockableSaveData.AttachmentSlot[] Attachments
	{
		[Token(Token = "0x6002E91")]
		[Address(RVA = "0xBBA470", Offset = "0xBBA470", VA = "0xBBA470", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6002E92")]
	[Address(RVA = "0xBBA48C", Offset = "0xBBA48C", VA = "0xBBA48C", Slot = "9")]
	protected override void Start()
	{
	}

	[Token(Token = "0x6002E93")]
	[Address(RVA = "0xBBA548", Offset = "0xBBA548", VA = "0xBBA548", Slot = "11")]
	protected override void OnEnable()
	{
	}

	[Token(Token = "0x6002E94")]
	[Address(RVA = "0xBBA5FC", Offset = "0xBBA5FC", VA = "0xBBA5FC", Slot = "12")]
	protected override void OnDisable()
	{
	}

	[Token(Token = "0x6002E95")]
	[Address(RVA = "0xBBA6B0", Offset = "0xBBA6B0", VA = "0xBBA6B0", Slot = "30")]
	public override void UpdateIcons()
	{
	}

	[Token(Token = "0x6002E96")]
	[Address(RVA = "0xBBA834", Offset = "0xBBA834", VA = "0xBBA834", Slot = "23")]
	protected override void OnSelfPressed(object sender, ButtonHandler.PressButtonHandlerEventArgs args)
	{
	}

	[Token(Token = "0x6002E97")]
	[Address(RVA = "0xBBAAA4", Offset = "0xBBAAA4", VA = "0xBBAAA4")]
	private void OnBlinkButtonFinished(object sender, BlinkButtonHandler.ButtonBlinkFinishedHandlerEventArgs args)
	{
	}

	[Token(Token = "0x6002E98")]
	[Address(RVA = "0xBBABEC", Offset = "0xBBABEC", VA = "0xBBABEC")]
	public CustomizableModItemSlotView()
	{
	}
}
