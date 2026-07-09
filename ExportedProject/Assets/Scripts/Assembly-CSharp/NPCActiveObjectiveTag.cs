using Il2CppDummyDll;

[Token(Token = "0x2000252")]
public class NPCActiveObjectiveTag : ObjectiveTagNPCBase
{
	[Token(Token = "0x4000CD8")]
	[FieldOffset(Offset = "0x98")]
	public Spawner[] Spawners;

	[Token(Token = "0x4000CD9")]
	[FieldOffset(Offset = "0xA0")]
	public float HPNeedeed;

	[Token(Token = "0x6000DFB")]
	[Address(RVA = "0xC51C60", Offset = "0xC51C60", VA = "0xC51C60", Slot = "7")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x6000DFC")]
	[Address(RVA = "0xC51D60", Offset = "0xC51D60", VA = "0xC51D60", Slot = "10")]
	protected override void OnDestroy()
	{
	}

	[Token(Token = "0x6000DFD")]
	[Address(RVA = "0xC51EDC", Offset = "0xC51EDC", VA = "0xC51EDC", Slot = "18")]
	protected override bool HaveHPNeeded()
	{
		return default(bool);
	}

	[Token(Token = "0x6000DFE")]
	[Address(RVA = "0xC51FD0", Offset = "0xC51FD0", VA = "0xC51FD0", Slot = "15")]
	protected override void ObjectiveTagDie()
	{
	}

	[Token(Token = "0x6000DFF")]
	[Address(RVA = "0xC51DE8", Offset = "0xC51DE8", VA = "0xC51DE8")]
	private void UnbindEvents()
	{
	}

	[Token(Token = "0x6000E00")]
	[Address(RVA = "0xC51B0C", Offset = "0xC51B0C", VA = "0xC51B0C", Slot = "20")]
	protected virtual bool IsInSpawnerList(Spawner spawnedFrom)
	{
		return default(bool);
	}

	[Token(Token = "0x6000E01")]
	[Address(RVA = "0xC51FF8", Offset = "0xC51FF8", VA = "0xC51FF8")]
	private void OnCharacterSpawned(object sender, Spawner.SpawnerEventArgs e)
	{
	}

	[Token(Token = "0x6000E02")]
	[Address(RVA = "0xC52128", Offset = "0xC52128", VA = "0xC52128")]
	private void OnCharacterDied(object sender, Character.DeathEvent e)
	{
	}

	[Token(Token = "0x6000E03")]
	[Address(RVA = "0xC51B78", Offset = "0xC51B78", VA = "0xC51B78")]
	public NPCActiveObjectiveTag()
	{
	}
}
