using Il2CppDummyDll;

namespace Technology.Security
{
	[Token(Token = "0x2000C49")]
	public class SecureLocalChar : SecureLocalDataType2Bytes
	{
		[Token(Token = "0x170009D1")]
		public char Value
		{
			[Token(Token = "0x6004D27")]
			[Address(RVA = "0xB688E0", Offset = "0xB688E0", VA = "0xB688E0")]
			get
			{
				return default(char);
			}
			[Token(Token = "0x6004D28")]
			[Address(RVA = "0xB688E4", Offset = "0xB688E4", VA = "0xB688E4")]
			set
			{
			}
		}

		[Token(Token = "0x6004D29")]
		[Address(RVA = "0xB688E8", Offset = "0xB688E8", VA = "0xB688E8")]
		public SecureLocalChar(char value = '\0')
		{
		}

		[Token(Token = "0x6004D2A")]
		[Address(RVA = "0xB68914", Offset = "0xB68914", VA = "0xB68914", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
