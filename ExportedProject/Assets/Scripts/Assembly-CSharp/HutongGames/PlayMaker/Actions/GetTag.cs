using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000FE5")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59F580", Offset = "0x59F580")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59F580", Offset = "0x59F580")]
	public class GetTag : FsmStateAction
	{
		[Token(Token = "0x4004AB9")]
		[FieldOffset(Offset = "0x50")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D792C", Offset = "0x5D792C")]
		public FsmGameObject gameObject;

		[Token(Token = "0x4004ABA")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D7978", Offset = "0x5D7978")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5D7978", Offset = "0x5D7978")]
		[RequiredField]
		public FsmString storeResult;

		[Token(Token = "0x4004ABB")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D79D8", Offset = "0x5D79D8")]
		public bool everyFrame;

		[Token(Token = "0x6005FD2")]
		[Address(RVA = "0xC8000C", Offset = "0xC8000C", VA = "0xC8000C", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005FD3")]
		[Address(RVA = "0xC80018", Offset = "0xC80018", VA = "0xC80018", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6005FD4")]
		[Address(RVA = "0xC80108", Offset = "0xC80108", VA = "0xC80108", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6005FD5")]
		[Address(RVA = "0xC80054", Offset = "0xC80054", VA = "0xC80054")]
		private void DoGetTag()
		{
		}

		[Token(Token = "0x6005FD6")]
		[Address(RVA = "0xC8010C", Offset = "0xC8010C", VA = "0xC8010C")]
		public GetTag()
		{
		}
	}
}
