using Il2CppDummyDll;

namespace Technology.Core.QualitySettings
{
	[Token(Token = "0x2000C94")]
	public class SavedDeviceQuality : IDeviceQuality
	{
		[Token(Token = "0x4003D42")]
		[FieldOffset(Offset = "0x0")]
		public static readonly string saveKey;

		[Token(Token = "0x6004E25")]
		[Address(RVA = "0xBB1854", Offset = "0xBB1854", VA = "0xBB1854", Slot = "4")]
		public Quality GetDeviceQuality()
		{
			return default(Quality);
		}

		[Token(Token = "0x6004E26")]
		[Address(RVA = "0xBB18C0", Offset = "0xBB18C0", VA = "0xBB18C0")]
		public static void SetDeviceQuality(int in_quality)
		{
		}

		[Token(Token = "0x6004E27")]
		[Address(RVA = "0xBB1930", Offset = "0xBB1930", VA = "0xBB1930")]
		public static int GetDeviceQualityValue()
		{
			return default(int);
		}

		[Token(Token = "0x6004E28")]
		[Address(RVA = "0xBB199C", Offset = "0xBB199C", VA = "0xBB199C")]
		public SavedDeviceQuality()
		{
		}
	}
}
