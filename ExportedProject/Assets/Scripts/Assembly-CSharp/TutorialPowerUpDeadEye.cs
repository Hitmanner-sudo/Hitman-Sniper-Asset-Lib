using Il2CppDummyDll;

[Token(Token = "0x20002D1")]
public class TutorialPowerUpDeadEye : TutorialPowerUp
{
	[Token(Token = "0x6001155")]
	[Address(RVA = "0xCA93EC", Offset = "0xCA93EC", VA = "0xCA93EC")]
	public TutorialPowerUpDeadEye(TutorialToLearnData data)
	{
	}

	[Token(Token = "0x6001156")]
	[Address(RVA = "0xCA9418", Offset = "0xCA9418", VA = "0xCA9418", Slot = "12")]
	protected override int GetTooltipIndex()
	{
		return default(int);
	}

	[Token(Token = "0x6001157")]
	[Address(RVA = "0xCA967C", Offset = "0xCA967C", VA = "0xCA967C", Slot = "13")]
	protected override SaveGameManager.SaveGameFlags GetSaveFlag()
	{
		return default(SaveGameManager.SaveGameFlags);
	}

	[Token(Token = "0x6001158")]
	[Address(RVA = "0xCA9684", Offset = "0xCA9684", VA = "0xCA9684", Slot = "14")]
	protected override bool ShouldHidePowerUps()
	{
		return default(bool);
	}
}
