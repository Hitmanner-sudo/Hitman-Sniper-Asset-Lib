using Il2CppDummyDll;
using UnityEngine;

namespace Technology.Core.Auth
{
	[Token(Token = "0x2000D9C")]
	public class AuthenticationConfiguration : ScriptableObject
	{
		[Token(Token = "0x40040DD")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x5BE6CC", Offset = "0x5BE6CC")]
		public string GooglePlayClientId;

		[Token(Token = "0x40040DE")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x5BE704", Offset = "0x5BE704")]
		public int GoogleAvatarSize;

		[Token(Token = "0x40040DF")]
		[FieldOffset(Offset = "0x24")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x5BE73C", Offset = "0x5BE73C")]
		public bool EnableVerboseGoogleLogging;

		[Token(Token = "0x40040E0")]
		[FieldOffset(Offset = "0x28")]
		public string GooglePublicBase64Key;

		[Token(Token = "0x60053CB")]
		[Address(RVA = "0xC0BCD8", Offset = "0xC0BCD8", VA = "0xC0BCD8")]
		public AuthenticationConfiguration()
		{
		}
	}
}
