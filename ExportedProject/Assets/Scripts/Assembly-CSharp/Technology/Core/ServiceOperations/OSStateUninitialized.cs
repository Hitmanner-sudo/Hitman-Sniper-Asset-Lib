using System;
using Il2CppDummyDll;

namespace Technology.Core.ServiceOperations
{
	[Token(Token = "0x2000CB4")]
	public class OSStateUninitialized : IOSState
	{
		[Token(Token = "0x2000CB5")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5987DC", Offset = "0x5987DC")]
		private sealed class _003C_003Ec__DisplayClass2_0
		{
			[Token(Token = "0x4003D8D")]
			[FieldOffset(Offset = "0x10")]
			public OnlineSuite os;

			[Token(Token = "0x6004E96")]
			[Address(RVA = "0x8CD268", Offset = "0x8CD268", VA = "0x8CD268")]
			public _003C_003Ec__DisplayClass2_0()
			{
			}

			[Token(Token = "0x6004E97")]
			[Address(RVA = "0x8CD270", Offset = "0x8CD270", VA = "0x8CD270")]
			internal void _003CHandleInitialize_003Eb__0(bool isPaused)
			{
			}
		}

		[Token(Token = "0x4003D8C")]
		[FieldOffset(Offset = "0x10")]
		private Action<bool> _pauseCallback;

		[Token(Token = "0x6004E92")]
		[Address(RVA = "0x9E9614", Offset = "0x9E9614", VA = "0x9E9614", Slot = "4")]
		public void Start(OnlineSuite os)
		{
		}

		[Token(Token = "0x6004E93")]
		[Address(RVA = "0x9E9618", Offset = "0x9E9618", VA = "0x9E9618", Slot = "5")]
		public void HandleInitialize(OnlineSuite os)
		{
		}

		[Token(Token = "0x6004E94")]
		[Address(RVA = "0x9E97D4", Offset = "0x9E97D4", VA = "0x9E97D4")]
		private static void OnApplicationPaused(bool isPaused, OnlineSuite os)
		{
		}

		[Token(Token = "0x6004E95")]
		[Address(RVA = "0x9E9A20", Offset = "0x9E9A20", VA = "0x9E9A20")]
		public OSStateUninitialized()
		{
		}
	}
}
