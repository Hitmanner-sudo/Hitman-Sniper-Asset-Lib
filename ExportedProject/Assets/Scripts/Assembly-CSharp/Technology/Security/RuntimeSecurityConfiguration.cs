using Il2CppDummyDll;
using UnityEngine;

namespace Technology.Security
{
	[Token(Token = "0x2000C37")]
	public class RuntimeSecurityConfiguration : ScriptableObject
	{
		[Token(Token = "0x4003C8B")]
		[FieldOffset(Offset = "0x18")]
		public string GameSecurityTypeName;

		[Token(Token = "0x6004CEF")]
		[Address(RVA = "0xBA74CC", Offset = "0xBA74CC", VA = "0xBA74CC")]
		public RuntimeSecurityConfiguration()
		{
		}
	}
}
