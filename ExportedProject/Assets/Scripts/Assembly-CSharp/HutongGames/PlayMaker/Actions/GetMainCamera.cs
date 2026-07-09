using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000F3C")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59C1C8", Offset = "0x59C1C8")]
	[Attribute(Name = "ActionTarget", RVA = "0x59C1C8", Offset = "0x59C1C8")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59C1C8", Offset = "0x59C1C8")]
	public class GetMainCamera : FsmStateAction
	{
		[Token(Token = "0x40047E3")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5CCA90", Offset = "0x5CCA90")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CCA90", Offset = "0x5CCA90")]
		[RequiredField]
		public FsmGameObject storeGameObject;

		[Token(Token = "0x6005D46")]
		[Address(RVA = "0x1063CFC", Offset = "0x1063CFC", VA = "0x1063CFC", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005D47")]
		[Address(RVA = "0x1063D04", Offset = "0x1063D04", VA = "0x1063D04", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6005D48")]
		[Address(RVA = "0x1063DC8", Offset = "0x1063DC8", VA = "0x1063DC8")]
		public GetMainCamera()
		{
		}
	}
}
