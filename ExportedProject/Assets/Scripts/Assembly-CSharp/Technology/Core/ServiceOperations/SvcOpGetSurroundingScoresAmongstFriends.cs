using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Technology.Core.ServiceOperations
{
	[Token(Token = "0x2000CCA")]
	public sealed class SvcOpGetSurroundingScoresAmongstFriends : SvcOpGetLeaderboard
	{
		[Token(Token = "0x4003DC6")]
		private const string SVCOPNAME = "GetSurroundingScoresAmongstFriends";

		[Token(Token = "0x17000A71")]
		public override string SvcOpCmd
		{
			[Token(Token = "0x6004F5E")]
			[Address(RVA = "0xD3A314", Offset = "0xD3A314", VA = "0xD3A314", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6004F5D")]
		[Address(RVA = "0xD3A304", Offset = "0xD3A304", VA = "0xD3A304")]
		public SvcOpGetSurroundingScoresAmongstFriends([Optional] Action<IResponseContext> responseFunction)
		{
		}

		[Token(Token = "0x6004F5F")]
		[Address(RVA = "0xD3A358", Offset = "0xD3A358", VA = "0xD3A358")]
		public new void Get(LeaderBoardType type, int leaderboardid, string userid, int range)
		{
		}
	}
}
