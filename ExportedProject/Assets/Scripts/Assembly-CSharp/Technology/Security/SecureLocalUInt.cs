using Il2CppDummyDll;

namespace Technology.Security
{
	[Token(Token = "0x2000C44")]
	public class SecureLocalUInt : SecureLocalDataType4Bytes
	{
		[Token(Token = "0x170009CC")]
		public uint Value
		{
			[Token(Token = "0x6004D13")]
			[Address(RVA = "0xB68F38", Offset = "0xB68F38", VA = "0xB68F38")]
			get
			{
				return default(uint);
			}
			[Token(Token = "0x6004D14")]
			[Address(RVA = "0xB68F3C", Offset = "0xB68F3C", VA = "0xB68F3C")]
			set
			{
			}
		}

		[Token(Token = "0x6004D15")]
		[Address(RVA = "0xB68F40", Offset = "0xB68F40", VA = "0xB68F40")]
		public SecureLocalUInt(uint value = 0u)
		{
		}

		[Token(Token = "0x6004D16")]
		[Address(RVA = "0xB68F6C", Offset = "0xB68F6C", VA = "0xB68F6C", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
