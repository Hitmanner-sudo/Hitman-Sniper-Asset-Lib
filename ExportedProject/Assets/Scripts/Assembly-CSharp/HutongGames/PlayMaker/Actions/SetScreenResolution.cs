using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000F08")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59B150", Offset = "0x59B150")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59B150", Offset = "0x59B150")]
	public class SetScreenResolution : FsmStateAction
	{
		[Token(Token = "0x400470F")]
		[FieldOffset(Offset = "0x50")]
		[RequiredField]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C9500", Offset = "0x5C9500")]
		public FsmInt width;

		[Token(Token = "0x4004710")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C954C", Offset = "0x5C954C")]
		[RequiredField]
		public FsmInt height;

		[Token(Token = "0x4004711")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C9598", Offset = "0x5C9598")]
		public FsmBool fullscreen;

		[Token(Token = "0x6005C7B")]
		[Address(RVA = "0x1044C40", Offset = "0x1044C40", VA = "0x1044C40", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005C7C")]
		[Address(RVA = "0x1044CD8", Offset = "0x1044CD8", VA = "0x1044CD8", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6005C7D")]
		[Address(RVA = "0x1044D5C", Offset = "0x1044D5C", VA = "0x1044D5C")]
		public SetScreenResolution()
		{
		}
	}
}
