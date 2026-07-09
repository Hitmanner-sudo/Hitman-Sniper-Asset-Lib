using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000FC2")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59EA28", Offset = "0x59EA28")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59EA28", Offset = "0x59EA28")]
	public class GUILayoutSpace : FsmStateAction
	{
		[Token(Token = "0x4004A2C")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D5640", Offset = "0x5D5640")]
		public FsmFloat space;

		[Token(Token = "0x6005F3C")]
		[Address(RVA = "0xD91BF4", Offset = "0xD91BF4", VA = "0xD91BF4", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005F3D")]
		[Address(RVA = "0xD91C20", Offset = "0xD91C20", VA = "0xD91C20", Slot = "35")]
		public override void OnGUI()
		{
		}

		[Token(Token = "0x6005F3E")]
		[Address(RVA = "0xD91C48", Offset = "0xD91C48", VA = "0xD91C48")]
		public GUILayoutSpace()
		{
		}
	}
}
