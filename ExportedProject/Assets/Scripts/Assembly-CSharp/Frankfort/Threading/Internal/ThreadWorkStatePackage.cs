using System;
using System.Threading;
using Il2CppDummyDll;

namespace Frankfort.Threading.Internal
{
	[Token(Token = "0x2000A3F")]
	public class ThreadWorkStatePackage
	{
		[Serializable]
		[Token(Token = "0x2000A40")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x597920", Offset = "0x597920")]
		private sealed class _003C_003Ec
		{
			[Token(Token = "0x4003585")]
			[FieldOffset(Offset = "0x0")]
			public static readonly _003C_003Ec _003C_003E9;

			[Token(Token = "0x4003586")]
			[FieldOffset(Offset = "0x8")]
			public static ThreadDispatchDelegate _003C_003E9__7_0;

			[Token(Token = "0x600410C")]
			[Address(RVA = "0xA372C0", Offset = "0xA372C0", VA = "0xA372C0")]
			public _003C_003Ec()
			{
			}

			[Token(Token = "0x600410D")]
			[Address(RVA = "0xA372C8", Offset = "0xA372C8", VA = "0xA372C8")]
			internal void _003CExecuteThreadWork_003Eb__7_0()
			{
			}
		}

		[Token(Token = "0x400357E")]
		[FieldOffset(Offset = "0x10")]
		public bool safeMode;

		[Token(Token = "0x400357F")]
		[FieldOffset(Offset = "0x11")]
		public bool started;

		[Token(Token = "0x4003580")]
		[FieldOffset(Offset = "0x12")]
		public bool running;

		[Token(Token = "0x4003581")]
		[FieldOffset(Offset = "0x13")]
		public bool finishedWorking;

		[Token(Token = "0x4003582")]
		[FieldOffset(Offset = "0x14")]
		public bool eventFired;

		[Token(Token = "0x4003583")]
		[FieldOffset(Offset = "0x18")]
		public IThreadWorkerObject workerObject;

		[Token(Token = "0x4003584")]
		[FieldOffset(Offset = "0x20")]
		public AutoResetEvent waitHandle;

		[Token(Token = "0x6004109")]
		[Address(RVA = "0xACED34", Offset = "0xACED34", VA = "0xACED34")]
		public void ExecuteThreadWork(object obj)
		{
		}

		[Token(Token = "0x600410A")]
		[Address(RVA = "0xACEFE4", Offset = "0xACEFE4", VA = "0xACEFE4")]
		public ThreadWorkStatePackage()
		{
		}
	}
}
