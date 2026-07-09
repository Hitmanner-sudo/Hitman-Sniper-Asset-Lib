using Il2CppDummyDll;

namespace Technology.Security
{
	[Token(Token = "0x2000C3B")]
	public abstract class SecureLocalDataType2Bytes : SecureLocalDataType
	{
		[Token(Token = "0x4003C91")]
		[FieldOffset(Offset = "0x10")]
		private ushort _value0;

		[Token(Token = "0x6004CF2")]
		[Address(RVA = "0xB6872C", Offset = "0xB6872C", VA = "0xB6872C")]
		protected void SetValue(ushort value)
		{
		}

		[Token(Token = "0x6004CF3")]
		[Address(RVA = "0xB686A8", Offset = "0xB686A8", VA = "0xB686A8")]
		protected ushort GetValue()
		{
			return default(ushort);
		}

		[Token(Token = "0x6004CF4")]
		[Address(RVA = "0xB687D4", Offset = "0xB687D4", VA = "0xB687D4")]
		protected SecureLocalDataType2Bytes()
		{
		}
	}
}
