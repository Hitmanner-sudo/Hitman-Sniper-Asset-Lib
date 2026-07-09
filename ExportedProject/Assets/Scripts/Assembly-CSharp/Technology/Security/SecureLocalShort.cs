using Il2CppDummyDll;

namespace Technology.Security
{
	[Token(Token = "0x2000C41")]
	public class SecureLocalShort : SecureLocalDataType2Bytes
	{
		[Token(Token = "0x170009C9")]
		public short Value
		{
			[Token(Token = "0x6004D07")]
			[Address(RVA = "0xB68ED8", Offset = "0xB68ED8", VA = "0xB68ED8")]
			get
			{
				return default(short);
			}
			[Token(Token = "0x6004D08")]
			[Address(RVA = "0xB68EDC", Offset = "0xB68EDC", VA = "0xB68EDC")]
			set
			{
			}
		}

		[Token(Token = "0x6004D09")]
		[Address(RVA = "0xB68EE0", Offset = "0xB68EE0", VA = "0xB68EE0")]
		public SecureLocalShort(short value = 0)
		{
		}

		[Token(Token = "0x6004D0A")]
		[Address(RVA = "0xB68F0C", Offset = "0xB68F0C", VA = "0xB68F0C", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
