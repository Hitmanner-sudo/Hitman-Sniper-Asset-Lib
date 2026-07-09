using System.Collections.Generic;
using Il2CppDummyDll;
using SimpleJSON;
using Technology.Core.Auth;

namespace Technology.Core.Common
{
	[Token(Token = "0x2000DD2")]
	public static class FacebookUtils
	{
		[Token(Token = "0x60054F3")]
		[Address(RVA = "0x94FB88", Offset = "0x94FB88", VA = "0x94FB88")]
		public static void SetFacebookRecord(FacebookPersonalRecord fbFriendRecord, Dictionary<string, object> dictionary)
		{
		}

		[Token(Token = "0x60054F4")]
		[Address(RVA = "0x950A10", Offset = "0x950A10", VA = "0x950A10")]
		public static void SetFacebookRecordPicture(FacebookPersonalRecord fbFriendRecord, byte[] rawData)
		{
		}

		[Token(Token = "0x60054F5")]
		[Address(RVA = "0x950A48", Offset = "0x950A48", VA = "0x950A48")]
		public static byte[] GetFacebookPicture(string facebookId, string urlformat, int timeoutInSeconds, Dictionary<string, string> options)
		{
			return null;
		}

		[Token(Token = "0x60054F6")]
		[Address(RVA = "0x950C1C", Offset = "0x950C1C", VA = "0x950C1C")]
		public static void SetFacebookRecord(FacebookPersonalRecord fbFriendRecord, JSONNode fbjson)
		{
		}

		[Token(Token = "0x60054F7")]
		[Address(RVA = "0x951598", Offset = "0x951598", VA = "0x951598")]
		public static FacebookPersonalRecord GetFacebookProfileInformation(string facebookid, string urlformat, int timeoutInSeconds)
		{
			return null;
		}
	}
}
