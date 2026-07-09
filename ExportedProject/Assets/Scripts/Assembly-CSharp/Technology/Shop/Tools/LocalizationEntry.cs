using Il2CppDummyDll;

namespace Technology.Shop.Tools
{
	[Token(Token = "0x2000B47")]
	public class LocalizationEntry
	{
		[Token(Token = "0x4003981")]
		[FieldOffset(Offset = "0x10")]
		public string Name;

		[Token(Token = "0x4003982")]
		[FieldOffset(Offset = "0x18")]
		public string Description;

		[Token(Token = "0x17000913")]
		public static LocalizationEntry Empty
		{
			[Token(Token = "0x6004775")]
			[Address(RVA = "0x9D8C9C", Offset = "0x9D8C9C", VA = "0x9D8C9C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6004774")]
		[Address(RVA = "0x9D8C64", Offset = "0x9D8C64", VA = "0x9D8C64")]
		public LocalizationEntry(string name, string description)
		{
		}
	}
}
