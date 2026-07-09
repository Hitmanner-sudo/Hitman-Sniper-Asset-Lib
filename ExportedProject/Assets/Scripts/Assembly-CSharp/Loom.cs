using System.Runtime.InteropServices;
using System.Threading;
using Frankfort.Threading;
using Frankfort.Threading.Internal;
using Il2CppDummyDll;

[Token(Token = "0x20008C8")]
public static class Loom
{
	[Token(Token = "0x600387D")]
	[Address(RVA = "0x9DFFD0", Offset = "0x9DFFD0", VA = "0x9DFFD0")]
	public static Thread StartSingleThread(ThreadStart targetMethod, bool safeMode = true)
	{
		return null;
	}

	[Token(Token = "0x600387E")]
	[Address(RVA = "0x9E0044", Offset = "0x9E0044", VA = "0x9E0044")]
	public static Thread StartSingleThread(ParameterizedThreadStart targetMethod, object argument, bool safeMode = true)
	{
		return null;
	}

	[Token(Token = "0x600387F")]
	public static ThreadPoolScheduler StartMultithreadedWorkloadExecution<T>(ThreadWorkloadExecutor<T> workloadExecutor, T[] workLoad, MultithreadedWorkloadComplete<T> onComplete, MultithreadedWorkloadPackageComplete<T> onPackageComplete, [Optional][DefaultParameterValue(-1)] int maxThreads, [Optional] ThreadPoolScheduler scheduler, bool safeMode = true)
	{
		return null;
	}

	[Token(Token = "0x6003880")]
	public static ThreadPoolScheduler StartMultithreadedWorkloadExecution<T>(ThreadWorkloadExecutorIndexed<T> workloadExecutor, T[] workLoad, MultithreadedWorkloadComplete<T> onComplete, MultithreadedWorkloadPackageComplete<T> onPackageComplete, [Optional][DefaultParameterValue(-1)] int maxThreads, [Optional] ThreadPoolScheduler scheduler, bool safeMode = true)
	{
		return null;
	}

	[Token(Token = "0x6003881")]
	public static ThreadPoolScheduler StartMultithreadedWorkloadExecution<T>(ThreadWorkloadExecutorArg<T> workloadExecutor, T[] workLoad, object extraArgument, MultithreadedWorkloadComplete<T> onComplete, MultithreadedWorkloadPackageComplete<T> onPackageComplete, [Optional][DefaultParameterValue(-1)] int maxThreads, [Optional] ThreadPoolScheduler scheduler, bool safeMode = true)
	{
		return null;
	}

	[Token(Token = "0x6003882")]
	public static ThreadPoolScheduler StartMultithreadedWorkloadExecution<T>(ThreadWorkloadExecutorArgIndexed<T> workloadExecutor, T[] workLoad, object extraArgument, MultithreadedWorkloadComplete<T> onComplete, MultithreadedWorkloadPackageComplete<T> onPackageComplete, [Optional][DefaultParameterValue(-1)] int maxThreads, [Optional] ThreadPoolScheduler scheduler, bool safeMode = true)
	{
		return null;
	}

	[Token(Token = "0x6003883")]
	[Address(RVA = "0x9E00C0", Offset = "0x9E00C0", VA = "0x9E00C0")]
	public static ThreadPoolScheduler StartMultithreadedWorkerObjects(IThreadWorkerObject[] workerObjects, ThreadPoolSchedulerEvent onCompleteCallBack, [Optional] ThreadedWorkCompleteEvent onPackageExecuted, [Optional][DefaultParameterValue(-1)] int maxThreads, [Optional] ThreadPoolScheduler scheduler, bool safeMode = true)
	{
		return null;
	}

	[Token(Token = "0x6003884")]
	[Address(RVA = "0x9E0190", Offset = "0x9E0190", VA = "0x9E0190")]
	public static ThreadPoolScheduler CreateThreadPoolScheduler()
	{
		return null;
	}

	[Token(Token = "0x6003885")]
	[Address(RVA = "0x9E0200", Offset = "0x9E0200", VA = "0x9E0200")]
	public static ThreadPoolScheduler CreateThreadPoolScheduler(string name)
	{
		return null;
	}

	[Token(Token = "0x6003886")]
	[Address(RVA = "0x9E0270", Offset = "0x9E0270", VA = "0x9E0270")]
	public static void WaitForNextFrame(int waitFrames = 1)
	{
	}

	[Token(Token = "0x6003887")]
	[Address(RVA = "0x9E02C8", Offset = "0x9E02C8", VA = "0x9E02C8")]
	public static void WaitForSeconds(float seconds)
	{
	}

	[Token(Token = "0x6003888")]
	[Address(RVA = "0x9E0324", Offset = "0x9E0324", VA = "0x9E0324")]
	public static void DispatchToMainThread(ThreadDispatchDelegate dispatchCall, bool waitForExecution = false, bool safeMode = true)
	{
	}

	[Token(Token = "0x6003889")]
	[Address(RVA = "0x9E03A0", Offset = "0x9E03A0", VA = "0x9E03A0")]
	public static void DispatchToMainThread(ThreadDispatchDelegateArg dispatchCall, object dispatchArgument, bool waitForExecution = false, bool safeMode = true)
	{
	}

	[Token(Token = "0x600388A")]
	[Address(RVA = "0x9E042C", Offset = "0x9E042C", VA = "0x9E042C")]
	public static object DispatchToMainThreadReturn(ThreadDispatchDelegateArgReturn dispatchCall, object dispatchArgument, bool safeMode = true)
	{
		return null;
	}

	[Token(Token = "0x600388B")]
	[Address(RVA = "0x9E04A8", Offset = "0x9E04A8", VA = "0x9E04A8")]
	public static object DispatchToMainThreadReturn(ThreadDispatchDelegateReturn dispatchCall, bool safeMode = true)
	{
		return null;
	}

	[Token(Token = "0x600388C")]
	[Address(RVA = "0x9E051C", Offset = "0x9E051C", VA = "0x9E051C")]
	public static bool CheckUnityActive()
	{
		return default(bool);
	}

	[Token(Token = "0x600388D")]
	[Address(RVA = "0x9E0578", Offset = "0x9E0578", VA = "0x9E0578")]
	public static void SleepOrAbortIfUnityInactive()
	{
	}

	[Token(Token = "0x600388E")]
	[Address(RVA = "0x9DB3B0", Offset = "0x9DB3B0", VA = "0x9DB3B0")]
	public static bool CheckIfMainThread()
	{
		return default(bool);
	}
}
