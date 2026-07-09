using System;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200067F")]
public class LeaderboardFriendManagementView : View
{
	[Token(Token = "0x4002447")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	private GameObject _visual;

	[Token(Token = "0x4002448")]
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	private GameObject _facebookNotConnectedIncentive;

	[Token(Token = "0x4002449")]
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	private GameObject _facebookNotConnected;

	[Token(Token = "0x400244A")]
	[FieldOffset(Offset = "0x78")]
	[SerializeField]
	private GameObject _facebookConnected;

	[Token(Token = "0x400244B")]
	[FieldOffset(Offset = "0x80")]
	[SerializeField]
	private UILabel _addFriendsLabel;

	[Token(Token = "0x400244C")]
	[FieldOffset(Offset = "0x88")]
	[SerializeField]
	private UILabel _friendCountLabel;

	[Token(Token = "0x400244D")]
	[FieldOffset(Offset = "0x90")]
	[SerializeField]
	private string _addFriendsKey;

	[Token(Token = "0x400244E")]
	[FieldOffset(Offset = "0x98")]
	[SerializeField]
	private string _maxFriendsReachedKey;

	[Token(Token = "0x400244F")]
	[FieldOffset(Offset = "0xA0")]
	[SerializeField]
	private UILabel _facebookIncentiveAmountLabel;

	[Token(Token = "0x6002A74")]
	[Address(RVA = "0x99CCB8", Offset = "0x99CCB8", VA = "0x99CCB8")]
	public void RefreshVisual()
	{
	}

	[Token(Token = "0x6002A75")]
	[Address(RVA = "0x99F720", Offset = "0x99F720", VA = "0x99F720", Slot = "11")]
	protected override void OnEnable()
	{
	}

	[Token(Token = "0x6002A76")]
	[Address(RVA = "0x99F898", Offset = "0x99F898", VA = "0x99F898", Slot = "12")]
	protected override void OnDisable()
	{
	}

	[Token(Token = "0x6002A77")]
	[Address(RVA = "0x99FA40", Offset = "0x99FA40", VA = "0x99FA40", Slot = "14")]
	protected override void OnVariableChanged(object sender, DataModel.VariableChangedEventArgs args)
	{
	}

	[Token(Token = "0x6002A78")]
	[Address(RVA = "0x99F5D0", Offset = "0x99F5D0", VA = "0x99F5D0")]
	private void OnFriendCountChanged()
	{
	}

	[Token(Token = "0x6002A79")]
	[Address(RVA = "0x99F4BC", Offset = "0x99F4BC", VA = "0x99F4BC")]
	private void OnLocalize(object sender, EventArgs e)
	{
	}

	[Token(Token = "0x6002A7A")]
	[Address(RVA = "0x99FB54", Offset = "0x99FB54", VA = "0x99FB54")]
	public LeaderboardFriendManagementView()
	{
	}
}
