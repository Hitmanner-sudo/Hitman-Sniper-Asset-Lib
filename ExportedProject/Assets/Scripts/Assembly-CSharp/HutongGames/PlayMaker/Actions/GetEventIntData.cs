using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x200114E")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A67CC", Offset = "0x5A67CC")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A67CC", Offset = "0x5A67CC")]
	public class GetEventIntData : FsmStateAction
	{
		[Token(Token = "0x400521D")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5F5F88", Offset = "0x5F5F88")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F5F88", Offset = "0x5F5F88")]
		public FsmInt getIntData;

		[Token(Token = "0x6006654")]
		[Address(RVA = "0x105FFAC", Offset = "0x105FFAC", VA = "0x105FFAC", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006655")]
		[Address(RVA = "0x105FFB4", Offset = "0x105FFB4", VA = "0x105FFB4", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006656")]
		[Address(RVA = "0x1060044", Offset = "0x1060044", VA = "0x1060044")]
		public GetEventIntData()
		{
		}
	}
}
