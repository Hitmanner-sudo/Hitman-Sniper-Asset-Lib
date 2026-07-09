using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Technology
{
	[Token(Token = "0x2000A83")]
	public class RangeClassifier
	{
		[Token(Token = "0x2000A84")]
		public class ComparisonComparer<T> : IComparer<T>
		{
			[Token(Token = "0x400368E")]
			[FieldOffset(Offset = "0x0")]
			private readonly Comparison<T> comparison;

			[Token(Token = "0x600423D")]
			public ComparisonComparer(Func<T, T, int> compare)
			{
			}

			[Token(Token = "0x600423E")]
			public int Compare(T x, T y)
			{
				return default(int);
			}
		}

		[Token(Token = "0x400368B")]
		[FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BBFA8", Offset = "0x5BBFA8")]
		private float[] _003CDivisions_003Ek__BackingField;

		[Token(Token = "0x400368C")]
		[FieldOffset(Offset = "0x18")]
		public float Threshold;

		[Token(Token = "0x400368D")]
		[FieldOffset(Offset = "0x20")]
		private IComparer<float> comparer;

		[Token(Token = "0x17000880")]
		public float[] Divisions
		{
			[Token(Token = "0x6004237")]
			[Address(RVA = "0xB3F150", Offset = "0xB3F150", VA = "0xB3F150")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x625B78", Offset = "0x625B78")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004238")]
			[Address(RVA = "0xB3F158", Offset = "0xB3F158", VA = "0xB3F158")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x625B88", Offset = "0x625B88")]
			private set
			{
			}
		}

		[Token(Token = "0x6004239")]
		[Address(RVA = "0xB3F160", Offset = "0xB3F160", VA = "0xB3F160")]
		public Range GetRange(int range)
		{
			return null;
		}

		[Token(Token = "0x600423A")]
		[Address(RVA = "0xB3F23C", Offset = "0xB3F23C", VA = "0xB3F23C")]
		public RangeClassifier(float[] divisions, float threshold)
		{
		}

		[Token(Token = "0x600423B")]
		[Address(RVA = "0xB3F278", Offset = "0xB3F278", VA = "0xB3F278")]
		public int Classify(float value, int lastDivision = -1)
		{
			return default(int);
		}

		[Token(Token = "0x600423C")]
		[Address(RVA = "0xB3F400", Offset = "0xB3F400", VA = "0xB3F400")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x625B98", Offset = "0x625B98")]
		private int _003CClassify_003Eb__9_0(float x, float y)
		{
			return default(int);
		}
	}
}
