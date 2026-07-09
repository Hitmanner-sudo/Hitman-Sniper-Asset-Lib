using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using Technology;
using Technology.Security;
using UnityEngine;

[Token(Token = "0x2000291")]
[Scope]
public class ScoreManager : GameSingleton<ScoreManager>
{
	[Token(Token = "0x2000292")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x592F80", Offset = "0x592F80")]
	private sealed class _003CGameEndComputing_003Ed__21 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000E76")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4000E77")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4000E78")]
		[FieldOffset(Offset = "0x20")]
		public ScoreManager _003C_003E4__this;

		[Token(Token = "0x4000E79")]
		[FieldOffset(Offset = "0x28")]
		private bool _003Csuccess_003E5__2;

		[Token(Token = "0x4000E7A")]
		[FieldOffset(Offset = "0x30")]
		private ContractData _003CcurrentContract_003E5__3;

		[Token(Token = "0x17000266")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6000F93")]
			[Address(RVA = "0x8B83D8", Offset = "0x8B83D8", VA = "0x8B83D8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000267")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6000F95")]
			[Address(RVA = "0x8B8420", Offset = "0x8B8420", VA = "0x8B8420", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000F90")]
		[Address(RVA = "0x8B7FCC", Offset = "0x8B7FCC", VA = "0x8B7FCC")]
		[DebuggerHidden]
		public _003CGameEndComputing_003Ed__21(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6000F91")]
		[Address(RVA = "0x8B7FF8", Offset = "0x8B7FF8", VA = "0x8B7FF8", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6000F92")]
		[Address(RVA = "0x8B7FFC", Offset = "0x8B7FFC", VA = "0x8B7FFC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000F94")]
		[Address(RVA = "0x8B83E0", Offset = "0x8B83E0", VA = "0x8B83E0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x4000E72")]
	[FieldOffset(Offset = "0x50")]
	public ModelContainer ModelContainer;

	[NonSerialized]
	[Token(Token = "0x4000E73")]
	[FieldOffset(Offset = "0x58")]
	public Texture2D KillScreenShot;

	[Token(Token = "0x4000E74")]
	[FieldOffset(Offset = "0x60")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5B3A54", Offset = "0x5B3A54")]
	private bool _003CIgnoreScoreChange_003Ek__BackingField;

	[Token(Token = "0x4000E75")]
	[FieldOffset(Offset = "0x68")]
	private readonly SecureLocalInt _gameScore;

	[Token(Token = "0x17000264")]
	public bool IgnoreScoreChange
	{
		[Token(Token = "0x6000F7F")]
		[Address(RVA = "0xBB7AC8", Offset = "0xBB7AC8", VA = "0xBB7AC8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6154C4", Offset = "0x6154C4")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000F80")]
		[Address(RVA = "0xBB7AD0", Offset = "0xBB7AD0", VA = "0xBB7AD0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6154D4", Offset = "0x6154D4")]
		private set
		{
		}
	}

	[Token(Token = "0x17000265")]
	public int GameScore
	{
		[Token(Token = "0x6000F81")]
		[Address(RVA = "0xBB7ADC", Offset = "0xBB7ADC", VA = "0xBB7ADC")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6000F82")]
		[Address(RVA = "0xBB7AF8", Offset = "0xBB7AF8", VA = "0xBB7AF8")]
		private set
		{
		}
	}

	[Token(Token = "0x1400003E")]
	public event EventHandler<ScoreChangedEventArgs> ScoreChanged
	{
		[Token(Token = "0x6000F7B")]
		[Address(RVA = "0xBB7810", Offset = "0xBB7810", VA = "0xBB7810")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x615484", Offset = "0x615484")]
		add
		{
		}
		[Token(Token = "0x6000F7C")]
		[Address(RVA = "0xBB78B0", Offset = "0xBB78B0", VA = "0xBB78B0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x615494", Offset = "0x615494")]
		remove
		{
		}
	}

	[Token(Token = "0x1400003F")]
	public static event EventHandler<FinalScoreEventArgs> FinalScoreTallied
	{
		[Token(Token = "0x6000F7D")]
		[Address(RVA = "0xBB7950", Offset = "0xBB7950", VA = "0xBB7950")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6154A4", Offset = "0x6154A4")]
		add
		{
		}
		[Token(Token = "0x6000F7E")]
		[Address(RVA = "0xBB7A0C", Offset = "0xBB7A0C", VA = "0xBB7A0C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6154B4", Offset = "0x6154B4")]
		remove
		{
		}
	}

	[Token(Token = "0x6000F83")]
	[Address(RVA = "0xBB7B98", Offset = "0xBB7B98", VA = "0xBB7B98", Slot = "9")]
	protected override void Start()
	{
	}

	[Token(Token = "0x6000F84")]
	[Address(RVA = "0xBB7E08", Offset = "0xBB7E08", VA = "0xBB7E08", Slot = "10")]
	protected override void OnDestroy()
	{
	}

	[Token(Token = "0x6000F85")]
	[Address(RVA = "0xBB7FB4", Offset = "0xBB7FB4", VA = "0xBB7FB4")]
	private void OnDied(object sender, Character.DeathEvent e)
	{
	}

	[Token(Token = "0x6000F86")]
	[Address(RVA = "0xBB8058", Offset = "0xBB8058", VA = "0xBB8058")]
	private void OnContractEnded(object sender, EventArgs e)
	{
	}

	[Token(Token = "0x6000F87")]
	[Address(RVA = "0xBB816C", Offset = "0xBB816C", VA = "0xBB816C")]
	private void OnGameEnded(object sender, EventArgs e)
	{
	}

	[Token(Token = "0x6000F88")]
	[Address(RVA = "0xBB81A0", Offset = "0xBB81A0", VA = "0xBB81A0")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x6154E4", Offset = "0x6154E4")]
	private IEnumerator GameEndComputing()
	{
		return null;
	}

	[Token(Token = "0x6000F89")]
	[Address(RVA = "0xBB820C", Offset = "0xBB820C", VA = "0xBB820C")]
	public void ShowScoreTextOnly(string desc)
	{
	}

	[Token(Token = "0x6000F8A")]
	[Address(RVA = "0xBB82F0", Offset = "0xBB82F0", VA = "0xBB82F0")]
	public void ApplyScore(int score, string desc, bool isScaredKill = false)
	{
	}

	[Token(Token = "0x6000F8B")]
	[Address(RVA = "0xBB84B8", Offset = "0xBB84B8", VA = "0xBB84B8")]
	public void ApplyCurrency(int currency, Wallet.Currency currencyType, string desc)
	{
	}

	[Token(Token = "0x6000F8C")]
	[Address(RVA = "0xBB8660", Offset = "0xBB8660", VA = "0xBB8660")]
	private void ApplyCompletionBonus()
	{
	}

	[Token(Token = "0x6000F8D")]
	[Address(RVA = "0xBB8B44", Offset = "0xBB8B44", VA = "0xBB8B44")]
	private void ResetCompletionReward()
	{
	}

	[Token(Token = "0x6000F8E")]
	[Address(RVA = "0xBB8CF0", Offset = "0xBB8CF0", VA = "0xBB8CF0")]
	public ScoreManager()
	{
	}

	[Token(Token = "0x6000F8F")]
	[Address(RVA = "0xBB8D98", Offset = "0xBB8D98", VA = "0xBB8D98")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x615544", Offset = "0x615544")]
	private FinalScoreEventArgs _003CGameEndComputing_003Eb__21_0()
	{
		return null;
	}
}
