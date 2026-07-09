using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Tapdaq
{
	[Serializable]
	[Token(Token = "0x2000075")]
	public class TDAdError
	{
		[Token(Token = "0x4000220")]
		[FieldOffset(Offset = "0x10")]
		public int code;

		[Token(Token = "0x4000221")]
		[FieldOffset(Offset = "0x18")]
		public string message;

		[Token(Token = "0x4000222")]
		[FieldOffset(Offset = "0x20")]
		public Dictionary<string, List<TDAdError>> subErrors;

		[Token(Token = "0x60002E7")]
		[Address(RVA = "0x10F2060", Offset = "0x10F2060", VA = "0x10F2060")]
		public TDAdError()
		{
		}
	}
}
