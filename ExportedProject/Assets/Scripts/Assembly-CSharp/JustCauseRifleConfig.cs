using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using Technology.Social;
using UnityEngine;

[Token(Token = "0x2000205")]
public class JustCauseRifleConfig : BaseConfig<JustCauseRifleConfig>
{
	[Serializable]
	[Token(Token = "0x2000206")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x592A84", Offset = "0x592A84")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x4000BB3")]
		[FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x4000BB4")]
		[FieldOffset(Offset = "0x8")]
		public static Func<LeaderboardRecord, bool> _003C_003E9__26_0;

		[Token(Token = "0x4000BB5")]
		[FieldOffset(Offset = "0x10")]
		public static Func<LeaderboardRecord, string> _003C_003E9__26_1;

		[Token(Token = "0x6000C5F")]
		[Address(RVA = "0xB2E2C0", Offset = "0xB2E2C0", VA = "0xB2E2C0")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x6000C60")]
		[Address(RVA = "0xB2E2C8", Offset = "0xB2E2C8", VA = "0xB2E2C8")]
		internal bool _003CDoRefreshFriendCount_003Eb__26_0(LeaderboardRecord r)
		{
			return default(bool);
		}

		[Token(Token = "0x6000C61")]
		[Address(RVA = "0xB2E2E4", Offset = "0xB2E2E4", VA = "0xB2E2E4")]
		internal string _003CDoRefreshFriendCount_003Eb__26_1(LeaderboardRecord r)
		{
			return null;
		}
	}

	[Token(Token = "0x2000207")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x592A94", Offset = "0x592A94")]
	private sealed class _003CDoRefreshFriendCount_003Ed__26 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000BB6")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4000BB7")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4000BB8")]
		[FieldOffset(Offset = "0x20")]
		public JustCauseRifleConfig _003C_003E4__this;

		[Token(Token = "0x4000BB9")]
		[FieldOffset(Offset = "0x28")]
		public MonoBehaviour coroutineObject;

		[Token(Token = "0x4000BBA")]
		[FieldOffset(Offset = "0x30")]
		private List<LeaderboardRecord> _003Crecords_003E5__2;

		[Token(Token = "0x170001F9")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6000C65")]
			[Address(RVA = "0xB2E86C", Offset = "0xB2E86C", VA = "0xB2E86C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001FA")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6000C67")]
			[Address(RVA = "0xB2E8B4", Offset = "0xB2E8B4", VA = "0xB2E8B4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000C62")]
		[Address(RVA = "0xB2E2FC", Offset = "0xB2E2FC", VA = "0xB2E2FC")]
		[DebuggerHidden]
		public _003CDoRefreshFriendCount_003Ed__26(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6000C63")]
		[Address(RVA = "0xB2E328", Offset = "0xB2E328", VA = "0xB2E328", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6000C64")]
		[Address(RVA = "0xB2E32C", Offset = "0xB2E32C", VA = "0xB2E32C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000C66")]
		[Address(RVA = "0xB2E874", Offset = "0xB2E874", VA = "0xB2E874", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x4000BAF")]
	[FieldOffset(Offset = "0x0")]
	public static readonly string PATH;

	[Token(Token = "0x4000BB1")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private int _rankRequired;

	[Token(Token = "0x4000BB2")]
	[FieldOffset(Offset = "0x3C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5B2D18", Offset = "0x5B2D18")]
	private int _003CFriendsReferred_003Ek__BackingField;

	[Token(Token = "0x170001F0")]
	public int RankRequired
	{
		[Token(Token = "0x6000C50")]
		[Address(RVA = "0x9926AC", Offset = "0x9926AC", VA = "0x9926AC")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170001F1")]
	public int TotalFriendsRequired
	{
		[Token(Token = "0x6000C51")]
		[Address(RVA = "0x9926B4", Offset = "0x9926B4", VA = "0x9926B4")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170001F2")]
	public int CurrentFriendsRequired
	{
		[Token(Token = "0x6000C52")]
		[Address(RVA = "0x99274C", Offset = "0x99274C", VA = "0x99274C")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170001F3")]
	public int FriendsReferred
	{
		[Token(Token = "0x6000C53")]
		[Address(RVA = "0x9928A8", Offset = "0x9928A8", VA = "0x9928A8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6142A4", Offset = "0x6142A4")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6000C54")]
		[Address(RVA = "0x9928B0", Offset = "0x9928B0", VA = "0x9928B0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6142B4", Offset = "0x6142B4")]
		private set
		{
		}
	}

	[Token(Token = "0x170001F4")]
	public int OfflineFriendsReferred
	{
		[Token(Token = "0x6000C55")]
		[Address(RVA = "0x992788", Offset = "0x992788", VA = "0x992788")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170001F5")]
	public bool IsAdsRequirementReached
	{
		[Token(Token = "0x6000C56")]
		[Address(RVA = "0x9928B8", Offset = "0x9928B8", VA = "0x9928B8")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170001F6")]
	public bool IsRankRequirementReached
	{
		[Token(Token = "0x6000C57")]
		[Address(RVA = "0x992948", Offset = "0x992948", VA = "0x992948")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170001F7")]
	public bool IsFriendsRequirementReached
	{
		[Token(Token = "0x6000C58")]
		[Address(RVA = "0x9929E4", Offset = "0x9929E4", VA = "0x9929E4")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170001F8")]
	public bool AllRequirementsReached
	{
		[Token(Token = "0x6000C59")]
		[Address(RVA = "0x992AA4", Offset = "0x992AA4", VA = "0x992AA4")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x14000027")]
	public event Action OnFriendCountRefreshed
	{
		[Token(Token = "0x6000C4E")]
		[Address(RVA = "0x99256C", Offset = "0x99256C", VA = "0x99256C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x614284", Offset = "0x614284")]
		add
		{
		}
		[Token(Token = "0x6000C4F")]
		[Address(RVA = "0x99260C", Offset = "0x99260C", VA = "0x99260C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x614294", Offset = "0x614294")]
		remove
		{
		}
	}

	[Token(Token = "0x6000C5A")]
	[Address(RVA = "0x992AE4", Offset = "0x992AE4", VA = "0x992AE4")]
	public void RefreshFriendCount()
	{
	}

	[Token(Token = "0x6000C5B")]
	[Address(RVA = "0x992B80", Offset = "0x992B80", VA = "0x992B80")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x6142C4", Offset = "0x6142C4")]
	private IEnumerator DoRefreshFriendCount(MonoBehaviour coroutineObject)
	{
		return null;
	}

	[Token(Token = "0x6000C5C")]
	[Address(RVA = "0x992BF8", Offset = "0x992BF8", VA = "0x992BF8")]
	public JustCauseRifleConfig()
	{
	}
}
