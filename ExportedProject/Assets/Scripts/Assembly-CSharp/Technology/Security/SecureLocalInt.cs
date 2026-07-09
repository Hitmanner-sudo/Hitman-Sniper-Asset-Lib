using Il2CppDummyDll;

namespace Technology.Security
{
	[Token(Token = "0x2000C43")]
	public class SecureLocalInt : SecureLocalDataType4Bytes
	{
		[Token(Token = "0x170009CB")]
		public int Value
		{
			[Token(Token = "0x6004D0F")]
			[Address(RVA = "0xB64B14", Offset = "0xB64B14", VA = "0xB64B14")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6004D10")]
			[Address(RVA = "0xB65120", Offset = "0xB65120", VA = "0xB65120")]
			set
			{
			}
		}

		[Token(Token = "0x6004D11")]
		[Address(RVA = "0xB61B6C", Offset = "0xB61B6C", VA = "0xB61B6C")]
		public SecureLocalInt(int value = 0)
		{
		}

		[Token(Token = "0x6004D12")]
		[Address(RVA = "0xB68DD8", Offset = "0xB68DD8", VA = "0xB68DD8", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
