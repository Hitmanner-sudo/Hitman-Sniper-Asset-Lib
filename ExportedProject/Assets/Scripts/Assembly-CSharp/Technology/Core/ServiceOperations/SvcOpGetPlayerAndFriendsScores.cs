using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Technology.Core.ServiceOperations
{
	[Token(Token = "0x2000CC4")]
	public sealed class SvcOpGetPlayerAndFriendsScores : SvcOpGetLeaderboard
	{
		[Token(Token = "0x4003DC0")]
		private const string SVCOPNAME = "GetPlayerAndFriendsScores";

		[Token(Token = "0x17000A6B")]
		public override string SvcOpCmd
		{
			[Token(Token = "0x6004F4C")]
			[Address(RVA = "0xD391EC", Offset = "0xD391EC", VA = "0xD391EC", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6004F4B")]
		[Address(RVA = "0xD391DC", Offset = "0xD391DC", VA = "0xD391DC")]
		public SvcOpGetPlayerAndFriendsScores([Optional] Action<IResponseContext> responseFunction)
		{
		}

		[Token(Token = "0x6004F4D")]
		[Address(RVA = "0xD39230", Offset = "0xD39230", VA = "0xD39230")]
		public new void Get(LeaderBoardType type, int leaderboardid, string userid)
		{
		}
	}
}
