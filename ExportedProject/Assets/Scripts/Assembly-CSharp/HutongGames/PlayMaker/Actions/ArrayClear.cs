using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000F0F")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59B330", Offset = "0x59B330")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59B330", Offset = "0x59B330")]
	public class ArrayClear : FsmStateAction
	{
		[Token(Token = "0x4004726")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C9A2C", Offset = "0x5C9A2C")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5C9A2C", Offset = "0x5C9A2C")]
		public FsmArray array;

		[Token(Token = "0x4004727")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C9A7C", Offset = "0x5C9A7C")]
		[Attribute(Name = "MatchElementTypeAttribute", RVA = "0x5C9A7C", Offset = "0x5C9A7C")]
		public FsmVar resetValue;

		[Token(Token = "0x6005C92")]
		[Address(RVA = "0xD56178", Offset = "0xD56178", VA = "0xD56178", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005C93")]
		[Address(RVA = "0xD561E8", Offset = "0xD561E8", VA = "0xD561E8", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6005C94")]
		[Address(RVA = "0xD562BC", Offset = "0xD562BC", VA = "0xD562BC")]
		public ArrayClear()
		{
		}
	}
}
