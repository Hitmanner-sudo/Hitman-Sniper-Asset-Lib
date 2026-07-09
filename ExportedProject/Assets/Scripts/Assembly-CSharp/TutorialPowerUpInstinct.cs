using Il2CppDummyDll;

[Token(Token = "0x20002D2")]
public class TutorialPowerUpInstinct : TutorialPowerUp
{
	[Token(Token = "0x6001159")]
	[Address(RVA = "0xCA968C", Offset = "0xCA968C", VA = "0xCA968C")]
	public TutorialPowerUpInstinct(TutorialToLearnData data)
	{
	}

	[Token(Token = "0x600115A")]
	[Address(RVA = "0xCA96B8", Offset = "0xCA96B8", VA = "0xCA96B8", Slot = "12")]
	protected override int GetTooltipIndex()
	{
		return default(int);
	}

	[Token(Token = "0x600115B")]
	[Address(RVA = "0xCA96C0", Offset = "0xCA96C0", VA = "0xCA96C0", Slot = "13")]
	protected override SaveGameManager.SaveGameFlags GetSaveFlag()
	{
		return default(SaveGameManager.SaveGameFlags);
	}

	[Token(Token = "0x600115C")]
	[Address(RVA = "0xCA96C8", Offset = "0xCA96C8", VA = "0xCA96C8", Slot = "14")]
	protected override bool ShouldHidePowerUps()
	{
		return default(bool);
	}
}
