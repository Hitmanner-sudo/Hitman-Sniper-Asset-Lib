using HutongGames.PlayMaker;
using Il2CppDummyDll;

[Token(Token = "0x20003FC")]
[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5939B4", Offset = "0x5939B4")]
public class GetZombieType : FsmStateAction
{
	[Token(Token = "0x4001638")]
	[FieldOffset(Offset = "0x50")]
	[Attribute(Name = "UIHintAttribute", RVA = "0x5B5474", Offset = "0x5B5474")]
	public FsmFloat WavePointTotal;

	[Token(Token = "0x4001639")]
	[FieldOffset(Offset = "0x58")]
	[Attribute(Name = "UIHintAttribute", RVA = "0x5B5488", Offset = "0x5B5488")]
	public FsmFloat MaxSpecialSpawnable;

	[Token(Token = "0x400163A")]
	[FieldOffset(Offset = "0x60")]
	[Attribute(Name = "UIHintAttribute", RVA = "0x5B549C", Offset = "0x5B549C")]
	public FsmFloat OutCurrentSpecialSpawned;

	[Token(Token = "0x400163B")]
	[FieldOffset(Offset = "0x68")]
	[Attribute(Name = "UIHintAttribute", RVA = "0x5B54B0", Offset = "0x5B54B0")]
	public FsmFloat OutWavePointAvailable;

	[Token(Token = "0x400163C")]
	[FieldOffset(Offset = "0x70")]
	[Attribute(Name = "UIHintAttribute", RVA = "0x5B54C4", Offset = "0x5B54C4")]
	public FsmFloat OutWavePointUsed;

	[Token(Token = "0x400163D")]
	[FieldOffset(Offset = "0x78")]
	[Attribute(Name = "UIHintAttribute", RVA = "0x5B54D8", Offset = "0x5B54D8")]
	public ZombieProperties ZombieTable;

	[Token(Token = "0x400163E")]
	[FieldOffset(Offset = "0x80")]
	public Faction RegularZombieFaction;

	[Token(Token = "0x400163F")]
	[FieldOffset(Offset = "0x88")]
	public Faction TankFaction;

	[Token(Token = "0x4001640")]
	[FieldOffset(Offset = "0x90")]
	public Faction HunterFaction;

	[Token(Token = "0x4001641")]
	[FieldOffset(Offset = "0x98")]
	public Faction ScreemerFaction;

	[Token(Token = "0x4001642")]
	[FieldOffset(Offset = "0xA0")]
	public FsmEvent RegularZombieSpawned;

	[Token(Token = "0x4001643")]
	[FieldOffset(Offset = "0xA8")]
	public FsmEvent TankSpawned;

	[Token(Token = "0x4001644")]
	[FieldOffset(Offset = "0xB0")]
	public FsmEvent HunterSpawned;

	[Token(Token = "0x4001645")]
	[FieldOffset(Offset = "0xB8")]
	public FsmEvent ScreemerSpawned;

	[Token(Token = "0x4001646")]
	[FieldOffset(Offset = "0xC0")]
	public FsmEvent NoSpawn;

	[Token(Token = "0x4001647")]
	[FieldOffset(Offset = "0xC8")]
	private ZombieProperties.ZombieDetail _zombieRegularDetail;

	[Token(Token = "0x4001648")]
	[FieldOffset(Offset = "0xD0")]
	private int[] _randomIndexCheck;

	[Token(Token = "0x6001866")]
	[Address(RVA = "0xC816F8", Offset = "0xC816F8", VA = "0xC816F8", Slot = "28")]
	public override void Reset()
	{
	}

	[Token(Token = "0x6001867")]
	[Address(RVA = "0xC81718", Offset = "0xC81718", VA = "0xC81718", Slot = "30")]
	public override void Awake()
	{
	}

	[Token(Token = "0x6001868")]
	[Address(RVA = "0xC81A50", Offset = "0xC81A50", VA = "0xC81A50", Slot = "32")]
	public override void OnEnter()
	{
	}

	[Token(Token = "0x6001869")]
	[Address(RVA = "0xC81A98", Offset = "0xC81A98", VA = "0xC81A98")]
	private bool SpawnZombie(int[] tableIndex)
	{
		return default(bool);
	}

	[Token(Token = "0x600186A")]
	[Address(RVA = "0xC81D04", Offset = "0xC81D04", VA = "0xC81D04")]
	private bool IsSpawnable(float cost, float currentSpawned, float maxSpawnable, int zombieTypeCount)
	{
		return default(bool);
	}

	[Token(Token = "0x600186B")]
	[Address(RVA = "0xC81CA0", Offset = "0xC81CA0", VA = "0xC81CA0")]
	private void AdjustPoints(float cost)
	{
	}

	[Token(Token = "0x600186C")]
	[Address(RVA = "0xC81E40", Offset = "0xC81E40", VA = "0xC81E40")]
	public GetZombieType()
	{
	}

	[Token(Token = "0x600186D")]
	[Address(RVA = "0xC81E48", Offset = "0xC81E48", VA = "0xC81E48")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6175A4", Offset = "0x6175A4")]
	private bool _003CAwake_003Eb__18_0(ZombieProperties.ZombieDetail x)
	{
		return default(bool);
	}
}
