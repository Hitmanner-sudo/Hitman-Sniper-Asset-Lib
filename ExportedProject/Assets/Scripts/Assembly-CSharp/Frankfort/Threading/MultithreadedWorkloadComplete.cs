using Il2CppDummyDll;

namespace Frankfort.Threading
{
	[Token(Token = "0x2000A29")]
	public delegate void MultithreadedWorkloadComplete<T>(T[] workLoad);
}
