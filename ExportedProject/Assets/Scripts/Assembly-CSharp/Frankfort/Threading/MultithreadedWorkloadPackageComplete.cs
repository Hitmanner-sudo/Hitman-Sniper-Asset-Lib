using Il2CppDummyDll;

namespace Frankfort.Threading
{
	[Token(Token = "0x2000A2A")]
	public delegate void MultithreadedWorkloadPackageComplete<T>(T[] workLoad, int firstIndex, int lastIndex);
}
