using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000421")]
public class StartingCurrencyBonus : PerkReward
{
	[Token(Token = "0x40016F9")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private int _currencyBonus;

	[Token(Token = "0x1700040F")]
	public override string GetDescription
	{
		[Token(Token = "0x6001967")]
		[Address(RVA = "0xD29C04", Offset = "0xD29C04", VA = "0xD29C04", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6001968")]
	[Address(RVA = "0xD29C84", Offset = "0xD29C84", VA = "0xD29C84", Slot = "5")]
	public override void Activate()
	{
	}

	[Token(Token = "0x6001969")]
	[Address(RVA = "0xD29DB0", Offset = "0xD29DB0", VA = "0xD29DB0", Slot = "6")]
	public override void Deactivate()
	{
	}

	[Token(Token = "0x600196A")]
	[Address(RVA = "0xD29C8C", Offset = "0xD29C8C", VA = "0xD29C8C")]
	private void AdjustStartingCurrencyBonus(int currencyBonus)
	{
	}

	[Token(Token = "0x600196B")]
	[Address(RVA = "0xD29DBC", Offset = "0xD29DBC", VA = "0xD29DBC")]
	public StartingCurrencyBonus()
	{
	}
}
