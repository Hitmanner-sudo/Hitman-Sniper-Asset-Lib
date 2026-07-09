using Il2CppDummyDll;

namespace Technology.Core.Auth
{
	[Token(Token = "0x2000DB9")]
	public class PlayGameServicesPersonalRecord : PersonalRecord
	{
		[Token(Token = "0x40041A1")]
		[FieldOffset(Offset = "0x7C")]
		public int EstimatedAge;

		[Token(Token = "0x40041A2")]
		[FieldOffset(Offset = "0x80")]
		public string StateProvince;

		[Token(Token = "0x60054A5")]
		[Address(RVA = "0xB75064", Offset = "0xB75064", VA = "0xB75064")]
		public PlayGameServicesPersonalRecord()
		{
		}
	}
}
