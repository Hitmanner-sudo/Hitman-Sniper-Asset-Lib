using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x20010DD")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x5A452C", Offset = "0x5A452C")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x5A452C", Offset = "0x5A452C")]
	public class SetRectValue : FsmStateAction
	{
		[Token(Token = "0x4004FA0")]
		[FieldOffset(Offset = "0x50")]
		[RequiredField]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5EC8F4", Offset = "0x5EC8F4")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5EC8F4", Offset = "0x5EC8F4")]
		public FsmRect rectVariable;

		[Token(Token = "0x4004FA1")]
		[FieldOffset(Offset = "0x58")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5EC954", Offset = "0x5EC954")]
		public FsmRect rectValue;

		[Token(Token = "0x4004FA2")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5EC9A0", Offset = "0x5EC9A0")]
		public bool everyFrame;

		[Token(Token = "0x600647D")]
		[Address(RVA = "0x10442E8", Offset = "0x10442E8", VA = "0x10442E8", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x600647E")]
		[Address(RVA = "0x10442F4", Offset = "0x10442F4", VA = "0x10442F4", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x600647F")]
		[Address(RVA = "0x1044334", Offset = "0x1044334", VA = "0x1044334", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6006480")]
		[Address(RVA = "0x1044360", Offset = "0x1044360", VA = "0x1044360")]
		public SetRectValue()
		{
		}
	}
}
