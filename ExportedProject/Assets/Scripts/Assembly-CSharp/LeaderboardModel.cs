using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using Technology;
using Technology.Social;
using UnityEngine;

[Token(Token = "0x20005B0")]
public class LeaderboardModel : DataModel
{
	[Token(Token = "0x20005B1")]
	private class LeaderboardRecordIDComparer : IEqualityComparer<LeaderboardRecord>
	{
		[Token(Token = "0x600242C")]
		[Address(RVA = "0xB32DD4", Offset = "0xB32DD4", VA = "0xB32DD4", Slot = "4")]
		private bool System_002ECollections_002EGeneric_002EIEqualityComparer_003CTechnology_002ESocial_002ELeaderboardRecord_003E_002EEquals(LeaderboardRecord x, LeaderboardRecord y)
		{
			return default(bool);
		}

		[Token(Token = "0x600242D")]
		[Address(RVA = "0xB32E0C", Offset = "0xB32E0C", VA = "0xB32E0C", Slot = "5")]
		private int System_002ECollections_002EGeneric_002EIEqualityComparer_003CTechnology_002ESocial_002ELeaderboardRecord_003E_002EGetHashCode(LeaderboardRecord obj)
		{
			return default(int);
		}

		[Token(Token = "0x600242E")]
		[Address(RVA = "0xB327C4", Offset = "0xB327C4", VA = "0xB327C4")]
		public LeaderboardRecordIDComparer()
		{
		}
	}

