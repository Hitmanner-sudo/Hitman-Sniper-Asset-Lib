using Il2CppDummyDll;

namespace Technology.Core.QualitySettings
{
	[Token(Token = "0x2000C9C")]
	public class WindowDeviceQuality : IDeviceQuality
	{
		[Token(Token = "0x6004E3F")]
		[Address(RVA = "0x87FA3C", Offset = "0x87FA3C", VA = "0x87FA3C", Slot = "4")]
		public Quality GetDeviceQuality()
		{
			return default(Quality);
		}

		[Token(Token = "0x6004E40")]
		[Address(RVA = "0x87FA44", Offset = "0x87FA44", VA = "0x87FA44")]
		public WindowDeviceQuality()
		{
		}
	}
}
