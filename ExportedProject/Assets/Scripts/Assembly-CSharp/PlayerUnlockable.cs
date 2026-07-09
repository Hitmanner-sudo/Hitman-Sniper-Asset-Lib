using Il2CppDummyDll;

[Token(Token = "0x200032A")]
public class PlayerUnlockable : Unlockable
{
	[Token(Token = "0x400118E")]
	[FieldOffset(Offset = "0x58")]
	public float BreathingTimeRatio;

	[Token(Token = "0x400118F")]
	[FieldOffset(Offset = "0x5C")]
	private float _breathingTimeModifier;

	[Token(Token = "0x4001190")]
	[FieldOffset(Offset = "0x60")]
	private PlayerController _player;

	[Token(Token = "0x6001353")]
	[Address(RVA = "0xABE520", Offset = "0xABE520", VA = "0xABE520", Slot = "8")]
	public override void Equip(PlayerController player)
	{
	}

	[Token(Token = "0x6001354")]
	[Address(RVA = "0xABE570", Offset = "0xABE570", VA = "0xABE570", Slot = "9")]
	public override void UnEquip()
	{
	}

	[Token(Token = "0x6001355")]
	[Address(RVA = "0xABE5A4", Offset = "0xABE5A4", VA = "0xABE5A4")]
	public PlayerUnlockable()
	{
	}
}
