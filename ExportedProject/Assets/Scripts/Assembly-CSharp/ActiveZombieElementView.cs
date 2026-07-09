using System;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200063B")]
public class ActiveZombieElementView : View
{
	[NonSerialized]
	[Token(Token = "0x4002247")]
	[FieldOffset(Offset = "0x60")]
	public Faction faction;

	[Token(Token = "0x4002248")]
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	private UILabel _amountUILabel;

	[Token(Token = "0x4002249")]
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	private UISprite _iconUISprite;

	[Token(Token = "0x400224A")]
	[FieldOffset(Offset = "0x78")]
	[SerializeField]
	private UISprite _backgroundUISprite;

	[Token(Token = "0x400224B")]
	[FieldOffset(Offset = "0x80")]
	[SerializeField]
	private UISprite _flourishUISprite;

	[Token(Token = "0x400224C")]
	[FieldOffset(Offset = "0x88")]
	[SerializeField]
	private TweenScale _flourishTweenScale;

	[Token(Token = "0x400224D")]
	[FieldOffset(Offset = "0x90")]
	[SerializeField]
	private TweenAlpha _flourishTweenAlpha;

	[Token(Token = "0x400224E")]
	[FieldOffset(Offset = "0x98")]
	private int _currentZombieAmount;

	[Token(Token = "0x17000548")]
	public bool IsFlourishing
	{
		[Token(Token = "0x6002836")]
		[Address(RVA = "0xD5B0F0", Offset = "0xD5B0F0", VA = "0xD5B0F0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6002837")]
	[Address(RVA = "0xD5B140", Offset = "0xD5B140", VA = "0xD5B140")]
	public void IncreaseAmount(int amount)
	{
	}

	[Token(Token = "0x6002838")]
	[Address(RVA = "0xD5B1F0", Offset = "0xD5B1F0", VA = "0xD5B1F0")]
	public void SetIcon(LazyUIAtlas lazyUIAtlas, string IconName)
	{
	}

	[Token(Token = "0x6002839")]
	[Address(RVA = "0xD5B290", Offset = "0xD5B290", VA = "0xD5B290")]
	public void SetBackground(LazyUIAtlas lazyUIAtlas, string IconName, Color color)
	{
	}

	[Token(Token = "0x600283A")]
	[Address(RVA = "0xD5B3F8", Offset = "0xD5B3F8", VA = "0xD5B3F8")]
	public void DoFlourish()
	{
	}

	[Token(Token = "0x600283B")]
	[Address(RVA = "0xD5B488", Offset = "0xD5B488", VA = "0xD5B488")]
	public ActiveZombieElementView()
	{
	}
}
