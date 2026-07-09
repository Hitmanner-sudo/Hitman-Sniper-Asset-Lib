using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using Technology;
using UnityEngine;

[Token(Token = "0x2000311")]
public class ReloadSequence : GameMonoBehaviour
{
	[Token(Token = "0x2000312")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x593384", Offset = "0x593384")]
	private sealed class _003CReload_003Ed__35 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4001121")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4001122")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4001123")]
		[FieldOffset(Offset = "0x20")]
		public ReloadSequence _003C_003E4__this;

		[Token(Token = "0x4001124")]
		[FieldOffset(Offset = "0x28")]
		private ReloadInteraction _003Caction_003E5__2;

		[Token(Token = "0x4001125")]
		[FieldOffset(Offset = "0x30")]
		private int _003Ci_003E5__3;

		[Token(Token = "0x4001126")]
		[FieldOffset(Offset = "0x38")]
		private IEnumerator _003Cenumerator_003E5__4;

		[Token(Token = "0x4001127")]
		[FieldOffset(Offset = "0x40")]
		private bool _003Ccompleted_003E5__5;

		[Token(Token = "0x4001128")]
		[FieldOffset(Offset = "0x41")]
		private bool _003CautoComplete_003E5__6;

		[Token(Token = "0x170002C8")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60012E9")]
			[Address(RVA = "0x8B40B4", Offset = "0x8B40B4", VA = "0x8B40B4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170002C9")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60012EB")]
			[Address(RVA = "0x8B40FC", Offset = "0x8B40FC", VA = "0x8B40FC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60012E6")]
		[Address(RVA = "0x8B3718", Offset = "0x8B3718", VA = "0x8B3718")]
		[DebuggerHidden]
		public _003CReload_003Ed__35(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60012E7")]
		[Address(RVA = "0x8B3744", Offset = "0x8B3744", VA = "0x8B3744", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60012E8")]
		[Address(RVA = "0x8B3748", Offset = "0x8B3748", VA = "0x8B3748", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60012EA")]
		[Address(RVA = "0x8B40BC", Offset = "0x8B40BC", VA = "0x8B40BC", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x2000313")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x593394", Offset = "0x593394")]
	private sealed class _003C_003Ec__DisplayClass37_0
	{
		[Token(Token = "0x4001129")]
		[FieldOffset(Offset = "0x10")]
		public GameObject debugLabel;

		[Token(Token = "0x60012EC")]
		[Address(RVA = "0x8B2DAC", Offset = "0x8B2DAC", VA = "0x8B2DAC")]
		public _003C_003Ec__DisplayClass37_0()
		{
		}

		[Token(Token = "0x60012ED")]
		[Address(RVA = "0x8B2DB4", Offset = "0x8B2DB4", VA = "0x8B2DB4")]
		internal bool _003CDisplayDebugInfo_003Eb__0(GameObject go)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2000314")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5933A4", Offset = "0x5933A4")]
	private sealed class _003CDisplayDebugInfo_003Ed__37 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400112A")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400112B")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400112C")]
		[FieldOffset(Offset = "0x20")]
		public ReloadSequence _003C_003E4__this;

		[Token(Token = "0x400112D")]
		[FieldOffset(Offset = "0x28")]
		public string info;

		[Token(Token = "0x400112E")]
		[FieldOffset(Offset = "0x30")]
		private _003C_003Ec__DisplayClass37_0 _003C_003E8__1;

		[Token(Token = "0x400112F")]
		[FieldOffset(Offset = "0x38")]
		public float time;

		[Token(Token = "0x4001130")]
		[FieldOffset(Offset = "0x3C")]
		private float _003CelapsedTime_003E5__2;

		[Token(Token = "0x170002CA")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60012F1")]
			[Address(RVA = "0x8B36C8", Offset = "0x8B36C8", VA = "0x8B36C8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170002CB")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60012F3")]
			[Address(RVA = "0x8B3710", Offset = "0x8B3710", VA = "0x8B3710", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60012EE")]
		[Address(RVA = "0x8B2E2C", Offset = "0x8B2E2C", VA = "0x8B2E2C")]
		[DebuggerHidden]
		public _003CDisplayDebugInfo_003Ed__37(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60012EF")]
		[Address(RVA = "0x8B2E58", Offset = "0x8B2E58", VA = "0x8B2E58", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60012F0")]
		[Address(RVA = "0x8B2E5C", Offset = "0x8B2E5C", VA = "0x8B2E5C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60012F2")]
		[Address(RVA = "0x8B36D0", Offset = "0x8B36D0", VA = "0x8B36D0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x400110C")]
	[FieldOffset(Offset = "0x48")]
	public GestureConfig GestureConfig;

	[Token(Token = "0x400110D")]
	[FieldOffset(Offset = "0x50")]
	public string DebugLabelTemplateName;

	[Token(Token = "0x400110E")]
	[FieldOffset(Offset = "0x58")]
	public ReloadInteraction[] ReloadInteractions;

	[Token(Token = "0x400110F")]
	[FieldOffset(Offset = "0x60")]
	public float OutTransitionTime;

	[Token(Token = "0x4001110")]
	[FieldOffset(Offset = "0x64")]
	public float MinSwipeDist;

	[Token(Token = "0x4001111")]
	[FieldOffset(Offset = "0x68")]
	public float MaxSwipeDist;

	[Token(Token = "0x4001112")]
	[FieldOffset(Offset = "0x6C")]
	public float MinAnimationSpeed;

	[Token(Token = "0x4001113")]
	[FieldOffset(Offset = "0x70")]
	public float MaxAnimationSpeed;

	[Token(Token = "0x4001114")]
	[FieldOffset(Offset = "0x78")]
	public ModelContainer Models;

	[Token(Token = "0x4001115")]
	[FieldOffset(Offset = "0x80")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5B4080", Offset = "0x5B4080")]
	private int _003CReloadStage_003Ek__BackingField;

	[Token(Token = "0x4001116")]
	[FieldOffset(Offset = "0x88")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5B4090", Offset = "0x5B4090")]
	private Weapon _003CWeapon_003Ek__BackingField;

	[Token(Token = "0x4001117")]
	[FieldOffset(Offset = "0x90")]
	private GameObject _debugLabelGO;

	[Token(Token = "0x4001118")]
	[FieldOffset(Offset = "0x98")]
	private PlayerAnimatorController _playerAnim;

	[Token(Token = "0x4001119")]
	[FieldOffset(Offset = "0xA0")]
	private WeaponAnimatorController _weaponAnim;

	[Token(Token = "0x400111A")]
	[FieldOffset(Offset = "0xA8")]
	private CameraAnimatorController _cameraAnim;

	[Token(Token = "0x400111B")]
	[FieldOffset(Offset = "0xB0")]
	private PlayerController _player;

	[Token(Token = "0x400111C")]
	[FieldOffset(Offset = "0xB8")]
	private Coroutine _reloadCoroutine;

	[Token(Token = "0x400111D")]
	[FieldOffset(Offset = "0xC0")]
	private List<GameObject> _debugs;

	[Token(Token = "0x400111E")]
	[FieldOffset(Offset = "0xC8")]
	private float _lastTime;

	[Token(Token = "0x170002C6")]
	public int ReloadStage
	{
		[Token(Token = "0x60012D3")]
		[Address(RVA = "0x963B30", Offset = "0x963B30", VA = "0x963B30")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x616894", Offset = "0x616894")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60012D4")]
		[Address(RVA = "0x963B38", Offset = "0x963B38", VA = "0x963B38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6168A4", Offset = "0x6168A4")]
		private set
		{
		}
	}

	[Token(Token = "0x170002C7")]
	public Weapon Weapon
	{
		[Token(Token = "0x60012D5")]
		[Address(RVA = "0x963B40", Offset = "0x963B40", VA = "0x963B40")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6168B4", Offset = "0x6168B4")]
		get
		{
			return null;
		}
		[Token(Token = "0x60012D6")]
		[Address(RVA = "0x963B48", Offset = "0x963B48", VA = "0x963B48")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6168C4", Offset = "0x6168C4")]
		set
		{
		}
	}

	[Token(Token = "0x14000051")]
	public static event EventHandler OnReloadStarted
	{
		[Token(Token = "0x60012D7")]
		[Address(RVA = "0x963B50", Offset = "0x963B50", VA = "0x963B50")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6168D4", Offset = "0x6168D4")]
		add
		{
		}
		[Token(Token = "0x60012D8")]
		[Address(RVA = "0x963C0C", Offset = "0x963C0C", VA = "0x963C0C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6168E4", Offset = "0x6168E4")]
		remove
		{
		}
	}

	[Token(Token = "0x14000052")]
	public static event EventHandler OnReloadCompleted
	{
		[Token(Token = "0x60012D9")]
		[Address(RVA = "0x963CC8", Offset = "0x963CC8", VA = "0x963CC8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6168F4", Offset = "0x6168F4")]
		add
		{
		}
		[Token(Token = "0x60012DA")]
		[Address(RVA = "0x963D88", Offset = "0x963D88", VA = "0x963D88")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x616904", Offset = "0x616904")]
		remove
		{
		}
	}

	[Token(Token = "0x60012DB")]
	[Address(RVA = "0x963E48", Offset = "0x963E48", VA = "0x963E48")]
	private void OnVariableChanged(object sender, DataModel.VariableChangedEventArgs args)
	{
	}

	[Token(Token = "0x60012DC")]
	[Address(RVA = "0x96400C", Offset = "0x96400C", VA = "0x96400C", Slot = "7")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x60012DD")]
	[Address(RVA = "0x964138", Offset = "0x964138", VA = "0x964138", Slot = "10")]
	protected override void OnDestroy()
	{
	}

	[Token(Token = "0x60012DE")]
	[Address(RVA = "0x9643CC", Offset = "0x9643CC", VA = "0x9643CC", Slot = "9")]
	protected override void Start()
	{
	}

	[Token(Token = "0x60012DF")]
	[Address(RVA = "0x963FA0", Offset = "0x963FA0", VA = "0x963FA0")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x616914", Offset = "0x616914")]
	private IEnumerator Reload()
	{
		return null;
	}

	[Token(Token = "0x60012E0")]
	[Address(RVA = "0x964588", Offset = "0x964588", VA = "0x964588")]
	private void UpdateDrag(FingerInput.FingerID finger, Vector2 drag)
	{
	}

	[Token(Token = "0x60012E1")]
	[Address(RVA = "0x9646B0", Offset = "0x9646B0", VA = "0x9646B0")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x616974", Offset = "0x616974")]
	private IEnumerator DisplayDebugInfo(string info, float time)
	{
		return null;
	}

	[Token(Token = "0x60012E2")]
	[Address(RVA = "0x964738", Offset = "0x964738", VA = "0x964738")]
	public int GetCurrentReloadInteractionIndex()
	{
		return default(int);
	}

	[Token(Token = "0x60012E3")]
	[Address(RVA = "0x96465C", Offset = "0x96465C", VA = "0x96465C")]
	public ReloadInteraction GetCurrentReloadInteraction()
	{
		return null;
	}

	[Token(Token = "0x60012E4")]
	[Address(RVA = "0x964748", Offset = "0x964748", VA = "0x964748")]
	public ReloadSequence()
	{
	}

	[Token(Token = "0x60012E5")]
	[Address(RVA = "0x9647F0", Offset = "0x9647F0", VA = "0x9647F0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6169D4", Offset = "0x6169D4")]
	private void _003CStart_003Eb__34_0(ReloadInteraction r)
	{
	}
}
