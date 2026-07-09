using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200075E")]
public abstract class TallyRouletteItem : MonoBehaviour
{
	[Token(Token = "0x40029A7")]
	[FieldOffset(Offset = "0x18")]
	public UILabel TopLabel;

	[Token(Token = "0x40029A8")]
	[FieldOffset(Offset = "0x20")]
	public UISprite TopSprite;

	[Token(Token = "0x40029A9")]
	[FieldOffset(Offset = "0x28")]
	public UILabel BottomLabel;

	[Token(Token = "0x40029AA")]
	[FieldOffset(Offset = "0x30")]
	public UISprite BottomSprite;

	[Token(Token = "0x40029AB")]
	[FieldOffset(Offset = "0x38")]
	public UITexture BottomTexture;

	[NonSerialized]
	[Token(Token = "0x40029AC")]
	[FieldOffset(Offset = "0x40")]
	public Rarity Rarity;

	[Token(Token = "0x40029AD")]
	[FieldOffset(Offset = "0x48")]
	public GameObject RarityBorderGO;

	[Token(Token = "0x40029AE")]
	[FieldOffset(Offset = "0x50")]
	public UISprite RarityGradient;

	[NonSerialized]
	[Token(Token = "0x40029AF")]
	[FieldOffset(Offset = "0x58")]
	public Action OnFlourish;

	[Token(Token = "0x40029B0")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	private TweenScale _rarityTween;

	[Token(Token = "0x40029B1")]
	protected const float SPRITE_MOVE_UP_DURATION = 0.5f;

	[Token(Token = "0x40029B2")]
	protected const float FLOURISH_DURATION = 0.5f;

	[Token(Token = "0x40029B3")]
	[FieldOffset(Offset = "0x68")]
	private UISprite[] _borderSprites;

	[Token(Token = "0x6003106")]
	[Address(RVA = "0xB4FCF0", Offset = "0xB4FCF0", VA = "0xB4FCF0", Slot = "4")]
	public virtual void OnEnable()
	{
	}

	[Token(Token = "0x6003107")]
	[Address(RVA = "0xB4FECC", Offset = "0xB4FECC", VA = "0xB4FECC", Slot = "5")]
	protected virtual void OnDestroy()
	{
	}

	[Token(Token = "0x6003108")]
	[Address(RVA = "0xB4FF4C", Offset = "0xB4FF4C", VA = "0xB4FF4C")]
	public void SetBorderAlpha(float newAlpha)
	{
	}

	[Token(Token = "0x6003109")]
	[Address(RVA = "0xB4FFE8", Offset = "0xB4FFE8", VA = "0xB4FFE8")]
	public void FadeUpGradient()
	{
	}

	[Token(Token = "0x600310A")]
	[Address(RVA = "0xB5001C", Offset = "0xB5001C", VA = "0xB5001C")]
	public void ExpandRarityBorder()
	{
	}

	[Token(Token = "0x600310B")]
	public abstract IEnumerator DoAnimation();

	[Token(Token = "0x600310C")]
	[Address(RVA = "0xB4FEC4", Offset = "0xB4FEC4", VA = "0xB4FEC4")]
	protected TallyRouletteItem()
	{
	}
}
