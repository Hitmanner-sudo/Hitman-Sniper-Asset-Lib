using HutongGames.PlayMaker;
using Il2CppDummyDll;

[Token(Token = "0x200040A")]
[Attribute(Name = "ActionCategoryAttribute", RVA = "0x593AF8", Offset = "0x593AF8")]
public class MissionObjective : FsmStateAction
{
	[Token(Token = "0x400168B")]
	[FieldOffset(Offset = "0x50")]
	public FsmEvent OnCompleteSendEvent;

	[Token(Token = "0x400168C")]
	[FieldOffset(Offset = "0x58")]
	public string Objective;

	[Token(Token = "0x400168D")]
	[FieldOffset(Offset = "0x60")]
	public string CounterName;

	[Token(Token = "0x400168E")]
	[FieldOffset(Offset = "0x68")]
	[Attribute(Name = "UIHintAttribute", RVA = "0x5B57E0", Offset = "0x5B57E0")]
	[RequiredField]
	public FsmInt EventCount;

	[Token(Token = "0x400168F")]
	[FieldOffset(Offset = "0x70")]
	public int CountNeeded;

	[Token(Token = "0x4001690")]
	[FieldOffset(Offset = "0x74")]
	private int _oldCounterValue;

	[Token(Token = "0x4001691")]
	[FieldOffset(Offset = "0x78")]
	private bool _missionUpdated;

	[Token(Token = "0x4001692")]
	[FieldOffset(Offset = "0x80")]
	public ModelContainer ModelContainer;

	[Token(Token = "0x60018D4")]
	[Address(RVA = "0xA1B878", Offset = "0xA1B878", VA = "0xA1B878", Slot = "28")]
	public override void Reset()
	{
	}

	[Token(Token = "0x60018D5")]
	[Address(RVA = "0xA1B8F4", Offset = "0xA1B8F4", VA = "0xA1B8F4", Slot = "32")]
	public override void OnEnter()
	{
	}

	[Token(Token = "0x60018D6")]
	[Address(RVA = "0xA1B930", Offset = "0xA1B930", VA = "0xA1B930")]
	private void TryToUpdateMission()
	{
	}

	[Token(Token = "0x60018D7")]
	[Address(RVA = "0xA1BA78", Offset = "0xA1BA78", VA = "0xA1BA78")]
	private void RefreshCounterText()
	{
	}

	[Token(Token = "0x60018D8")]
	[Address(RVA = "0xA1B9E8", Offset = "0xA1B9E8", VA = "0xA1B9E8")]
	private void UpdateObjective()
	{
	}

	[Token(Token = "0x60018D9")]
	[Address(RVA = "0xA1BBBC", Offset = "0xA1BBBC", VA = "0xA1BBBC", Slot = "34")]
	public override void OnUpdate()
	{
	}

	[Token(Token = "0x60018DA")]
	[Address(RVA = "0xA1BC18", Offset = "0xA1BC18", VA = "0xA1BC18")]
	public MissionObjective()
	{
	}
}
