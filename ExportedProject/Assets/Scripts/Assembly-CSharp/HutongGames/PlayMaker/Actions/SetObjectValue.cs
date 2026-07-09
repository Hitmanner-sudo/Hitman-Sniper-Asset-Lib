using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001253")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5AC364", Offset = "0x5AC364")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5AC364", Offset = "0x5AC364")]
	public class SetObjectValue : FsmStateAction
	{
		[Token(Token = "0x40057CA")]
		[FieldOffset(Offset = "0x50")]
		[RequiredField]
		[Attribute(Name = "UIHintAttribute", RVA = "0x609124", Offset = "0x609124")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x609124", Offset = "0x609124")]
		public FsmObject objectVariable;

		[Token(Token = "0x40057CB")]
		[FieldOffset(Offset = "0x58")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x609184", Offset = "0x609184")]
		public FsmObject objectValue;

		[Token(Token = "0x40057CC")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x6091D0", Offset = "0x6091D0")]
		public bool everyFrame;

		[Token(Token = "0x6006B43")]
		[Address(RVA = "0x1041194", Offset = "0x1041194", VA = "0x1041194", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006B44")]
		[Address(RVA = "0x10411A0", Offset = "0x10411A0", VA = "0x10411A0", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006B45")]
		[Address(RVA = "0x10411F8", Offset = "0x10411F8", VA = "0x10411F8", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6006B46")]
		[Address(RVA = "0x1041234", Offset = "0x1041234", VA = "0x1041234")]
		public SetObjectValue()
		{
		}
	}
}
