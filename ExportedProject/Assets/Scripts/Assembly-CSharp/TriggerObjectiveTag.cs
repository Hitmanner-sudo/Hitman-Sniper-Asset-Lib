using Il2CppDummyDll;

[Token(Token = "0x20002B6")]
public class TriggerObjectiveTag : ObjectiveTagNPCBase
{
	[Token(Token = "0x4000F50")]
	[FieldOffset(Offset = "0x98")]
	public NPCTriggerBase _NPCTrigger;

	[Token(Token = "0x4000F51")]
	[FieldOffset(Offset = "0xA0")]
	public float HPNeedeed;

	[Token(Token = "0x600108D")]
	[Address(RVA = "0xC9F1D0", Offset = "0xC9F1D0", VA = "0xC9F1D0", Slot = "7")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x600108E")]
	[Address(RVA = "0xC9F3DC", Offset = "0xC9F3DC", VA = "0xC9F3DC", Slot = "10")]
	protected override void OnDestroy()
	{
	}

	[Token(Token = "0x600108F")]
	[Address(RVA = "0xC9F538", Offset = "0xC9F538", VA = "0xC9F538")]
	private void OnNPCTriggerEnter(object sender, NPCTriggerBase.NPCTriggerEventArgs args)
	{
	}

	[Token(Token = "0x6001090")]
	[Address(RVA = "0xC9F554", Offset = "0xC9F554", VA = "0xC9F554")]
	private void OnNPCTriggerExit(object sender, NPCTriggerBase.NPCTriggerEventArgs args)
	{
	}

	[Token(Token = "0x6001091")]
	[Address(RVA = "0xC9F570", Offset = "0xC9F570", VA = "0xC9F570", Slot = "18")]
	protected override bool HaveHPNeeded()
	{
		return default(bool);
	}

	[Token(Token = "0x6001092")]
	[Address(RVA = "0xC9F674", Offset = "0xC9F674", VA = "0xC9F674")]
	public TriggerObjectiveTag()
	{
	}
}
