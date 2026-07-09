using System;
using Il2CppDummyDll;

[Token(Token = "0x2000714")]
public class ModItemSlotView : AttachmentSlotView
{
	[Token(Token = "0x2000715")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x595E18", Offset = "0x595E18")]
	private sealed class _003C_003Ec__DisplayClass6_0
	{
		[Token(Token = "0x400280B")]
		[FieldOffset(Offset = "0x10")]
		public WeaponMod otherMod;

		[Token(Token = "0x6002F24")]
		[Address(RVA = "0x8C80FC", Offset = "0x8C80FC", VA = "0x8C80FC")]
		public _003C_003Ec__DisplayClass6_0()
		{
		}

		[Token(Token = "0x6002F25")]
		[Address(RVA = "0x8C8104", Offset = "0x8C8104", VA = "0x8C8104")]
		internal bool _003CAttachmentsOverlap_003Eb__0(Attachment attach)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2000716")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x595E28", Offset = "0x595E28")]
	private sealed class _003C_003Ec__DisplayClass6_1
	{
		[Token(Token = "0x400280C")]
		[FieldOffset(Offset = "0x10")]
		public Attachment attach;

		[Token(Token = "0x6002F26")]
		[Address(RVA = "0x8C820C", Offset = "0x8C820C", VA = "0x8C820C")]
		public _003C_003Ec__DisplayClass6_1()
		{
		}

		[Token(Token = "0x6002F27")]
		[Address(RVA = "0x8C8214", Offset = "0x8C8214", VA = "0x8C8214")]
		internal bool _003CAttachmentsOverlap_003Eb__1(Attachment a)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000618")]
	protected override WeaponUnlockableSaveData.AttachmentSlot[] Attachments
	{
		[Token(Token = "0x6002F1E")]
		[Address(RVA = "0xA1E624", Offset = "0xA1E624", VA = "0xA1E624", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000619")]
	protected override Func<int, AttachmentsUnlockable> LoadFunction
	{
		[Token(Token = "0x6002F1F")]
		[Address(RVA = "0xA1E640", Offset = "0xA1E640", VA = "0xA1E640", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700061A")]
	protected override SniperAnalytics.TooltipClickType TooltipClickType
	{
		[Token(Token = "0x6002F20")]
		[Address(RVA = "0xA1E71C", Offset = "0xA1E71C", VA = "0xA1E71C", Slot = "17")]
		get
		{
			return default(SniperAnalytics.TooltipClickType);
		}
	}

	[Token(Token = "0x6002F21")]
	[Address(RVA = "0xA1E724", Offset = "0xA1E724", VA = "0xA1E724", Slot = "26")]
	public override bool AttachmentsOverlap(AttachmentsUnlockable other)
	{
		return default(bool);
	}

	[Token(Token = "0x6002F22")]
	[Address(RVA = "0xA1E960", Offset = "0xA1E960", VA = "0xA1E960", Slot = "28")]
	protected override int GetLevelUnlocked()
	{
		return default(int);
	}

	[Token(Token = "0x6002F23")]
	[Address(RVA = "0xA1EAB0", Offset = "0xA1EAB0", VA = "0xA1EAB0")]
	public ModItemSlotView()
	{
	}
}
