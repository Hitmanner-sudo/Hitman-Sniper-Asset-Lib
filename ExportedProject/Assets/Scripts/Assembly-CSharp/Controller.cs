using Il2CppDummyDll;
using Technology;

[Token(Token = "0x200019E")]
public abstract class Controller : GameMonoBehaviour
{
	[Token(Token = "0x40008BE")]
	[FieldOffset(Offset = "0x48")]
	protected Character _character;

	[Token(Token = "0x170001C2")]
	public Character Character
	{
		[Token(Token = "0x6000AFC")]
		[Address(RVA = "0xD7C39C", Offset = "0xD7C39C", VA = "0xD7C39C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000AFD")]
	[Address(RVA = "0xD7C3A4", Offset = "0xD7C3A4", VA = "0xD7C3A4", Slot = "14")]
	public virtual void SetCharacter(Character character)
	{
	}

	[Token(Token = "0x6000AFE")]
	[Address(RVA = "0xD7C3C0", Offset = "0xD7C3C0", VA = "0xD7C3C0", Slot = "10")]
	protected override void OnDestroy()
	{
	}

	[Token(Token = "0x6000AFF")]
	[Address(RVA = "0xD7C43C", Offset = "0xD7C43C", VA = "0xD7C43C")]
	protected Controller()
	{
	}
}
