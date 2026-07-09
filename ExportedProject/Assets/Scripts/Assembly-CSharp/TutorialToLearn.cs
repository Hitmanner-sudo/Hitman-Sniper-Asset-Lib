using System;
using Il2CppDummyDll;
using UnityEngine;

[Serializable]
[Token(Token = "0x20002D7")]
public class TutorialToLearn
{
	[Token(Token = "0x20002D8")]
	public enum TutorialToLearnType
	{
		[Token(Token = "0x4000FB2")]
		None = 0,
		[Token(Token = "0x4000FB3")]
		LookAround = 1,
		[Token(Token = "0x4000FB4")]
		EnterScope = 2,
		[Token(Token = "0x4000FB5")]
		ZoomInAndOut = 3,
		[Token(Token = "0x4000FB6")]
		FindAndIdentifyTheMark = 4,
		[Token(Token = "0x4000FB7")]
		AlignTargetAndShoot = 5,
		[Token(Token = "0x4000FB8")]
		HoldBreath = 6,
		[Token(Token = "0x4000FB9")]
		Reload = 7,
		[Token(Token = "0x4000FBA")]
		CenterOnTag = 8,
		[Token(Token = "0x4000FBB")]
		MaxTags = 9,
		[Token(Token = "0x4000FBC")]
		RivalScore = 10,
		[Token(Token = "0x4000FBD")]
		PowerUpInstinct = 11,
		[Token(Token = "0x4000FBE")]
		FindAndIdentifyNewTarget = 12,
		[Token(Token = "0x4000FBF")]
		KillingTheMark = 13,
		[Token(Token = "0x4000FC0")]
		IncreaseScoreExtraction = 14,
		[Token(Token = "0x4000FC1")]
		FindAndKillAZombie = 15,
		[Token(Token = "0x4000FC2")]
		FindTheSurvivor = 16,
		[Token(Token = "0x4000FC3")]
		OpenYourShop = 17,
		[Token(Token = "0x4000FC4")]
		ProtectTheSurvivor = 18,
		[Token(Token = "0x4000FC5")]
		MiniObjectives = 19,
		[Token(Token = "0x4000FC6")]
		PowerUpDeadEye = 20
	}

	[Token(Token = "0x4000FAF")]
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	private TutorialToLearnData _tutorialToLearnData;

	[Token(Token = "0x4000FB0")]
	[FieldOffset(Offset = "0x18")]
	private TutorialToLearnLogic _tutorialToLearnLogic;

	[Token(Token = "0x17000295")]
	public TutorialToLearnType TutorialType
	{
		[Token(Token = "0x600117F")]
		[Address(RVA = "0xCA63CC", Offset = "0xCA63CC", VA = "0xCA63CC")]
		get
		{
			return default(TutorialToLearnType);
		}
	}

	[Token(Token = "0x17000296")]
	public bool RestartOnQuitOrFail
	{
		[Token(Token = "0x6001180")]
		[Address(RVA = "0xCA76B8", Offset = "0xCA76B8", VA = "0xCA76B8")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000297")]
	public bool IsRepeating
	{
		[Token(Token = "0x6001181")]
		[Address(RVA = "0xCA76D4", Offset = "0xCA76D4", VA = "0xCA76D4")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6001182")]
	[Address(RVA = "0xCA6610", Offset = "0xCA6610", VA = "0xCA6610")]
	public bool CanUseAction()
	{
		return default(bool);
	}

	[Token(Token = "0x6001183")]
	[Address(RVA = "0xCA63E8", Offset = "0xCA63E8", VA = "0xCA63E8")]
	public bool IsCompleted()
	{
		return default(bool);
	}

	[Token(Token = "0x6001184")]
	[Address(RVA = "0xCA61AC", Offset = "0xCA61AC", VA = "0xCA61AC")]
	public bool Update()
	{
		return default(bool);
	}

	[Token(Token = "0x6001185")]
	[Address(RVA = "0xCA71E4", Offset = "0xCA71E4", VA = "0xCA71E4")]
	public bool CheckCompletion()
	{
		return default(bool);
	}

	[Token(Token = "0x6001186")]
	[Address(RVA = "0xCAAA28", Offset = "0xCAAA28", VA = "0xCAAA28")]
	private TutorialToLearnLogic GetSpecificLogic()
	{
		return null;
	}

	[Token(Token = "0x6001187")]
	[Address(RVA = "0xCA76F0", Offset = "0xCA76F0", VA = "0xCA76F0")]
	public void ForceCompletedTo(bool completed)
	{
	}

	[Token(Token = "0x6001188")]
	[Address(RVA = "0xCAAF88", Offset = "0xCAAF88", VA = "0xCAAF88")]
	public TutorialToLearn()
	{
	}
}
