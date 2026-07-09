using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using Technology.Security;
using UnityEngine;

[Token(Token = "0x2000769")]
public class TokenAccumulatedTallyScreen : View
{
	[Token(Token = "0x200076A")]
	private class ScoreItem
	{
		[Token(Token = "0x40029FC")]
		[FieldOffset(Offset = "0x10")]
		public string Title;

		[Token(Token = "0x40029FD")]
		[FieldOffset(Offset = "0x18")]
		public string Amount;

		[Token(Token = "0x40029FE")]
		[FieldOffset(Offset = "0x20")]
		public SecureLocalInt Score;

		[Token(Token = "0x6003156")]
		[Address(RVA = "0xA37ECC", Offset = "0xA37ECC", VA = "0xA37ECC")]
		public ScoreItem()
		{
		}
	}

	[Token(Token = "0x200076B")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x595FF8", Offset = "0x595FF8")]
	private sealed class _003CStartDisplayLogic_003Ed__13 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40029FF")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4002A00")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4002A01")]
		[FieldOffset(Offset = "0x20")]
		public TokenAccumulatedTallyScreen _003C_003E4__this;

		[Token(Token = "0x4002A02")]
		[FieldOffset(Offset = "0x28")]
		public ZombieScoreTallyView zombieScoreTallyView;

		[Token(Token = "0x4002A03")]
		[FieldOffset(Offset = "0x30")]
		private int _003Ci_003E5__2;

