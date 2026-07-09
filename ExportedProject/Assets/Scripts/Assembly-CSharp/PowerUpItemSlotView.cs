using System;
using Il2CppDummyDll;

[Token(Token = "0x2000743")]
public class PowerUpItemSlotView : AttachmentSlotView
{
	[Token(Token = "0x4002918")]
	[FieldOffset(Offset = "0xD0")]
	public UISprite PowerUpOutline;

	[Token(Token = "0x17000635")]
	protected override WeaponUnlockableSaveData.AttachmentSlot[] Attachments
	{
		[Token(Token = "0x6003066")]
		[Address(RVA = "0x943624", Offset = "0x943624", VA = "0x943624", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000636")]
	protected override Func<int, AttachmentsUnlockable> LoadFunction
	{
		[Token(Token = "0x6003067")]
		[Address(RVA = "0x943640", Offset = "0x943640", VA = "0x943640", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000637")]
	protected override SniperAnalytics.TooltipClickType TooltipClickType
	{
		[Token(Token = "0x6003068")]
		[Address(RVA = "0x94371C", Offset = "0x94371C", VA = "0x94371C", Slot = "17")]
		get
		{
			return default(SniperAnalytics.TooltipClickType);
		}
	}

	[Token(Token = "0x6003069")]
	[Address(RVA = "0x943724", Offset = "0x943724", VA = "0x943724", Slot = "26")]
	public override bool AttachmentsOverlap(AttachmentsUnlockable other)
	{
		return default(bool);
	}

	[Token(Token = "0x600306A")]
	[Address(RVA = "0x943898", Offset = "0x943898", VA = "0x943898", Slot = "30")]
	public override void UpdateIcons()
	{
	}

	[Token(Token = "0x600306B")]
	[Address(RVA = "0x9439FC", Offset = "0x9439FC", VA = "0x9439FC", Slot = "28")]
	protected override int GetLevelUnlocked()
	{
		return default(int);
	}

	[Token(Token = "0x600306C")]
	[Address(RVA = "0x943B4C", Offset = "0x943B4C", VA = "0x943B4C")]
	public PowerUpItemSlotView()
	{
	}
}
