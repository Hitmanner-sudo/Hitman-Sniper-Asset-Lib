using Il2CppDummyDll;
using UnityEngine;

namespace Technology
{
	[Token(Token = "0x2000AC7")]
	public class NotificationConfiguration : ScriptableObject
	{
		[Token(Token = "0x400372E")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "DescriptionAttribute", RVA = "0x5BC078", Offset = "0x5BC078")]
		public bool AutomaticallyRegisterToken;

		[Token(Token = "0x6004347")]
		[Address(RVA = "0xC5EAEC", Offset = "0xC5EAEC", VA = "0xC5EAEC")]
		public NotificationConfiguration()
		{
		}
	}
}
