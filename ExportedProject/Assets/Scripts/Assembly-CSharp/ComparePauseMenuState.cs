using HutongGames.PlayMaker;
using Il2CppDummyDll;

[Token(Token = "0x200043F")]
[Attribute(Name = "TooltipAttribute", RVA = "0x593EA0", Offset = "0x593EA0")]
[Attribute(Name = "ActionCategoryAttribute", RVA = "0x593EA0", Offset = "0x593EA0")]
public class ComparePauseMenuState : FsmStateAction
{
	[Token(Token = "0x4001772")]
	private const string HUD_MODEL_PATH = "Models/HUDModel";

	[Token(Token = "0x4001773")]
	[FieldOffset(Offset = "0x4C")]
	public HUDModel.PauseMenuState StateToCompare;

	[Token(Token = "0x4001774")]
	[FieldOffset(Offset = "0x50")]
	public FsmEvent Equal;

	[Token(Token = "0x4001775")]
	[FieldOffset(Offset = "0x58")]
	public bool EveryFrame;

	[Token(Token = "0x4001776")]
	[FieldOffset(Offset = "0x60")]
	private DataModel _model;

	[Token(Token = "0x60019F6")]
	[Address(RVA = "0x8DECDC", Offset = "0x8DECDC", VA = "0x8DECDC", Slot = "32")]
	public override void OnEnter()
	{
	}

	[Token(Token = "0x60019F7")]
	[Address(RVA = "0x8DEE60", Offset = "0x8DEE60", VA = "0x8DEE60", Slot = "34")]
	public override void OnUpdate()
	{
	}

	[Token(Token = "0x60019F8")]
	[Address(RVA = "0x8DED98", Offset = "0x8DED98", VA = "0x8DED98")]
	private void DoCompare()
	{
	}

	[Token(Token = "0x60019F9")]
	[Address(RVA = "0x8DEE64", Offset = "0x8DEE64", VA = "0x8DEE64")]
	public ComparePauseMenuState()
	{
	}
}
