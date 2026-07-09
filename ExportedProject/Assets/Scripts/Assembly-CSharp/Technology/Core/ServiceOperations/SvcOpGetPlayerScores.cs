using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Technology.Core.ServiceOperations
{
	[Token(Token = "0x2000CC6")]
	public sealed class SvcOpGetPlayerScores : SvcOpGetLeaderboard
	{
		[Token(Token = "0x4003DC2")]
		private const string SVCOPNAME = "GetPlayerScores";

		[Token(Token = "0x17000A6D")]
		public override string SvcOpCmd
		{
			[Token(Token = "0x6004F52")]
			[Address(RVA = "0xD39910", Offset = "0xD39910", VA = "0xD39910", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6004F51")]
		[Address(RVA = "0xD39900", Offset = "0xD39900", VA = "0xD39900")]
		public SvcOpGetPlayerScores([Optional] Action<IResponseContext> responseFunction)
		{
		}

		[Token(Token = "0x6004F53")]
		[Address(RVA = "0xD39954", Offset = "0xD39954", VA = "0xD39954")]
		public new void Get(LeaderBoardType type, int leaderboardid, string[] poolOfUids)
		{
		}
	}
}
