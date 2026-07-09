using Il2CppDummyDll;

namespace Technology.Distribution
{
	[Token(Token = "0x2000BBD")]
	public class Platform : IABSeedParameter
	{
		[Token(Token = "0x4003B16")]
		[FieldOffset(Offset = "0x10")]
		public readonly SupportedPlatform Supported;

		[Token(Token = "0x6004A67")]
		[Address(RVA = "0x90ACF0", Offset = "0x90ACF0", VA = "0x90ACF0")]
		public Platform(SupportedPlatform platform)
		{
		}

		[Token(Token = "0x6004A68")]
		[Address(RVA = "0x90AD1C", Offset = "0x90AD1C", VA = "0x90AD1C", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6004A69")]
		[Address(RVA = "0x90ADA8", Offset = "0x90ADA8", VA = "0x90ADA8", Slot = "5")]
		public string ToJSON()
		{
			return null;
		}
	}
}
