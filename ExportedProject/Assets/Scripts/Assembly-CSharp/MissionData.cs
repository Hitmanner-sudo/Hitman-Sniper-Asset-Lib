using System;
using Il2CppDummyDll;
using SimpleJSON;
using Technology;
using UnityEngine;

[Serializable]
[Token(Token = "0x2000400")]
public class MissionData : ScriptableObject
{
	[Serializable]
	[Token(Token = "0x2000401")]
	public class WeaponSuggestionData : ISaveable
	{
		[Serializable]
		[Token(Token = "0x2000402")]
		public struct WeaponPromoSuggestion : ISaveable
		{
			[Serializable]
			[Token(Token = "0x2000403")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x593A94", Offset = "0x593A94")]
			private sealed class _003C_003Ec
			{
				[Token(Token = "0x4001670")]
				[FieldOffset(Offset = "0x0")]
				public static readonly _003C_003Ec _003C_003E9;

				[Token(Token = "0x6001888")]
				[Address(RVA = "0xA47854", Offset = "0xA47854", VA = "0xA47854")]
				public _003C_003Ec()
				{
				}
			}

			[Token(Token = "0x400166A")]
			[FieldOffset(Offset = "0x0")]
			public static readonly string WEAPON_FIELD_NAME;

			[Token(Token = "0x400166B")]
			[FieldOffset(Offset = "0x8")]
			public static readonly string PROMO_FIELD_NAME;

			[Token(Token = "0x400166C")]
			[FieldOffset(Offset = "0x10")]
			public static readonly string WEAPON_PATH_FIELD_NAME;

			[Token(Token = "0x400166D")]
			[FieldOffset(Offset = "0x0")]
			[SerializeField]
			private LazyWeaponUnlockable _weaponRef;

			[Token(Token = "0x400166E")]
			[FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "SaveableAttribute", RVA = "0x5B56D8", Offset = "0x5B56D8")]
			[SerializeField]
			private int _promo;

			[Token(Token = "0x400166F")]
			[FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "SaveableAttribute", RVA = "0x5B5710", Offset = "0x5B5710")]
			private string _weaponPath;

