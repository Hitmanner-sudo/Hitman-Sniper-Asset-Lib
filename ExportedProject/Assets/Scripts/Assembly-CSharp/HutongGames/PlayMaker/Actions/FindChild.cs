using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000FD5")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59F080", Offset = "0x59F080")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59F080", Offset = "0x59F080")]
	public class FindChild : FsmStateAction
	{
		[Token(Token = "0x4004A7C")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D683C", Offset = "0x5D683C")]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x4004A7D")]
		[FieldOffset(Offset = "0x58")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D6888", Offset = "0x5D6888")]
		public FsmString childName;

		[Token(Token = "0x4004A7E")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D68D4", Offset = "0x5D68D4")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5D68D4", Offset = "0x5D68D4")]
		[RequiredField]
		public FsmGameObject storeResult;

		[Token(Token = "0x6005F8A")]
		[Address(RVA = "0x954A24", Offset = "0x954A24", VA = "0x954A24", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005F8B")]
		[Address(RVA = "0x954A7C", Offset = "0x954A7C", VA = "0x954A7C", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6005F8C")]
		[Address(RVA = "0x954AA4", Offset = "0x954AA4", VA = "0x954AA4")]
		private void DoFindChild()
		{
		}

		[Token(Token = "0x6005F8D")]
		[Address(RVA = "0x954BE4", Offset = "0x954BE4", VA = "0x954BE4")]
		public FindChild()
		{
		}
	}
}
