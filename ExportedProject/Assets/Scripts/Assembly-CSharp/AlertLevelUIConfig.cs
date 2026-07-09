using System;
using Il2CppDummyDll;
using UnityEngine;

[Serializable]
[Token(Token = "0x200057C")]
public class AlertLevelUIConfig
{
	[Token(Token = "0x4001CE7")]
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	private string _localizedName;

	[Token(Token = "0x4001CE8")]
	[FieldOffset(Offset = "0x18")]
	public Color BackgroundFromColor;

	[Token(Token = "0x4001CE9")]
	[FieldOffset(Offset = "0x28")]
	public Color BackgroundToColor;

	[Token(Token = "0x4001CEA")]
	[FieldOffset(Offset = "0x38")]
	public Color TextColor;

	[Token(Token = "0x4001CEB")]
	[FieldOffset(Offset = "0x48")]
	public Color TagColor;

	[Token(Token = "0x4001CEC")]
	[FieldOffset(Offset = "0x58")]
	public Color IconTagColor;

	[Token(Token = "0x4001CED")]
	[FieldOffset(Offset = "0x68")]
	public string IconTagSpriteName;

	[Token(Token = "0x4001CEE")]
	[FieldOffset(Offset = "0x70")]
	public bool StayOnAnimFinished;

	[Token(Token = "0x170004F2")]
	public string Name
	{
		[Token(Token = "0x600227D")]
		[Address(RVA = "0xD5F0C8", Offset = "0xD5F0C8", VA = "0xD5F0C8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600227E")]
	[Address(RVA = "0xD5F130", Offset = "0xD5F130", VA = "0xD5F130")]
	public AlertLevelUIConfig()
	{
	}
}
