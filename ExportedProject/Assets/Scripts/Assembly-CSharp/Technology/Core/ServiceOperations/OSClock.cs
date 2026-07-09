using Il2CppDummyDll;

namespace Technology.Core.ServiceOperations
{
	[Token(Token = "0x2000CF2")]
	public class OSClock
	{
		[Token(Token = "0x2000CF3")]
		public enum TimeUnit
		{
			[Token(Token = "0x4003E14")]
			UNIT_SECOND = 0,
			[Token(Token = "0x4003E15")]
			UNIT_MILI = 1,
			[Token(Token = "0x4003E16")]
			UNIT_MICRO = 2
		}

		[Token(Token = "0x4003E11")]
		[FieldOffset(Offset = "0x0")]
		private static OSClock instance;

		[Token(Token = "0x4003E12")]
		[FieldOffset(Offset = "0x10")]
		private long _clock;

		[Token(Token = "0x17000A91")]
		public static OSClock Instance
		{
			[Token(Token = "0x6005019")]
			[Address(RVA = "0x9E8624", Offset = "0x9E8624", VA = "0x9E8624")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600501A")]
		[Address(RVA = "0x9E86A8", Offset = "0x9E86A8", VA = "0x9E86A8")]
		public OSClock()
		{
		}

		[Token(Token = "0x600501B")]
		[Address(RVA = "0x9E87BC", Offset = "0x9E87BC", VA = "0x9E87BC")]
		public OSClock(long ticks)
		{
		}

		[Token(Token = "0x600501C")]
		[Address(RVA = "0x9E87E8", Offset = "0x9E87E8", VA = "0x9E87E8")]
		public static OSClock GetClock()
		{
			return null;
		}

		[Token(Token = "0x600501D")]
		[Address(RVA = "0x9E8848", Offset = "0x9E8848", VA = "0x9E8848")]
		public long Elapsed(TimeUnit unit)
		{
			return default(long);
		}

		[Token(Token = "0x600501E")]
		[Address(RVA = "0x9E86D4", Offset = "0x9E86D4", VA = "0x9E86D4")]
		private static long MiliSinceEpoch()
		{
			return default(long);
		}
	}
}