	[Token(Token = "0x20005B2")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x59538C", Offset = "0x59538C")]
	private sealed class _003C_003Ec__DisplayClass24_0
	{
		[Token(Token = "0x4001E7C")]
		[FieldOffset(Offset = "0x10")]
		public bool? isOnline;

		[Token(Token = "0x600242F")]
		[Address(RVA = "0xB30544", Offset = "0xB30544", VA = "0xB30544")]
		public _003C_003Ec__DisplayClass24_0()
		{
		}

		[Token(Token = "0x6002430")]
		[Address(RVA = "0xB3054C", Offset = "0xB3054C", VA = "0xB3054C")]
		internal void _003CRefreshLeaderboards_003Eb__0(bool b)
		{
		}
	}

	[Token(Token = "0x20005B3")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x59539C", Offset = "0x59539C")]
	private sealed class _003CRefreshLeaderboards_003Ed__24 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4001E7D")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4001E7E")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4001E7F")]
		[FieldOffset(Offset = "0x20")]
		public LeaderboardModel _003C_003E4__this;

		[Token(Token = "0x4001E80")]
		[FieldOffset(Offset = "0x28")]
		private _003C_003Ec__DisplayClass24_0 _003C_003E8__1;

		[Token(Token = "0x4001E81")]
		[FieldOffset(Offset = "0x30")]
		public MonoBehaviour coroutineObject;

		[Token(Token = "0x4001E82")]
		[FieldOffset(Offset = "0x38")]
		private List<LeaderboardRecord> _003Crecords_003E5__2;

		[Token(Token = "0x4001E83")]
		[FieldOffset(Offset = "0x40")]
		private bool _003CisFacebookConnected_003E5__3;

		[Token(Token = "0x4001E84")]
		[FieldOffset(Offset = "0x41")]
		private bool _003CisFirstPartyConnected_003E5__4;

		[Token(Token = "0x4001E85")]
		[FieldOffset(Offset = "0x42")]
		private bool _003CisProfileUpdated_003E5__5;

		[Token(Token = "0x4001E86")]
		[FieldOffset(Offset = "0x43")]
		private bool _003CisFriendOnly_003E5__6;

		[Token(Token = "0x17000507")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6002434")]
			[Address(RVA = "0xB32D84", Offset = "0xB32D84", VA = "0xB32D84", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000508")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6002436")]
			[Address(RVA = "0xB32DCC", Offset = "0xB32DCC", VA = "0xB32DCC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6002431")]
		[Address(RVA = "0xB3281C", Offset = "0xB3281C", VA = "0xB3281C")]
		[DebuggerHidden]
		public _003CRefreshLeaderboards_003Ed__24(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6002432")]
		[Address(RVA = "0xB32848", Offset = "0xB32848", VA = "0xB32848", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6002433")]
		[Address(RVA = "0xB3284C", Offset = "0xB3284C", VA = "0xB3284C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6002435")]
		[Address(RVA = "0xB32D8C", Offset = "0xB32D8C", VA = "0xB32D8C", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x20005B4")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5953AC", Offset = "0x5953AC")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x4001E87")]
		[FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x4001E88")]
		[FieldOffset(Offset = "0x8")]
		public static Func<LeaderboardRecord, bool> _003C_003E9__26_0;

		[Token(Token = "0x4001E89")]
		[FieldOffset(Offset = "0x10")]
		public static Func<LeaderboardRecord, bool> _003C_003E9__27_0;

		[Token(Token = "0x4001E8A")]
		[FieldOffset(Offset = "0x18")]
		public static Func<LeaderboardRecord, bool> _003C_003E9__28_1;

		[Token(Token = "0x4001E8B")]
		[FieldOffset(Offset = "0x20")]
		public static Func<LeaderboardRecord, bool> _003C_003E9__28_2;

		[Token(Token = "0x4001E8C")]
		[FieldOffset(Offset = "0x28")]
		public static Predicate<LeaderboardRecord> _003C_003E9__30_0;

		[Token(Token = "0x4001E8D")]
		[FieldOffset(Offset = "0x30")]
		public static Func<LeaderboardRecord, LeaderboardRecord> _003C_003E9__30_1;

		[Token(Token = "0x4001E8E")]
		[FieldOffset(Offset = "0x38")]
		public static Func<LeaderboardRecord, LeaderboardRecord> _003C_003E9__30_2;

		[Token(Token = "0x4001E8F")]
		[FieldOffset(Offset = "0x40")]
		public static Func<KeyValuePair<LeaderboardRecord, LeaderboardRecord>, LeaderboardRecord> _003C_003E9__30_3;

		[Token(Token = "0x4001E90")]
		[FieldOffset(Offset = "0x48")]
		public static Comparison<LeaderboardRecord> _003C_003E9__34_0;

		[Token(Token = "0x4001E91")]
		[FieldOffset(Offset = "0x50")]
		public static Predicate<LeaderboardRecord> _003C_003E9__35_0;

		[Token(Token = "0x4001E92")]
		[FieldOffset(Offset = "0x58")]
		public static Predicate<LeaderboardRecord> _003C_003E9__36_0;

		[Token(Token = "0x6002438")]
		[Address(RVA = "0xB303D8", Offset = "0xB303D8", VA = "0xB303D8")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x6002439")]
		[Address(RVA = "0xB303E0", Offset = "0xB303E0", VA = "0xB303E0")]
		internal bool _003CAddLeaderboardRecords_003Eb__26_0(LeaderboardRecord r)
		{
			return default(bool);
		}

		[Token(Token = "0x600243A")]
		[Address(RVA = "0xB303FC", Offset = "0xB303FC", VA = "0xB303FC")]
		internal bool _003CAddLeaderboardRecordsFromPool_003Eb__27_0(LeaderboardRecord r)
		{
			return default(bool);
		}

		[Token(Token = "0x600243B")]
		[Address(RVA = "0xB30418", Offset = "0xB30418", VA = "0xB30418")]
		internal bool _003CAddLeaderboardRecordsBelowBoundaries_003Eb__28_1(LeaderboardRecord r)
		{
			return default(bool);
		}

		[Token(Token = "0x600243C")]
		[Address(RVA = "0xB30434", Offset = "0xB30434", VA = "0xB30434")]
		internal bool _003CAddLeaderboardRecordsBelowBoundaries_003Eb__28_2(LeaderboardRecord r)
		{
			return default(bool);
		}

		[Token(Token = "0x600243D")]
		[Address(RVA = "0xB30454", Offset = "0xB30454", VA = "0xB30454")]
		internal bool _003CGetFriendsRecords_003Eb__30_0(LeaderboardRecord r)
		{
			return default(bool);
		}

		[Token(Token = "0x600243E")]
		[Address(RVA = "0xB30474", Offset = "0xB30474", VA = "0xB30474")]
		internal LeaderboardRecord _003CGetFriendsRecords_003Eb__30_1(LeaderboardRecord r)
		{
			return null;
		}

		[Token(Token = "0x600243F")]
		[Address(RVA = "0xB3047C", Offset = "0xB3047C", VA = "0xB3047C")]
		internal LeaderboardRecord _003CGetFriendsRecords_003Eb__30_2(LeaderboardRecord r)
		{
			return null;
		}

		[Token(Token = "0x6002440")]
		[Address(RVA = "0xB30484", Offset = "0xB30484", VA = "0xB30484")]
		internal LeaderboardRecord _003CGetFriendsRecords_003Eb__30_3(KeyValuePair<LeaderboardRecord, LeaderboardRecord> kvp)
		{
			return null;
		}

		[Token(Token = "0x6002441")]
		[Address(RVA = "0xB304C4", Offset = "0xB304C4", VA = "0xB304C4")]
		internal int _003CSortRecords_003Eb__34_0(LeaderboardRecord c1, LeaderboardRecord c2)
		{
			return default(int);
		}

		[Token(Token = "0x6002442")]
		[Address(RVA = "0xB30514", Offset = "0xB30514", VA = "0xB30514")]
		internal bool _003CEnsureLocalPlayerHasBestScore_003Eb__35_0(LeaderboardRecord r)
		{
			return default(bool);
		}

		[Token(Token = "0x6002443")]
		[Address(RVA = "0xB3052C", Offset = "0xB3052C", VA = "0xB3052C")]
		internal bool _003CEnsureProperRankOrdering_003Eb__36_0(LeaderboardRecord r)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x20005B5")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5953BC", Offset = "0x5953BC")]
	private sealed class _003CAddLeaderboardRecords_003Ed__26 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4001E93")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4001E94")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4001E95")]
		[FieldOffset(Offset = "0x20")]
		public LeaderBoardType type;

		[Token(Token = "0x4001E96")]
		[FieldOffset(Offset = "0x24")]
		public int leaderboardId;

		[Token(Token = "0x4001E97")]
		[FieldOffset(Offset = "0x28")]
		public bool bSocial;

		[Token(Token = "0x4001E98")]
		[FieldOffset(Offset = "0x2C")]
		public int maxRecords;

		[Token(Token = "0x4001E99")]
		[FieldOffset(Offset = "0x30")]
		public string playerid;

		[Token(Token = "0x4001E9A")]
		[FieldOffset(Offset = "0x38")]
		public long score;

		[Token(Token = "0x4001E9B")]
		[FieldOffset(Offset = "0x40")]
		public List<LeaderboardRecord> record;

		[Token(Token = "0x4001E9C")]
		[FieldOffset(Offset = "0x48")]
		private LeaderboardRecord[] _003CnetRecords_003E5__2;

		[Token(Token = "0x4001E9D")]
		[FieldOffset(Offset = "0x50")]
		private ContinuousTimer _003Ctimer_003E5__3;

		[Token(Token = "0x17000509")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6002447")]
			[Address(RVA = "0xB30B60", Offset = "0xB30B60", VA = "0xB30B60", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700050A")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6002449")]
			[Address(RVA = "0xB30BA8", Offset = "0xB30BA8", VA = "0xB30BA8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6002444")]
		[Address(RVA = "0xB307A8", Offset = "0xB307A8", VA = "0xB307A8")]
		[DebuggerHidden]
		public _003CAddLeaderboardRecords_003Ed__26(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6002445")]
		[Address(RVA = "0xB307D4", Offset = "0xB307D4", VA = "0xB307D4", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6002446")]
		[Address(RVA = "0xB307D8", Offset = "0xB307D8", VA = "0xB307D8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6002448")]
		[Address(RVA = "0xB30B68", Offset = "0xB30B68", VA = "0xB30B68", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x20005B6")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5953CC", Offset = "0x5953CC")]
	private sealed class _003CAddLeaderboardRecordsFromPool_003Ed__27 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4001E9E")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4001E9F")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4001EA0")]
		[FieldOffset(Offset = "0x20")]
		public LeaderBoardType type;

		[Token(Token = "0x4001EA1")]
		[FieldOffset(Offset = "0x24")]
		public int leaderboardId;

		[Token(Token = "0x4001EA2")]
		[FieldOffset(Offset = "0x28")]
		public string[] playerPoolIds;

		[Token(Token = "0x4001EA3")]
		[FieldOffset(Offset = "0x30")]
		public List<LeaderboardRecord> records;

		[Token(Token = "0x4001EA4")]
		[FieldOffset(Offset = "0x38")]
		private LeaderboardRecord[] _003CnetRecords_003E5__2;

		[Token(Token = "0x4001EA5")]
		[FieldOffset(Offset = "0x40")]
		private ContinuousTimer _003Ctimer_003E5__3;

		[Token(Token = "0x1700050B")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600244D")]
			[Address(RVA = "0xB31698", Offset = "0xB31698", VA = "0xB31698", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700050C")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600244F")]
			[Address(RVA = "0xB316E0", Offset = "0xB316E0", VA = "0xB316E0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600244A")]
		[Address(RVA = "0xB31314", Offset = "0xB31314", VA = "0xB31314")]
		[DebuggerHidden]
		public _003CAddLeaderboardRecordsFromPool_003Ed__27(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600244B")]
		[Address(RVA = "0xB31340", Offset = "0xB31340", VA = "0xB31340", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600244C")]
		[Address(RVA = "0xB31344", Offset = "0xB31344", VA = "0xB31344", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600244E")]
		[Address(RVA = "0xB316A0", Offset = "0xB316A0", VA = "0xB316A0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x20005B7")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5953DC", Offset = "0x5953DC")]
	private sealed class _003C_003Ec__DisplayClass28_0
	{
		[Token(Token = "0x4001EA6")]
		[FieldOffset(Offset = "0x10")]
		public bool localDone;

		[Token(Token = "0x4001EA7")]
		[FieldOffset(Offset = "0x18")]
		public LeaderboardRecord localRecord;

		[Token(Token = "0x6002450")]
		[Address(RVA = "0xB305B8", Offset = "0xB305B8", VA = "0xB305B8")]
		public _003C_003Ec__DisplayClass28_0()
		{
		}

		[Token(Token = "0x6002451")]
		[Address(RVA = "0xB305C0", Offset = "0xB305C0", VA = "0xB305C0")]
		internal void _003CAddLeaderboardRecordsBelowBoundaries_003Eb__0(LeaderboardRecord lbr)
		{
		}
	}

	[Token(Token = "0x20005B8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5953EC", Offset = "0x5953EC")]
	private sealed class _003CAddLeaderboardRecordsBelowBoundaries_003Ed__28 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4001EA8")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4001EA9")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4001EAA")]
		[FieldOffset(Offset = "0x20")]
		public int leaderboardId;

		[Token(Token = "0x4001EAB")]
		[FieldOffset(Offset = "0x28")]
		public int[] boundaries;

		[Token(Token = "0x4001EAC")]
		[FieldOffset(Offset = "0x30")]
		private _003C_003Ec__DisplayClass28_0 _003C_003E8__1;

		[Token(Token = "0x4001EAD")]
		[FieldOffset(Offset = "0x38")]
		public LeaderboardConfiguration config;

		[Token(Token = "0x4001EAE")]
		[FieldOffset(Offset = "0x40")]
		public int numRecordsToRequest;

		[Token(Token = "0x4001EAF")]
		[FieldOffset(Offset = "0x44")]
		public int score;

		[Token(Token = "0x4001EB0")]
		[FieldOffset(Offset = "0x48")]
		public List<LeaderboardRecord> records;

		[Token(Token = "0x4001EB1")]
		[FieldOffset(Offset = "0x50")]
		private ILeaderboard _003Cleaderboard_003E5__2;

		[Token(Token = "0x4001EB2")]
		[FieldOffset(Offset = "0x58")]
		private Type _003CleaderboardType_003E5__3;

		[Token(Token = "0x4001EB3")]
		[FieldOffset(Offset = "0x60")]
		private string _003ClocalId_003E5__4;

		[Token(Token = "0x4001EB4")]
		[FieldOffset(Offset = "0x68")]
		private LeaderboardRecord[] _003CnetRecords_003E5__5;

		[Token(Token = "0x4001EB5")]
		[FieldOffset(Offset = "0x70")]
		private ContinuousTimer _003Ctimer_003E5__6;

		[Token(Token = "0x1700050D")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6002455")]
			[Address(RVA = "0xB312C4", Offset = "0xB312C4", VA = "0xB312C4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700050E")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6002457")]
			[Address(RVA = "0xB3130C", Offset = "0xB3130C", VA = "0xB3130C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6002452")]
		[Address(RVA = "0xB30BB0", Offset = "0xB30BB0", VA = "0xB30BB0")]
		[DebuggerHidden]
		public _003CAddLeaderboardRecordsBelowBoundaries_003Ed__28(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6002453")]
		[Address(RVA = "0xB30BDC", Offset = "0xB30BDC", VA = "0xB30BDC", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6002454")]
		[Address(RVA = "0xB30BE0", Offset = "0xB30BE0", VA = "0xB30BE0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6002456")]
		[Address(RVA = "0xB312CC", Offset = "0xB312CC", VA = "0xB312CC", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x20005B9")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5953FC", Offset = "0x5953FC")]
	private sealed class _003CAddFriends_003Ed__29 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4001EB6")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4001EB7")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4001EB8")]
		[FieldOffset(Offset = "0x20")]
		public MonoBehaviour coroutineObject;

		[Token(Token = "0x4001EB9")]
		[FieldOffset(Offset = "0x28")]
		public List<LeaderboardRecord> records;

		[Token(Token = "0x4001EBA")]
		[FieldOffset(Offset = "0x30")]
		public LeaderboardModel _003C_003E4__this;

		[Token(Token = "0x1700050F")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600245B")]
			[Address(RVA = "0xB30758", Offset = "0xB30758", VA = "0xB30758", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000510")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600245D")]
			[Address(RVA = "0xB307A0", Offset = "0xB307A0", VA = "0xB307A0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6002458")]
		[Address(RVA = "0xB30618", Offset = "0xB30618", VA = "0xB30618")]
		[DebuggerHidden]
		public _003CAddFriends_003Ed__29(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6002459")]
		[Address(RVA = "0xB30644", Offset = "0xB30644", VA = "0xB30644", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600245A")]
		[Address(RVA = "0xB30648", Offset = "0xB30648", VA = "0xB30648", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600245C")]
		[Address(RVA = "0xB30760", Offset = "0xB30760", VA = "0xB30760", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x20005BA")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x59540C", Offset = "0x59540C")]
	private sealed class _003CGetFriendsRecords_003Ed__30 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4001EBB")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4001EBC")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4001EBD")]
		[FieldOffset(Offset = "0x20")]
		public List<LeaderboardRecord> records;

		[Token(Token = "0x4001EBE")]
		[FieldOffset(Offset = "0x28")]
		public int maxRecords;

		[Token(Token = "0x4001EBF")]
		[FieldOffset(Offset = "0x30")]
		public MonoBehaviour coroutineObject;

		[Token(Token = "0x4001EC0")]
		[FieldOffset(Offset = "0x38")]
		public int leaderboardId;

		[Token(Token = "0x4001EC1")]
		[FieldOffset(Offset = "0x40")]
		private string[] _003CfriendsList_003E5__2;

		[Token(Token = "0x4001EC2")]
		[FieldOffset(Offset = "0x48")]
		private Dictionary<LeaderboardRecord, LeaderboardRecord> _003Cdict_003E5__3;

		[Token(Token = "0x4001EC3")]
		[FieldOffset(Offset = "0x50")]
		private List<LeaderboardRecord> _003CfriendsRecords_003E5__4;

		[Token(Token = "0x17000511")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6002461")]
			[Address(RVA = "0xB327CC", Offset = "0xB327CC", VA = "0xB327CC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000512")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6002463")]
			[Address(RVA = "0xB32814", Offset = "0xB32814", VA = "0xB32814", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600245E")]
		[Address(RVA = "0xB31ED4", Offset = "0xB31ED4", VA = "0xB31ED4")]
		[DebuggerHidden]
		public _003CGetFriendsRecords_003Ed__30(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600245F")]
		[Address(RVA = "0xB31F00", Offset = "0xB31F00", VA = "0xB31F00", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6002460")]
		[Address(RVA = "0xB31F04", Offset = "0xB31F04", VA = "0xB31F04", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6002462")]
		[Address(RVA = "0xB327D4", Offset = "0xB327D4", VA = "0xB327D4", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x20005BB")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x59541C", Offset = "0x59541C")]
	private sealed class _003C_003Ec__DisplayClass31_0
	{
		[Token(Token = "0x4001EC4")]
		[FieldOffset(Offset = "0x10")]
		public LeaderboardConfiguration.SubDivision subDivisionOUT;

		[Token(Token = "0x6002464")]
		[Address(RVA = "0xB305D0", Offset = "0xB305D0", VA = "0xB305D0")]
		public _003C_003Ec__DisplayClass31_0()
		{
		}

		[Token(Token = "0x6002465")]
		[Address(RVA = "0xB305D8", Offset = "0xB305D8", VA = "0xB305D8")]
		internal bool _003CFindLastChallenger_003Eb__0(LeaderboardRecord r)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x20005BC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x59542C", Offset = "0x59542C")]
	private sealed class _003CFindLastChallenger_003Ed__31 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4001EC5")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4001EC6")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4001EC7")]
		[FieldOffset(Offset = "0x20")]
		public LeaderboardModel _003C_003E4__this;

		[Token(Token = "0x4001EC8")]
		[FieldOffset(Offset = "0x28")]
		public MonoBehaviour coroutineObject;

		[Token(Token = "0x4001EC9")]
		[FieldOffset(Offset = "0x30")]
		private _003C_003Ec__DisplayClass31_0 _003C_003E8__1;

		[Token(Token = "0x4001ECA")]
		[FieldOffset(Offset = "0x38")]
		public List<LeaderboardRecord> records;

		[Token(Token = "0x4001ECB")]
		[FieldOffset(Offset = "0x40")]
		private int _003CleaderboardID_003E5__2;

		[Token(Token = "0x4001ECC")]
		[FieldOffset(Offset = "0x48")]
		private List<LeaderboardRecord> _003CchallengerRecordsList_003E5__3;

		[Token(Token = "0x4001ECD")]
		[FieldOffset(Offset = "0x50")]
		private LeaderboardConfiguration _003CleaderboardConfiguration_003E5__4;

		[Token(Token = "0x17000513")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6002469")]
			[Address(RVA = "0xB31E84", Offset = "0xB31E84", VA = "0xB31E84", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000514")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600246B")]
			[Address(RVA = "0xB31ECC", Offset = "0xB31ECC", VA = "0xB31ECC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6002466")]
		[Address(RVA = "0xB31B14", Offset = "0xB31B14", VA = "0xB31B14")]
		[DebuggerHidden]
		public _003CFindLastChallenger_003Ed__31(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6002467")]
		[Address(RVA = "0xB31B40", Offset = "0xB31B40", VA = "0xB31B40", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6002468")]
		[Address(RVA = "0xB31B44", Offset = "0xB31B44", VA = "0xB31B44", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600246A")]
		[Address(RVA = "0xB31E8C", Offset = "0xB31E8C", VA = "0xB31E8C", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x20005BD")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x59543C", Offset = "0x59543C")]
	private sealed class _003CFillUpWithWorldPlayer_003Ed__32 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4001ECE")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4001ECF")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4001ED0")]
		[FieldOffset(Offset = "0x20")]
		public LeaderboardModel _003C_003E4__this;

		[Token(Token = "0x4001ED1")]
		[FieldOffset(Offset = "0x28")]
		public List<LeaderboardRecord> records;

		[Token(Token = "0x4001ED2")]
		[FieldOffset(Offset = "0x30")]
		public MonoBehaviour coroutineObject;

		[Token(Token = "0x4001ED3")]
		[FieldOffset(Offset = "0x38")]
		private List<LeaderboardRecord> _003CfillerRecordsList_003E5__2;

		[Token(Token = "0x17000515")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600246F")]
			[Address(RVA = "0xB31AC4", Offset = "0xB31AC4", VA = "0xB31AC4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000516")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6002471")]
			[Address(RVA = "0xB31B0C", Offset = "0xB31B0C", VA = "0xB31B0C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600246C")]
		[Address(RVA = "0xB316E8", Offset = "0xB316E8", VA = "0xB316E8")]
		[DebuggerHidden]
		public _003CFillUpWithWorldPlayer_003Ed__32(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600246D")]
		[Address(RVA = "0xB31714", Offset = "0xB31714", VA = "0xB31714", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600246E")]
		[Address(RVA = "0xB31718", Offset = "0xB31718", VA = "0xB31718", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6002470")]
		[Address(RVA = "0xB31ACC", Offset = "0xB31ACC", VA = "0xB31ACC", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x4001E66")]
	private const float TIMEOUT_DURATION = 20f;

	[Token(Token = "0x4001E67")]
	[FieldOffset(Offset = "0x0")]
	public static readonly string LEADERBOARD_ID;

	[Token(Token = "0x4001E68")]
	[FieldOffset(Offset = "0x8")]
	public static readonly string NUM_RECORDS_DISPLAYED;

	[Token(Token = "0x4001E69")]
	[FieldOffset(Offset = "0x10")]
	public static readonly string IS_OFFLINE;

	[Token(Token = "0x4001E6A")]
	[FieldOffset(Offset = "0x18")]
	public static readonly string IS_SERVER_DOWN;

	[Token(Token = "0x4001E6B")]
	[FieldOffset(Offset = "0x20")]
	public static readonly string LEADERBOARD_RECORDS;

	[Token(Token = "0x4001E6C")]
	[FieldOffset(Offset = "0x28")]
	public static readonly string NO_NETWORK_ERROR;

	[Token(Token = "0x4001E6D")]
	[FieldOffset(Offset = "0x30")]
	public static readonly string FAKE_OFFLINE_RECORDS_SETTINGS;

	[Token(Token = "0x4001E6E")]
	[FieldOffset(Offset = "0x38")]
	public static readonly string SHOW_FRIENDS_ONLY;

	[Token(Token = "0x4001E6F")]
	[FieldOffset(Offset = "0x40")]
	public static readonly string SHOW_MILESTONE;

	[Token(Token = "0x4001E70")]
	[FieldOffset(Offset = "0x48")]
	public static readonly string TIER_INDEX;

	[Token(Token = "0x4001E71")]
	[FieldOffset(Offset = "0x50")]
	public static readonly string IS_PLAYER_INACTIVE;

	[Token(Token = "0x4001E72")]
	[FieldOffset(Offset = "0x48")]
	public int NumRecordsDisplayed;

	[Token(Token = "0x4001E73")]
	[FieldOffset(Offset = "0x58")]
	private static readonly Dictionary<MonoBehaviour, Coroutine> _refreshCoroutines;

	[Token(Token = "0x4001E74")]
	[FieldOffset(Offset = "0x4C")]
	private int _leaderboardID;

	[Token(Token = "0x4001E75")]
	[FieldOffset(Offset = "0x50")]
	private bool _isOffline;

	[Token(Token = "0x4001E76")]
	[FieldOffset(Offset = "0x51")]
	private bool _isServerDown;

	[Token(Token = "0x4001E77")]
	[FieldOffset(Offset = "0x58")]
	private IEnumerable<LeaderboardRecord> _records;

	[Token(Token = "0x4001E78")]
	[FieldOffset(Offset = "0x60")]
	private bool _noNetworkError;

	[Token(Token = "0x4001E79")]
	[FieldOffset(Offset = "0x61")]
	private bool _showFriendsOnly;

	[Token(Token = "0x4001E7A")]
	[FieldOffset(Offset = "0x62")]
	private bool _showMilestone;

	[Token(Token = "0x4001E7B")]
	[FieldOffset(Offset = "0x64")]
	private int _tierIndex;

	[Token(Token = "0x6002407")]
	[Address(RVA = "0x9A1454", Offset = "0x9A1454", VA = "0x9A1454", Slot = "5")]
	protected override void BindAllVariables()
	{
	}

	[Token(Token = "0x6002408")]
	[Address(RVA = "0x99C6B8", Offset = "0x99C6B8", VA = "0x99C6B8")]
	public static void StartLeaderboardRefresh(UIController uiController)
	{
	}

	[Token(Token = "0x6002409")]
	[Address(RVA = "0x9A1AD4", Offset = "0x9A1AD4", VA = "0x9A1AD4")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x61AD40", Offset = "0x61AD40")]
	public IEnumerator RefreshLeaderboards(MonoBehaviour coroutineObject)
	{
		return null;
	}

	[Token(Token = "0x600240A")]
	[Address(RVA = "0x9A1B50", Offset = "0x9A1B50", VA = "0x9A1B50")]
	private static IEnumerator AddLeaderboardRecords(List<LeaderboardRecord> record, LeaderBoardType type, int leaderboardId, bool bSocial, int maxRecords)
	{
		return null;
	}

	[Token(Token = "0x600240B")]
	[Address(RVA = "0x9A1C4C", Offset = "0x9A1C4C", VA = "0x9A1C4C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x61ADA0", Offset = "0x61ADA0")]
	private static IEnumerator AddLeaderboardRecords(List<LeaderboardRecord> record, LeaderBoardType type, int leaderboardId, bool bSocial, int maxRecords, string playerid, long score)
	{
		return null;
	}

	[Token(Token = "0x600240C")]
	[Address(RVA = "0x9A1CFC", Offset = "0x9A1CFC", VA = "0x9A1CFC")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x61AE00", Offset = "0x61AE00")]
	private static IEnumerator AddLeaderboardRecordsFromPool(List<LeaderboardRecord> records, LeaderBoardType type, int leaderboardId, string[] playerPoolIds)
	{
		return null;
	}

	[Token(Token = "0x600240D")]
	[Address(RVA = "0x9A1D88", Offset = "0x9A1D88", VA = "0x9A1D88")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x61AE60", Offset = "0x61AE60")]
	private static IEnumerator AddLeaderboardRecordsBelowBoundaries(List<LeaderboardRecord> records, int leaderboardId, int[] boundaries, int numRecordsToRequest, int score, LeaderboardConfiguration config)
	{
		return null;
	}

	[Token(Token = "0x600240E")]
	[Address(RVA = "0x9A1E30", Offset = "0x9A1E30", VA = "0x9A1E30")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x61AEC0", Offset = "0x61AEC0")]
	private IEnumerator AddFriends(List<LeaderboardRecord> records, MonoBehaviour coroutineObject)
	{
		return null;
	}

	[Token(Token = "0x600240F")]
	[Address(RVA = "0x9A1EB0", Offset = "0x9A1EB0", VA = "0x9A1EB0")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x61AF20", Offset = "0x61AF20")]
	public static IEnumerator GetFriendsRecords(List<LeaderboardRecord> records, MonoBehaviour coroutineObject, int maxRecords, int leaderboardId)
	{
		return null;
	}

	[Token(Token = "0x6002410")]
	[Address(RVA = "0x9A1F44", Offset = "0x9A1F44", VA = "0x9A1F44")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x61AF80", Offset = "0x61AF80")]
	private IEnumerator FindLastChallenger(List<LeaderboardRecord> records, MonoBehaviour coroutineObject)
	{
		return null;
	}

	[Token(Token = "0x6002411")]
	[Address(RVA = "0x9A1FC4", Offset = "0x9A1FC4", VA = "0x9A1FC4")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x61AFE0", Offset = "0x61AFE0")]
	private IEnumerator FillUpWithWorldPlayer(List<LeaderboardRecord> records, MonoBehaviour coroutineObject)
	{
		return null;
	}

	[Token(Token = "0x6002412")]
	[Address(RVA = "0x9A2044", Offset = "0x9A2044", VA = "0x9A2044")]
	private static List<LeaderboardRecord> RemoveNullAndDuplicate(List<LeaderboardRecord> records)
	{
		return null;
	}

	[Token(Token = "0x6002413")]
	[Address(RVA = "0x9A212C", Offset = "0x9A212C", VA = "0x9A212C")]
	private static void SortRecords(List<LeaderboardRecord> records)
	{
	}

	[Token(Token = "0x6002414")]
	[Address(RVA = "0x9A224C", Offset = "0x9A224C", VA = "0x9A224C")]
	private void EnsureLocalPlayerHasBestScore(List<LeaderboardRecord> records)
	{
	}

	[Token(Token = "0x6002415")]
	[Address(RVA = "0x9A2584", Offset = "0x9A2584", VA = "0x9A2584")]
	private static void EnsureProperRankOrdering(List<LeaderboardRecord> records)
	{
	}

	[Token(Token = "0x6002416")]
	[Address(RVA = "0x9A2878", Offset = "0x9A2878", VA = "0x9A2878")]
	private bool IsPlayerInactive()
	{
		return default(bool);
	}

	[Token(Token = "0x6002417")]
	[Address(RVA = "0x9A2918", Offset = "0x9A2918", VA = "0x9A2918")]
	public LeaderboardModel()
	{
	}

	[Token(Token = "0x6002419")]
	[Address(RVA = "0x9A2B18", Offset = "0x9A2B18", VA = "0x9A2B18")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61B040", Offset = "0x61B040")]
	private int _003CBindAllVariables_003Eb__22_0()
	{
		return default(int);
	}

	[Token(Token = "0x600241A")]
	[Address(RVA = "0x9A2B20", Offset = "0x9A2B20", VA = "0x9A2B20")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61B050", Offset = "0x61B050")]
	private void _003CBindAllVariables_003Eb__22_1(int i)
	{
	}

	[Token(Token = "0x600241B")]
	[Address(RVA = "0x9A2B28", Offset = "0x9A2B28", VA = "0x9A2B28")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61B060", Offset = "0x61B060")]
	private int _003CBindAllVariables_003Eb__22_2()
	{
		return default(int);
	}

	[Token(Token = "0x600241C")]
	[Address(RVA = "0x9A2B30", Offset = "0x9A2B30", VA = "0x9A2B30")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61B070", Offset = "0x61B070")]
	private void _003CBindAllVariables_003Eb__22_3(int i)
	{
	}

	[Token(Token = "0x600241D")]
	[Address(RVA = "0x9A2B38", Offset = "0x9A2B38", VA = "0x9A2B38")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61B080", Offset = "0x61B080")]
	private bool _003CBindAllVariables_003Eb__22_4()
	{
		return default(bool);
	}

	[Token(Token = "0x600241E")]
	[Address(RVA = "0x9A2B40", Offset = "0x9A2B40", VA = "0x9A2B40")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61B090", Offset = "0x61B090")]
	private void _003CBindAllVariables_003Eb__22_5(bool b)
	{
	}

	[Token(Token = "0x600241F")]
	[Address(RVA = "0x9A2B4C", Offset = "0x9A2B4C", VA = "0x9A2B4C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61B0A0", Offset = "0x61B0A0")]
	private bool _003CBindAllVariables_003Eb__22_6()
	{
		return default(bool);
	}

	[Token(Token = "0x6002420")]
	[Address(RVA = "0x9A2B54", Offset = "0x9A2B54", VA = "0x9A2B54")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61B0B0", Offset = "0x61B0B0")]
	private void _003CBindAllVariables_003Eb__22_7(bool b)
	{
	}

	[Token(Token = "0x6002421")]
	[Address(RVA = "0x9A2B60", Offset = "0x9A2B60", VA = "0x9A2B60")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61B0C0", Offset = "0x61B0C0")]
	private object _003CBindAllVariables_003Eb__22_8()
	{
		return null;
	}

	[Token(Token = "0x6002422")]
	[Address(RVA = "0x9A2B68", Offset = "0x9A2B68", VA = "0x9A2B68")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61B0D0", Offset = "0x61B0D0")]
	private void _003CBindAllVariables_003Eb__22_9(object r)
	{
	}

	[Token(Token = "0x6002423")]
	[Address(RVA = "0x9A2BE4", Offset = "0x9A2BE4", VA = "0x9A2BE4")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61B0E0", Offset = "0x61B0E0")]
	private bool _003CBindAllVariables_003Eb__22_10()
	{
		return default(bool);
	}

	[Token(Token = "0x6002424")]
	[Address(RVA = "0x9A2BEC", Offset = "0x9A2BEC", VA = "0x9A2BEC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61B0F0", Offset = "0x61B0F0")]
	private void _003CBindAllVariables_003Eb__22_11(bool b)
	{
	}

	[Token(Token = "0x6002425")]
	[Address(RVA = "0x9A2BF8", Offset = "0x9A2BF8", VA = "0x9A2BF8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61B100", Offset = "0x61B100")]
	private bool _003CBindAllVariables_003Eb__22_12()
	{
		return default(bool);
	}

	[Token(Token = "0x6002426")]
	[Address(RVA = "0x9A2C00", Offset = "0x9A2C00", VA = "0x9A2C00")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61B110", Offset = "0x61B110")]
	private void _003CBindAllVariables_003Eb__22_13(bool b)
	{
	}

	[Token(Token = "0x6002427")]
	[Address(RVA = "0x9A2C0C", Offset = "0x9A2C0C", VA = "0x9A2C0C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61B120", Offset = "0x61B120")]
	private bool _003CBindAllVariables_003Eb__22_14()
	{
		return default(bool);
	}

	[Token(Token = "0x6002428")]
	[Address(RVA = "0x9A2C14", Offset = "0x9A2C14", VA = "0x9A2C14")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61B130", Offset = "0x61B130")]
	private void _003CBindAllVariables_003Eb__22_15(bool b)
	{
	}

	[Token(Token = "0x6002429")]
	[Address(RVA = "0x9A2C20", Offset = "0x9A2C20", VA = "0x9A2C20")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61B140", Offset = "0x61B140")]
	private int _003CBindAllVariables_003Eb__22_16()
	{
		return default(int);
	}

	[Token(Token = "0x600242A")]
	[Address(RVA = "0x9A2C28", Offset = "0x9A2C28", VA = "0x9A2C28")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61B150", Offset = "0x61B150")]
	private void _003CBindAllVariables_003Eb__22_17(int i)
	{
	}

	[Token(Token = "0x600242B")]
	[Address(RVA = "0x9A2C30", Offset = "0x9A2C30", VA = "0x9A2C30")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61B160", Offset = "0x61B160")]
	private bool _003CBindAllVariables_003Eb__22_18()
	{
		return default(bool);
	}
}
