using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000FE3")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59F4E0", Offset = "0x59F4E0")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59F4E0", Offset = "0x59F4E0")]
	public class GetRandomObject : FsmStateAction
	{
		[Token(Token = "0x4004AB4")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5D7798", Offset = "0x5D7798")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D7798", Offset = "0x5D7798")]
		public FsmString withTag;

		[Token(Token = "0x4004AB5")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D77E8", Offset = "0x5D77E8")]
		[RequiredField]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5D77E8", Offset = "0x5D77E8")]
		public FsmGameObject storeResult;

		[Token(Token = "0x4004AB6")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D7848", Offset = "0x5D7848")]
		public bool everyFrame;

		[Token(Token = "0x6005FC9")]
		[Address(RVA = "0x1067C28", Offset = "0x1067C28", VA = "0x1067C28", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005FCA")]
		[Address(RVA = "0x1067C80", Offset = "0x1067C80", VA = "0x1067C80", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6005FCB")]
		[Address(RVA = "0x1067E7C", Offset = "0x1067E7C", VA = "0x1067E7C", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6005FCC")]
		[Address(RVA = "0x1067CBC", Offset = "0x1067CBC", VA = "0x1067CBC")]
		private void DoGetRandomObject()
		{
		}

		[Token(Token = "0x6005FCD")]
		[Address(RVA = "0x1067E80", Offset = "0x1067E80", VA = "0x1067E80")]
		public GetRandomObject()
		{
		}
	}
}
