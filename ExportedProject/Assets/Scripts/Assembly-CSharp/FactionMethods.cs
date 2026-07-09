using Il2CppDummyDll;

[Token(Token = "0x2000121")]
public static class FactionMethods
{
	[Token(Token = "0x60007E9")]
	[Address(RVA = "0x951B80", Offset = "0x951B80", VA = "0x951B80")]
	public static bool IsAlliedWith(this Faction me, Faction other)
	{
		return default(bool);
	}

	[Token(Token = "0x60007EA")]
	[Address(RVA = "0x951C34", Offset = "0x951C34", VA = "0x951C34")]
	public static bool IsEnemyWith(this Faction me, Faction other)
	{
		return default(bool);
	}

	[Token(Token = "0x60007EB")]
	[Address(RVA = "0x951CB0", Offset = "0x951CB0", VA = "0x951CB0")]
	public static Faction.Relationship GetRelationship(this Faction me, Faction other)
	{
		return default(Faction.Relationship);
	}
}
