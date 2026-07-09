using Il2CppDummyDll;

[Token(Token = "0x20001DF")]
public class ContractVoiceOverConfig : BaseConfig<ContractVoiceOverConfig>
{
	[Token(Token = "0x4000ACA")]
	[FieldOffset(Offset = "0x30")]
	public Bark AlertWarning;

	[Token(Token = "0x4000ACB")]
	[FieldOffset(Offset = "0x38")]
	public Bark OnFirstKill;

	[Token(Token = "0x4000ACC")]
	[FieldOffset(Offset = "0x40")]
	public Bark OnKill;

	[Token(Token = "0x4000ACD")]
	[FieldOffset(Offset = "0x48")]
	public Bark OnKillHeadshot;

	[Token(Token = "0x4000ACE")]
	[FieldOffset(Offset = "0x50")]
	public Bark OnAccidentKill;

	[Token(Token = "0x4000ACF")]
	[FieldOffset(Offset = "0x58")]
	public Bark OnCivilianKill;

	[Token(Token = "0x4000AD0")]
	[FieldOffset(Offset = "0x60")]
	public Bark OnConclaveKill;

	[Token(Token = "0x4000AD1")]
	[FieldOffset(Offset = "0x68")]
	public Bark OnContractComplete;

	[Token(Token = "0x4000AD2")]
	[FieldOffset(Offset = "0x70")]
	public Bark OnContractFailed;

	[Token(Token = "0x4000AD3")]
	[FieldOffset(Offset = "0x78")]
	public Bark OnMissionCompleteContractOver;

	[Token(Token = "0x4000AD4")]
	[FieldOffset(Offset = "0x80")]
	public Bark OnMissionCompleteContractNotOver;

	[Token(Token = "0x4000AD5")]
	[FieldOffset(Offset = "0x88")]
	public Bark OnMarkFlee;

	[Token(Token = "0x4000AD6")]
	[FieldOffset(Offset = "0x90")]
	public Bark OnContractTimingDown;

	[Token(Token = "0x4000AD7")]
	[FieldOffset(Offset = "0x98")]
	public Bark TutorialArmoury1;

	[Token(Token = "0x4000AD8")]
	[FieldOffset(Offset = "0xA0")]
	public Bark TutorialArmoury2;

	[Token(Token = "0x4000AD9")]
	[FieldOffset(Offset = "0xA8")]
	public Bark TutorialArmouryAbilities;

	[Token(Token = "0x4000ADA")]
	[FieldOffset(Offset = "0xB0")]
	public Bark TutorialArmouryCollectPart;

	[Token(Token = "0x4000ADB")]
	[FieldOffset(Offset = "0xB8")]
	public Bark TutorialArmouryCollectAllParts;

	[Token(Token = "0x4000ADC")]
	[FieldOffset(Offset = "0xC0")]
	public Bark TutorialArmouryBlueprintComplete;

	[Token(Token = "0x4000ADD")]
	[FieldOffset(Offset = "0xC8")]
	public Bark TutorialMissionsAssignments;

	[Token(Token = "0x4000ADE")]
	[FieldOffset(Offset = "0xD0")]
	public Bark TutorialFirstLevelUp;

	[Token(Token = "0x4000ADF")]
	[FieldOffset(Offset = "0xD8")]
	public float AudioDuckingTime;

	[Token(Token = "0x4000AE0")]
	[FieldOffset(Offset = "0xDC")]
	public float AudioDuckingAmount;

	[Token(Token = "0x6000BE9")]
	[Address(RVA = "0xD7BF60", Offset = "0xD7BF60", VA = "0xD7BF60")]
	public void ResetAllSoundContainers()
	{
	}

	[Token(Token = "0x6000BEA")]
	[Address(RVA = "0xD7C168", Offset = "0xD7C168", VA = "0xD7C168")]
	public ContractVoiceOverConfig()
	{
	}
}
