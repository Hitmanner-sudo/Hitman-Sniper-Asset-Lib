using Il2CppDummyDll;

[Token(Token = "0x20003AF")]
public class WeaponPart : Unlockable
{
	[Token(Token = "0x40014FF")]
	[FieldOffset(Offset = "0x58")]
	public string AttachmentUITransformName;

	[Token(Token = "0x4001500")]
	[FieldOffset(Offset = "0x60")]
	public string ShortNameLocalizationKey;

	[Token(Token = "0x170003AE")]
	public string ShortName
	{
		[Token(Token = "0x60016D9")]
		[Address(RVA = "0x98BC38", Offset = "0x98BC38", VA = "0x98BC38")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170003AF")]
	public new AttachmentsUnlockableSaveData UnlockableData
	{
		[Token(Token = "0x60016DA")]
		[Address(RVA = "0x98BCA0", Offset = "0x98BCA0", VA = "0x98BCA0")]
		get
		{
			return null;
		}
		[Token(Token = "0x60016DB")]
		[Address(RVA = "0x98BD1C", Offset = "0x98BD1C", VA = "0x98BD1C")]
		set
		{
		}
	}

	[Token(Token = "0x170003B0")]
	public override bool Unlocked
	{
		[Token(Token = "0x60016DC")]
		[Address(RVA = "0x98BD24", Offset = "0x98BD24", VA = "0x98BD24", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x60016DD")]
	[Address(RVA = "0x98BEC8", Offset = "0x98BEC8", VA = "0x98BEC8", Slot = "7")]
	public override void Unlock(bool showNewFeedback = true)
	{
	}

	[Token(Token = "0x60016DE")]
	[Address(RVA = "0x98C03C", Offset = "0x98C03C", VA = "0x98C03C")]
	public WeaponPart()
	{
	}
}
