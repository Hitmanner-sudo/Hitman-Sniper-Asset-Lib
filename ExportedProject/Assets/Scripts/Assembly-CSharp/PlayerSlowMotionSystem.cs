using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using Technology;
using UnityEngine;

[Token(Token = "0x20004DF")]
public class PlayerSlowMotionSystem : PlayerSystem
{
	[Token(Token = "0x20004E0")]
	public class SlowMotionActivatedEventArgs : EventArgs
	{
		[Token(Token = "0x4001A27")]
		[FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5B740C", Offset = "0x5B740C")]
		private bool _003CActivated_003Ek__BackingField;

		[Token(Token = "0x170004A8")]
		public bool Activated
		{
			[Token(Token = "0x6001E0B")]
			[Address(RVA = "0x8ABD84", Offset = "0x8ABD84", VA = "0x8ABD84")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x618B18", Offset = "0x618B18")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001E0C")]
			[Address(RVA = "0x8ABD8C", Offset = "0x8ABD8C", VA = "0x8ABD8C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x618B28", Offset = "0x618B28")]
			set
			{
			}
		}

		[Token(Token = "0x6001E0D")]
		[Address(RVA = "0x8ABD98", Offset = "0x8ABD98", VA = "0x8ABD98")]
		public SlowMotionActivatedEventArgs()
		{
		}
	}

	[Token(Token = "0x20004E1")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x594E28", Offset = "0x594E28")]
	private sealed class _003CResetOutOfBreath_003Ed__42 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4001A28")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4001A29")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4001A2A")]
		[FieldOffset(Offset = "0x20")]
		public PlayerSlowMotionSystem _003C_003E4__this;

