using Il2CppDummyDll;

namespace Frankfort.Threading.Internal
{
	[Token(Token = "0x2000A36")]
	public delegate void ThreadWorkloadExecutorArgIndexed<T>(T workload, int workloadIndex, object extraArgument);
}
