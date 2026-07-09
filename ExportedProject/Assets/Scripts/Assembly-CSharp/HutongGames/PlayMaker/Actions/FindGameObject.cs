using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000FD7")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59F120", Offset = "0x59F120")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59F120", Offset = "0x59F120")]
	public class FindGameObject : FsmStateAction
	{
		[Token(Token = "0x4004A86")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D6B28", Offset = "0x5D6B28")]
		public FsmString objectName;

		[Token(Token = "0x4004A87")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D6B60", Offset = "0x5D6B60")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5D6B60", Offset = "0x5D6B60")]
		public FsmString withTag;

		[Token(Token = "0x4004A88")]
		[FieldOffset(Offset = "0x60")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D6BB0", Offset = "0x5D6BB0")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5D6BB0", Offset = "0x5D6BB0")]
		public FsmGameObject store;

		[Token(Token = "0x6005F93")]
		[Address(RVA = "0x955028", Offset = "0x955028", VA = "0x955028", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005F94")]
		[Address(RVA = "0x9550A0", Offset = "0x9550A0", VA = "0x9550A0", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6005F95")]
		[Address(RVA = "0x9550C8", Offset = "0x9550C8", VA = "0x9550C8")]
		private void Find()
		{
		}

		[Token(Token = "0x6005F96")]
		[Address(RVA = "0x955264", Offset = "0x955264", VA = "0x955264", Slot = "61")]
		public override string ErrorCheck()
		{
			return null;
		}

		[Token(Token = "0x6005F97")]
		[Address(RVA = "0x9552F4", Offset = "0x9552F4", VA = "0x9552F4")]
		public FindGameObject()
		{
		}
	}
}
