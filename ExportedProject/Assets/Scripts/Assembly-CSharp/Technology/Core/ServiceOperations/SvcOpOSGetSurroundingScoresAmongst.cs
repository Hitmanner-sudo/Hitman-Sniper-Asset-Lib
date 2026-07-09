using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Technology.Core.ServiceOperations
{
	[Token(Token = "0x2000CC9")]
	public sealed class SvcOpOSGetSurroundingScoresAmongst : SvcOpGetLeaderboard
	{
		[Token(Token = "0x4003DC5")]
		private const string SVCOPNAME = "GetSurroundingScoresAmongst";

		[Token(Token = "0x17000A70")]
		public override string SvcOpCmd
		{
			[Token(Token = "0x6004F5B")]
			[Address(RVA = "0xD3CD64", Offset = "0xD3CD64", VA = "0xD3CD64", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6004F5A")]
		[Address(RVA = "0xD3CD54", Offset = "0xD3CD54", VA = "0xD3CD54")]
		public SvcOpOSGetSurroundingScoresAmongst([Optional] Action<IResponseContext> responseFunction)
		{
		}

		[Token(Token = "0x6004F5C")]
		[Address(RVA = "0xD3CDA8", Offset = "0xD3CDA8", VA = "0xD3CDA8")]
		public new void Get(LeaderBoardType type, int leaderboardid, string userid, string[] playerIdPool, int range)
		{
		}
	}
}
