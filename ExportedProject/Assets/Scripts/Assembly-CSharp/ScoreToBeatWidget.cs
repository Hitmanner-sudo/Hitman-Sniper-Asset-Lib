using Il2CppDummyDll;
using Technology;
using UnityEngine;

[Token(Token = "0x2000797")]
public class ScoreToBeatWidget : GameMonoBehaviour
{
	[Token(Token = "0x4002AC2")]
	[FieldOffset(Offset = "0x48")]
	public UITexture AvatarTexture;

	[Token(Token = "0x4002AC3")]
	[FieldOffset(Offset = "0x50")]
	public UISprite AvatarNoPicture;

	[Token(Token = "0x4002AC4")]
	[FieldOffset(Offset = "0x58")]
	public UILabel NameLabel;

	[Token(Token = "0x4002AC5")]
	[FieldOffset(Offset = "0x60")]
	public UILabel ScoreLabel;

	[Token(Token = "0x1700066C")]
	public Texture Avatar
	{
		[Token(Token = "0x600323F")]
		[Address(RVA = "0xB65968", Offset = "0xB65968", VA = "0xB65968")]
		get
		{
			return null;
		}
		[Token(Token = "0x6003240")]
		[Address(RVA = "0xB65988", Offset = "0xB65988", VA = "0xB65988")]
		set
		{
		}
	}

	[Token(Token = "0x1700066D")]
	public string Name
	{
		[Token(Token = "0x6003241")]
		[Address(RVA = "0xB659A8", Offset = "0xB659A8", VA = "0xB659A8")]
		get
		{
			return null;
		}
		[Token(Token = "0x6003242")]
		[Address(RVA = "0xB659C4", Offset = "0xB659C4", VA = "0xB659C4")]
		set
		{
		}
	}

	[Token(Token = "0x1700066E")]
	public string Score
	{
		[Token(Token = "0x6003243")]
		[Address(RVA = "0xB659E0", Offset = "0xB659E0", VA = "0xB659E0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6003244")]
		[Address(RVA = "0xB659FC", Offset = "0xB659FC", VA = "0xB659FC")]
		set
		{
		}
	}

	[Token(Token = "0x6003245")]
	[Address(RVA = "0xB65A18", Offset = "0xB65A18", VA = "0xB65A18")]
	public ScoreToBeatWidget()
	{
	}
}
