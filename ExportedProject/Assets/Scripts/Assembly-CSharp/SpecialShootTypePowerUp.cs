using Il2CppDummyDll;

[Token(Token = "0x200035E")]
public class SpecialShootTypePowerUp : PowerUp
{
	[Token(Token = "0x40012A1")]
	[FieldOffset(Offset = "0xA0")]
	public float BulletSpeed;

	[Token(Token = "0x40012A2")]
	[FieldOffset(Offset = "0xA4")]
	public float BulletGravity;

	[Token(Token = "0x40012A3")]
	[FieldOffset(Offset = "0xA8")]
	public bool PenetrateEverything;

	[Token(Token = "0x40012A4")]
	[FieldOffset(Offset = "0xA9")]
	public bool KillInOneShoot;

	[Token(Token = "0x40012A5")]
	[FieldOffset(Offset = "0xAA")]
	public bool IsPossessShot;

	[Token(Token = "0x40012A6")]
	[FieldOffset(Offset = "0xAB")]
	public bool IsPinShot;

	[Token(Token = "0x40012A7")]
	[FieldOffset(Offset = "0xAC")]
	private float _previousSpeed;

	[Token(Token = "0x40012A8")]
	[FieldOffset(Offset = "0xB0")]
	private float _previousGravity;

	[Token(Token = "0x40012A9")]
	[FieldOffset(Offset = "0xB4")]
	private bool _previousPenetrateEverything;

	[Token(Token = "0x40012AA")]
	[FieldOffset(Offset = "0xB8")]
	private int _previousDamage;

	[Token(Token = "0x40012AB")]
	[FieldOffset(Offset = "0xBC")]
	private bool _previousIsPossessShot;

	[Token(Token = "0x40012AC")]
	[FieldOffset(Offset = "0xBD")]
	private bool _previousIsPinShot;

	[Token(Token = "0x6001452")]
	[Address(RVA = "0xA746DC", Offset = "0xA746DC", VA = "0xA746DC", Slot = "10")]
	public override void Activate()
	{
	}

	[Token(Token = "0x6001453")]
	[Address(RVA = "0xA747DC", Offset = "0xA747DC", VA = "0xA747DC", Slot = "11")]
	public override void Deactivate()
	{
	}

	[Token(Token = "0x6001454")]
	[Address(RVA = "0xA74878", Offset = "0xA74878", VA = "0xA74878")]
	public SpecialShootTypePowerUp()
	{
	}
}
