using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using SimpleJSON;
using Technology;
using UnityEngine;

[Token(Token = "0x2000809")]
public static class DDNAWeaponSuggestionHandler
{
	[Serializable]
	[Token(Token = "0x200080A")]
	public struct MissionSuggestionMapping : ISaveable
	{
		[Serializable]
		[Token(Token = "0x200080B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5965FC", Offset = "0x5965FC")]
		private sealed class _003C_003Ec
		{
			[Token(Token = "0x4002CD4")]
			[FieldOffset(Offset = "0x0")]
			public static readonly _003C_003Ec _003C_003E9;

			[Token(Token = "0x6003464")]
			[Address(RVA = "0xA45624", Offset = "0xA45624", VA = "0xA45624")]
			public _003C_003Ec()
			{
			}
		}

		[Token(Token = "0x4002CD0")]
		[FieldOffset(Offset = "0x0")]
		private static readonly string MISSION_ID_FIELD_NAME;

		[Token(Token = "0x4002CD1")]
		[FieldOffset(Offset = "0x8")]
		private static readonly string SUGGESTIONS_FIELD_NAME;

		[Token(Token = "0x4002CD2")]
		[FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5BB2A4", Offset = "0x5BB2A4")]
		[SerializeField]
		[AttributeAttribute(Name = "SaveableAttribute", RVA = "0x5BB2A4", Offset = "0x5BB2A4")]
		private int _missionId;

		[Token(Token = "0x4002CD3")]
		[FieldOffset(Offset = "0x8")]
		[SerializeField]
		[AttributeAttribute(Name = "SaveableAttribute", RVA = "0x5BB2F8", Offset = "0x5BB2F8")]
		private MissionData.WeaponSuggestionData _suggestions;

		[Token(Token = "0x170006B5")]
		public int MissionIdx
		{
			[Token(Token = "0x600345E")]
			[Address(RVA = "0x86967C", Offset = "0x86967C", VA = "0x86967C")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170006B6")]
		public MissionData.WeaponSuggestionData Suggestions
		{
			[Token(Token = "0x600345F")]
			[Address(RVA = "0x869688", Offset = "0x869688", VA = "0x869688")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6003460")]
		[Address(RVA = "0x869690", Offset = "0x869690", VA = "0x869690", Slot = "4")]
		public void OnSaveableDeserialization(JSONNode data)
		{
		}

		[Token(Token = "0x6003461")]
		[Address(RVA = "0x8697F8", Offset = "0x8697F8", VA = "0x8697F8", Slot = "5")]
		public JSONNode OnSaveableSerialization()
		{
			return null;
		}
	}

	[Token(Token = "0x4002CCF")]
	private const string WEAPON_SUGGESTION_PARAMETER = "weaponSuggestionsParams";

	[Token(Token = "0x600345C")]
	[Address(RVA = "0xBC8444", Offset = "0xBC8444", VA = "0xBC8444")]
	public static bool Handle(Dictionary<string, object> parameters, long transactionId)
	{
		return default(bool);
	}

	[Token(Token = "0x600345D")]
	[Address(RVA = "0xBD58DC", Offset = "0xBD58DC", VA = "0xBD58DC")]
	private static void Fail(string message, long transactionId)
	{
	}
}
