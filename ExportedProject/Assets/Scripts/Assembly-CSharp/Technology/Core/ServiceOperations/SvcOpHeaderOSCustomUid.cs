using System.Collections.Generic;
using Il2CppDummyDll;

namespace Technology.Core.ServiceOperations
{
	[Token(Token = "0x2000D08")]
	public class SvcOpHeaderOSCustomUid : SvcOpHeaderOnlineSuite
	{
		[Token(Token = "0x4003E73")]
		[FieldOffset(Offset = "0x40")]
		private string _uid;

		[Token(Token = "0x600508E")]
		[Address(RVA = "0xD35658", Offset = "0xD35658", VA = "0xD35658")]
		public SvcOpHeaderOSCustomUid(string uid)
		{
		}

		[Token(Token = "0x600508F")]
		[Address(RVA = "0xD3AF38", Offset = "0xD3AF38", VA = "0xD3AF38", Slot = "6")]
		protected override KeyValuePair<string, string>[] DefineRuntime()
		{
			return null;
		}
	}
}
