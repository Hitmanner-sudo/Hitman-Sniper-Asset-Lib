using Il2CppDummyDll;

namespace Helpshift
{
	[Token(Token = "0x20012D5")]
	public class HelpshiftUser
	{
		[Token(Token = "0x20012D6")]
		public sealed class Builder
		{
			[Token(Token = "0x4005A53")]
			[FieldOffset(Offset = "0x10")]
			private string identifier;

			[Token(Token = "0x4005A54")]
			[FieldOffset(Offset = "0x18")]
			private string email;

			[Token(Token = "0x4005A55")]
			[FieldOffset(Offset = "0x20")]
			private string name;

			[Token(Token = "0x4005A56")]
			[FieldOffset(Offset = "0x28")]
			private string authToken;

			[Token(Token = "0x6006DF5")]
			[Address(RVA = "0xB201EC", Offset = "0xB201EC", VA = "0xB201EC")]
			public Builder(string identifier, string email)
			{
			}

			[Token(Token = "0x6006DF6")]
			[Address(RVA = "0xB20224", Offset = "0xB20224", VA = "0xB20224")]
			public Builder setName(string name)
			{
				return null;
			}

			[Token(Token = "0x6006DF7")]
			[Address(RVA = "0xB2022C", Offset = "0xB2022C", VA = "0xB2022C")]
			public Builder setAuthToken(string authToken)
			{
				return null;
			}

			[Token(Token = "0x6006DF8")]
			[Address(RVA = "0xB20234", Offset = "0xB20234", VA = "0xB20234")]
			public HelpshiftUser build()
			{
				return null;
			}
		}

		[Token(Token = "0x4005A4F")]
		[FieldOffset(Offset = "0x10")]
		public readonly string identifier;

		[Token(Token = "0x4005A50")]
		[FieldOffset(Offset = "0x18")]
		public readonly string email;

		[Token(Token = "0x4005A51")]
		[FieldOffset(Offset = "0x20")]
		public readonly string name;

		[Token(Token = "0x4005A52")]
		[FieldOffset(Offset = "0x28")]
		public readonly string authToken;

		[Token(Token = "0x6006DF4")]
		[Address(RVA = "0xA1281C", Offset = "0xA1281C", VA = "0xA1281C")]
		private HelpshiftUser(string identifier, string email, string name, string authToken)
		{
		}
	}
}
