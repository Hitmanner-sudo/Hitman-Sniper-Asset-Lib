using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using Technology;
using Technology.Social;
using UnityEngine;

[Token(Token = "0x2000682")]
public class LeaderboardView : View
{
	[Token(Token = "0x2000683")]
	public class StickyObject
	{
		[Token(Token = "0x4002490")]
		[FieldOffset(Offset = "0x10")]
		public GameObject StickyItem;

		[Token(Token = "0x4002491")]
		[FieldOffset(Offset = "0x18")]
		public GameObject Item;

		[Token(Token = "0x4002492")]
		[FieldOffset(Offset = "0x20")]
		public GameObject DraggablePanel;

		[Token(Token = "0x4002493")]
		[FieldOffset(Offset = "0x28")]
		public float Index;

		[Token(Token = "0x6002AB2")]
		[Address(RVA = "0x8C1308", Offset = "0x8C1308", VA = "0x8C1308")]
		public StickyObject(GameObject stickyItem, GameObject item, int index)
		{
		}
	}

	[Token(Token = "0x2000684")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x595928", Offset = "0x595928")]
	private sealed class _003CUpdateLeaderboards_003Ed__38 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4002494")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4002495")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4002496")]
		[FieldOffset(Offset = "0x20")]
		public LeaderboardView _003C_003E4__this;

		[Token(Token = "0x4002497")]
		[FieldOffset(Offset = "0x28")]
		private List<LeaderboardRecord> _003Crecords_003E5__2;

