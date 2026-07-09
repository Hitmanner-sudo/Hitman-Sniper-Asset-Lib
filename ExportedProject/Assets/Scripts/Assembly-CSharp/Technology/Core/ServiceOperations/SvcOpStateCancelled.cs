using Il2CppDummyDll;

namespace Technology.Core.ServiceOperations
{
	[Token(Token = "0x2000CE4")]
	public class SvcOpStateCancelled : SvcOpState
	{
		[Token(Token = "0x6004FC1")]
		[Address(RVA = "0xB481CC", Offset = "0xB481CC", VA = "0xB481CC", Slot = "5")]
		public override void Handle(SvcOp svcop)
		{
		}

		[Token(Token = "0x6004FC2")]
		[Address(RVA = "0xB481D0", Offset = "0xB481D0", VA = "0xB481D0")]
		public SvcOpStateCancelled()
		{
		}
	}
}
