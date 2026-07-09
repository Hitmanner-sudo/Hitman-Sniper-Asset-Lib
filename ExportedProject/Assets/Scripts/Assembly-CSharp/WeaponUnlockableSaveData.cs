using System;
using Il2CppDummyDll;
using SimpleJSON;
using Technology;

[Serializable]
[Token(Token = "0x20003B8")]
public class WeaponUnlockableSaveData : UnlockableSaveData
{
	[Serializable]
	[Token(Token = "0x20003B9")]
	public class AttachmentSlot : ISaveable
	{
		[Token(Token = "0x4001530")]
		[FieldOffset(Offset = "0x0")]
		public static readonly int EMPTY_SLOT;

		[Token(Token = "0x4001531")]
		[FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "SaveableAttribute", RVA = "0x5B4DE8", Offset = "0x5B4DE8")]
		public int Attachment;

		[Token(Token = "0x4001532")]
		[FieldOffset(Offset = "0x14")]
		public bool IsCustomizable;

		[Token(Token = "0x6001739")]
		[Address(RVA = "0xA43264", Offset = "0xA43264", VA = "0xA43264", Slot = "4")]
		public void OnSaveableDeserialization(JSONNode data)
		{
		}

		[Token(Token = "0x600173A")]
		[Address(RVA = "0xA43304", Offset = "0xA43304", VA = "0xA43304", Slot = "5")]
		public JSONNode OnSaveableSerialization()
		{
			return null;
		}

		[Token(Token = "0x600173B")]
		[Address(RVA = "0xA4337C", Offset = "0xA4337C", VA = "0xA4337C")]
		public AttachmentSlot()
		{
		}
	}

	[Token(Token = "0x20003BA")]
	public enum CompletionState
	{
		[Token(Token = "0x4001534")]
		PARTS_MISSING = 0,
		[Token(Token = "0x4001535")]
		PARTS_COMPLETED = 1,
		[Token(Token = "0x4001536")]
		ASSEMBLED = 2
	}

	[NonSerialized]
	[Token(Token = "0x4001529")]
	[FieldOffset(Offset = "0x24")]
	[AttributeAttribute(Name = "SaveableAttribute", RVA = "0x5B4D78", Offset = "0x5B4D78")]
	public int XP;

	[NonSerialized]
	[Token(Token = "0x400152A")]
	[FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "SaveableAttribute", RVA = "0x5B4D88", Offset = "0x5B4D88")]
	public int CompletedInt;

	[NonSerialized]
	[Token(Token = "0x400152B")]
	[FieldOffset(Offset = "0x2C")]
	[AttributeAttribute(Name = "SaveableAttribute", RVA = "0x5B4D98", Offset = "0x5B4D98")]
	public int LastSeenModSlots;

	[NonSerialized]
	[Token(Token = "0x400152C")]
	[FieldOffset(Offset = "0x30")]
	[AttributeAttribute(Name = "SaveableAttribute", RVA = "0x5B4DA8", Offset = "0x5B4DA8")]
	public int LastSeenPowerUpSlots;

	[NonSerialized]
	[Token(Token = "0x400152D")]
	[FieldOffset(Offset = "0x38")]
	[AttributeAttribute(Name = "SaveableAttribute", RVA = "0x5B4DB8", Offset = "0x5B4DB8")]
	public AttachmentSlot[] Mods;

	[NonSerialized]
	[Token(Token = "0x400152E")]
	[FieldOffset(Offset = "0x40")]
	[AttributeAttribute(Name = "SaveableAttribute", RVA = "0x5B4DC8", Offset = "0x5B4DC8")]
	public AttachmentSlot[] PowerUps;

	[NonSerialized]
	[Token(Token = "0x400152F")]
	[FieldOffset(Offset = "0x48")]
	[AttributeAttribute(Name = "SaveableAttribute", RVA = "0x5B4DD8", Offset = "0x5B4DD8")]
	public int MasteryLevel;

	[Token(Token = "0x170003B9")]
	public CompletionState Completed
	{
		[Token(Token = "0x6001730")]
		[Address(RVA = "0x87D64C", Offset = "0x87D64C", VA = "0x87D64C")]
		get
		{
			return default(CompletionState);
		}
		[Token(Token = "0x6001731")]
		[Address(RVA = "0x87D654", Offset = "0x87D654", VA = "0x87D654")]
		set
		{
		}
	}

	[Token(Token = "0x170003BA")]
	public bool IsCompleted
	{
		[Token(Token = "0x6001735")]
		[Address(RVA = "0x87D65C", Offset = "0x87D65C", VA = "0x87D65C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170003BB")]
	public bool IsAssembled
	{
		[Token(Token = "0x6001736")]
		[Address(RVA = "0x87D6C4", Offset = "0x87D6C4", VA = "0x87D6C4")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170003BC")]
	public bool IsNewlyCompleted
	{
		[Token(Token = "0x6001737")]
		[Address(RVA = "0x87D6D4", Offset = "0x87D6D4", VA = "0x87D6D4")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x600172D")]
	[Address(RVA = "0x87D278", Offset = "0x87D278", VA = "0x87D278", Slot = "10")]
	public override JSONNode OnSaveableSerialization()
	{
		return null;
	}

	[Token(Token = "0x600172E")]
	[Address(RVA = "0x87D35C", Offset = "0x87D35C", VA = "0x87D35C", Slot = "9")]
	public override void OnSaveableDeserialization(JSONNode data)
	{
	}

	[Token(Token = "0x600172F")]
	[Address(RVA = "0x87D464", Offset = "0x87D464", VA = "0x87D464")]
	private void TryDeserializeOldFields(AttachmentSlot[] attachments, JSONNode data)
	{
	}

	[Token(Token = "0x6001732")]
	[Address(RVA = "0x87A7A4", Offset = "0x87A7A4", VA = "0x87A7A4")]
	public void Complete(bool showNewFeedback)
	{
	}

	[Token(Token = "0x6001733")]
	[Address(RVA = "0x87A834", Offset = "0x87A834", VA = "0x87A834")]
	public void Assemble(bool showNewFeedback)
	{
	}

	[Token(Token = "0x6001734")]
	[Address(RVA = "0x87D670", Offset = "0x87D670", VA = "0x87D670", Slot = "8")]
	public override bool HasNewFeedback()
	{
		return default(bool);
	}

	[Token(Token = "0x6001738")]
	[Address(RVA = "0x87D6E0", Offset = "0x87D6E0", VA = "0x87D6E0")]
	public WeaponUnlockableSaveData()
	{
	}
}
