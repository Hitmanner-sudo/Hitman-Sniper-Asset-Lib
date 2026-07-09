using Il2CppDummyDll;

namespace Frankfort.Threading
{
	[Token(Token = "0x2000A24")]
	public interface IThreadWorkerObject
	{
		[Token(Token = "0x6004089")]
		void ExecuteThreadedWork();

		[Token(Token = "0x600408A")]
		void AbortThreadedWork();
	}
}
