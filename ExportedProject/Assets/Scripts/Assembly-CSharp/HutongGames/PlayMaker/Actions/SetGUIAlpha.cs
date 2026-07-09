using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000F9E")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59DE70", Offset = "0x59DE70")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59DE70", Offset = "0x59DE70")]
	public class SetGUIAlpha : FsmStateAction
	{
		[Token(Token = "0x40049C4")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D3D74", Offset = "0x5D3D74")]
		[RequiredField]
		public FsmFloat alpha;

		[Token(Token = "0x40049C5")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5D3DC0", Offset = "0x5D3DC0")]
		public FsmBool applyGlobally;

		[Token(Token = "0x6005ED4")]
		[Address(RVA = "0x103CF9C", Offset = "0x103CF9C", VA = "0x103CF9C", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005ED5")]
		[Address(RVA = "0x103CFC8", Offset = "0x103CFC8", VA = "0x103CFC8", Slot = "35")]
		public override void OnGUI()
		{
		}

		[Token(Token = "0x6005ED6")]
		[Address(RVA = "0x103D15C", Offset = "0x103D15C", VA = "0x103D15C")]
		public SetGUIAlpha()
		{
		}
	}
}
