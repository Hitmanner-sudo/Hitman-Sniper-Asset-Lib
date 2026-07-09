using System;
using Il2CppDummyDll;
using SimpleJSON;
using Technology;

[Serializable]
[Token(Token = "0x2000405")]
public class MissionSaveData : ISaveable
{
	[Serializable]
	[Token(Token = "0x2000406")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x593AB4", Offset = "0x593AB4")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x400167B")]
		[FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x6001891")]
		[Address(RVA = "0x8C7FA4", Offset = "0x8C7FA4", VA = "0x8C7FA4")]
		public _003C_003Ec()
		{
		}
	}

	[Token(Token = "0x4001672")]
	public const int INVALID_ROGUE_INDEX = -1;

	[Token(Token = "0x4001673")]
	[FieldOffset(Offset = "0x0")]
	private static readonly string IS_COMPLETED_FIELD_NAME;

	[Token(Token = "0x4001674")]
	[FieldOffset(Offset = "0x8")]
	private static readonly string PRIMARY_ASSIGNMENT_SAVE_DATA_FIELD_NAME;

	[Token(Token = "0x4001675")]
	[FieldOffset(Offset = "0x10")]
	private static readonly string RANDOM_ROGUE_INDEX_FIELD_NAME;

	[Token(Token = "0x4001676")]
	[FieldOffset(Offset = "0x18")]
	private static readonly string WEAPON_SUGGESTION_FIELD_NAME;

	[NonSerialized]
	[Token(Token = "0x4001677")]
	[FieldOffset(Offset = "0x10")]
	[AttributeAttribute(Name = "SaveableAttribute", RVA = "0x5B5720", Offset = "0x5B5720")]
	public AssignmentSaveData PrimaryAssignmentSaveData;

	[NonSerialized]
	[Token(Token = "0x4001678")]
	[FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "SaveableAttribute", RVA = "0x5B5730", Offset = "0x5B5730")]
	public int AttemptCount;

	[NonSerialized]
	[Token(Token = "0x4001679")]
	[FieldOffset(Offset = "0x1C")]
	[AttributeAttribute(Name = "SaveableAttribute", RVA = "0x5B5740", Offset = "0x5B5740")]
	public int RandomRogueIndex;

	[NonSerialized]
	[Token(Token = "0x400167A")]
	[FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "SaveableAttribute", RVA = "0x5B5750", Offset = "0x5B5750")]
	public MissionData.WeaponSuggestionData WeaponSuggestion;

	[Token(Token = "0x600188B")]
	[Address(RVA = "0xA1C418", Offset = "0xA1C418", VA = "0xA1C418")]
	public static bool IsCompleted(JSONNode data)
	{
		return default(bool);
	}

	[Token(Token = "0x600188C")]
	[Address(RVA = "0xA1C518", Offset = "0xA1C518", VA = "0xA1C518", Slot = "4")]
	public void OnSaveableDeserialization(JSONNode data)
	{
	}

	[Token(Token = "0x600188D")]
	[Address(RVA = "0xA1C5A0", Offset = "0xA1C5A0", VA = "0xA1C5A0", Slot = "5")]
	public JSONNode OnSaveableSerialization()
	{
		return null;
	}

	[Token(Token = "0x600188E")]
	[Address(RVA = "0xA1C800", Offset = "0xA1C800", VA = "0xA1C800")]
	public MissionSaveData()
	{
	}
}
