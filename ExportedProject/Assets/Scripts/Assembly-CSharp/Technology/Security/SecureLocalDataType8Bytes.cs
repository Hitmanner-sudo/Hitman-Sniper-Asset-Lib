using Il2CppDummyDll;

namespace Technology.Security
{
	[Token(Token = "0x2000C3D")]
	public abstract class SecureLocalDataType8Bytes : SecureLocalDataType
	{
		[Token(Token = "0x4003C94")]
		[FieldOffset(Offset = "0x10")]
		private ushort _value0;

		[Token(Token = "0x4003C95")]
		[FieldOffset(Offset = "0x12")]
		private ushort _value1;

		[Token(Token = "0x4003C96")]
		[FieldOffset(Offset = "0x14")]
		private ushort _value2;

		[Token(Token = "0x4003C97")]
		[FieldOffset(Offset = "0x16")]
		private ushort _value3;

		[Token(Token = "0x6004CF8")]
		[Address(RVA = "0xB68B3C", Offset = "0xB68B3C", VA = "0xB68B3C")]
		protected void SetValue(ulong value)
		{
		}

		[Token(Token = "0x6004CF9")]
		[Address(RVA = "0xB68BF0", Offset = "0xB68BF0", VA = "0xB68BF0")]
		protected ulong GetValue()
		{
			return default(ulong);
		}

		[Token(Token = "0x6004CFA")]
		[Address(RVA = "0xB68C94", Offset = "0xB68C94", VA = "0xB68C94")]
		protected SecureLocalDataType8Bytes()
		{
		}
	}
}
