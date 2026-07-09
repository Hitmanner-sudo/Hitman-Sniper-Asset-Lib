using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000F76")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59D268", Offset = "0x59D268")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59D268", Offset = "0x59D268")]
	public class DrawStateLabel : FsmStateAction
	{
		[Token(Token = "0x40048EF")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D0D30", Offset = "0x5D0D30")]
		[RequiredField]
		public FsmBool showLabel;

		[Token(Token = "0x6005E46")]
		[Address(RVA = "0xC1FC30", Offset = "0xC1FC30", VA = "0xC1FC30", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005E47")]
		[Address(RVA = "0xC1FC5C", Offset = "0xC1FC5C", VA = "0xC1FC5C", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6005E48")]
		[Address(RVA = "0xC1FCA4", Offset = "0xC1FCA4", VA = "0xC1FCA4")]
		public DrawStateLabel()
		{
		}
	}
}
