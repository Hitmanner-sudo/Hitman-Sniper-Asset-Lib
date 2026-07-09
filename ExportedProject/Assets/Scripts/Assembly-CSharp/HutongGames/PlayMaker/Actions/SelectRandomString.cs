using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001190")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A8A04", Offset = "0x5A8A04")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A8A04", Offset = "0x5A8A04")]
	public class SelectRandomString : FsmStateAction
	{
		[Token(Token = "0x4005390")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "CompoundArrayAttribute", RVA = "0x5FA78C", Offset = "0x5FA78C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FA78C", Offset = "0x5FA78C")]
		public FsmString[] strings;

		[Token(Token = "0x4005391")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "HasFloatSliderAttribute", RVA = "0x5FA81C", Offset = "0x5FA81C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FA81C", Offset = "0x5FA81C")]
		public FsmFloat[] weights;

		[Token(Token = "0x4005392")]
		[FieldOffset(Offset = "0x60")]
		[RequiredField]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5FA870", Offset = "0x5FA870")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5FA870", Offset = "0x5FA870")]
		public FsmString storeString;

		[Token(Token = "0x600678D")]
		[Address(RVA = "0xB70244", Offset = "0xB70244", VA = "0xB70244", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x600678E")]
		[Address(RVA = "0xB7038C", Offset = "0xB7038C", VA = "0xB7038C", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x600678F")]
		[Address(RVA = "0xB703B4", Offset = "0xB703B4", VA = "0xB703B4")]
		private void DoSelectRandomString()
		{
		}

		[Token(Token = "0x6006790")]
		[Address(RVA = "0xB70440", Offset = "0xB70440", VA = "0xB70440")]
		public SelectRandomString()
		{
		}
	}
}
