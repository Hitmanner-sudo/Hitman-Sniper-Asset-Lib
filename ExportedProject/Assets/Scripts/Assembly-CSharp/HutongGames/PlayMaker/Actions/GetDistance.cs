using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000FDB")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59F260", Offset = "0x59F260")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59F260", Offset = "0x59F260")]
	public class GetDistance : FsmStateAction
	{
		[Token(Token = "0x4004A93")]
		[FieldOffset(Offset = "0x50")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D6F20", Offset = "0x5D6F20")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x4004A94")]
		[FieldOffset(Offset = "0x58")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D6F6C", Offset = "0x5D6F6C")]
		public FsmGameObject target;

		[Token(Token = "0x4004A95")]
		[FieldOffset(Offset = "0x60")]
		[RequiredField]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5D6FB8", Offset = "0x5D6FB8")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D6FB8", Offset = "0x5D6FB8")]
		public FsmFloat storeResult;

		[Token(Token = "0x4004A96")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D7018", Offset = "0x5D7018")]
		public bool everyFrame;

		[Token(Token = "0x6005FA6")]
		[Address(RVA = "0x105F52C", Offset = "0x105F52C", VA = "0x105F52C", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005FA7")]
		[Address(RVA = "0x105F540", Offset = "0x105F540", VA = "0x105F540", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6005FA8")]
		[Address(RVA = "0x105F6E4", Offset = "0x105F6E4", VA = "0x105F6E4", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6005FA9")]
		[Address(RVA = "0x105F57C", Offset = "0x105F57C", VA = "0x105F57C")]
		private void DoGetDistance()
		{
		}

		[Token(Token = "0x6005FAA")]
		[Address(RVA = "0x105F6E8", Offset = "0x105F6E8", VA = "0x105F6E8")]
		public GetDistance()
		{
		}
	}
}
