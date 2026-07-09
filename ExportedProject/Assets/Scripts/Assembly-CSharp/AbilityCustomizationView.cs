using Il2CppDummyDll;

[Token(Token = "0x20006FA")]
public class AbilityCustomizationView : WeaponCustomizationView
{
	[Token(Token = "0x17000601")]
	protected override WeaponUnlockableSaveData.AttachmentSlot[] AttachmentList
	{
		[Token(Token = "0x6002E6F")]
		[Address(RVA = "0xA9C0CC", Offset = "0xA9C0CC", VA = "0xA9C0CC", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6002E70")]
	[Address(RVA = "0xA9C0E8", Offset = "0xA9C0E8", VA = "0xA9C0E8", Slot = "16")]
	protected override int GetNumAttachmentsForUpgrade(WeaponXPUpgrade upgrade)
	{
		return default(int);
	}

	[Token(Token = "0x6002E71")]
	[Address(RVA = "0xA9C10C", Offset = "0xA9C10C", VA = "0xA9C10C", Slot = "17")]
	protected override bool IsAttachmentCustomizable(WeaponXPUpgrade upgrade, int idx)
	{
		return default(bool);
	}

	[Token(Token = "0x6002E72")]
	[Address(RVA = "0xA9C1A0", Offset = "0xA9C1A0", VA = "0xA9C1A0", Slot = "18")]
	protected override int GetNumAvailableAttachments()
	{
		return default(int);
	}

	[Token(Token = "0x6002E73")]
	[Address(RVA = "0xA9C1C8", Offset = "0xA9C1C8", VA = "0xA9C1C8", Slot = "19")]
	protected override int GetNumRestrictedAttachments()
	{
		return default(int);
	}

	[Token(Token = "0x6002E74")]
	[Address(RVA = "0xA9C1F0", Offset = "0xA9C1F0", VA = "0xA9C1F0", Slot = "20")]
	protected override string GetAvailableAttachmentPath(int idx)
	{
		return null;
	}

	[Token(Token = "0x6002E75")]
	[Address(RVA = "0xA9C240", Offset = "0xA9C240", VA = "0xA9C240", Slot = "21")]
	protected override string GetRestrictedAttachmentPath(int idx)
	{
		return null;
	}

	[Token(Token = "0x6002E76")]
	[Address(RVA = "0xA9C298", Offset = "0xA9C298", VA = "0xA9C298", Slot = "22")]
	protected override string GetRestrictedAttachmentWeaponName(int idx)
	{
		return null;
	}

	[Token(Token = "0x6002E77")]
	[Address(RVA = "0xA9C3C8", Offset = "0xA9C3C8", VA = "0xA9C3C8", Slot = "23")]
	protected override bool IsRestrictedAttachmentUnlocked(int idx)
	{
		return default(bool);
	}

	[Token(Token = "0x6002E78")]
	[Address(RVA = "0xA9C504", Offset = "0xA9C504", VA = "0xA9C504")]
	public AbilityCustomizationView()
	{
	}
}
