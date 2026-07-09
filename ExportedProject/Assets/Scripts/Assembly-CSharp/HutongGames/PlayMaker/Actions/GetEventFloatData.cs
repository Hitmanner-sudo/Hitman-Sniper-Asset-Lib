using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x200114C")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A6708", Offset = "0x5A6708")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A6708", Offset = "0x5A6708")]
	public class GetEventFloatData : FsmStateAction
	{
		[Token(Token = "0x400520D")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F5A88", Offset = "0x5F5A88")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5F5A88", Offset = "0x5F5A88")]
		public FsmFloat getFloatData;

		[Token(Token = "0x600664E")]
		[Address(RVA = "0x105FB54", Offset = "0x105FB54", VA = "0x105FB54", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x600664F")]
		[Address(RVA = "0x105FB5C", Offset = "0x105FB5C", VA = "0x105FB5C", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006650")]
		[Address(RVA = "0x105FBEC", Offset = "0x105FBEC", VA = "0x105FBEC")]
		public GetEventFloatData()
		{
		}
	}
}
