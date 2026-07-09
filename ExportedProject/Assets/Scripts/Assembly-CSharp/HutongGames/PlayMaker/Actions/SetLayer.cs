using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000FEB")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59F760", Offset = "0x59F760")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59F760", Offset = "0x59F760")]
	public class SetLayer : FsmStateAction
	{
		[Token(Token = "0x4004ACF")]
		[FieldOffset(Offset = "0x50")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D7FDC", Offset = "0x5D7FDC")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x4004AD0")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D8028", Offset = "0x5D8028")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5D8028", Offset = "0x5D8028")]
		public int layer;

		[Token(Token = "0x6005FED")]
		[Address(RVA = "0x103EBC8", Offset = "0x103EBC8", VA = "0x103EBC8", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005FEE")]
		[Address(RVA = "0x103EBD4", Offset = "0x103EBD4", VA = "0x103EBD4", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6005FEF")]
		[Address(RVA = "0x103EBFC", Offset = "0x103EBFC", VA = "0x103EBFC")]
		private void DoSetLayer()
		{
		}

		[Token(Token = "0x6005FF0")]
		[Address(RVA = "0x103ECA8", Offset = "0x103ECA8", VA = "0x103ECA8")]
		public SetLayer()
		{
		}
	}
}
