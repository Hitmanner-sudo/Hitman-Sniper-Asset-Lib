using System;
using System.Collections.Generic;
using System.Threading;
using Il2CppDummyDll;

namespace Frankfort.Threading.Internal
{
	[Token(Token = "0x2000A3A")]
	public static class SingleThreadStarter
	{
		[Token(Token = "0x2000A3B")]
		private class SafeSingleThreadSession
		{
			[Serializable]
			[Token(Token = "0x2000A3C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x597910", Offset = "0x597910")]
			private sealed class _003C_003Ec
			{
				[Token(Token = "0x4003573")]
				[FieldOffset(Offset = "0x0")]
				public static readonly _003C_003Ec _003C_003E9;

				[Token(Token = "0x4003574")]
				[FieldOffset(Offset = "0x8")]
				public static ThreadDispatchDelegate _003C_003E9__4_0;

				[Token(Token = "0x4003575")]
				[FieldOffset(Offset = "0x10")]
				public static ThreadDispatchDelegate _003C_003E9__5_0;

				[Token(Token = "0x60040FD")]
				[Address(RVA = "0xA46EA4", Offset = "0xA46EA4", VA = "0xA46EA4")]
				public _003C_003Ec()
				{
				}

				[Token(Token = "0x60040FE")]
				[Address(RVA = "0xA46EAC", Offset = "0xA46EAC", VA = "0xA46EAC")]
				internal void _003CSafeExecte_ThreadStart_003Eb__4_0()
				{
				}

				[Token(Token = "0x60040FF")]
				[Address(RVA = "0xA46EB0", Offset = "0xA46EB0", VA = "0xA46EB0")]
				internal void _003CSafeExecte_ParamThreadStart_003Eb__5_0()
				{
				}
			}

			[Token(Token = "0x4003571")]
			[FieldOffset(Offset = "0x10")]
			private ThreadStart targetMethod;

			[Token(Token = "0x4003572")]
			[FieldOffset(Offset = "0x18")]
			private ParameterizedThreadStart paramTargetMethod;

			[Token(Token = "0x60040F8")]
			[Address(RVA = "0x8BFB78", Offset = "0x8BFB78", VA = "0x8BFB78")]
			public SafeSingleThreadSession(ThreadStart targetMethod)
			{
			}

			[Token(Token = "0x60040F9")]
			[Address(RVA = "0x8BFBA4", Offset = "0x8BFBA4", VA = "0x8BFBA4")]
			public SafeSingleThreadSession(ParameterizedThreadStart targetMethod)
			{
			}

			[Token(Token = "0x60040FA")]
			[Address(RVA = "0x8BFBD0", Offset = "0x8BFBD0", VA = "0x8BFBD0")]
			public void SafeExecte_ThreadStart()
			{
			}

			[Token(Token = "0x60040FB")]
			[Address(RVA = "0x8BFD74", Offset = "0x8BFD74", VA = "0x8BFD74")]
			public void SafeExecte_ParamThreadStart(object argument)
			{
			}
		}

		[Token(Token = "0x400356F")]
		[FieldOffset(Offset = "0x0")]
		private static bool helperCreated;

		[Token(Token = "0x4003570")]
		[FieldOffset(Offset = "0x8")]
		private static List<Thread> startedThreads;

		[Token(Token = "0x60040F1")]
		[Address(RVA = "0x8461D4", Offset = "0x8461D4", VA = "0x8461D4")]
		public static Thread StartSingleThread(ThreadStart targetMethod, bool safeMode = true)
		{
			return null;
		}

		[Token(Token = "0x60040F2")]
		[Address(RVA = "0x846468", Offset = "0x846468", VA = "0x846468")]
		public static Thread StartSingleThread(ParameterizedThreadStart targetMethod, object argument, bool safeMode = true)
		{
			return null;
		}

		[Token(Token = "0x60040F3")]
		[Address(RVA = "0x8463DC", Offset = "0x8463DC", VA = "0x8463DC")]
		private static void Init()
		{
		}

		[Token(Token = "0x60040F4")]
		[Address(RVA = "0x8466F0", Offset = "0x8466F0", VA = "0x8466F0")]
		private static void CreateHelperGameObject()
		{
		}

		[Token(Token = "0x60040F5")]
		[Address(RVA = "0x846080", Offset = "0x846080", VA = "0x846080")]
		public static void AbortRunningThreads()
		{
		}

		[Token(Token = "0x60040F6")]
		[Address(RVA = "0x846678", Offset = "0x846678", VA = "0x846678")]
		private static void ValidateThreadStates()
		{
		}
	}
}
