using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000FE4")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59F530", Offset = "0x59F530")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59F530", Offset = "0x59F530")]
	public class GetRoot : FsmStateAction
	{
		[Token(Token = "0x4004AB7")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D7880", Offset = "0x5D7880")]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x4004AB8")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5D78CC", Offset = "0x5D78CC")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D78CC", Offset = "0x5D78CC")]
		[RequiredField]
		public FsmGameObject storeRoot;

		[Token(Token = "0x6005FCE")]
		[Address(RVA = "0x1068AA8", Offset = "0x1068AA8", VA = "0x1068AA8", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005FCF")]
		[Address(RVA = "0x1068AB0", Offset = "0x1068AB0", VA = "0x1068AB0", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6005FD0")]
		[Address(RVA = "0x1068AD8", Offset = "0x1068AD8", VA = "0x1068AD8")]
		private void DoGetRoot()
		{
		}

		[Token(Token = "0x6005FD1")]
		[Address(RVA = "0x1068BB0", Offset = "0x1068BB0", VA = "0x1068BB0")]
		public GetRoot()
		{
		}
	}
}
