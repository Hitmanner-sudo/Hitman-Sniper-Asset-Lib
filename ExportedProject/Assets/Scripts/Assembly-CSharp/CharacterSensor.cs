using Il2CppDummyDll;

[Token(Token = "0x2000146")]
public class CharacterSensor : AIVisionSensor
{
	[Token(Token = "0x40006F4")]
	[FieldOffset(Offset = "0xA0")]
	private Character _character;

	[Token(Token = "0x60008C2")]
	[Address(RVA = "0xAFD5F4", Offset = "0xAFD5F4", VA = "0xAFD5F4", Slot = "9")]
	protected override void Start()
	{
	}

	[Token(Token = "0x60008C3")]
	[Address(RVA = "0xAFD668", Offset = "0xAFD668", VA = "0xAFD668", Slot = "16")]
	protected override void UpdateVisionStart()
	{
	}

	[Token(Token = "0x60008C4")]
	[Address(RVA = "0xAFD71C", Offset = "0xAFD71C", VA = "0xAFD71C")]
	public CharacterSensor()
	{
	}
}