			[Token(Token = "0x170003ED")]
			public WeaponUnlockable WeaponUnlockable
			{
				[Token(Token = "0x6001882")]
				[Address(RVA = "0xA46248", Offset = "0xA46248", VA = "0xA46248")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170003EE")]
			public int PromoIdx
			{
				[Token(Token = "0x6001883")]
				[Address(RVA = "0xA464A8", Offset = "0xA464A8", VA = "0xA464A8")]
				get
				{
					return default(int);
				}
			}

			[Token(Token = "0x6001884")]
			[Address(RVA = "0xA464B0", Offset = "0xA464B0", VA = "0xA464B0", Slot = "4")]
			public void OnSaveableDeserialization(JSONNode data)
			{
			}

			[Token(Token = "0x6001885")]
			[Address(RVA = "0xA465E4", Offset = "0xA465E4", VA = "0xA465E4", Slot = "5")]
			public JSONNode OnSaveableSerialization()
			{
				return null;
			}
		}

		[Serializable]
		[Token(Token = "0x2000404")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x593AA4", Offset = "0x593AA4")]
		private sealed class _003C_003Ec
		{
			[Token(Token = "0x4001671")]
			[FieldOffset(Offset = "0x0")]
			public static readonly _003C_003Ec _003C_003E9;

			[Token(Token = "0x600188A")]
			[Address(RVA = "0xA46240", Offset = "0xA46240", VA = "0xA46240")]
			public _003C_003Ec()
			{
			}
		}

		[Token(Token = "0x4001668")]
		[FieldOffset(Offset = "0x0")]
		public static readonly string SUGGESTED_WEAPON_FIELD_NAME;

		[Token(Token = "0x4001669")]
		[FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "SaveableAttribute", RVA = "0x5B5690", Offset = "0x5B5690")]
		[SerializeField]
		private WeaponPromoSuggestion[] _suggestedWeapons;

		[Token(Token = "0x170003EC")]
		public WeaponPromoSuggestion[] SuggestedWeapons
		{
			[Token(Token = "0x600187D")]
			[Address(RVA = "0x8C7B64", Offset = "0x8C7B64", VA = "0x8C7B64")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600187E")]
		[Address(RVA = "0x8C7B6C", Offset = "0x8C7B6C", VA = "0x8C7B6C", Slot = "4")]
		public void OnSaveableDeserialization(JSONNode data)
		{
		}

		[Token(Token = "0x600187F")]
		[Address(RVA = "0x8C7BF4", Offset = "0x8C7BF4", VA = "0x8C7BF4", Slot = "5")]
		public JSONNode OnSaveableSerialization()
		{
			return null;
		}

		[Token(Token = "0x6001880")]
		[Address(RVA = "0x8C7C84", Offset = "0x8C7C84", VA = "0x8C7C84")]
		public WeaponSuggestionData()
		{
		}
	}

	[Token(Token = "0x400165A")]
	[FieldOffset(Offset = "0x18")]
	public LazyAssignmentData PrimaryAssignment;

	[Token(Token = "0x400165B")]
	[FieldOffset(Offset = "0x20")]
	public bool SkipAllowedOnlyOnceCompleted;

	[Token(Token = "0x400165C")]
	[FieldOffset(Offset = "0x28")]
	public Bark IntroVO;

	[Token(Token = "0x400165D")]
	[FieldOffset(Offset = "0x30")]
	public bool NoScoreOrReward;

	[Token(Token = "0x400165E")]
	[FieldOffset(Offset = "0x38")]
	[LootBoxReference]
	[SerializeField]
	private LootBox _lootBox;

	[Token(Token = "0x400165F")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private bool _skipLootBoxAnim;

	[Token(Token = "0x4001660")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private WeaponSuggestionData _suggestedWeapons;

	[Token(Token = "0x4001661")]
	[FieldOffset(Offset = "0x50")]
	[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x5B5634", Offset = "0x5B5634")]
	[SerializeField]
	private RogueData _rogueData;

	[Token(Token = "0x4001662")]
	[FieldOffset(Offset = "0x58")]
	public bool RandomRogueSelection;

	[Token(Token = "0x4001663")]
	[FieldOffset(Offset = "0x60")]
	public string[] LoadingScreenHints;

	[Token(Token = "0x4001664")]
	[FieldOffset(Offset = "0x68")]
	public bool AddKillRogueObjective;

	[Token(Token = "0x4001665")]
	[FieldOffset(Offset = "0x69")]
	[SerializeField]
	private bool _continueToNextMissionImmediately;

	[NonSerialized]
	[Token(Token = "0x4001666")]
	[FieldOffset(Offset = "0x70")]
	public MissionSaveData SaveData;

	[Token(Token = "0x4001667")]
	[FieldOffset(Offset = "0x78")]
	private RogueData _cachedRogueData;

	[Token(Token = "0x170003E6")]
	public AssignmentSaveData PrimaryAssignmentSaveData
	{
		[Token(Token = "0x6001874")]
		[Address(RVA = "0x9C3A54", Offset = "0x9C3A54", VA = "0x9C3A54")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001875")]
		[Address(RVA = "0x9C3A70", Offset = "0x9C3A70", VA = "0x9C3A70")]
		set
		{
		}
	}

	[Token(Token = "0x170003E7")]
	public RogueData RogueData
	{
		[Token(Token = "0x6001876")]
		[Address(RVA = "0x9C3A8C", Offset = "0x9C3A8C", VA = "0x9C3A8C")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001877")]
		[Address(RVA = "0x9C3ACC", Offset = "0x9C3ACC", VA = "0x9C3ACC")]
		set
		{
		}
	}

	[Token(Token = "0x170003E8")]
	public bool ContinueToNextMissionImmediately
	{
		[Token(Token = "0x6001878")]
		[Address(RVA = "0x9C3AD4", Offset = "0x9C3AD4", VA = "0x9C3AD4")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170003E9")]
	public LootBox LootBox
	{
		[Token(Token = "0x6001879")]
		[Address(RVA = "0x9C3ADC", Offset = "0x9C3ADC", VA = "0x9C3ADC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170003EA")]
	public bool SkipLootBoxAnim
	{
		[Token(Token = "0x600187A")]
		[Address(RVA = "0x9C3AE4", Offset = "0x9C3AE4", VA = "0x9C3AE4")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170003EB")]
	public WeaponSuggestionData.WeaponPromoSuggestion[] SuggestedWeapons
	{
		[Token(Token = "0x600187B")]
		[Address(RVA = "0x9C3AEC", Offset = "0x9C3AEC", VA = "0x9C3AEC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600187C")]
	[Address(RVA = "0x9C3B1C", Offset = "0x9C3B1C", VA = "0x9C3B1C")]
	public MissionData()
	{
	}
}
