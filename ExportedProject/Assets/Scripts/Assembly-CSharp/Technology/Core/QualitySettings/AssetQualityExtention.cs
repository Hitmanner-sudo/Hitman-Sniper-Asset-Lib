using Il2CppDummyDll;

namespace Technology.Core.QualitySettings
{
	[Token(Token = "0x2000C99")]
	public static class AssetQualityExtention
	{
		[Token(Token = "0x6004E2F")]
		[Address(RVA = "0xC010C0", Offset = "0xC010C0", VA = "0xC010C0")]
		public static BundleQualityAttribute GetQualityAttribute(this Quality quality)
		{
			return null;
		}

		[Token(Token = "0x6004E30")]
		[Address(RVA = "0xC010AC", Offset = "0xC010AC", VA = "0xC010AC")]
		public static bool IsLowQuality(this BundleQualityAttribute bundleQuality)
		{
			return default(bool);
		}
	}
}
