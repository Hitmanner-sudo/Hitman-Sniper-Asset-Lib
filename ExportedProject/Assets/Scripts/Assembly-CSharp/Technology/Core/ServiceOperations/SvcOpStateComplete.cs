using Il2CppDummyDll;

namespace Technology.Core.ServiceOperations
{
	[Token(Token = "0x2000CE5")]
	public class SvcOpStateComplete : SvcOpState
	{
		[Token(Token = "0x6004FC3")]
		[Address(RVA = "0xB481D8", Offset = "0xB481D8", VA = "0xB481D8", Slot = "5")]
		public override void Handle(SvcOp svcop)
		{
		}

		[Token(Token = "0x6004FC4")]
		[Address(RVA = "0xB481DC", Offset = "0xB481DC", VA = "0xB481DC")]
		public SvcOpStateComplete()
		{
		}
	}
}
