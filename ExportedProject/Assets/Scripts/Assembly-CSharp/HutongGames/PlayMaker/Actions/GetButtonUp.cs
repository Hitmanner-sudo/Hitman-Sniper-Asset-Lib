using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000FF7")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59FB38", Offset = "0x59FB38")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59FB38", Offset = "0x59FB38")]
	public class GetButtonUp : FsmStateAction
	{
		[Token(Token = "0x4004AF8")]
		[FieldOffset(Offset = "0x50")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D8940", Offset = "0x5D8940")]
		public FsmString buttonName;

		[Token(Token = "0x4004AF9")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D898C", Offset = "0x5D898C")]
		public FsmEvent sendEvent;

		[Token(Token = "0x4004AFA")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D89C4", Offset = "0x5D89C4")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5D89C4", Offset = "0x5D89C4")]
		public FsmBool storeResult;

		[Token(Token = "0x6006016")]
		[Address(RVA = "0x105DA94", Offset = "0x105DA94", VA = "0x105DA94", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006017")]
		[Address(RVA = "0x105DAEC", Offset = "0x105DAEC", VA = "0x105DAEC", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6006018")]
		[Address(RVA = "0x105DB50", Offset = "0x105DB50", VA = "0x105DB50")]
		public GetButtonUp()
		{
		}
	}
}
