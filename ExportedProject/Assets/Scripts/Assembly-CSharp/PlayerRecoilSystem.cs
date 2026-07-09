using Il2CppDummyDll;

[Token(Token = "0x20004DA")]
public class PlayerRecoilSystem : PlayerSystem
{
	[Token(Token = "0x40019F3")]
	[FieldOffset(Offset = "0x50")]
	private RecoilSystem _recoilSystemForCamera;

	[Token(Token = "0x40019F4")]
	[FieldOffset(Offset = "0x58")]
	private RecoilSystem _recoilSystemForMesh;

	[Token(Token = "0x6001DB9")]
	[Address(RVA = "0xAB52B8", Offset = "0xAB52B8", VA = "0xAB52B8", Slot = "9")]
	protected override void Start()
	{
	}

	[Token(Token = "0x6001DBA")]
	[Address(RVA = "0xAB53C4", Offset = "0xAB53C4", VA = "0xAB53C4", Slot = "14")]
	public override void Execute()
	{
	}

	[Token(Token = "0x6001DBB")]
	[Address(RVA = "0xAB5400", Offset = "0xAB5400", VA = "0xAB5400", Slot = "15")]
	public override void ApplyToCharacter()
	{
	}

	[Token(Token = "0x6001DBC")]
	[Address(RVA = "0xAB570C", Offset = "0xAB570C", VA = "0xAB570C")]
	public void AddRecoil()
	{
	}

	[Token(Token = "0x6001DBD")]
	[Address(RVA = "0xAB5780", Offset = "0xAB5780", VA = "0xAB5780")]
	public void AddRecoilPlayerTime()
	{
	}

	[Token(Token = "0x6001DBE")]
	[Address(RVA = "0xAB57F4", Offset = "0xAB57F4", VA = "0xAB57F4")]
	public PlayerRecoilSystem()
	{
	}
}
