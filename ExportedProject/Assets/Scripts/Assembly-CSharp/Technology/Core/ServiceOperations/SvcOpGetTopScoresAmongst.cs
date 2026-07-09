using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Technology.Core.ServiceOperations
{
	[Token(Token = "0x2000CCD")]
	public sealed class SvcOpGetTopScoresAmongst : SvcOpGetLeaderboard
	{
		[Token(Token = "0x4003DC9")]
		private const string SVCOPNAME = "GetTopScoresAmongst";

		[Token(Token = "0x17000A74")]
		public override string SvcOpCmd
		{
			[Token(Token = "0x6004F67")]
			[Address(RVA = "0xD3A44C", Offset = "0xD3A44C", VA = "0xD3A44C", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6004F66")]
		[Address(RVA = "0xD3A43C", Offset = "0xD3A43C", VA = "0xD3A43C")]
		public SvcOpGetTopScoresAmongst([Optional] Action<IResponseContext> responseFunction)
		{
		}

		[Token(Token = "0x6004F68")]
		[Address(RVA = "0xD3A490", Offset = "0xD3A490", VA = "0xD3A490")]
		public new void Get(LeaderBoardType type, int leaderboardid, int startPosition, int range, string[] playerIdPool)
		{
		}
	}
}
