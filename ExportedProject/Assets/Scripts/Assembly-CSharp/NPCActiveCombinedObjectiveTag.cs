using Il2CppDummyDll;

[Token(Token = "0x2000251")]
public class NPCActiveCombinedObjectiveTag : NPCActiveObjectiveTag
{
	[Token(Token = "0x4000CD7")]
	[FieldOffset(Offset = "0xA8")]
	public Spawner[] SecondSpawners;

	[Token(Token = "0x6000DF5")]
	[Address(RVA = "0xC518BC", Offset = "0xC518BC", VA = "0xC518BC", Slot = "19")]
	protected override bool ShouldRegisterNPC()
	{
		return default(bool);
	}

	[Token(Token = "0x6000DF6")]
	[Address(RVA = "0xC51A8C", Offset = "0xC51A8C", VA = "0xC51A8C", Slot = "20")]
	protected override bool IsInSpawnerList(Spawner spawnedFrom)
	{
		return default(bool);
	}

	[Token(Token = "0x6000DF7")]
	[Address(RVA = "0xC518F8", Offset = "0xC518F8", VA = "0xC518F8")]
	protected bool HaveOneNPCInEachSpawners()
	{
		return default(bool);
	}

	[Token(Token = "0x6000DF8")]
	[Address(RVA = "0xC51B68", Offset = "0xC51B68", VA = "0xC51B68")]
	public NPCActiveCombinedObjectiveTag()
	{
	}

	[Token(Token = "0x6000DF9")]
	[Address(RVA = "0xC51B88", Offset = "0xC51B88", VA = "0xC51B88")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x614EC4", Offset = "0x614EC4")]
	private bool _003CHaveOneNPCInEachSpawners_003Eb__3_0(AIController r)
	{
		return default(bool);
	}

	[Token(Token = "0x6000DFA")]
	[Address(RVA = "0xC51BF4", Offset = "0xC51BF4", VA = "0xC51BF4")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x614ED4", Offset = "0x614ED4")]
	private bool _003CHaveOneNPCInEachSpawners_003Eb__3_1(AIController r)
	{
		return default(bool);
	}
}
