using System.Collections.Generic;
using Il2CppDummyDll;

namespace Technology
{
	[Token(Token = "0x2000A94")]
	public sealed class TestResults
	{
		[Token(Token = "0x2000A95")]
		public struct TestLine
		{
			[Token(Token = "0x40036AE")]
			[FieldOffset(Offset = "0x0")]
			public string Message;

			[Token(Token = "0x40036AF")]
			[FieldOffset(Offset = "0x8")]
			public string CallStack;
		}

		[Token(Token = "0x40036AC")]
		[FieldOffset(Offset = "0x10")]
		public bool Passed;

		[Token(Token = "0x40036AD")]
		[FieldOffset(Offset = "0x18")]
		private List<TestLine> _errors;

		[Token(Token = "0x17000882")]
		public IEnumerable<TestLine> Errors
		{
			[Token(Token = "0x600427B")]
			[Address(RVA = "0xAC29F0", Offset = "0xAC29F0", VA = "0xAC29F0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600427C")]
		[Address(RVA = "0xAC29F8", Offset = "0xAC29F8", VA = "0xAC29F8")]
		public void AddError(string message, string callStack)
		{
		}

		[Token(Token = "0x600427D")]
		[Address(RVA = "0xAC2A68", Offset = "0xAC2A68", VA = "0xAC2A68")]
		public TestResults()
		{
		}
	}
}
