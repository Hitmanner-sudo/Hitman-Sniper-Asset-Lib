using HutongGames.PlayMaker;
using Il2CppDummyDll;

[Token(Token = "0x2000455")]
[Attribute(Name = "ActionCategoryAttribute", RVA = "0x594348", Offset = "0x594348")]
public class HoldBreathMonitor : FsmStateAction
{
	[Token(Token = "0x40017E7")]
	[FieldOffset(Offset = "0x50")]
	public FsmEvent HoldingBreathEvent;

	[Token(Token = "0x6001A54")]
	[Address(RVA = "0xA155B4", Offset = "0xA155B4", VA = "0xA155B4", Slot = "28")]
	public override void Reset()
	{
	}

	[Token(Token = "0x6001A55")]
	[Address(RVA = "0xA155BC", Offset = "0xA155BC", VA = "0xA155BC", Slot = "32")]
	public override void OnEnter()
	{
	}

	[Token(Token = "0x6001A56")]
	[Address(RVA = "0xA156F8", Offset = "0xA156F8", VA = "0xA156F8", Slot = "37")]
	public override void OnExit()
	{
	}

	[Token(Token = "0x6001A57")]
	[Address(RVA = "0xA15788", Offset = "0xA15788", VA = "0xA15788")]
	private void OnSlowMotionActivated(object sender, PlayerSlowMotionSystem.SlowMotionActivatedEventArgs e)
	{
	}

	[Token(Token = "0x6001A58")]
	[Address(RVA = "0xA157C4", Offset = "0xA157C4", VA = "0xA157C4")]
	public HoldBreathMonitor()
	{
	}
}
