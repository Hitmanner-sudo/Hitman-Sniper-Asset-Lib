using Il2CppDummyDll;

namespace Frankfort.Threading.Internal
{
	[Token(Token = "0x2000A41")]
	public class ASyncThreadWorkData
	{
		[Token(Token = "0x4003587")]
		[FieldOffset(Offset = "0x10")]
		public ThreadWorkStatePackage[] workerPackages;

		[Token(Token = "0x4003588")]
		[FieldOffset(Offset = "0x18")]
		public int maxWorkingThreads;

		[Token(Token = "0x600410E")]
		[Address(RVA = "0xA9B9EC", Offset = "0xA9B9EC", VA = "0xA9B9EC")]
		public ASyncThreadWorkData(IThreadWorkerObject[] workerObjects, bool safeMode, int maxWorkingThreads = -1)
		{
		}

		[Token(Token = "0x600410F")]
		[Address(RVA = "0xA9BB98", Offset = "0xA9BB98", VA = "0xA9BB98")]
		public void Dispose()
		{
		}
	}
}
