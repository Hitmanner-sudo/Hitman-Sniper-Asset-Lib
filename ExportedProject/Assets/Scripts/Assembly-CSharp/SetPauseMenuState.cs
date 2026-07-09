using HutongGames.PlayMaker;
using Il2CppDummyDll;

[Token(Token = "0x200046F")]
[Attribute(Name = "TooltipAttribute", RVA = "0x594960", Offset = "0x594960")]
[Attribute(Name = "ActionCategoryAttribute", RVA = "0x594960", Offset = "0x594960")]
public class SetPauseMenuState : FsmStateAction
{
	[Token(Token = "0x4001840")]
	private const string HUD_MODEL_PATH = "Models/HUDModel";

	[Token(Token = "0x4001841")]
	[FieldOffset(Offset = "0x4C")]
	public HUDModel.PauseMenuState NewState;

	[Token(Token = "0x6001AC2")]
	[Address(RVA = "0x1041438", Offset = "0x1041438", VA = "0x1041438", Slot = "32")]
	public override void OnEnter()
	{
	}

	[Token(Token = "0x6001AC3")]
	[Address(RVA = "0x1041564", Offset = "0x1041564", VA = "0x1041564")]
	public SetPauseMenuState()
	{
	}
}
