using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Technology.Core.ServiceOperations
{
	[Token(Token = "0x2000CC5")]
	public sealed class SvcOpGetPlayerScore : SvcOpGetLeaderboard
	{
		[Token(Token = "0x4003DC1")]
		private const string SVCOPNAME = "GetPlayerScore";

		[Token(Token = "0x17000A6C")]
		public override string SvcOpCmd
		{
			[Token(Token = "0x6004F4F")]
			[Address(RVA = "0xD39884", Offset = "0xD39884", VA = "0xD39884", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6004F4E")]
		[Address(RVA = "0xD39874", Offset = "0xD39874", VA = "0xD39874")]
		public SvcOpGetPlayerScore([Optional] Action<IResponseContext> responseFunction)
		{
		}

		[Token(Token = "0x6004F50")]
		[Address(RVA = "0xD398C8", Offset = "0xD398C8", VA = "0xD398C8")]
		public new void Get(LeaderBoardType type, int leaderboardid, string userid)
		{
		}
	}
}
