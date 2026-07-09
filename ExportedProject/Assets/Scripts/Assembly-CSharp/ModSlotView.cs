using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000705")]
public class ModSlotView : SlotView
{
	[Token(Token = "0x40027C0")]
	[FieldOffset(Offset = "0xA8")]
	[SerializeField]
	private GameObject _backgroundBordersParent;

	[Token(Token = "0x40027C1")]
	[FieldOffset(Offset = "0xB0")]
	[SerializeField]
	private UISprite[] _backgroundBorders;

	[Token(Token = "0x17000609")]
	protected override WeaponUnlockableSaveData.AttachmentSlot[] Attachments
	{
		[Token(Token = "0x6002EB8")]
		[Address(RVA = "0xA1EBAC", Offset = "0xA1EBAC", VA = "0xA1EBAC", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6002EB7")]
	[Address(RVA = "0xA1EB14", Offset = "0xA1EB14", VA = "0xA1EB14", Slot = "15")]
	public override void UpdateIcon()
	{
	}

	[Token(Token = "0x6002EB9")]
	[Address(RVA = "0xA1EC40", Offset = "0xA1EC40", VA = "0xA1EC40", Slot = "17")]
	protected override AttachmentsUnlockable Load(int idx)
	{
		return null;
	}

	[Token(Token = "0x6002EBA")]
	[Address(RVA = "0xA1ECD0", Offset = "0xA1ECD0", VA = "0xA1ECD0", Slot = "18")]
	protected override void Unload(AttachmentsUnlockable attachment)
	{
	}

	[Token(Token = "0x6002EBB")]
	[Address(RVA = "0xA1EDA8", Offset = "0xA1EDA8", VA = "0xA1EDA8", Slot = "19")]
	protected override void SetBackgroundOutlineColor(Color color)
	{
	}

	[Token(Token = "0x6002EBC")]
	[Address(RVA = "0xA1EE48", Offset = "0xA1EE48", VA = "0xA1EE48")]
	public ModSlotView()
	{
	}
}
