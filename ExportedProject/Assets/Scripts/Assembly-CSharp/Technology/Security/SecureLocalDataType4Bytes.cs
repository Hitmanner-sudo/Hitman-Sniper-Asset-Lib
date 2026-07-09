using Il2CppDummyDll;

namespace Technology.Security
{
	[Token(Token = "0x2000C3C")]
	public abstract class SecureLocalDataType4Bytes : SecureLocalDataType
	{
		[Token(Token = "0x4003C92")]
		[FieldOffset(Offset = "0x10")]
		private ushort _value0;

		[Token(Token = "0x4003C93")]
		[FieldOffset(Offset = "0x12")]
		private ushort _value1;

		[Token(Token = "0x6004CF5")]
		[Address(RVA = "0xB689C8", Offset = "0xB689C8", VA = "0xB689C8")]
		protected void SetValue(uint value)
		{
		}

		[Token(Token = "0x6004CF6")]
		[Address(RVA = "0xB68A54", Offset = "0xB68A54", VA = "0xB68A54")]
		protected uint GetValue()
		{
			return default(uint);
		}

		[Token(Token = "0x6004CF7")]
		[Address(RVA = "0xB68AD8", Offset = "0xB68AD8", VA = "0xB68AD8")]
		protected SecureLocalDataType4Bytes()
		{
		}
	}
}
