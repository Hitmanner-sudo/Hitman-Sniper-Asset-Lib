using Il2CppDummyDll;

namespace Technology
{
	[Token(Token = "0x2000A99")]
	public abstract class Testable : ITestable
	{
		[Token(Token = "0x6004296")]
		[Address(RVA = "0xAC42D4", Offset = "0xAC42D4", VA = "0xAC42D4", Slot = "6")]
		public virtual void Start(TestSuite testSuite)
		{
		}

		[Token(Token = "0x6004297")]
		[Address(RVA = "0xAC42D8", Offset = "0xAC42D8", VA = "0xAC42D8", Slot = "7")]
		public virtual void Cleanup()
		{
		}

		[Token(Token = "0x6004298")]
		[Address(RVA = "0xAC42DC", Offset = "0xAC42DC", VA = "0xAC42DC")]
		protected void ForceUpdate(int count = 0)
		{
		}

		[Token(Token = "0x6004299")]
		[Address(RVA = "0xAC43AC", Offset = "0xAC43AC", VA = "0xAC43AC")]
		protected Testable()
		{
		}
	}
}
