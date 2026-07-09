using Il2CppDummyDll;

namespace Technology.Security
{
	[Token(Token = "0x2000C46")]
	public class SecureLocalULong : SecureLocalDataType8Bytes
	{
		[Token(Token = "0x170009CE")]
		public ulong Value
		{
			[Token(Token = "0x6004D1B")]
			[Address(RVA = "0xB68F98", Offset = "0xB68F98", VA = "0xB68F98")]
			get
			{
				return default(ulong);
			}
			[Token(Token = "0x6004D1C")]
			[Address(RVA = "0xB68F9C", Offset = "0xB68F9C", VA = "0xB68F9C")]
			set
			{
			}
		}

		[Token(Token = "0x6004D1D")]
		[Address(RVA = "0xB68FA0", Offset = "0xB68FA0", VA = "0xB68FA0")]
		public SecureLocalULong(ulong value = 0uL)
		{
		}

		[Token(Token = "0x6004D1E")]
		[Address(RVA = "0xB68FCC", Offset = "0xB68FCC", VA = "0xB68FCC", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
