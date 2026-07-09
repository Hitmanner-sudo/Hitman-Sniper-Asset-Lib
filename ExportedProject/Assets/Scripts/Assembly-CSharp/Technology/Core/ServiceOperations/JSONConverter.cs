using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Technology.Core.ServiceOperations
{
	[Token(Token = "0x2000D00")]
	public static class JSONConverter
	{
		[Token(Token = "0x600503E")]
		[Address(RVA = "0x10CD920", Offset = "0x10CD920", VA = "0x10CD920")]
		public static string Convert(string[] values, bool isJson = false)
		{
			return null;
		}

		[Token(Token = "0x600503F")]
		[Address(RVA = "0x10CDB6C", Offset = "0x10CDB6C", VA = "0x10CDB6C")]
		public static string Convert(KeyValuePair<string, sbyte>[] pairs, bool isJson = false)
		{
			return null;
		}

		[Token(Token = "0x6005040")]
		[Address(RVA = "0x10CDE04", Offset = "0x10CDE04", VA = "0x10CDE04")]
		public static string Convert(KeyValuePair<string, string>[] pairs, [Optional][DefaultParameterValue(false)] bool isJson, [Optional][DefaultParameterValue(false)] bool wrapInternalJsonKeyValue, [Optional] BitArray disableValueQuotesFlags)
		{
			return null;
		}
	}
}
