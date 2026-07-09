using System.Collections.Generic;
using Il2CppDummyDll;

namespace Technology.Core.Achievement
{
	[Token(Token = "0x2000E35")]
	[Attribute(Name = "ResourcePathAttribute", RVA = "0x598C9C", Offset = "0x598C9C")]
	public class AchievementConfiguration : AbstractConfiguration<AchievementConfiguration>
	{
		[Token(Token = "0x400436B")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "RequiredFieldAttribute", RVA = "0x5BF724", Offset = "0x5BF724")]
		public List<AchievementData> Value;

		[Token(Token = "0x6005763")]
		[Address(RVA = "0xAA70EC", Offset = "0xAA70EC", VA = "0xAA70EC")]
		public AchievementConfiguration()
		{
		}
	}
}
