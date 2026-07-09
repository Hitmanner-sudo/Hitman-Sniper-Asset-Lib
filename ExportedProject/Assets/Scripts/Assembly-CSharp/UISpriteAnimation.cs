using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20000A1")]
[Attribute(Name = "AddComponentMenu", RVA = "0x591E68", Offset = "0x591E68")]
[Attribute(Name = "RequireComponent", RVA = "0x591E68", Offset = "0x591E68")]
[ExecuteInEditMode]
public class UISpriteAnimation : MonoBehaviour
{
	[Token(Token = "0x40003CE")]
	[FieldOffset(Offset = "0x18")]
	[HideInInspector]
	[SerializeField]
	private int mFPS;

	[Token(Token = "0x40003CF")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[HideInInspector]
	private string mPrefix;

	[Token(Token = "0x40003D0")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[HideInInspector]
	private bool mLoop;

	[Token(Token = "0x40003D1")]
	[FieldOffset(Offset = "0x30")]
	private UISprite mSprite;

	[Token(Token = "0x40003D2")]
	[FieldOffset(Offset = "0x38")]
	private float mDelta;

	[Token(Token = "0x40003D3")]
	[FieldOffset(Offset = "0x3C")]
	private int mIndex;

	[Token(Token = "0x40003D4")]
	[FieldOffset(Offset = "0x40")]
	private bool mActive;

	[Token(Token = "0x40003D5")]
	[FieldOffset(Offset = "0x48")]
	private List<string> mSpriteNames;

	[Token(Token = "0x17000105")]
	public int frames
	{
		[Token(Token = "0x600051A")]
		[Address(RVA = "0x1169B3C", Offset = "0x1169B3C", VA = "0x1169B3C")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000106")]
	public int framesPerSecond
	{
		[Token(Token = "0x600051B")]
		[Address(RVA = "0x1169B88", Offset = "0x1169B88", VA = "0x1169B88")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600051C")]
		[Address(RVA = "0x1169B90", Offset = "0x1169B90", VA = "0x1169B90")]
		set
		{
		}
	}

	[Token(Token = "0x17000107")]
	public string namePrefix
	{
		[Token(Token = "0x600051D")]
		[Address(RVA = "0x1169B98", Offset = "0x1169B98", VA = "0x1169B98")]
		get
		{
			return null;
		}
		[Token(Token = "0x600051E")]
		[Address(RVA = "0x1169BA0", Offset = "0x1169BA0", VA = "0x1169BA0")]
		set
		{
		}
	}

	[Token(Token = "0x17000108")]
	public bool loop
	{
		[Token(Token = "0x600051F")]
		[Address(RVA = "0x1169E28", Offset = "0x1169E28", VA = "0x1169E28")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000520")]
		[Address(RVA = "0x1169E30", Offset = "0x1169E30", VA = "0x1169E30")]
		set
		{
		}
	}

	[Token(Token = "0x17000109")]
	public bool isPlaying
	{
		[Token(Token = "0x6000521")]
		[Address(RVA = "0x1169E3C", Offset = "0x1169E3C", VA = "0x1169E3C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6000522")]
	[Address(RVA = "0x1169E44", Offset = "0x1169E44", VA = "0x1169E44")]
	private void Start()
	{
	}

	[Token(Token = "0x6000523")]
	[Address(RVA = "0x1169E48", Offset = "0x1169E48", VA = "0x1169E48")]
	private void Update()
	{
	}

	[Token(Token = "0x6000524")]
	[Address(RVA = "0x1169BE4", Offset = "0x1169BE4", VA = "0x1169BE4")]
	private void RebuildSpriteList()
	{
	}

	[Token(Token = "0x6000525")]
	[Address(RVA = "0x1169FB4", Offset = "0x1169FB4", VA = "0x1169FB4")]
	public void Reset()
	{
	}

	[Token(Token = "0x6000526")]
	[Address(RVA = "0x116A0C4", Offset = "0x116A0C4", VA = "0x116A0C4")]
	public UISpriteAnimation()
	{
	}
}
