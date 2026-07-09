using Il2CppDummyDll;

namespace Technology
{
	[Token(Token = "0x2000A86")]
	public interface IRuntimeMonitor
	{
		[Token(Token = "0x6004243")]
		void Start();

		[Token(Token = "0x6004244")]
		void Update();

		[Token(Token = "0x6004245")]
		void RunReport();
	}
}
