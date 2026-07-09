using Il2CppDummyDll;

namespace DeltaDNA
{
	[Token(Token = "0x2001336")]
	internal class ExecutionCountTriggerCondition : ExecutionCountBasedTriggerCondition
	{
		[Token(Token = "0x4005C18")]
		[FieldOffset(Offset = "0x20")]
		private readonly long executionsRequired;

		[Token(Token = "0x600711B")]
		[Address(RVA = "0xE1D67C", Offset = "0xE1D67C", VA = "0xE1D67C")]
		public ExecutionCountTriggerCondition(long executionsRequired, ExecutionCountManager executionCountManager, long variantId)
		{
		}

		[Token(Token = "0x600711C")]
		[Address(RVA = "0xE1D6BC", Offset = "0xE1D6BC", VA = "0xE1D6BC", Slot = "5")]
		public override bool CanExecute()
		{
			return default(bool);
		}
	}
}
