using System;
using Il2CppDummyDll;
using SimpleJSON;
using Technology;

[Serializable]
[Token(Token = "0x2000415")]
public class PerkSaveData : ISaveable
{
	[Token(Token = "0x40016E1")]
	[FieldOffset(Offset = "0x10")]
	[AttributeAttribute(Name = "SaveableAttribute", RVA = "0x5B5A44", Offset = "0x5B5A44")]
	public int CurrentProgress;

	[Token(Token = "0x40016E2")]
	[FieldOffset(Offset = "0x14")]
	[AttributeAttribute(Name = "SaveableAttribute", RVA = "0x5B5A54", Offset = "0x5B5A54")]
	public bool Completed;

	[Token(Token = "0x40016E3")]
	[FieldOffset(Offset = "0x15")]
	[AttributeAttribute(Name = "SaveableAttribute", RVA = "0x5B5A64", Offset = "0x5B5A64")]
	public bool Claimed;

	[Token(Token = "0x40016E4")]
	[FieldOffset(Offset = "0x16")]
	[AttributeAttribute(Name = "SaveableAttribute", RVA = "0x5B5A74", Offset = "0x5B5A74")]
	public bool HasNewFeedback;

	[Token(Token = "0x600193A")]
	[Address(RVA = "0x8FEA9C", Offset = "0x8FEA9C", VA = "0x8FEA9C")]
	public bool IsClaimable()
	{
		return default(bool);
	}

	[Token(Token = "0x600193B")]
	[Address(RVA = "0x901C2C", Offset = "0x901C2C", VA = "0x901C2C", Slot = "6")]
	public virtual void OnSaveableDeserialization(JSONNode data)
	{
	}

	[Token(Token = "0x600193C")]
	[Address(RVA = "0x901CB4", Offset = "0x901CB4", VA = "0x901CB4", Slot = "7")]
	public virtual JSONNode OnSaveableSerialization()
	{
		return null;
	}

	[Token(Token = "0x600193D")]
	[Address(RVA = "0x8FD7E0", Offset = "0x8FD7E0", VA = "0x8FD7E0")]
	public PerkSaveData()
	{
	}
}
