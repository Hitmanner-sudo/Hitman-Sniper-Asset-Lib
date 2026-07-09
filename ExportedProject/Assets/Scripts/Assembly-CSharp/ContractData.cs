using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using SimpleJSON;
using Technology;
using UnityEngine;

[Serializable]
[Token(Token = "0x20003F5")]
public class ContractData : ScriptableObject, ISaveable
{
	[Token(Token = "0x20003F6")]
	public enum ModeTypeEnum
	{
		[Token(Token = "0x4001619")]
		Contract = 0,
		[Token(Token = "0x400161A")]
		Challenge = 1,
		[Token(Token = "0x400161B")]
		NONE = -1
	}

	[Serializable]
	[Token(Token = "0x20003F7")]
	public class RogueArrivalTimerData
	{
		[Token(Token = "0x400161C")]
		[FieldOffset(Offset = "0x10")]
		public GameObject Prefab;

		[Token(Token = "0x400161D")]
		[FieldOffset(Offset = "0x18")]
		public bool CompactVersion;

		[Token(Token = "0x400161E")]
		[FieldOffset(Offset = "0x19")]
		public bool HideWhenDead;

		[Token(Token = "0x400161F")]
		[FieldOffset(Offset = "0x1A")]
		public bool ShowImageContourCorners;

		[Token(Token = "0x4001620")]
		[FieldOffset(Offset = "0x1B")]
		public bool MainTargetBlinkingIcon;

		[Token(Token = "0x4001621")]
		[FieldOffset(Offset = "0x1C")]
		public bool ChangeImageBasedOnHealth;

		[Token(Token = "0x4001622")]
		[FieldOffset(Offset = "0x20")]
		public Vector2 Position;

