using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using SimpleJSON;

namespace Technology.Distribution
{
	[Token(Token = "0x2000BBF")]
	public class SeedParser
	{
		[Serializable]
		[Token(Token = "0x2000BC0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x598384", Offset = "0x598384")]
		private sealed class _003C_003Ec
		{
			[Token(Token = "0x4003B20")]
			[FieldOffset(Offset = "0x0")]
			public static readonly _003C_003Ec _003C_003E9;

			[Token(Token = "0x4003B21")]
			[FieldOffset(Offset = "0x8")]
			public static Func<Country, Territory> _003C_003E9__0_0;

			[Token(Token = "0x6004A75")]
			[Address(RVA = "0x8BA5F4", Offset = "0x8BA5F4", VA = "0x8BA5F4")]
			public _003C_003Ec()
			{
			}

			[Token(Token = "0x6004A76")]
			[Address(RVA = "0x8BA5FC", Offset = "0x8BA5FC", VA = "0x8BA5FC")]
			internal Territory _003CParse_003Eb__0_0(Country x)
			{
				return null;
			}
		}

		[Token(Token = "0x6004A70")]
		[Address(RVA = "0xB69730", Offset = "0xB69730", VA = "0xB69730")]
		public static List<Seed> Parse(JSONNode node)
		{
			return null;
		}

		[Token(Token = "0x6004A71")]
		[Address(RVA = "0xB69F98", Offset = "0xB69F98", VA = "0xB69F98")]
		public static List<Demographic> GetDemographics(JSONNode demoNode)
		{
			return null;
		}

		[Token(Token = "0x6004A72")]
		public static List<T> GetSet<T, E>(JSONNode node, T defaultValue, Func<E, T> func)
		{
			return null;
		}

		[Token(Token = "0x6004A73")]
		[Address(RVA = "0xB6A854", Offset = "0xB6A854", VA = "0xB6A854")]
		public SeedParser()
		{
		}
	}
}
