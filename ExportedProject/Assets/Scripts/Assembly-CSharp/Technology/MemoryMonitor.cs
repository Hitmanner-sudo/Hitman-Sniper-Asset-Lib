using Il2CppDummyDll;

namespace Technology
{
	[Token(Token = "0x2000A88")]
	public class MemoryMonitor : IRuntimeMonitor
	{
		[Token(Token = "0x4003691")]
		[FieldOffset(Offset = "0x10")]
		private uint maxMemoryUsed;

		[Token(Token = "0x6004248")]
		[Address(RVA = "0x9BA1B8", Offset = "0x9BA1B8", VA = "0x9BA1B8", Slot = "4")]
		public void Start()
		{
		}

		[Token(Token = "0x6004249")]
		[Address(RVA = "0x9BA1BC", Offset = "0x9BA1BC", VA = "0x9BA1BC", Slot = "5")]
		public void Update()
		{
		}

		[Token(Token = "0x600424A")]
		[Address(RVA = "0x9BA248", Offset = "0x9BA248", VA = "0x9BA248", Slot = "6")]
		public void RunReport()
		{
		}

		[Token(Token = "0x600424B")]
		[Address(RVA = "0x9BA24C", Offset = "0x9BA24C", VA = "0x9BA24C")]
		public MemoryMonitor()
		{
		}
	}
}
