using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000759")]
public class TallyRivalBeatenItem : View
{
	[Token(Token = "0x4002998")]
	[FieldOffset(Offset = "0x60")]
	public UISprite NoAvatarSprite;

	[Token(Token = "0x4002999")]
	[FieldOffset(Offset = "0x68")]
	public UITexture AvatarTexture;

	[Token(Token = "0x400299A")]
	[FieldOffset(Offset = "0x70")]
	public TweenAlpha CrossFadeUpTween;

	[Token(Token = "0x17000643")]
	public Texture Avatar
	{
		[Token(Token = "0x60030F4")]
		[Address(RVA = "0xB4FB9C", Offset = "0xB4FB9C", VA = "0xB4FB9C")]
		get
		{
			return null;
		}
		[Token(Token = "0x60030F5")]
		[Address(RVA = "0xB4FBBC", Offset = "0xB4FBBC", VA = "0xB4FBBC")]
		set
		{
		}
	}

	[Token(Token = "0x60030F6")]
	[Address(RVA = "0xB4FBDC", Offset = "0xB4FBDC", VA = "0xB4FBDC")]
	public void SetAvatar(Texture avatar)
	{
	}

	[Token(Token = "0x60030F7")]
	[Address(RVA = "0xB4FCAC", Offset = "0xB4FCAC", VA = "0xB4FCAC")]
	public TallyRivalBeatenItem()
	{
	}
}
