using Il2CppDummyDll;

namespace DeltaDNA
{
	[Token(Token = "0x2001335")]
	internal abstract class ExecutionCountBasedTriggerCondition : TriggerCondition
	{
		[Token(Token = "0x4005C16")]
		[FieldOffset(Offset = "0x10")]
		protected readonly ExecutionCountManager executionCountManager;

		[Token(Token = "0x4005C17")]
		[FieldOffset(Offset = "0x18")]
		protected readonly long variantId;

		[Token(Token = "0x6007118")]
		[Address(RVA = "0xE1D470", Offset = "0xE1D470", VA = "0xE1D470")]
		protected ExecutionCountBasedTriggerCondition(ExecutionCountManager executionCountManager, long variantId)
		{
		}

		[Token(Token = "0x6007119")]
		[Address(RVA = "0xE1D4A8", Offset = "0xE1D4A8", VA = "0xE1D4A8")]
		protected long getCurrentExecutionCount()
		{
			return default(long);
		}

		[Token(Token = "0x600711A")]
		public abstract bool CanExecute();
	}
}
