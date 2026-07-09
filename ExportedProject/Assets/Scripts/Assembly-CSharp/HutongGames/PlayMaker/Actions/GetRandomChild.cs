using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000FE2")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59F490", Offset = "0x59F490")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59F490", Offset = "0x59F490")]
	public class GetRandomChild : FsmStateAction
	{
		[Token(Token = "0x4004AB2")]
		[FieldOffset(Offset = "0x50")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D76EC", Offset = "0x5D76EC")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x4004AB3")]
		[FieldOffset(Offset = "0x58")]
		[RequiredField]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5D7738", Offset = "0x5D7738")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D7738", Offset = "0x5D7738")]
		public FsmGameObject storeResult;

		[Token(Token = "0x6005FC5")]
		[Address(RVA = "0x1067AD0", Offset = "0x1067AD0", VA = "0x1067AD0", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005FC6")]
		[Address(RVA = "0x1067AD8", Offset = "0x1067AD8", VA = "0x1067AD8", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6005FC7")]
		[Address(RVA = "0x1067B00", Offset = "0x1067B00", VA = "0x1067B00")]
		private void DoGetRandomChild()
		{
		}

		[Token(Token = "0x6005FC8")]
		[Address(RVA = "0x1067C20", Offset = "0x1067C20", VA = "0x1067C20")]
		public GetRandomChild()
		{
		}
	}
}
