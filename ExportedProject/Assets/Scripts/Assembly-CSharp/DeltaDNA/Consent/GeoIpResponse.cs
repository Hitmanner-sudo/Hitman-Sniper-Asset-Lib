using System;
using Il2CppDummyDll;

namespace DeltaDNA.Consent
{
	[Serializable]
	[Token(Token = "0x200134C")]
	internal class GeoIpResponse
	{
		[Token(Token = "0x4005C5E")]
		[FieldOffset(Offset = "0x10")]
		public string identifier;

		[Token(Token = "0x4005C5F")]
		[FieldOffset(Offset = "0x18")]
		public string country;

		[Token(Token = "0x4005C60")]
		[FieldOffset(Offset = "0x20")]
		public string region;

		[Token(Token = "0x4005C61")]
		[FieldOffset(Offset = "0x28")]
		public int ageGateLimit;

		[Token(Token = "0x6007195")]
		[Address(RVA = "0xD9F460", Offset = "0xD9F460", VA = "0xD9F460")]
		public GeoIpResponse()
		{
		}
	}
}
