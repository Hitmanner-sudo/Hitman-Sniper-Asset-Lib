using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000FA8")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59E1FC", Offset = "0x59E1FC")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59E1FC", Offset = "0x59E1FC")]
	[Attribute(Name = "ObsoleteAttribute", RVA = "0x59E1FC", Offset = "0x59E1FC")]
	public class SetGUITextureColor : FsmStateAction
	{
		[Token(Token = "0x40049D6")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "ActionSection", RVA = "0x5D41F4", Offset = "0x5D41F4")]
		public FsmColor color;

		[Token(Token = "0x6005EF0")]
		[Address(RVA = "0x103D87C", Offset = "0x103D87C", VA = "0x103D87C")]
		public SetGUITextureColor()
		{
		}
	}
}
