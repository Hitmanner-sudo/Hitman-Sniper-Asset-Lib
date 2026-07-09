using System;
using Il2CppDummyDll;

[Serializable]
[Token(Token = "0x20002D9")]
public class TutorialToLearnData
{
	[Token(Token = "0x4000FC7")]
	[FieldOffset(Offset = "0x10")]
	public TutorialToLearn.TutorialToLearnType TutorialType;

	[Token(Token = "0x4000FC8")]
	[FieldOffset(Offset = "0x14")]
	public bool UsableIfNotLearned;

	[Token(Token = "0x4000FC9")]
	[FieldOffset(Offset = "0x18")]
	public string ToolTipText;

	[Token(Token = "0x4000FCA")]
	[FieldOffset(Offset = "0x20")]
	public string AlternateToolTipText;

	[Token(Token = "0x4000FCB")]
	[FieldOffset(Offset = "0x28")]
	public float TimeToWaitBeforeDisplay;

	[Token(Token = "0x4000FCC")]
	[FieldOffset(Offset = "0x2C")]
	public TutorialToLearn.TutorialToLearnType ValidAfterThisTutorialFinished;

	[Token(Token = "0x4000FCD")]
	[FieldOffset(Offset = "0x30")]
	public int MissionID;

	[Token(Token = "0x4000FCE")]
	[FieldOffset(Offset = "0x34")]
	public bool EqualsCurrentMissionID;

	[Token(Token = "0x4000FCF")]
	[FieldOffset(Offset = "0x35")]
	public bool HigherThanCurrentMissionID;

	[Token(Token = "0x4000FD0")]
	[FieldOffset(Offset = "0x36")]
	public bool LowerThanCurrentMissionID;

	[Token(Token = "0x4000FD1")]
	[FieldOffset(Offset = "0x37")]
	public bool RestartOnQuitOrFail;

	[Token(Token = "0x4000FD2")]
	[FieldOffset(Offset = "0x38")]
	public bool IsRepeating;

	[Token(Token = "0x6001189")]
	[Address(RVA = "0xCAAF90", Offset = "0xCAAF90", VA = "0xCAAF90")]
	public TutorialToLearnData()
	{
	}
}
