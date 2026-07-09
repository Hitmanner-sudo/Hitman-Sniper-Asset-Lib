using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000F1A")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59B660", Offset = "0x59B660")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59B660", Offset = "0x59B660")]
	public class ArrayRemove : FsmStateAction
	{
		[Token(Token = "0x4004759")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CA8BC", Offset = "0x5CA8BC")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5CA8BC", Offset = "0x5CA8BC")]
		[RequiredField]
		public FsmArray array;

		[Token(Token = "0x400475A")]
		[FieldOffset(Offset = "0x58")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CA91C", Offset = "0x5CA91C")]
		[Attribute(Name = "MatchElementTypeAttribute", RVA = "0x5CA91C", Offset = "0x5CA91C")]
		public FsmVar value;

		[Token(Token = "0x400475B")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CA98C", Offset = "0x5CA98C")]
		public FsmBool allMatches;

		[Token(Token = "0x6005CC6")]
		[Address(RVA = "0xBFD490", Offset = "0xBFD490", VA = "0xBFD490", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005CC7")]
		[Address(RVA = "0xBFD500", Offset = "0xBFD500", VA = "0xBFD500", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6005CC8")]
		[Address(RVA = "0xBFD528", Offset = "0xBFD528", VA = "0xBFD528")]
		private void DoRemoveValue()
		{
		}

		[Token(Token = "0x6005CC9")]
		[Address(RVA = "0xBFD6E0", Offset = "0xBFD6E0", VA = "0xBFD6E0")]
		public ArrayRemove()
		{
		}

		[Token(Token = "0x6005CCA")]
		[Address(RVA = "0xBFD6E8", Offset = "0xBFD6E8", VA = "0xBFD6E8")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x62BF60", Offset = "0x62BF60")]
		private bool _003CDoRemoveValue_003Eb__5_0(object x)
		{
			return default(bool);
		}
	}
}
