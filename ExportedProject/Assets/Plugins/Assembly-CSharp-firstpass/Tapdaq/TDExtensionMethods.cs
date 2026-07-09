using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Tapdaq
{
	[Token(Token = "0x2000068")]
	public static class TDExtensionMethods
	{
		[Token(Token = "0x6000296")]
		[Address(RVA = "0x18BA47C", Offset = "0x18BA47C", VA = "0x18BA47C")]
		public static int ParseInt(this string str, int defaultValue)
		{
			return default(int);
		}

		[Token(Token = "0x6000297")]
		[Address(RVA = "0x18BA4B4", Offset = "0x18BA4B4", VA = "0x18BA4B4")]
		public static float ParseFloat(this string str, float defaultValue)
		{
			return default(float);
		}

		[Token(Token = "0x6000298")]
		public static TV GetValue<TK, TV>(this Dictionary<TK, TV> dict, TK key, [Optional] TV defaultValue)
		{
			return (TV)null;
		}

		[Token(Token = "0x6000299")]
		public static T GetValueOrDefault<T>(this List<T> list, int index, [Optional] T def)
		{
			return (T)null;
		}
	}
}
