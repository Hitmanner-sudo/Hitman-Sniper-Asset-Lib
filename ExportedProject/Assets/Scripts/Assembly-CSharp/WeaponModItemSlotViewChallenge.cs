using Il2CppDummyDll;

[Token(Token = "0x2000751")]
public class WeaponModItemSlotViewChallenge : ModItemSlotView
{
	[Token(Token = "0x1700063D")]
	public override int AttachmentIndex
	{
		[Token(Token = "0x60030C7")]
		[Address(RVA = "0x98BA38", Offset = "0x98BA38", VA = "0x98BA38", Slot = "22")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x1700063E")]
	protected override ColorModel.ColorModelEnum LockedColor
	{
		[Token(Token = "0x60030CA")]
		[Address(RVA = "0x98BC28", Offset = "0x98BC28", VA = "0x98BC28", Slot = "18")]
		get
		{
			return default(ColorModel.ColorModelEnum);
		}
	}

	[Token(Token = "0x60030C8")]
	[Address(RVA = "0x98BAB0", Offset = "0x98BAB0", VA = "0x98BAB0", Slot = "29")]
	public override bool WillUnlockNextLevel()
	{
		return default(bool);
	}

	[Token(Token = "0x60030C9")]
	[Address(RVA = "0x98BBB0", Offset = "0x98BBB0", VA = "0x98BBB0", Slot = "28")]
	protected override int GetLevelUnlocked()
	{
		return default(int);
	}

	[Token(Token = "0x60030CB")]
	[Address(RVA = "0x98BC30", Offset = "0x98BC30", VA = "0x98BC30")]
	public WeaponModItemSlotViewChallenge()
	{
	}
}
