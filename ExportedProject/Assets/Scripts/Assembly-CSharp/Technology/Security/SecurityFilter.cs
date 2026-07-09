using Il2CppDummyDll;

namespace Technology.Security
{
	[Token(Token = "0x2000C4B")]
	internal abstract class SecurityFilter
	{
		[Token(Token = "0x6004D34")]
		[Address(RVA = "0xB69058", Offset = "0xB69058", VA = "0xB69058", Slot = "4")]
		internal virtual void Initialize()
		{
		}

		[Token(Token = "0x6004D35")]
		internal abstract object Apply(object input);

		[Token(Token = "0x6004D36")]
		[Address(RVA = "0xB6905C", Offset = "0xB6905C", VA = "0xB6905C")]
		protected SecurityFilter()
		{
		}
	}
}
