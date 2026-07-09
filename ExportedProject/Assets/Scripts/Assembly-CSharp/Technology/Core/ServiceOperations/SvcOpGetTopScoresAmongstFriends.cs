using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Technology.Core.ServiceOperations
{
	[Token(Token = "0x2000CCE")]
	public sealed class SvcOpGetTopScoresAmongstFriends : SvcOpGetLeaderboard
	{
		[Token(Token = "0x4003DCA")]
		private const string SVCOPNAME = "GetTopScoresAmongstFriends";

		[Token(Token = "0x17000A75")]
		public override string SvcOpCmd
		{
			[Token(Token = "0x6004F6A")]
			[Address(RVA = "0xD3A4A4", Offset = "0xD3A4A4", VA = "0xD3A4A4", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6004F69")]
		[Address(RVA = "0xD3A494", Offset = "0xD3A494", VA = "0xD3A494")]
		public SvcOpGetTopScoresAmongstFriends([Optional] Action<IResponseContext> responseFunction)
		{
		}

		[Token(Token = "0x6004F6B")]
		[Address(RVA = "0xD3A4E8", Offset = "0xD3A4E8", VA = "0xD3A4E8")]
		public new void Get(LeaderBoardType type, int leaderboardid, string userid, int start, int range)
		{
		}
	}
}
