using Il2CppDummyDll;

namespace Technology.CrossPromotion
{
	[Token(Token = "0x2000C1F")]
	public abstract class StoreLinkInfo
	{
		[Token(Token = "0x4003C53")]
		[FieldOffset(Offset = "0x0")]
		protected static string DEFAULT_APP_NAME;

		[Token(Token = "0x4003C54")]
		protected const int PRIME_NUMBER = 11;

		[Token(Token = "0x4003C55")]
		protected const string APP_NAME_REF = "[APPNAME]";

		[Token(Token = "0x4003C56")]
		[FieldOffset(Offset = "0x10")]
		protected readonly string BASE_LINK;

		[Token(Token = "0x4003C57")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BDB24", Offset = "0x5BDB24")]
		private bool _003CIsValid_003Ek__BackingField;

		[Token(Token = "0x4003C58")]
		[FieldOffset(Offset = "0x20")]
		public string AppName;

		[Token(Token = "0x170009C1")]
		public bool IsValid
		{
			[Token(Token = "0x6004C86")]
			[Address(RVA = "0xD2DA24", Offset = "0xD2DA24", VA = "0xD2DA24")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6286D0", Offset = "0x6286D0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6004C87")]
			[Address(RVA = "0xD2DA2C", Offset = "0xD2DA2C", VA = "0xD2DA2C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6286E0", Offset = "0x6286E0")]
			protected set
			{
			}
		}

		[Token(Token = "0x6004C88")]
		[Address(RVA = "0xD2DA38", Offset = "0xD2DA38", VA = "0xD2DA38")]
		protected StoreLinkInfo(string baseLink)
		{
		}

		[Token(Token = "0x6004C89")]
		public abstract string Get();

		[Token(Token = "0x6004C8A")]
		public abstract bool Set(string link);
	}
}
