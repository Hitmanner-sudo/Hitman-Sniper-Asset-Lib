using System;
using Il2CppDummyDll;
using UnityEngine;

[Serializable]
[Token(Token = "0x20004A1")]
public class FacebookData : ScriptableObject
{
	[Token(Token = "0x40018FD")]
	[FieldOffset(Offset = "0x18")]
	public Wallet.CurrencyAmount FriendInviteReward;

	[Token(Token = "0x40018FE")]
	[FieldOffset(Offset = "0x20")]
	public int FriendInviteMaxPlayer;

	[Token(Token = "0x40018FF")]
	[FieldOffset(Offset = "0x28")]
	public Wallet.CurrencyAmount IncentiveReward;

	[Token(Token = "0x4001900")]
	[FieldOffset(Offset = "0x30")]
	public Wallet.CurrencyAmount LikePageReward;

	[Token(Token = "0x6001C2D")]
	[Address(RVA = "0x9506C8", Offset = "0x9506C8", VA = "0x9506C8")]
	public static FacebookData GetFacebookData()
	{
		return null;
	}

	[Token(Token = "0x6001C2E")]
	[Address(RVA = "0x950790", Offset = "0x950790", VA = "0x950790")]
	public static Wallet.CurrencyAmount GetFriendInviteReward(out int friendInviteMaxPlayer)
	{
		return null;
	}

	[Token(Token = "0x6001C2F")]
	[Address(RVA = "0x9507C4", Offset = "0x9507C4", VA = "0x9507C4")]
	public static Wallet.CurrencyAmount GetIncentiveReward()
	{
		return null;
	}

	[Token(Token = "0x6001C30")]
	[Address(RVA = "0x9507E4", Offset = "0x9507E4", VA = "0x9507E4")]
	public static Wallet.CurrencyAmount GetLikePageReward()
	{
		return null;
	}

	[Token(Token = "0x6001C31")]
	[Address(RVA = "0x950804", Offset = "0x950804", VA = "0x950804")]
	public FacebookData()
	{
	}
}
