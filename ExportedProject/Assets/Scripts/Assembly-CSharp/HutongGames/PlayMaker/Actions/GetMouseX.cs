using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000FFE")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59FD68", Offset = "0x59FD68")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59FD68", Offset = "0x59FD68")]
	public class GetMouseX : FsmStateAction
	{
		[Token(Token = "0x4004B0F")]
		[FieldOffset(Offset = "0x50")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D8F9C", Offset = "0x5D8F9C")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5D8F9C", Offset = "0x5D8F9C")]
		public FsmFloat storeResult;

		[Token(Token = "0x4004B10")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D8FFC", Offset = "0x5D8FFC")]
		public bool normalize;

		[Token(Token = "0x4004B11")]
		[FieldOffset(Offset = "0x59")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D9034", Offset = "0x5D9034")]
		public bool everyFrame;

		[Token(Token = "0x6006033")]
		[Address(RVA = "0x1064AA4", Offset = "0x1064AA4", VA = "0x1064AA4", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6006034")]
		[Address(RVA = "0x1064AB4", Offset = "0x1064AB4", VA = "0x1064AB4", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6006035")]
		[Address(RVA = "0x1064B50", Offset = "0x1064B50", VA = "0x1064B50", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6006036")]
		[Address(RVA = "0x1064AF0", Offset = "0x1064AF0", VA = "0x1064AF0")]
		private void DoGetMouseX()
		{
		}

		[Token(Token = "0x6006037")]
		[Address(RVA = "0x1064B54", Offset = "0x1064B54", VA = "0x1064B54")]
		public GetMouseX()
		{
		}
	}
}
