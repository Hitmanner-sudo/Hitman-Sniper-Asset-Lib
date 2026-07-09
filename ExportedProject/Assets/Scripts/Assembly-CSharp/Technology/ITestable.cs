using Il2CppDummyDll;

namespace Technology
{
	[Token(Token = "0x2000A87")]
	public interface ITestable
	{
		[Token(Token = "0x6004246")]
		void Start(TestSuite testSuite);

		[Token(Token = "0x6004247")]
		void Cleanup();
	}
}
