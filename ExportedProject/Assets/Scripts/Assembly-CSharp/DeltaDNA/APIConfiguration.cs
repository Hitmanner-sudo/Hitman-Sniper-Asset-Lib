using System;
using Il2CppDummyDll;

namespace DeltaDNA
{
	[Serializable]
	[Token(Token = "0x20012FD")]
	[AttributeAttribute(Name = "XmlRootAttribute", RVA = "0x5AE7A4", Offset = "0x5AE7A4")]
	public sealed class APIConfiguration
	{
		[Token(Token = "0x4005B08")]
		[FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "XmlElementAttribute", RVA = "0x611128", Offset = "0x611128")]
		public string ApiKey;

		[Token(Token = "0x6006F7C")]
		[Address(RVA = "0xA9A7F4", Offset = "0xA9A7F4", VA = "0xA9A7F4")]
		public APIConfiguration()
		{
		}
	}
}
