using Il2CppDummyDll;

namespace Frankfort.Threading.Internal
{
	[Token(Token = "0x2000A3E")]
	public class ThreadDispatchAction
	{
		[Token(Token = "0x4003576")]
		[FieldOffset(Offset = "0x10")]
		public bool executed;

		[Token(Token = "0x4003577")]
		[FieldOffset(Offset = "0x18")]
		public object dispatchExecutionResult;

		[Token(Token = "0x4003578")]
		[FieldOffset(Offset = "0x20")]
		private ThreadDispatchDelegate dispatchCallClean;

		[Token(Token = "0x4003579")]
		[FieldOffset(Offset = "0x28")]
		private ThreadDispatchDelegateArg dispatchCallArg;

		[Token(Token = "0x400357A")]
		[FieldOffset(Offset = "0x30")]
		private ThreadDispatchDelegateArgReturn dispatchCallArgReturn;

		[Token(Token = "0x400357B")]
		[FieldOffset(Offset = "0x38")]
		private ThreadDispatchDelegateReturn dispatchCallReturn;

		[Token(Token = "0x400357C")]
		[FieldOffset(Offset = "0x40")]
		private object dispatchArgParam;

		[Token(Token = "0x400357D")]
		[FieldOffset(Offset = "0x48")]
		private bool safeMode;

		[Token(Token = "0x6004102")]
		[Address(RVA = "0xACC864", Offset = "0xACC864", VA = "0xACC864")]
		public ThreadDispatchAction()
		{
		}

		[Token(Token = "0x6004103")]
		[Address(RVA = "0xACC86C", Offset = "0xACC86C", VA = "0xACC86C")]
		public void Init(ThreadDispatchDelegate dispatchCall, bool waitForExecution, bool safeMode)
		{
		}

		[Token(Token = "0x6004104")]
		[Address(RVA = "0xACC924", Offset = "0xACC924", VA = "0xACC924")]
		public void Init(ThreadDispatchDelegateArg dispatchCall, object dispatchArgumentParameter, bool waitForExecution, bool safeMode)
		{
		}

		[Token(Token = "0x6004105")]
		[Address(RVA = "0xACC93C", Offset = "0xACC93C", VA = "0xACC93C")]
		public void Init(ThreadDispatchDelegateArgReturn dispatchCall, object dispatchArgumentParameter, bool safeMode)
		{
		}

		[Token(Token = "0x6004106")]
		[Address(RVA = "0xACC954", Offset = "0xACC954", VA = "0xACC954")]
		public void Init(ThreadDispatchDelegateReturn dispatchCall, bool safeMode)
		{
		}

		[Token(Token = "0x6004107")]
		[Address(RVA = "0xACC884", Offset = "0xACC884", VA = "0xACC884")]
		private void ValidateExecutionOnInit(bool waitForExecution)
		{
		}

		[Token(Token = "0x6004108")]
		[Address(RVA = "0xACC96C", Offset = "0xACC96C", VA = "0xACC96C")]
		public void ExecuteDispatch()
		{
		}
	}
}
