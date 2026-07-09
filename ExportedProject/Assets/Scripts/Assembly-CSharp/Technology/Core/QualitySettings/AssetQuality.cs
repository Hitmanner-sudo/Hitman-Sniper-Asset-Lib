using Il2CppDummyDll;

namespace Technology.Core.QualitySettings
{
	[Token(Token = "0x2000C98")]
	public class AssetQuality
	{
		[Token(Token = "0x6004E2B")]
		[Address(RVA = "0xC00EA8", Offset = "0xC00EA8", VA = "0xC00EA8")]
		public static string GetQualitySuffix()
		{
			return null;
		}

		[Token(Token = "0x6004E2C")]
		[Address(RVA = "0xC01088", Offset = "0xC01088", VA = "0xC01088")]
		public static bool IsLowQuality()
		{
			return default(bool);
		}

		[Token(Token = "0x6004E2D")]
		[Address(RVA = "0xC00FC4", Offset = "0xC00FC4", VA = "0xC00FC4")]
		public static BundleQualityAttribute GetQualityAttribute()
		{
			return null;
		}

		[Token(Token = "0x6004E2E")]
		[Address(RVA = "0xC0124C", Offset = "0xC0124C", VA = "0xC0124C")]
		public AssetQuality()
		{
		}
	}
}
