using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using Technology;
using UnityEngine;

[Token(Token = "0x200061F")]
public class ScoreAnimation : GameMonoBehaviour
{
	[Serializable]
	[Token(Token = "0x2000620")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x595610", Offset = "0x595610")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x40021F0")]
		[FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x40021F1")]
		[FieldOffset(Offset = "0x8")]
		public static Action<UITweener> _003C_003E9__50_0;

		[Token(Token = "0x40021F2")]
		[FieldOffset(Offset = "0x10")]
		public static Action<UITweener> _003C_003E9__50_1;

		[Token(Token = "0x40021F3")]
		[FieldOffset(Offset = "0x18")]
		public static Action<SingleCharacterGlow> _003C_003E9__71_0;

		[Token(Token = "0x40021F4")]
		[FieldOffset(Offset = "0x20")]
		public static Action<UITweener> _003C_003E9__74_0;

		[Token(Token = "0x40021F5")]
		[FieldOffset(Offset = "0x28")]
		public static Action<UITweener> _003C_003E9__75_0;

		[Token(Token = "0x60027D4")]
		[Address(RVA = "0x8B6BE0", Offset = "0x8B6BE0", VA = "0x8B6BE0")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x60027D5")]
		[Address(RVA = "0x8B6BE8", Offset = "0x8B6BE8", VA = "0x8B6BE8")]
		internal void _003COnEnable_003Eb__50_0(UITweener tw)
		{
		}

		[Token(Token = "0x60027D6")]
		[Address(RVA = "0x8B6C18", Offset = "0x8B6C18", VA = "0x8B6C18")]
		internal void _003COnEnable_003Eb__50_1(UITweener tw)
		{
		}

		[Token(Token = "0x60027D7")]
		[Address(RVA = "0x8B6C48", Offset = "0x8B6C48", VA = "0x8B6C48")]
		internal void _003COnScoreGlowFaded_003Eb__71_0(SingleCharacterGlow l)
		{
		}

		[Token(Token = "0x60027D8")]
		[Address(RVA = "0x8B6CE4", Offset = "0x8B6CE4", VA = "0x8B6CE4")]
		internal void _003COnStartChangeRival_003Eb__74_0(UITweener t)
		{
		}

		[Token(Token = "0x60027D9")]
		[Address(RVA = "0x8B6D14", Offset = "0x8B6D14", VA = "0x8B6D14")]
		internal void _003COnRivalChangedCompleted_003Eb__75_0(UITweener t)
		{
		}
	}

	[Token(Token = "0x2000621")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x595620", Offset = "0x595620")]
	private sealed class _003CScoreChangedAnimation_003Ed__56 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40021F6")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40021F7")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40021F8")]
		[FieldOffset(Offset = "0x20")]
		public ScoreAnimation _003C_003E4__this;

		[Token(Token = "0x40021F9")]
		[FieldOffset(Offset = "0x28")]
		private bool _003CscoreDetailSoundPlayed_003E5__2;

		[Token(Token = "0x40021FA")]
		[FieldOffset(Offset = "0x30")]
		private List<ScoreDetail> _003Cdetails_003E5__3;

		[Token(Token = "0x40021FB")]
		[FieldOffset(Offset = "0x38")]
		private List<ScoreDetailLabel> _003CdetailLabels_003E5__4;

		[Token(Token = "0x40021FC")]
		[FieldOffset(Offset = "0x40")]
		private int _003Ci_003E5__5;

		[Token(Token = "0x17000537")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60027DD")]
			[Address(RVA = "0x8B7F7C", Offset = "0x8B7F7C", VA = "0x8B7F7C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000538")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60027DF")]
			[Address(RVA = "0x8B7FC4", Offset = "0x8B7FC4", VA = "0x8B7FC4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60027DA")]
		[Address(RVA = "0x8B7990", Offset = "0x8B7990", VA = "0x8B7990")]
		[DebuggerHidden]
		public _003CScoreChangedAnimation_003Ed__56(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60027DB")]
		[Address(RVA = "0x8B79BC", Offset = "0x8B79BC", VA = "0x8B79BC", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60027DC")]
		[Address(RVA = "0x8B79C0", Offset = "0x8B79C0", VA = "0x8B79C0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60027DE")]
		[Address(RVA = "0x8B7F84", Offset = "0x8B7F84", VA = "0x8B7F84", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x2000622")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x595630", Offset = "0x595630")]
	private sealed class _003C_003Ec__DisplayClass63_0
	{
		[Token(Token = "0x40021FD")]
		[FieldOffset(Offset = "0x10")]
		public int currentVisibleTotalScore;

		[Token(Token = "0x40021FE")]
		[FieldOffset(Offset = "0x14")]
		public int currentTotalScore;

		[Token(Token = "0x40021FF")]
		[FieldOffset(Offset = "0x18")]
		public float duration;

		[Token(Token = "0x60027E0")]
		[Address(RVA = "0x8B6D50", Offset = "0x8B6D50", VA = "0x8B6D50")]
		public _003C_003Ec__DisplayClass63_0()
		{
		}

		[Token(Token = "0x60027E1")]
		[Address(RVA = "0x8B6D58", Offset = "0x8B6D58", VA = "0x8B6D58")]
		internal void _003CUpdateTotalScore_003Eb__0(UITweener tw)
		{
		}
	}

	[Token(Token = "0x2000623")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x595640", Offset = "0x595640")]
	private sealed class _003C_003Ec__DisplayClass64_0
	{
		[Token(Token = "0x4002200")]
		[FieldOffset(Offset = "0x10")]
		public ScoreAnimation _003C_003E4__this;

		[Token(Token = "0x4002201")]
		[FieldOffset(Offset = "0x18")]
		public ScoreDetailLabel scoreDetailLabel;

		[Token(Token = "0x60027E2")]
		[Address(RVA = "0x8B6E60", Offset = "0x8B6E60", VA = "0x8B6E60")]
		public _003C_003Ec__DisplayClass64_0()
		{
		}
	}

	[Token(Token = "0x2000624")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x595650", Offset = "0x595650")]
	private sealed class _003C_003Ec__DisplayClass64_1
	{
		[Token(Token = "0x4002202")]
		[FieldOffset(Offset = "0x10")]
		public UITweener tweener;

		[Token(Token = "0x4002203")]
		[FieldOffset(Offset = "0x18")]
		public _003C_003Ec__DisplayClass64_0 CS_0024_003C_003E8__locals1;

		[Token(Token = "0x60027E3")]
		[Address(RVA = "0x8B6E68", Offset = "0x8B6E68", VA = "0x8B6E68")]
		public _003C_003Ec__DisplayClass64_1()
		{
		}

		[Token(Token = "0x60027E4")]
		[Address(RVA = "0x8B6E70", Offset = "0x8B6E70", VA = "0x8B6E70")]
		internal void _003CDoPostScoreEffects_003Eb__0()
		{
		}
	}

	[Token(Token = "0x2000625")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x595660", Offset = "0x595660")]
	private sealed class _003C_003Ec__DisplayClass70_0
	{
		[Token(Token = "0x4002204")]
		[FieldOffset(Offset = "0x10")]
		public int i;

		[Token(Token = "0x4002205")]
		[FieldOffset(Offset = "0x18")]
		public ScoreAnimation _003C_003E4__this;

		[Token(Token = "0x60027E5")]
		[Address(RVA = "0x8B6F2C", Offset = "0x8B6F2C", VA = "0x8B6F2C")]
		public _003C_003Ec__DisplayClass70_0()
		{
		}

		[Token(Token = "0x60027E6")]
		[Address(RVA = "0x8B6F34", Offset = "0x8B6F34", VA = "0x8B6F34")]
		internal void _003CGlowHighScore_003Eb__1(UILabel l)
		{
		}
	}

	[Token(Token = "0x2000626")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x595670", Offset = "0x595670")]
	private sealed class _003CGlowHighScore_003Ed__70 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4002206")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4002207")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4002208")]
		[FieldOffset(Offset = "0x20")]
		public ScoreAnimation _003C_003E4__this;

		[Token(Token = "0x4002209")]
		[FieldOffset(Offset = "0x28")]
		private _003C_003Ec__DisplayClass70_0 _003C_003E8__1;

		[Token(Token = "0x400220A")]
		[FieldOffset(Offset = "0x30")]
		private int _003Ccount_003E5__2;

		[Token(Token = "0x17000539")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60027EA")]
			[Address(RVA = "0x8B75A8", Offset = "0x8B75A8", VA = "0x8B75A8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700053A")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60027EC")]
			[Address(RVA = "0x8B75F0", Offset = "0x8B75F0", VA = "0x8B75F0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60027E7")]
		[Address(RVA = "0x8B6F90", Offset = "0x8B6F90", VA = "0x8B6F90")]
		[DebuggerHidden]
		public _003CGlowHighScore_003Ed__70(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60027E8")]
		[Address(RVA = "0x8B6FBC", Offset = "0x8B6FBC", VA = "0x8B6FBC", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60027E9")]
		[Address(RVA = "0x8B6FC0", Offset = "0x8B6FC0", VA = "0x8B6FC0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60027EB")]
		[Address(RVA = "0x8B75B0", Offset = "0x8B75B0", VA = "0x8B75B0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x2000627")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x595680", Offset = "0x595680")]
	private sealed class _003COnStartChangeRival_003Ed__74 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400220B")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400220C")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400220D")]
		[FieldOffset(Offset = "0x20")]
		public ScoreAnimation _003C_003E4__this;

		[Token(Token = "0x1700053B")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60027F0")]
			[Address(RVA = "0x8B7940", Offset = "0x8B7940", VA = "0x8B7940", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700053C")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60027F2")]
			[Address(RVA = "0x8B7988", Offset = "0x8B7988", VA = "0x8B7988", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60027ED")]
		[Address(RVA = "0x8B75F8", Offset = "0x8B75F8", VA = "0x8B75F8")]
		[DebuggerHidden]
		public _003COnStartChangeRival_003Ed__74(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60027EE")]
		[Address(RVA = "0x8B7624", Offset = "0x8B7624", VA = "0x8B7624", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60027EF")]
		[Address(RVA = "0x8B7628", Offset = "0x8B7628", VA = "0x8B7628", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60027F1")]
		[Address(RVA = "0x8B7948", Offset = "0x8B7948", VA = "0x8B7948", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x40021C6")]
	[FieldOffset(Offset = "0x58")]
	public ModelContainer ModelContainer;

	[Token(Token = "0x40021C7")]
	[FieldOffset(Offset = "0x60")]
	public ScoreToBeatWidget ScoreToBeatWidget;

	[Token(Token = "0x40021C8")]
	[FieldOffset(Offset = "0x68")]
	public ScoreToBeatWidget NextRivalWidget;

	[Token(Token = "0x40021C9")]
	[FieldOffset(Offset = "0x70")]
	public UILabel TotalScoreLabel;

	[Token(Token = "0x40021CA")]
	[FieldOffset(Offset = "0x78")]
	public UILabel TotalScoreHighlight;

	[Token(Token = "0x40021CB")]
	[FieldOffset(Offset = "0x80")]
	public UITweener[] ScoreCountingTweener;

	[Token(Token = "0x40021CC")]
	[FieldOffset(Offset = "0x88")]
	public UITweener[] ScoreHighlightTweener;

	[Token(Token = "0x40021CD")]
	[FieldOffset(Offset = "0x90")]
	public SoundContainer ScoreCountingSound;

	[Token(Token = "0x40021CE")]
	[FieldOffset(Offset = "0x98")]
	public SingleCharacterGlow CharacterGlowTemplate;

	[Token(Token = "0x40021CF")]
	[FieldOffset(Offset = "0xA0")]
	public float CharacterInterval;

	[Token(Token = "0x40021D0")]
	[FieldOffset(Offset = "0xA8")]
	public TweenPosition ScorePanelTweener;

	[Token(Token = "0x40021D1")]
	[FieldOffset(Offset = "0xB0")]
	public UITweener[] RivalCrosshairFadeInTweener;

	[Token(Token = "0x40021D2")]
	[FieldOffset(Offset = "0xB8")]
	public UITweener[] ColorBoomTweeners;

	[Token(Token = "0x40021D3")]
	[FieldOffset(Offset = "0xC0")]
	public UITweener[] RivalChangeTweener;

	[Token(Token = "0x40021D4")]
	[FieldOffset(Offset = "0xC8")]
	public float RivalChangeDelay;

	[Token(Token = "0x40021D5")]
	[FieldOffset(Offset = "0xD0")]
	public UITweener[] RivalCrosshairFadeOutTweener;

	[Token(Token = "0x40021D6")]
	[FieldOffset(Offset = "0xD8")]
	public GameObject ScoreDetailLabelPrefab;

	[Token(Token = "0x40021D7")]
	[FieldOffset(Offset = "0xE0")]
	public GameObject ScoreDetailLabelParentGO;

	[Token(Token = "0x40021D8")]
	[FieldOffset(Offset = "0xE8")]
	public SoundContainer ScoreDetailsound;

	[Token(Token = "0x40021D9")]
	[FieldOffset(Offset = "0xF0")]
	private PlayingSoundContainer _playingScoreCountingSound;

	[Token(Token = "0x40021DA")]
	[FieldOffset(Offset = "0xF8")]
	private int _playingScoreCountingTweeners;

	[Token(Token = "0x40021DB")]
	[FieldOffset(Offset = "0x100")]
	private Coroutine _scoreAnimation;

	[Token(Token = "0x40021DC")]
	[FieldOffset(Offset = "0x108")]
	private bool _rivalAnimationPlaying;

	[Token(Token = "0x40021DD")]
	[FieldOffset(Offset = "0x110")]
	private LinkedList<List<ScoreDetail>> _details;

	[Token(Token = "0x40021DE")]
	[FieldOffset(Offset = "0x118")]
	private SingleCharacterGlow[] _letters;

	[Token(Token = "0x40021DF")]
	[FieldOffset(Offset = "0x120")]
	private GameTimer _timer;

	[Token(Token = "0x40021E0")]
	[FieldOffset(Offset = "0x128")]
	private float _speedMultiplier;

	[Token(Token = "0x40021E1")]
	[FieldOffset(Offset = "0x130")]
	private ObjectPool<ScoreDetailLabel> _scoreDetailLabelPool;

	[Token(Token = "0x40021E2")]
	private const float PRE_SCORE_ITEM_EFFECT_DURATION = 0.5f;

	[Token(Token = "0x40021E3")]
	private const float MOVE_UP_ITEM_EFFECT_DURATION = 0.2f;

	[Token(Token = "0x40021E4")]
	private const float DELAY_BETWEEN_ITEMS_PRE_EFFECT = 0.2f;

	[Token(Token = "0x40021E5")]
	private const float DELAY_BEFORE_DOING_POST_EFFECTS = 0.2f;

	[Token(Token = "0x40021E6")]
	private const float MAX_DELAY_BEFORE_DOING_POST_EFFECTS = 1f;

	[Token(Token = "0x40021E7")]
	private const float POST_SCORE_ITEM_EFFECT_DURATION = 0.5f;

	[Token(Token = "0x40021E8")]
	private const float DELAY_BETWEEN_ITEMS_POST_EFFECT = 0.5f;

	[Token(Token = "0x40021E9")]
	private const float DELAY_AFTER_POST_EFFECTS_DONE = 0f;

	[Token(Token = "0x40021EA")]
	private const float TOTAL_SCORE_UPDATE_TIME = 1f;

	[Token(Token = "0x40021EB")]
	private const int MAX_DISPLAY_AMOUNT = 5;

	[Token(Token = "0x40021EC")]
	private const int SCORE_DETAIL_LABEL_PRE_ALLOCATE = 8;

	[Token(Token = "0x40021ED")]
	private const int SCORE_DETAIL_LABEL_EXTRA_SPACE = 5;

	[Token(Token = "0x40021EE")]
	[FieldOffset(Offset = "0x138")]
	private GameTimer _timer3;

	[Token(Token = "0x40021EF")]
	[FieldOffset(Offset = "0x140")]
	private GameTimer _timer2;

	[Token(Token = "0x17000536")]
	private float DurationMultiplier
	{
		[Token(Token = "0x60027AC")]
		[Address(RVA = "0xBB42A8", Offset = "0xBB42A8", VA = "0xBB42A8")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x1400008F")]
	public event EventHandler ScoreAnimationCompleted
	{
		[Token(Token = "0x60027A8")]
		[Address(RVA = "0xBB4028", Offset = "0xBB4028", VA = "0xBB4028")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61D340", Offset = "0x61D340")]
		add
		{
		}
		[Token(Token = "0x60027A9")]
		[Address(RVA = "0xBB40C8", Offset = "0xBB40C8", VA = "0xBB40C8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61D350", Offset = "0x61D350")]
		remove
		{
		}
	}

	[Token(Token = "0x14000090")]
	public event EventHandler RivalAnimationCompleted
	{
		[Token(Token = "0x60027AA")]
		[Address(RVA = "0xBB4168", Offset = "0xBB4168", VA = "0xBB4168")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61D360", Offset = "0x61D360")]
		add
		{
		}
		[Token(Token = "0x60027AB")]
		[Address(RVA = "0xBB4208", Offset = "0xBB4208", VA = "0xBB4208")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61D370", Offset = "0x61D370")]
		remove
		{
		}
	}

	[Token(Token = "0x60027AD")]
	[Address(RVA = "0xBB4348", Offset = "0xBB4348", VA = "0xBB4348", Slot = "7")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x60027AE")]
	[Address(RVA = "0xBB4458", Offset = "0xBB4458", VA = "0xBB4458", Slot = "10")]
	protected override void OnDestroy()
	{
	}

	[Token(Token = "0x60027AF")]
	[Address(RVA = "0xBB4500", Offset = "0xBB4500", VA = "0xBB4500", Slot = "11")]
	protected override void OnEnable()
	{
	}

	[Token(Token = "0x60027B0")]
	[Address(RVA = "0xBB4750", Offset = "0xBB4750", VA = "0xBB4750", Slot = "12")]
	protected override void OnDisable()
	{
	}

	[Token(Token = "0x60027B1")]
	[Address(RVA = "0xBB47E0", Offset = "0xBB47E0", VA = "0xBB47E0")]
	private ScoreDetailLabel CreateScoreDetailLabelInstance()
	{
		return null;
	}

	[Token(Token = "0x60027B2")]
	[Address(RVA = "0xBB4874", Offset = "0xBB4874", VA = "0xBB4874")]
	public void AddScoreDetail(ScoreDetail scoreDetail)
	{
	}

	[Token(Token = "0x60027B3")]
	[Address(RVA = "0xBB4A44", Offset = "0xBB4A44", VA = "0xBB4A44")]
	public void StartScoreAnimation()
	{
	}

	[Token(Token = "0x60027B4")]
	[Address(RVA = "0xBB4A84", Offset = "0xBB4A84", VA = "0xBB4A84")]
	public void StopScoreAnimation()
	{
	}

	[Token(Token = "0x60027B5")]
	[Address(RVA = "0xBB49D8", Offset = "0xBB49D8", VA = "0xBB49D8")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x61D380", Offset = "0x61D380")]
	private IEnumerator ScoreChangedAnimation()
	{
		return null;
	}

	[Token(Token = "0x60027B6")]
	[Address(RVA = "0xBB4AB4", Offset = "0xBB4AB4", VA = "0xBB4AB4")]
	private void DoGroupScore(ScoreConfig scoreConfig, List<ScoreDetail> details)
	{
	}

	[Token(Token = "0x60027B7")]
	[Address(RVA = "0xBB4CC8", Offset = "0xBB4CC8", VA = "0xBB4CC8")]
	private string GetGroupScoreDescription(ScoreConfig scoreConfig, int score)
	{
		return null;
	}

	[Token(Token = "0x60027B8")]
	[Address(RVA = "0xBB4E34", Offset = "0xBB4E34", VA = "0xBB4E34")]
	private void MoveAllLabelsUp(List<ScoreDetail> details, List<ScoreDetailLabel> detailLabels, ref int index)
	{
	}

	[Token(Token = "0x60027B9")]
	[Address(RVA = "0xBB54D0", Offset = "0xBB54D0", VA = "0xBB54D0")]
	private void DoMoveUpEffect(ScoreDetailLabel scoreDetailLabel)
	{
	}

	[Token(Token = "0x60027BA")]
	[Address(RVA = "0xBB56A0", Offset = "0xBB56A0", VA = "0xBB56A0")]
	private void CreateScoreItem(ref bool scoreDetailSoundPlayed, List<ScoreDetailLabel> scoreDetailLabelList, List<ScoreDetail> scoreDetailList, int index)
	{
	}

	[Token(Token = "0x60027BB")]
	[Address(RVA = "0xBB5B24", Offset = "0xBB5B24", VA = "0xBB5B24")]
	private void DoPreScoreEffects(ScoreDetailLabel scoreDetailLabel)
	{
	}

	[Token(Token = "0x60027BC")]
	[Address(RVA = "0xBB5308", Offset = "0xBB5308", VA = "0xBB5308")]
	private void UpdateTotalScore(int currentTotalScore, float duration)
	{
	}

	[Token(Token = "0x60027BD")]
	[Address(RVA = "0xBB5044", Offset = "0xBB5044", VA = "0xBB5044")]
	private void DoPostScoreEffects(ScoreDetailLabel scoreDetailLabel)
	{
	}

	[Token(Token = "0x60027BE")]
	[Address(RVA = "0xBB5CE4", Offset = "0xBB5CE4", VA = "0xBB5CE4")]
	public void StartRivalBeatenAnimation()
	{
	}

	[Token(Token = "0x60027BF")]
	[Address(RVA = "0xBB5CF0", Offset = "0xBB5CF0", VA = "0xBB5CF0")]
	private void ScoreScaleAnimation()
	{
	}

	[Token(Token = "0x60027C0")]
	[Address(RVA = "0xBB5EC4", Offset = "0xBB5EC4", VA = "0xBB5EC4")]
	private void OnScoreHighlightFinished()
	{
	}

	[Token(Token = "0x60027C1")]
	[Address(RVA = "0xBB6018", Offset = "0xBB6018", VA = "0xBB6018")]
	private void OnShowScorePanelFinished()
	{
	}

	[Token(Token = "0x60027C2")]
	[Address(RVA = "0xBB6044", Offset = "0xBB6044", VA = "0xBB6044")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x61D3E0", Offset = "0x61D3E0")]
	private IEnumerator GlowHighScore()
	{
		return null;
	}

	[Token(Token = "0x60027C3")]
	[Address(RVA = "0xBB60B0", Offset = "0xBB60B0", VA = "0xBB60B0")]
	private void OnScoreGlowFaded()
	{
	}

	[Token(Token = "0x60027C4")]
	[Address(RVA = "0xBB632C", Offset = "0xBB632C", VA = "0xBB632C")]
	private void OnRivalCrosshairFadedIn()
	{
	}

	[Token(Token = "0x60027C5")]
	[Address(RVA = "0xBB656C", Offset = "0xBB656C", VA = "0xBB656C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x61D440", Offset = "0x61D440")]
	private IEnumerator OnStartChangeRival()
	{
		return null;
	}

	[Token(Token = "0x60027C6")]
	[Address(RVA = "0xBB65D8", Offset = "0xBB65D8", VA = "0xBB65D8")]
	private void OnRivalChangedCompleted()
	{
	}

	[Token(Token = "0x60027C7")]
	[Address(RVA = "0xBB69DC", Offset = "0xBB69DC", VA = "0xBB69DC")]
	private void OnRivalCrosshairFadedOut()
	{
	}

	[Token(Token = "0x60027C8")]
	[Address(RVA = "0xBB6A78", Offset = "0xBB6A78", VA = "0xBB6A78")]
	private void OnScoreCountingTweenerFinished()
	{
	}

	[Token(Token = "0x60027C9")]
	[Address(RVA = "0xBB6AB4", Offset = "0xBB6AB4", VA = "0xBB6AB4")]
	public ScoreAnimation()
	{
	}

	[Token(Token = "0x60027CA")]
	[Address(RVA = "0xBB6BA4", Offset = "0xBB6BA4", VA = "0xBB6BA4")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61D4A0", Offset = "0x61D4A0")]
	private void _003COnEnable_003Eb__50_2(UITweener tw)
	{
	}

	[Token(Token = "0x60027CB")]
	[Address(RVA = "0xBB6C68", Offset = "0xBB6C68", VA = "0xBB6C68")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61D4B0", Offset = "0x61D4B0")]
	private void _003CScoreScaleAnimation_003Eb__66_0(UITweener t)
	{
	}

	[Token(Token = "0x60027CC")]
	[Address(RVA = "0xBB6CB8", Offset = "0xBB6CB8", VA = "0xBB6CB8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61D4C0", Offset = "0x61D4C0")]
	private void _003CGlowHighScore_003Eb__70_0(UILabel l)
	{
	}

	[Token(Token = "0x60027CD")]
	[Address(RVA = "0xBB6D84", Offset = "0xBB6D84", VA = "0xBB6D84")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61D4D0", Offset = "0x61D4D0")]
	private void _003CGlowHighScore_003Eb__70_2(UITweener tw)
	{
	}

	[Token(Token = "0x60027CE")]
	[Address(RVA = "0xBB6DC8", Offset = "0xBB6DC8", VA = "0xBB6DC8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61D4E0", Offset = "0x61D4E0")]
	private void _003COnScoreGlowFaded_003Eb__71_1(UITweener t)
	{
	}

	[Token(Token = "0x60027CF")]
	[Address(RVA = "0xBB6E3C", Offset = "0xBB6E3C", VA = "0xBB6E3C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61D4F0", Offset = "0x61D4F0")]
	private void _003COnRivalCrosshairFadedIn_003Eb__72_0(UITweener t)
	{
	}

	[Token(Token = "0x60027D0")]
	[Address(RVA = "0xBB6EB0", Offset = "0xBB6EB0", VA = "0xBB6EB0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61D500", Offset = "0x61D500")]
	private void _003COnRivalCrosshairFadedIn_003Eb__72_1()
	{
	}

	[Token(Token = "0x60027D1")]
	[Address(RVA = "0xBB6EDC", Offset = "0xBB6EDC", VA = "0xBB6EDC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61D510", Offset = "0x61D510")]
	private void _003COnStartChangeRival_003Eb__74_1(UITweener t)
	{
	}

	[Token(Token = "0x60027D2")]
	[Address(RVA = "0xBB6F2C", Offset = "0xBB6F2C", VA = "0xBB6F2C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61D520", Offset = "0x61D520")]
	private void _003COnRivalChangedCompleted_003Eb__75_1(UITweener t)
	{
	}
}
