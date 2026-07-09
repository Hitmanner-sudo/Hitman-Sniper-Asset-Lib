using System;
using Il2CppDummyDll;
using SimpleJSON;
using Technology;
using UnityEngine;

[Serializable]
[Token(Token = "0x200036A")]
public class UnlockableSaveData : ScriptableObject, ISaveable
{
	[Token(Token = "0x40012E2")]
	[FieldOffset(Offset = "0x18")]
	public Rarity ItemRarity;

	[Token(Token = "0x40012E3")]
	[FieldOffset(Offset = "0x1C")]
	[AttributeAttribute(Name = "SaveableAttribute", RVA = "0x5B4638", Offset = "0x5B4638")]
	public bool ShowNewFeedback;

	[Token(Token = "0x40012E4")]
	[FieldOffset(Offset = "0x1D")]
	public bool JustUnlocked;

	[NonSerialized]
	[Token(Token = "0x40012E5")]
	[FieldOffset(Offset = "0x20")]
	public int UnlockedAtRank;

	[Token(Token = "0x1700030D")]
	public virtual bool Unlocked
	{
		[Token(Token = "0x600147F")]
		[Address(RVA = "0xB9C8B8", Offset = "0xB9C8B8", VA = "0xB9C8B8", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6001480")]
	[Address(RVA = "0xB9C9D4", Offset = "0xB9C9D4", VA = "0xB9C9D4", Slot = "7")]
	public virtual void Unlock(bool showNewFeedback = true)
	{
	}

	[Token(Token = "0x6001481")]
	[Address(RVA = "0xB9C9F8", Offset = "0xB9C9F8", VA = "0xB9C9F8", Slot = "8")]
	public virtual bool HasNewFeedback()
	{
		return default(bool);
	}

	[Token(Token = "0x6001482")]
	[Address(RVA = "0xB9CA1C", Offset = "0xB9CA1C", VA = "0xB9CA1C")]
	public bool IsProgressionLocked()
	{
		return default(bool);
	}

	[Token(Token = "0x6001483")]
	[Address(RVA = "0xB9CAB8", Offset = "0xB9CAB8", VA = "0xB9CAB8", Slot = "9")]
	public virtual void OnSaveableDeserialization(JSONNode data)
	{
	}

	[Token(Token = "0x6001484")]
	[Address(RVA = "0xB9CB40", Offset = "0xB9CB40", VA = "0xB9CB40", Slot = "10")]
	public virtual JSONNode OnSaveableSerialization()
	{
		return null;
	}

	[Token(Token = "0x6001485")]
	[Address(RVA = "0xB9CBB8", Offset = "0xB9CBB8", VA = "0xB9CBB8")]
	public UnlockableSaveData()
	{
	}
}
