using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using SimpleJSON;
using Technology.Core.Common;
using Technology.Social;
using UnityEngine.SocialPlatforms;

[Token(Token = "0x20005E4")]
public class SniperLeaderboardRecordBuilder : IDisposable
{
	[Token(Token = "0x20005E5")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x59547C", Offset = "0x59547C")]
	private sealed class _003C_003Ec__DisplayClass5_0
	{
		[Token(Token = "0x4002015")]
		[FieldOffset(Offset = "0x10")]
		public SniperLeaderboardRecordBuilder _003C_003E4__this;

		[Token(Token = "0x4002016")]
		[FieldOffset(Offset = "0x18")]
		public LeaderboardRecord record;

		[Token(Token = "0x600260C")]
		[Address(RVA = "0xA498B4", Offset = "0xA498B4", VA = "0xA498B4")]
		public _003C_003Ec__DisplayClass5_0()
		{
		}

		[Token(Token = "0x600260D")]
		[Address(RVA = "0xA498BC", Offset = "0xA498BC", VA = "0xA498BC")]
		internal void _003CAskUser_003Eb__0(object s, SharedProfile.SharedProfileEvent e)
		{
		}
	}

	[Token(Token = "0x20005E6")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x59548C", Offset = "0x59548C")]
	private sealed class _003C_003Ec__DisplayClass13_0
	{
		[Token(Token = "0x4002017")]
		[FieldOffset(Offset = "0x10")]
		public List<LeaderboardRecord> records;

		[Token(Token = "0x4002018")]
		[FieldOffset(Offset = "0x18")]
		public SniperLeaderboardRecordBuilder _003C_003E4__this;

		[Token(Token = "0x600260E")]
		[Address(RVA = "0xA496EC", Offset = "0xA496EC", VA = "0xA496EC")]
		public _003C_003Ec__DisplayClass13_0()
		{
		}

		[Token(Token = "0x600260F")]
		[Address(RVA = "0xA496F4", Offset = "0xA496F4", VA = "0xA496F4")]
		internal void _003CFetchFacebookInfo_003Eb__0(object _003Cp0_003E)
		{
		}
	}

	[Token(Token = "0x20005E7")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x59549C", Offset = "0x59549C")]
	private sealed class _003C_003Ec__DisplayClass14_0
	{
		[Token(Token = "0x4002019")]
		[FieldOffset(Offset = "0x10")]
		public List<LeaderboardRecord> records;

		[Token(Token = "0x6002610")]
		[Address(RVA = "0xA497B0", Offset = "0xA497B0", VA = "0xA497B0")]
		public _003C_003Ec__DisplayClass14_0()
		{
		}

		[Token(Token = "0x6002611")]
		[Address(RVA = "0xA497B8", Offset = "0xA497B8", VA = "0xA497B8")]
		internal void _003CFetchFirstPartySocialInfo_003Eb__0(IUserProfile[] a)
		{
		}
	}

	[Token(Token = "0x20005E8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5954AC", Offset = "0x5954AC")]
	private sealed class _003C_003Ec__DisplayClass16_0
	{
		[Token(Token = "0x400201A")]
		[FieldOffset(Offset = "0x10")]
		public IUserProfile profile;

		[Token(Token = "0x6002612")]
		[Address(RVA = "0xA497CC", Offset = "0xA497CC", VA = "0xA497CC")]
		public _003C_003Ec__DisplayClass16_0()
		{
		}

		[Token(Token = "0x6002613")]
		[Address(RVA = "0xA497D4", Offset = "0xA497D4", VA = "0xA497D4")]
		internal bool _003CProcessPlayerInfo_003Eb__0(LeaderboardRecord r)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x20005E9")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5954BC", Offset = "0x5954BC")]
	private sealed class _003CPollImageLoaded_003Ed__17 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400201B")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400201C")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400201D")]
		[FieldOffset(Offset = "0x20")]
		public IUserProfile profile;

		[Token(Token = "0x400201E")]
		[FieldOffset(Offset = "0x28")]
		public IEnumerable<LeaderboardRecord> records;

		[Token(Token = "0x17000524")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6002617")]
			[Address(RVA = "0xA49E5C", Offset = "0xA49E5C", VA = "0xA49E5C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000525")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6002619")]
			[Address(RVA = "0xA49EA4", Offset = "0xA49EA4", VA = "0xA49EA4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6002614")]
		[Address(RVA = "0xA4992C", Offset = "0xA4992C", VA = "0xA4992C")]
		[DebuggerHidden]
		public _003CPollImageLoaded_003Ed__17(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6002615")]
		[Address(RVA = "0xA49958", Offset = "0xA49958", VA = "0xA49958", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6002616")]
		[Address(RVA = "0xA4995C", Offset = "0xA4995C", VA = "0xA4995C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6002618")]
		[Address(RVA = "0xA49E64", Offset = "0xA49E64", VA = "0xA49E64", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x4002013")]
	[FieldOffset(Offset = "0x10")]
	private Dictionary<string, string> _profileRequestOptions;

	[Token(Token = "0x4002014")]
	[FieldOffset(Offset = "0x18")]
	private bool _disposed;

	[Token(Token = "0x60025F8")]
	[Address(RVA = "0xA61F78", Offset = "0xA61F78", VA = "0xA61F78")]
	public SniperLeaderboardRecordBuilder()
	{
	}

	[Token(Token = "0x60025F9")]
	[Address(RVA = "0xA62120", Offset = "0xA62120", VA = "0xA62120")]
	public LeaderboardRecord BuildLocal(Dictionary<string, object> metaDictionary, string metaLeaderboardKey)
	{
		return null;
	}

	[Token(Token = "0x60025FA")]
	[Address(RVA = "0xA626B0", Offset = "0xA626B0", VA = "0xA626B0")]
	public LeaderboardRecord BuildFromJSON(JSONNode node)
	{
		return null;
	}

	[Token(Token = "0x60025FB")]
	[Address(RVA = "0xA62594", Offset = "0xA62594", VA = "0xA62594")]
	public void AskUser(LeaderboardRecord record)
	{
	}

	[Token(Token = "0x60025FC")]
	[Address(RVA = "0xA629C8", Offset = "0xA629C8", VA = "0xA629C8")]
	public void HandleSharedProfileResponse(Dictionary<string, object> data, LeaderboardRecord record)
	{
	}

	[Token(Token = "0x60025FD")]
	[Address(RVA = "0xA62A14", Offset = "0xA62A14", VA = "0xA62A14")]
	private static void SetPlayerDisplayName(Dictionary<string, object> data, LeaderboardRecord record)
	{
	}

	[Token(Token = "0x60025FE")]
	[Address(RVA = "0xA62AD0", Offset = "0xA62AD0", VA = "0xA62AD0")]
	private static void SetPlayerFirstPartySocialID(Dictionary<string, object> data, LeaderboardRecord record)
	{
	}

	[Token(Token = "0x60025FF")]
	[Address(RVA = "0xA62C84", Offset = "0xA62C84", VA = "0xA62C84")]
	private static string GetFirstPartyNameKey(Dictionary<string, object> data, string firstKey, string secondKey)
	{
		return null;
	}

	[Token(Token = "0x6002600")]
	[Address(RVA = "0xA62B50", Offset = "0xA62B50", VA = "0xA62B50")]
	private static void SetPlayerFacebookID(Dictionary<string, object> data, LeaderboardRecord record)
	{
	}

	[Token(Token = "0x6002601")]
	[Address(RVA = "0xA62BF4", Offset = "0xA62BF4", VA = "0xA62BF4")]
	private static void SetPlayerPicPref(Dictionary<string, object> data, LeaderboardRecord record)
	{
	}

	[Token(Token = "0x6002602")]
	[Address(RVA = "0xA62D38", Offset = "0xA62D38", VA = "0xA62D38")]
	public void FetchPlayersInfo(LeaderboardRecord[] records)
	{
	}

	[Token(Token = "0x6002603")]
	[Address(RVA = "0xA63114", Offset = "0xA63114", VA = "0xA63114")]
	private void FetchFacebookInfo(List<LeaderboardRecord> records)
	{
	}

	[Token(Token = "0x6002604")]
	[Address(RVA = "0xA62E88", Offset = "0xA62E88", VA = "0xA62E88")]
	private static void FetchFirstPartySocialInfo(List<LeaderboardRecord> records)
	{
	}

	[Token(Token = "0x6002605")]
	[Address(RVA = "0xA631D0", Offset = "0xA631D0", VA = "0xA631D0")]
	private static string GetFirstPartSocialId(string id)
	{
		return null;
	}

	[Token(Token = "0x6002606")]
	[Address(RVA = "0xA63258", Offset = "0xA63258", VA = "0xA63258")]
	private static void ProcessPlayerInfo(IUserProfile[] profiles, List<LeaderboardRecord> records)
	{
	}

	[Token(Token = "0x6002607")]
	[Address(RVA = "0xA6395C", Offset = "0xA6395C", VA = "0xA6395C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x61C2E0", Offset = "0x61C2E0")]
	private static IEnumerator PollImageLoaded(IUserProfile profile, IEnumerable<LeaderboardRecord> records)
	{
		return null;
	}

	[Token(Token = "0x6002608")]
	[Address(RVA = "0xA639D4", Offset = "0xA639D4", VA = "0xA639D4")]
	private void FetchFacebookInfo(LeaderboardRecord record)
	{
	}

	[Token(Token = "0x6002609")]
	[Address(RVA = "0xA6258C", Offset = "0xA6258C", VA = "0xA6258C")]
	private static long GetPlayerScore(string lbid)
	{
		return default(long);
	}

	[Token(Token = "0x600260A")]
	[Address(RVA = "0xA63B20", Offset = "0xA63B20", VA = "0xA63B20", Slot = "4")]
	public void Dispose()
	{
	}

	[Token(Token = "0x600260B")]
	[Address(RVA = "0xA63B90", Offset = "0xA63B90", VA = "0xA63B90")]
	protected void Dispose(bool disposing)
	{
	}
}
