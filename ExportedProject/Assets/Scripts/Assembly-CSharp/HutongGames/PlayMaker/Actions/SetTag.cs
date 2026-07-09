using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000FEE")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59F850", Offset = "0x59F850")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59F850", Offset = "0x59F850")]
	public class SetTag : FsmStateAction
	{
		[Token(Token = "0x4004AD8")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D823C", Offset = "0x5D823C")]
		public FsmOwnerDefault gameObject;

		[Token(Token = "0x4004AD9")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D8274", Offset = "0x5D8274")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5D8274", Offset = "0x5D8274")]
		public FsmString tag;

		[Token(Token = "0x6005FF8")]
		[Address(RVA = "0x83B21C", Offset = "0x83B21C", VA = "0x83B21C", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005FF9")]
		[Address(RVA = "0x83B274", Offset = "0x83B274", VA = "0x83B274", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6005FFA")]
		[Address(RVA = "0x83B330", Offset = "0x83B330", VA = "0x83B330")]
		public SetTag()
		{
		}
	}
}
