using System;
using Il2CppDummyDll;
using SimpleJSON;
using Technology;

[Serializable]
[Token(Token = "0x20003E4")]
public class AssignmentSaveData : ISaveable
{
	[NonSerialized]
	[Token(Token = "0x40015A8")]
	[FieldOffset(Offset = "0x10")]
	[AttributeAttribute(Name = "SaveableAttribute", RVA = "0x5B5140", Offset = "0x5B5140")]
	public int Progress;

	[NonSerialized]
	[Token(Token = "0x40015A9")]
	[FieldOffset(Offset = "0x14")]
	[AttributeAttribute(Name = "SaveableAttribute", RVA = "0x5B5150", Offset = "0x5B5150")]
	public int Progress2;

	[NonSerialized]
	[Token(Token = "0x40015AA")]
	[FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "SaveableAttribute", RVA = "0x5B5160", Offset = "0x5B5160")]
	public bool Skipped;

	[NonSerialized]
	[Token(Token = "0x40015AB")]
	[FieldOffset(Offset = "0x19")]
	[AttributeAttribute(Name = "SaveableAttribute", RVA = "0x5B5170", Offset = "0x5B5170")]
	public bool Completed;

	[NonSerialized]
	[Token(Token = "0x40015AC")]
	[FieldOffset(Offset = "0x1A")]
	[AttributeAttribute(Name = "SaveableAttribute", RVA = "0x5B5180", Offset = "0x5B5180")]
	public bool EverCompleted;

	[NonSerialized]
	[Token(Token = "0x40015AD")]
	[FieldOffset(Offset = "0x1B")]
	[AttributeAttribute(Name = "SaveableAttribute", RVA = "0x5B5190", Offset = "0x5B5190")]
	public bool WasStarRewarded;

	[Token(Token = "0x170003D8")]
	public bool IsCompleted
	{
		[Token(Token = "0x60017F9")]
		[Address(RVA = "0xC038C0", Offset = "0xC038C0", VA = "0xC038C0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60017FA")]
		[Address(RVA = "0xC01838", Offset = "0xC01838", VA = "0xC01838")]
		set
		{
		}
	}

	[Token(Token = "0x170003D9")]
	public bool WasEverCompleted
	{
		[Token(Token = "0x60017FB")]
		[Address(RVA = "0xC01638", Offset = "0xC01638", VA = "0xC01638")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x60017FC")]
	[Address(RVA = "0xC038C8", Offset = "0xC038C8", VA = "0xC038C8")]
	public AssignmentSaveData()
	{
	}

	[Token(Token = "0x60017FD")]
	[Address(RVA = "0xC038D0", Offset = "0xC038D0", VA = "0xC038D0", Slot = "6")]
	public virtual void OnSaveableDeserialization(JSONNode data)
	{
	}

	[Token(Token = "0x60017FE")]
	[Address(RVA = "0xC03958", Offset = "0xC03958", VA = "0xC03958", Slot = "7")]
	public virtual JSONNode OnSaveableSerialization()
	{
		return null;
	}
}
