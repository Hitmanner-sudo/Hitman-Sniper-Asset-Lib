using System.Collections.Generic;
using Il2CppDummyDll;

namespace Technology
{
	[Token(Token = "0x2000A92")]
	public sealed class TestCaseResults
	{
		[Token(Token = "0x2000A93")]
		public struct TestCaseResult
		{
			[Token(Token = "0x40036A9")]
			[FieldOffset(Offset = "0x0")]
			public string TestCaseName;

			[Token(Token = "0x40036AA")]
			[FieldOffset(Offset = "0x8")]
			public string TestName;

			[Token(Token = "0x40036AB")]
			[FieldOffset(Offset = "0x10")]
			public TestResults TestResults;
		}

		[Token(Token = "0x40036A7")]
		[FieldOffset(Offset = "0x10")]
		public bool Passed;

		[Token(Token = "0x40036A8")]
		[FieldOffset(Offset = "0x18")]
		private List<TestCaseResult> _results;

		[Token(Token = "0x17000881")]
		public IEnumerable<TestCaseResult> Results
		{
			[Token(Token = "0x6004278")]
			[Address(RVA = "0xAC2778", Offset = "0xAC2778", VA = "0xAC2778")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6004279")]
		[Address(RVA = "0xAC2780", Offset = "0xAC2780", VA = "0xAC2780")]
		public void AddResult(string testCaseName, string testName, TestResults testResults)
		{
		}

		[Token(Token = "0x600427A")]
		[Address(RVA = "0xAC282C", Offset = "0xAC282C", VA = "0xAC282C")]
		public TestCaseResults()
		{
		}
	}
}
