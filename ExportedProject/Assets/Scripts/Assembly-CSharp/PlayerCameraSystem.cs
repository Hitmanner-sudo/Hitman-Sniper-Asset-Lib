using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20004D1")]
public class PlayerCameraSystem : PlayerSystem
{
	[Token(Token = "0x20004D2")]
	public enum CameraRectState
	{
		[Token(Token = "0x40019BB")]
		NONE = 0,
		[Token(Token = "0x40019BC")]
		InScope = 1,
		[Token(Token = "0x40019BD")]
		InScopeReloading = 2,
		[Token(Token = "0x40019BE")]
		OutOfScope = 3
	}

	[Token(Token = "0x20004D3")]
	public class MovingAimingCamera : EventArgs
	{
		[Token(Token = "0x40019BF")]
		[FieldOffset(Offset = "0x10")]
		public bool IsMoving;

		[Token(Token = "0x6001D92")]
		[Address(RVA = "0x8D33B4", Offset = "0x8D33B4", VA = "0x8D33B4")]
		public MovingAimingCamera()
		{
		}
	}

	[Token(Token = "0x20004D4")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x594E08", Offset = "0x594E08")]
	private sealed class _003CDoZombieSpecialIntro_003Ed__36 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40019C0")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40019C1")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40019C2")]
		[FieldOffset(Offset = "0x20")]
		public PlayerCameraSystem _003C_003E4__this;

		[Token(Token = "0x40019C3")]
		[FieldOffset(Offset = "0x28")]
		public ZombieSpecialIntro.IntroInfo zombieSpecialIntroInfo;

		[Token(Token = "0x40019C4")]
		[FieldOffset(Offset = "0x50")]
		private Vector3 _003CpreviousPosition_003E5__2;

		[Token(Token = "0x40019C5")]
		[FieldOffset(Offset = "0x5C")]
		private Quaternion _003CpreviousRotation_003E5__3;

		[Token(Token = "0x40019C6")]
		[FieldOffset(Offset = "0x6C")]
		private CameraRectState _003CpreviousCameraRectState_003E5__4;

		[Token(Token = "0x40019C7")]
		[FieldOffset(Offset = "0x70")]
		private float _003CpreviousFOV_003E5__5;

		[Token(Token = "0x40019C8")]
		[FieldOffset(Offset = "0x78")]
		private GameObject _003CinstinctCameraGO_003E5__6;

		[Token(Token = "0x40019C9")]
		[FieldOffset(Offset = "0x80")]
		private bool _003CpreviousInstinctCameraActive_003E5__7;

		[Token(Token = "0x40019CA")]
		[FieldOffset(Offset = "0x88")]
		private SplineWalker _003CsplineWalker_003E5__8;

		[Token(Token = "0x40019CB")]
		[FieldOffset(Offset = "0x90")]
		private ContinuousTimer _003Ctimer_003E5__9;

		[Token(Token = "0x40019CC")]
		[FieldOffset(Offset = "0x98")]
		private GameObject _003CintroUI_003E5__10;

