using Il2CppDummyDll;

namespace Helpshift
{
	[Token(Token = "0x20012D7")]
	public class HelpshiftUserAction
	{
		[Token(Token = "0x4005A57")]
		[FieldOffset(Offset = "0x10")]
		public readonly string actionType;

		[Token(Token = "0x4005A58")]
		[FieldOffset(Offset = "0x18")]
		public readonly string actionData;

		[Token(Token = "0x6006DF9")]
		[Address(RVA = "0xA11C1C", Offset = "0xA11C1C", VA = "0xA11C1C")]
		public HelpshiftUserAction(string actionType, string actionData)
		{
		}
	}
}
