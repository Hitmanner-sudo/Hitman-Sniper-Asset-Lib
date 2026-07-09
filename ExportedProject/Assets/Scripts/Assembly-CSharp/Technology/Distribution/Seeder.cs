using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Technology.Distribution
{
	[Serializable]
	[Token(Token = "0x2000BC2")]
	public class Seeder
	{
		[Token(Token = "0x2000BC3")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x598394", Offset = "0x598394")]
		private sealed class _003C_003Ec__DisplayClass6_0
		{
			[Token(Token = "0x4003B26")]
			[FieldOffset(Offset = "0x10")]
			public string currentSeedId;

			[Token(Token = "0x6004A83")]
			[Address(RVA = "0x8BA65C", Offset = "0x8BA65C", VA = "0x8BA65C")]
			public _003C_003Ec__DisplayClass6_0()
			{
			}

			[Token(Token = "0x6004A84")]
			[Address(RVA = "0x8BA664", Offset = "0x8BA664", VA = "0x8BA664")]
			internal bool _003CSeed_003Eb__0(Seed seed)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x2000BC4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5983A4", Offset = "0x5983A4")]
		private sealed class _003C_003Ec__DisplayClass8_0
		{
			[Token(Token = "0x4003B27")]
			[FieldOffset(Offset = "0x10")]
			public PlayerProfile player;

			[Token(Token = "0x4003B28")]
			[FieldOffset(Offset = "0x18")]
			public Predicate<Territory> _003C_003E9__1;

			[Token(Token = "0x4003B29")]
			[FieldOffset(Offset = "0x20")]
			public Predicate<Demographic> _003C_003E9__2;

			[Token(Token = "0x6004A85")]
			[Address(RVA = "0x8BA690", Offset = "0x8BA690", VA = "0x8BA690")]
			public _003C_003Ec__DisplayClass8_0()
			{
			}

			[Token(Token = "0x6004A86")]
			[Address(RVA = "0x8BA698", Offset = "0x8BA698", VA = "0x8BA698")]
			internal bool _003CGetQualifiedSeeds_003Eb__0(Seed x)
			{
				return default(bool);
			}

			[Token(Token = "0x6004A87")]
			[Address(RVA = "0x8BA6D4", Offset = "0x8BA6D4", VA = "0x8BA6D4")]
			internal bool _003CGetQualifiedSeeds_003Eb__1(Territory x)
			{
				return default(bool);
			}

			[Token(Token = "0x6004A88")]
			[Address(RVA = "0x8BA7F8", Offset = "0x8BA7F8", VA = "0x8BA7F8")]
			internal bool _003CGetQualifiedSeeds_003Eb__2(Demographic x)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x4003B22")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private Seed _selectedSeed;

		[Token(Token = "0x4003B23")]
		private const string SEED_START_DATETIME_KEY = "ABTestTimeSinceEpoch";

		[Token(Token = "0x4003B24")]
		private const string SEED_DURATION_HOURS_KEY = "ABTestDur";

		[Token(Token = "0x4003B25")]
		private const string SEED_NAME_KEY = "ABTestSeedNm";

		[Token(Token = "0x17000965")]
		public Seed SelectedSeed
		{
			[Token(Token = "0x6004A7D")]
			[Address(RVA = "0xB6AB78", Offset = "0xB6AB78", VA = "0xB6AB78")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6004A7E")]
		[Address(RVA = "0xB6AB80", Offset = "0xB6AB80", VA = "0xB6AB80")]
		public bool Seed(PlayerProfile player, List<Seed> seeds)
		{
			return default(bool);
		}

		[Token(Token = "0x6004A7F")]
		[Address(RVA = "0xB6AE30", Offset = "0xB6AE30", VA = "0xB6AE30")]
		private bool GetNewSeed(PlayerProfile player, List<Seed> seeds, TimeSpan l_ts)
		{
			return default(bool);
		}

		[Token(Token = "0x6004A80")]
		[Address(RVA = "0xB6B0F0", Offset = "0xB6B0F0", VA = "0xB6B0F0")]
		private List<Seed> GetQualifiedSeeds(PlayerProfile player, List<Seed> seeds)
		{
			return null;
		}

		[Token(Token = "0x6004A81")]
		[Address(RVA = "0xB6B4D4", Offset = "0xB6B4D4", VA = "0xB6B4D4")]
		public void Destroy()
		{
		}

		[Token(Token = "0x6004A82")]
		[Address(RVA = "0xB6B4DC", Offset = "0xB6B4DC", VA = "0xB6B4DC")]
		public Seeder()
		{
		}
	}
}
