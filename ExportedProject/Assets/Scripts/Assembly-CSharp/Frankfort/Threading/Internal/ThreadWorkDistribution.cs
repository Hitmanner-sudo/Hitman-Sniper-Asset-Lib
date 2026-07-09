using Il2CppDummyDll;

namespace Frankfort.Threading.Internal
{
	[Token(Token = "0x2000A39")]
	public class ThreadWorkDistribution<T> : IThreadWorkerObject
	{
		[Token(Token = "0x4003565")]
		[FieldOffset(Offset = "0x0")]
		public int ID;

		[Token(Token = "0x4003566")]
		[FieldOffset(Offset = "0x0")]
		public ThreadWorkloadExecutor<T> workloadExecutor;

		[Token(Token = "0x4003567")]
		[FieldOffset(Offset = "0x0")]
		public ThreadWorkloadExecutorIndexed<T> workloadExecutorIndexed;

		[Token(Token = "0x4003568")]
		[FieldOffset(Offset = "0x0")]
		public ThreadWorkloadExecutorArg<T> workloadExecutorArg;

		[Token(Token = "0x4003569")]
		[FieldOffset(Offset = "0x0")]
		public ThreadWorkloadExecutorArgIndexed<T> workloadExecutorArgIndexed;

		[Token(Token = "0x400356A")]
		[FieldOffset(Offset = "0x0")]
		public int startIndex;

		[Token(Token = "0x400356B")]
		[FieldOffset(Offset = "0x0")]
		public int endIndex;

		[Token(Token = "0x400356C")]
		[FieldOffset(Offset = "0x0")]
		public T[] workLoad;

		[Token(Token = "0x400356D")]
		[FieldOffset(Offset = "0x0")]
		public object extraArgument;

		[Token(Token = "0x400356E")]
		[FieldOffset(Offset = "0x0")]
		private bool _isAborted;

		[Token(Token = "0x60040EB")]
		public ThreadWorkDistribution(ThreadWorkloadExecutor<T> workloadExecutor, T[] workLoad, int startIndex, int endIndex)
		{
		}

		[Token(Token = "0x60040EC")]
		public ThreadWorkDistribution(ThreadWorkloadExecutorIndexed<T> workloadExecutorIndexed, T[] workLoad, int startIndex, int endIndex)
		{
		}

		[Token(Token = "0x60040ED")]
		public ThreadWorkDistribution(ThreadWorkloadExecutorArg<T> workloadExecutorArg, T[] workLoad, object extraArgument, int startIndex, int endIndex)
		{
		}

		[Token(Token = "0x60040EE")]
		public ThreadWorkDistribution(ThreadWorkloadExecutorArgIndexed<T> workloadExecutorArgIndexed, T[] workLoad, object extraArgument, int startIndex, int endIndex)
		{
		}

		[Token(Token = "0x60040EF")]
		public void ExecuteThreadedWork()
		{
		}

		[Token(Token = "0x60040F0")]
		public void AbortThreadedWork()
		{
		}
	}
}
