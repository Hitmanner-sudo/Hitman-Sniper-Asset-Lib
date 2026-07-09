using Il2CppDummyDll;

namespace Technology.Analytics
{
	[Token(Token = "0x2000E62")]
	public struct MeasureBoolean : IMeasurable
	{
		[Token(Token = "0x40043E4")]
		[FieldOffset(Offset = "0x0")]
		private bool _measurement;

		[Token(Token = "0x17000BE6")]
		public object Value
		{
			[Token(Token = "0x6005892")]
			[Address(RVA = "0x9B7418", Offset = "0x9B7418", VA = "0x9B7418", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6005893")]
		[Address(RVA = "0x9B7478", Offset = "0x9B7478", VA = "0x9B7478")]
		public MeasureBoolean(bool val)
		{
		}

		[Token(Token = "0x6005894")]
		[Address(RVA = "0x9B7484", Offset = "0x9B7484", VA = "0x9B7484", Slot = "4")]
		public void Increment()
		{
		}
	}
}
