using System;
using Il2CppDummyDll;

namespace Technology.Core.Auth
{
	[Token(Token = "0x2000DB7")]
	public class SquareEnixPersonalRecord : PersonalRecord
	{
		[Token(Token = "0x400419C")]
		[FieldOffset(Offset = "0x80")]
		public string Uuid;

		[Token(Token = "0x400419D")]
		[FieldOffset(Offset = "0x88")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BF39C", Offset = "0x5BF39C")]
		private string _003CPassPhrase_003Ek__BackingField;

		[Token(Token = "0x400419E")]
		[FieldOffset(Offset = "0x90")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BF3AC", Offset = "0x5BF3AC")]
		private string _003CMigrationGetDataUid_003Ek__BackingField;

		[Token(Token = "0x400419F")]
		[FieldOffset(Offset = "0x98")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BF3BC", Offset = "0x5BF3BC")]
		private DateTime _003CMigrationExpirationUtcTimeStamp_003Ek__BackingField;

		[Token(Token = "0x17000B30")]
		public bool IsUuidGenerated
		{
			[Token(Token = "0x600549C")]
			[Address(RVA = "0xD28320", Offset = "0xD28320", VA = "0xD28320")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000B31")]
		public string PassPhrase
		{
			[Token(Token = "0x600549D")]
			[Address(RVA = "0xD2836C", Offset = "0xD2836C", VA = "0xD2836C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62A8C0", Offset = "0x62A8C0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600549E")]
			[Address(RVA = "0xD28374", Offset = "0xD28374", VA = "0xD28374")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62A8D0", Offset = "0x62A8D0")]
			set
			{
			}
		}

		[Token(Token = "0x17000B32")]
		public string MigrationGetDataUid
		{
			[Token(Token = "0x600549F")]
			[Address(RVA = "0xD2837C", Offset = "0xD2837C", VA = "0xD2837C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62A8E0", Offset = "0x62A8E0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60054A0")]
			[Address(RVA = "0xD28384", Offset = "0xD28384", VA = "0xD28384")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62A8F0", Offset = "0x62A8F0")]
			set
			{
			}
		}

		[Token(Token = "0x17000B33")]
		public DateTime MigrationExpirationUtcTimeStamp
		{
			[Token(Token = "0x60054A1")]
			[Address(RVA = "0xD2838C", Offset = "0xD2838C", VA = "0xD2838C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62A900", Offset = "0x62A900")]
			get
			{
				return default(DateTime);
			}
			[Token(Token = "0x60054A2")]
			[Address(RVA = "0xD28394", Offset = "0xD28394", VA = "0xD28394")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62A910", Offset = "0x62A910")]
			set
			{
			}
		}

		[Token(Token = "0x60054A3")]
		[Address(RVA = "0xD2839C", Offset = "0xD2839C", VA = "0xD2839C")]
		public SquareEnixPersonalRecord()
		{
		}
	}
}
