using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Technology.Core.Common.Localization
{
	[Token(Token = "0x2000E14")]
	public static class ArmoryLocalization
	{
		[Token(Token = "0x2000E15")]
		public class LanguageChangedEventArgs : EventArgs
		{
			[Token(Token = "0x4004279")]
			[FieldOffset(Offset = "0x10")]
			public LanguageCode PreviousLanguage;

			[Token(Token = "0x400427A")]
			[FieldOffset(Offset = "0x14")]
			public LanguageCode NewLanguage;

			[Token(Token = "0x600568A")]
			[Address(RVA = "0x9230A8", Offset = "0x9230A8", VA = "0x9230A8")]
			public LanguageChangedEventArgs()
			{
			}
		}

		[Token(Token = "0x2000E16")]
		public enum LanguageCode
		{
			[Token(Token = "0x400427C")]
			N = 0,
			[Token(Token = "0x400427D")]
			AF = 1,
			[Token(Token = "0x400427E")]
			AR = 2,
			[Token(Token = "0x400427F")]
			BA = 3,
			[Token(Token = "0x4004280")]
			BE = 4,
			[Token(Token = "0x4004281")]
			BG = 5,
			[Token(Token = "0x4004282")]
			CA = 6,
			[Token(Token = "0x4004283")]
			ZH = 7,
			[Token(Token = "0x4004284")]
			CS = 8,
			[Token(Token = "0x4004285")]
			DA = 9,
			[Token(Token = "0x4004286")]
			NL = 10,
			[Token(Token = "0x4004287")]
			EN = 11,
			[Token(Token = "0x4004288")]
			ET = 12,
			[Token(Token = "0x4004289")]
			FA = 13,
			[Token(Token = "0x400428A")]
			FI = 14,
			[Token(Token = "0x400428B")]
			FR = 15,
			[Token(Token = "0x400428C")]
			DE = 16,
			[Token(Token = "0x400428D")]
			EL = 17,
			[Token(Token = "0x400428E")]
			HE = 18,
			[Token(Token = "0x400428F")]
			HU = 19,
			[Token(Token = "0x4004290")]
			IS = 20,
			[Token(Token = "0x4004291")]
			ID = 21,
			[Token(Token = "0x4004292")]
			IT = 22,
			[Token(Token = "0x4004293")]
			JA = 23,
			[Token(Token = "0x4004294")]
			KO = 24,
			[Token(Token = "0x4004295")]
			LA = 25,
			[Token(Token = "0x4004296")]
			LT = 26,
			[Token(Token = "0x4004297")]
			NO = 27,
			[Token(Token = "0x4004298")]
			PL = 28,
			[Token(Token = "0x4004299")]
			PT = 29,
			[Token(Token = "0x400429A")]
			RO = 30,
			[Token(Token = "0x400429B")]
			RU = 31,
			[Token(Token = "0x400429C")]
			SH = 32,
			[Token(Token = "0x400429D")]
			SK = 33,
			[Token(Token = "0x400429E")]
			SL = 34,
			[Token(Token = "0x400429F")]
			ES = 35,
			[Token(Token = "0x40042A0")]
			SW = 36,
			[Token(Token = "0x40042A1")]
			TH = 37,
			[Token(Token = "0x40042A2")]
			TR = 38,
			[Token(Token = "0x40042A3")]
			UK = 39,
			[Token(Token = "0x40042A4")]
			VI = 40,
			[Token(Token = "0x40042A5")]
			ZH_HANS = 41,
			[Token(Token = "0x40042A6")]
			ZH_HANT = 42
		}

		[Token(Token = "0x4004274")]
		[FieldOffset(Offset = "0x8")]
		private static ArmoryLanguage _language;

		[Token(Token = "0x4004275")]
		[FieldOffset(Offset = "0x10")]
		private static readonly ArmoryLocalizationConfiguration _configuration;

		[Token(Token = "0x4004276")]
		[FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BF5C4", Offset = "0x5BF5C4")]
		private static LanguageCode[] _003CAvailableLanguages_003Ek__BackingField;

		[Token(Token = "0x4004277")]
		public const int SIMPLIFIED_CHINESE_LCID = 4;

		[Token(Token = "0x4004278")]
		public const int TRADITIONAL_CHINESE_LCID = 31748;

		[Token(Token = "0x17000B7B")]
		public static LanguageCode[] AvailableLanguages
		{
			[Token(Token = "0x6005683")]
			[Address(RVA = "0xD4F784", Offset = "0xD4F784", VA = "0xD4F784")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62B350", Offset = "0x62B350")]
			get
			{
				return null;
			}
			[Token(Token = "0x6005684")]
			[Address(RVA = "0xD4F7E8", Offset = "0xD4F7E8", VA = "0xD4F7E8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62B360", Offset = "0x62B360")]
			private set
			{
			}
		}

		[Token(Token = "0x17000B7C")]
		public static LanguageCode CurrentLanguage
		{
			[Token(Token = "0x6005685")]
			[Address(RVA = "0xD4F850", Offset = "0xD4F850", VA = "0xD4F850")]
			get
			{
				return default(LanguageCode);
			}
		}

		[Token(Token = "0x14000171")]
		public static event EventHandler<LanguageChangedEventArgs> OnLanguageChanged
		{
			[Token(Token = "0x6005681")]
			[Address(RVA = "0xD4F59C", Offset = "0xD4F59C", VA = "0xD4F59C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62B330", Offset = "0x62B330")]
			add
			{
			}
			[Token(Token = "0x6005682")]
			[Address(RVA = "0xD4F690", Offset = "0xD4F690", VA = "0xD4F690")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x62B340", Offset = "0x62B340")]
			remove
			{
			}
		}

		[Token(Token = "0x6005686")]
		[Address(RVA = "0xD4F8C0", Offset = "0xD4F8C0", VA = "0xD4F8C0")]
		public static LanguageCode SystemLanguageToCode(SystemLanguage language)
		{
			return default(LanguageCode);
		}

		[Token(Token = "0x6005687")]
		[Address(RVA = "0xD4F8D8", Offset = "0xD4F8D8", VA = "0xD4F8D8")]
		static ArmoryLocalization()
		{
		}

		[Token(Token = "0x6005688")]
		[Address(RVA = "0xD4FE50", Offset = "0xD4FE50", VA = "0xD4FE50")]
		public static void ChangeLanguage(LanguageCode languageCode)
		{
		}

		[Token(Token = "0x6005689")]
		[Address(RVA = "0xD50144", Offset = "0xD50144", VA = "0xD50144")]
		public static string GetString(string key)
		{
			return null;
		}
	}
}
