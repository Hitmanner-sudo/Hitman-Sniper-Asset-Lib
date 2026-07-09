using Il2CppDummyDll;
using UnityEngine;

namespace Technology.Core.Common.Localization
{
	[Token(Token = "0x2000E17")]
	public class ArmoryLocalizationConfiguration : ScriptableObject
	{
		[Token(Token = "0x40042A7")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private bool _useSystemLanguage;

		[Token(Token = "0x40042A8")]
		[FieldOffset(Offset = "0x1C")]
		public ArmoryLocalization.LanguageCode DefaultLanguageCode;

		[Token(Token = "0x40042A9")]
		[FieldOffset(Offset = "0x20")]
		public ArmoryLocalization.LanguageCode[] AvailableLanguages;

		[Token(Token = "0x17000B7D")]
		public bool UseSystemLanguage
		{
			[Token(Token = "0x600568B")]
			[Address(RVA = "0xD501B8", Offset = "0xD501B8", VA = "0xD501B8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600568C")]
		[Address(RVA = "0xD501C0", Offset = "0xD501C0", VA = "0xD501C0")]
		public ArmoryLocalizationConfiguration()
		{
		}
	}
}
