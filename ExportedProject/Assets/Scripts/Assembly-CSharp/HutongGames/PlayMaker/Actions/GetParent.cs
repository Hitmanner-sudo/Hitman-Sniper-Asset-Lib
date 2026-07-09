using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000FE1")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59F440", Offset = "0x59F440")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59F440", Offset = "0x59F440")]
	public class GetParent : FsmStateAction
	{
		[Token(Token = "0x4004AB0")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D7650", Offset = "0x5D7650")]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x4004AB1")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D769C", Offset = "0x5D769C")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5D769C", Offset = "0x5D769C")]
		public FsmGameObject storeResult;

		[Token(Token = "0x6005FC2")]
		[Address(RVA = "0x1066FDC", Offset = "0x1066FDC", VA = "0x1066FDC", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005FC3")]
		[Address(RVA = "0x1066FE4", Offset = "0x1066FE4", VA = "0x1066FE4", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6005FC4")]
		[Address(RVA = "0x1067124", Offset = "0x1067124", VA = "0x1067124")]
		public GetParent()
		{
		}
	}
}
