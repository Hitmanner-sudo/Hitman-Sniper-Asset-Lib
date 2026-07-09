using HutongGames.PlayMaker;
using Il2CppDummyDll;

[Token(Token = "0x200046C")]
[Attribute(Name = "ActionCategoryAttribute", RVA = "0x594890", Offset = "0x594890")]
public class RewardMonitor : FsmStateAction
{
	[Token(Token = "0x4001833")]
	[FieldOffset(Offset = "0x50")]
	public string RewardName;

	[Token(Token = "0x4001834")]
	[FieldOffset(Offset = "0x58")]
	[Attribute(Name = "UIHintAttribute", RVA = "0x5B6A30", Offset = "0x5B6A30")]
	public FsmString RewardNameVar;

	[Token(Token = "0x4001835")]
	[FieldOffset(Offset = "0x60")]
	public FsmEvent OnRewardCompleted;

	[Token(Token = "0x4001836")]
	[FieldOffset(Offset = "0x68")]
	public FsmEvent OnRewardProgress;

	[Token(Token = "0x4001837")]
	[FieldOffset(Offset = "0x70")]
	[Attribute(Name = "UIHintAttribute", RVA = "0x5B6A44", Offset = "0x5B6A44")]
	public FsmInt CurrentProgress;

	[Token(Token = "0x4001838")]
	[FieldOffset(Offset = "0x78")]
	[Attribute(Name = "UIHintAttribute", RVA = "0x5B6A58", Offset = "0x5B6A58")]
	public FsmInt TotalCountNeeded;

	[Token(Token = "0x6001AB3")]
	[Address(RVA = "0x96D550", Offset = "0x96D550", VA = "0x96D550", Slot = "28")]
	public override void Reset()
	{
	}

	[Token(Token = "0x6001AB4")]
	[Address(RVA = "0x96D5A0", Offset = "0x96D5A0", VA = "0x96D5A0", Slot = "32")]
	public override void OnEnter()
	{
	}

	[Token(Token = "0x6001AB5")]
	[Address(RVA = "0x96D7C0", Offset = "0x96D7C0", VA = "0x96D7C0")]
	private void OnProgress(object sender, RewardActionBase.RewardCompletedEvent e)
	{
	}

	[Token(Token = "0x6001AB6")]
	[Address(RVA = "0x96D854", Offset = "0x96D854", VA = "0x96D854")]
	private void OnComplete(object sender, RewardActionBase.RewardCompletedEvent args)
	{
	}

	[Token(Token = "0x6001AB7")]
	[Address(RVA = "0x96D890", Offset = "0x96D890", VA = "0x96D890", Slot = "37")]
	public override void OnExit()
	{
	}

	[Token(Token = "0x6001AB8")]
	[Address(RVA = "0x96DA38", Offset = "0x96DA38", VA = "0x96DA38")]
	public RewardMonitor()
	{
	}
}
