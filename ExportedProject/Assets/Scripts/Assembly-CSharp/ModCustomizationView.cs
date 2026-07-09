using Il2CppDummyDll;

[Token(Token = "0x2000704")]
public class ModCustomizationView : WeaponCustomizationView
{
	[Token(Token = "0x17000608")]
	protected override WeaponUnlockableSaveData.AttachmentSlot[] AttachmentList
	{
		[Token(Token = "0x6002EAD")]
		[Address(RVA = "0xA1D940", Offset = "0xA1D940", VA = "0xA1D940", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6002EAE")]
	[Address(RVA = "0xA1D95C", Offset = "0xA1D95C", VA = "0xA1D95C", Slot = "16")]
	protected override int GetNumAttachmentsForUpgrade(WeaponXPUpgrade upgrade)
	{
		return default(int);
	}

	[Token(Token = "0x6002EAF")]
	[Address(RVA = "0xA1D980", Offset = "0xA1D980", VA = "0xA1D980", Slot = "17")]
	protected override bool IsAttachmentCustomizable(WeaponXPUpgrade upgrade, int idx)
	{
		return default(bool);
	}

	[Token(Token = "0x6002EB0")]
	[Address(RVA = "0xA1DA14", Offset = "0xA1DA14", VA = "0xA1DA14", Slot = "18")]
	protected override int GetNumAvailableAttachments()
	{
		return default(int);
	}

	[Token(Token = "0x6002EB1")]
	[Address(RVA = "0xA1DA3C", Offset = "0xA1DA3C", VA = "0xA1DA3C", Slot = "19")]
	protected override int GetNumRestrictedAttachments()
	{
		return default(int);
	}

	[Token(Token = "0x6002EB2")]
	[Address(RVA = "0xA1DA64", Offset = "0xA1DA64", VA = "0xA1DA64", Slot = "20")]
	protected override string GetAvailableAttachmentPath(int idx)
	{
		return null;
	}

	[Token(Token = "0x6002EB3")]
	[Address(RVA = "0xA1DAB4", Offset = "0xA1DAB4", VA = "0xA1DAB4", Slot = "21")]
	protected override string GetRestrictedAttachmentPath(int idx)
	{
		return null;
	}

	[Token(Token = "0x6002EB4")]
	[Address(RVA = "0xA1DB0C", Offset = "0xA1DB0C", VA = "0xA1DB0C", Slot = "22")]
	protected override string GetRestrictedAttachmentWeaponName(int idx)
	{
		return null;
	}

	[Token(Token = "0x6002EB5")]
	[Address(RVA = "0xA1DC3C", Offset = "0xA1DC3C", VA = "0xA1DC3C", Slot = "23")]
	protected override bool IsRestrictedAttachmentUnlocked(int idx)
	{
		return default(bool);
	}

	[Token(Token = "0x6002EB6")]
	[Address(RVA = "0xA1DD78", Offset = "0xA1DD78", VA = "0xA1DD78")]
	public ModCustomizationView()
	{
	}
}
