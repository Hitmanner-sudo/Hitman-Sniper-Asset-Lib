using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000F16")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59B520", Offset = "0x59B520")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59B520", Offset = "0x59B520")]
	public class ArrayGetNext : FsmStateAction
	{
		[Token(Token = "0x4004743")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5CA2C0", Offset = "0x5CA2C0")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CA2C0", Offset = "0x5CA2C0")]
		public FsmArray array;

		[Token(Token = "0x4004744")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CA320", Offset = "0x5CA320")]
		public FsmInt startIndex;

		[Token(Token = "0x4004745")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CA358", Offset = "0x5CA358")]
		public FsmInt endIndex;

		[Token(Token = "0x4004746")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CA390", Offset = "0x5CA390")]
		public FsmEvent loopEvent;

		[Token(Token = "0x4004747")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CA3C8", Offset = "0x5CA3C8")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5CA3C8", Offset = "0x5CA3C8")]
		public FsmBool resetFlag;

		[Token(Token = "0x4004748")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CA418", Offset = "0x5CA418")]
		public FsmEvent finishedEvent;

		[Token(Token = "0x4004749")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5CA450", Offset = "0x5CA450")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CA450", Offset = "0x5CA450")]
		[Attribute(Name = "ActionSection", RVA = "0x5CA450", Offset = "0x5CA450")]
		[Attribute(Name = "MatchElementTypeAttribute", RVA = "0x5CA450", Offset = "0x5CA450")]
		public FsmVar result;

		[Token(Token = "0x400474A")]
		[FieldOffset(Offset = "0x88")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5CA4E8", Offset = "0x5CA4E8")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CA4E8", Offset = "0x5CA4E8")]
		public FsmInt currentIndex;

		[Token(Token = "0x400474B")]
		[FieldOffset(Offset = "0x90")]
		private int nextItemIndex;

		[Token(Token = "0x6005CB5")]
		[Address(RVA = "0xBFCFB0", Offset = "0xBFCFB0", VA = "0xBFCFB0", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005CB6")]
		[Address(RVA = "0xBFCFC0", Offset = "0xBFCFC0", VA = "0xBFCFC0", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6005CB7")]
		[Address(RVA = "0xBFD058", Offset = "0xBFD058", VA = "0xBFD058")]
		private void DoGetNextItem()
		{
		}

		[Token(Token = "0x6005CB8")]
		[Address(RVA = "0xBFD1A0", Offset = "0xBFD1A0", VA = "0xBFD1A0")]
		public ArrayGetNext()
		{
		}
	}
}
