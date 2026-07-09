using Il2CppDummyDll;

namespace Technology.Analytics
{
	[Token(Token = "0x2000E5F")]
	public struct MeasureShort : IMeasurable
	{
		[Token(Token = "0x40043E1")]
		[FieldOffset(Offset = "0x0")]
		private short _measurement;

		[Token(Token = "0x17000BE3")]
		public object Value
		{
			[Token(Token = "0x6005889")]
			[Address(RVA = "0x9B75F8", Offset = "0x9B75F8", VA = "0x9B75F8", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600588A")]
		[Address(RVA = "0x9B7658", Offset = "0x9B7658", VA = "0x9B7658")]
		public MeasureShort(short val)
		{
		}

		[Token(Token = "0x600588B")]
		[Address(RVA = "0x9B7660", Offset = "0x9B7660", VA = "0x9B7660", Slot = "4")]
		public void Increment()
		{
		}
	}
}
