using Il2CppDummyDll;

namespace Technology.Core.QualitySettings
{
	[Token(Token = "0x2000C92")]
	public class DevelopmentDeviceQuality : IDeviceQuality
	{
		[Token(Token = "0x6004E22")]
		[Address(RVA = "0xC13C3C", Offset = "0xC13C3C", VA = "0xC13C3C", Slot = "4")]
		public Quality GetDeviceQuality()
		{
			return default(Quality);
		}

		[Token(Token = "0x6004E23")]
		[Address(RVA = "0xC13C44", Offset = "0xC13C44", VA = "0xC13C44")]
		public DevelopmentDeviceQuality()
		{
		}
	}
}
