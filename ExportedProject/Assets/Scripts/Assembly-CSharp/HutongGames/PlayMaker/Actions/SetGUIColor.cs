using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000FA0")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59DF10", Offset = "0x59DF10")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59DF10", Offset = "0x59DF10")]
	public class SetGUIColor : FsmStateAction
	{
		[Token(Token = "0x40049C8")]
		[FieldOffset(Offset = "0x50")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D3E7C", Offset = "0x5D3E7C")]
		public FsmColor color;

		[Token(Token = "0x40049C9")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D3EC8", Offset = "0x5D3EC8")]
		public FsmBool applyGlobally;

		[Token(Token = "0x6005EDA")]
		[Address(RVA = "0x103D2EC", Offset = "0x103D2EC", VA = "0x103D2EC", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005EDB")]
		[Address(RVA = "0x103D31C", Offset = "0x103D31C", VA = "0x103D31C", Slot = "35")]
		public override void OnGUI()
		{
		}

		[Token(Token = "0x6005EDC")]
		[Address(RVA = "0x103D46C", Offset = "0x103D46C", VA = "0x103D46C")]
		public SetGUIColor()
		{
		}
	}
}
