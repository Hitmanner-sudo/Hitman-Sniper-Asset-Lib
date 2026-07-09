using System;
using Il2CppDummyDll;

namespace Technology.Distribution
{
	[Token(Token = "0x2000BFF")]
	public class UriBuilder
	{
		[Token(Token = "0x6004BEE")]
		[Address(RVA = "0xBA199C", Offset = "0xBA199C", VA = "0xBA199C")]
		public static Uri CreateSeedDirectory(Uri hierarchicalpart, string seedDirectory)
		{
			return null;
		}

		[Token(Token = "0x6004BEF")]
		[Address(RVA = "0xBA1A38", Offset = "0xBA1A38", VA = "0xBA1A38")]
		public static Uri CreateHierarchicalPart(string scheme, string hostname, string port, string relative)
		{
			return null;
		}

		[Token(Token = "0x6004BF0")]
		[Address(RVA = "0xBA1CFC", Offset = "0xBA1CFC", VA = "0xBA1CFC")]
		public static Uri CreateSeedHierarchicalPart(Uri uri, string filename, string extension = "")
		{
			return null;
		}

		[Token(Token = "0x6004BF1")]
		[Address(RVA = "0xBA1E08", Offset = "0xBA1E08", VA = "0xBA1E08")]
		public static string CreateOutputHierarchicalPart(string seedName)
		{
			return null;
		}

		[Token(Token = "0x6004BF2")]
		[Address(RVA = "0xBA1E90", Offset = "0xBA1E90", VA = "0xBA1E90")]
		public static Uri RemoveLastUriSegment(Uri l_uri, bool removeTrailingSlash = true)
		{
			return null;
		}

		[Token(Token = "0x6004BF3")]
		[Address(RVA = "0xBA2014", Offset = "0xBA2014", VA = "0xBA2014")]
		public UriBuilder()
		{
		}
	}
}
