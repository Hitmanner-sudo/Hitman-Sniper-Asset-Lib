using Il2CppDummyDll;

[Token(Token = "0x20000CB")]
public class FireworkPoint : Waypoint
{
	[Token(Token = "0x600061D")]
	[Address(RVA = "0x9569CC", Offset = "0x9569CC", VA = "0x9569CC", Slot = "16")]
	protected override void Register()
	{
	}

	[Token(Token = "0x600061E")]
	[Address(RVA = "0x956A44", Offset = "0x956A44", VA = "0x956A44", Slot = "17")]
	protected override void UnRegister()
	{
	}

	[Token(Token = "0x600061F")]
	[Address(RVA = "0x956ABC", Offset = "0x956ABC", VA = "0x956ABC", Slot = "24")]
	public override float GetDistanceSqr(AIController ai)
	{
		return default(float);
	}

	[Token(Token = "0x6000620")]
	[Address(RVA = "0x956B54", Offset = "0x956B54", VA = "0x956B54")]
	public FireworkPoint()
	{
	}
}
