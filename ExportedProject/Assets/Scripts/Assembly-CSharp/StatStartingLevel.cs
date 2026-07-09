using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000422")]
public class StatStartingLevel : PerkReward
{
	[Token(Token = "0x2000423")]
	private enum PowerUpStat
	{
		[Token(Token = "0x40016FD")]
		ClipSize = 0,
		[Token(Token = "0x40016FE")]
		FireRate = 1,
		[Token(Token = "0x40016FF")]
		Damage = 2,
		[Token(Token = "0x4001700")]
		Sway = 3,
		[Token(Token = "0x4001701")]
		BulletSpeed = 4
	}

	[Token(Token = "0x40016FA")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private PowerUpStat _statToModify;

	[Token(Token = "0x40016FB")]
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	private int _levelBonus;

	[Token(Token = "0x17000410")]
	public override string GetDescription
	{
		[Token(Token = "0x600196C")]
		[Address(RVA = "0xD29DC4", Offset = "0xD29DC4", VA = "0xD29DC4", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600196D")]
	[Address(RVA = "0xD29E44", Offset = "0xD29E44", VA = "0xD29E44", Slot = "5")]
	public override void Activate()
	{
	}

	[Token(Token = "0x600196E")]
	[Address(RVA = "0xD29FEC", Offset = "0xD29FEC", VA = "0xD29FEC", Slot = "6")]
	public override void Deactivate()
	{
	}

	[Token(Token = "0x600196F")]
	[Address(RVA = "0xD29E4C", Offset = "0xD29E4C", VA = "0xD29E4C")]
	private void AdjustWeaponStats(int levelBonus)
	{
	}

	[Token(Token = "0x6001970")]
	[Address(RVA = "0xD29FF8", Offset = "0xD29FF8", VA = "0xD29FF8")]
	public StatStartingLevel()
	{
	}
}
