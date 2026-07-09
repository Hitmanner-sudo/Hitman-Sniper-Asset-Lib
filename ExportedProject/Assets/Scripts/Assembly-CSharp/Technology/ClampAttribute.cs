using Il2CppDummyDll;
using UnityEngine;

namespace Technology
{
	[Token(Token = "0x2000AAA")]
	public class ClampAttribute : PropertyAttribute
	{
		[Token(Token = "0x40036E8")]
		[FieldOffset(Offset = "0x10")]
		public readonly float Min;

		[Token(Token = "0x40036E9")]
		[FieldOffset(Offset = "0x14")]
		public readonly float Max;

		[Token(Token = "0x60042F2")]
		[Address(RVA = "0xB00FDC", Offset = "0xB00FDC", VA = "0xB00FDC")]
		public ClampAttribute(float min, float max)
		{
		}

		[Token(Token = "0x60042F3")]
		[Address(RVA = "0xB01014", Offset = "0xB01014", VA = "0xB01014")]
		public ClampAttribute(int min, int max)
		{
		}
	}
}
