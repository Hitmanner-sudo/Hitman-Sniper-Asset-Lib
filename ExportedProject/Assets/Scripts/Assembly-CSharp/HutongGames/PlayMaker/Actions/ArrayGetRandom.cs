using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000F17")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59B570", Offset = "0x59B570")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59B570", Offset = "0x59B570")]
	public class ArrayGetRandom : FsmStateAction
	{
		[Token(Token = "0x400474C")]
		[FieldOffset(Offset = "0x50")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CA538", Offset = "0x5CA538")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5CA538", Offset = "0x5CA538")]
		public FsmArray array;

		[Token(Token = "0x400474D")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CA598", Offset = "0x5CA598")]
		[Attribute(Name = "MatchElementTypeAttribute", RVA = "0x5CA598", Offset = "0x5CA598")]
		[RequiredField]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5CA598", Offset = "0x5CA598")]
		public FsmVar storeValue;

		[Token(Token = "0x400474E")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CA61C", Offset = "0x5CA61C")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5CA61C", Offset = "0x5CA61C")]
		public FsmInt index;

		[Token(Token = "0x400474F")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CA66C", Offset = "0x5CA66C")]
		public FsmBool noRepeat;

		[Token(Token = "0x4004750")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CA6A4", Offset = "0x5CA6A4")]
		public bool everyFrame;

		[Token(Token = "0x4004751")]
		[FieldOffset(Offset = "0x74")]
		private int randomIndex;

		[Token(Token = "0x4004752")]
		[FieldOffset(Offset = "0x78")]
		private int lastIndex;

		[Token(Token = "0x6005CB9")]
		[Address(RVA = "0xBFD1A8", Offset = "0xBFD1A8", VA = "0xBFD1A8", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005CBA")]
		[Address(RVA = "0xBFD1E0", Offset = "0xBFD1E0", VA = "0xBFD1E0", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6005CBB")]
		[Address(RVA = "0xBFD328", Offset = "0xBFD328", VA = "0xBFD328", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6005CBC")]
		[Address(RVA = "0xBFD21C", Offset = "0xBFD21C", VA = "0xBFD21C")]
		private void DoGetRandomValue()
		{
		}

		[Token(Token = "0x6005CBD")]
		[Address(RVA = "0xBFD32C", Offset = "0xBFD32C", VA = "0xBFD32C")]
		public ArrayGetRandom()
		{
		}
	}
}
