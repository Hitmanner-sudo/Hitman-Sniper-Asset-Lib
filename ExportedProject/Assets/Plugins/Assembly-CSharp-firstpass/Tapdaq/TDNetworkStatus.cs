using System;
using Il2CppDummyDll;

namespace Tapdaq
{
	[Serializable]
	[Token(Token = "0x2000077")]
	public class TDNetworkStatus
	{
		[Token(Token = "0x4000227")]
		[FieldOffset(Offset = "0x10")]
		public string name;

		[Token(Token = "0x4000228")]
		[FieldOffset(Offset = "0x18")]
		public string status;

		[Token(Token = "0x4000229")]
		[FieldOffset(Offset = "0x20")]
		public TDAdError error;

		[Token(Token = "0x60002EF")]
		[Address(RVA = "0x18BAF50", Offset = "0x18BAF50", VA = "0x18BAF50")]
		public TDNetworkStatus()
		{
		}
	}
}
