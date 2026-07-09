using System.Collections.Generic;
using AnimationOrTween;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000048")]
[Attribute(Name = "RequireComponent", RVA = "0x591364", Offset = "0x591364")]
[Attribute(Name = "AddComponentMenu", RVA = "0x591364", Offset = "0x591364")]
public class ActiveAnimation : MonoBehaviour
{
	[Token(Token = "0x4000185")]
	[FieldOffset(Offset = "0x0")]
	public static ActiveAnimation current;

	[Token(Token = "0x4000186")]
	[FieldOffset(Offset = "0x18")]
	public List<EventDelegate> onFinished;

	[Token(Token = "0x4000187")]
	[FieldOffset(Offset = "0x20")]
	[HideInInspector]
	public GameObject eventReceiver;

	[Token(Token = "0x4000188")]
	[FieldOffset(Offset = "0x28")]
	[HideInInspector]
	public string callWhenFinished;

	[Token(Token = "0x4000189")]
	[FieldOffset(Offset = "0x30")]
	private Animation mAnim;

	[Token(Token = "0x400018A")]
	[FieldOffset(Offset = "0x38")]
	private Direction mLastDirection;

	[Token(Token = "0x400018B")]
	[FieldOffset(Offset = "0x3C")]
	private Direction mDisableDirection;

	[Token(Token = "0x400018C")]
	[FieldOffset(Offset = "0x40")]
	private bool mNotify;

	[Token(Token = "0x1700003E")]
	public bool isPlaying
	{
		[Token(Token = "0x60001B3")]
		[Address(RVA = "0xD59BD8", Offset = "0xD59BD8", VA = "0xD59BD8")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x60001B4")]
	[Address(RVA = "0xD59F6C", Offset = "0xD59F6C", VA = "0xD59F6C")]
	public void Reset()
	{
	}

	[Token(Token = "0x60001B5")]
	[Address(RVA = "0xD5A27C", Offset = "0xD5A27C", VA = "0xD5A27C")]
	private void Start()
	{
	}

	[Token(Token = "0x60001B6")]
	[Address(RVA = "0xD5A340", Offset = "0xD5A340", VA = "0xD5A340")]
	private void Update()
	{
	}

	[Token(Token = "0x60001B7")]
	[Address(RVA = "0xD5A890", Offset = "0xD5A890", VA = "0xD5A890")]
	private void Play(string clipName, Direction playDirection)
	{
	}

	[Token(Token = "0x60001B8")]
	[Address(RVA = "0xD5AD18", Offset = "0xD5AD18", VA = "0xD5AD18")]
	public static ActiveAnimation Play(Animation anim, string clipName, Direction playDirection, EnableCondition enableBeforePlay, DisableCondition disableCondition)
	{
		return null;
	}

	[Token(Token = "0x60001B9")]
	[Address(RVA = "0xD5AF70", Offset = "0xD5AF70", VA = "0xD5AF70")]
	public static ActiveAnimation Play(Animation anim, string clipName, Direction playDirection)
	{
		return null;
	}

	[Token(Token = "0x60001BA")]
	[Address(RVA = "0xD5AF7C", Offset = "0xD5AF7C", VA = "0xD5AF7C")]
	public static ActiveAnimation Play(Animation anim, Direction playDirection)
	{
		return null;
	}

	[Token(Token = "0x60001BB")]
	[Address(RVA = "0xD5AF90", Offset = "0xD5AF90", VA = "0xD5AF90")]
	public ActiveAnimation()
	{
	}
}
