using System.Collections.Generic;
using Il2CppDummyDll;

namespace Technology.Core.ServiceOperations
{
	[Token(Token = "0x2000CD2")]
	public struct OsMetric
	{
		[Token(Token = "0x4003DD1")]
		[FieldOffset(Offset = "0x0")]
		private readonly KeyValuePair<char[], char[]>[] _attributes;

		[Token(Token = "0x4003DD2")]
		[FieldOffset(Offset = "0x8")]
		private readonly char[] _name;

		[Token(Token = "0x6004F75")]
		[Address(RVA = "0x9FEBE4", Offset = "0x9FEBE4", VA = "0x9FEBE4")]
		public OsMetric(char[] name, KeyValuePair<char[], char[]>[] attributes)
		{
		}

		[Token(Token = "0x6004F76")]
		[Address(RVA = "0x9FEBEC", Offset = "0x9FEBEC", VA = "0x9FEBEC")]
		public string ToJSON()
		{
			return null;
		}
	}
}
