using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000FDD")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59F300", Offset = "0x59F300")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59F300", Offset = "0x59F300")]
	public class GetLayer : FsmStateAction
	{
		[Token(Token = "0x4004AA2")]
		[FieldOffset(Offset = "0x50")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D72BC", Offset = "0x5D72BC")]
		public FsmGameObject gameObject;

		[Token(Token = "0x4004AA3")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5D7308", Offset = "0x5D7308")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D7308", Offset = "0x5D7308")]
		[RequiredField]
		public FsmInt storeResult;

		[Token(Token = "0x4004AA4")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D7368", Offset = "0x5D7368")]
		public bool everyFrame;

		[Token(Token = "0x6005FB1")]
		[Address(RVA = "0x1063BF4", Offset = "0x1063BF4", VA = "0x1063BF4", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005FB2")]
		[Address(RVA = "0x1063C00", Offset = "0x1063C00", VA = "0x1063C00", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6005FB3")]
		[Address(RVA = "0x1063CF0", Offset = "0x1063CF0", VA = "0x1063CF0", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6005FB4")]
		[Address(RVA = "0x1063C3C", Offset = "0x1063C3C", VA = "0x1063C3C")]
		private void DoGetLayer()
		{
		}

		[Token(Token = "0x6005FB5")]
		[Address(RVA = "0x1063CF4", Offset = "0x1063CF4", VA = "0x1063CF4")]
		public GetLayer()
		{
		}
	}
}
