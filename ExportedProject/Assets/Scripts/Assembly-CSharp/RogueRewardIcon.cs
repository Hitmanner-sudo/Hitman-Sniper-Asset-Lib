using System;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20006C4")]
public class RogueRewardIcon : View
{
	[Token(Token = "0x4002601")]
	[FieldOffset(Offset = "0x60")]
	public BlueprintPartIconView RewardPrefab;

	[Token(Token = "0x4002602")]
	[FieldOffset(Offset = "0x68")]
	public UILabel Title;

	[Token(Token = "0x4002603")]
	[FieldOffset(Offset = "0x70")]
	public UILabel Score;

	[Token(Token = "0x4002604")]
	[FieldOffset(Offset = "0x78")]
	public UISprite Bar;

	[Token(Token = "0x4002605")]
	[FieldOffset(Offset = "0x80")]
	public Transform RewardAnchor;

	[Token(Token = "0x4002606")]
	[FieldOffset(Offset = "0x88")]
	public ButtonHandler Container;

	[NonSerialized]
	[Token(Token = "0x4002607")]
	[FieldOffset(Offset = "0x90")]
	public BlueprintPartIconView RewardIcon;

	[Token(Token = "0x6002C8D")]
	[Address(RVA = "0x972F00", Offset = "0x972F00", VA = "0x972F00")]
	public void CreateBlueprintPartIcon()
	{
	}

	[Token(Token = "0x6002C8E")]
	[Address(RVA = "0x9730D0", Offset = "0x9730D0", VA = "0x9730D0", Slot = "10")]
	protected override void OnDestroy()
	{
	}

	[Token(Token = "0x6002C8F")]
	[Address(RVA = "0x973280", Offset = "0x973280", VA = "0x973280")]
	public void SetAvailability(bool available)
	{
	}

	[Token(Token = "0x6002C90")]
	[Address(RVA = "0x9734F0", Offset = "0x9734F0", VA = "0x9734F0")]
	public RogueRewardIcon()
	{
	}
}
