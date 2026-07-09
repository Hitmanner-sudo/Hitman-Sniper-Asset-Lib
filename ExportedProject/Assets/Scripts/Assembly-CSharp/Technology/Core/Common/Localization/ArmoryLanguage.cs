using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Technology.Core.Common.Localization
{
	[Token(Token = "0x2000E12")]
	public class ArmoryLanguage
	{
		[Token(Token = "0x4004271")]
		[FieldOffset(Offset = "0x10")]
		private readonly Dictionary<string, string> _strings;

		[Token(Token = "0x4004272")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BF5A4", Offset = "0x5BF5A4")]
		private ArmoryLocalization.LanguageCode _003CLanguageCode_003Ek__BackingField;

		[Token(Token = "0x17000B7A")]
		public ArmoryLocalization.LanguageCode LanguageCode
		{
			[Token(Token = "0x600567B")]
			[Address(RVA = "0xD4EFD8", Offset = "0xD4EFD8", VA = "0xD4EFD8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x62B300", Offset = "0x62B300")]
			get
			{
				return default(ArmoryLocalization.LanguageCode);
			}
			[Token(Token = "0x600567C")]
			[Address(RVA = "0xD4EFE0", Offset = "0xD4EFE0", VA = "0xD4EFE0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x62B310", Offset = "0x62B310")]
			private set
			{
			}
		}

		[Token(Token = "0x600567D")]
		[Address(RVA = "0xD4EFE8", Offset = "0xD4EFE8", VA = "0xD4EFE8")]
		public ArmoryLanguage(ArmoryLocalization.LanguageCode languageCode)
		{
		}

		[Token(Token = "0x600567E")]
		[Address(RVA = "0xD4F500", Offset = "0xD4F500", VA = "0xD4F500")]
		public string Get(string key)
		{
			return null;
		}

		[Token(Token = "0x600567F")]
		[Address(RVA = "0xD4F1A8", Offset = "0xD4F1A8", VA = "0xD4F1A8")]
		private void LoadStrings(TextAsset ta)
		{
		}
	}
}
