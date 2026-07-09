using Il2CppDummyDll;

namespace Technology.Analytics
{
	[Token(Token = "0x2000E5D")]
	public struct MeasureStringArray : IMeasurable
	{
		[Token(Token = "0x40043DF")]
		[FieldOffset(Offset = "0x0")]
		private string _measurement;

		[Token(Token = "0x17000BE1")]
		public object Value
		{
			[Token(Token = "0x6005883")]
			[Address(RVA = "0x9B7670", Offset = "0x9B7670", VA = "0x9B7670", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6005884")]
		[Address(RVA = "0x9B7678", Offset = "0x9B7678", VA = "0x9B7678")]
		public MeasureStringArray(string val)
		{
		}

		[Token(Token = "0x6005885")]
		[Address(RVA = "0x9B7680", Offset = "0x9B7680", VA = "0x9B7680", Slot = "4")]
		public void Increment()
		{
		}
	}
}
