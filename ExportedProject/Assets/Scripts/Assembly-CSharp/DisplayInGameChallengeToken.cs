using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000665")]
public class DisplayInGameChallengeToken : View
{
	[Token(Token = "0x4002376")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	private TweenNumber _currencyTweenNumber;

	[Token(Token = "0x4002377")]
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	private float _tweenDuration;

	[Token(Token = "0x4002378")]
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	private GameObject _displayParent;

	[Token(Token = "0x4002379")]
	[FieldOffset(Offset = "0x78")]
	[SerializeField]
	private UILabel _symbolUILabel;

	[Token(Token = "0x400237A")]
	[FieldOffset(Offset = "0x80")]
	[SerializeField]
	private UILabel _amountUILabel;

	[Token(Token = "0x6002976")]
	[Address(RVA = "0xC16844", Offset = "0xC16844", VA = "0xC16844", Slot = "7")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x6002977")]
	[Address(RVA = "0xC16AE0", Offset = "0xC16AE0", VA = "0xC16AE0", Slot = "10")]
	protected override void OnDestroy()
	{
	}

	[Token(Token = "0x6002978")]
	[Address(RVA = "0xC16C94", Offset = "0xC16C94", VA = "0xC16C94")]
	private void OnZombieTokensChanged(object sender, ZombieSpecificManager.ZombieTokensChangedEventArgs args)
	{
	}

	[Token(Token = "0x6002979")]
	[Address(RVA = "0xC16A78", Offset = "0xC16A78", VA = "0xC16A78")]
	private void SetCurrencyDisplay(int toValue)
	{
	}

	[Token(Token = "0x600297A")]
	[Address(RVA = "0xC16CAC", Offset = "0xC16CAC", VA = "0xC16CAC", Slot = "14")]
	protected override void OnVariableChanged(object sender, DataModel.VariableChangedEventArgs args)
	{
	}

	[Token(Token = "0x600297B")]
	[Address(RVA = "0xC16DBC", Offset = "0xC16DBC", VA = "0xC16DBC")]
	private void OnPauseMenuStateChanged(HUDModel.PauseMenuState newState)
	{
	}

	[Token(Token = "0x600297C")]
	[Address(RVA = "0xC16DE0", Offset = "0xC16DE0", VA = "0xC16DE0")]
	public DisplayInGameChallengeToken()
	{
	}
}
