using HutongGames.PlayMaker;
using Il2CppDummyDll;

[Token(Token = "0x200056F")]
[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5952D4", Offset = "0x5952D4")]
public class FadeAction : FsmStateAction
{
	[Token(Token = "0x4001CA6")]
	[FieldOffset(Offset = "0x50")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5B7C3C", Offset = "0x5B7C3C")]
	[Attribute(Name = "UIHintAttribute", RVA = "0x5B7C3C", Offset = "0x5B7C3C")]
	public UIWidget WidgetToFade;

	[Token(Token = "0x4001CA7")]
	[FieldOffset(Offset = "0x58")]
	[Attribute(Name = "UIHintAttribute", RVA = "0x5B7C8C", Offset = "0x5B7C8C")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5B7C8C", Offset = "0x5B7C8C")]
	public FsmFloat FadeTime;

	[Token(Token = "0x4001CA8")]
	[FieldOffset(Offset = "0x60")]
	[Attribute(Name = "UIHintAttribute", RVA = "0x5B7CDC", Offset = "0x5B7CDC")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5B7CDC", Offset = "0x5B7CDC")]
	public FsmFloat FadeTo;

	[Token(Token = "0x6002249")]
	[Address(RVA = "0x951CF4", Offset = "0x951CF4", VA = "0x951CF4", Slot = "32")]
	public override void OnEnter()
	{
	}

	[Token(Token = "0x600224A")]
	[Address(RVA = "0x951D78", Offset = "0x951D78", VA = "0x951D78")]
	public FadeAction()
	{
	}
}
