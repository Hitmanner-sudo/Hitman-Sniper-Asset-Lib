using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x200101D")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A06A0", Offset = "0x5A06A0")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A06A0", Offset = "0x5A06A0")]
	public class BoolTest : FsmStateAction
	{
		[Token(Token = "0x4004B9B")]
		[FieldOffset(Offset = "0x50")]
		[Readonly]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DB268", Offset = "0x5DB268")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5DB268", Offset = "0x5DB268")]
		public FsmBool boolVariable;

		[Token(Token = "0x4004B9C")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DB2D8", Offset = "0x5DB2D8")]
		public FsmEvent isTrue;

		[Token(Token = "0x4004B9D")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DB310", Offset = "0x5DB310")]
		public FsmEvent isFalse;

		[Token(Token = "0x4004B9E")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DB348", Offset = "0x5DB348")]
		public bool everyFrame;

		[Token(Token = "0x60060B1")]
		[Address(RVA = "0xA7F74C", Offset = "0xA7F74C", VA = "0xA7F74C", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x60060B2")]
		[Address(RVA = "0xA7F75C", Offset = "0xA7F75C", VA = "0xA7F75C", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x60060B3")]
		[Address(RVA = "0xA7F7D0", Offset = "0xA7F7D0", VA = "0xA7F7D0", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x60060B4")]
		[Address(RVA = "0xA7F824", Offset = "0xA7F824", VA = "0xA7F824")]
		public BoolTest()
		{
		}
	}
}
