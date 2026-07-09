using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20006FB")]
public class AbilitySlotView : SlotView
{
	[Token(Token = "0x400279C")]
	[FieldOffset(Offset = "0xA8")]
	[SerializeField]
	private UISprite _backgroundOutline;

	[Token(Token = "0x17000602")]
	protected override WeaponUnlockableSaveData.AttachmentSlot[] Attachments
	{
		[Token(Token = "0x6002E79")]
		[Address(RVA = "0xA9C50C", Offset = "0xA9C50C", VA = "0xA9C50C", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6002E7A")]
	[Address(RVA = "0xA9C5A0", Offset = "0xA9C5A0", VA = "0xA9C5A0", Slot = "17")]
	protected override AttachmentsUnlockable Load(int idx)
	{
		return null;
	}

	[Token(Token = "0x6002E7B")]
	[Address(RVA = "0xA9C630", Offset = "0xA9C630", VA = "0xA9C630", Slot = "18")]
	protected override void Unload(AttachmentsUnlockable attachment)
	{
	}

	[Token(Token = "0x6002E7C")]
	[Address(RVA = "0xA9C708", Offset = "0xA9C708", VA = "0xA9C708", Slot = "19")]
	protected override void SetBackgroundOutlineColor(Color color)
	{
	}

	[Token(Token = "0x6002E7D")]
	[Address(RVA = "0xA9C728", Offset = "0xA9C728", VA = "0xA9C728")]
	public AbilitySlotView()
	{
	}
}
