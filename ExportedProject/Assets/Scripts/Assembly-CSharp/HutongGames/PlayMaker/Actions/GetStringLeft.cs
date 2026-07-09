using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x200118C")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A88C4", Offset = "0x5A88C4")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A88C4", Offset = "0x5A88C4")]
	public class GetStringLeft : FsmStateAction
	{
		[Token(Token = "0x4005380")]
		[FieldOffset(Offset = "0x50")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FA2A4", Offset = "0x5FA2A4")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5FA2A4", Offset = "0x5FA2A4")]
		public FsmString stringVariable;

		[Token(Token = "0x4005381")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FA304", Offset = "0x5FA304")]
		public FsmInt charCount;

		[Token(Token = "0x4005382")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5FA33C", Offset = "0x5FA33C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FA33C", Offset = "0x5FA33C")]
		[RequiredField]
		public FsmString storeResult;

		[Token(Token = "0x4005383")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FA39C", Offset = "0x5FA39C")]
		public bool everyFrame;

		[Token(Token = "0x6006779")]
		[Address(RVA = "0xC7FA34", Offset = "0xC7FA34", VA = "0xC7FA34", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x600677A")]
		[Address(RVA = "0xC7FA68", Offset = "0xC7FA68", VA = "0xC7FA68", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x600677B")]
		[Address(RVA = "0xC7FB70", Offset = "0xC7FB70", VA = "0xC7FB70", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x600677C")]
		[Address(RVA = "0xC7FAA4", Offset = "0xC7FAA4", VA = "0xC7FAA4")]
		private void DoGetStringLeft()
		{
		}

		[Token(Token = "0x600677D")]
		[Address(RVA = "0xC7FB74", Offset = "0xC7FB74", VA = "0xC7FB74")]
		public GetStringLeft()
		{
		}
	}
}
