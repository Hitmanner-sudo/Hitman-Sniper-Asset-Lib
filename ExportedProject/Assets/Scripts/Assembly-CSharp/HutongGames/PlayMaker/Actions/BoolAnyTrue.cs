using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001018")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A0560", Offset = "0x5A0560")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A0560", Offset = "0x5A0560")]
	public class BoolAnyTrue : FsmStateAction
	{
		[Token(Token = "0x4004B85")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DADD8", Offset = "0x5DADD8")]
		[RequiredField]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5DADD8", Offset = "0x5DADD8")]
		public FsmBool[] boolVariables;

		[Token(Token = "0x4004B86")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DAE38", Offset = "0x5DAE38")]
		public FsmEvent sendEvent;

		[Token(Token = "0x4004B87")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DAE70", Offset = "0x5DAE70")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5DAE70", Offset = "0x5DAE70")]
		public FsmBool storeResult;

		[Token(Token = "0x4004B88")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DAEC0", Offset = "0x5DAEC0")]
		public bool everyFrame;

		[Token(Token = "0x600609E")]
		[Address(RVA = "0xA7F2B8", Offset = "0xA7F2B8", VA = "0xA7F2B8", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x600609F")]
		[Address(RVA = "0xA7F2C8", Offset = "0xA7F2C8", VA = "0xA7F2C8", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x60060A0")]
		[Address(RVA = "0xA7F3B4", Offset = "0xA7F3B4", VA = "0xA7F3B4", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x60060A1")]
		[Address(RVA = "0xA7F304", Offset = "0xA7F304", VA = "0xA7F304")]
		private void DoAnyTrue()
		{
		}

		[Token(Token = "0x60060A2")]
		[Address(RVA = "0xA7F3B8", Offset = "0xA7F3B8", VA = "0xA7F3B8")]
		public BoolAnyTrue()
		{
		}
	}
}
