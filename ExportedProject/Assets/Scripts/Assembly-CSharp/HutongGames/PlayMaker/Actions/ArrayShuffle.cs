using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000F1F")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59B7F0", Offset = "0x59B7F0")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59B7F0", Offset = "0x59B7F0")]
	public class ArrayShuffle : FsmStateAction
	{
		[Token(Token = "0x4004766")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CACE4", Offset = "0x5CACE4")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5CACE4", Offset = "0x5CACE4")]
		[RequiredField]
		public FsmArray array;

		[Token(Token = "0x4004767")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CAD44", Offset = "0x5CAD44")]
		public FsmInt startIndex;

		[Token(Token = "0x4004768")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CAD7C", Offset = "0x5CAD7C")]
		public FsmInt shufflingRange;

		[Token(Token = "0x6005CD8")]
		[Address(RVA = "0xBFDABC", Offset = "0xBFDABC", VA = "0xBFDABC", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005CD9")]
		[Address(RVA = "0xBFDB54", Offset = "0xBFDB54", VA = "0xBFDB54", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6005CDA")]
		[Address(RVA = "0xBFDD88", Offset = "0xBFDD88", VA = "0xBFDD88")]
		public ArrayShuffle()
		{
		}
	}
}
