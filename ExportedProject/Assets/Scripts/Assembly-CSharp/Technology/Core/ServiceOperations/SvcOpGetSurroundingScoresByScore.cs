using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Technology.Core.ServiceOperations
{
	[Token(Token = "0x2000CCB")]
	public sealed class SvcOpGetSurroundingScoresByScore : SvcOpGetLeaderboard
	{
		[Token(Token = "0x4003DC7")]
		private const string SVCOPNAME = "GetSurroundingScoresByScore";

		[Token(Token = "0x17000A72")]
		public override string SvcOpCmd
		{
			[Token(Token = "0x6004F61")]
			[Address(RVA = "0xD3A39C", Offset = "0xD3A39C", VA = "0xD3A39C", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6004F60")]
		[Address(RVA = "0xD3A38C", Offset = "0xD3A38C", VA = "0xD3A38C")]
		public SvcOpGetSurroundingScoresByScore([Optional] Action<IResponseContext> responseFunction)
		{
		}

		[Token(Token = "0x6004F62")]
		[Address(RVA = "0xD3A3E0", Offset = "0xD3A3E0", VA = "0xD3A3E0")]
		public new void Get(LeaderBoardType type, int leaderboardid, long score, int range)
		{
		}
	}
}
