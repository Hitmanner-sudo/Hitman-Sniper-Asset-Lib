using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200060A")]
public class ZombieProperties : DataModel
{
	[Serializable]
	[Token(Token = "0x200060B")]
	public class ZombieDetail
	{
		[Token(Token = "0x4002163")]
		[FieldOffset(Offset = "0x10")]
		public Faction Faction;

		[Token(Token = "0x4002164")]
		[FieldOffset(Offset = "0x18")]
		public float TokenValue;

		[Token(Token = "0x4002165")]
		[FieldOffset(Offset = "0x1C")]
		public float PointValue;

		[NonSerialized]
		[Token(Token = "0x4002166")]
		[FieldOffset(Offset = "0x20")]
		public int BonusTokenValue;

		[Token(Token = "0x4002167")]
		[FieldOffset(Offset = "0x28")]
		public LazyUIAtlas BackgroundAtlas;

		[Token(Token = "0x4002168")]
		[FieldOffset(Offset = "0x30")]
		public string BackgroundName;

		[Token(Token = "0x4002169")]
		[FieldOffset(Offset = "0x38")]
		public Color BackgroundColor;

		[Token(Token = "0x400216A")]
		[FieldOffset(Offset = "0x48")]
		public LazyUIAtlas IconAtlas;

		[Token(Token = "0x400216B")]
		[FieldOffset(Offset = "0x50")]
		public string IconName;

		[Token(Token = "0x6002749")]
		[Address(RVA = "0xA43714", Offset = "0xA43714", VA = "0xA43714")]
		public int GetTokenValue()
		{
			return default(int);
		}

		[Token(Token = "0x600274A")]
		[Address(RVA = "0xA43740", Offset = "0xA43740", VA = "0xA43740")]
		public ZombieDetail()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x200060C")]
	public class CurrencyBonusChance
	{
		[Token(Token = "0x400216C")]
		[FieldOffset(Offset = "0x10")]
		public float BonusChance;

		[Token(Token = "0x400216D")]
		[FieldOffset(Offset = "0x14")]
		public int BonusValue;

		[Token(Token = "0x600274B")]
		[Address(RVA = "0xA436F4", Offset = "0xA436F4", VA = "0xA436F4")]
		public CurrencyBonusChance()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x200060D")]
	public class FactionByDifficulty
	{
		[Token(Token = "0x400216E")]
		[FieldOffset(Offset = "0x10")]
		public Faction[] Normal;

		[Token(Token = "0x400216F")]
		[FieldOffset(Offset = "0x18")]
		public Faction[] Hard;

		[Token(Token = "0x4002170")]
		[FieldOffset(Offset = "0x20")]
		public Faction[] Expert;

		[Token(Token = "0x600274C")]
		[Address(RVA = "0xA436FC", Offset = "0xA436FC", VA = "0xA436FC")]
		public FactionByDifficulty()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x200060E")]
	public class TagsAppearAfterTime
	{
		[Token(Token = "0x4002171")]
		[FieldOffset(Offset = "0x10")]
		public float Normal;

		[Token(Token = "0x4002172")]
		[FieldOffset(Offset = "0x14")]
		public float Hard;

		[Token(Token = "0x4002173")]
		[FieldOffset(Offset = "0x18")]
		public float Expert;

		[Token(Token = "0x600274D")]
		[Address(RVA = "0xA4370C", Offset = "0xA4370C", VA = "0xA4370C")]
		public TagsAppearAfterTime()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x200060F")]
	public class NumWavesByDifficulty
	{
		[Token(Token = "0x4002174")]
		[FieldOffset(Offset = "0x10")]
		public int Normal;

		[Token(Token = "0x4002175")]
		[FieldOffset(Offset = "0x14")]
		public int Hard;

		[Token(Token = "0x4002176")]
		[FieldOffset(Offset = "0x18")]
		public int Expert;

		[Token(Token = "0x600274E")]
		[Address(RVA = "0xA43704", Offset = "0xA43704", VA = "0xA43704")]
		public NumWavesByDifficulty()
		{
		}
	}

