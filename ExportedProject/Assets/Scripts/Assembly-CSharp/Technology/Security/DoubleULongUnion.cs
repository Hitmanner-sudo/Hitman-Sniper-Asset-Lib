using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Technology.Security
{
	[StructLayout((LayoutKind)2)]
	[Token(Token = "0x2000C38")]
	internal struct DoubleULongUnion
	{
		[Token(Token = "0x4003C8C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ulong Long;

		[Token(Token = "0x4003C8D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public double Double;
	}
}