		[Token(Token = "0x4001623")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private ColorModel.ColorModelEnum _contourColorModelEnum;

		[Token(Token = "0x4001624")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private Color _contourColor;

		[Token(Token = "0x4001625")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private ColorModel.ColorModelEnum _blinkingColorModelEnum;

		[Token(Token = "0x4001626")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Color _blinkingColor;

		[Token(Token = "0x4001627")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private ColorModel.ColorModelEnum _healthColorModelEnum;

		[Token(Token = "0x4001628")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		private Color _healthColor;

		[Token(Token = "0x6001857")]
		[Address(RVA = "0x863590", Offset = "0x863590", VA = "0x863590")]
		public Color GetContourColor()
		{
			return default(Color);
		}

		[Token(Token = "0x6001858")]
		[Address(RVA = "0x863630", Offset = "0x863630", VA = "0x863630")]
		public Color GetBlinkingColor()
		{
			return default(Color);
		}

		[Token(Token = "0x6001859")]
		[Address(RVA = "0x8636D0", Offset = "0x8636D0", VA = "0x8636D0")]
		public Color GetHealthColor()
		{
			return default(Color);
		}

		[Token(Token = "0x600185A")]
		[Address(RVA = "0x863770", Offset = "0x863770", VA = "0x863770")]
		public RogueArrivalTimerData()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x20003F8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5938FC", Offset = "0x5938FC")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x4001629")]
		[FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x600185C")]
		[Address(RVA = "0x863588", Offset = "0x863588", VA = "0x863588")]
		public _003C_003Ec()
		{
		}
	}

	[Token(Token = "0x40015EA")]
	[FieldOffset(Offset = "0x18")]
	public GameplayConfig GameplayConfig;

	[Token(Token = "0x40015EB")]
	[FieldOffset(Offset = "0x20")]
	public ContractVoiceOverConfig ContractVoiceOverConfig;

	[Token(Token = "0x40015EC")]
	[FieldOffset(Offset = "0x28")]
	public AudioConfig AudioConfig;

	[Token(Token = "0x40015ED")]
	[FieldOffset(Offset = "0x30")]
	public ScoreConfig ScoreConfig;

	[Token(Token = "0x40015EE")]
	[FieldOffset(Offset = "0x38")]
	public RewardActionConfig RewardActionConfig;

	[Token(Token = "0x40015EF")]
	[FieldOffset(Offset = "0x40")]
	public string Name;

	[Token(Token = "0x40015F0")]
	[FieldOffset(Offset = "0x48")]
	public string OnSuccessTitle;

	[Token(Token = "0x40015F1")]
	[FieldOffset(Offset = "0x50")]
	public string OnFailTitle;

	[Token(Token = "0x40015F2")]
	[FieldOffset(Offset = "0x58")]
	public float LongShotDistance;

	[Token(Token = "0x40015F3")]
	[FieldOffset(Offset = "0x60")]
	public LazyUITexture LocationTexture;

	[Token(Token = "0x40015F4")]
	[FieldOffset(Offset = "0x68")]
	public LazyUITexture LocationTexturePhone;

	[Token(Token = "0x40015F5")]
	[FieldOffset(Offset = "0x70")]
	public LazyUITexture LocationTallyVignette;

	[Token(Token = "0x40015F6")]
	[FieldOffset(Offset = "0x78")]
	public LazyUITexture LocationTallyVignettePhone;

	[Token(Token = "0x40015F7")]
	[FieldOffset(Offset = "0x80")]
	public Color LocationTallyVignetteFinalColor;

	[Token(Token = "0x40015F8")]
	[FieldOffset(Offset = "0x90")]
	public LazyMissionData[] Missions;

	[Token(Token = "0x40015F9")]
	[FieldOffset(Offset = "0x98")]
	public LazyChapterData ChapterData;

	[Token(Token = "0x40015FA")]
	[FieldOffset(Offset = "0xA0")]
	public ColorModel.ColorModelEnum TimerColor;

	[Token(Token = "0x40015FB")]
	[FieldOffset(Offset = "0xA4")]
	public Vector2 GameTimerGOPosition;

	[Token(Token = "0x40015FC")]
	[FieldOffset(Offset = "0xAC")]
	public float ExtractionTimeOnSuccess;

	[Token(Token = "0x40015FD")]
	[FieldOffset(Offset = "0xB0")]
	public float ExtractionTimeOnFail;

	[Token(Token = "0x40015FE")]
	[FieldOffset(Offset = "0xB4")]
	public float ExtractionTimeOnAlarmRaised;

	[Token(Token = "0x40015FF")]
	[FieldOffset(Offset = "0xB8")]
	public string ContractSuccededHudMessage;

	[Token(Token = "0x4001600")]
	[FieldOffset(Offset = "0xC0")]
	public string ContractFailedHudMessage;

	[Token(Token = "0x4001601")]
	[FieldOffset(Offset = "0xC8")]
	public string AlarmRaisedHudMessage;

	[Token(Token = "0x4001602")]
	[FieldOffset(Offset = "0xD0")]
	public LazyGameObject PauseMenuLazyPrefab;

	[Token(Token = "0x4001603")]
	[FieldOffset(Offset = "0xD8")]
	public ModeTypeEnum ModeType;

	[Token(Token = "0x4001604")]
	[FieldOffset(Offset = "0xDC")]
	public int DisplayRankInfoStartingFromMission;

	[Token(Token = "0x4001605")]
	[FieldOffset(Offset = "0xE0")]
	public int DisplayCurrenciesInfoStartingFromMission;

	[Token(Token = "0x4001606")]
	[FieldOffset(Offset = "0xE4")]
	public bool ShowContractFinishedPopup;

	[Token(Token = "0x4001607")]
	[FieldOffset(Offset = "0xE8")]
	public LazyGameObject[] ExtraHudGameObjects;

	[Token(Token = "0x4001608")]
	[FieldOffset(Offset = "0xF0")]
	public List<GameObject> SpecificManagers;

	[Token(Token = "0x4001609")]
	[FieldOffset(Offset = "0xF8")]
	public bool ApplyCompletionBonusOnFail;

	[Token(Token = "0x400160A")]
	[FieldOffset(Offset = "0x100")]
	public RogueArrivalTimerData RogueArrivalTimer;

	[Token(Token = "0x400160B")]
	[FieldOffset(Offset = "0x108")]
	public TutorialManager.TutorialContractData TutorialContractData;

	[Token(Token = "0x400160C")]
	[FieldOffset(Offset = "0x110")]
	public string[] FacebookScorePosts;

	[Token(Token = "0x400160D")]
	[FieldOffset(Offset = "0x118")]
	public string[] FacebookScorePostTaunts;

	[Token(Token = "0x400160E")]
	[FieldOffset(Offset = "0x120")]
	public string[] FacebookScorePostTauntsTop;

	[Token(Token = "0x400160F")]
	[FieldOffset(Offset = "0x128")]
	public string[] FacebookScorePostsTop;

	[Token(Token = "0x4001610")]
	[FieldOffset(Offset = "0x130")]
	[AttributeAttribute(Name = "SaveableAttribute", RVA = "0x5B5290", Offset = "0x5B5290")]
	public Perk[] Perks;

	[Token(Token = "0x4001611")]
	[FieldOffset(Offset = "0x138")]
	[AttributeAttribute(Name = "SaveableAttribute", RVA = "0x5B52A0", Offset = "0x5B52A0")]
	public RogueData[] Rogues;

	[NonSerialized]
	[Token(Token = "0x4001612")]
	[FieldOffset(Offset = "0x140")]
	[AttributeAttribute(Name = "SaveableAttribute", RVA = "0x5B52B0", Offset = "0x5B52B0")]
	public int CurrentMissionIdx;

	[NonSerialized]
	[Token(Token = "0x4001613")]
	[FieldOffset(Offset = "0x148")]
	[AttributeAttribute(Name = "SaveableAttribute", RVA = "0x5B52C0", Offset = "0x5B52C0")]
	public MissionSaveData[] MissionsSaveData;

	[NonSerialized]
	[Token(Token = "0x4001614")]
	[FieldOffset(Offset = "0x150")]
	[AttributeAttribute(Name = "SaveableAttribute", RVA = "0x5B52D0", Offset = "0x5B52D0")]
	public int HighScore;

	[NonSerialized]
	[Token(Token = "0x4001615")]
	[FieldOffset(Offset = "0x158")]
	[AttributeAttribute(Name = "SaveableAttribute", RVA = "0x5B52E0", Offset = "0x5B52E0")]
	public MissionTimerData OverrideTimerData;

	[Token(Token = "0x4001616")]
	[FieldOffset(Offset = "0x160")]
	[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x5B52F0", Offset = "0x5B52F0")]
	[SerializeField]
	private float _missionDuration;

	[Token(Token = "0x4001617")]
	[FieldOffset(Offset = "0x0")]
	private static readonly string CURRENT_MISSION_IDX_FIELD_NAME;

	[Token(Token = "0x170003DF")]
	public string GetTargetName
	{
		[Token(Token = "0x6001847")]
		[Address(RVA = "0x8E5D78", Offset = "0x8E5D78", VA = "0x8E5D78")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170003E0")]
	public MissionData CurrentMission
	{
		[Token(Token = "0x6001848")]
		[Address(RVA = "0x8E5E6C", Offset = "0x8E5E6C", VA = "0x8E5E6C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170003E1")]
	public virtual GameEventsManager.GameEndResult GetMainTargetDespawnEndGameType
	{
		[Token(Token = "0x6001849")]
		[Address(RVA = "0x8E5EE4", Offset = "0x8E5EE4", VA = "0x8E5EE4", Slot = "6")]
		get
		{
			return default(GameEventsManager.GameEndResult);
		}
	}

	[Token(Token = "0x170003E2")]
	public virtual GameEventsManager.GameEndResult GetMainTargetDeathEndGameType
	{
		[Token(Token = "0x600184A")]
		[Address(RVA = "0x8E5EEC", Offset = "0x8E5EEC", VA = "0x8E5EEC", Slot = "7")]
		get
		{
			return default(GameEventsManager.GameEndResult);
		}
	}

	[Token(Token = "0x170003E3")]
	public virtual GameEventsManager.GameEndResult GetMissionTimerExpiresEndGameType
	{
		[Token(Token = "0x600184B")]
		[Address(RVA = "0x8E5EF4", Offset = "0x8E5EF4", VA = "0x8E5EF4", Slot = "8")]
		get
		{
			return default(GameEventsManager.GameEndResult);
		}
	}

	[Token(Token = "0x170003E4")]
	public virtual GameEventsManager.GameEndResult GetAlarmRaisedEndGameType
	{
		[Token(Token = "0x600184C")]
		[Address(RVA = "0x8E5EFC", Offset = "0x8E5EFC", VA = "0x8E5EFC", Slot = "9")]
		get
		{
			return default(GameEventsManager.GameEndResult);
		}
	}

	[Token(Token = "0x170003E5")]
	public int NumMissionsCompletedAndSkipped
	{
		[Token(Token = "0x600184E")]
		[Address(RVA = "0x8E6010", Offset = "0x8E6010", VA = "0x8E6010")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x6001846")]
	[Address(RVA = "0x8E5D1C", Offset = "0x8E5D1C", VA = "0x8E5D1C")]
	public float GetMissionDuration(int missionId)
	{
		return default(float);
	}

	[Token(Token = "0x600184D")]
	[Address(RVA = "0x8E5F04", Offset = "0x8E5F04", VA = "0x8E5F04")]
	public int NumMissionsCompleted(bool includeSkipped = true)
	{
		return default(int);
	}

	[Token(Token = "0x600184F")]
	[Address(RVA = "0x8E6100", Offset = "0x8E6100", VA = "0x8E6100")]
	public static void GetIndexOfCurrentMission(JSONNode data, int availableContractsIndex, out int chapterIndex, out int missionIndex)
	{
	}

	[Token(Token = "0x6001850")]
	[Address(RVA = "0x8E62FC", Offset = "0x8E62FC", VA = "0x8E62FC", Slot = "10")]
	public virtual void DoFirstInit()
	{
	}

	[Token(Token = "0x6001851")]
	[Address(RVA = "0x8E658C", Offset = "0x8E658C", VA = "0x8E658C")]
	public void PatchUpMissionData(bool forceClear = false)
	{
	}

	[Token(Token = "0x6001852")]
	[Address(RVA = "0x8E6704", Offset = "0x8E6704", VA = "0x8E6704")]
	public void UpdateMissionIndex()
	{
	}

	[Token(Token = "0x6001853")]
	[Address(RVA = "0x8E6744", Offset = "0x8E6744", VA = "0x8E6744", Slot = "11")]
	public virtual void OnSaveableDeserialization(JSONNode data)
	{
	}

	[Token(Token = "0x6001854")]
	[Address(RVA = "0x8E67CC", Offset = "0x8E67CC", VA = "0x8E67CC", Slot = "12")]
	public virtual JSONNode OnSaveableSerialization()
	{
		return null;
	}

	[Token(Token = "0x6001855")]
	[Address(RVA = "0x8E6844", Offset = "0x8E6844", VA = "0x8E6844")]
	public ContractData()
	{
	}
}