	[Token(Token = "0x2000610")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x59558C", Offset = "0x59558C")]
	private sealed class _003C_003Ec__DisplayClass23_0
	{
		[Token(Token = "0x4002177")]
		[FieldOffset(Offset = "0x10")]
		public Faction faction;

		[Token(Token = "0x600274F")]
		[Address(RVA = "0xA436C8", Offset = "0xA436C8", VA = "0xA436C8")]
		public _003C_003Ec__DisplayClass23_0()
		{
		}

		[Token(Token = "0x6002750")]
		[Address(RVA = "0xA436D0", Offset = "0xA436D0", VA = "0xA436D0")]
		internal bool _003CGetZombieDetail_003Eb__0(ZombieDetail x)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x4002152")]
	[FieldOffset(Offset = "0x0")]
	public static readonly string ZOMBIE_PROPERTIES_DETAILS;

	[Token(Token = "0x4002153")]
	[FieldOffset(Offset = "0x8")]
	public static readonly string ZOMBIE_PROPERTIES_CURRENCY_BONUS_CHANCE;

	[Token(Token = "0x4002154")]
	[FieldOffset(Offset = "0x10")]
	public static readonly string ZOMBIE_PROPERTIES_NORMAL_KILL_BONUS_CURRENCY;

	[Token(Token = "0x4002155")]
	[FieldOffset(Offset = "0x18")]
	public static readonly string ZOMBIE_PROPERTIES_TANK_KILL_BONUS_CURRENCY;

	[Token(Token = "0x4002156")]
	[FieldOffset(Offset = "0x20")]
	public static readonly string ZOMBIE_PROPERTIES_SCREAMER_KILL_BONUS_CURRENCY;

	[Token(Token = "0x4002157")]
	[FieldOffset(Offset = "0x28")]
	public static readonly string ZOMBIE_PROPERTIES_HUNTER_KILL_BONUS_CURRENCY;

	[Token(Token = "0x4002158")]
	[FieldOffset(Offset = "0x48")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5B82A4", Offset = "0x5B82A4")]
	public bool WaitForAllDead;

	[Token(Token = "0x4002159")]
	[FieldOffset(Offset = "0x50")]
	public Faction NormalZombieFaction;

	[Token(Token = "0x400215A")]
	[FieldOffset(Offset = "0x58")]
	public Faction TankZombieFaction;

	[Token(Token = "0x400215B")]
	[FieldOffset(Offset = "0x60")]
	public Faction ScreamerZombieFaction;

	[Token(Token = "0x400215C")]
	[FieldOffset(Offset = "0x68")]
	public Faction HunterZombieFaction;

	[Token(Token = "0x400215D")]
	[FieldOffset(Offset = "0x70")]
	public TagsAppearAfterTime TagsAppearTime;

	[Token(Token = "0x400215E")]
	[FieldOffset(Offset = "0x78")]
	public FactionByDifficulty ZombieTypeByDifficulty;

	[Token(Token = "0x400215F")]
	[FieldOffset(Offset = "0x80")]
	public SpawnTableModel[] SpawnTables;

	[Token(Token = "0x4002160")]
	[FieldOffset(Offset = "0x88")]
	public ZombieDetail[] ZombiesDetails;

	[Token(Token = "0x4002161")]
	[FieldOffset(Offset = "0x90")]
	public NumWavesByDifficulty NumberOfWavesByDifficulty;

	[Token(Token = "0x4002162")]
	[FieldOffset(Offset = "0x98")]
	private List<CurrencyBonusChance> _currencyBonusChance;

	[Token(Token = "0x6002737")]
	[Address(RVA = "0x883F94", Offset = "0x883F94", VA = "0x883F94", Slot = "5")]
	protected override void BindAllVariables()
	{
	}

	[Token(Token = "0x6002738")]
	[Address(RVA = "0x8843C4", Offset = "0x8843C4", VA = "0x8843C4")]
	private ZombieDetail GetZombieDetail(Faction faction)
	{
		return null;
	}

	[Token(Token = "0x6002739")]
	[Address(RVA = "0x8844B0", Offset = "0x8844B0", VA = "0x8844B0")]
	public Faction[] GetFactionByDiffulty(ContractDataModel.DifficultyType difficulty)
	{
		return null;
	}

	[Token(Token = "0x600273A")]
	[Address(RVA = "0x884508", Offset = "0x884508", VA = "0x884508")]
	public int GetNumWaveByDiffulty(ContractDataModel.DifficultyType difficulty)
	{
		return default(int);
	}

	[Token(Token = "0x600273B")]
	[Address(RVA = "0x884560", Offset = "0x884560", VA = "0x884560")]
	public ZombieProperties()
	{
	}

	[Token(Token = "0x600273D")]
	[Address(RVA = "0x8846E0", Offset = "0x8846E0", VA = "0x8846E0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61D040", Offset = "0x61D040")]
	private object _003CBindAllVariables_003Eb__22_0()
	{
		return null;
	}

	[Token(Token = "0x600273E")]
	[Address(RVA = "0x8846E8", Offset = "0x8846E8", VA = "0x8846E8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61D050", Offset = "0x61D050")]
	private void _003CBindAllVariables_003Eb__22_1(object a)
	{
	}

	[Token(Token = "0x600273F")]
	[Address(RVA = "0x884764", Offset = "0x884764", VA = "0x884764")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61D060", Offset = "0x61D060")]
	private object _003CBindAllVariables_003Eb__22_2()
	{
		return null;
	}

	[Token(Token = "0x6002740")]
	[Address(RVA = "0x88476C", Offset = "0x88476C", VA = "0x88476C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61D070", Offset = "0x61D070")]
	private void _003CBindAllVariables_003Eb__22_3(object a)
	{
	}

	[Token(Token = "0x6002741")]
	[Address(RVA = "0x8847F8", Offset = "0x8847F8", VA = "0x8847F8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61D080", Offset = "0x61D080")]
	private int _003CBindAllVariables_003Eb__22_4()
	{
		return default(int);
	}

	[Token(Token = "0x6002742")]
	[Address(RVA = "0x88481C", Offset = "0x88481C", VA = "0x88481C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61D090", Offset = "0x61D090")]
	private void _003CBindAllVariables_003Eb__22_5(int a)
	{
	}

	[Token(Token = "0x6002743")]
	[Address(RVA = "0x884850", Offset = "0x884850", VA = "0x884850")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61D0A0", Offset = "0x61D0A0")]
	private int _003CBindAllVariables_003Eb__22_6()
	{
		return default(int);
	}

	[Token(Token = "0x6002744")]
	[Address(RVA = "0x884874", Offset = "0x884874", VA = "0x884874")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61D0B0", Offset = "0x61D0B0")]
	private void _003CBindAllVariables_003Eb__22_7(int a)
	{
	}

	[Token(Token = "0x6002745")]
	[Address(RVA = "0x8848A8", Offset = "0x8848A8", VA = "0x8848A8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61D0C0", Offset = "0x61D0C0")]
	private int _003CBindAllVariables_003Eb__22_8()
	{
		return default(int);
	}

	[Token(Token = "0x6002746")]
	[Address(RVA = "0x8848CC", Offset = "0x8848CC", VA = "0x8848CC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61D0D0", Offset = "0x61D0D0")]
	private void _003CBindAllVariables_003Eb__22_9(int a)
	{
	}

	[Token(Token = "0x6002747")]
	[Address(RVA = "0x884900", Offset = "0x884900", VA = "0x884900")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61D0E0", Offset = "0x61D0E0")]
	private int _003CBindAllVariables_003Eb__22_10()
	{
		return default(int);
	}

	[Token(Token = "0x6002748")]
	[Address(RVA = "0x884924", Offset = "0x884924", VA = "0x884924")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61D0F0", Offset = "0x61D0F0")]
	private void _003CBindAllVariables_003Eb__22_11(int a)
	{
	}
}
