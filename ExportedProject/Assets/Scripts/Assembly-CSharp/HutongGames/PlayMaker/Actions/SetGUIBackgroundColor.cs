using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000F9F")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59DEC0", Offset = "0x59DEC0")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59DEC0", Offset = "0x59DEC0")]
	public class SetGUIBackgroundColor : FsmStateAction
	{
		[Token(Token = "0x40049C6")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D3DF8", Offset = "0x5D3DF8")]
		[RequiredField]
		public FsmColor backgroundColor;

		[Token(Token = "0x40049C7")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D3E44", Offset = "0x5D3E44")]
		public FsmBool applyGlobally;

		[Token(Token = "0x6005ED7")]
		[Address(RVA = "0x103D164", Offset = "0x103D164", VA = "0x103D164", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005ED8")]
		[Address(RVA = "0x103D194", Offset = "0x103D194", VA = "0x103D194", Slot = "35")]
		public override void OnGUI()
		{
		}

		[Token(Token = "0x6005ED9")]
		[Address(RVA = "0x103D2E4", Offset = "0x103D2E4", VA = "0x103D2E4")]
		public SetGUIBackgroundColor()
		{
		}
	}
}
