using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Technology.Security
{
	[Token(Token = "0x2000C28")]
	public static class ArmorySecurityAccess
	{
		[Token(Token = "0x6004CC3")]
		public static T2 RevertFilter<T1, T2>(FilterType type, T1 output, [Optional] T2 defaultResponse)
		{
			return (T2)null;
		}

		[Token(Token = "0x6004CC4")]
		public static T2 ApplyFilter<T1, T2>(FilterType type, T1 input, [Optional] T2 defaultOutput)
		{
			return (T2)null;
		}
	}
}
