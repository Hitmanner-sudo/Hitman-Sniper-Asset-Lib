using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000F54")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59C960", Offset = "0x59C960")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59C960", Offset = "0x59C960")]
	public class SetColorValue : FsmStateAction
	{
		[Token(Token = "0x400487C")]
		[FieldOffset(Offset = "0x50")]
		[RequiredField]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5CF34C", Offset = "0x5CF34C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CF34C", Offset = "0x5CF34C")]
		public FsmColor colorVariable;

		[Token(Token = "0x400487D")]
		[FieldOffset(Offset = "0x58")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CF3AC", Offset = "0x5CF3AC")]
		public FsmColor color;

		[Token(Token = "0x400487E")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5CF3F8", Offset = "0x5CF3F8")]
		public bool everyFrame;

		[Token(Token = "0x6005DBA")]
		[Address(RVA = "0x1038BE8", Offset = "0x1038BE8", VA = "0x1038BE8", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005DBB")]
		[Address(RVA = "0x1038BF4", Offset = "0x1038BF4", VA = "0x1038BF4", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6005DBC")]
		[Address(RVA = "0x1038C58", Offset = "0x1038C58", VA = "0x1038C58", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6005DBD")]
		[Address(RVA = "0x1038C30", Offset = "0x1038C30", VA = "0x1038C30")]
		private void DoSetColorValue()
		{
		}

		[Token(Token = "0x6005DBE")]
		[Address(RVA = "0x1038C5C", Offset = "0x1038C5C", VA = "0x1038C5C")]
		public SetColorValue()
		{
		}
	}
}
