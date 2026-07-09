using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000F0B")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59B1F0", Offset = "0x59B1F0")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59B1F0", Offset = "0x59B1F0")]
	public class ArrayAdd : FsmStateAction
	{
		[Token(Token = "0x400471D")]
		[FieldOffset(Offset = "0x50")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C9734", Offset = "0x5C9734")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5C9734", Offset = "0x5C9734")]
		public FsmArray array;

		[Token(Token = "0x400471E")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "MatchElementTypeAttribute", RVA = "0x5C9794", Offset = "0x5C9794")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C9794", Offset = "0x5C9794")]
		[RequiredField]
		public FsmVar value;

		[Token(Token = "0x6005C81")]
		[Address(RVA = "0xD55C9C", Offset = "0xD55C9C", VA = "0xD55C9C", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005C82")]
		[Address(RVA = "0xD55CA4", Offset = "0xD55CA4", VA = "0xD55CA4", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6005C83")]
		[Address(RVA = "0xD55CCC", Offset = "0xD55CCC", VA = "0xD55CCC")]
		private void DoAddValue()
		{
		}

		[Token(Token = "0x6005C84")]
		[Address(RVA = "0xD55D5C", Offset = "0xD55D5C", VA = "0xD55D5C")]
		public ArrayAdd()
		{
		}
	}
}
