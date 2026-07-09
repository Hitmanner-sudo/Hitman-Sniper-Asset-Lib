using Il2CppDummyDll;

[Token(Token = "0x2000700")]
public class ModCollectionItemView : CollectionItemView
{
	[Token(Token = "0x2000701")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x595D88", Offset = "0x595D88")]
	private sealed class _003C_003Ec__DisplayClass0_0
	{
		[Token(Token = "0x40027BD")]
		[FieldOffset(Offset = "0x10")]
		public string path;

		[Token(Token = "0x6002EA7")]
		[Address(RVA = "0x8C7FAC", Offset = "0x8C7FAC", VA = "0x8C7FAC")]
		public _003C_003Ec__DisplayClass0_0()
		{
		}

		[Token(Token = "0x6002EA8")]
		[Address(RVA = "0x8C7FB4", Offset = "0x8C7FB4", VA = "0x8C7FB4")]
		internal bool _003CLoad_003Eb__0(LazyWeaponMod p)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2000702")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x595D98", Offset = "0x595D98")]
	private sealed class _003C_003Ec__DisplayClass4_0
	{
		[Token(Token = "0x40027BE")]
		[FieldOffset(Offset = "0x10")]
		public Attachment[] secondAttachments;

		[Token(Token = "0x6002EA9")]
		[Address(RVA = "0x8C7FF4", Offset = "0x8C7FF4", VA = "0x8C7FF4")]
		public _003C_003Ec__DisplayClass4_0()
		{
		}

		[Token(Token = "0x6002EAA")]
		[Address(RVA = "0x8C7FFC", Offset = "0x8C7FFC", VA = "0x8C7FFC")]
		internal bool _003CDoModsOverlap_003Eb__0(Attachment a)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2000703")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x595DA8", Offset = "0x595DA8")]
	private sealed class _003C_003Ec__DisplayClass4_1
	{
		[Token(Token = "0x40027BF")]
		[FieldOffset(Offset = "0x10")]
		public Attachment a;

		[Token(Token = "0x6002EAB")]
		[Address(RVA = "0x8C80E8", Offset = "0x8C80E8", VA = "0x8C80E8")]
		public _003C_003Ec__DisplayClass4_1()
		{
		}

		[Token(Token = "0x6002EAC")]
		[Address(RVA = "0x8C80F0", Offset = "0x8C80F0", VA = "0x8C80F0")]
		internal bool _003CDoModsOverlap_003Eb__1(Attachment b)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6002EA1")]
	[Address(RVA = "0xA1D1A4", Offset = "0xA1D1A4", VA = "0xA1D1A4", Slot = "15")]
	protected override AttachmentsUnlockable Load(string path, out int attachmentIdx)
	{
		return null;
	}

	[Token(Token = "0x6002EA2")]
	[Address(RVA = "0xA1D310", Offset = "0xA1D310", VA = "0xA1D310", Slot = "16")]
	protected override void Unload(AttachmentsUnlockable attachment)
	{
	}

	[Token(Token = "0x6002EA3")]
	[Address(RVA = "0xA1D42C", Offset = "0xA1D42C", VA = "0xA1D42C", Slot = "17")]
	protected override void SlotNewAttachment(SelectedSlot slot)
	{
	}

	[Token(Token = "0x6002EA4")]
	[Address(RVA = "0xA1D504", Offset = "0xA1D504", VA = "0xA1D504", Slot = "18")]
	protected override bool IsCurrentlySlotted()
	{
		return default(bool);
	}

	[Token(Token = "0x6002EA5")]
	[Address(RVA = "0xA1D70C", Offset = "0xA1D70C", VA = "0xA1D70C")]
	private bool DoModsOverlap(WeaponMod first, WeaponMod second)
	{
		return default(bool);
	}

	[Token(Token = "0x6002EA6")]
	[Address(RVA = "0xA1D938", Offset = "0xA1D938", VA = "0xA1D938")]
	public ModCollectionItemView()
	{
	}
}
