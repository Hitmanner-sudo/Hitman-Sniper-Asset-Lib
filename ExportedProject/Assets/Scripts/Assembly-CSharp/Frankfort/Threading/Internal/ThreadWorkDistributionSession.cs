using Il2CppDummyDll;

namespace Frankfort.Threading.Internal
{
	[Token(Token = "0x2000A38")]
	public class ThreadWorkDistributionSession<T>
	{
		[Token(Token = "0x4003561")]
		[FieldOffset(Offset = "0x0")]
		public MultithreadedWorkloadComplete<T> onComplete;

		[Token(Token = "0x4003562")]
		[FieldOffset(Offset = "0x0")]
		public MultithreadedWorkloadPackageComplete<T> onPackageComplete;

		[Token(Token = "0x4003563")]
		[FieldOffset(Offset = "0x0")]
		public T[] workLoad;

		[Token(Token = "0x4003564")]
		[FieldOffset(Offset = "0x0")]
		public ThreadWorkDistribution<T>[] packages;

		[Token(Token = "0x60040E8")]
		public void onCompleteBubble(IThreadWorkerObject[] finishedObjects)
		{
		}

		[Token(Token = "0x60040E9")]
		public void onPackageCompleteBubble(IThreadWorkerObject finishedObject)
		{
		}

		[Token(Token = "0x60040EA")]
		public ThreadWorkDistributionSession()
		{
		}
	}
}
