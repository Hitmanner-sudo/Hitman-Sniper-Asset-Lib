using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000FA6")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59E114", Offset = "0x59E114")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59E114", Offset = "0x59E114")]
	[Attribute(Name = "ObsoleteAttribute", RVA = "0x59E114", Offset = "0x59E114")]
	public class SetGUITexture : FsmStateAction
	{
		[Token(Token = "0x40049D4")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "ActionSection", RVA = "0x5D4184", Offset = "0x5D4184")]
		public FsmTexture texture;

		[Token(Token = "0x6005EEE")]
		[Address(RVA = "0x103D86C", Offset = "0x103D86C", VA = "0x103D86C")]
		public SetGUITexture()
		{
		}
	}
}