		[Token(Token = "0x1700064E")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600315A")]
			[Address(RVA = "0xA37E7C", Offset = "0xA37E7C", VA = "0xA37E7C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700064F")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600315C")]
			[Address(RVA = "0xA37EC4", Offset = "0xA37EC4", VA = "0xA37EC4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6003157")]
		[Address(RVA = "0xA37C54", Offset = "0xA37C54", VA = "0xA37C54")]
		[DebuggerHidden]
		public _003CStartDisplayLogic_003Ed__13(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6003158")]
		[Address(RVA = "0xA37C80", Offset = "0xA37C80", VA = "0xA37C80", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6003159")]
		[Address(RVA = "0xA37C84", Offset = "0xA37C84", VA = "0xA37C84", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600315B")]
		[Address(RVA = "0xA37E84", Offset = "0xA37E84", VA = "0xA37E84", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x200076C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x596008", Offset = "0x596008")]
	private sealed class _003C_003Ec__DisplayClass16_0
	{
		[Token(Token = "0x4002A04")]
		[FieldOffset(Offset = "0x10")]
		public Faction faction;

		[Token(Token = "0x4002A05")]
		[FieldOffset(Offset = "0x18")]
		public ScoreTallyView.TallyItem tallyItem;

		[Token(Token = "0x4002A06")]
		[FieldOffset(Offset = "0x20")]
		public Predicate<ScoreTallyView.TallyItem> _003C_003E9__1;

		[Token(Token = "0x600315D")]
		[Address(RVA = "0xA3757C", Offset = "0xA3757C", VA = "0xA3757C")]
		public _003C_003Ec__DisplayClass16_0()
		{
		}

		[Token(Token = "0x600315E")]
		[Address(RVA = "0xA37584", Offset = "0xA37584", VA = "0xA37584")]
		internal bool _003CAddScoreAndCount_003Eb__0(ZombieProperties.ZombieDetail x)
		{
			return default(bool);
		}

		[Token(Token = "0x600315F")]
		[Address(RVA = "0xA375A8", Offset = "0xA375A8", VA = "0xA375A8")]
		internal bool _003CAddScoreAndCount_003Eb__1(ScoreTallyView.TallyItem item)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x200076D")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x596018", Offset = "0x596018")]
	private sealed class _003CCreateScoreItemView_003Ed__18 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4002A07")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4002A08")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4002A09")]
		[FieldOffset(Offset = "0x20")]
		public GameObject scoreItemParent;

		[Token(Token = "0x4002A0A")]
		[FieldOffset(Offset = "0x28")]
		public GameObject scoreItemPrefab;

		[Token(Token = "0x4002A0B")]
		[FieldOffset(Offset = "0x30")]
		public ScoreItem scoreItem;

		[Token(Token = "0x4002A0C")]
		[FieldOffset(Offset = "0x38")]
		public TokenAccumulatedTallyScreen _003C_003E4__this;

		[Token(Token = "0x4002A0D")]
		[FieldOffset(Offset = "0x40")]
		public float getTimeMultiplier;

		[Token(Token = "0x17000650")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6003163")]
			[Address(RVA = "0xA37930", Offset = "0xA37930", VA = "0xA37930", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000651")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6003165")]
			[Address(RVA = "0xA37978", Offset = "0xA37978", VA = "0xA37978", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6003160")]
		[Address(RVA = "0xA375B8", Offset = "0xA375B8", VA = "0xA375B8")]
		[DebuggerHidden]
		public _003CCreateScoreItemView_003Ed__18(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6003161")]
		[Address(RVA = "0xA375E4", Offset = "0xA375E4", VA = "0xA375E4", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6003162")]
		[Address(RVA = "0xA375E8", Offset = "0xA375E8", VA = "0xA375E8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6003164")]
		[Address(RVA = "0xA37938", Offset = "0xA37938", VA = "0xA37938", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x200076E")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x596028", Offset = "0x596028")]
	private sealed class _003CEarnTokensAnimation_003Ed__21 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4002A0E")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4002A0F")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4002A10")]
		[FieldOffset(Offset = "0x20")]
		public TokenAccumulatedTallyScreen _003C_003E4__this;

		[Token(Token = "0x4002A11")]
		[FieldOffset(Offset = "0x28")]
		private TweenAlpha _003CtweenAlpha_003E5__2;

		[Token(Token = "0x17000652")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6003169")]
			[Address(RVA = "0xA37C04", Offset = "0xA37C04", VA = "0xA37C04", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000653")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600316B")]
			[Address(RVA = "0xA37C4C", Offset = "0xA37C4C", VA = "0xA37C4C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6003166")]
		[Address(RVA = "0xA37980", Offset = "0xA37980", VA = "0xA37980")]
		[DebuggerHidden]
		public _003CEarnTokensAnimation_003Ed__21(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6003167")]
		[Address(RVA = "0xA379AC", Offset = "0xA379AC", VA = "0xA379AC", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6003168")]
		[Address(RVA = "0xA379B0", Offset = "0xA379B0", VA = "0xA379B0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600316A")]
		[Address(RVA = "0xA37C0C", Offset = "0xA37C0C", VA = "0xA37C0C", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x40029F0")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	private UIGrid _scoreItemsUIGrid;

	[Token(Token = "0x40029F1")]
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	private GameObject _scoreItemPrefab;

	[Token(Token = "0x40029F2")]
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	private UILabel _totalTokensUILabel;

	[Token(Token = "0x40029F3")]
	[FieldOffset(Offset = "0x78")]
	[SerializeField]
	private string _totalTokensFormatString;

	[Token(Token = "0x40029F4")]
	[FieldOffset(Offset = "0x80")]
	[SerializeField]
	private Faction _zombieFaction;

	[Token(Token = "0x40029F5")]
	[FieldOffset(Offset = "0x88")]
	[SerializeField]
	private Faction _tankFaction;

	[Token(Token = "0x40029F6")]
	[FieldOffset(Offset = "0x90")]
	[SerializeField]
	private Faction _hunterFaction;

	[Token(Token = "0x40029F7")]
	[FieldOffset(Offset = "0x98")]
	[SerializeField]
	private Faction _screamerFaction;

	[Token(Token = "0x40029F8")]
	[FieldOffset(Offset = "0xA0")]
	[SerializeField]
	private GameObject _totalTokensFlourish;

	[Token(Token = "0x40029F9")]
	[FieldOffset(Offset = "0xA8")]
	private List<ScoreItem> _scoreItemList;

	[Token(Token = "0x40029FA")]
	[FieldOffset(Offset = "0xB0")]
	private SecureLocalInt _totalTokens;

	[Token(Token = "0x40029FB")]
	private const float _timeInSection = 1f;

	[Token(Token = "0x600314C")]
	[Address(RVA = "0xAD2760", Offset = "0xAD2760", VA = "0xAD2760", Slot = "7")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x600314D")]
	[Address(RVA = "0xAD2808", Offset = "0xAD2808", VA = "0xAD2808")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x621F40", Offset = "0x621F40")]
	public IEnumerator StartDisplayLogic(ZombieScoreTallyView zombieScoreTallyView)
	{
		return null;
	}

	[Token(Token = "0x600314E")]
	[Address(RVA = "0xAD2880", Offset = "0xAD2880", VA = "0xAD2880")]
	private void CreateAllScoreItem()
	{
	}

	[Token(Token = "0x600314F")]
	[Address(RVA = "0xAD2AB8", Offset = "0xAD2AB8", VA = "0xAD2AB8")]
	private void CreateChainScoreItem(string title, ScoreTallyView.TallyItem tallyItem, Faction faction)
	{
	}

	[Token(Token = "0x6003150")]
	[Address(RVA = "0xAD2C3C", Offset = "0xAD2C3C", VA = "0xAD2C3C")]
	private void AddScoreAndCount(ScoreTallyView.TallyItem tallyItem, Faction faction, ref int score, ref int totalCount)
	{
	}

	[Token(Token = "0x6003151")]
	[Address(RVA = "0xAD2B68", Offset = "0xAD2B68", VA = "0xAD2B68")]
	private void CreateScoreItem(string title, string amount, int score)
	{
	}

	[Token(Token = "0x6003152")]
	[Address(RVA = "0xAD3080", Offset = "0xAD3080", VA = "0xAD3080")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x621FA0", Offset = "0x621FA0")]
	private IEnumerator CreateScoreItemView(ScoreItem scoreItem, GameObject scoreItemParent, GameObject scoreItemPrefab, float getTimeMultiplier)
	{
		return null;
	}

	[Token(Token = "0x6003153")]
	[Address(RVA = "0xAD311C", Offset = "0xAD311C", VA = "0xAD311C")]
	private void TotalTokensChanged(int value, float getTimeMultiplier)
	{
	}

	[Token(Token = "0x6003154")]
	[Address(RVA = "0xAD31E4", Offset = "0xAD31E4", VA = "0xAD31E4")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x622000", Offset = "0x622000")]
	private IEnumerator EarnTokensAnimation()
	{
		return null;
	}

	[Token(Token = "0x6003155")]
	[Address(RVA = "0xAD3250", Offset = "0xAD3250", VA = "0xAD3250")]
	public TokenAccumulatedTallyScreen()
	{
	}
}