		[Token(Token = "0x170004A9")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6001E11")]
			[Address(RVA = "0x8ABD34", Offset = "0x8ABD34", VA = "0x8ABD34", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170004AA")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6001E13")]
			[Address(RVA = "0x8ABD7C", Offset = "0x8ABD7C", VA = "0x8ABD7C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6001E0E")]
		[Address(RVA = "0x8ABB00", Offset = "0x8ABB00", VA = "0x8ABB00")]
		[DebuggerHidden]
		public _003CResetOutOfBreath_003Ed__42(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6001E0F")]
		[Address(RVA = "0x8ABB2C", Offset = "0x8ABB2C", VA = "0x8ABB2C", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6001E10")]
		[Address(RVA = "0x8ABB30", Offset = "0x8ABB30", VA = "0x8ABB30", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6001E12")]
		[Address(RVA = "0x8ABD3C", Offset = "0x8ABD3C", VA = "0x8ABD3C", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x20004E2")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x594E38", Offset = "0x594E38")]
	private sealed class _003C_003Ec__DisplayClass48_0
	{
		[Token(Token = "0x4001A2B")]
		[FieldOffset(Offset = "0x10")]
		public float toPitch;

		[Token(Token = "0x6001E14")]
		[Address(RVA = "0x8D7260", Offset = "0x8D7260", VA = "0x8D7260")]
		public _003C_003Ec__DisplayClass48_0()
		{
		}
	}

	[Token(Token = "0x20004E3")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x594E48", Offset = "0x594E48")]
	private sealed class _003C_003Ec__DisplayClass48_1
	{
		[Token(Token = "0x4001A2C")]
		[FieldOffset(Offset = "0x10")]
		public int copy;

		[Token(Token = "0x4001A2D")]
		[FieldOffset(Offset = "0x18")]
		public _003C_003Ec__DisplayClass48_0 CS_0024_003C_003E8__locals1;

		[Token(Token = "0x6001E15")]
		[Address(RVA = "0x8D7268", Offset = "0x8D7268", VA = "0x8D7268")]
		public _003C_003Ec__DisplayClass48_1()
		{
		}

		[Token(Token = "0x6001E16")]
		[Address(RVA = "0x8D7270", Offset = "0x8D7270", VA = "0x8D7270")]
		internal void _003CActivateHoldBreath_003Eb__1()
		{
		}
	}

	[Token(Token = "0x20004E4")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x594E58", Offset = "0x594E58")]
	private sealed class _003CChangeCutoffFrequency_003Ed__50 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4001A2E")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4001A2F")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4001A30")]
		[FieldOffset(Offset = "0x20")]
		public PlayerSlowMotionSystem _003C_003E4__this;

		[Token(Token = "0x4001A31")]
		[FieldOffset(Offset = "0x28")]
		public float time;

		[Token(Token = "0x4001A32")]
		[FieldOffset(Offset = "0x2C")]
		public float toHz;

		[Token(Token = "0x4001A33")]
		[FieldOffset(Offset = "0x30")]
		public Action callback;

		[Token(Token = "0x4001A34")]
		[FieldOffset(Offset = "0x38")]
		private float _003CstartHz_003E5__2;

		[Token(Token = "0x4001A35")]
		[FieldOffset(Offset = "0x3C")]
		private float _003CstartTime_003E5__3;

		[Token(Token = "0x170004AB")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6001E1A")]
			[Address(RVA = "0x8D7548", Offset = "0x8D7548", VA = "0x8D7548", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170004AC")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6001E1C")]
			[Address(RVA = "0x8D7590", Offset = "0x8D7590", VA = "0x8D7590", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6001E17")]
		[Address(RVA = "0x8D7334", Offset = "0x8D7334", VA = "0x8D7334")]
		[DebuggerHidden]
		public _003CChangeCutoffFrequency_003Ed__50(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6001E18")]
		[Address(RVA = "0x8D7360", Offset = "0x8D7360", VA = "0x8D7360", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6001E19")]
		[Address(RVA = "0x8D7364", Offset = "0x8D7364", VA = "0x8D7364", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6001E1B")]
		[Address(RVA = "0x8D7550", Offset = "0x8D7550", VA = "0x8D7550", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x20004E5")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x594E68", Offset = "0x594E68")]
	private sealed class _003CChangePitch_003Ed__51 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4001A36")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4001A37")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4001A38")]
		[FieldOffset(Offset = "0x20")]
		public AudioBusName busName;

		[Token(Token = "0x4001A39")]
		[FieldOffset(Offset = "0x24")]
		public float time;

		[Token(Token = "0x4001A3A")]
		[FieldOffset(Offset = "0x28")]
		public float toPitch;

		[Token(Token = "0x4001A3B")]
		[FieldOffset(Offset = "0x30")]
		public Action callback;

		[Token(Token = "0x4001A3C")]
		[FieldOffset(Offset = "0x38")]
		public PlayerSlowMotionSystem _003C_003E4__this;

		[Token(Token = "0x4001A3D")]
		[FieldOffset(Offset = "0x40")]
		private AudioBus _003Cbus_003E5__2;

		[Token(Token = "0x4001A3E")]
		[FieldOffset(Offset = "0x48")]
		private float _003CstartPitch_003E5__3;

		[Token(Token = "0x4001A3F")]
		[FieldOffset(Offset = "0x4C")]
		private float _003CstartTime_003E5__4;

		[Token(Token = "0x170004AD")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6001E20")]
			[Address(RVA = "0x8ABAB0", Offset = "0x8ABAB0", VA = "0x8ABAB0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170004AE")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6001E22")]
			[Address(RVA = "0x8ABAF8", Offset = "0x8ABAF8", VA = "0x8ABAF8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6001E1D")]
		[Address(RVA = "0x8AB800", Offset = "0x8AB800", VA = "0x8AB800")]
		[DebuggerHidden]
		public _003CChangePitch_003Ed__51(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6001E1E")]
		[Address(RVA = "0x8AB82C", Offset = "0x8AB82C", VA = "0x8AB82C", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6001E1F")]
		[Address(RVA = "0x8AB830", Offset = "0x8AB830", VA = "0x8AB830", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6001E21")]
		[Address(RVA = "0x8ABAB8", Offset = "0x8ABAB8", VA = "0x8ABAB8", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x4001A0E")]
	[FieldOffset(Offset = "0x50")]
	private float _slowFactor;

	[Token(Token = "0x4001A0F")]
	[FieldOffset(Offset = "0x54")]
	private float _playerTimeSlowFactor;

	[Token(Token = "0x4001A10")]
	[FieldOffset(Offset = "0x58")]
	private float _headShotSlowMotionDuration;

	[Token(Token = "0x4001A11")]
	[FieldOffset(Offset = "0x5C")]
	public float SlowMotionMaxDuration;

	[Token(Token = "0x4001A12")]
	[FieldOffset(Offset = "0x60")]
	private AnimationCurve _slowMotionRefillRateCurve;

	[Token(Token = "0x4001A13")]
	[FieldOffset(Offset = "0x68")]
	private float _minimumRatioToBeActivated;

	[Token(Token = "0x4001A14")]
	[FieldOffset(Offset = "0x70")]
	public ModelContainer Models;

	[Token(Token = "0x4001A15")]
	[FieldOffset(Offset = "0x78")]
	public bool DoHeadShotSlowMo;

	[Token(Token = "0x4001A16")]
	[FieldOffset(Offset = "0x79")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5B73EC", Offset = "0x5B73EC")]
	private bool _003CWasOutOfBreath_003Ek__BackingField;

	[Token(Token = "0x4001A17")]
	[FieldOffset(Offset = "0x7C")]
	private float _lastHoldBreathTime;

	[Token(Token = "0x4001A18")]
	[FieldOffset(Offset = "0x80")]
	private GameRealTimer _slowMotionTimer;

	[Token(Token = "0x4001A19")]
	[FieldOffset(Offset = "0x88")]
	private float _curHoldBreathDuration;

	[Token(Token = "0x4001A1A")]
	[FieldOffset(Offset = "0x8C")]
	private bool _enabled;

	[Token(Token = "0x4001A1B")]
	[FieldOffset(Offset = "0x90")]
	private AudioLowPassFilter _filter;

	[Token(Token = "0x4001A1C")]
	[FieldOffset(Offset = "0x98")]
	private Coroutine _cutoffFrequencyCoroutine;

	[Token(Token = "0x4001A1D")]
	[FieldOffset(Offset = "0xA0")]
	private Coroutine[] _changePitchCoroutines;

	[Token(Token = "0x4001A1E")]
	[FieldOffset(Offset = "0xA8")]
	private bool _isPaused;

	[Token(Token = "0x4001A1F")]
	[FieldOffset(Offset = "0xB0")]
	private PlayingSoundContainer _holdBreathSound;

	[Token(Token = "0x4001A21")]
	[FieldOffset(Offset = "0xB8")]
	private GameTimer _timer;

	[Token(Token = "0x4001A22")]
	[FieldOffset(Offset = "0xC0")]
	public float ZoomModifier;

	[Token(Token = "0x4001A23")]
	[FieldOffset(Offset = "0xC4")]
	public float ZoomModifierInDamping;

	[Token(Token = "0x4001A24")]
	[FieldOffset(Offset = "0xC8")]
	public float ZoomModifierOutDamping;

	[Token(Token = "0x4001A25")]
	[FieldOffset(Offset = "0xCC")]
	private float _fovModifier;

	[Token(Token = "0x4001A26")]
	[FieldOffset(Offset = "0xD0")]
	private float _fovModifierSpeed;

	[Token(Token = "0x170004A3")]
	public bool IsHoldingBreath
	{
		[Token(Token = "0x6001DEB")]
		[Address(RVA = "0xAB7E58", Offset = "0xAB7E58", VA = "0xAB7E58")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6001DEC")]
		[Address(RVA = "0xAB7E60", Offset = "0xAB7E60", VA = "0xAB7E60")]
		private set
		{
		}
	}

	[Token(Token = "0x170004A4")]
	public float TimeSinceHoldBreath
	{
		[Token(Token = "0x6001DED")]
		[Address(RVA = "0xAB7EF4", Offset = "0xAB7EF4", VA = "0xAB7EF4")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x170004A5")]
	public bool WasOutOfBreath
	{
		[Token(Token = "0x6001DEE")]
		[Address(RVA = "0xAB7FB0", Offset = "0xAB7FB0", VA = "0xAB7FB0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6189A8", Offset = "0x6189A8")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6001DEF")]
		[Address(RVA = "0xAB7FB8", Offset = "0xAB7FB8", VA = "0xAB7FB8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6189B8", Offset = "0x6189B8")]
		private set
		{
		}
	}

	[Token(Token = "0x170004A6")]
	public float SlowMotionLeftTimeRatio
	{
		[Token(Token = "0x6001DF0")]
		[Address(RVA = "0xAB7FC4", Offset = "0xAB7FC4", VA = "0xAB7FC4")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x170004A7")]
	public float FOVModier
	{
		[Token(Token = "0x6001E06")]
		[Address(RVA = "0xAB9E90", Offset = "0xAB9E90", VA = "0xAB9E90")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x14000077")]
	public static event EventHandler<SlowMotionActivatedEventArgs> OnSlowMotionActivated
	{
		[Token(Token = "0x6001DF1")]
		[Address(RVA = "0xAB801C", Offset = "0xAB801C", VA = "0xAB801C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6189C8", Offset = "0x6189C8")]
		add
		{
		}
		[Token(Token = "0x6001DF2")]
		[Address(RVA = "0xAB80D8", Offset = "0xAB80D8", VA = "0xAB80D8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6189D8", Offset = "0x6189D8")]
		remove
		{
		}
	}

	[Token(Token = "0x6001DF3")]
	[Address(RVA = "0xAB8194", Offset = "0xAB8194", VA = "0xAB8194", Slot = "7")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x6001DF4")]
	[Address(RVA = "0xAB8370", Offset = "0xAB8370", VA = "0xAB8370", Slot = "9")]
	protected override void Start()
	{
	}

	[Token(Token = "0x6001DF5")]
	[Address(RVA = "0xAB8550", Offset = "0xAB8550", VA = "0xAB8550", Slot = "10")]
	protected override void OnDestroy()
	{
	}

	[Token(Token = "0x6001DF6")]
	[Address(RVA = "0xAB8914", Offset = "0xAB8914", VA = "0xAB8914")]
	private void OnCharacterDied(object sender, Character.DeathEvent args)
	{
	}

	[Token(Token = "0x6001DF7")]
	[Address(RVA = "0xAB93A0", Offset = "0xAB93A0", VA = "0xAB93A0")]
	private void OnGameEnded(object sender, EventArgs args)
	{
	}

	[Token(Token = "0x6001DF8")]
	[Address(RVA = "0xAB93B4", Offset = "0xAB93B4", VA = "0xAB93B4", Slot = "5")]
	protected override void GameUpdate()
	{
	}

	[Token(Token = "0x6001DF9")]
	[Address(RVA = "0xAB9724", Offset = "0xAB9724", VA = "0xAB9724")]
	private void OnVariableChanged(object sender, DataModel.VariableChangedEventArgs args)
	{
	}

	[Token(Token = "0x6001DFA")]
	[Address(RVA = "0xAB9904", Offset = "0xAB9904", VA = "0xAB9904")]
	private void OnWeaponAttachedCompleted(object sender, EventArgs args)
	{
	}

	[Token(Token = "0x6001DFB")]
	[Address(RVA = "0xAB9964", Offset = "0xAB9964", VA = "0xAB9964")]
	public void IncreaseSlowMotionMaxDuration(float duration)
	{
	}

	[Token(Token = "0x6001DFC")]
	[Address(RVA = "0xAB95A0", Offset = "0xAB95A0", VA = "0xAB95A0")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x6189E8", Offset = "0x6189E8")]
	private IEnumerator ResetOutOfBreath()
	{
		return null;
	}

	[Token(Token = "0x6001DFD")]
	[Address(RVA = "0xAB9854", Offset = "0xAB9854", VA = "0xAB9854")]
	public void ToggleHoldBreath()
	{
	}

	[Token(Token = "0x6001DFE")]
	[Address(RVA = "0xAB9280", Offset = "0xAB9280", VA = "0xAB9280")]
	private void ActivateSlowMotion(float duration)
	{
	}

	[Token(Token = "0x6001DFF")]
	[Address(RVA = "0xAB8784", Offset = "0xAB8784", VA = "0xAB8784")]
	private void DeactivateSlowMotion()
	{
	}

	[Token(Token = "0x6001E00")]
	[Address(RVA = "0xAB99FC", Offset = "0xAB99FC", VA = "0xAB99FC")]
	public bool IsPaused()
	{
		return default(bool);
	}

	[Token(Token = "0x6001E01")]
	[Address(RVA = "0xAB9A04", Offset = "0xAB9A04", VA = "0xAB9A04")]
	public void PauseSlowMotion()
	{
	}

	[Token(Token = "0x6001E02")]
	[Address(RVA = "0xAB8A40", Offset = "0xAB8A40", VA = "0xAB8A40")]
	public void ActivateHoldBreath(bool activate)
	{
	}

	[Token(Token = "0x6001E03")]
	[Address(RVA = "0xAB9A2C", Offset = "0xAB9A2C", VA = "0xAB9A2C")]
	private void PlayHoldBreathSound(SoundContainer sound)
	{
	}

	[Token(Token = "0x6001E04")]
	[Address(RVA = "0xAB9B18", Offset = "0xAB9B18", VA = "0xAB9B18")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x618A48", Offset = "0x618A48")]
	private IEnumerator ChangeCutoffFrequency(float toHz, float time, Action callback)
	{
		return null;
	}

	[Token(Token = "0x6001E05")]
	[Address(RVA = "0xAB9BA8", Offset = "0xAB9BA8", VA = "0xAB9BA8")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x618AA8", Offset = "0x618AA8")]
	private IEnumerator ChangePitch(AudioBusName busName, float toPitch, float time, Action callback)
	{
		return null;
	}

	[Token(Token = "0x6001E07")]
	[Address(RVA = "0xAB960C", Offset = "0xAB960C", VA = "0xAB960C")]
	private void UpdateFOVModifier()
	{
	}

	[Token(Token = "0x6001E08")]
	[Address(RVA = "0xAB9E98", Offset = "0xAB9E98", VA = "0xAB9E98")]
	public void SetSlowMotionEnabled(bool isEnabled)
	{
	}

	[Token(Token = "0x6001E09")]
	[Address(RVA = "0xAB9F3C", Offset = "0xAB9F3C", VA = "0xAB9F3C")]
	public PlayerSlowMotionSystem()
	{
	}

	[Token(Token = "0x6001E0A")]
	[Address(RVA = "0xABA1AC", Offset = "0xABA1AC", VA = "0xABA1AC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x618B08", Offset = "0x618B08")]
	private void _003CActivateHoldBreath_003Eb__48_0()
	{
	}
}
