using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Technology;

[Token(Token = "0x20002BA")]
[Scope]
public class TutorialManager : GameSingleton<TutorialManager>
{
	[Serializable]
	[Token(Token = "0x20002BB")]
	public class TutorialContractData
	{
		[Token(Token = "0x4000F65")]
		[FieldOffset(Offset = "0x10")]
		public int IGC_DisplayedStartingFromMissionID;

		[Token(Token = "0x4000F66")]
		[FieldOffset(Offset = "0x14")]
		public int Score_DisplayedStartingFromMissionID;

		[Token(Token = "0x4000F67")]
		[FieldOffset(Offset = "0x18")]
		public int Timer_DisplayedStartingFromMissionID;

		[Token(Token = "0x4000F68")]
		[FieldOffset(Offset = "0x1C")]
		public int HoldBreath_DisplayedStartingFromMissionID;

		[Token(Token = "0x4000F69")]
		[FieldOffset(Offset = "0x20")]
		public int PowerUps_DisplayedStartingFromMissionID;

		[Token(Token = "0x4000F6A")]
		[FieldOffset(Offset = "0x24")]
		public int AmmoCounter_DisplayedStartingFromMissionID;

		[Token(Token = "0x4000F6B")]
		[FieldOffset(Offset = "0x28")]
		public int MissionDetailAtStart_DisplayedStartingFromMissionID;

		[Token(Token = "0x4000F6C")]
		[FieldOffset(Offset = "0x2C")]
		public int PauseMenuQuitButton_DisplayedStartingFromMissionID;

		[Token(Token = "0x4000F6D")]
		[FieldOffset(Offset = "0x30")]
		public int InfinitAmmo_DeactivatedStartingFromMissionID;

		[Token(Token = "0x4000F6E")]
		[FieldOffset(Offset = "0x34")]
		public int Tags_DisplayedStartingFromMissionID;

		[Token(Token = "0x4000F6F")]
		[FieldOffset(Offset = "0x38")]
		public int RogueArrivalTimer_DisplayedStartingFromMissionID;

		[Token(Token = "0x4000F70")]
		[FieldOffset(Offset = "0x3C")]
		public int Objectives_DisplayedStartingFromMissionID;

		[Token(Token = "0x4000F71")]
		[FieldOffset(Offset = "0x40")]
		public int TallyWallet_DisplayStartingFromMissionID;

		[Token(Token = "0x4000F72")]
		[FieldOffset(Offset = "0x44")]
		public float Tutorial_PausedTimescale;

		[Token(Token = "0x4000F73")]
		[FieldOffset(Offset = "0x48")]
		public List<TutorialToLearn> TutorialsToLearn;

		[Token(Token = "0x60010B2")]
		[Address(RVA = "0xA395E4", Offset = "0xA395E4", VA = "0xA395E4")]
		public TutorialContractData()
		{
		}
	}

	[Token(Token = "0x4000F62")]
	[FieldOffset(Offset = "0x48")]
	public ModelContainer ModelContainer;

	[Token(Token = "0x4000F63")]
	[FieldOffset(Offset = "0x50")]
	private List<TutorialToLearn> _tutorialsActive;

	[Token(Token = "0x4000F64")]
	[FieldOffset(Offset = "0x58")]
	private readonly List<TutorialToLearn> _tutorialsCompleted;