		[Token(Token = "0x17000487")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6001D96")]
			[Address(RVA = "0x8D3418", Offset = "0x8D3418", VA = "0x8D3418", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000488")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6001D98")]
			[Address(RVA = "0x8D3460", Offset = "0x8D3460", VA = "0x8D3460", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6001D93")]
		[Address(RVA = "0x8D2C4C", Offset = "0x8D2C4C", VA = "0x8D2C4C")]
		[DebuggerHidden]
		public _003CDoZombieSpecialIntro_003Ed__36(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6001D94")]
		[Address(RVA = "0x8D2C78", Offset = "0x8D2C78", VA = "0x8D2C78", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6001D95")]
		[Address(RVA = "0x8D2C7C", Offset = "0x8D2C7C", VA = "0x8D2C7C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6001D97")]
		[Address(RVA = "0x8D3420", Offset = "0x8D3420", VA = "0x8D3420", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x40019A6")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private ModelContainer _modelContainer;

	[Token(Token = "0x40019A7")]
	[FieldOffset(Offset = "0x58")]
	public Camera AimingCamera;

	[Token(Token = "0x40019A8")]
	[FieldOffset(Offset = "0x60")]
	public Camera FirstPersonCamera;

	[Token(Token = "0x40019A9")]
	[FieldOffset(Offset = "0x68")]
	public bool CalculateFOV;

	[Token(Token = "0x40019AA")]
	[FieldOffset(Offset = "0x70")]
	public GrayscaleEffect GrayscaleEffect;

	[Token(Token = "0x40019AB")]
	[FieldOffset(Offset = "0x78")]
	private Vector3 _aimAngle;

	[Token(Token = "0x40019AC")]
	[FieldOffset(Offset = "0x84")]
	private Vector3 _deltaAimAngle;

	[Token(Token = "0x40019AD")]
	[FieldOffset(Offset = "0x90")]
	private Vector3 _initialAimAngle;

	[Token(Token = "0x40019AE")]
	[FieldOffset(Offset = "0x9C")]
	private bool _hasSoundThreshold;

	[Token(Token = "0x40019AF")]
	[FieldOffset(Offset = "0xA0")]
	private float _lastSwipeSoundTime;

	[Token(Token = "0x40019B0")]
	[FieldOffset(Offset = "0xA4")]
	private Vector3 _lastDeltaAimAngles;

	[Token(Token = "0x40019B1")]
	[FieldOffset(Offset = "0xB0")]
	private PlayerSpawnerData _spawnerData;

	[Token(Token = "0x40019B2")]
	[FieldOffset(Offset = "0xB8")]
	private bool _isAxisInverted;

	[Token(Token = "0x40019B3")]
	[FieldOffset(Offset = "0xC0")]
	private Transform _aimingCameraTransform;

	[Token(Token = "0x40019B4")]
	[FieldOffset(Offset = "0xC8")]
	private Coroutine _moveAimingCameraCoroutine;

	[Token(Token = "0x40019B5")]
	[FieldOffset(Offset = "0xD0")]
	private CameraRectState _previousCameraRectState;

	[Token(Token = "0x40019B6")]
	[FieldOffset(Offset = "0xD4")]
	private float _previousFOV;

	[Token(Token = "0x40019B7")]
	public const float IN_SCOPE_CAMERA_MAX_RATIO = 0.92f;

	[Token(Token = "0x40019B8")]
	[FieldOffset(Offset = "0xD8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5B72F4", Offset = "0x5B72F4")]
	private Vector3 _003CLastMovement_003Ek__BackingField;

	[Token(Token = "0x17000485")]
	public Vector3 LastMovement
	{
		[Token(Token = "0x6001D77")]
		[Address(RVA = "0xB846FC", Offset = "0xB846FC", VA = "0xB846FC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6187D8", Offset = "0x6187D8")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x6001D78")]
		[Address(RVA = "0xB84708", Offset = "0xB84708", VA = "0xB84708")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6187E8", Offset = "0x6187E8")]
		private set
		{
		}
	}

	[Token(Token = "0x17000486")]
	private PlayerSpawnerData SpawnerData
	{
		[Token(Token = "0x6001D79")]
		[Address(RVA = "0xB84714", Offset = "0xB84714", VA = "0xB84714")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x14000073")]
	public static event EventHandler<MovingAimingCamera> OnMovingAimingCamera
	{
		[Token(Token = "0x6001D7A")]
		[Address(RVA = "0xB84878", Offset = "0xB84878", VA = "0xB84878")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6187F8", Offset = "0x6187F8")]
		add
		{
		}
		[Token(Token = "0x6001D7B")]
		[Address(RVA = "0xB84934", Offset = "0xB84934", VA = "0xB84934")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x618808", Offset = "0x618808")]
		remove
		{
		}
	}

	[Token(Token = "0x6001D7C")]
	[Address(RVA = "0xB849F0", Offset = "0xB849F0", VA = "0xB849F0", Slot = "9")]
	protected override void Start()
	{
	}

	[Token(Token = "0x6001D7D")]
	[Address(RVA = "0xB84CF4", Offset = "0xB84CF4", VA = "0xB84CF4")]
	private void OnVariableChanged(object sender, DataModel.VariableChangedEventArgs e)
	{
	}

	[Token(Token = "0x6001D7E")]
	[Address(RVA = "0xB84E84", Offset = "0xB84E84", VA = "0xB84E84", Slot = "14")]
	public override void Execute()
	{
	}

	[Token(Token = "0x6001D7F")]
	[Address(RVA = "0xB855BC", Offset = "0xB855BC", VA = "0xB855BC", Slot = "10")]
	protected override void OnDestroy()
	{
	}

	[Token(Token = "0x6001D80")]
	[Address(RVA = "0xB85320", Offset = "0xB85320", VA = "0xB85320")]
	private void UpdateSwipeSound(float swipeMagnitude)
	{
	}

	[Token(Token = "0x6001D81")]
	[Address(RVA = "0xB856C0", Offset = "0xB856C0", VA = "0xB856C0", Slot = "16")]
	public override void Reset()
	{
	}

	[Token(Token = "0x6001D82")]
	[Address(RVA = "0xB856EC", Offset = "0xB856EC", VA = "0xB856EC")]
	public void ZombieSpecialIntro(ZombieSpecialIntro.IntroInfo zombieSpecialIntroInfo)
	{
	}

	[Token(Token = "0x6001D83")]
	[Address(RVA = "0xB85748", Offset = "0xB85748", VA = "0xB85748")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x618818", Offset = "0x618818")]
	private IEnumerator DoZombieSpecialIntro(ZombieSpecialIntro.IntroInfo zombieSpecialIntroInfo)
	{
		return null;
	}

	[Token(Token = "0x6001D84")]
	[Address(RVA = "0xB857D4", Offset = "0xB857D4", VA = "0xB857D4")]
	public void UpdateProjectionMatrix(float fov, CameraRectState cameraRectState, bool forceUpdate = false)
	{
	}

	[Token(Token = "0x6001D85")]
	[Address(RVA = "0xB850F4", Offset = "0xB850F4", VA = "0xB850F4")]
	private Vector2 GetLookYawLimits()
	{
		return default(Vector2);
	}

	[Token(Token = "0x6001D86")]
	[Address(RVA = "0xB851F8", Offset = "0xB851F8", VA = "0xB851F8")]
	private Vector2 GetLookPitchLimits()
	{
		return default(Vector2);
	}

	[Token(Token = "0x6001D87")]
	[Address(RVA = "0xB852A0", Offset = "0xB852A0", VA = "0xB852A0")]
	private float ClampAngle(float angle, float min, float max)
	{
		return default(float);
	}

	[Token(Token = "0x6001D88")]
	[Address(RVA = "0xB85B24", Offset = "0xB85B24", VA = "0xB85B24")]
	public void AddAimingAngleDelta(Vector3 deltaAngle)
	{
	}

	[Token(Token = "0x6001D89")]
	[Address(RVA = "0xB85B44", Offset = "0xB85B44", VA = "0xB85B44")]
	public void SetAimingAngle(Vector3 angle)
	{
	}

	[Token(Token = "0x6001D8A")]
	[Address(RVA = "0xB85CE8", Offset = "0xB85CE8", VA = "0xB85CE8")]
	public Vector2 GetAimingAngle()
	{
		return default(Vector2);
	}

	[Token(Token = "0x6001D8B")]
	[Address(RVA = "0xB85CF0", Offset = "0xB85CF0", VA = "0xB85CF0", Slot = "15")]
	public override void ApplyToCharacter()
	{
	}

	[Token(Token = "0x6001D8C")]
	[Address(RVA = "0xB85D74", Offset = "0xB85D74", VA = "0xB85D74")]
	public void SetFOV(float fov)
	{
	}

	[Token(Token = "0x6001D8D")]
	[Address(RVA = "0xB85DB8", Offset = "0xB85DB8", VA = "0xB85DB8")]
	public void EnableLensRender()
	{
	}

	[Token(Token = "0x6001D8E")]
	[Address(RVA = "0xB85E1C", Offset = "0xB85E1C", VA = "0xB85E1C")]
	public void DisableLensRender()
	{
	}

	[Token(Token = "0x6001D8F")]
	[Address(RVA = "0xB85E80", Offset = "0xB85E80", VA = "0xB85E80")]
	public void EnableScopeBackgroundRender()
	{
	}

	[Token(Token = "0x6001D90")]
	[Address(RVA = "0xB85EBC", Offset = "0xB85EBC", VA = "0xB85EBC")]
	public void DisableScopeBackgroundRender()
	{
	}

	[Token(Token = "0x6001D91")]
	[Address(RVA = "0xB85EF8", Offset = "0xB85EF8", VA = "0xB85EF8")]
	public PlayerCameraSystem()
	{
	}
}
