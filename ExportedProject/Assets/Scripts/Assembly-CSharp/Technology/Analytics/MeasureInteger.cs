using Il2CppDummyDll;

namespace Technology.Analytics
{
	[Token(Token = "0x2000E5E")]
	public struct MeasureInteger : IMeasurable
	{
		[Token(Token = "0x40043E0")]
		[FieldOffset(Offset = "0x0")]
		private int _measurement;

		[Token(Token = "0x17000BE2")]
		public object Value
		{
			[Token(Token = "0x6005886")]
			[Address(RVA = "0x9B7580", Offset = "0x9B7580", VA = "0x9B7580", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6005887")]
		[Address(RVA = "0x9B75E0", Offset = "0x9B75E0", VA = "0x9B75E0")]
		public MeasureInteger(int val)
		{
		}

		[Token(Token = "0x6005888")]
		[Address(RVA = "0x9B75E8", Offset = "0x9B75E8", VA = "0x9B75E8", Slot = "4")]
		public void Increment()
		{
		}
	}
}
