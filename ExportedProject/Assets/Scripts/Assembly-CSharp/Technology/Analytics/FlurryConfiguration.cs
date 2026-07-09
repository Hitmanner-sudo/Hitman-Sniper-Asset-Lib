using Il2CppDummyDll;
using UnityEngine;

namespace Technology.Analytics
{
	[Token(Token = "0x2000E56")]
	public class FlurryConfiguration : ScriptableObject
	{
		[Token(Token = "0x40043D6")]
		[FieldOffset(Offset = "0x18")]
		public string AndroidAPIKey;

		[Token(Token = "0x40043D7")]
		[FieldOffset(Offset = "0x20")]
		public string iOSAPIKey;

		[Token(Token = "0x17000BDA")]
		public string APIKey
		{
			[Token(Token = "0x600585D")]
			[Address(RVA = "0x959BD0", Offset = "0x959BD0", VA = "0x959BD0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600585E")]
		[Address(RVA = "0x959BD8", Offset = "0x959BD8", VA = "0x959BD8")]
		public FlurryConfiguration()
		{
		}
	}
}
