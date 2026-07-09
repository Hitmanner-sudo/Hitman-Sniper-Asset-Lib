using System.Text;
using Il2CppDummyDll;

namespace Technology.Security
{
	[Token(Token = "0x2000C4D")]
	internal class StringEncoder : RevertibleFilter
	{
		[Token(Token = "0x4003CA0")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Encoding _encoding;

		[Token(Token = "0x6004D39")]
		[Address(RVA = "0xD2DFA8", Offset = "0xD2DFA8", VA = "0xD2DFA8", Slot = "6")]
		internal override object Revert(object output)
		{
			return null;
		}

		[Token(Token = "0x6004D3A")]
		[Address(RVA = "0xD2E07C", Offset = "0xD2E07C", VA = "0xD2E07C", Slot = "5")]
		internal override object Apply(object input)
		{
			return null;
		}

		[Token(Token = "0x6004D3B")]
		[Address(RVA = "0xD2E128", Offset = "0xD2E128", VA = "0xD2E128")]
		public StringEncoder()
		{
		}
	}
}
