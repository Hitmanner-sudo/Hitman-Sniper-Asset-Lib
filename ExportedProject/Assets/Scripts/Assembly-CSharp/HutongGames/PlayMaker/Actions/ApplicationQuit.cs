using Il2CppDummyDll;

namespace HutongGames.PlayMaker.Actions
{
	[Token(Token = "0x2000F04")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x59B010", Offset = "0x59B010")]
	[Attribute(Name = "ActionCategoryAttribute", RVA = "0x59B010", Offset = "0x59B010")]
	public class ApplicationQuit : FsmStateAction
	{
		[Token(Token = "0x4004709")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x5C9360", Offset = "0x5C9360")]
		public FsmInt exitCode;

		[Token(Token = "0x6005C6D")]
		[Address(RVA = "0xD4BC3C", Offset = "0xD4BC3C", VA = "0xD4BC3C", Slot = "28")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6005C6E")]
		[Address(RVA = "0xD4BC68", Offset = "0xD4BC68", VA = "0xD4BC68", Slot = "32")]
		public override void OnEnter()
		{
		}

		[Token(Token = "0x6005C6F")]
		[Address(RVA = "0xD4BCA8", Offset = "0xD4BCA8", VA = "0xD4BCA8")]
		public ApplicationQuit()
		{
		}
	}
}
