using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Technology.Core.ServiceOperations;

[Token(Token = "0x20005EA")]
public class SniperLeaderboardReporter
{
	[Token(Token = "0x20005EB")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5954CC", Offset = "0x5954CC")]
	private sealed class _003C_003Ec__DisplayClass0_0
	{
		[Token(Token = "0x400201F")]
		[FieldOffset(Offset = "0x10")]
		public SvcOpSetPlayerScore svcOp;

		[Token(Token = "0x4002020")]
		[FieldOffset(Offset = "0x18")]
		public int leaderboardId;

		[Token(Token = "0x4002021")]
		[FieldOffset(Offset = "0x1C")]
		public bool notifyFriends;

		[Token(Token = "0x4002022")]
		[FieldOffset(Offset = "0x20")]
		public long score;

		[Token(Token = "0x4002023")]
		[FieldOffset(Offset = "0x28")]
		public Action<bool> onDone;

		[Token(Token = "0x600261C")]
		[Address(RVA = "0xA49EAC", Offset = "0xA49EAC", VA = "0xA49EAC")]
		public _003C_003Ec__DisplayClass0_0()
		{
		}

		[Token(Token = "0x600261D")]
		[Address(RVA = "0xA49EB4", Offset = "0xA49EB4", VA = "0xA49EB4")]
		internal void _003CReportScore_003Eb__0()
		{
		}

		[Token(Token = "0x600261E")]
		[Address(RVA = "0xA49F24", Offset = "0xA49F24", VA = "0xA49F24")]
		internal void _003CReportScore_003Eb__1(IResponseContext context, IRequestContext requestContext, OSRequestState state, Dictionary<string, object> arg4)
		{
		}
	}

	[Token(Token = "0x600261A")]
	[Address(RVA = "0xA60BC8", Offset = "0xA60BC8", VA = "0xA60BC8")]
	public OnlineServiceError ReportScore(int leaderboardId, long score, bool notifyFriends, Action<bool> onDone)
	{
		return default(OnlineServiceError);
	}

	[Token(Token = "0x600261B")]
	[Address(RVA = "0xA608F4", Offset = "0xA608F4", VA = "0xA608F4")]
	public SniperLeaderboardReporter()
	{
	}
}
