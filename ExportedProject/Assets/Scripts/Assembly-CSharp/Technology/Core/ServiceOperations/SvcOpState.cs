using Il2CppDummyDll;

namespace Technology.Core.ServiceOperations
{
	[Token(Token = "0x2000CE3")]
	public abstract class SvcOpState : ISrvOpState
	{
		[Token(Token = "0x6004FBF")]
		public abstract void Handle(SvcOp svcop);

		[Token(Token = "0x6004FC0")]
		[Address(RVA = "0xB481C4", Offset = "0xB481C4", VA = "0xB481C4")]
		protected SvcOpState()
		{
		}
	}
}
