using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Frankfort.Threading.Internal
{
	[Token(Token = "0x2000A37")]
	public static class MultithreadedWorkloadHelper
	{
		[Token(Token = "0x60040E7")]
		public static ThreadPoolScheduler StartMultithreadedWorkloadExecution<D, T>(D executor, T[] workLoad, object extraArgument, MultithreadedWorkloadComplete<T> onComplete, MultithreadedWorkloadPackageComplete<T> onPackageComplete, [Optional][DefaultParameterValue(-1)] int maxThreads, [Optional] ThreadPoolScheduler scheduler, bool safeMode = true)
		{
			return null;
		}
	}
}
