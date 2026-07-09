using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Technology;
using UnityEngine;

[Token(Token = "0x2000408")]
[Scope]
public class MissionManager : GameSingleton<MissionManager>
{
	[Token(Token = "0x2000409")]
	public class AssignmentUpdateEventArgs : EventArgs
	{
		[Token(Token = "0x4001688")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public AssignmentData Assignment;

		[Token(Token = "0x4001689")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool LockMenus;

		[Token(Token = "0x400168A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		public bool FailedDueToRestriction;

		[Token(Token = "0x60018D3")]
		[Address(RVA = "0x8C7E70", Offset = "0x8C7E70", VA = "0x8C7E70")]
		public AssignmentUpdateEventArgs()
		{
		}
	}

	[Token(Token = "0x400167C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public ModelContainer ModelContainer;

	[Token(Token = "0x400167D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[SerializeField]
	private int _missionSkipCostFactor;

	[Token(Token = "0x400167E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	[SerializeField]
	private int _missionSkipCostCap;

	[Token(Token = "0x400167F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private int _selectedContract;

	[Token(Token = "0x4001680")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	private int _lastActiveMissionId;

	[Token(Token = "0x4001681")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private ContractsModel _contracts;

	[Token(Token = "0x170003EF")]
	public MissionData LastActiveMission
	{
		[Token(Token = "0x6001897")]
		[Address(RVA = "0x9C3E2C", Offset = "0x9C3E2C", VA = "0x9C3E2C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170003F0")]
	public ContractsModel Contracts
	{
		[Token(Token = "0x6001898")]
		[Address(RVA = "0x9C3FDC", Offset = "0x9C3FDC", VA = "0x9C3FDC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170003F1")]
	public ContractDataModel CurrentContractModel
	{
		[Token(Token = "0x6001899")]
		[Address(RVA = "0x9C4064", Offset = "0x9C4064", VA = "0x9C4064")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170003F2")]
	public ContractData CurrentContract
	{
		[Token(Token = "0x600189C")]
		[Address(RVA = "0x9C3E90", Offset = "0x9C3E90", VA = "0x9C3E90")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170003F3")]
	public int SelectedContract
	{
		[Token(Token = "0x600189D")]
		[Address(RVA = "0x9C40D0", Offset = "0x9C40D0", VA = "0x9C40D0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600189E")]
		[Address(RVA = "0x9C42D8", Offset = "0x9C42D8", VA = "0x9C42D8")]
		set
		{
		}
	}

	[Token(Token = "0x170003F4")]
	public int LastCompletedMissionId
	{
		[Token(Token = "0x60018A7")]
		[Address(RVA = "0x9C4B48", Offset = "0x9C4B48", VA = "0x9C4B48")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170003F5")]
	public int CurrentMissionId
	{
		[Token(Token = "0x60018AB")]
		[Address(RVA = "0x9C48B4", Offset = "0x9C48B4", VA = "0x9C48B4")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170003F6")]
	public int CurrentIncompleteMissionId
	{
		[Token(Token = "0x60018AC")]
		[Address(RVA = "0x9C4B68", Offset = "0x9C4B68", VA = "0x9C4B68")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170003F7")]
	public MissionData CurrentMission
	{
		[Token(Token = "0x60018AD")]
		[Address(RVA = "0x9C3FBC", Offset = "0x9C3FBC", VA = "0x9C3FBC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170003F8")]
	public int MissionSkipCost
	{
		[Token(Token = "0x60018AF")]
		[Address(RVA = "0x9C4C40", Offset = "0x9C4C40", VA = "0x9C4C40")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x1400005E")]
	public static event EventHandler OnContractAboutToChange
	{
		[Token(Token = "0x6001893")]
		[Address(RVA = "0x9C3B34", Offset = "0x9C3B34", VA = "0x9C3B34")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6175B4", Offset = "0x6175B4")]
		add
		{
		}
		[Token(Token = "0x6001894")]
		[Address(RVA = "0x9C3BF0", Offset = "0x9C3BF0", VA = "0x9C3BF0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6175C4", Offset = "0x6175C4")]
		remove
		{
		}
	}

	[Token(Token = "0x1400005F")]
	public static event EventHandler OnContractChanged
	{
		[Token(Token = "0x6001895")]
		[Address(RVA = "0x9C3CAC", Offset = "0x9C3CAC", VA = "0x9C3CAC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6175D4", Offset = "0x6175D4")]
		add
		{
		}
		[Token(Token = "0x6001896")]
		[Address(RVA = "0x9C3D6C", Offset = "0x9C3D6C", VA = "0x9C3D6C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6175E4", Offset = "0x6175E4")]
		remove
		{
		}
	}

	[Token(Token = "0x14000060")]
	public static event EventHandler<AssignmentUpdateEventArgs> AssignmentCompleted
	{
		[Token(Token = "0x60018B0")]
		[Address(RVA = "0x9C4CD8", Offset = "0x9C4CD8", VA = "0x9C4CD8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6175F4", Offset = "0x6175F4")]
		add
		{
		}
		[Token(Token = "0x60018B1")]
		[Address(RVA = "0x9C4D98", Offset = "0x9C4D98", VA = "0x9C4D98")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x617604", Offset = "0x617604")]
		remove
		{
		}
	}

	[Token(Token = "0x14000061")]
	public static event EventHandler<AssignmentUpdateEventArgs> SubAssignmentCompleted
	{
		[Token(Token = "0x60018B2")]
		[Address(RVA = "0x9C4E58", Offset = "0x9C4E58", VA = "0x9C4E58")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x617614", Offset = "0x617614")]
		add
		{
		}
		[Token(Token = "0x60018B3")]
		[Address(RVA = "0x9C4F18", Offset = "0x9C4F18", VA = "0x9C4F18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x617624", Offset = "0x617624")]
		remove
		{
		}
	}

	[Token(Token = "0x14000062")]
	public static event EventHandler<AssignmentUpdateEventArgs> AssignmentFailed
	{
		[Token(Token = "0x60018B4")]
		[Address(RVA = "0x9C4FD8", Offset = "0x9C4FD8", VA = "0x9C4FD8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x617634", Offset = "0x617634")]
		add
		{
		}
		[Token(Token = "0x60018B5")]
		[Address(RVA = "0x9C5098", Offset = "0x9C5098", VA = "0x9C5098")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x617644", Offset = "0x617644")]
		remove
		{
		}
	}

	[Token(Token = "0x14000063")]
	public static event EventHandler<AssignmentUpdateEventArgs> AssignmentProgressUpdated
	{
		[Token(Token = "0x60018B6")]
		[Address(RVA = "0x9C5158", Offset = "0x9C5158", VA = "0x9C5158")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x617654", Offset = "0x617654")]
		add
		{
		}
		[Token(Token = "0x60018B7")]
		[Address(RVA = "0x9C5218", Offset = "0x9C5218", VA = "0x9C5218")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x617664", Offset = "0x617664")]
		remove
		{
		}
	}

	[Token(Token = "0x600189A")]
	[Address(RVA = "0x9C4168", Offset = "0x9C4168", VA = "0x9C4168")]
	public void SetSelectedContract(ContractData.ModeTypeEnum modeType)
	{
	}

	[Token(Token = "0x600189B")]
	[Address(RVA = "0x9C43C8", Offset = "0x9C43C8", VA = "0x9C43C8")]
	public ContractDataModel GetContractByType(ContractData.ModeTypeEnum modeType)
	{
		return null;
	}

	[Token(Token = "0x600189F")]
	[Address(RVA = "0x9C449C", Offset = "0x9C449C", VA = "0x9C449C")]
	public int NbOfMissionsCompleted(bool includeSkipped = true)
	{
		return default(int);
	}

	[Token(Token = "0x60018A0")]
	[Address(RVA = "0x9C45E0", Offset = "0x9C45E0", VA = "0x9C45E0")]
	public int ChapterID([Optional] ContractData contractData)
	{
		return default(int);
	}

	[Token(Token = "0x60018A1")]
	[Address(RVA = "0x9C46C0", Offset = "0x9C46C0", VA = "0x9C46C0")]
	public int ChapterCount([Optional] ContractData contractData)
	{
		return default(int);
	}

	[Token(Token = "0x60018A2")]
	[Address(RVA = "0x9C479C", Offset = "0x9C479C", VA = "0x9C479C")]
	public int MissionID([Optional] ContractData contractData)
	{
		return default(int);
	}

	[Token(Token = "0x60018A3")]
	[Address(RVA = "0x9C487C", Offset = "0x9C487C", VA = "0x9C487C")]
	public bool IsInTutorialMission()
	{
		return default(bool);
	}

	[Token(Token = "0x60018A4")]
	[Address(RVA = "0x9C48D8", Offset = "0x9C48D8", VA = "0x9C48D8")]
	public int GetTutorialMissionsNumber([Optional] ContractData contractData)
	{
		return default(int);
	}

	[Token(Token = "0x60018A5")]
	[Address(RVA = "0x9C49BC", Offset = "0x9C49BC", VA = "0x9C49BC")]
	public ChapterData.ChapterInfo GetCurrentChapterData([Optional] ContractData contractData)
	{
		return null;
	}

	[Token(Token = "0x60018A6")]
	[Address(RVA = "0x9C4A9C", Offset = "0x9C4A9C", VA = "0x9C4A9C")]
	public bool IsOnLastMission([Optional] ContractData contractData)
	{
		return default(bool);
	}

	[Token(Token = "0x60018A8")]
	[Address(RVA = "0x9C4B80", Offset = "0x9C4B80", VA = "0x9C4B80")]
	public int MissionId(ContractData contractData)
	{
		return default(int);
	}

	[Token(Token = "0x60018A9")]
	[Address(RVA = "0x9C4B9C", Offset = "0x9C4B9C", VA = "0x9C4B9C")]
	public int IncompleteMissionId(ContractData contractData)
	{
		return default(int);
	}

	[Token(Token = "0x60018AA")]
	[Address(RVA = "0x9C4C24", Offset = "0x9C4C24", VA = "0x9C4C24")]
	public MissionData Mission(ContractData contractData)
	{
		return null;
	}

	[Token(Token = "0x60018AE")]
	[Address(RVA = "0x9C3F2C", Offset = "0x9C3F2C", VA = "0x9C3F2C")]
	private MissionData GetMissionFromId(int missionId)
	{
		return null;
	}

	[Token(Token = "0x60018B8")]
	[Address(RVA = "0x9C52D8", Offset = "0x9C52D8", VA = "0x9C52D8")]
	public void RaiseAssignmentProgressUpdated(AssignmentData assignmentData)
	{
	}

	[Token(Token = "0x60018B9")]
	[Address(RVA = "0x9C538C", Offset = "0x9C538C", VA = "0x9C538C", Slot = "7")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x60018BA")]
	[Address(RVA = "0x9C5784", Offset = "0x9C5784", VA = "0x9C5784")]
	private void OnCharacterDied(object sender, Character.DeathEvent args)
	{
	}

	[Token(Token = "0x60018BB")]
	[Address(RVA = "0x9C5A98", Offset = "0x9C5A98", VA = "0x9C5A98")]
	private void OnLoadComplete(object sender, EventArgs args)
	{
	}

	[Token(Token = "0x60018BC")]
	[Address(RVA = "0x9C5C30", Offset = "0x9C5C30", VA = "0x9C5C30")]
	private void OnSceneLoading(object sender, EventArgs e)
	{
	}

	[Token(Token = "0x60018BD")]
	[Address(RVA = "0x9C5E44", Offset = "0x9C5E44", VA = "0x9C5E44")]
	private void AddAssignmentHandler(AssignmentData assignmentData)
	{
	}

	[Token(Token = "0x60018BE")]
	[Address(RVA = "0x9C5FF4", Offset = "0x9C5FF4", VA = "0x9C5FF4")]
	private void OnAssignmentFailed(object sender, EventArgs e)
	{
	}

	[Token(Token = "0x60018BF")]
	[Address(RVA = "0x9C6174", Offset = "0x9C6174", VA = "0x9C6174")]
	private void OnAssignmentSuccess(object sender, EventArgs e)
	{
	}

	[Token(Token = "0x60018C0")]
	[Address(RVA = "0x9C6380", Offset = "0x9C6380", VA = "0x9C6380", Slot = "10")]
	protected override void OnDestroy()
	{
	}

	[Token(Token = "0x60018C1")]
	[Address(RVA = "0x9C66BC", Offset = "0x9C66BC", VA = "0x9C66BC")]
	private void OnContractEnded(object sender, ContractEndedArgs e)
	{
	}

	[Token(Token = "0x60018C2")]
	[Address(RVA = "0x9C68CC", Offset = "0x9C68CC", VA = "0x9C68CC")]
	private void OnGameEnded(object sender, EventArgs eventArgs)
	{
	}

	[Token(Token = "0x60018C3")]
	[Address(RVA = "0x9C6AB4", Offset = "0x9C6AB4", VA = "0x9C6AB4")]
	private static void OpenMissionReward(MissionData mission, bool fromSkip = false)
	{
	}

	[Token(Token = "0x60018C4")]
	[Address(RVA = "0x9C6CD8", Offset = "0x9C6CD8", VA = "0x9C6CD8")]
	public void OnGameResults()
	{
	}

	[Token(Token = "0x60018C5")]
	[Address(RVA = "0x9C6DA0", Offset = "0x9C6DA0", VA = "0x9C6DA0")]
	public void UpdateRandomRogueSelection()
	{
	}

	[Token(Token = "0x60018C6")]
	[Address(RVA = "0x9C6F84", Offset = "0x9C6F84", VA = "0x9C6F84")]
	public bool IsMissionSucceeded(MissionData mission)
	{
		return default(bool);
	}

	[Token(Token = "0x60018C7")]
	[Address(RVA = "0x9C6FE8", Offset = "0x9C6FE8", VA = "0x9C6FE8")]
	public void AutoAdvanceCompletedMission()
	{
	}

	[Token(Token = "0x60018C8")]
	[Address(RVA = "0x9C7064", Offset = "0x9C7064", VA = "0x9C7064")]
	public void ResetAssignment(AssignmentData assignment, bool forceReset)
	{
	}

	[Token(Token = "0x60018C9")]
	[Address(RVA = "0x9C7118", Offset = "0x9C7118", VA = "0x9C7118")]
	public void ResetSubAssignment(AssignmentData assignment, bool forceReset)
	{
	}

	[Token(Token = "0x60018CA")]
	[Address(RVA = "0x9C71CC", Offset = "0x9C71CC", VA = "0x9C71CC")]
	public void SetProgressAssignment(AssignmentData assignment, int progressionValue, Action<int> setProgress, int targetValue)
	{
	}

	[Token(Token = "0x60018CB")]
	[Address(RVA = "0x9C6210", Offset = "0x9C6210", VA = "0x9C6210")]
	public static void CompleteAssignment(MissionData mission, bool fromSkip = false, bool lockMenus = true)
	{
	}

	[Token(Token = "0x60018CC")]
	[Address(RVA = "0x9C7354", Offset = "0x9C7354", VA = "0x9C7354")]
	public void SetIncompleteAssignmentFailed()
	{
	}

	[Token(Token = "0x60018CD")]
	[Address(RVA = "0x9C6C18", Offset = "0x9C6C18", VA = "0x9C6C18")]
	private void Restart()
	{
	}

	[Token(Token = "0x60018CE")]
	[Address(RVA = "0x9C741C", Offset = "0x9C741C", VA = "0x9C741C")]
	private void UpdateRewardedStars()
	{
	}

	[Token(Token = "0x60018CF")]
	[Address(RVA = "0x9BC474", Offset = "0x9BC474", VA = "0x9BC474")]
	public bool CanResetMissionsProgress()
	{
		return default(bool);
	}

	[Token(Token = "0x60018D0")]
	[Address(RVA = "0x9BD184", Offset = "0x9BD184", VA = "0x9BD184")]
	public void ResetMissionsProgressAfterTutorials()
	{
	}

	[Token(Token = "0x60018D1")]
	[Address(RVA = "0x9C74B4", Offset = "0x9C74B4", VA = "0x9C74B4")]
	private static void OnGlobalAlertChanged(object sender, AISensorManager.AlertLevelChangedArgs args)
	{
	}

	[Token(Token = "0x60018D2")]
	[Address(RVA = "0x9C7584", Offset = "0x9C7584", VA = "0x9C7584")]
	public MissionManager()
	{
	}
}
