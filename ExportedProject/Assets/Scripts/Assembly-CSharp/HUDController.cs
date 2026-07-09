using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using Technology.Social;
using UnityEngine;

[Token(Token = "0x200051A")]
public class HUDController : UIController
{
	[Serializable]
	[Token(Token = "0x200051B")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x594FAC", Offset = "0x594FAC")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x4001AFD")]
		[FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x4001AFE")]
		[FieldOffset(Offset = "0x8")]
		public static Predicate<LeaderboardRecord> _003C_003E9__26_0;

		[Token(Token = "0x4001AFF")]
		[FieldOffset(Offset = "0x10")]
		public static Func<LeaderboardRecord, bool> _003C_003E9__26_1;

		[Token(Token = "0x6001F93")]
		[Address(RVA = "0xB1E4C8", Offset = "0xB1E4C8", VA = "0xB1E4C8")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x6001F94")]
		[Address(RVA = "0xB1E4D0", Offset = "0xB1E4D0", VA = "0xB1E4D0")]
		internal bool _003CUpdateLeaderboards_003Eb__26_0(LeaderboardRecord r)
		{
			return default(bool);
		}

		[Token(Token = "0x6001F95")]
		[Address(RVA = "0xB1E4EC", Offset = "0xB1E4EC", VA = "0xB1E4EC")]
		internal bool _003CUpdateLeaderboards_003Eb__26_1(LeaderboardRecord r)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x200051C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x594FBC", Offset = "0x594FBC")]
	private sealed class _003CUpdateLeaderboards_003Ed__26 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4001B00")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4001B01")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4001B02")]
		[FieldOffset(Offset = "0x20")]
		public HUDController _003C_003E4__this;

		[Token(Token = "0x4001B03")]
		[FieldOffset(Offset = "0x28")]
		private LeaderboardRecord _003CrivalPlayer_003E5__2;

		[Token(Token = "0x170004D1")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6001F99")]
			[Address(RVA = "0xB1EA18", Offset = "0xB1EA18", VA = "0xB1EA18", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170004D2")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6001F9B")]
			[Address(RVA = "0xB1EA60", Offset = "0xB1EA60", VA = "0xB1EA60", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6001F96")]
		[Address(RVA = "0xB1E590", Offset = "0xB1E590", VA = "0xB1E590")]
		[DebuggerHidden]
		public _003CUpdateLeaderboards_003Ed__26(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6001F97")]
		[Address(RVA = "0xB1E5BC", Offset = "0xB1E5BC", VA = "0xB1E5BC", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6001F98")]
		[Address(RVA = "0xB1E5C0", Offset = "0xB1E5C0", VA = "0xB1E5C0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6001F9A")]
		[Address(RVA = "0xB1EA20", Offset = "0xB1EA20", VA = "0xB1EA20", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x200051D")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x594FCC", Offset = "0x594FCC")]
	private sealed class _003C_003Ec__DisplayClass27_0
	{
		[Token(Token = "0x4001B04")]
		[FieldOffset(Offset = "0x10")]
		public int currentScore;

		[Token(Token = "0x6001F9C")]
		[Address(RVA = "0xB1E534", Offset = "0xB1E534", VA = "0xB1E534")]
		public _003C_003Ec__DisplayClass27_0()
		{
		}

		[Token(Token = "0x6001F9D")]
		[Address(RVA = "0xB1E53C", Offset = "0xB1E53C", VA = "0xB1E53C")]
		internal bool _003CGameUpdate_003Eb__0(LeaderboardRecord r)
		{
			return default(bool);
		}

		[Token(Token = "0x6001F9E")]
		[Address(RVA = "0xB1E56C", Offset = "0xB1E56C", VA = "0xB1E56C")]
		internal bool _003CGameUpdate_003Eb__1(LeaderboardRecord r)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x4001AF1")]
	[FieldOffset(Offset = "0x50")]
	public ButtonHandler ReloadButton;

	[Token(Token = "0x4001AF2")]
	[FieldOffset(Offset = "0x58")]
	public BlinkButtonHandler ScorePanel;

	[Token(Token = "0x4001AF3")]
	[FieldOffset(Offset = "0x60")]
	public ButtonHandler ShootButton;

	[Token(Token = "0x4001AF4")]
	[FieldOffset(Offset = "0x68")]
	private List<LeaderboardRecord> _records;

	[Token(Token = "0x4001AF5")]
	[FieldOffset(Offset = "0x70")]
	private bool _updatingNextScoreToBeat;

	[Token(Token = "0x4001AF6")]
	[FieldOffset(Offset = "0x71")]
	private bool _scoreBeatenEventSent;

	[Token(Token = "0x4001AF7")]
	[FieldOffset(Offset = "0x78")]
	private GameTimer _gameTimer;

	[Token(Token = "0x4001AF8")]
	[FieldOffset(Offset = "0x80")]
	private float _missionDuration;

	[Token(Token = "0x4001AF9")]
	[FieldOffset(Offset = "0x88")]
	private readonly GameTimer _scoreToBeatTimer;

	[Token(Token = "0x4001AFA")]
	[FieldOffset(Offset = "0x90")]
	public GameObject PauseMenu;

	[Token(Token = "0x14000082")]
	public static event EventHandler OnRivalBeaten
	{
		[Token(Token = "0x6001F7B")]
		[Address(RVA = "0xC906B8", Offset = "0xC906B8", VA = "0xC906B8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x619148", Offset = "0x619148")]
		add
		{
		}
		[Token(Token = "0x6001F7C")]
		[Address(RVA = "0xC90774", Offset = "0xC90774", VA = "0xC90774")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x619158", Offset = "0x619158")]
		remove
		{
		}
	}

	[Token(Token = "0x14000083")]
	public static event EventHandler OnScorePanelClicked
	{
		[Token(Token = "0x6001F7D")]
		[Address(RVA = "0xC90830", Offset = "0xC90830", VA = "0xC90830")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x619168", Offset = "0x619168")]
		add
		{
		}
		[Token(Token = "0x6001F7E")]
		[Address(RVA = "0xC908F0", Offset = "0xC908F0", VA = "0xC908F0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x619178", Offset = "0x619178")]
		remove
		{
		}
	}

	[Token(Token = "0x6001F7F")]
	[Address(RVA = "0xC909B0", Offset = "0xC909B0", VA = "0xC909B0", Slot = "7")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x6001F80")]
	[Address(RVA = "0xC90BB0", Offset = "0xC90BB0", VA = "0xC90BB0", Slot = "10")]
	protected override void OnDestroy()
	{
	}

	[Token(Token = "0x6001F81")]
	[Address(RVA = "0xC90CA8", Offset = "0xC90CA8", VA = "0xC90CA8", Slot = "9")]
	protected override void Start()
	{
	}

	[Token(Token = "0x6001F82")]
	[Address(RVA = "0xC90F34", Offset = "0xC90F34", VA = "0xC90F34", Slot = "11")]
	protected override void OnEnable()
	{
	}

	[Token(Token = "0x6001F83")]
	[Address(RVA = "0xC91444", Offset = "0xC91444", VA = "0xC91444", Slot = "12")]
	protected override void OnDisable()
	{
	}

	[Token(Token = "0x6001F84")]
	[Address(RVA = "0xC916D0", Offset = "0xC916D0", VA = "0xC916D0")]
	private void OnVariableChanged(object sender, DataModel.VariableChangedEventArgs args)
	{
	}

	[Token(Token = "0x6001F85")]
	[Address(RVA = "0xC91384", Offset = "0xC91384", VA = "0xC91384")]
	private static void OnChangeShootIconsSide(bool iconsOnLeft)
	{
	}

	[Token(Token = "0x6001F86")]
	[Address(RVA = "0xC9124C", Offset = "0xC9124C", VA = "0xC9124C")]
	private void OnScopeStateChanged(bool inScope)
	{
	}

	[Token(Token = "0x6001F87")]
	[Address(RVA = "0xC91A58", Offset = "0xC91A58", VA = "0xC91A58")]
	private void OnScoreChanged(int value)
	{
	}

	[Token(Token = "0x6001F88")]
	[Address(RVA = "0xC91B94", Offset = "0xC91B94", VA = "0xC91B94")]
	private void UpdateNextScoreToBeat()
	{
	}

	[Token(Token = "0x6001F89")]
	[Address(RVA = "0xC91C2C", Offset = "0xC91C2C", VA = "0xC91C2C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x619188", Offset = "0x619188")]
	private IEnumerator UpdateLeaderboards()
	{
		return null;
	}

	[Token(Token = "0x6001F8A")]
	[Address(RVA = "0xC91C98", Offset = "0xC91C98", VA = "0xC91C98", Slot = "5")]
	protected override void GameUpdate()
	{
	}

	[Token(Token = "0x6001F8B")]
	[Address(RVA = "0xC920B4", Offset = "0xC920B4", VA = "0xC920B4")]
	private void OnReloadButtonClicked(object sender, ButtonHandler.ButtonHandlerEventArgs args)
	{
	}

	[Token(Token = "0x6001F8C")]
	[Address(RVA = "0xC92168", Offset = "0xC92168", VA = "0xC92168")]
	private void OnScorePanelClickFinished(object sender, BlinkButtonHandler.ButtonBlinkFinishedHandlerEventArgs args)
	{
	}

	[Token(Token = "0x6001F8D")]
	[Address(RVA = "0xC922B4", Offset = "0xC922B4", VA = "0xC922B4")]
	private void ChangeShowScoreToBeatValue()
	{
	}

	[Token(Token = "0x6001F8E")]
	[Address(RVA = "0xC92378", Offset = "0xC92378", VA = "0xC92378")]
	private void OnShootButtonClicked(object sender, ButtonHandler.ButtonHandlerEventArgs args)
	{
	}

	[Token(Token = "0x6001F8F")]
	[Address(RVA = "0xC91EF8", Offset = "0xC91EF8", VA = "0xC91EF8")]
	private void CheckTimer()
	{
	}

	[Token(Token = "0x6001F90")]
	[Address(RVA = "0xC923EC", Offset = "0xC923EC", VA = "0xC923EC")]
	private void OnContractEnded(object sender, ContractEndedArgs e)
	{
	}

	[Token(Token = "0x6001F91")]
	[Address(RVA = "0xC92408", Offset = "0xC92408", VA = "0xC92408")]
	public HUDController()
	{
	}
}
