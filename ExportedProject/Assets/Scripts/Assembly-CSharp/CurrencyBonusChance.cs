using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200041A")]
public class CurrencyBonusChance : PerkReward
{
	[Token(Token = "0x40016EE")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private ZombieProperties.CurrencyBonusChance _currencyBonusChance;

	[Token(Token = "0x40016EF")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private ModelContainer _modelContainer;

	[Token(Token = "0x1700040A")]
	public override string GetDescription
	{
		[Token(Token = "0x600194E")]
		[Address(RVA = "0xD88414", Offset = "0xD88414", VA = "0xD88414", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600194F")]
	[Address(RVA = "0xD884E4", Offset = "0xD884E4", VA = "0xD884E4", Slot = "5")]
	public override void Activate()
	{
	}

	[Token(Token = "0x6001950")]
	[Address(RVA = "0xD88640", Offset = "0xD88640", VA = "0xD88640", Slot = "6")]
	public override void Deactivate()
	{
	}

	[Token(Token = "0x6001951")]
	[Address(RVA = "0xD884EC", Offset = "0xD884EC", VA = "0xD884EC")]
	private void SetCurrencyChance(bool add)
	{
	}

	[Token(Token = "0x6001952")]
	[Address(RVA = "0xD88648", Offset = "0xD88648", VA = "0xD88648")]
	public CurrencyBonusChance()
	{
	}
}
