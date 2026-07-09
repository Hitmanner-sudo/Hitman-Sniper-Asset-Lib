using System.Collections.Generic;
using System.Reflection;
using Il2CppDummyDll;

namespace Technology.Core.Common
{
	[Token(Token = "0x2000E02")]
	internal class WinRTAppDomain
	{
		[Token(Token = "0x600561B")]
		[Address(RVA = "0x87E61C", Offset = "0x87E61C", VA = "0x87E61C")]
		public static IEnumerable<Assembly> GetAssemblyList()
		{
			return null;
		}

		[Token(Token = "0x600561C")]
		[Address(RVA = "0x87E640", Offset = "0x87E640", VA = "0x87E640")]
		public WinRTAppDomain()
		{
		}
	}
}
