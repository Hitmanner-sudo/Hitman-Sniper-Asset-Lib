using System.Threading;
using Il2CppDummyDll;

namespace Frankfort.Threading.Internal
{
	[Token(Token = "0x2000A32")]
	public class MainThreadWatchdog
	{
		[Token(Token = "0x4003560")]
		[FieldOffset(Offset = "0x0")]
		private static Thread mainThread;

		[Token(Token = "0x60040D3")]
		[Address(RVA = "0x9ADCDC", Offset = "0x9ADCDC", VA = "0x9ADCDC")]
		public static void Init()
		{
		}

		[Token(Token = "0x60040D4")]
		[Address(RVA = "0x9AE5D8", Offset = "0x9AE5D8", VA = "0x9AE5D8")]
		public static bool CheckIfMainThread()
		{
			return default(bool);
		}

		[Token(Token = "0x60040D5")]
		[Address(RVA = "0x9AECFC", Offset = "0x9AECFC", VA = "0x9AECFC")]
		public MainThreadWatchdog()
		{
		}
	}
}
