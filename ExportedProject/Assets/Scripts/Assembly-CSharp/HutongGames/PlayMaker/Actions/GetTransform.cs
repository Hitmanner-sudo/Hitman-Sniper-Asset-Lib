using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000FE7")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59F620", Offset = "0x59F620")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59F620", Offset = "0x59F620")]
	public class GetTransform : FsmStateAction
	{
		[Token(Token = "0x4004ABE")]
		[FieldOffset(Offset = "0x50")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D7AC0", Offset = "0x5D7AC0")]
		public FsmGameObject gameObject;

		[Token(Token = "0x4004ABF")]
		[FieldOffset(Offset = "0x58")]
		[RequiredField]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5D7B0C", Offset = "0x5D7B0C")]
		[Attribute(Name = "ObjectTypeAttribute", RVA = "0x5D7B0C", Offset = "0x5D7B0C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D7B0C", Offset = "0x5D7B0C")]
		public FsmObject storeTransform;

		[Token(Token = "0x4004AC0")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D7BB4", Offset = "0x5D7BB4")]
		public bool everyFrame;

		[Token(Token = "0x6005FDA")]
		[Address(RVA = "0xC8084C", Offset = "0xC8084C", VA = "0xC8084C", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005FDB")]
		[Address(RVA = "0xC808BC", Offset = "0xC808BC", VA = "0xC808BC", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6005FDC")]
		[Address(RVA = "0xC809A8", Offset = "0xC809A8", VA = "0xC809A8", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6005FDD")]
		[Address(RVA = "0xC808F8", Offset = "0xC808F8", VA = "0xC808F8")]
		private void DoGetGameObjectName()
		{
		}

		[Token(Token = "0x6005FDE")]
		[Address(RVA = "0xC809AC", Offset = "0xC809AC", VA = "0xC809AC")]
		public GetTransform()
		{
		}
	}
}
