using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Technology;
using UnityEngine;

[Token(Token = "0x20003A0")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x59352C", Offset = "0x59352C")]
public class Weapon : InventoryItem
{
	[Token(Token = "0x20003A1")]
	public class ShotFiredArgs : EventArgs
	{
		[Token(Token = "0x4001493")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Bullet Bullet;

		[Token(Token = "0x600168A")]
		[Address(RVA = "0xA41F48", Offset = "0xA41F48", VA = "0xA41F48")]
		public ShotFiredArgs()
		{
		}
	}

	[Token(Token = "0x20003A2")]
	public class PowerUpUsedEventArgs : EventArgs
	{
		[Token(Token = "0x4001494")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public PowerUp PowerUp;

		[Token(Token = "0x600168B")]
		[Address(RVA = "0xA42808", Offset = "0xA42808", VA = "0xA42808")]
		public PowerUpUsedEventArgs()
		{
		}
	}

	[Token(Token = "0x20003A3")]
	private class AIControllerDistance
	{
		[Token(Token = "0x4001495")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public AIController AIController;

		[Token(Token = "0x4001496")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float Distance;

		[Token(Token = "0x600168C")]
		[Address(RVA = "0xA42800", Offset = "0xA42800", VA = "0xA42800")]
		public AIControllerDistance()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x20003A4")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x59358C", Offset = "0x59358C")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x4001497")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x4001498")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Func<DataModel, bool> _003C_003E9__42_0;

		[Token(Token = "0x4001499")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static Comparison<AIControllerDistance> _003C_003E9__58_1;

		[Token(Token = "0x400149A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static Converter<AIControllerDistance, AIController> _003C_003E9__58_2;

		[Token(Token = "0x600168E")]
		[Address(RVA = "0xA41DAC", Offset = "0xA41DAC", VA = "0xA41DAC")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x600168F")]
		[Address(RVA = "0xA41DB4", Offset = "0xA41DB4", VA = "0xA41DB4")]
		internal bool _003CSetupFromData_003Eb__42_0(DataModel m)
		{
			return default(bool);
		}

		[Token(Token = "0x6001690")]
		[Address(RVA = "0xA41E30", Offset = "0xA41E30", VA = "0xA41E30")]
		internal int _003CGetClosestEnemies_003Eb__58_1(AIControllerDistance a, AIControllerDistance b)
		{
			return default(int);
		}

		[Token(Token = "0x6001691")]
		[Address(RVA = "0xA41E58", Offset = "0xA41E58", VA = "0xA41E58")]
		internal AIController _003CGetClosestEnemies_003Eb__58_2(AIControllerDistance x)
		{
			return null;
		}
	}

	[Token(Token = "0x20003A5")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x59359C", Offset = "0x59359C")]
	private sealed class _003CUpdateEnemiesTracking_003Ed__44 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400149B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400149C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400149D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Weapon _003C_003E4__this;

		[Token(Token = "0x400149E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private PlayerController _003CplayerController_003E5__2;

		[Token(Token = "0x17000391")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6001695")]
			[Address(RVA = "0xA427B0", Offset = "0xA427B0", VA = "0xA427B0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000392")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6001697")]
			[Address(RVA = "0xA427F8", Offset = "0xA427F8", VA = "0xA427F8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6001692")]
		[Address(RVA = "0xA42578", Offset = "0xA42578", VA = "0xA42578")]
		[DebuggerHidden]
		public _003CUpdateEnemiesTracking_003Ed__44(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6001693")]
		[Address(RVA = "0xA425A4", Offset = "0xA425A4", VA = "0xA425A4", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6001694")]
		[Address(RVA = "0xA425A8", Offset = "0xA425A8", VA = "0xA425A8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6001696")]
		[Address(RVA = "0xA427B8", Offset = "0xA427B8", VA = "0xA427B8", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x20003A6")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5935AC", Offset = "0x5935AC")]
	private sealed class _003CDoVolleyShoots_003Ed__45 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400149F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40014A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40014A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Weapon _003C_003E4__this;

		[Token(Token = "0x40014A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public PlayerController playerController;

		[Token(Token = "0x40014A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public VolleyPowerUp.VolleyData volleyData;

		[Token(Token = "0x40014A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Vector3 origin;

		[Token(Token = "0x40014A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public Vector3 direction;

		[Token(Token = "0x40014A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Bullet lastBullet;

		[Token(Token = "0x40014A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private List<AIController> _003CclosestEnemies_003E5__2;

		[Token(Token = "0x40014A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private TimeReferential _003CgameTime_003E5__3;

		[Token(Token = "0x40014A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private long _003CbulletID_003E5__4;

		[Token(Token = "0x40014AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private int _003CtrackedEnemyIndex_003E5__5;

		[Token(Token = "0x40014AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private float _003CgameTimeWhenStarted_003E5__6;

		[Token(Token = "0x40014AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private float _003CgameTimeCurrent_003E5__7;

		[Token(Token = "0x40014AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private bool _003CpenetrateEverything_003E5__8;

		[Token(Token = "0x40014AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private List<bool> _003CisTrackedEnemy_003E5__9;

		[Token(Token = "0x40014AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private int _003Ci_003E5__10;

		[Token(Token = "0x17000393")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600169B")]
			[Address(RVA = "0xA42528", Offset = "0xA42528", VA = "0xA42528", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000394")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600169D")]
			[Address(RVA = "0xA42570", Offset = "0xA42570", VA = "0xA42570", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6001698")]
		[Address(RVA = "0xA41FAC", Offset = "0xA41FAC", VA = "0xA41FAC")]
		[DebuggerHidden]
		public _003CDoVolleyShoots_003Ed__45(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6001699")]
		[Address(RVA = "0xA41FD8", Offset = "0xA41FD8", VA = "0xA41FD8", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600169A")]
		[Address(RVA = "0xA41FDC", Offset = "0xA41FDC", VA = "0xA41FDC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600169C")]
		[Address(RVA = "0xA42530", Offset = "0xA42530", VA = "0xA42530", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x20003A7")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5935BC", Offset = "0x5935BC")]
	private sealed class _003C_003Ec__DisplayClass58_0
	{
		[Token(Token = "0x40014B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Faction shooterFaction;

		[Token(Token = "0x600169E")]
		[Address(RVA = "0xA41E70", Offset = "0xA41E70", VA = "0xA41E70")]
		public _003C_003Ec__DisplayClass58_0()
		{
		}

		[Token(Token = "0x600169F")]
		[Address(RVA = "0xA41E78", Offset = "0xA41E78", VA = "0xA41E78")]
		internal bool _003CGetClosestEnemies_003Eb__0(AIController x)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x20003A8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5935CC", Offset = "0x5935CC")]
	private sealed class _003C_003Ec__DisplayClass64_0
	{
		[Token(Token = "0x40014B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Bullet bullet;

		[Token(Token = "0x60016A0")]
		[Address(RVA = "0xA41ED8", Offset = "0xA41ED8", VA = "0xA41ED8")]
		public _003C_003Ec__DisplayClass64_0()
		{
		}

		[Token(Token = "0x60016A1")]
		[Address(RVA = "0xA41EE0", Offset = "0xA41EE0", VA = "0xA41EE0")]
		internal ShotFiredArgs _003CDoShoot_003Eb__0()
		{
			return null;
		}
	}

	[Token(Token = "0x400147C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public Bullet Bullet;

	[Token(Token = "0x400147D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public Transform ScopeBorderTransform;

	[Token(Token = "0x400147E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public WeaponData Data;

	[Token(Token = "0x400147F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public RuntimeAnimatorController PlayerAnimatorOverride;

	[Token(Token = "0x4001480")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5B4B3C", Offset = "0x5B4B3C")]
	private ReloadSequence _003CReloadSequence_003Ek__BackingField;

	[Token(Token = "0x4001481")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	public ModelContainer ModelContainer;

	[Token(Token = "0x4001482")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	public Material SplitShootMaterial;

	[NonSerialized]
	[Token(Token = "0x4001483")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	public bool InstaBulletPowerUpActivate;

	[NonSerialized]
	[Token(Token = "0x4001484")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD9")]
	public bool InstaBulletDisabledOverride;

	[NonSerialized]
	[Token(Token = "0x4001485")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xDA")]
	public bool IsExplosiveHookSecondShot;

	[NonSerialized]
	[Token(Token = "0x4001486")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xDB")]
	public bool InfinitAmmo;

	[NonSerialized]
	[Token(Token = "0x4001487")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
	public bool NoFriendlyFire;

	[NonSerialized]
	[Token(Token = "0x4001488")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xDD")]
	public bool PenetrateEverything;

	[Token(Token = "0x4001489")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	private float _nextShotTime;

	[Token(Token = "0x400148A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	private Dictionary<string, float> _activePowerUps;

	[Token(Token = "0x400148B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	private int _currentAmmunitionCount;

	[Token(Token = "0x400148C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
	private int _enemiesToTrackNumber;

	[Token(Token = "0x400148D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	private bool _enemiesToTrackShowHighlight;

	[Token(Token = "0x400148E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
	private float _enemiesToTrackDistance;

	[Token(Token = "0x400148F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	private Coroutine _enemiesTrackingCoroutine;

	[Token(Token = "0x4001490")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	private List<AIController> _previousTargetedAIControllers;

	[Token(Token = "0x1700038B")]
	public ReloadSequence ReloadSequence
	{
		[Token(Token = "0x600165E")]
		[Address(RVA = "0x9801EC", Offset = "0x9801EC", VA = "0x9801EC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6172C4", Offset = "0x6172C4")]
		get
		{
			return null;
		}
		[Token(Token = "0x600165F")]
		[Address(RVA = "0x9801F4", Offset = "0x9801F4", VA = "0x9801F4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6172D4", Offset = "0x6172D4")]
		private set
		{
		}
	}

	[Token(Token = "0x1700038C")]
	public bool AmmoClipFull
	{
		[Token(Token = "0x6001660")]
		[Address(RVA = "0x9801FC", Offset = "0x9801FC", VA = "0x9801FC")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700038D")]
	public int CurrentAmmunitionCount
	{
		[Token(Token = "0x6001661")]
		[Address(RVA = "0x980290", Offset = "0x980290", VA = "0x980290")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6001662")]
		[Address(RVA = "0x980298", Offset = "0x980298", VA = "0x980298")]
		set
		{
		}
	}

	[Token(Token = "0x1700038E")]
	public bool IsInstaBullet
	{
		[Token(Token = "0x6001663")]
		[Address(RVA = "0x980328", Offset = "0x980328", VA = "0x980328")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700038F")]
	public bool IsShooting
	{
		[Token(Token = "0x6001675")]
		[Address(RVA = "0x9815DC", Offset = "0x9815DC", VA = "0x9815DC")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000390")]
	public float NextShootTime
	{
		[Token(Token = "0x6001676")]
		[Address(RVA = "0x98169C", Offset = "0x98169C", VA = "0x98169C")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x14000058")]
	public static event EventHandler<ShotFiredArgs> OnShotFired
	{
		[Token(Token = "0x6001664")]
		[Address(RVA = "0x980350", Offset = "0x980350", VA = "0x980350")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6172E4", Offset = "0x6172E4")]
		add
		{
		}
		[Token(Token = "0x6001665")]
		[Address(RVA = "0x98040C", Offset = "0x98040C", VA = "0x98040C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6172F4", Offset = "0x6172F4")]
		remove
		{
		}
	}

	[Token(Token = "0x14000059")]
	public static event EventHandler<PowerUpUsedEventArgs> OnPowerUpUsed
	{
		[Token(Token = "0x6001666")]
		[Address(RVA = "0x9804C8", Offset = "0x9804C8", VA = "0x9804C8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x617304", Offset = "0x617304")]
		add
		{
		}
		[Token(Token = "0x6001667")]
		[Address(RVA = "0x980588", Offset = "0x980588", VA = "0x980588")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x617314", Offset = "0x617314")]
		remove
		{
		}
	}

	[Token(Token = "0x6001668")]
	[Address(RVA = "0x980648", Offset = "0x980648", VA = "0x980648", Slot = "7")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x6001669")]
	[Address(RVA = "0x9807F0", Offset = "0x9807F0", VA = "0x9807F0", Slot = "9")]
	protected override void Start()
	{
	}

	[Token(Token = "0x600166A")]
	[Address(RVA = "0x980674", Offset = "0x980674", VA = "0x980674")]
	public void SetupReloadSequence([Optional] ReloadSequence reloaderSequence)
	{
	}

	[Token(Token = "0x600166B")]
	[Address(RVA = "0x9808AC", Offset = "0x9808AC", VA = "0x9808AC")]
	public void SetupFromData()
	{
	}

	[Token(Token = "0x600166C")]
	[Address(RVA = "0x980C20", Offset = "0x980C20", VA = "0x980C20")]
	private void Update()
	{
	}

	[Token(Token = "0x600166D")]
	[Address(RVA = "0x980D3C", Offset = "0x980D3C", VA = "0x980D3C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x617324", Offset = "0x617324")]
	private IEnumerator UpdateEnemiesTracking()
	{
		return null;
	}

	[Token(Token = "0x600166E")]
	[Address(RVA = "0x980E54", Offset = "0x980E54", VA = "0x980E54")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x617384", Offset = "0x617384")]
	private IEnumerator DoVolleyShoots(PlayerController playerController, Vector3 origin, Vector3 direction, VolleyPowerUp.VolleyData volleyData, Bullet lastBullet)
	{
		return null;
	}

	[Token(Token = "0x600166F")]
	[Address(RVA = "0x980F20", Offset = "0x980F20", VA = "0x980F20")]
	private void EnableTargetGlow(AIController aiController)
	{
	}

	[Token(Token = "0x6001670")]
	[Address(RVA = "0x9812C0", Offset = "0x9812C0", VA = "0x9812C0")]
	private void DisableTargetGlow(AIController aiController)
	{
	}

	[Token(Token = "0x6001671")]
	[Address(RVA = "0x980FD0", Offset = "0x980FD0", VA = "0x980FD0")]
	private void ActiveTargetGlow(AIController aiController, bool activate)
	{
	}

	[Token(Token = "0x6001672")]
	[Address(RVA = "0x980DA8", Offset = "0x980DA8", VA = "0x980DA8")]
	private void DisableAllTargetGlow()
	{
	}

	[Token(Token = "0x6001673")]
	[Address(RVA = "0x981334", Offset = "0x981334", VA = "0x981334", Slot = "10")]
	protected override void OnDestroy()
	{
	}

	[Token(Token = "0x6001674")]
	[Address(RVA = "0x9814D4", Offset = "0x9814D4", VA = "0x9814D4")]
	private void OnVariableChanged(object sender, DataModel.VariableChangedEventArgs args)
	{
	}

	[Token(Token = "0x6001677")]
	[Address(RVA = "0x97B510", Offset = "0x97B510", VA = "0x97B510")]
	public void TrackClosestEnemies(int enemiesToTrackNumber, float enemiesToTrackDistance, bool enemiesToTrackShowHighlight)
	{
	}

	[Token(Token = "0x6001678")]
	[Address(RVA = "0x9816A4", Offset = "0x9816A4", VA = "0x9816A4")]
	public Bullet Shoot(GameMonoBehaviour shooter, Vector3 origin, Vector3 direction)
	{
		return null;
	}

	[Token(Token = "0x6001679")]
	[Address(RVA = "0x982390", Offset = "0x982390", VA = "0x982390")]
	private List<AIController> GetClosestEnemies(PlayerController playerController)
	{
		return null;
	}

	[Token(Token = "0x600167A")]
	[Address(RVA = "0x9819FC", Offset = "0x9819FC", VA = "0x9819FC")]
	private Bullet DoSplitShoot(PlayerController playerController, Vector3 origin, Vector3 direction)
	{
		return null;
	}

	[Token(Token = "0x600167B")]
	[Address(RVA = "0x981CF0", Offset = "0x981CF0", VA = "0x981CF0")]
	private Bullet DoVolleyShoot(PlayerController playerController, Vector3 origin, Vector3 direction, VolleyPowerUp.VolleyData volleyData)
	{
		return null;
	}

	[Token(Token = "0x600167C")]
	[Address(RVA = "0x981D94", Offset = "0x981D94", VA = "0x981D94")]
	private Bullet DoCunningShoot()
	{
		return null;
	}

	[Token(Token = "0x600167D")]
	[Address(RVA = "0x982A6C", Offset = "0x982A6C", VA = "0x982A6C")]
	private void GetOriginAndDirection(Trackable tracker, out Vector3 origin, out Vector3 direction)
	{
	}

	[Token(Token = "0x600167E")]
	[Address(RVA = "0x982B54", Offset = "0x982B54", VA = "0x982B54")]
	private int AIControllersSortFunction(AIControllerDistance a, AIControllerDistance b)
	{
		return default(int);
	}

	[Token(Token = "0x600167F")]
	[Address(RVA = "0x981FD8", Offset = "0x981FD8", VA = "0x981FD8")]
	private Bullet DoShoot(PlayerController playerController, Vector3 origin, Vector3 direction, bool instaBullet, bool playSound, bool reduceAmmo, bool fireShotEvent, bool penetrateEverything, bool noFriendlyFire, long forceBulletID, ThirdPersonCharacter guidedArrowTarget, VolleyPowerUp.VolleyData volleyData, Bullet bulletToUse, bool playSoundOnImpact, bool isMinZoom)
	{
		return null;
	}

	[Token(Token = "0x6001680")]
	[Address(RVA = "0x982A28", Offset = "0x982A28", VA = "0x982A28")]
	private Bullet CreateNewBullet(PlayerController playerController)
	{
		return null;
	}

	[Token(Token = "0x6001681")]
	[Address(RVA = "0x982F2C", Offset = "0x982F2C", VA = "0x982F2C")]
	public void ReloadCompleted()
	{
	}

	[Token(Token = "0x6001682")]
	[Address(RVA = "0x982F6C", Offset = "0x982F6C", VA = "0x982F6C")]
	public void SetPowerUpActive(PowerUp powerUp)
	{
	}

	[Token(Token = "0x6001683")]
	[Address(RVA = "0x983258", Offset = "0x983258", VA = "0x983258")]
	public void SetPowerUpInactive(PowerUp powerUp, float delay = 1f)
	{
	}

	[Token(Token = "0x6001684")]
	[Address(RVA = "0x983554", Offset = "0x983554", VA = "0x983554")]
	public bool IsPowerUpActive(string powerUpResource)
	{
		return default(bool);
	}

	[Token(Token = "0x6001685")]
	[Address(RVA = "0x982B84", Offset = "0x982B84", VA = "0x982B84")]
	private GuidedArrowData GetGuidedArrowData(VolleyPowerUp.VolleyData volleyData, ThirdPersonCharacter guidedArrowTarget)
	{
		return null;
	}

	[Token(Token = "0x6001686")]
	[Address(RVA = "0x98367C", Offset = "0x98367C", VA = "0x98367C")]
	private float Fudge(float fudgeAmount)
	{
		return default(float);
	}

	[Token(Token = "0x6001687")]
	[Address(RVA = "0x982C54", Offset = "0x982C54", VA = "0x982C54")]
	public void PlayShootSound()
	{
	}

	[Token(Token = "0x6001688")]
	[Address(RVA = "0x98368C", Offset = "0x98368C", VA = "0x98368C")]
	public void SetReloadEnabled(bool isEnabled)
	{
	}

	[Token(Token = "0x6001689")]
	[Address(RVA = "0x983718", Offset = "0x983718", VA = "0x983718")]
	public Weapon()
	{
	}
}
