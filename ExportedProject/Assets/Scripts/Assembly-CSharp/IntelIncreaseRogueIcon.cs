using System;
using Il2CppDummyDll;
using UnityEngine;

[Serializable]
[Token(Token = "0x2000713")]
public class IntelIncreaseRogueIcon : MonoBehaviour
{
	[Token(Token = "0x4002807")]
	[FieldOffset(Offset = "0x18")]
	public UILabel IntelLabel;

	[Token(Token = "0x4002808")]
	[FieldOffset(Offset = "0x20")]
	public UISprite RogueIcon;

	[Token(Token = "0x4002809")]
	[FieldOffset(Offset = "0x28")]
	public UISprite RarityBorder;

	[NonSerialized]
	[Token(Token = "0x400280A")]
	[FieldOffset(Offset = "0x30")]
	public IntelUnlockable IntelUnlockable;

	[Token(Token = "0x6002F1C")]
	[Address(RVA = "0xB16A78", Offset = "0xB16A78", VA = "0xB16A78")]
	public void Refresh()
	{
	}

	[Token(Token = "0x6002F1D")]
	[Address(RVA = "0xB16CA4", Offset = "0xB16CA4", VA = "0xB16CA4")]
	public IntelIncreaseRogueIcon()
	{
	}
}
