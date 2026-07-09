using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Technology.Security
{
	[StructLayout((LayoutKind)2)]
	[Token(Token = "0x2000C39")]
	internal struct FloatUIntUnion
	{
		[Token(Token = "0x4003C8E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public uint Int;

		[Token(Token = "0x4003C8F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float Float;
	}
}
