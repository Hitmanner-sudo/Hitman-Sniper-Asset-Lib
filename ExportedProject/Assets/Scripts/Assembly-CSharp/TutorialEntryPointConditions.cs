using System;
using Il2CppDummyDll;

[Serializable]
[Token(Token = "0x20002B8")]
public class TutorialEntryPointConditions
{
	[Token(Token = "0x20002B9")]
	public enum MainMenuTutorial
	{
		[Token(Token = "0x4000F59")]
		NONE = 0,
		[Token(Token = "0x4000F5A")]
		FirstArmory = 1,
		[Token(Token = "0x4000F5B")]
		SecondArmory = 2,
		[Token(Token = "0x4000F5C")]
		FirstTarget = 3,
		[Token(Token = "0x4000F5D")]
		DEPRECATED_FacebookIncentiveA = 4,
		[Token(Token = "0x4000F5E")]
		DEPRECATED_FacebookIncentiveB = 5,
		[Token(Token = "0x4000F5F")]
		DEPRECATED_BundlePrompt = 6,
		[Token(Token = "0x4000F60")]
		FirstContractScreen = 7,
		[Token(Token = "0x4000F61")]
		ChallengeModeUnlocked = 8
	}

	[Token(Token = "0x4000F54")]
	[FieldOffset(Offset = "0x10")]
	public int MissionToHaveBeenCompleted;

	[Token(Token = "0x4000F55")]
	[FieldOffset(Offset = "0x14")]
	public int MissionToHaveBeenCompletedAndNotSkipped;

	[Token(Token = "0x4000F56")]
	[FieldOffset(Offset = "0x18")]
	public int DoNotShowAfterThisMissionCompleted;

	[Token(Token = "0x4000F57")]
	[FieldOffset(Offset = "0x1C")]
	public MainMenuTutorial TutorialToCheck;

	[Token(Token = "0x6001097")]
	[Address(RVA = "0xCA12BC", Offset = "0xCA12BC", VA = "0xCA12BC")]
	public TutorialEntryPointConditions()
	{
	}
}
