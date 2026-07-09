using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000FDE")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59F350", Offset = "0x59F350")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59F350", Offset = "0x59F350")]
	public class GetName : FsmStateAction
	{
		[Token(Token = "0x4004AA5")]
		[FieldOffset(Offset = "0x50")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D73A0", Offset = "0x5D73A0")]
		public FsmGameObject gameObject;

		[Token(Token = "0x4004AA6")]
		[FieldOffset(Offset = "0x58")]
		[RequiredField]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5D73EC", Offset = "0x5D73EC")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D73EC", Offset = "0x5D73EC")]
		public FsmString storeName;

		[Token(Token = "0x4004AA7")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D744C", Offset = "0x5D744C")]
		public bool everyFrame;

		[Token(Token = "0x6005FB6")]
		[Address(RVA = "0x1064C14", Offset = "0x1064C14", VA = "0x1064C14", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005FB7")]
		[Address(RVA = "0x1064C84", Offset = "0x1064C84", VA = "0x1064C84", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6005FB8")]
		[Address(RVA = "0x1064D88", Offset = "0x1064D88", VA = "0x1064D88", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6005FB9")]
		[Address(RVA = "0x1064CC0", Offset = "0x1064CC0", VA = "0x1064CC0")]
		private void DoGetGameObjectName()
		{
		}

		[Token(Token = "0x6005FBA")]
		[Address(RVA = "0x1064D8C", Offset = "0x1064D8C", VA = "0x1064D8C")]
		public GetName()
		{
		}
	}
}
