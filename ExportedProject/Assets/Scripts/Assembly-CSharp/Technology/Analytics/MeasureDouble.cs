using Il2CppDummyDll;

namespace Technology.Analytics
{
	[Token(Token = "0x2000E60")]
	public struct MeasureDouble : IMeasurable
	{
		[Token(Token = "0x40043E2")]
		[FieldOffset(Offset = "0x0")]
		private double _measurement;

		[Token(Token = "0x17000BE4")]
		public object Value
		{
			[Token(Token = "0x600588C")]
			[Address(RVA = "0x9B7488", Offset = "0x9B7488", VA = "0x9B7488", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600588D")]
		[Address(RVA = "0x9B74E8", Offset = "0x9B74E8", VA = "0x9B74E8")]
		public MeasureDouble(double val)
		{
		}

		[Token(Token = "0x600588E")]
		[Address(RVA = "0x9B74F0", Offset = "0x9B74F0", VA = "0x9B74F0", Slot = "4")]
		public void Increment()
		{
		}
	}
}
