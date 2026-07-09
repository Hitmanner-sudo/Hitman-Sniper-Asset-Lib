using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000FFB")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59FC78", Offset = "0x59FC78")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59FC78", Offset = "0x59FC78")]
	public class GetMouseButton : FsmStateAction
	{
		[Token(Token = "0x4004B04")]
		[FieldOffset(Offset = "0x4C")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D8CA0", Offset = "0x5D8CA0")]
		public MouseButton button;

		[Token(Token = "0x4004B05")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D8CEC", Offset = "0x5D8CEC")]
		[RequiredField]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5D8CEC", Offset = "0x5D8CEC")]
		public FsmBool storeResult;

		[Token(Token = "0x4004B06")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D8D4C", Offset = "0x5D8D4C")]
		public bool everyFrame;

		[Token(Token = "0x6006024")]
		[Address(RVA = "0x10648F0", Offset = "0x10648F0", VA = "0x10648F0", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006025")]
		[Address(RVA = "0x1064904", Offset = "0x1064904", VA = "0x1064904", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006026")]
		[Address(RVA = "0x1064978", Offset = "0x1064978", VA = "0x1064978", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6006027")]
		[Address(RVA = "0x1064940", Offset = "0x1064940", VA = "0x1064940")]
		private void DoGetMouseButton()
		{
		}

		[Token(Token = "0x6006028")]
		[Address(RVA = "0x106497C", Offset = "0x106497C", VA = "0x106497C")]
		public GetMouseButton()
		{
		}
	}
}
