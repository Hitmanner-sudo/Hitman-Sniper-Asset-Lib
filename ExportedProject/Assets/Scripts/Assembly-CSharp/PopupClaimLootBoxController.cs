using Il2CppDummyDll;
using Technology.Ads;
using UnityEngine;

[Token(Token = "0x2000525")]
public class PopupClaimLootBoxController : UIController
{
	[Token(Token = "0x4001B29")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private BlinkButtonHandler _collectButton;

	[Token(Token = "0x4001B2A")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	private BlinkButtonHandler _doubleRewardButton;

	[Token(Token = "0x4001B2B")]
	[FieldOffset(Offset = "0x60")]
	private Ad _ad;

	[Token(Token = "0x6001FE4")]
	[Address(RVA = "0x92DB34", Offset = "0x92DB34", VA = "0x92DB34", Slot = "11")]
	protected override void OnEnable()
	{
	}

	[Token(Token = "0x6001FE5")]
	[Address(RVA = "0x92DBE0", Offset = "0x92DBE0", VA = "0x92DBE0", Slot = "12")]
	protected override void OnDisable()
	{
	}

	[Token(Token = "0x6001FE6")]
	[Address(RVA = "0x92DC8C", Offset = "0x92DC8C", VA = "0x92DC8C")]
	private void OnCollectClicked(object sender, ButtonHandler.ButtonHandlerEventArgs e)
	{
	}

	[Token(Token = "0x6001FE7")]
	[Address(RVA = "0x92DD74", Offset = "0x92DD74", VA = "0x92DD74")]
	public PopupClaimLootBoxController()
	{
	}
}
