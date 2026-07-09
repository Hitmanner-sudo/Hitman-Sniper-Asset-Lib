using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000542")]
public class RogueArrivalTimerController : SidePanelItemController
{
	[Token(Token = "0x2000543")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x595104", Offset = "0x595104")]
	private sealed class _003CUpdateTimerText_003Ed__43 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4001BF3")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4001BF4")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4001BF5")]
		[FieldOffset(Offset = "0x20")]
		public RogueArrivalTimerController _003C_003E4__this;

		[Token(Token = "0x170004DD")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6002109")]
			[Address(RVA = "0x8B4C98", Offset = "0x8B4C98", VA = "0x8B4C98", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170004DE")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600210B")]
			[Address(RVA = "0x8B4CE0", Offset = "0x8B4CE0", VA = "0x8B4CE0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6002106")]
		[Address(RVA = "0x8B4B38", Offset = "0x8B4B38", VA = "0x8B4B38")]
		[DebuggerHidden]
		public _003CUpdateTimerText_003Ed__43(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6002107")]
		[Address(RVA = "0x8B4B64", Offset = "0x8B4B64", VA = "0x8B4B64", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6002108")]
		[Address(RVA = "0x8B4B68", Offset = "0x8B4B68", VA = "0x8B4B68", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600210A")]
		[Address(RVA = "0x8B4CA0", Offset = "0x8B4CA0", VA = "0x8B4CA0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x2000544")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x595114", Offset = "0x595114")]
	private sealed class _003CDelayFadeDownTimer_003Ed__44 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4001BF6")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4001BF7")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4001BF8")]
		[FieldOffset(Offset = "0x20")]
		public float delay;

		[Token(Token = "0x4001BF9")]
		[FieldOffset(Offset = "0x28")]
		public RogueArrivalTimerController _003C_003E4__this;

		[Token(Token = "0x4001BFA")]
		[FieldOffset(Offset = "0x30")]
		private GameTimer _003Ctimer_003E5__2;

		[Token(Token = "0x170004DF")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600210F")]
			[Address(RVA = "0x8B4AE8", Offset = "0x8B4AE8", VA = "0x8B4AE8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170004E0")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6002111")]
			[Address(RVA = "0x8B4B30", Offset = "0x8B4B30", VA = "0x8B4B30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600210C")]
		[Address(RVA = "0x8B49D4", Offset = "0x8B49D4", VA = "0x8B49D4")]
		[DebuggerHidden]
		public _003CDelayFadeDownTimer_003Ed__44(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600210D")]
		[Address(RVA = "0x8B4A00", Offset = "0x8B4A00", VA = "0x8B4A00", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600210E")]
		[Address(RVA = "0x8B4A04", Offset = "0x8B4A04", VA = "0x8B4A04", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6002110")]
		[Address(RVA = "0x8B4AF0", Offset = "0x8B4AF0", VA = "0x8B4AF0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x2000545")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x595124", Offset = "0x595124")]
	private sealed class _003CWaitForObjectivesComplete_003Ed__67 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4001BFB")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4001BFC")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4001BFD")]
		[FieldOffset(Offset = "0x20")]
		public RogueArrivalTimerController _003C_003E4__this;

		[Token(Token = "0x170004E1")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6002115")]
			[Address(RVA = "0x8B4E68", Offset = "0x8B4E68", VA = "0x8B4E68", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170004E2")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6002117")]
			[Address(RVA = "0x8B4EB0", Offset = "0x8B4EB0", VA = "0x8B4EB0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6002112")]
		[Address(RVA = "0x8B4CE8", Offset = "0x8B4CE8", VA = "0x8B4CE8")]
		[DebuggerHidden]
		public _003CWaitForObjectivesComplete_003Ed__67(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6002113")]
		[Address(RVA = "0x8B4D14", Offset = "0x8B4D14", VA = "0x8B4D14", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6002114")]
		[Address(RVA = "0x8B4D18", Offset = "0x8B4D18", VA = "0x8B4D18", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6002116")]
		[Address(RVA = "0x8B4E70", Offset = "0x8B4E70", VA = "0x8B4E70", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x4001BD2")]
	[FieldOffset(Offset = "0xA8")]
	public UISprite ArrivalTextBackground;

	[Token(Token = "0x4001BD3")]
	[FieldOffset(Offset = "0xB0")]
	public UILabel ArrivalTextLabel;

	[Token(Token = "0x4001BD4")]
	[FieldOffset(Offset = "0xB8")]
	public UILabel TimeRemainingLabel;

	[Token(Token = "0x4001BD5")]
	[FieldOffset(Offset = "0xC0")]
	public UISprite RogueHealth;

	[Token(Token = "0x4001BD6")]
	[FieldOffset(Offset = "0xC8")]
	public ButtonHandler RogueIconButton;

	[Token(Token = "0x4001BD7")]
	[FieldOffset(Offset = "0xD0")]
	public UIPanel TimerPanel;

	[Token(Token = "0x4001BD8")]
	[FieldOffset(Offset = "0xD8")]
	public GameObject TimerContainerGameObjet;

	[Token(Token = "0x4001BD9")]
	[FieldOffset(Offset = "0xE0")]
	public float OnTakeDamageEffectDuration;

	[Token(Token = "0x4001BDA")]
	[FieldOffset(Offset = "0xE4")]
	public float OnTakeDamageFlashDuration;

	[Token(Token = "0x4001BDB")]
	[FieldOffset(Offset = "0xE8")]
	public float OnTakeDamageVignetteFlashDuration;

	[Token(Token = "0x4001BDC")]
	[FieldOffset(Offset = "0xF0")]
	public GameObject ImageContourCornersGO;

	[Token(Token = "0x4001BDD")]
	[FieldOffset(Offset = "0xF8")]
	public int ArrivalTextMaxWidth;

	[Token(Token = "0x4001BDE")]
	[FieldOffset(Offset = "0xFC")]
	public int ArrivalTextBackgroundMaxHeight;

	[Token(Token = "0x4001BDF")]
	[FieldOffset(Offset = "0x100")]
	private readonly GameRealTimer _damageTakenTimer;

	[Token(Token = "0x4001BE0")]
	[FieldOffset(Offset = "0x108")]
	private RogueData _missionRogueData;

	[Token(Token = "0x4001BE1")]
	[FieldOffset(Offset = "0x110")]
	private GameTimer _gameTimer;

	[Token(Token = "0x4001BE2")]
	[FieldOffset(Offset = "0x118")]
	private GameTimer _arrivalTimer;

	[Token(Token = "0x4001BE3")]
	[FieldOffset(Offset = "0x120")]
	private int _targetDespawnCount;

	[Token(Token = "0x4001BE4")]
	[FieldOffset(Offset = "0x128")]
	private Coroutine _timerTextCoroutine;

	[Token(Token = "0x4001BE5")]
	[FieldOffset(Offset = "0x130")]
	private bool _hideWhenDead;

	[Token(Token = "0x4001BE6")]
	[FieldOffset(Offset = "0x134")]
	private Color _blinkingColor;

	[Token(Token = "0x4001BE7")]
	[FieldOffset(Offset = "0x144")]
	private Color _defaultContourColor;

	[Token(Token = "0x4001BE8")]
	[FieldOffset(Offset = "0x158")]
	private ContractData.RogueArrivalTimerData _rogueArrivalTimerData;

	[Token(Token = "0x4001BE9")]
	[FieldOffset(Offset = "0x160")]
	private int _secondsLeftCached;

	[Token(Token = "0x4001BEA")]
	[FieldOffset(Offset = "0x164")]
	private bool _eventBinded;

	[Token(Token = "0x4001BEB")]
	[FieldOffset(Offset = "0x168")]
	private float _timerTargetTime;

	[Token(Token = "0x4001BEC")]
	[FieldOffset(Offset = "0x16C")]
	private bool _isShowingTimer;

	[Token(Token = "0x4001BED")]
	[FieldOffset(Offset = "0x16D")]
	private bool _mainTargetDeadOrDespawned;

	[Token(Token = "0x4001BEE")]
	private const float COMPACT_VERSION_SCALE = 0.75f;

	[Token(Token = "0x4001BEF")]
	private const string SPAWN_KEY = "LOC_Rogue_Arrival";

	[Token(Token = "0x4001BF0")]
	private const string DESPAWN_KEY = "LOC_Rogue_Departure";

	[Token(Token = "0x4001BF1")]
	private const string RESPAWN_KEY = "LOC_Rogue_Return";

	[Token(Token = "0x4001BF2")]
	private const string MURDER_WARNING_KEY = "LOC_Rogue_Murder_Warning";

	[Token(Token = "0x60020E1")]
	[Address(RVA = "0x96F3F0", Offset = "0x96F3F0", VA = "0x96F3F0")]
	public void SetParameters(RogueData rogueData, ContractData.RogueArrivalTimerData rogueArrivalTimerData)
	{
	}

	[Token(Token = "0x60020E2")]
	[Address(RVA = "0x96F58C", Offset = "0x96F58C", VA = "0x96F58C", Slot = "9")]
	protected override void Start()
	{
	}

	[Token(Token = "0x60020E3")]
	[Address(RVA = "0x96F790", Offset = "0x96F790", VA = "0x96F790")]
	private void SetArrivalTimer(string descriptionText, bool showTimerLabel)
	{
	}

	[Token(Token = "0x60020E4")]
	[Address(RVA = "0x96FD80", Offset = "0x96FD80", VA = "0x96FD80", Slot = "11")]
	protected override void OnEnable()
	{
	}

	[Token(Token = "0x60020E5")]
	[Address(RVA = "0x9700A4", Offset = "0x9700A4", VA = "0x9700A4", Slot = "12")]
	protected override void OnDisable()
	{
	}

	[Token(Token = "0x60020E6")]
	[Address(RVA = "0x970518", Offset = "0x970518", VA = "0x970518", Slot = "10")]
	protected override void OnDestroy()
	{
	}

	[Token(Token = "0x60020E7")]
	[Address(RVA = "0x9705AC", Offset = "0x9705AC", VA = "0x9705AC")]
	private void Update()
	{
	}

	[Token(Token = "0x60020E8")]
	[Address(RVA = "0x970784", Offset = "0x970784", VA = "0x970784")]
	private void OnVariableChanged(object sender, DataModel.VariableChangedEventArgs args)
	{
	}

	[Token(Token = "0x60020E9")]
	[Address(RVA = "0x96FFA0", Offset = "0x96FFA0", VA = "0x96FFA0")]
	private void OnShowRogueArrivalTimerChanged(bool show)
	{
	}

	[Token(Token = "0x60020EA")]
	[Address(RVA = "0x96F860", Offset = "0x96F860", VA = "0x96F860")]
	private void SetupArrivalTimer(float time)
	{
	}

	[Token(Token = "0x60020EB")]
	[Address(RVA = "0x96F940", Offset = "0x96F940", VA = "0x96F940")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x619638", Offset = "0x619638")]
	private IEnumerator UpdateTimerText()
	{
		return null;
	}

	[Token(Token = "0x60020EC")]
	[Address(RVA = "0x97087C", Offset = "0x97087C", VA = "0x97087C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x619698", Offset = "0x619698")]
	private IEnumerator DelayFadeDownTimer(float delay)
	{
		return null;
	}

	[Token(Token = "0x60020ED")]
	[Address(RVA = "0x9708F8", Offset = "0x9708F8", VA = "0x9708F8")]
	private void FadeDownTimer()
	{
	}

	[Token(Token = "0x60020EE")]
	[Address(RVA = "0x970874", Offset = "0x970874", VA = "0x970874")]
	private void FadeUpTimer()
	{
	}

	[Token(Token = "0x60020EF")]
	[Address(RVA = "0x970900", Offset = "0x970900", VA = "0x970900")]
	private void FadeTimer(float to)
	{
	}

	[Token(Token = "0x60020F0")]
	[Address(RVA = "0x970940", Offset = "0x970940", VA = "0x970940")]
	private void OnCharacterDied(object sender, Character.DeathEvent e)
	{
	}

	[Token(Token = "0x60020F1")]
	[Address(RVA = "0x970A74", Offset = "0x970A74", VA = "0x970A74")]
	private void OnMainTargetDied(Character.DeathEvent e)
	{
	}

	[Token(Token = "0x60020F2")]
	[Address(RVA = "0x970AB0", Offset = "0x970AB0", VA = "0x970AB0")]
	private void HandleMainTargetDespawn()
	{
	}

	[Token(Token = "0x60020F3")]
	[Address(RVA = "0x970C2C", Offset = "0x970C2C", VA = "0x970C2C")]
	private void ShowReturnTimer()
	{
	}

	[Token(Token = "0x60020F4")]
	[Address(RVA = "0x970B58", Offset = "0x970B58", VA = "0x970B58")]
	private void HandleMainTargetDeath()
	{
	}

	[Token(Token = "0x60020F5")]
	[Address(RVA = "0x970D3C", Offset = "0x970D3C", VA = "0x970D3C")]
	private void OnMurderWarning(object sender, MurderWarningAction.MurderWarningArgs e)
	{
	}

	[Token(Token = "0x60020F6")]
	[Address(RVA = "0x970E28", Offset = "0x970E28", VA = "0x970E28")]
	private void OnWaypointStartUsing(object sender, Waypoint.WaypointEventArgs e)
	{
	}

	[Token(Token = "0x60020F7")]
	[Address(RVA = "0x970988", Offset = "0x970988", VA = "0x970988")]
	private bool IsMainTarget(Character c)
	{
		return default(bool);
	}

	[Token(Token = "0x60020F8")]
	[Address(RVA = "0x970FEC", Offset = "0x970FEC", VA = "0x970FEC")]
	private bool IsFinalDespawn()
	{
		return default(bool);
	}

	[Token(Token = "0x60020F9")]
	[Address(RVA = "0x970B78", Offset = "0x970B78", VA = "0x970B78")]
	private bool ShouldShowReturnTimer()
	{
		return default(bool);
	}

	[Token(Token = "0x60020FA")]
	[Address(RVA = "0x970EE8", Offset = "0x970EE8", VA = "0x970EE8")]
	private bool ShouldShowDespawnWarning(Waypoint.WaypointEventArgs e)
	{
		return default(bool);
	}

	[Token(Token = "0x60020FB")]
	[Address(RVA = "0x971020", Offset = "0x971020", VA = "0x971020")]
	private void OnRogueIconPressed(object sender, ButtonHandler.ButtonHandlerEventArgs e)
	{
	}

	[Token(Token = "0x60020FC")]
	[Address(RVA = "0x971228", Offset = "0x971228", VA = "0x971228")]
	private Target GetMainTarget()
	{
		return null;
	}

	[Token(Token = "0x60020FD")]
	[Address(RVA = "0x971318", Offset = "0x971318", VA = "0x971318")]
	private void OnMainTargetTakeDamage(object sender, Health.TakeDamageEventArgs args)
	{
	}

	[Token(Token = "0x60020FE")]
	[Address(RVA = "0x97169C", Offset = "0x97169C", VA = "0x97169C")]
	private void OnMainTargetTakeHeal(object sender, Health.TakeHealEventArgs args)
	{
	}

	[Token(Token = "0x60020FF")]
	[Address(RVA = "0x96FFC0", Offset = "0x96FFC0", VA = "0x96FFC0")]
	private void UpdateRogueHealth()
	{
	}

	[Token(Token = "0x6002100")]
	[Address(RVA = "0x971520", Offset = "0x971520", VA = "0x971520")]
	private void SetRogueHealthVisual(Health health)
	{
	}

	[Token(Token = "0x6002101")]
	[Address(RVA = "0x96F9AC", Offset = "0x96F9AC", VA = "0x96F9AC")]
	private void BindEvents()
	{
	}

	[Token(Token = "0x6002102")]
	[Address(RVA = "0x970158", Offset = "0x970158", VA = "0x970158")]
	private void UnbindEvents()
	{
	}

	[Token(Token = "0x6002103")]
	[Address(RVA = "0x96FF34", Offset = "0x96FF34", VA = "0x96FF34")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x6196F8", Offset = "0x6196F8")]
	private IEnumerator WaitForObjectivesComplete()
	{
		return null;
	}

	[Token(Token = "0x6002104")]
	[Address(RVA = "0x9717B4", Offset = "0x9717B4", VA = "0x9717B4")]
	public RogueArrivalTimerController()
	{
	}

	[Token(Token = "0x6002105")]
	[Address(RVA = "0x971878", Offset = "0x971878", VA = "0x971878")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x619758", Offset = "0x619758")]
	private bool _003CGetMainTarget_003Eb__60_0(Target t)
	{
		return default(bool);
	}
}
