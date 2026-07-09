using Il2CppDummyDll;
using UnityEngine;

namespace Technology
{
	[Token(Token = "0x2000A70")]
	public static class Extensions
	{
		[Token(Token = "0x60041E6")]
		[Address(RVA = "0x94CA14", Offset = "0x94CA14", VA = "0x94CA14")]
		public static Transform FindTransform(this Transform target, string name)
		{
			return null;
		}

		[Token(Token = "0x60041E7")]
		[Address(RVA = "0x94CB1C", Offset = "0x94CB1C", VA = "0x94CB1C")]
		public static double ToDecibelsVolume(this double linearVolume)
		{
			return default(double);
		}

		[Token(Token = "0x60041E8")]
		[Address(RVA = "0x94CB90", Offset = "0x94CB90", VA = "0x94CB90")]
		public static double ToLinearVolume(this double decibelVolume)
		{
			return default(double);
		}

		[Token(Token = "0x60041E9")]
		[Address(RVA = "0x94CC04", Offset = "0x94CC04", VA = "0x94CC04")]
		public static float ToDecibelsVolume(this float linearVolume)
		{
			return default(float);
		}

		[Token(Token = "0x60041EA")]
		[Address(RVA = "0x94CC20", Offset = "0x94CC20", VA = "0x94CC20")]
		public static float ToLinearVolume(this float decibelVolume)
		{
			return default(float);
		}
	}
}
