using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000F10")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59B380", Offset = "0x59B380")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59B380", Offset = "0x59B380")]
	public class ArrayCompare : FsmStateAction
	{
		[Token(Token = "0x4004728")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C9ADC", Offset = "0x5C9ADC")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5C9ADC", Offset = "0x5C9ADC")]
		[RequiredField]
		public FsmArray array1;

		[Token(Token = "0x4004729")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C9B3C", Offset = "0x5C9B3C")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5C9B3C", Offset = "0x5C9B3C")]
		[RequiredField]
		public FsmArray array2;

		[Token(Token = "0x400472A")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C9B9C", Offset = "0x5C9B9C")]
		public FsmEvent SequenceEqual;

		[Token(Token = "0x400472B")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C9BD4", Offset = "0x5C9BD4")]
		public FsmEvent SequenceNotEqual;

		[Token(Token = "0x400472C")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C9C0C", Offset = "0x5C9C0C")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5C9C0C", Offset = "0x5C9C0C")]
		public FsmBool storeResult;

		[Token(Token = "0x400472D")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C9C5C", Offset = "0x5C9C5C")]
		public bool everyFrame;

		[Token(Token = "0x6005C95")]
		[Address(RVA = "0xD562C4", Offset = "0xD562C4", VA = "0xD562C4", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005C96")]
		[Address(RVA = "0xD562D0", Offset = "0xD562D0", VA = "0xD562D0", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6005C97")]
		[Address(RVA = "0xD5630C", Offset = "0xD5630C", VA = "0xD5630C")]
		private void DoSequenceEqual()
		{
		}

		[Token(Token = "0x6005C98")]
		[Address(RVA = "0xD563E8", Offset = "0xD563E8", VA = "0xD563E8")]
		private bool TestSequenceEqual(object[] _array1, object[] _array2)
		{
			return default(bool);
		}

		[Token(Token = "0x6005C99")]
		[Address(RVA = "0xD564B4", Offset = "0xD564B4", VA = "0xD564B4")]
		public ArrayCompare()
		{
		}
	}
}
