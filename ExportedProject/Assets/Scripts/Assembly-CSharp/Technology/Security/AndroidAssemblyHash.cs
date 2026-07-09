using System;
using Il2CppDummyDll;

namespace Technology.Security
{
	[Token(Token = "0x2000C2A")]
	public class AndroidAssemblyHash : AbstractAssemblyHash
	{
		[Token(Token = "0x2000C2B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5985D4", Offset = "0x5985D4")]
		private sealed class _003C_003Ec__DisplayClass0_0
		{
			[Token(Token = "0x4003C7B")]
			[FieldOffset(Offset = "0x10")]
			public AndroidAssemblyHash _003C_003E4__this;

			[Token(Token = "0x4003C7C")]
			[FieldOffset(Offset = "0x18")]
			public Action<string> onAssemblyHashComputed;

			[Token(Token = "0x6004CCA")]
			[Address(RVA = "0x9124DC", Offset = "0x9124DC", VA = "0x9124DC")]
			public _003C_003Ec__DisplayClass0_0()
			{
			}

			[Token(Token = "0x6004CCB")]
			[Address(RVA = "0x9124E4", Offset = "0x9124E4", VA = "0x9124E4")]
			internal void _003CCompute_003Eb__0(string hash)
			{
			}
		}

		[Token(Token = "0x6004CC8")]
		[Address(RVA = "0xD615F4", Offset = "0xD615F4", VA = "0xD615F4", Slot = "4")]
		public override void Compute(Action<string> onAssemblyHashComputed)
		{
		}

		[Token(Token = "0x6004CC9")]
		[Address(RVA = "0xD61BE8", Offset = "0xD61BE8", VA = "0xD61BE8")]
		public AndroidAssemblyHash()
		{
		}
	}
}
