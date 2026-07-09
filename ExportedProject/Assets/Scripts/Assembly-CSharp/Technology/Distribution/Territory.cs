using Il2CppDummyDll;

namespace Technology.Distribution
{
	[Token(Token = "0x2000BC6")]
	public class Territory : IABSeedParameter
	{
		[Token(Token = "0x4003B2D")]
		[FieldOffset(Offset = "0x10")]
		public readonly Country Country;

		[Token(Token = "0x6004A89")]
		[Address(RVA = "0xAC25D8", Offset = "0xAC25D8", VA = "0xAC25D8")]
		public Territory(Country country)
		{
		}

		[Token(Token = "0x6004A8A")]
		[Address(RVA = "0xAC2604", Offset = "0xAC2604", VA = "0xAC2604", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6004A8B")]
		[Address(RVA = "0xAC2690", Offset = "0xAC2690", VA = "0xAC2690", Slot = "5")]
		public string ToJSON()
		{
			return null;
		}
	}
}
