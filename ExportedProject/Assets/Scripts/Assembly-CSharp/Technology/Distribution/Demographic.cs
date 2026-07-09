using Il2CppDummyDll;

namespace Technology.Distribution
{
	[Token(Token = "0x2000BBA")]
	public class Demographic : IABSeedParameter
	{
		[Token(Token = "0x4003B0C")]
		[FieldOffset(Offset = "0x10")]
		public AgeGroup AgeGroup;

		[Token(Token = "0x4003B0D")]
		[FieldOffset(Offset = "0x14")]
		public Gender Gender;

		[Token(Token = "0x6004A63")]
		[Address(RVA = "0xC1246C", Offset = "0xC1246C", VA = "0xC1246C")]
		public Demographic(AgeGroup ageGroup, Gender gender)
		{
		}

		[Token(Token = "0x6004A64")]
		[Address(RVA = "0xC124A4", Offset = "0xC124A4", VA = "0xC124A4", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6004A65")]
		[Address(RVA = "0xC12598", Offset = "0xC12598", VA = "0xC12598", Slot = "5")]
		public string ToJSON()
		{
			return null;
		}
	}
}
