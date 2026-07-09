using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Serializable]
[Token(Token = "0x20004BE")]
[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x594D28", Offset = "0x594D28")]
public class PlayerProgressionData : ScriptableObject
{
	[Token(Token = "0x20004BF")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x594D60", Offset = "0x594D60")]
	private sealed class _003C_003Ec__DisplayClass6_0
	{
		[Token(Token = "0x400197B")]
		[FieldOffset(Offset = "0x10")]
		public Unlockable unlockable;

		[Token(Token = "0x400197C")]
		[FieldOffset(Offset = "0x18")]
		public Func<LazyUnlockable, bool> _003C_003E9__1;

		[Token(Token = "0x6001D17")]
		[Address(RVA = "0x8D4370", Offset = "0x8D4370", VA = "0x8D4370")]
		public _003C_003Ec__DisplayClass6_0()
		{
		}

		[Token(Token = "0x6001D18")]
		[Address(RVA = "0x8D4378", Offset = "0x8D4378", VA = "0x8D4378")]
		internal bool _003CGetUnlockLevel_003Eb__1(LazyUnlockable r)
		{
			return default(bool);
		}
	}

	[Serializable]
	[Token(Token = "0x20004C0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x594D70", Offset = "0x594D70")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x400197D")]
		[FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x400197E")]
		[FieldOffset(Offset = "0x8")]
		public static Func<UnlockableLootBoxItem, IEnumerable<LazyUnlockable>> _003C_003E9__6_0;

		[Token(Token = "0x400197F")]
		[FieldOffset(Offset = "0x10")]
		public static Func<RankData, IEnumerable<LevelData>> _003C_003E9__7_0;

		[Token(Token = "0x4001980")]
		[FieldOffset(Offset = "0x18")]
		public static Func<RankData, LevelData, _003C_003Ef__AnonymousType1<RankData, LevelData>> _003C_003E9__7_1;

		[Token(Token = "0x4001981")]
		[FieldOffset(Offset = "0x20")]
		public static Func<_003C_003Ef__AnonymousType1<RankData, LevelData>, LevelData> _003C_003E9__7_3;

		[Token(Token = "0x6001D1A")]
		[Address(RVA = "0x8D426C", Offset = "0x8D426C", VA = "0x8D426C")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x6001D1B")]
		[Address(RVA = "0x8D4274", Offset = "0x8D4274", VA = "0x8D4274")]
		internal IEnumerable<LazyUnlockable> _003CGetUnlockLevel_003Eb__6_0(UnlockableLootBoxItem u)
		{
			return null;
		}

		[Token(Token = "0x6001D1C")]
		[Address(RVA = "0x8D428C", Offset = "0x8D428C", VA = "0x8D428C")]
		internal IEnumerable<LevelData> _003CIsProgressionLootBox_003Eb__7_0(RankData rank)
		{
			return null;
		}

		[Token(Token = "0x6001D1D")]
		[Address(RVA = "0x8D42A4", Offset = "0x8D42A4", VA = "0x8D42A4")]
		internal _003C_003Ef__AnonymousType1<RankData, LevelData> _003CIsProgressionLootBox_003Eb__7_1(RankData rank, LevelData level)
		{
			return null;
		}

		[Token(Token = "0x6001D1E")]
		[Address(RVA = "0x8D4328", Offset = "0x8D4328", VA = "0x8D4328")]
		internal LevelData _003CIsProgressionLootBox_003Eb__7_3(_003C_003Ef__AnonymousType1<RankData, LevelData> _003C_003Eh__TransparentIdentifier0)
		{
			return null;
		}
	}

	[Token(Token = "0x20004C1")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x594D80", Offset = "0x594D80")]
	private sealed class _003C_003Ec__DisplayClass7_0
	{
		[Token(Token = "0x4001982")]
		[FieldOffset(Offset = "0x10")]
		public LootBox lootbox;

		[Token(Token = "0x6001D1F")]
		[Address(RVA = "0x8D4560", Offset = "0x8D4560", VA = "0x8D4560")]
		public _003C_003Ec__DisplayClass7_0()
		{
		}

		[Token(Token = "0x6001D20")]
		[Address(RVA = "0x8D4568", Offset = "0x8D4568", VA = "0x8D4568")]
		internal bool _003CIsProgressionLootBox_003Eb__2(_003C_003Ef__AnonymousType1<RankData, LevelData> _003C_003Eh__TransparentIdentifier0)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x4001979")]
	[FieldOffset(Offset = "0x18")]
	public RankData[] Ranks;

	[Token(Token = "0x400197A")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private PopupRankUpLootBox _rankUpPopupPrefab;

	[Token(Token = "0x1700047E")]
	public PopupRankUpLootBox RankUpPopupPrefab
	{
		[Token(Token = "0x6001D12")]
		[Address(RVA = "0xAB4BDC", Offset = "0xAB4BDC", VA = "0xAB4BDC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700047F")]
	public RankData Item
	{
		[Token(Token = "0x6001D13")]
		[Address(RVA = "0xAAD404", Offset = "0xAAD404", VA = "0xAAD404")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6001D14")]
	[Address(RVA = "0xAB4BE4", Offset = "0xAB4BE4", VA = "0xAB4BE4")]
	public int GetUnlockLevel(Unlockable unlockable)
	{
		return default(int);
	}

	[Token(Token = "0x6001D15")]
	[Address(RVA = "0xAB4F2C", Offset = "0xAB4F2C", VA = "0xAB4F2C")]
	public bool IsProgressionLootBox(LootBox lootbox)
	{
		return default(bool);
	}

	[Token(Token = "0x6001D16")]
	[Address(RVA = "0xAB52B0", Offset = "0xAB52B0", VA = "0xAB52B0")]
	public PlayerProgressionData()
	{
	}
}
