using Il2CppDummyDll;

namespace Technology.Core.Common
{
	[Token(Token = "0x2000E0C")]
	public enum WinRTThreadState
	{
		[Token(Token = "0x400425D")]
		Canceled = 0,
		[Token(Token = "0x400425E")]
		Created = 1,
		[Token(Token = "0x400425F")]
		Faulted = 2,
		[Token(Token = "0x4004260")]
		RanToCompletion = 3,
		[Token(Token = "0x4004261")]
		Running = 4,
		[Token(Token = "0x4004262")]
		WaitingForActivation = 5,
		[Token(Token = "0x4004263")]
		WaitingForChildrenToComplete = 6,
		[Token(Token = "0x4004264")]
		WaitingToRun = 7
	}
}
