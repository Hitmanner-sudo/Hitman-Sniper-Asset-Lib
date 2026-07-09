using Il2CppDummyDll;

namespace DeltaDNA
{
	[Token(Token = "0x2001337")]
	internal class ExecutionRepeatTriggerCondition : ExecutionCountBasedTriggerCondition
	{
		[Token(Token = "0x4005C19")]
		[FieldOffset(Offset = "0x20")]
		private readonly long executionsRepeatInterval;

		[Token(Token = "0x4005C1A")]
		[FieldOffset(Offset = "0x28")]
		private long executionLimit;

		[Token(Token = "0x600711D")]
		[Address(RVA = "0xE1D6E4", Offset = "0xE1D6E4", VA = "0xE1D6E4")]
		public ExecutionRepeatTriggerCondition(long executionsRepeatInterval, ExecutionCountManager executionCountManager, long variantId)
		{
		}

		[Token(Token = "0x600711E")]
		[Address(RVA = "0xE1D72C", Offset = "0xE1D72C", VA = "0xE1D72C")]
		public void setExecutionLimit(long limit)
		{
		}

		[Token(Token = "0x600711F")]
		[Address(RVA = "0xE1D758", Offset = "0xE1D758", VA = "0xE1D758", Slot = "5")]
		public override bool CanExecute()
		{
			return default(bool);
		}
	}
}
