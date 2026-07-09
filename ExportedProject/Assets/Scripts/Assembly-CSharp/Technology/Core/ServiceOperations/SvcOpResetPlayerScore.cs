using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Technology.Core.ServiceOperations
{
	[Token(Token = "0x2000CCF")]
	public sealed class SvcOpResetPlayerScore : SvcOpGet
	{
		[Token(Token = "0x4003DCB")]
		public const string QUERYSTRING_PARAM_TYPES_KEY = "i32_types";

		[Token(Token = "0x4003DCC")]
		public const string QUERYSTRING_PARAM_LID_KEY = "s_lid";

		[Token(Token = "0x4003DCD")]
		public const string QUERYSTRING_PARAM_UID_KEY = "s_uid";

		[Token(Token = "0x4003DCE")]
		private const string SVCOPNAME = "ResetPlayerScore";

		[Token(Token = "0x17000A76")]
		public override string SvcOpCmd
		{
			[Token(Token = "0x6004F6D")]
			[Address(RVA = "0xD3EF78", Offset = "0xD3EF78", VA = "0xD3EF78", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6004F6C")]
		[Address(RVA = "0xD3EF68", Offset = "0xD3EF68", VA = "0xD3EF68")]
		public SvcOpResetPlayerScore([Optional] Action<IResponseContext> responseFunction)
		{
		}

		[Token(Token = "0x6004F6E")]
		[Address(RVA = "0xD3EFBC", Offset = "0xD3EFBC", VA = "0xD3EFBC")]
		public void Get(SvcOpGetLeaderboard.LeaderBoardType type, int leaderboardId, string userid)
		{
		}
	}
}
