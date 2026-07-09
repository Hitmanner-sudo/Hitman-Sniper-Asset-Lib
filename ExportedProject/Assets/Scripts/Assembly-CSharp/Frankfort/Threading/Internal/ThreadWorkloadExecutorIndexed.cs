using Il2CppDummyDll;

namespace Frankfort.Threading.Internal
{
	[Token(Token = "0x2000A34")]
	public delegate void ThreadWorkloadExecutorIndexed<T>(T workload, int workloadIndex);
}
