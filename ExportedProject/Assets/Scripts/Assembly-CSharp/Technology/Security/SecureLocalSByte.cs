using Il2CppDummyDll;

namespace Technology.Security
{
	[Token(Token = "0x2000C40")]
	public class SecureLocalSByte : SecureLocalDataType2Bytes
	{
		[Token(Token = "0x170009C8")]
		public sbyte Value
		{
			[Token(Token = "0x6004D03")]
			[Address(RVA = "0xB68E64", Offset = "0xB68E64", VA = "0xB68E64")]
			get
			{
				return default(sbyte);
			}
			[Token(Token = "0x6004D04")]
			[Address(RVA = "0xB68E78", Offset = "0xB68E78", VA = "0xB68E78")]
			set
			{
			}
		}

		[Token(Token = "0x6004D05")]
		[Address(RVA = "0xB68E80", Offset = "0xB68E80", VA = "0xB68E80")]
		public SecureLocalSByte(sbyte value = 0)
		{
		}

		[Token(Token = "0x6004D06")]
		[Address(RVA = "0xB68EAC", Offset = "0xB68EAC", VA = "0xB68EAC", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
