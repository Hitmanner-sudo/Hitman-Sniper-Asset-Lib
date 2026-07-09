using System;
using System.Collections.Generic;
using System.Reflection;
using Il2CppDummyDll;
using Technology.Core.Logging;

namespace Technology
{
	[Token(Token = "0x2000A96")]
	public sealed class TestSuite
	{
		[Serializable]
		[Token(Token = "0x2000A97")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x597B40", Offset = "0x597B40")]
		private sealed class _003C_003Ec
		{
			[Token(Token = "0x40036B5")]
			[FieldOffset(Offset = "0x0")]
			public static readonly _003C_003Ec _003C_003E9;

			[Token(Token = "0x40036B6")]
			[FieldOffset(Offset = "0x8")]
			public static Func<Assembly, IEnumerable<Type>> _003C_003E9__13_0;

			[Token(Token = "0x40036B7")]
			[FieldOffset(Offset = "0x10")]
			public static Func<Assembly, Type, _003C_003Ef__AnonymousType4<Assembly, Type>> _003C_003E9__13_1;

			[Token(Token = "0x40036B8")]
			[FieldOffset(Offset = "0x18")]
			public static Func<_003C_003Ef__AnonymousType4<Assembly, Type>, bool> _003C_003E9__13_2;

			[Token(Token = "0x40036B9")]
			[FieldOffset(Offset = "0x20")]
			public static Func<_003C_003Ef__AnonymousType4<Assembly, Type>, Testable> _003C_003E9__13_3;

			[Token(Token = "0x40036BA")]
			[FieldOffset(Offset = "0x28")]
			public static Func<MethodInfo, _003C_003Ef__AnonymousType5<MethodInfo, TestAttribute[]>> _003C_003E9__17_0;

			[Token(Token = "0x40036BB")]
			[FieldOffset(Offset = "0x30")]
			public static Func<_003C_003Ef__AnonymousType5<MethodInfo, TestAttribute[]>, MethodInfo> _003C_003E9__17_2;

			[Token(Token = "0x600428D")]
			[Address(RVA = "0xA566F4", Offset = "0xA566F4", VA = "0xA566F4")]
			public _003C_003Ec()
			{
			}

			[Token(Token = "0x600428E")]
			[Address(RVA = "0xA566FC", Offset = "0xA566FC", VA = "0xA566FC")]
			internal IEnumerable<Type> _003CFindAndAddTestCases_003Eb__13_0(Assembly a)
			{
				return null;
			}

			[Token(Token = "0x600428F")]
			[Address(RVA = "0xA56720", Offset = "0xA56720", VA = "0xA56720")]
			internal _003C_003Ef__AnonymousType4<Assembly, Type> _003CFindAndAddTestCases_003Eb__13_1(Assembly a, Type t)
			{
				return null;
			}

			[Token(Token = "0x6004290")]
			[Address(RVA = "0xA567A4", Offset = "0xA567A4", VA = "0xA567A4")]
			internal bool _003CFindAndAddTestCases_003Eb__13_2(_003C_003Ef__AnonymousType4<Assembly, Type> _003C_003Eh__TransparentIdentifier0)
			{
				return default(bool);
			}

			[Token(Token = "0x6004291")]
			[Address(RVA = "0xA568A8", Offset = "0xA568A8", VA = "0xA568A8")]
			internal Testable _003CFindAndAddTestCases_003Eb__13_3(_003C_003Ef__AnonymousType4<Assembly, Type> _003C_003Eh__TransparentIdentifier0)
			{
				return null;
			}

			[Token(Token = "0x6004292")]
			[Address(RVA = "0xA56940", Offset = "0xA56940", VA = "0xA56940")]
			internal _003C_003Ef__AnonymousType5<MethodInfo, TestAttribute[]> _003CRun_003Eb__17_0(MethodInfo m)
			{
				return null;
			}

			[Token(Token = "0x6004293")]
			[Address(RVA = "0xA56A78", Offset = "0xA56A78", VA = "0xA56A78")]
			internal MethodInfo _003CRun_003Eb__17_2(_003C_003Ef__AnonymousType5<MethodInfo, TestAttribute[]> _003C_003Eh__TransparentIdentifier0)
			{
				return null;
			}
		}

		[Token(Token = "0x2000A98")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x597B50", Offset = "0x597B50")]
		private sealed class _003C_003Ec__DisplayClass17_0
		{
			[Token(Token = "0x40036BC")]
			[FieldOffset(Offset = "0x10")]
			public TestType testType;

			[Token(Token = "0x40036BD")]
			[FieldOffset(Offset = "0x18")]
			public string testName;

			[Token(Token = "0x40036BE")]
			[FieldOffset(Offset = "0x20")]
			public Func<_003C_003Ef__AnonymousType5<MethodInfo, TestAttribute[]>, bool> _003C_003E9__1;

			[Token(Token = "0x6004294")]
			[Address(RVA = "0xA56AC0", Offset = "0xA56AC0", VA = "0xA56AC0")]
			public _003C_003Ec__DisplayClass17_0()
			{
			}

			[Token(Token = "0x6004295")]
			[Address(RVA = "0xA56AC8", Offset = "0xA56AC8", VA = "0xA56AC8")]
			internal bool _003CRun_003Eb__1(_003C_003Ef__AnonymousType5<MethodInfo, TestAttribute[]> _003C_003Eh__TransparentIdentifier0)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x40036B0")]
		[FieldOffset(Offset = "0x10")]
		private List<Testable> _testCases;

		[Token(Token = "0x40036B1")]
		[FieldOffset(Offset = "0x18")]
		private TestResults _results;

		[Token(Token = "0x40036B2")]
		[FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BBFB8", Offset = "0x5BBFB8")]
		private TestCaseResults _003C_testCaseResults_003Ek__BackingField;

		[Token(Token = "0x40036B3")]
		[FieldOffset(Offset = "0x28")]
		private bool _testsPassed;

		[Token(Token = "0x40036B4")]
		[FieldOffset(Offset = "0x29")]
		public bool ShowReport;

		[Token(Token = "0x17000883")]
		public TestCaseResults _testCaseResults
		{
			[Token(Token = "0x600427E")]
			[Address(RVA = "0xAC2AE8", Offset = "0xAC2AE8", VA = "0xAC2AE8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x625CF8", Offset = "0x625CF8")]
			get
			{
				return null;
			}
			[Token(Token = "0x600427F")]
			[Address(RVA = "0xAC2AF0", Offset = "0xAC2AF0", VA = "0xAC2AF0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x625D08", Offset = "0x625D08")]
			private set
			{
			}
		}

		[Token(Token = "0x17000884")]
		public bool TestsPassed
		{
			[Token(Token = "0x6004280")]
			[Address(RVA = "0xAC2AF8", Offset = "0xAC2AF8", VA = "0xAC2AF8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6004281")]
		[Address(RVA = "0xAC2B00", Offset = "0xAC2B00", VA = "0xAC2B00")]
		private bool ShouldFail(LogType logType)
		{
			return default(bool);
		}

		[Token(Token = "0x6004282")]
		[Address(RVA = "0xAC2B0C", Offset = "0xAC2B0C", VA = "0xAC2B0C")]
		public void HandleLog(string message, string callStack, LogType logType)
		{
		}

		[Token(Token = "0x6004283")]
		[Address(RVA = "0xAC2B3C", Offset = "0xAC2B3C", VA = "0xAC2B3C")]
		private void Report(string message)
		{
		}

		[Token(Token = "0x6004284")]
		[Address(RVA = "0xAC2B40", Offset = "0xAC2B40", VA = "0xAC2B40")]
		public void FindAndAddTestCases()
		{
		}

		[Token(Token = "0x6004285")]
		[Address(RVA = "0xAC316C", Offset = "0xAC316C", VA = "0xAC316C")]
		public void AddTestCase(Testable testCase)
		{
		}

		[Token(Token = "0x6004286")]
		[Address(RVA = "0xAC3228", Offset = "0xAC3228", VA = "0xAC3228")]
		public void ClearTestCases()
		{
		}

		[Token(Token = "0x6004287")]
		[Address(RVA = "0xAC327C", Offset = "0xAC327C", VA = "0xAC327C")]
		public void Run(TestType testType, bool verbose)
		{
		}

		[Token(Token = "0x6004288")]
		[Address(RVA = "0xAC3330", Offset = "0xAC3330", VA = "0xAC3330")]
		public void Run(TestType testType, string testName)
		{
		}

		[Token(Token = "0x6004289")]
		[Address(RVA = "0xAC3DB8", Offset = "0xAC3DB8", VA = "0xAC3DB8")]
		private TestResults RunTest(Testable instance, MethodInfo test)
		{
			return null;
		}

		[Token(Token = "0x600428A")]
		[Address(RVA = "0xAC3CCC", Offset = "0xAC3CCC", VA = "0xAC3CCC")]
		private void CleanupControllers()
		{
		}

		[Token(Token = "0x600428B")]
		[Address(RVA = "0xAC4254", Offset = "0xAC4254", VA = "0xAC4254")]
		public TestSuite()
		{
		}
	}
}
