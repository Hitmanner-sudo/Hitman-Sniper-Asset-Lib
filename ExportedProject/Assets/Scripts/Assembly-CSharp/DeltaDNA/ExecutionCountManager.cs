using Il2CppDummyDll;

namespace DeltaDNA
{
	[Token(Token = "0x2001341")]
	public class ExecutionCountManager : SimpleDataStore<long, long>
	{
		[Token(Token = "0x6007160")]
		[Address(RVA = "0xE1D528", Offset = "0xE1D528", VA = "0xE1D528")]
		public ExecutionCountManager()
		{
		}

		[Token(Token = "0x6007161")]
		[Address(RVA = "0xE1D5D4", Offset = "0xE1D5D4", VA = "0xE1D5D4", Slot = "4")]
		protected override long parseKey(string key)
		{
			return default(long);
		}

		[Token(Token = "0x6007162")]
		[Address(RVA = "0xE1D5E0", Offset = "0xE1D5E0", VA = "0xE1D5E0", Slot = "5")]
		protected override long parseValue(string value)
		{
			return default(long);
		}

		[Token(Token = "0x6007163")]
		[Address(RVA = "0xE1D5EC", Offset = "0xE1D5EC", VA = "0xE1D5EC", Slot = "6")]
		protected override string createLine(long key, long value)
		{
			return null;
		}

		[Token(Token = "0x6007164")]
		[Address(RVA = "0xE1D4C8", Offset = "0xE1D4C8", VA = "0xE1D4C8")]
		public long GetExecutionCount(long variantId)
		{
			return default(long);
		}

		[Token(Token = "0x6007165")]
		[Address(RVA = "0xE1C1DC", Offset = "0xE1C1DC", VA = "0xE1C1DC")]
		public void incrementExecutionCount(long variantId)
		{
		}
	}
}
