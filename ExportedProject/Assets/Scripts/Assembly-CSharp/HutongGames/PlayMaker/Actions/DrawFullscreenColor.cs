using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000F8F")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59D9CC", Offset = "0x59D9CC")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59D9CC", Offset = "0x59D9CC")]
	public class DrawFullscreenColor : FsmStateAction
	{
		[Token(Token = "0x4004987")]
		[FieldOffset(Offset = "0x50")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D2F30", Offset = "0x5D2F30")]
		public FsmColor color;

		[Token(Token = "0x6005EA8")]
		[Address(RVA = "0xC1FAEC", Offset = "0xC1FAEC", VA = "0xC1FAEC", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005EA9")]
		[Address(RVA = "0xC1FB1C", Offset = "0xC1FB1C", VA = "0xC1FB1C", Slot = "35")]
		public override void OnGUI()
		{
		}

		[Token(Token = "0x6005EAA")]
		[Address(RVA = "0xC1FC28", Offset = "0xC1FC28", VA = "0xC1FC28")]
		public DrawFullscreenColor()
		{
		}
	}
}
