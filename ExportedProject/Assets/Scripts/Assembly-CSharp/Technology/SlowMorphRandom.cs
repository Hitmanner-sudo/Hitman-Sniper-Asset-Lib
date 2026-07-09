using System.Collections.Generic;
using Il2CppDummyDll;

namespace Technology
{
	[Token(Token = "0x2000A51")]
	public class SlowMorphRandom
	{
		[Token(Token = "0x40035BC")]
		[FieldOffset(Offset = "0x10")]
		private LinkedList<int> _permutatedIndices;

		[Token(Token = "0x40035BD")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BBE38", Offset = "0x5BBE38")]
		private int _003CMin_003Ek__BackingField;

		[Token(Token = "0x40035BE")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BBE48", Offset = "0x5BBE48")]
		private int _003CMax_003Ek__BackingField;

		[Token(Token = "0x40035BF")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "RangeAttribute", RVA = "0x5BBE58", Offset = "0x5BBE58")]
		public float BucketRatio;

		[Token(Token = "0x17000858")]
		public int Min
		{
			[Token(Token = "0x6004152")]
			[Address(RVA = "0x8476A8", Offset = "0x8476A8", VA = "0x8476A8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x625458", Offset = "0x625458")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6004153")]
			[Address(RVA = "0x8476B0", Offset = "0x8476B0", VA = "0x8476B0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x625468", Offset = "0x625468")]
			private set
			{
			}
		}

		[Token(Token = "0x17000859")]
		public int Max
		{
			[Token(Token = "0x6004154")]
			[Address(RVA = "0x8476B8", Offset = "0x8476B8", VA = "0x8476B8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x625478", Offset = "0x625478")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6004155")]
			[Address(RVA = "0x8476C0", Offset = "0x8476C0", VA = "0x8476C0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x625488", Offset = "0x625488")]
			private set
			{
			}
		}

		[Token(Token = "0x1700085A")]
		public int Next
		{
			[Token(Token = "0x6004156")]
			[Address(RVA = "0x8476C8", Offset = "0x8476C8", VA = "0x8476C8")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x6004157")]
		[Address(RVA = "0x8478C0", Offset = "0x8478C0", VA = "0x8478C0")]
		public SlowMorphRandom()
		{
		}

		[Token(Token = "0x6004158")]
		[Address(RVA = "0x847948", Offset = "0x847948", VA = "0x847948")]
		public SlowMorphRandom(int min, int max)
		{
		}

		[Token(Token = "0x6004159")]
		[Address(RVA = "0x8479E8", Offset = "0x8479E8", VA = "0x8479E8")]
		public void ResetRange(int min, int max)
		{
		}

		[Token(Token = "0x600415A")]
		[Address(RVA = "0x847754", Offset = "0x847754", VA = "0x847754")]
		private void Insert(int index)
		{
		}
	}
}
