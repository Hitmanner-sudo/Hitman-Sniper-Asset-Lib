using Il2CppDummyDll;

namespace Technology.Security
{
	[Token(Token = "0x2000C48")]
	public class SecureLocalDouble : SecureLocalDataType8Bytes
	{
		[Token(Token = "0x4003C99")]
		[FieldOffset(Offset = "0x18")]
		private DoubleULongUnion _union;

		[Token(Token = "0x170009D0")]
		public double Value
		{
			[Token(Token = "0x6004D23")]
			[Address(RVA = "0xB68CF8", Offset = "0xB68CF8", VA = "0xB68CF8")]
			get
			{
				return default(double);
			}
			[Token(Token = "0x6004D24")]
			[Address(RVA = "0xB68D20", Offset = "0xB68D20", VA = "0xB68D20")]
			set
			{
			}
		}

		[Token(Token = "0x6004D25")]
		[Address(RVA = "0xB68D2C", Offset = "0xB68D2C", VA = "0xB68D2C")]
		public SecureLocalDouble(double value = 0.0)
		{
		}

		[Token(Token = "0x6004D26")]
		[Address(RVA = "0xB68D64", Offset = "0xB68D64", VA = "0xB68D64", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
