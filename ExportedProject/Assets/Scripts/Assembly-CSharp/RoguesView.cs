using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000745")]
public class RoguesView : MainMenuPageView
{
	[Serializable]
	[Token(Token = "0x2000746")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x595F18", Offset = "0x595F18")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x400293A")]
		[FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x400293B")]
		[FieldOffset(Offset = "0x8")]
		public static Func<RogueRewardIcon, bool> _003C_003E9__26_0;

		[Token(Token = "0x400293C")]
		[FieldOffset(Offset = "0x10")]
		public static Func<RogueData, int> _003C_003E9__33_0;

		[Token(Token = "0x400293D")]
		[FieldOffset(Offset = "0x18")]
		public static Func<RogueInfoView, bool> _003C_003E9__34_0;

		[Token(Token = "0x400293E")]
		[FieldOffset(Offset = "0x20")]
		public static Action<RogueRewardIcon> _003C_003E9__37_0;

		[Token(Token = "0x60030A4")]
		[Address(RVA = "0x8B50C0", Offset = "0x8B50C0", VA = "0x8B50C0")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x60030A5")]
		[Address(RVA = "0x8B50C8", Offset = "0x8B50C8", VA = "0x8B50C8")]
		internal bool _003CStart_003Eb__26_0(RogueRewardIcon r)
		{
			return default(bool);
		}

		[Token(Token = "0x60030A6")]
		[Address(RVA = "0x8B50F4", Offset = "0x8B50F4", VA = "0x8B50F4")]
		internal int _003CPopulateRoguesList_003Eb__33_0(RogueData rogue)
		{
			return default(int);
		}

		[Token(Token = "0x60030A7")]
		[Address(RVA = "0x8B510C", Offset = "0x8B510C", VA = "0x8B510C")]
		internal bool _003CRefreshNewFeedback_003Eb__34_0(RogueInfoView rogue)
		{
			return default(bool);
		}

		[Token(Token = "0x60030A8")]
		[Address(RVA = "0x8B519C", Offset = "0x8B519C", VA = "0x8B519C")]
		internal void _003CUpdateRewardGrid_003Eb__37_0(RogueRewardIcon reward)
		{
		}
	}

	[Token(Token = "0x2000747")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x595F28", Offset = "0x595F28")]
	private sealed class _003CRogueTransition_003Ed__44 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400293F")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4002940")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4002941")]
		[FieldOffset(Offset = "0x20")]
		public RoguesView _003C_003E4__this;

		[Token(Token = "0x4002942")]
		[FieldOffset(Offset = "0x28")]
		private ContinuousTimer _003Ctimer_003E5__2;

		[Token(Token = "0x1700063B")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60030AC")]
			[Address(RVA = "0x8B5934", Offset = "0x8B5934", VA = "0x8B5934", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700063C")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60030AE")]
			[Address(RVA = "0x8B597C", Offset = "0x8B597C", VA = "0x8B597C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60030A9")]
		[Address(RVA = "0x8B5734", Offset = "0x8B5734", VA = "0x8B5734")]
		[DebuggerHidden]
		public _003CRogueTransition_003Ed__44(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60030AA")]
		[Address(RVA = "0x8B5760", Offset = "0x8B5760", VA = "0x8B5760", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60030AB")]
		[Address(RVA = "0x8B5764", Offset = "0x8B5764", VA = "0x8B5764", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60030AD")]
		[Address(RVA = "0x8B593C", Offset = "0x8B593C", VA = "0x8B593C", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x2000748")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x595F38", Offset = "0x595F38")]
	private sealed class _003C_003Ec__DisplayClass46_0
	{
		[Token(Token = "0x4002943")]
		[FieldOffset(Offset = "0x10")]
		public UILabel scoreLabel;

		[Token(Token = "0x4002944")]
		[FieldOffset(Offset = "0x18")]
		public RoguesView _003C_003E4__this;

		[Token(Token = "0x60030AF")]
		[Address(RVA = "0x8B52AC", Offset = "0x8B52AC", VA = "0x8B52AC")]
		public _003C_003Ec__DisplayClass46_0()
		{
		}

		[Token(Token = "0x60030B0")]
		[Address(RVA = "0x8B52B4", Offset = "0x8B52B4", VA = "0x8B52B4")]
		internal void _003CFirstTargetTutorialTargetPageCentered_003Eb__0()
		{
		}
	}

	[Token(Token = "0x2000749")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x595F48", Offset = "0x595F48")]
	private sealed class _003C_003Ec__DisplayClass47_0
	{
		[Token(Token = "0x4002945")]
		[FieldOffset(Offset = "0x10")]
		public BlueprintPartIconView partView;

		[Token(Token = "0x4002946")]
		[FieldOffset(Offset = "0x18")]
		public RoguesView _003C_003E4__this;

		[Token(Token = "0x60030B1")]
		[Address(RVA = "0x8B54EC", Offset = "0x8B54EC", VA = "0x8B54EC")]
		public _003C_003Ec__DisplayClass47_0()
		{
		}

		[Token(Token = "0x60030B2")]
		[Address(RVA = "0x8B54F4", Offset = "0x8B54F4", VA = "0x8B54F4")]
		internal void _003CCloseTargetScoreTutorial_003Eb__0()
		{
		}
	}

	[Token(Token = "0x4002924")]
	[FieldOffset(Offset = "0x0")]
	private static readonly int MAX_REWARDS;

	[Token(Token = "0x4002925")]
	[FieldOffset(Offset = "0x4")]
	private static readonly int NEW_TARGET_REWARD_TUTORIAL_ID;

	[Token(Token = "0x4002926")]
	[FieldOffset(Offset = "0x8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BA528", Offset = "0x5BA528")]
	private static RoguesView _003CInstance_003Ek__BackingField;

	[Token(Token = "0x4002927")]
	[FieldOffset(Offset = "0x98")]
	public RogueRewardIcon RewardIconPrefab;

	[Token(Token = "0x4002928")]
	[FieldOffset(Offset = "0xA0")]
	public RogueInfoView RogueInfoPrefab;

	[Token(Token = "0x4002929")]
	[FieldOffset(Offset = "0xA8")]
	public UIPanel InfoPanel;

	[Token(Token = "0x400292A")]
	[FieldOffset(Offset = "0xB0")]
	public UILabel RogueName;

	[Token(Token = "0x400292B")]
	[FieldOffset(Offset = "0xB8")]
	public UIGrid RewardGrid;

	[Token(Token = "0x400292C")]
	[FieldOffset(Offset = "0xC0")]
	public UITexture Picture;

	[Token(Token = "0x400292D")]
	[FieldOffset(Offset = "0xC8")]
	public UIDraggablePanel RoguesPanel;

	[Token(Token = "0x400292E")]
	[FieldOffset(Offset = "0xD0")]
	public UIGrid RoguesGrid;

	[Token(Token = "0x400292F")]
	[FieldOffset(Offset = "0xD8")]
	public float FadeDuration;

	[Token(Token = "0x4002930")]
	[FieldOffset(Offset = "0xE0")]
	public UISprite LeftArrow;

	[Token(Token = "0x4002931")]
	[FieldOffset(Offset = "0xE8")]
	public UISprite RightArrow;

	[Token(Token = "0x4002932")]
	[FieldOffset(Offset = "0xF0")]
	public UIAlignChildOnPanelEdges UIAlignChildOnPanelEdges;

	[Token(Token = "0x4002933")]
	[FieldOffset(Offset = "0xF8")]
	private RogueInfoView _currentRogue;

	[Token(Token = "0x4002934")]
	[FieldOffset(Offset = "0x100")]
	private readonly List<RogueInfoView> _rogueViews;

	[Token(Token = "0x4002935")]
	[FieldOffset(Offset = "0x108")]
	private readonly List<RogueRewardIcon> _rewards;

	[Token(Token = "0x4002936")]
	[FieldOffset(Offset = "0x110")]
	private int _cachedNumMissionsCompleted;

	[Token(Token = "0x4002937")]
	[FieldOffset(Offset = "0x118")]
	private Coroutine _infoPanelAnimation;

	[Token(Token = "0x4002938")]
	[FieldOffset(Offset = "0x120")]
	private bool _isStarted;

	[Token(Token = "0x4002939")]
	[FieldOffset(Offset = "0x128")]
	private RogueData _forceSelectedRogue;

	[Token(Token = "0x1700063A")]
	public static RoguesView Instance
	{
		[Token(Token = "0x6003082")]
		[Address(RVA = "0x973C40", Offset = "0x973C40", VA = "0x973C40")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x621A90", Offset = "0x621A90")]
		get
		{
			return null;
		}
		[Token(Token = "0x6003083")]
		[Address(RVA = "0x973CA4", Offset = "0x973CA4", VA = "0x973CA4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x621AA0", Offset = "0x621AA0")]
		private set
		{
		}
	}

	[Token(Token = "0x6003084")]
	[Address(RVA = "0x973D0C", Offset = "0x973D0C", VA = "0x973D0C", Slot = "7")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x6003085")]
	[Address(RVA = "0x973DBC", Offset = "0x973DBC", VA = "0x973DBC", Slot = "9")]
	protected override void Start()
	{
	}

	[Token(Token = "0x6003086")]
	[Address(RVA = "0x974DD8", Offset = "0x974DD8", VA = "0x974DD8", Slot = "11")]
	protected override void OnEnable()
	{
	}

	[Token(Token = "0x6003087")]
	[Address(RVA = "0x974FC0", Offset = "0x974FC0", VA = "0x974FC0", Slot = "12")]
	protected override void OnDisable()
	{
	}

	[Token(Token = "0x6003088")]
	[Address(RVA = "0x975124", Offset = "0x975124", VA = "0x975124", Slot = "10")]
	protected override void OnDestroy()
	{
	}

	[Token(Token = "0x6003089")]
	[Address(RVA = "0x97481C", Offset = "0x97481C", VA = "0x97481C")]
	private void ForceSelectedRogue(RogueData rogueData)
	{
	}

	[Token(Token = "0x600308A")]
	[Address(RVA = "0x97534C", Offset = "0x97534C", VA = "0x97534C")]
	private void OnPageCentered(object sender, EventArgs args)
	{
	}

	[Token(Token = "0x600308B")]
	[Address(RVA = "0x975350", Offset = "0x975350", VA = "0x975350")]
	private void SetNewFeedbackSeen()
	{
	}

	[Token(Token = "0x600308C")]
	[Address(RVA = "0x973F3C", Offset = "0x973F3C", VA = "0x973F3C")]
	public void PopulateRoguesList()
	{
	}

	[Token(Token = "0x600308D")]
	[Address(RVA = "0x975528", Offset = "0x975528", VA = "0x975528")]
	public void RefreshNewFeedback()
	{
	}

	[Token(Token = "0x600308E")]
	[Address(RVA = "0x974970", Offset = "0x974970", VA = "0x974970")]
	public void UpdateCurrentRogue()
	{
	}

	[Token(Token = "0x600308F")]
	[Address(RVA = "0x974C7C", Offset = "0x974C7C", VA = "0x974C7C")]
	private void ForceRogueIntelLoad()
	{
	}

	[Token(Token = "0x6003090")]
	[Address(RVA = "0x97566C", Offset = "0x97566C", VA = "0x97566C")]
	private void UpdateRewardGrid()
	{
	}

	[Token(Token = "0x6003091")]
	[Address(RVA = "0x975E0C", Offset = "0x975E0C", VA = "0x975E0C")]
	private void UpdateRewardAvailability()
	{
	}

	[Token(Token = "0x6003092")]
	private static void PopulateObjectsAndResizeGrid<T>(UIGrid grid, T objectPrefab, List<T> objectList, int numObjectsDesired) where T : Component
	{
	}

	[Token(Token = "0x6003093")]
	[Address(RVA = "0x976304", Offset = "0x976304", VA = "0x976304")]
	private void Update()
	{
	}

	[Token(Token = "0x6003094")]
	[Address(RVA = "0x9765F8", Offset = "0x9765F8", VA = "0x9765F8")]
	public void SwitchToRogue(RogueData rogue)
	{
	}

	[Token(Token = "0x6003095")]
	[Address(RVA = "0x972E04", Offset = "0x972E04", VA = "0x972E04")]
	public void ChangeSelectedRogue(RogueInfoView view)
	{
	}

	[Token(Token = "0x6003096")]
	[Address(RVA = "0x974F64", Offset = "0x974F64", VA = "0x974F64")]
	private void StartRogueTransition()
	{
	}

	[Token(Token = "0x6003097")]
	[Address(RVA = "0x976700", Offset = "0x976700", VA = "0x976700")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x621AB0", Offset = "0x621AB0")]
	private IEnumerator RogueTransition()
	{
		return null;
	}

	[Token(Token = "0x6003098")]
	[Address(RVA = "0x97676C", Offset = "0x97676C", VA = "0x97676C")]
	public void UnlockIntelForUnlockedRogues()
	{
	}

	[Token(Token = "0x6003099")]
	[Address(RVA = "0x976914", Offset = "0x976914", VA = "0x976914")]
	public void FirstTargetTutorialTargetPageCentered(object sender, EventArgs args)
	{
	}

	[Token(Token = "0x600309A")]
	[Address(RVA = "0x976CE4", Offset = "0x976CE4", VA = "0x976CE4")]
	public void CloseTargetScoreTutorial(object sender, EventArgs args)
	{
	}

	[Token(Token = "0x600309B")]
	[Address(RVA = "0x977088", Offset = "0x977088", VA = "0x977088")]
	private void OnPartViewTooltipPressed(object sender, EventArgs e)
	{
	}

	[Token(Token = "0x600309C")]
	[Address(RVA = "0x9770B8", Offset = "0x9770B8", VA = "0x9770B8")]
	public void CloseTargetRewardTutorial(object sender, EventArgs args)
	{
	}

	[Token(Token = "0x600309D")]
	[Address(RVA = "0x9773C4", Offset = "0x9773C4", VA = "0x9773C4")]
	private void OnLanguageChanged(object sender, EventArgs e)
	{
	}

	[Token(Token = "0x600309E")]
	[Address(RVA = "0x97740C", Offset = "0x97740C", VA = "0x97740C")]
	public RoguesView()
	{
	}

	[Token(Token = "0x60030A0")]
	[Address(RVA = "0x97752C", Offset = "0x97752C", VA = "0x97752C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x621B10", Offset = "0x621B10")]
	private void _003CPopulateRoguesList_003Eb__33_1()
	{
	}

	[Token(Token = "0x60030A1")]
	[Address(RVA = "0x97754C", Offset = "0x97754C", VA = "0x97754C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x621B20", Offset = "0x621B20")]
	private void _003CFirstTargetTutorialTargetPageCentered_003Eb__46_1(object _003Cp0_003E, ButtonHandler.ButtonHandlerEventArgs _003Cp1_003E)
	{
	}

	[Token(Token = "0x60030A2")]
	[Address(RVA = "0x977550", Offset = "0x977550", VA = "0x977550")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x621B30", Offset = "0x621B30")]
	private void _003CCloseTargetScoreTutorial_003Eb__47_1(object _003Cp0_003E, ButtonHandler.ButtonHandlerEventArgs _003Cp1_003E)
	{
	}
}