		[Token(Token = "0x17000577")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6002AB6")]
			[Address(RVA = "0xB34A54", Offset = "0xB34A54", VA = "0xB34A54", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000578")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6002AB8")]
			[Address(RVA = "0xB34A9C", Offset = "0xB34A9C", VA = "0xB34A9C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6002AB3")]
		[Address(RVA = "0xB34804", Offset = "0xB34804", VA = "0xB34804")]
		[DebuggerHidden]
		public _003CUpdateLeaderboards_003Ed__38(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6002AB4")]
		[Address(RVA = "0xB34830", Offset = "0xB34830", VA = "0xB34830", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6002AB5")]
		[Address(RVA = "0xB34834", Offset = "0xB34834", VA = "0xB34834", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6002AB7")]
		[Address(RVA = "0xB34A5C", Offset = "0xB34A5C", VA = "0xB34A5C", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2000685")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x595938", Offset = "0x595938")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x4002498")]
		[FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x4002499")]
		[FieldOffset(Offset = "0x8")]
		public static Func<LeaderboardRecord, bool> _003C_003E9__39_0;

		[Token(Token = "0x400249A")]
		[FieldOffset(Offset = "0x10")]
		public static Predicate<LeaderboardRecord> _003C_003E9__42_0;

		[Token(Token = "0x400249B")]
		[FieldOffset(Offset = "0x18")]
		public static Predicate<LeaderboardRecord> _003C_003E9__51_0;

		[Token(Token = "0x6002ABA")]
		[Address(RVA = "0xB337BC", Offset = "0xB337BC", VA = "0xB337BC")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x6002ABB")]
		[Address(RVA = "0xB337C4", Offset = "0xB337C4", VA = "0xB337C4")]
		internal bool _003CResetLeaderboardItems_003Eb__39_0(LeaderboardRecord r)
		{
			return default(bool);
		}

		[Token(Token = "0x6002ABC")]
		[Address(RVA = "0xB337D0", Offset = "0xB337D0", VA = "0xB337D0")]
		internal bool _003CCreateItems_003Eb__42_0(LeaderboardRecord r)
		{
			return default(bool);
		}

		[Token(Token = "0x6002ABD")]
		[Address(RVA = "0xB337EC", Offset = "0xB337EC", VA = "0xB337EC")]
		internal bool _003CLoadPicture_003Eb__51_0(LeaderboardRecord r)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2000686")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x595948", Offset = "0x595948")]
	private sealed class _003CResetLeaderboardItems_003Ed__39 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400249C")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400249D")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400249E")]
		[FieldOffset(Offset = "0x20")]
		public LeaderboardView _003C_003E4__this;

		[Token(Token = "0x400249F")]
		[FieldOffset(Offset = "0x28")]
		public List<LeaderboardRecord> records;

		[Token(Token = "0x17000579")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6002AC1")]
			[Address(RVA = "0xB347B4", Offset = "0xB347B4", VA = "0xB347B4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700057A")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6002AC3")]
			[Address(RVA = "0xB347FC", Offset = "0xB347FC", VA = "0xB347FC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6002ABE")]
		[Address(RVA = "0xB34584", Offset = "0xB34584", VA = "0xB34584")]
		[DebuggerHidden]
		public _003CResetLeaderboardItems_003Ed__39(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6002ABF")]
		[Address(RVA = "0xB345B0", Offset = "0xB345B0", VA = "0xB345B0", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6002AC0")]
		[Address(RVA = "0xB345B4", Offset = "0xB345B4", VA = "0xB345B4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6002AC2")]
		[Address(RVA = "0xB347BC", Offset = "0xB347BC", VA = "0xB347BC", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x2000687")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x595958", Offset = "0x595958")]
	private sealed class _003C_003Ec__DisplayClass42_0
	{
		[Token(Token = "0x40024A0")]
		[FieldOffset(Offset = "0x10")]
		public string friendSid;

		[Token(Token = "0x6002AC4")]
		[Address(RVA = "0xB33808", Offset = "0xB33808", VA = "0xB33808")]
		public _003C_003Ec__DisplayClass42_0()
		{
		}

		[Token(Token = "0x6002AC5")]
		[Address(RVA = "0xB33810", Offset = "0xB33810", VA = "0xB33810")]
		internal bool _003CCreateItems_003Eb__1(LeaderboardRecord r)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2000688")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x595968", Offset = "0x595968")]
	private sealed class _003CCreateItems_003Ed__42 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40024A1")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40024A2")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40024A3")]
		[FieldOffset(Offset = "0x20")]
		public List<LeaderboardRecord> records;

		[Token(Token = "0x40024A4")]
		[FieldOffset(Offset = "0x28")]
		public LeaderboardView _003C_003E4__this;

		[Token(Token = "0x40024A5")]
		[FieldOffset(Offset = "0x30")]
		private int _003ClocalPlayerIndex_003E5__2;

		[Token(Token = "0x40024A6")]
		[FieldOffset(Offset = "0x38")]
		private LeaderboardRecord _003ClocalPlayer_003E5__3;

		[Token(Token = "0x40024A7")]
		[FieldOffset(Offset = "0x40")]
		private int _003CitemsIndex_003E5__4;

		[Token(Token = "0x1700057B")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6002AC9")]
			[Address(RVA = "0xB34120", Offset = "0xB34120", VA = "0xB34120", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700057C")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6002ACB")]
			[Address(RVA = "0xB34168", Offset = "0xB34168", VA = "0xB34168", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6002AC6")]
		[Address(RVA = "0xB33830", Offset = "0xB33830", VA = "0xB33830")]
		[DebuggerHidden]
		public _003CCreateItems_003Ed__42(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6002AC7")]
		[Address(RVA = "0xB3385C", Offset = "0xB3385C", VA = "0xB3385C", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6002AC8")]
		[Address(RVA = "0xB33860", Offset = "0xB33860", VA = "0xB33860", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6002ACA")]
		[Address(RVA = "0xB34128", Offset = "0xB34128", VA = "0xB34128", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x2000689")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x595978", Offset = "0x595978")]
	private sealed class _003CLoadPicture_003Ed__51 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40024A8")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40024A9")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40024AA")]
		[FieldOffset(Offset = "0x20")]
		public List<LeaderboardRecord> records;

		[Token(Token = "0x40024AB")]
		[FieldOffset(Offset = "0x28")]
		public LeaderboardView _003C_003E4__this;

		[Token(Token = "0x40024AC")]
		[FieldOffset(Offset = "0x30")]
		private LeaderboardRecord _003ClocalPlayer_003E5__2;

		[Token(Token = "0x40024AD")]
		[FieldOffset(Offset = "0x38")]
		private bool _003CrecordsLoaded_003E5__3;

		[Token(Token = "0x1700057D")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6002ACF")]
			[Address(RVA = "0xB34534", Offset = "0xB34534", VA = "0xB34534", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700057E")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6002AD1")]
			[Address(RVA = "0xB3457C", Offset = "0xB3457C", VA = "0xB3457C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6002ACC")]
		[Address(RVA = "0xB34170", Offset = "0xB34170", VA = "0xB34170")]
		[DebuggerHidden]
		public _003CLoadPicture_003Ed__51(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6002ACD")]
		[Address(RVA = "0xB3419C", Offset = "0xB3419C", VA = "0xB3419C", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6002ACE")]
		[Address(RVA = "0xB341A0", Offset = "0xB341A0", VA = "0xB341A0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6002AD0")]
		[Address(RVA = "0xB3453C", Offset = "0xB3453C", VA = "0xB3453C", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x4002475")]
	[FieldOffset(Offset = "0x60")]
	public UIGrid LeaderboardGrid;

	[Token(Token = "0x4002476")]
	[FieldOffset(Offset = "0x68")]
	public UIDraggablePanel LeaderboardScrollView;

	[Token(Token = "0x4002477")]
	[FieldOffset(Offset = "0x70")]
	public GameObject OfflineWarning;

	[Token(Token = "0x4002478")]
	[FieldOffset(Offset = "0x78")]
	public GameObject PlayerInactiveWarning;

	[Token(Token = "0x4002479")]
	[FieldOffset(Offset = "0x80")]
	[SerializeField]
	private GameObject _serverDownWarning;

	[Token(Token = "0x400247A")]
	[FieldOffset(Offset = "0x88")]
	public LeaderboardItem LeaderboardItemPrefab;

	[Token(Token = "0x400247B")]
	[FieldOffset(Offset = "0x90")]
	public UISprite TierBackTopBar;

	[Token(Token = "0x400247C")]
	[FieldOffset(Offset = "0x98")]
	public GameObject GlobalFilter;

	[Token(Token = "0x400247D")]
	[FieldOffset(Offset = "0xA0")]
	public UITexture TierGlobalTexture;

	[Token(Token = "0x400247E")]
	[FieldOffset(Offset = "0xA8")]
	public UILabel TierGlobalLabel;

	[Token(Token = "0x400247F")]
	[FieldOffset(Offset = "0xB0")]
	public GameObject FriendsFilter;

	[Token(Token = "0x4002480")]
	[FieldOffset(Offset = "0xB8")]
	public UITexture TierFriendsTexture;

	[Token(Token = "0x4002481")]
	[FieldOffset(Offset = "0xC0")]
	public UILabel TierFriendsLabel;

	[Token(Token = "0x4002482")]
	[FieldOffset(Offset = "0xC8")]
	public bool ShouldGenerateLeaderboardEvent;

	[Token(Token = "0x4002483")]
	[FieldOffset(Offset = "0xCC")]
	[SerializeField]
	private Vector2 _scrollViewOffset;

	[Token(Token = "0x4002484")]
	[FieldOffset(Offset = "0xD4")]
	[SerializeField]
	private Vector2 _bottomFadeNormalOffset;

	[Token(Token = "0x4002485")]
	[FieldOffset(Offset = "0xDC")]
	[SerializeField]
	private Vector2 _bottomFadeFriendsOffset;

	[Token(Token = "0x4002486")]
	[FieldOffset(Offset = "0xE8")]
	[SerializeField]
	private UIAnchor _bottomFade;

	[Token(Token = "0x4002487")]
	[FieldOffset(Offset = "0xF0")]
	[SerializeField]
	private UIWidget _friendManagementSection;

	[Token(Token = "0x4002488")]
	[FieldOffset(Offset = "0xF8")]
	[SerializeField]
	private UIWidget _rankGoalSection;

	[Token(Token = "0x4002489")]
	[FieldOffset(Offset = "0x100")]
	private readonly List<LeaderboardItem> _leaderboardsItems;

	[Token(Token = "0x400248A")]
	[FieldOffset(Offset = "0x108")]
	private LeaderboardItem _playerItem;

	[Token(Token = "0x400248B")]
	[FieldOffset(Offset = "0x110")]
	private LeaderboardConfiguration _leaderboardConfiguration;

	[Token(Token = "0x400248C")]
	[FieldOffset(Offset = "0x118")]
	private bool _started;

	[Token(Token = "0x400248D")]
	private const float STICKY_POS_Y_MIN = 0f;

	[Token(Token = "0x400248E")]
	private const float STICKY_POS_Y_MAX = 899f;

	[Token(Token = "0x400248F")]
	[FieldOffset(Offset = "0x120")]
	private readonly List<StickyObject> _stickyObjects;

	[Token(Token = "0x6002A95")]
	[Address(RVA = "0x9A733C", Offset = "0x9A733C", VA = "0x9A733C", Slot = "7")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x6002A96")]
	[Address(RVA = "0x9A7758", Offset = "0x9A7758", VA = "0x9A7758", Slot = "11")]
	protected override void OnEnable()
	{
	}

	[Token(Token = "0x6002A97")]
	[Address(RVA = "0x9A7BFC", Offset = "0x9A7BFC", VA = "0x9A7BFC", Slot = "9")]
	protected override void Start()
	{
	}

	[Token(Token = "0x6002A98")]
	[Address(RVA = "0x9A7E5C", Offset = "0x9A7E5C", VA = "0x9A7E5C", Slot = "12")]
	protected override void OnDisable()
	{
	}

	[Token(Token = "0x6002A99")]
	[Address(RVA = "0x9A7EE4", Offset = "0x9A7EE4", VA = "0x9A7EE4", Slot = "14")]
	protected override void OnVariableChanged(object sender, DataModel.VariableChangedEventArgs args)
	{
	}

	[Token(Token = "0x6002A9A")]
	[Address(RVA = "0x9A8310", Offset = "0x9A8310", VA = "0x9A8310")]
	private void OnLeaderboardTypeChanged()
	{
	}

	[Token(Token = "0x6002A9B")]
	[Address(RVA = "0x9A77F0", Offset = "0x9A77F0", VA = "0x9A77F0")]
	private void RefreshVisual()
	{
	}

	[Token(Token = "0x6002A9C")]
	[Address(RVA = "0x9A83A0", Offset = "0x9A83A0", VA = "0x9A83A0")]
	private LeaderboardConfiguration.Tier GetTierInfo(int tierIndex, out string divisionKey, out string subDivision, out Texture2D texture)
	{
		return null;
	}

	[Token(Token = "0x6002A9D")]
	[Address(RVA = "0x9A7494", Offset = "0x9A7494", VA = "0x9A7494")]
	private void OnOfflineOrServerDownWarningChanged(bool isOffline, bool isServerDown)
	{
	}

	[Token(Token = "0x6002A9E")]
	[Address(RVA = "0x9A8464", Offset = "0x9A8464", VA = "0x9A8464")]
	private void RefreshPlayerInactiveWarning()
	{
	}

	[Token(Token = "0x6002A9F")]
	[Address(RVA = "0x9A8334", Offset = "0x9A8334", VA = "0x9A8334")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x61E3F8", Offset = "0x61E3F8")]
	private IEnumerator UpdateLeaderboards()
	{
		return null;
	}

	[Token(Token = "0x6002AA0")]
	[Address(RVA = "0x9A8558", Offset = "0x9A8558", VA = "0x9A8558")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x61E458", Offset = "0x61E458")]
	private IEnumerator ResetLeaderboardItems(List<LeaderboardRecord> records)
	{
		return null;
	}

	[Token(Token = "0x6002AA1")]
	[Address(RVA = "0x9A85D0", Offset = "0x9A85D0", VA = "0x9A85D0", Slot = "6")]
	protected override void LateGameUpdate()
	{
	}

	[Token(Token = "0x6002AA2")]
	[Address(RVA = "0x9A87B0", Offset = "0x9A87B0", VA = "0x9A87B0")]
	private void AddStickyObject(LeaderboardItem item, int index)
	{
	}

	[Token(Token = "0x6002AA3")]
	[Address(RVA = "0x9A8A7C", Offset = "0x9A8A7C", VA = "0x9A8A7C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x61E4B8", Offset = "0x61E4B8")]
	private IEnumerator CreateItems(List<LeaderboardRecord> records)
	{
		return null;
	}

	[Token(Token = "0x6002AA4")]
	[Address(RVA = "0x9A8AF4", Offset = "0x9A8AF4", VA = "0x9A8AF4")]
	private LeaderboardItem CreateLeaderboardItem()
	{
		return null;
	}

	[Token(Token = "0x6002AA5")]
	[Address(RVA = "0x9A8CB0", Offset = "0x9A8CB0", VA = "0x9A8CB0")]
	private bool NeedToCreateMilestone(LeaderboardRecord localPlayer)
	{
		return default(bool);
	}

	[Token(Token = "0x6002AA6")]
	[Address(RVA = "0x9A8E4C", Offset = "0x9A8E4C", VA = "0x9A8E4C")]
	private LeaderboardItem CreateMilestoneRecord(LeaderboardRecord localPlayer)
	{
		return null;
	}

	[Token(Token = "0x6002AA7")]
	[Address(RVA = "0x9A928C", Offset = "0x9A928C", VA = "0x9A928C")]
	private bool IsRecordValid(LeaderboardRecord localPlayer, LeaderboardRecord record)
	{
		return default(bool);
	}

	[Token(Token = "0x6002AA8")]
	[Address(RVA = "0x9A8DB4", Offset = "0x9A8DB4", VA = "0x9A8DB4")]
	private int GetTierIndex(LeaderboardRecord record)
	{
		return default(int);
	}

	[Token(Token = "0x6002AA9")]
	[Address(RVA = "0x9A935C", Offset = "0x9A935C", VA = "0x9A935C")]
	private void ClearAndRealign(int itemsIndex)
	{
	}

	[Token(Token = "0x6002AAA")]
	[Address(RVA = "0x9A94FC", Offset = "0x9A94FC", VA = "0x9A94FC")]
	private void ClearUnusedSticky()
	{
	}

	[Token(Token = "0x6002AAB")]
	[Address(RVA = "0x9A9648", Offset = "0x9A9648", VA = "0x9A9648")]
	private void SetupLeaderboardItem(LeaderboardItem item, LeaderboardRecord record, int itemsIndex, bool localPlayer, int rank)
	{
	}

	[Token(Token = "0x6002AAC")]
	[Address(RVA = "0x9A9BB0", Offset = "0x9A9BB0", VA = "0x9A9BB0")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x61E518", Offset = "0x61E518")]
	private IEnumerator LoadPicture(List<LeaderboardRecord> records)
	{
		return null;
	}

	[Token(Token = "0x6002AAD")]
	[Address(RVA = "0x9A79D0", Offset = "0x9A79D0", VA = "0x9A79D0")]
	private void AlignToPlayer()
	{
	}

	[Token(Token = "0x6002AAE")]
	[Address(RVA = "0x9A9C28", Offset = "0x9A9C28", VA = "0x9A9C28")]
	private void AlignToTopEdge()
	{
	}

	[Token(Token = "0x6002AAF")]
	[Address(RVA = "0x9A74E8", Offset = "0x9A74E8", VA = "0x9A74E8")]
	private void ClearLeaderboardItemList()
	{
	}

	[Token(Token = "0x6002AB0")]
	[Address(RVA = "0x9A7C2C", Offset = "0x9A7C2C", VA = "0x9A7C2C")]
	private void AdjustStickyObjectBounds()
	{
	}

	[Token(Token = "0x6002AB1")]
	[Address(RVA = "0x9A9CE0", Offset = "0x9A9CE0", VA = "0x9A9CE0")]
	public LeaderboardView()
	{
	}
}
