using HutongGames.PlayMaker;
using Il2CppDummyDll;

[Token(Token = "0x2000435")]
[Attribute(Name = "ActionCategoryAttribute", RVA = "0x593CB8", Offset = "0x593CB8")]
[Attribute(Name = "TooltipAttribute", RVA = "0x593CB8", Offset = "0x593CB8")]
public class BodyDisposalTriggerMonitor : FsmStateAction
{
	[Token(Token = "0x4001743")]
	[FieldOffset(Offset = "0x50")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5B5C68", Offset = "0x5B5C68")]
	public FsmGameObject BodyDisposalTrigger;

	[Token(Token = "0x4001744")]
	[FieldOffset(Offset = "0x58")]
	private BodyDisposalTrigger[] _triggers;

	[Token(Token = "0x4001745")]
	[FieldOffset(Offset = "0x60")]
	[Attribute(Name = "UIHintAttribute", RVA = "0x5B5CA0", Offset = "0x5B5CA0")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5B5CA0", Offset = "0x5B5CA0")]
	public FsmGameObject NPC;

	[Token(Token = "0x4001746")]
	[FieldOffset(Offset = "0x68")]
	public FsmEvent BodyDisposedEvent;

	[Token(Token = "0x4001747")]
	[FieldOffset(Offset = "0x70")]
	public FsmEvent AnyBodyDisposedEvent;

	[Token(Token = "0x4001748")]
	[FieldOffset(Offset = "0x78")]
	public NPCFilter AnyBodyDisposedFilter;

	[Token(Token = "0x60019C3")]
	[Address(RVA = "0xA7E8F8", Offset = "0xA7E8F8", VA = "0xA7E8F8", Slot = "28")]
	public override void Reset()
	{
	}

	[Token(Token = "0x60019C4")]
	[Address(RVA = "0xA7E930", Offset = "0xA7E930", VA = "0xA7E930", Slot = "32")]
	public override void OnEnter()
	{
	}

	[Token(Token = "0x60019C5")]
	[Address(RVA = "0xA7EB34", Offset = "0xA7EB34", VA = "0xA7EB34")]
	private void OnBodyDisposed(object sender, NPCTriggerBase.NPCTriggerEventArgs args)
	{
	}

	[Token(Token = "0x60019C6")]
	[Address(RVA = "0xA7EC20", Offset = "0xA7EC20", VA = "0xA7EC20")]
	private void OnAnyBodyDisposed(object sender, NPCTriggerBase.NPCTriggerEventArgs args)
	{
	}

	[Token(Token = "0x60019C7")]
	[Address(RVA = "0xA7ED28", Offset = "0xA7ED28", VA = "0xA7ED28", Slot = "37")]
	public override void OnExit()
	{
	}

	[Token(Token = "0x60019C8")]
	[Address(RVA = "0xA7EEAC", Offset = "0xA7EEAC", VA = "0xA7EEAC")]
	public BodyDisposalTriggerMonitor()
	{
	}
}
