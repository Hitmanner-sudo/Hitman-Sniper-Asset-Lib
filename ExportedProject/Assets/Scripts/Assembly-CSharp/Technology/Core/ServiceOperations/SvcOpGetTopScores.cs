using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Technology.Core.ServiceOperations
{
	[Token(Token = "0x2000CCC")]
	public sealed class SvcOpGetTopScores : SvcOpGetLeaderboard
	{
		[Token(Token = "0x4003DC8")]
		private const string SVCOPNAME = "GetTopScores";

		[Token(Token = "0x17000A73")]
		public override string SvcOpCmd
		{
			[Token(Token = "0x6004F64")]
			[Address(RVA = "0xD3A3F4", Offset = "0xD3A3F4", VA = "0xD3A3F4", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6004F63")]
		[Address(RVA = "0xD3A3E4", Offset = "0xD3A3E4", VA = "0xD3A3E4")]
		public SvcOpGetTopScores([Optional] Action<IResponseContext> responseFunction)
		{
		}

		[Token(Token = "0x6004F65")]
		[Address(RVA = "0xD3A438", Offset = "0xD3A438", VA = "0xD3A438")]
		public new void Get(LeaderBoardType type, int leaderboardid, int startPosition, int range)
		{
		}
	}
}
