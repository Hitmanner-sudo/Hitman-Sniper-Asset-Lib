using Il2CppDummyDll;

namespace Technology.Security
{
	[Token(Token = "0x2000C42")]
	public class SecureLocalUShort : SecureLocalDataType2Bytes
	{
		[Token(Token = "0x170009CA")]
		public ushort Value
		{
			[Token(Token = "0x6004D0B")]
			[Address(RVA = "0xB68FF8", Offset = "0xB68FF8", VA = "0xB68FF8")]
			get
			{
				return default(ushort);
			}
			[Token(Token = "0x6004D0C")]
			[Address(RVA = "0xB68FFC", Offset = "0xB68FFC", VA = "0xB68FFC")]
			set
			{
			}
		}

		[Token(Token = "0x6004D0D")]
		[Address(RVA = "0xB69000", Offset = "0xB69000", VA = "0xB69000")]
		public SecureLocalUShort(ushort value = 0)
		{
		}

		[Token(Token = "0x6004D0E")]
		[Address(RVA = "0xB6902C", Offset = "0xB6902C", VA = "0xB6902C", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
