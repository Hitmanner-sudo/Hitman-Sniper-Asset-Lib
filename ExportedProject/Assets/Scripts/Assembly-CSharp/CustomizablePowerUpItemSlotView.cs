using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20006FF")]
public class CustomizablePowerUpItemSlotView : PowerUpItemSlotView
{
	[Token(Token = "0x40027B4")]
	[FieldOffset(Offset = "0xD8")]
	[SerializeField]
	private UISprite _emptySlotSprite;

	[Token(Token = "0x40027B5")]
	[FieldOffset(Offset = "0xE0")]
	[SerializeField]
	private string _emptySlotSpriteName;

	[Token(Token = "0x40027B6")]
	[FieldOffset(Offset = "0xE8")]
	[SerializeField]
	private string _lockedSlotSpriteName;

	[Token(Token = "0x40027B7")]
	[FieldOffset(Offset = "0xF0")]
	[SerializeField]
	private BlinkButtonHandler _button;

	[Token(Token = "0x40027B8")]
	[FieldOffset(Offset = "0xF8")]
	[SerializeField]
	private UITweener[] _arrowTweeners;

	[Token(Token = "0x40027B9")]
	[FieldOffset(Offset = "0x100")]
	[SerializeField]
	private UIWidget[] _arrowWidgets;

	[Token(Token = "0x40027BA")]
	[FieldOffset(Offset = "0x108")]
	[SerializeField]
	private ColorModel.ColorModelEnum _arrowUnlockedColor;

	[Token(Token = "0x40027BB")]
	[FieldOffset(Offset = "0x10C")]
	[SerializeField]
	private Color _arrowLockedColor;

	[Token(Token = "0x40027BC")]
	[FieldOffset(Offset = "0x120")]
	[SerializeField]
	private string _tooltipTitleKey;

	[Token(Token = "0x17000607")]
	protected override WeaponUnlockableSaveData.AttachmentSlot[] Attachments
	{
		[Token(Token = "0x6002E99")]
		[Address(RVA = "0xBBAC40", Offset = "0xBBAC40", VA = "0xBBAC40", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6002E9A")]
	[Address(RVA = "0xBBAC5C", Offset = "0xBBAC5C", VA = "0xBBAC5C", Slot = "9")]
	protected override void Start()
	{
	}

	[Token(Token = "0x6002E9B")]
	[Address(RVA = "0xBBAD18", Offset = "0xBBAD18", VA = "0xBBAD18", Slot = "11")]
	protected override void OnEnable()
	{
	}

	[Token(Token = "0x6002E9C")]
	[Address(RVA = "0xBBADCC", Offset = "0xBBADCC", VA = "0xBBADCC", Slot = "12")]
	protected override void OnDisable()
	{
	}

	[Token(Token = "0x6002E9D")]
	[Address(RVA = "0xBBAE80", Offset = "0xBBAE80", VA = "0xBBAE80", Slot = "30")]
	public override void UpdateIcons()
	{
	}

	[Token(Token = "0x6002E9E")]
	[Address(RVA = "0xBBB12C", Offset = "0xBBB12C", VA = "0xBBB12C", Slot = "23")]
	protected override void OnSelfPressed(object sender, ButtonHandler.PressButtonHandlerEventArgs args)
	{
	}

	[Token(Token = "0x6002E9F")]
	[Address(RVA = "0xBBB39C", Offset = "0xBBB39C", VA = "0xBBB39C")]
	private void OnBlinkButtonFinished(object sender, BlinkButtonHandler.ButtonBlinkFinishedHandlerEventArgs args)
	{
	}

	[Token(Token = "0x6002EA0")]
	[Address(RVA = "0xBBB4E4", Offset = "0xBBB4E4", VA = "0xBBB4E4")]
	public CustomizablePowerUpItemSlotView()
	{
	}
}
