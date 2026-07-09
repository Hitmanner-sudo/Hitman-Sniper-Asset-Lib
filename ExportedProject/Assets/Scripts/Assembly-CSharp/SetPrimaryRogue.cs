using Il2CppDummyDll;
using Technology;

[Token(Token = "0x200040E")]
public class SetPrimaryRogue : GameMonoBehaviour
{
	[Token(Token = "0x40016AF")]
	[FieldOffset(Offset = "0x48")]
	public Target.TargetTypeEnum NewTargetType;

	[Token(Token = "0x40016B0")]
	[FieldOffset(Offset = "0x50")]
	public Trackable NewTracker;

	[Token(Token = "0x40016B1")]
	[FieldOffset(Offset = "0x58")]
	public AIController NewController;

	[Token(Token = "0x40016B2")]
	[FieldOffset(Offset = "0x60")]
	private Character _character;

	[Token(Token = "0x40016B3")]
	[FieldOffset(Offset = "0x68")]
	private RogueData _missionRogueData;

	[Token(Token = "0x60018FC")]
	[Address(RVA = "0x1041C0C", Offset = "0x1041C0C", VA = "0x1041C0C", Slot = "11")]
	protected override void OnEnable()
	{
	}

	[Token(Token = "0x60018FD")]
	[Address(RVA = "0x104209C", Offset = "0x104209C", VA = "0x104209C", Slot = "12")]
	protected override void OnDisable()
	{
	}

	[Token(Token = "0x60018FE")]
	[Address(RVA = "0x1041E90", Offset = "0x1041E90", VA = "0x1041E90")]
	private bool HandlerSpawner(AICharacterSpawner s)
	{
		return default(bool);
	}

	[Token(Token = "0x60018FF")]
	[Address(RVA = "0x10421C0", Offset = "0x10421C0", VA = "0x10421C0")]
	private void OnSpawn(object sender, Spawner.SpawnerEventArgs e)
	{
	}

	[Token(Token = "0x6001900")]
	[Address(RVA = "0x1042180", Offset = "0x1042180", VA = "0x1042180")]
	private void Promote(Character c)
	{
	}

	[Token(Token = "0x6001901")]
	[Address(RVA = "0x1042414", Offset = "0x1042414", VA = "0x1042414")]
	private void SetTargetType()
	{
	}

	[Token(Token = "0x6001902")]
	[Address(RVA = "0x10426AC", Offset = "0x10426AC", VA = "0x10426AC")]
	private void RemoveOldTrackable()
	{
	}

	[Token(Token = "0x6001903")]
	[Address(RVA = "0x1042478", Offset = "0x1042478", VA = "0x1042478")]
	private void RemoveOldController()
	{
	}

	[Token(Token = "0x6001904")]
	[Address(RVA = "0x104276C", Offset = "0x104276C", VA = "0x104276C")]
	private void AddNewTrackable()
	{
	}

	[Token(Token = "0x6001905")]
	[Address(RVA = "0x1042538", Offset = "0x1042538", VA = "0x1042538")]
	private void AddNewController()
	{
	}

	[Token(Token = "0x6001906")]
	[Address(RVA = "0x10428B0", Offset = "0x10428B0", VA = "0x10428B0")]
	public SetPrimaryRogue()
	{
	}
}
