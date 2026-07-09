using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Technology.Core.ServiceOperations
{
	[Token(Token = "0x2000CD1")]
	public sealed class SvcOpSetPlayerScore : SvcOpGetLeaderboard
	{
		[Token(Token = "0x4003DD0")]
		private const string SVCOPNAME = "SetPlayerScore";

		[Token(Token = "0x17000A78")]
		public override string SvcOpCmd
		{
			[Token(Token = "0x6004F73")]
			[Address(RVA = "0xB48008", Offset = "0xB48008", VA = "0xB48008", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6004F72")]
		[Address(RVA = "0xB47FF4", Offset = "0xB47FF4", VA = "0xB47FF4")]
		public SvcOpSetPlayerScore([Optional] Action<IResponseContext> responseFunction)
		{
		}

		[Token(Token = "0x6004F74")]
		[Address(RVA = "0xB4804C", Offset = "0xB4804C", VA = "0xB4804C")]
		public void Get(int leaderboardid, string userid, bool notifyFriends, long score)
		{
		}
	}
}
