using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001038")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A1110", Offset = "0x5A1110")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A1110", Offset = "0x5A1110")]
	public class StringContains : FsmStateAction
	{
		[Token(Token = "0x4004C2E")]
		[FieldOffset(Offset = "0x50")]
		[RequiredField]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5DD998", Offset = "0x5DD998")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DD998", Offset = "0x5DD998")]
		public FsmString stringVariable;

		[Token(Token = "0x4004C2F")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DD9F8", Offset = "0x5DD9F8")]
		[RequiredField]
		public FsmString containsString;

		[Token(Token = "0x4004C30")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DDA44", Offset = "0x5DDA44")]
		public FsmEvent trueEvent;

		[Token(Token = "0x4004C31")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DDA7C", Offset = "0x5DDA7C")]
		public FsmEvent falseEvent;

		[Token(Token = "0x4004C32")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5DDAB4", Offset = "0x5DDAB4")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DDAB4", Offset = "0x5DDAB4")]
		public FsmBool storeResult;

		[Token(Token = "0x4004C33")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DDB04", Offset = "0x5DDB04")]
		public bool everyFrame;

		[Token(Token = "0x6006138")]
		[Address(RVA = "0xD2DE3C", Offset = "0xD2DE3C", VA = "0xD2DE3C", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006139")]
		[Address(RVA = "0xD2DE9C", Offset = "0xD2DE9C", VA = "0xD2DE9C", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x600613A")]
		[Address(RVA = "0xD2DF9C", Offset = "0xD2DF9C", VA = "0xD2DF9C", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x600613B")]
		[Address(RVA = "0xD2DED8", Offset = "0xD2DED8", VA = "0xD2DED8")]
		private void DoStringContains()
		{
		}

		[Token(Token = "0x600613C")]
		[Address(RVA = "0xD2DFA0", Offset = "0xD2DFA0", VA = "0xD2DFA0")]
		public StringContains()
		{
		}
	}
}
