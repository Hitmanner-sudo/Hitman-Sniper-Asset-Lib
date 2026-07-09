using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000FA5")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59E0A0", Offset = "0x59E0A0")]
	[Attribute(Name = "ObsoleteAttribute", RVA = "0x59E0A0", Offset = "0x59E0A0")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59E0A0", Offset = "0x59E0A0")]
	public class SetGUIText : FsmStateAction
	{
		[Token(Token = "0x40049D3")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "ActionSection", RVA = "0x5D4134", Offset = "0x5D4134")]
		[Attribute(Name = "UIHintAttribute", RVA = "0x5D4134", Offset = "0x5D4134")]
		public FsmString text;

		[Token(Token = "0x6005EED")]
		[Address(RVA = "0x103D864", Offset = "0x103D864", VA = "0x103D864")]
		public SetGUIText()
		{
		}
	}
}
