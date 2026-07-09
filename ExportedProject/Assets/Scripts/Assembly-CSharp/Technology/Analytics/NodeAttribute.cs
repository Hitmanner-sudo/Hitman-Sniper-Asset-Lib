using Il2CppDummyDll;

namespace Technology.Analytics
{
	[Token(Token = "0x2000E64")]
	public struct NodeAttribute
	{
		[Token(Token = "0x40043E7")]
		[FieldOffset(Offset = "0x0")]
		private string _id;

		[Token(Token = "0x40043E8")]
		[FieldOffset(Offset = "0x8")]
		private Schema _schema;

		[Token(Token = "0x40043E9")]
		[FieldOffset(Offset = "0x10")]
		private int _gameTimeCreatedInSeconds;

		[Token(Token = "0x17000BE7")]
		public string Id
		{
			[Token(Token = "0x6005897")]
			[Address(RVA = "0xC5E24C", Offset = "0xC5E24C", VA = "0xC5E24C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000BE8")]
		public string Value
		{
			[Token(Token = "0x6005898")]
			[Address(RVA = "0xC5E254", Offset = "0xC5E254", VA = "0xC5E254")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000BE9")]
		public Schema Schema
		{
			[Token(Token = "0x6005899")]
			[Address(RVA = "0xC5E25C", Offset = "0xC5E25C", VA = "0xC5E25C")]
			get
			{
				return default(Schema);
			}
		}

		[Token(Token = "0x17000BEA")]
		public int GameCreationTimeInSeconds
		{
			[Token(Token = "0x600589A")]
			[Address(RVA = "0xC5E264", Offset = "0xC5E264", VA = "0xC5E264")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600589B")]
			[Address(RVA = "0xC5E26C", Offset = "0xC5E26C", VA = "0xC5E26C")]
			set
			{
			}
		}

		[Token(Token = "0x600589C")]
		[Address(RVA = "0xC5DA88", Offset = "0xC5DA88", VA = "0xC5DA88")]
		public NodeAttribute(string l_id, Schema l_schema)
		{
		}
	}
}
