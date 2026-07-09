using Il2CppDummyDll;

namespace Technology.Analytics
{
	[Token(Token = "0x2000E61")]
	public struct MeasureFloat : IMeasurable
	{
		[Token(Token = "0x40043E3")]
		[FieldOffset(Offset = "0x0")]
		private float _measurement;

		[Token(Token = "0x17000BE5")]
		public object Value
		{
			[Token(Token = "0x600588F")]
			[Address(RVA = "0x9B7504", Offset = "0x9B7504", VA = "0x9B7504", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6005890")]
		[Address(RVA = "0x9B7564", Offset = "0x9B7564", VA = "0x9B7564")]
		public MeasureFloat(float val)
		{
		}

		[Token(Token = "0x6005891")]
		[Address(RVA = "0x9B756C", Offset = "0x9B756C", VA = "0x9B756C", Slot = "4")]
		public void Increment()
		{
		}
	}
}
