using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000FA4")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59E050", Offset = "0x59E050")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59E050", Offset = "0x59E050")]
	public class SetMouseCursor : FsmStateAction
	{
		[Token(Token = "0x40049CF")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D4054", Offset = "0x5D4054")]
		public FsmTexture cursorTexture;

		[Token(Token = "0x40049D0")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D408C", Offset = "0x5D408C")]
		public FsmBool hideCursor;

		[Token(Token = "0x40049D1")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D40C4", Offset = "0x5D40C4")]
		public FsmBool lockCursor;

		[Token(Token = "0x40049D2")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D40FC", Offset = "0x5D40FC")]
		public bool everyFrame;

		[Token(Token = "0x6005EE7")]
		[Address(RVA = "0x1040C88", Offset = "0x1040C88", VA = "0x1040C88", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005EE8")]
		[Address(RVA = "0x1040CCC", Offset = "0x1040CCC", VA = "0x1040CCC", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6005EE9")]
		[Address(RVA = "0x1040E70", Offset = "0x1040E70", VA = "0x1040E70")]
		private void UpdateCursorState()
		{
		}

		[Token(Token = "0x6005EEA")]
		[Address(RVA = "0x1040EC8", Offset = "0x1040EC8", VA = "0x1040EC8", Slot = "34")]
		public override void OnUpdate()
		{
		}

		[Token(Token = "0x6005EEB")]
		[Address(RVA = "0x1040ECC", Offset = "0x1040ECC", VA = "0x1040ECC", Slot = "35")]
		public override void OnGUI()
		{
		}

		[Token(Token = "0x6005EEC")]
		[Address(RVA = "0x1041098", Offset = "0x1041098", VA = "0x1041098")]
		public SetMouseCursor()
		{
		}
	}
}
