using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001019")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A05B0", Offset = "0x5A05B0")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A05B0", Offset = "0x5A05B0")]
	public class BoolChanged : FsmStateAction
	{
		[Token(Token = "0x4004B89")]
		[FieldOffset(Offset = "0x50")]
		[RequiredField]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5DAEF8", Offset = "0x5DAEF8")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DAEF8", Offset = "0x5DAEF8")]
		public FsmBool boolVariable;

		[Token(Token = "0x4004B8A")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DAF58", Offset = "0x5DAF58")]
		public FsmEvent changedEvent;

		[Token(Token = "0x4004B8B")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5DAF90", Offset = "0x5DAF90")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5DAF90", Offset = "0x5DAF90")]
		public FsmBool storeResult;

		[Token(Token = "0x4004B8C")]
		[FieldOffset(Offset = "0x68")]
		private bool previousValue;

		[Token(Token = "0x60060A3")]
		[Address(RVA = "0xA7F3C0", Offset = "0xA7F3C0", VA = "0xA7F3C0", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x60060A4")]
		[Address(RVA = "0xA7F3CC", Offset = "0xA7F3CC", VA = "0xA7F3CC", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x60060A5")]
		[Address(RVA = "0xA7F42C", Offset = "0xA7F42C", VA = "0xA7F42C", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x60060A6")]
		[Address(RVA = "0xA7F4A8", Offset = "0xA7F4A8", VA = "0xA7F4A8")]
		public BoolChanged()
		{
		}
	}
}
