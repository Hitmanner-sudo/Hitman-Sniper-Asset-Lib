using Il2CppDummyDll;

namespace DeltaDNA
{
	[Token(Token = "0x2001301")]
	internal static class ClientInfo
	{
		[Token(Token = "0x4005B0F")]
		[FieldOffset(Offset = "0x0")]
		private static string platform;

		[Token(Token = "0x4005B10")]
		[FieldOffset(Offset = "0x8")]
		private static string deviceName;

		[Token(Token = "0x4005B11")]
		[FieldOffset(Offset = "0x10")]
		private static string deviceModel;

		[Token(Token = "0x4005B12")]
		[FieldOffset(Offset = "0x18")]
		private static string deviceType;

		[Token(Token = "0x4005B13")]
		[FieldOffset(Offset = "0x20")]
		private static string operatingSystem;

		[Token(Token = "0x4005B14")]
		[FieldOffset(Offset = "0x28")]
		private static string operatingSystemVersion;

		[Token(Token = "0x4005B15")]
		[FieldOffset(Offset = "0x30")]
		private static string manufacturer;

		[Token(Token = "0x4005B16")]
		[FieldOffset(Offset = "0x38")]
		private static string timezoneOffset;

		[Token(Token = "0x4005B17")]
		[FieldOffset(Offset = "0x40")]
		private static string countryCode;

		[Token(Token = "0x4005B18")]
		[FieldOffset(Offset = "0x48")]
		private static string languageCode;

		[Token(Token = "0x4005B19")]
		[FieldOffset(Offset = "0x50")]
		private static string locale;

		[Token(Token = "0x17000CA6")]
		public static string Platform
		{
			[Token(Token = "0x6006F8A")]
			[Address(RVA = "0xB02064", Offset = "0xB02064", VA = "0xB02064")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000CA7")]
		public static string DeviceName
		{
			[Token(Token = "0x6006F8B")]
			[Address(RVA = "0xB02A04", Offset = "0xB02A04", VA = "0xB02A04")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000CA8")]
		public static string DeviceModel
		{
			[Token(Token = "0x6006F8C")]
			[Address(RVA = "0xB04DB0", Offset = "0xB04DB0", VA = "0xB04DB0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000CA9")]
		public static string DeviceType
		{
			[Token(Token = "0x6006F8D")]
			[Address(RVA = "0xB04EB4", Offset = "0xB04EB4", VA = "0xB04EB4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000CAA")]
		public static string OperatingSystem
		{
			[Token(Token = "0x6006F8E")]
			[Address(RVA = "0xB05134", Offset = "0xB05134", VA = "0xB05134")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000CAB")]
		public static string OperatingSystemVersion
		{
			[Token(Token = "0x6006F8F")]
			[Address(RVA = "0xB05468", Offset = "0xB05468", VA = "0xB05468")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000CAC")]
		public static string Manufacturer
		{
			[Token(Token = "0x6006F90")]
			[Address(RVA = "0xB05694", Offset = "0xB05694", VA = "0xB05694")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000CAD")]
		public static string TimezoneOffset
		{
			[Token(Token = "0x6006F91")]
			[Address(RVA = "0xB058AC", Offset = "0xB058AC", VA = "0xB058AC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000CAE")]
		public static string CountryCode
		{
			[Token(Token = "0x6006F92")]
			[Address(RVA = "0xB05C40", Offset = "0xB05C40", VA = "0xB05C40")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000CAF")]
		public static string LanguageCode
		{
			[Token(Token = "0x6006F93")]
			[Address(RVA = "0xB05CE0", Offset = "0xB05CE0", VA = "0xB05CE0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000CB0")]
		public static string Locale
		{
			[Token(Token = "0x6006F94")]
			[Address(RVA = "0xB05D80", Offset = "0xB05D80", VA = "0xB05D80")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6006F95")]
		[Address(RVA = "0xB05F3C", Offset = "0xB05F3C", VA = "0xB05F3C")]
		private static bool RuntimePlatformIs(string platformName)
		{
			return default(bool);
		}

		[Token(Token = "0x6006F96")]
		[Address(RVA = "0xB06088", Offset = "0xB06088", VA = "0xB06088")]
		private static float ScreenSizeInches()
		{
			return default(float);
		}

		[Token(Token = "0x6006F97")]
		[Address(RVA = "0xB06150", Offset = "0xB06150", VA = "0xB06150")]
		private static bool IsTablet()
		{
			return default(bool);
		}

		[Token(Token = "0x6006F98")]
		[Address(RVA = "0xB020F8", Offset = "0xB020F8", VA = "0xB020F8")]
		private static string GetPlatform()
		{
			return null;
		}

		[Token(Token = "0x6006F99")]
		[Address(RVA = "0xB02A98", Offset = "0xB02A98", VA = "0xB02A98")]
		private static string GetDeviceName()
		{
			return null;
		}

		[Token(Token = "0x6006F9A")]
		[Address(RVA = "0xB04E44", Offset = "0xB04E44", VA = "0xB04E44")]
		private static string GetDeviceModel()
		{
			return null;
		}

		[Token(Token = "0x6006F9B")]
		[Address(RVA = "0xB04F48", Offset = "0xB04F48", VA = "0xB04F48")]
		private static string GetDeviceType()
		{
			return null;
		}

		[Token(Token = "0x6006F9C")]
		[Address(RVA = "0xB051C8", Offset = "0xB051C8", VA = "0xB051C8")]
		private static string GetOperatingSystem()
		{
			return null;
		}

		[Token(Token = "0x6006F9D")]
		[Address(RVA = "0xB054FC", Offset = "0xB054FC", VA = "0xB054FC")]
		private static string GetOperatingSystemVersion()
		{
			return null;
		}

		[Token(Token = "0x6006F9E")]
		[Address(RVA = "0xB05728", Offset = "0xB05728", VA = "0xB05728")]
		private static string GetManufacturer()
		{
			return null;
		}

		[Token(Token = "0x6006F9F")]
		[Address(RVA = "0xB05940", Offset = "0xB05940", VA = "0xB05940")]
		private static string GetCurrentTimezoneOffset()
		{
			return null;
		}

		[Token(Token = "0x6006FA0")]
		[Address(RVA = "0xB05CD8", Offset = "0xB05CD8", VA = "0xB05CD8")]
		private static string GetCountryCode()
		{
			return null;
		}

		[Token(Token = "0x6006FA1")]
		[Address(RVA = "0xB05D78", Offset = "0xB05D78", VA = "0xB05D78")]
		private static string GetLanguageCode()
		{
			return null;
		}

		[Token(Token = "0x6006FA2")]
		[Address(RVA = "0xB05E14", Offset = "0xB05E14", VA = "0xB05E14")]
		private static string GetLocale()
		{
			return null;
		}

		[Token(Token = "0x6006FA3")]
		[Address(RVA = "0xB061B8", Offset = "0xB061B8", VA = "0xB061B8")]
		private static string Trim(string value, int length)
		{
			return null;
		}
	}
}
