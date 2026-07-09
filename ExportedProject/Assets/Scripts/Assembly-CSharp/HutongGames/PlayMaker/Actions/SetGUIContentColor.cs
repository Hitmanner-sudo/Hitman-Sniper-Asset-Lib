using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000FA1")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59DF60", Offset = "0x59DF60")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59DF60", Offset = "0x59DF60")]
	public class SetGUIContentColor : FsmStateAction
	{
		[Token(Token = "0x40049CA")]
		[FieldOffset(Offset = "0x50")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D3F00", Offset = "0x5D3F00")]
		public FsmColor contentColor;

		[Token(Token = "0x40049CB")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D3F4C", Offset = "0x5D3F4C")]
		public FsmBool applyGlobally;

		[Token(Token = "0x6005EDD")]
		[Address(RVA = "0x103D474", Offset = "0x103D474", VA = "0x103D474", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005EDE")]
		[Address(RVA = "0x103D4A4", Offset = "0x103D4A4", VA = "0x103D4A4", Slot = "35")]
		public override void OnGUI()
		{
		}

		[Token(Token = "0x6005EDF")]
		[Address(RVA = "0x103D5F4", Offset = "0x103D5F4", VA = "0x103D5F4")]
		public SetGUIContentColor()
		{
		}
	}
}
