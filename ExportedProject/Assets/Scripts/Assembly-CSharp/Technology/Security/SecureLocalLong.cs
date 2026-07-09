using Il2CppDummyDll;

namespace Technology.Security
{
	[Token(Token = "0x2000C45")]
	public class SecureLocalLong : SecureLocalDataType8Bytes
	{
		[Token(Token = "0x170009CD")]
		public long Value
		{
			[Token(Token = "0x6004D17")]
			[Address(RVA = "0xB68E04", Offset = "0xB68E04", VA = "0xB68E04")]
			get
			{
				return default(long);
			}
			[Token(Token = "0x6004D18")]
			[Address(RVA = "0xB68E08", Offset = "0xB68E08", VA = "0xB68E08")]
			set
			{
			}
		}

		[Token(Token = "0x6004D19")]
		[Address(RVA = "0xB68E0C", Offset = "0xB68E0C", VA = "0xB68E0C")]
		public SecureLocalLong(long value = 0L)
		{
		}

		[Token(Token = "0x6004D1A")]
		[Address(RVA = "0xB68E38", Offset = "0xB68E38", VA = "0xB68E38", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
