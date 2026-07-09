using System.Collections.Generic;
using Il2CppDummyDll;

namespace Frankfort.Threading.Internal
{
	[Token(Token = "0x2000A30")]
	public static class MainThreadDispatcher
	{
		[Token(Token = "0x400355C")]
		[FieldOffset(Offset = "0x0")]
		private static List<ThreadDispatchAction> dispatchActions;

		[Token(Token = "0x400355D")]
		[FieldOffset(Offset = "0x8")]
		private static bool helperCreated;

		[Token(Token = "0x400355E")]
		[FieldOffset(Offset = "0xC")]
		public static int currentFrame;

		[Token(Token = "0x60040C6")]
		[Address(RVA = "0x9ADEE8", Offset = "0x9ADEE8", VA = "0x9ADEE8")]
		public static void Init()
		{
		}

		[Token(Token = "0x60040C7")]
		[Address(RVA = "0x9ADF70", Offset = "0x9ADF70", VA = "0x9ADF70")]
		private static void CreateHelperGameObject()
		{
		}

		[Token(Token = "0x60040C8")]
		[Address(RVA = "0x9ADE7C", Offset = "0x9ADE7C", VA = "0x9ADE7C")]
		public static void Update()
		{
		}

		[Token(Token = "0x60040C9")]
		[Address(RVA = "0x9AE0A0", Offset = "0x9AE0A0", VA = "0x9AE0A0")]
		private static void DispatchActionsIfPresent()
		{
		}

		[Token(Token = "0x60040CA")]
		[Address(RVA = "0x9AE3D8", Offset = "0x9AE3D8", VA = "0x9AE3D8")]
		public static void DispatchToMainThread(ThreadDispatchDelegate dispatchCall, bool waitForExecution = false, bool safeMode = true)
		{
		}

		[Token(Token = "0x60040CB")]
		[Address(RVA = "0x9AE650", Offset = "0x9AE650", VA = "0x9AE650")]
		public static void DispatchToMainThread(ThreadDispatchDelegateArg dispatchCall, object dispatchArgument, bool waitForExecution = false, bool safeMode = true)
		{
		}

		[Token(Token = "0x60040CC")]
		[Address(RVA = "0x9AE85C", Offset = "0x9AE85C", VA = "0x9AE85C")]
		public static object DispatchToMainThreadReturn(ThreadDispatchDelegateArgReturn dispatchCall, object dispatchArgument, bool safeMode = true)
		{
			return null;
		}

		[Token(Token = "0x60040CD")]
		[Address(RVA = "0x9AEA6C", Offset = "0x9AEA6C", VA = "0x9AEA6C")]
		public static object DispatchToMainThreadReturn(ThreadDispatchDelegateReturn dispatchCall, bool safeMode = true)
		{
			return null;
		}
	}
}
