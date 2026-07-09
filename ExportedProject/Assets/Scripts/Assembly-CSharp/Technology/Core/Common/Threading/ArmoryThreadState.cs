using Il2CppDummyDll;

namespace Technology.Core.Common.Threading
{
	[Token(Token = "0x2000E10")]
	public enum ArmoryThreadState
	{
		[Token(Token = "0x4004268")]
		Canceled = 0,
		[Token(Token = "0x4004269")]
		Created = 1,
		[Token(Token = "0x400426A")]
		Faulted = 2,
		[Token(Token = "0x400426B")]
		RanToCompletion = 3,
		[Token(Token = "0x400426C")]
		Running = 4,
		[Token(Token = "0x400426D")]
		WaitingForActivation = 5,
		[Token(Token = "0x400426E")]
		WaitingForChildrenToComplete = 6,
		[Token(Token = "0x400426F")]
		WaitingToRun = 7
	}
}