	[Token(Token = "0x6001098")]
	[Address(RVA = "0xCA5CF8", Offset = "0xCA5CF8", VA = "0xCA5CF8", Slot = "7")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x6001099")]
	[Address(RVA = "0xCA5D90", Offset = "0xCA5D90", VA = "0xCA5D90", Slot = "9")]
	protected override void Start()
	{
	}

	[Token(Token = "0x600109A")]
	[Address(RVA = "0xCA5E98", Offset = "0xCA5E98", VA = "0xCA5E98", Slot = "10")]
	protected override void OnDestroy()
	{
	}

	[Token(Token = "0x600109B")]
	[Address(RVA = "0xCA6000", Offset = "0xCA6000", VA = "0xCA6000", Slot = "5")]
	protected override void GameUpdate()
	{
	}

	[Token(Token = "0x600109C")]
	[Address(RVA = "0xCA61F0", Offset = "0xCA61F0", VA = "0xCA61F0")]
	public static bool IsTutorialCompleted(TutorialToLearn.TutorialToLearnType tutorialType)
	{
		return default(bool);
	}

	[Token(Token = "0x600109D")]
	[Address(RVA = "0xCA62BC", Offset = "0xCA62BC", VA = "0xCA62BC")]
	private bool IsTutorialCompletedInternal(TutorialToLearn.TutorialToLearnType tutorialType)
	{
		return default(bool);
	}

	[Token(Token = "0x600109E")]
	[Address(RVA = "0xCA6434", Offset = "0xCA6434", VA = "0xCA6434")]
	public static bool CanUseAction(TutorialToLearn.TutorialToLearnType tutorialType)
	{
		return default(bool);
	}

	[Token(Token = "0x600109F")]
	[Address(RVA = "0xCA6500", Offset = "0xCA6500", VA = "0xCA6500")]
	private bool CanUseActionInternal(TutorialToLearn.TutorialToLearnType tutorialType)
	{
		return default(bool);
	}

	[Token(Token = "0x60010A0")]
	public static T GetVariable<T>(string name)
	{
		return (T)null;
	}

	[Token(Token = "0x60010A1")]
	[Address(RVA = "0xCA665C", Offset = "0xCA665C", VA = "0xCA665C")]
	public static int GetIntVariable(string name)
	{
		return default(int);
	}

	[Token(Token = "0x60010A2")]
	[Address(RVA = "0xCA676C", Offset = "0xCA676C", VA = "0xCA676C")]
	public static bool GetBoolVariable(string name)
	{
		return default(bool);
	}

	[Token(Token = "0x60010A3")]
	[Address(RVA = "0xCA687C", Offset = "0xCA687C", VA = "0xCA687C")]
	public static float GetFloatVariable(string name)
	{
		return default(float);
	}

	[Token(Token = "0x60010A4")]
	[Address(RVA = "0xCA44A4", Offset = "0xCA44A4", VA = "0xCA44A4")]
	public static void SetVariable(string name, object value)
	{
	}

	[Token(Token = "0x60010A5")]
	[Address(RVA = "0xCA698C", Offset = "0xCA698C", VA = "0xCA698C")]
	public static void SetVariable(string name, object value, bool forceChangedEvent)
	{
	}

	[Token(Token = "0x60010A6")]
	[Address(RVA = "0xCA6AB4", Offset = "0xCA6AB4", VA = "0xCA6AB4")]
	public static void SetVariable(string name, int value)
	{
	}

	[Token(Token = "0x60010A7")]
	[Address(RVA = "0xCA6ABC", Offset = "0xCA6ABC", VA = "0xCA6ABC")]
	public static void SetVariable(string name, int value, bool forceChangedEvent)
	{
	}

	[Token(Token = "0x60010A8")]
	[Address(RVA = "0xCA2D88", Offset = "0xCA2D88", VA = "0xCA2D88")]
	public static void SetVariable(string name, bool value)
	{
	}

	[Token(Token = "0x60010A9")]
	[Address(RVA = "0xCA2564", Offset = "0xCA2564", VA = "0xCA2564")]
	public static void SetVariable(string name, bool value, bool forceChangedEvent)
	{
	}

	[Token(Token = "0x60010AA")]
	[Address(RVA = "0xCA6BE4", Offset = "0xCA6BE4", VA = "0xCA6BE4")]
	public static void SetVariable(string name, float value)
	{
	}

	[Token(Token = "0x60010AB")]
	[Address(RVA = "0xCA6BEC", Offset = "0xCA6BEC", VA = "0xCA6BEC")]
	public static void SetVariable(string name, float value, bool forceChangedEvent)
	{
	}

	[Token(Token = "0x60010AC")]
	[Address(RVA = "0xCA6D14", Offset = "0xCA6D14", VA = "0xCA6D14")]
	private void OnGameStarted(object sender, EventArgs args)
	{
	}

	[Token(Token = "0x60010AD")]
	[Address(RVA = "0xCA72EC", Offset = "0xCA72EC", VA = "0xCA72EC")]
	private void OnPlayerAdded(object sender, EventArgs args)
	{
	}

	[Token(Token = "0x60010AE")]
	[Address(RVA = "0xCA73E0", Offset = "0xCA73E0", VA = "0xCA73E0")]
	private void OnWeaponAttached(object sender, EventArgs args)
	{
	}

	[Token(Token = "0x60010AF")]
	[Address(RVA = "0xCA7538", Offset = "0xCA7538", VA = "0xCA7538")]
	private void OnGameEnded(object sender, EventArgs args)
	{
	}

	[Token(Token = "0x60010B0")]
	[Address(RVA = "0xCA725C", Offset = "0xCA725C", VA = "0xCA725C")]
	private bool NeedsToBeActived(int activateFromMissionID)
	{
		return default(bool);
	}

	[Token(Token = "0x60010B1")]
	[Address(RVA = "0xCA7750", Offset = "0xCA7750", VA = "0xCA7750")]
	public TutorialManager()
	{
	}
}
