using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000F18")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59B5C0", Offset = "0x59B5C0")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59B5C0", Offset = "0x59B5C0")]
	public class ArrayInsert : FsmStateAction
	{
		[Token(Token = "0x4004753")]
		[FieldOffset(Offset = "0x50")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CA6DC", Offset = "0x5CA6DC")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5CA6DC", Offset = "0x5CA6DC")]
		public FsmArray array;

		[Token(Token = "0x4004754")]
		[FieldOffset(Offset = "0x58")]
		[RequiredField]
		[Attribute(Name = "MatchElementTypeAttribute", RVA = "0x5CA73C", Offset = "0x5CA73C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CA73C", Offset = "0x5CA73C")]
		public FsmVar value;

		[Token(Token = "0x4004755")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CA7AC", Offset = "0x5CA7AC")]
		public FsmInt atIndex;

		[Token(Token = "0x6005CBE")]
		[Address(RVA = "0xBFD33C", Offset = "0xBFD33C", VA = "0xBFD33C", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005CBF")]
		[Address(RVA = "0xBFD348", Offset = "0xBFD348", VA = "0xBFD348", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6005CC0")]
		[Address(RVA = "0xBFD370", Offset = "0xBFD370", VA = "0xBFD370")]
		private void DoInsertValue()
		{
		}

		[Token(Token = "0x6005CC1")]
		[Address(RVA = "0xBFD3E0", Offset = "0xBFD3E0", VA = "0xBFD3E0")]
		public ArrayInsert()
		{
		}
	}
}
