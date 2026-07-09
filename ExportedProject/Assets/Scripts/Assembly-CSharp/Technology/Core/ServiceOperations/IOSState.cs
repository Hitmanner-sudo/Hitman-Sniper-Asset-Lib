using Il2CppDummyDll;

namespace Technology.Core.ServiceOperations
{
	[Token(Token = "0x2000CAE")]
	public interface IOSState
	{
		[Token(Token = "0x6004E82")]
		void Start(OnlineSuite os);

		[Token(Token = "0x6004E83")]
		void HandleInitialize(OnlineSuite os);
	}
}
