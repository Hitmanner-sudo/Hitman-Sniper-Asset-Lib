using Il2CppDummyDll;

namespace Technology.Security
{
	[Token(Token = "0x2000C3E")]
	public class SecureLocalBool : SecureLocalDataType2Bytes
	{
		[Token(Token = "0x170009C6")]
		public bool Value
		{
			[Token(Token = "0x6004CFB")]
			[Address(RVA = "0xB6868C", Offset = "0xB6868C", VA = "0xB6868C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6004CFC")]
			[Address(RVA = "0xB68718", Offset = "0xB68718", VA = "0xB68718")]
			set
			{
			}
		}

		[Token(Token = "0x6004CFD")]
		[Address(RVA = "0xB687A8", Offset = "0xB687A8", VA = "0xB687A8")]
		public SecureLocalBool(bool value = false)
		{
		}

		[Token(Token = "0x6004CFE")]
		[Address(RVA = "0xB68838", Offset = "0xB68838", VA = "0xB68838", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
