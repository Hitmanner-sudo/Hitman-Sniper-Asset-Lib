using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000524")]
public class LeaderboardFriendManagementController : UIController
{
	[Token(Token = "0x4001B27")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private BlinkButtonHandler[] _facebookButtons;

	[Token(Token = "0x4001B28")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	private BlinkButtonHandler _addFriendsButton;

	[Token(Token = "0x6001FDE")]
	[Address(RVA = "0x99EFC8", Offset = "0x99EFC8", VA = "0x99EFC8", Slot = "11")]
	protected override void OnEnable()
	{
	}

	[Token(Token = "0x6001FDF")]
	[Address(RVA = "0x99F234", Offset = "0x99F234", VA = "0x99F234", Slot = "12")]
	protected override void OnDisable()
	{
	}

	[Token(Token = "0x6001FE0")]
	[Address(RVA = "0x99F45C", Offset = "0x99F45C", VA = "0x99F45C")]
	private void OnAddFriendsButtonBlinkFinished(object sender, BlinkButtonHandler.ButtonBlinkFinishedHandlerEventArgs e)
	{
	}

	[Token(Token = "0x6001FE1")]
	[Address(RVA = "0x99F4B0", Offset = "0x99F4B0", VA = "0x99F4B0")]
	private void OnFacebookButtonBlinkFinished(object sender, BlinkButtonHandler.ButtonBlinkFinishedHandlerEventArgs e)
	{
	}

	[Token(Token = "0x6001FE2")]
	[Address(RVA = "0x99F1C0", Offset = "0x99F1C0", VA = "0x99F1C0")]
	private void OnFriendCountChanged()
	{
	}

	[Token(Token = "0x6001FE3")]
	[Address(RVA = "0x99F4B4", Offset = "0x99F4B4", VA = "0x99F4B4")]
	public LeaderboardFriendManagementController()
	{
	}
}
