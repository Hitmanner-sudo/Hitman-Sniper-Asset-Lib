using HutongGames.PlayMaker;
using Il2CppDummyDll;

[Token(Token = "0x2000451")]
[Attribute(Name = "ActionCategoryAttribute", RVA = "0x594240", Offset = "0x594240")]
public class ExtractionCountdownMonitor : FsmStateAction
{
	[Token(Token = "0x40017DE")]
	[FieldOffset(Offset = "0x50")]
	public FsmEvent EnteredExtractionCountdown;

	[Token(Token = "0x6001A46")]
	[Address(RVA = "0x94CC30", Offset = "0x94CC30", VA = "0x94CC30", Slot = "34")]
	public override void OnUpdate()
	{
	}

	[Token(Token = "0x6001A47")]
	[Address(RVA = "0x94CD04", Offset = "0x94CD04", VA = "0x94CD04")]
	private void OnExtractionCountdownStart()
	{
	}

	[Token(Token = "0x6001A48")]
	[Address(RVA = "0x94CD40", Offset = "0x94CD40", VA = "0x94CD40")]
	public ExtractionCountdownMonitor()
	{
	}
}
