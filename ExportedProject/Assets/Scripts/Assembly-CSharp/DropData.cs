using System;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200037C")]
public class DropData : ScriptableObject
{
	[Token(Token = "0x400136E")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private float _rarityBonusRatio;

	[NonSerialized]
	[Token(Token = "0x400136F")]
	[FieldOffset(Offset = "0x1C")]
	private float _rarityBonusRatioModifier;

	[Token(Token = "0x17000330")]
	public float RarityBonusRatio
	{
		[Token(Token = "0x6001546")]
		[Address(RVA = "0xC2007C", Offset = "0xC2007C", VA = "0xC2007C")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x6001547")]
	[Address(RVA = "0xC20088", Offset = "0xC20088", VA = "0xC20088")]
	public void ResetModifiers()
	{
	}

	[Token(Token = "0x6001548")]
	[Address(RVA = "0xC20090", Offset = "0xC20090", VA = "0xC20090")]
	public void ApplyAttachment(Attachment attachment)
	{
	}

	[Token(Token = "0x6001549")]
	[Address(RVA = "0xC200E4", Offset = "0xC200E4", VA = "0xC200E4")]
	public DropData()
	{
	}
}
