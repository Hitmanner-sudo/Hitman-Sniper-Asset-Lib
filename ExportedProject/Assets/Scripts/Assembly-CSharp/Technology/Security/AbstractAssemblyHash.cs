using System;
using Il2CppDummyDll;

namespace Technology.Security
{
	[Token(Token = "0x2000C29")]
	public abstract class AbstractAssemblyHash
	{
		[Token(Token = "0x6004CC5")]
		public abstract void Compute(Action<string> onAssemblyHashComputed);

		[Token(Token = "0x6004CC6")]
		[Address(RVA = "0xA9EB64", Offset = "0xA9EB64", VA = "0xA9EB64")]
		protected void SaveInPlayerProfile(string hash)
		{
		}

		[Token(Token = "0x6004CC7")]
		[Address(RVA = "0xA9EB68", Offset = "0xA9EB68", VA = "0xA9EB68")]
		protected AbstractAssemblyHash()
		{
		}
	}
}
