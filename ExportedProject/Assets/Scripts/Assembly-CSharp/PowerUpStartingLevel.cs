using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200041E")]
public class PowerUpStartingLevel : PerkReward
{
	[Token(Token = "0x40016F2")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private ChallengeData.DefaultPowerUp _newDefaultPowerUp;

	[Token(Token = "0x40016F3")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private int _levelBonus;

	[Token(Token = "0x1700040D")]
	public override string GetDescription
	{
		[Token(Token = "0x600195E")]
		[Address(RVA = "0x945C98", Offset = "0x945C98", VA = "0x945C98", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600195F")]
	[Address(RVA = "0x945D18", Offset = "0x945D18", VA = "0x945D18", Slot = "5")]
	public override void Activate()
	{
	}

	[Token(Token = "0x6001960")]
	[Address(RVA = "0x945EF8", Offset = "0x945EF8", VA = "0x945EF8", Slot = "6")]
	public override void Deactivate()
	{
	}

	[Token(Token = "0x6001961")]
	[Address(RVA = "0x945D20", Offset = "0x945D20", VA = "0x945D20")]
	private void AdjustWeaponStats(int levelBonus)
	{
	}

	[Token(Token = "0x6001962")]
	[Address(RVA = "0x945F04", Offset = "0x945F04", VA = "0x945F04")]
	public PowerUpStartingLevel()
	{
	}
}
