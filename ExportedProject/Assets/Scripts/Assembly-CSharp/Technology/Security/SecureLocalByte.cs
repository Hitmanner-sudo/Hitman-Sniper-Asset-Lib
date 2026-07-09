using Il2CppDummyDll;

namespace Technology.Security
{
	[Token(Token = "0x2000C3F")]
	public class SecureLocalByte : SecureLocalDataType2Bytes
	{
		[Token(Token = "0x170009C7")]
		public byte Value
		{
			[Token(Token = "0x6004CFF")]
			[Address(RVA = "0xB6886C", Offset = "0xB6886C", VA = "0xB6886C")]
			get
			{
				return default(byte);
			}
			[Token(Token = "0x6004D00")]
			[Address(RVA = "0xB68880", Offset = "0xB68880", VA = "0xB68880")]
			set
			{
			}
		}

		[Token(Token = "0x6004D01")]
		[Address(RVA = "0xB68888", Offset = "0xB68888", VA = "0xB68888")]
		public SecureLocalByte(byte value = 0)
		{
		}

		[Token(Token = "0x6004D02")]
		[Address(RVA = "0xB688B4", Offset = "0xB688B4", VA = "0xB688B4", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
