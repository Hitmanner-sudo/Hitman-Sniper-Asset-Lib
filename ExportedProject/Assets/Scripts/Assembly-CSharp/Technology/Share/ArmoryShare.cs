using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Technology.Share
{
	[Token(Token = "0x2000B96")]
	public static class ArmoryShare
	{
		[Token(Token = "0x60049A2")]
		[Address(RVA = "0xD4D96C", Offset = "0xD4D96C", VA = "0xD4D96C")]
		public static TextShareAction CreateTextShareAction(string text)
		{
			return null;
		}

		[Token(Token = "0x60049A3")]
		[Address(RVA = "0xD518E0", Offset = "0xD518E0", VA = "0xD518E0")]
		public static UriShareAction CreateUriShareAction(string uri)
		{
			return null;
		}

		[Token(Token = "0x60049A4")]
		[Address(RVA = "0xD51940", Offset = "0xD51940", VA = "0xD51940")]
		public static UriShareAction CreateUriShareAction(Uri uri)
		{
			return null;
		}

		[Token(Token = "0x60049A5")]
		[Address(RVA = "0xD519A0", Offset = "0xD519A0", VA = "0xD519A0")]
		public static ImageShareAction CreateImageShareAction(Texture2D image)
		{
			return null;
		}
	}
}
