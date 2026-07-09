using System;
using System.Collections.Generic;
using System.Text;
using Il2CppDummyDll;

namespace Technology.Core
{
	[Token(Token = "0x2000C6B")]
	public static class URIUtils
	{
		[Token(Token = "0x2000C6C")]
		public static class PlatformFileFormat
		{
			[Token(Token = "0x4003CDB")]
			public const string ANDROID_SCHEMA = "jar:file:///{0}";

			[Token(Token = "0x4003CDC")]
			public const string WINDOWSPLAYER_SCHEMA = "file:///{0}";

			[Token(Token = "0x4003CDD")]
			public const string DEFAULT_SCHEMA = "file://{0}";
		}

		[Token(Token = "0x2000C6D")]
		public static class URIValidator
		{
			[Token(Token = "0x6004D90")]
			[Address(RVA = "0xA3F2B8", Offset = "0xA3F2B8", VA = "0xA3F2B8")]
			public static bool Validate(string uri)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x2000C6E")]
		public static class URIExtractor
		{
			[Token(Token = "0x6004D91")]
			[Address(RVA = "0xA3FA94", Offset = "0xA3FA94", VA = "0xA3FA94")]
			public static int Version(Uri uri)
			{
				return default(int);
			}

			[Token(Token = "0x6004D92")]
			[Address(RVA = "0xA3FC78", Offset = "0xA3FC78", VA = "0xA3FC78")]
			public static int Version(string uri)
			{
				return default(int);
			}
		}

		[Token(Token = "0x2000C6F")]
		public static class URICreator
		{
			[Token(Token = "0x6004D93")]
			[Address(RVA = "0xA3EE50", Offset = "0xA3EE50", VA = "0xA3EE50")]
			public static Uri Create(string url, string path, string queryString)
			{
				return null;
			}

			[Token(Token = "0x6004D94")]
			[Address(RVA = "0xA3F320", Offset = "0xA3F320", VA = "0xA3F320")]
			public static string CreateQueryString(KeyValuePair<string, string>[] parameters)
			{
				return null;
			}

			[Token(Token = "0x6004D95")]
			[Address(RVA = "0xA3F4E4", Offset = "0xA3F4E4", VA = "0xA3F4E4")]
			public static string CreateQueryStringNonEscaped(KeyValuePair<string, string>[] parameters)
			{
				return null;
			}

			[Token(Token = "0x6004D96")]
			[Address(RVA = "0xA3F658", Offset = "0xA3F658", VA = "0xA3F658")]
			public static Uri RemoveLastUriSegment(Uri l_uri, bool removeTrailingSlash = true)
			{
				return null;
			}

			[Token(Token = "0x6004D97")]
			[Address(RVA = "0xA3F7DC", Offset = "0xA3F7DC", VA = "0xA3F7DC")]
			public static string CreateLocalFile(string absolute_uri)
			{
				return null;
			}

			[Token(Token = "0x6004D98")]
			[Address(RVA = "0xA3F998", Offset = "0xA3F998", VA = "0xA3F998")]
			public static string CreateLocalStreamingAssetPath(string relative_uri)
			{
				return null;
			}
		}

		[Token(Token = "0x2000C70")]
		public static class HeadersUtils
		{
			[Token(Token = "0x4003CDE")]
			private const string HEADERENCODE = "OS-UTF8_";

			[Token(Token = "0x4003CDF")]
			[FieldOffset(Offset = "0x0")]
			private static readonly Encoding _iso;

			[Token(Token = "0x4003CE0")]
			[FieldOffset(Offset = "0x8")]
			private static readonly Encoding _utf8;

			[Token(Token = "0x6004D99")]
			[Address(RVA = "0xA3EA90", Offset = "0xA3EA90", VA = "0xA3EA90")]
			public static string GetValidHeader(string header)
			{
				return null;
			}

			[Token(Token = "0x6004D9A")]
			[Address(RVA = "0xA3EB24", Offset = "0xA3EB24", VA = "0xA3EB24")]
			private static bool HeaderRequiresEncoding(string header)
			{
				return default(bool);
			}

			[Token(Token = "0x6004D9B")]
			[Address(RVA = "0xA3EBC4", Offset = "0xA3EBC4", VA = "0xA3EBC4")]
			private static string EncodeHeader(string header)
			{
				return null;
			}

			[Token(Token = "0x6004D9C")]
			[Address(RVA = "0xA3ECC4", Offset = "0xA3ECC4", VA = "0xA3ECC4")]
			public static string DecodeHeader(string value)
			{
				return null;
			}
		}
	}
}
