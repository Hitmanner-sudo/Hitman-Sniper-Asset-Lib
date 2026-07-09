using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x200114B")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A66B8", Offset = "0x5A66B8")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A66B8", Offset = "0x5A66B8")]
	public class GetEventBoolData : FsmStateAction
	{
		[Token(Token = "0x400520C")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5F5A38", Offset = "0x5F5A38")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5F5A38", Offset = "0x5F5A38")]
		public FsmBool getBoolData;

		[Token(Token = "0x600664B")]
		[Address(RVA = "0x105FAB4", Offset = "0x105FAB4", VA = "0x105FAB4", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x600664C")]
		[Address(RVA = "0x105FABC", Offset = "0x105FABC", VA = "0x105FABC", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x600664D")]
		[Address(RVA = "0x105FB4C", Offset = "0x105FB4C", VA = "0x105FB4C")]
		public GetEventBoolData()
		{
		}
	}
}
