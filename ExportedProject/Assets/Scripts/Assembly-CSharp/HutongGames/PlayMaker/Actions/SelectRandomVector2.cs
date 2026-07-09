using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2001258")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5AC4F4", Offset = "0x5AC4F4")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5AC4F4", Offset = "0x5AC4F4")]
	public class SelectRandomVector2 : FsmStateAction
	{
		[Token(Token = "0x40057D9")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "CompoundArrayAttribute", RVA = "0x609498", Offset = "0x609498")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x609498", Offset = "0x609498")]
		public FsmVector2[] vector2Array;

		[Token(Token = "0x40057DA")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x609528", Offset = "0x609528")]
		[Attribute(Name = "HasFloatSliderAttribute", RVA = "0x609528", Offset = "0x609528")]
		public FsmFloat[] weights;

		[Token(Token = "0x40057DB")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x60957C", Offset = "0x60957C")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x60957C", Offset = "0x60957C")]
		[RequiredField]
		public FsmVector2 storeVector2;

		[Token(Token = "0x6006B5A")]
		[Address(RVA = "0xB70448", Offset = "0xB70448", VA = "0xB70448", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006B5B")]
		[Address(RVA = "0xB70590", Offset = "0xB70590", VA = "0xB70590", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006B5C")]
		[Address(RVA = "0xB705B8", Offset = "0xB705B8", VA = "0xB705B8")]
		private void DoSelectRandom()
		{
		}

		[Token(Token = "0x6006B5D")]
		[Address(RVA = "0xB70640", Offset = "0xB70640", VA = "0xB70640")]
		public SelectRandomVector2()
		{
		}
	}
}
