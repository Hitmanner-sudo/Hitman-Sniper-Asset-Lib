using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Technology.Core.ServiceOperations
{
	[Token(Token = "0x2000CD0")]
	public sealed class SvcOpResetThisWeeksLeaderboardScores : SvcOpGetLeaderboard
	{
		[Token(Token = "0x4003DCF")]
		private const string SVCOPNAME = "ResetThisWeeksLeaderboardScores";

		[Token(Token = "0x17000A77")]
		public override string SvcOpCmd
		{
			[Token(Token = "0x6004F70")]
			[Address(RVA = "0xD3F1AC", Offset = "0xD3F1AC", VA = "0xD3F1AC", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6004F6F")]
		[Address(RVA = "0xD3F19C", Offset = "0xD3F19C", VA = "0xD3F19C")]
		public SvcOpResetThisWeeksLeaderboardScores([Optional] Action<IResponseContext> responseFunction)
		{
		}

		[Token(Token = "0x6004F71")]
		[Address(RVA = "0xD3F1F0", Offset = "0xD3F1F0", VA = "0xD3F1F0")]
		public void Get(int leaderboardId)
		{
		}
	}
}
