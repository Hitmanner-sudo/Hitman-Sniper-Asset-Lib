using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000FA7")]
	[Attribute(Name = "ObsoleteAttribute", RVA = "0x59E188", Offset = "0x59E188")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59E188", Offset = "0x59E188")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59E188", Offset = "0x59E188")]
	public class SetGUITextureAlpha : FsmStateAction
	{
		[Token(Token = "0x40049D5")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "ActionSection", RVA = "0x5D41BC", Offset = "0x5D41BC")]
		public FsmFloat alpha;

		[Token(Token = "0x6005EEF")]
		[Address(RVA = "0x103D874", Offset = "0x103D874", VA = "0x103D874")]
		public SetGUITextureAlpha()
		{
		}
	}
}
