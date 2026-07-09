using Il2CppDummyDll;

[Token(Token = "0x20000CC")]
public class FleePoint : Waypoint
{
	[Token(Token = "0x6000621")]
	[Address(RVA = "0x9585F0", Offset = "0x9585F0", VA = "0x9585F0", Slot = "16")]
	protected override void Register()
	{
	}

	[Token(Token = "0x6000622")]
	[Address(RVA = "0x958668", Offset = "0x958668", VA = "0x958668", Slot = "17")]
	protected override void UnRegister()
	{
	}

	[Token(Token = "0x6000623")]
	[Address(RVA = "0x9586E0", Offset = "0x9586E0", VA = "0x9586E0", Slot = "15")]
	public override bool CanKeepUsing(AIController ai)
	{
		return default(bool);
	}

	[Token(Token = "0x6000624")]
	[Address(RVA = "0x958518", Offset = "0x958518", VA = "0x958518")]
	public static bool CanFlee(AIController ai)
	{
		return default(bool);
	}

	[Token(Token = "0x6000625")]
	[Address(RVA = "0x958728", Offset = "0x958728", VA = "0x958728")]
	public FleePoint()
	{
	}
}
