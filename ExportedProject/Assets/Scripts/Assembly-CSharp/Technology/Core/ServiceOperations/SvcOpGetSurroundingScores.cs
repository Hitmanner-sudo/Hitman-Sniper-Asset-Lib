using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Technology.Core.ServiceOperations
{
	[Token(Token = "0x2000CC8")]
	public sealed class SvcOpGetSurroundingScores : SvcOpGetLeaderboard
	{
		[Token(Token = "0x4003DC4")]
		private const string SVCOPNAME = "GetSurroundingScores";

		[Token(Token = "0x17000A6F")]
		public override string SvcOpCmd
		{
			[Token(Token = "0x6004F58")]
			[Address(RVA = "0xD3A28C", Offset = "0xD3A28C", VA = "0xD3A28C", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6004F57")]
		[Address(RVA = "0xD3A27C", Offset = "0xD3A27C", VA = "0xD3A27C")]
		public SvcOpGetSurroundingScores([Optional] Action<IResponseContext> responseFunction)
		{
		}

		[Token(Token = "0x6004F59")]
		[Address(RVA = "0xD3A2D0", Offset = "0xD3A2D0", VA = "0xD3A2D0")]
		public new void Get(LeaderBoardType type, int leaderboardid, string userid, int range)
		{
		}
	}
}
