using Il2CppDummyDll;

namespace Technology.Core.ServiceOperations
{
	[Token(Token = "0x2000CE7")]
	public class SvcOpStateInitialize : SvcOpState
	{
		[Token(Token = "0x6004FC7")]
		[Address(RVA = "0xB481F0", Offset = "0xB481F0", VA = "0xB481F0", Slot = "5")]
		public override void Handle(SvcOp svcop)
		{
		}

		[Token(Token = "0x6004FC8")]
		[Address(RVA = "0xB481F4", Offset = "0xB481F4", VA = "0xB481F4")]
		public SvcOpStateInitialize()
		{
		}
	}
}
