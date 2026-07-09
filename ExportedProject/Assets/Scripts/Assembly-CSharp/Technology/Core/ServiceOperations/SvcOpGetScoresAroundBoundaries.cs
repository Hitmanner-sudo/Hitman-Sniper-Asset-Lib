using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Technology.Core.ServiceOperations
{
	[Token(Token = "0x2000CC7")]
	public class SvcOpGetScoresAroundBoundaries : SvcOpGetLeaderboard
	{
		[Token(Token = "0x4003DC3")]
		private const string SVCOPNAME = "GetScoresAroundBoundaries";

		[Token(Token = "0x17000A6E")]
		public override string SvcOpCmd
		{
			[Token(Token = "0x6004F54")]
			[Address(RVA = "0xD39C58", Offset = "0xD39C58", VA = "0xD39C58", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6004F55")]
		[Address(RVA = "0xD39C9C", Offset = "0xD39C9C", VA = "0xD39C9C")]
		public SvcOpGetScoresAroundBoundaries([Optional] Action<IResponseContext> responseAction)
		{
		}

		[Token(Token = "0x6004F56")]
		[Address(RVA = "0xD39CAC", Offset = "0xD39CAC", VA = "0xD39CAC")]
		public new void Get(int leaderboardId, int[] boundaries)
		{
		}
	}
}
