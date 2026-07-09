using System.Collections.Generic;
using System.Text.RegularExpressions;
using Il2CppDummyDll;
using SimpleJSON;
using Technology.Core.Auth;

namespace Technology.Core.Persistence
{
	[Token(Token = "0x2000D49")]
	public static class Utils
	{
		[Token(Token = "0x4003F57")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Regex REGEX_BASE64;

		[Token(Token = "0x600520C")]
		[Address(RVA = "0x13C3C58", Offset = "0x13C3C58", VA = "0x13C3C58")]
		public static void LoadFromLocal(this FacebookPersonalRecord facebookPersonalRecord)
		{
		}

		[Token(Token = "0x600520D")]
		[Address(RVA = "0x13C3F10", Offset = "0x13C3F10", VA = "0x13C3F10")]
		public static void LoadFromLocal(this GameCenterPersonalRecord gameCenterPersonalRecord)
		{
		}

		[Token(Token = "0x600520E")]
		[Address(RVA = "0x13C4128", Offset = "0x13C4128", VA = "0x13C4128")]
		public static void LoadFromLocal(this PlayGameServicesPersonalRecord playGameServicePersonalRecord)
		{
		}

		[Token(Token = "0x600520F")]
		[Address(RVA = "0x13C4368", Offset = "0x13C4368", VA = "0x13C4368")]
		public static void SaveLocally(this FacebookPersonalRecord facebookPersonalRecord)
		{
		}

		[Token(Token = "0x6005210")]
		[Address(RVA = "0x13C4624", Offset = "0x13C4624", VA = "0x13C4624")]
		public static void ClearFacebookPersonalRecord()
		{
		}

		[Token(Token = "0x6005211")]
		[Address(RVA = "0x13C4880", Offset = "0x13C4880", VA = "0x13C4880")]
		public static void SaveLocally(this GameCenterPersonalRecord gameCenterPersonalRecord)
		{
		}

		[Token(Token = "0x6005212")]
		[Address(RVA = "0x13C4AAC", Offset = "0x13C4AAC", VA = "0x13C4AAC")]
		public static void SaveLocally(this PlayGameServicesPersonalRecord playGameServicePersonalRecord)
		{
		}

		[Token(Token = "0x6005213")]
		public static bool SetCache<T>(this JSONClass rootnode, IPersistableCache<T> cache)
		{
			return default(bool);
		}

		[Token(Token = "0x6005214")]
		[Address(RVA = "0x13C4CD8", Offset = "0x13C4CD8", VA = "0x13C4CD8")]
		public static string Base64Encode(string plainText)
		{
			return null;
		}

		[Token(Token = "0x6005215")]
		[Address(RVA = "0x13C4D68", Offset = "0x13C4D68", VA = "0x13C4D68")]
		public static string Base64Decode(string base64EncodedData)
		{
			return null;
		}

		[Token(Token = "0x6005216")]
		[Address(RVA = "0x13C4E00", Offset = "0x13C4E00", VA = "0x13C4E00")]
		public static bool ContainsBase64String(string encodedString)
		{
			return default(bool);
		}

		[Token(Token = "0x6005217")]
		public static void ConvertToPersistableCache<T>(this Dictionary<string, object> dictionary, IPersistableCache<T> cache)
		{
		}
	}
}
