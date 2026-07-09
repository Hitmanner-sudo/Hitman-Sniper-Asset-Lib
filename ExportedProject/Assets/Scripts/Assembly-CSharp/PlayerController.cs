using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200047E")]
public class PlayerController : Controller
{
	[Token(Token = "0x200047F")]
	private struct MeshTransform
	{
		[Token(Token = "0x400189D")]
		[FieldOffset(Offset = "0x0")]
		public Vector3 Translation;

		[Token(Token = "0x400189E")]
		[FieldOffset(Offset = "0xC")]
		public bool HasTranslation;

		[Token(Token = "0x400189F")]
		[FieldOffset(Offset = "0x10")]
		public Quaternion Rotation;

		[Token(Token = "0x40018A0")]
		[FieldOffset(Offset = "0x20")]
		public bool HasRotation;

		[Token(Token = "0x40018A1")]
		[FieldOffset(Offset = "0x28")]
		public Transform Pivot;

		[Token(Token = "0x40018A2")]
		[FieldOffset(Offset = "0x30")]
		public Vector3 PivotOffset;
	}

	[Token(Token = "0x2000480")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x594BB0", Offset = "0x594BB0")]
	private sealed class _003CTakeScreenShootShoot_003Ed__40 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40018A3")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40018A4")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40018A5")]
		[FieldOffset(Offset = "0x20")]
		private ScoreManager _003CscoreManagerInstance_003E5__2;

		[Token(Token = "0x17000440")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6001B5B")]
			[Address(RVA = "0x8D369C", Offset = "0x8D369C", VA = "0x8D369C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000441")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6001B5D")]
			[Address(RVA = "0x8D36E4", Offset = "0x8D36E4", VA = "0x8D36E4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6001B58")]
		[Address(RVA = "0x8D3468", Offset = "0x8D3468", VA = "0x8D3468")]
		[DebuggerHidden]
		public _003CTakeScreenShootShoot_003Ed__40(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6001B59")]
		[Address(RVA = "0x8D3494", Offset = "0x8D3494", VA = "0x8D3494", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6001B5A")]
		[Address(RVA = "0x8D3498", Offset = "0x8D3498", VA = "0x8D3498", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6001B5C")]
		[Address(RVA = "0x8D36A4", Offset = "0x8D36A4", VA = "0x8D36A4", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x2000481")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x594BC0", Offset = "0x594BC0")]
	private sealed class _003CUpdateBoltCycle_003Ed__83 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40018A6")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40018A7")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40018A8")]
		[FieldOffset(Offset = "0x20")]
		public PlayerController _003C_003E4__this;

		[Token(Token = "0x40018A9")]
		[FieldOffset(Offset = "0x28")]
		public Timer timer;

		[Token(Token = "0x40018AA")]
		[FieldOffset(Offset = "0x30")]
		private bool _003CskipBolt_003E5__2;

		[Token(Token = "0x40018AB")]
		[FieldOffset(Offset = "0x38")]
		private WeaponSoundData _003CweaponSounds_003E5__3;

		[Token(Token = "0x17000442")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6001B61")]
			[Address(RVA = "0x8D39D4", Offset = "0x8D39D4", VA = "0x8D39D4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000443")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6001B63")]
			[Address(RVA = "0x8D3A1C", Offset = "0x8D3A1C", VA = "0x8D3A1C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6001B5E")]
		[Address(RVA = "0x8D36EC", Offset = "0x8D36EC", VA = "0x8D36EC")]
		[DebuggerHidden]
		public _003CUpdateBoltCycle_003Ed__83(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6001B5F")]
		[Address(RVA = "0x8D3718", Offset = "0x8D3718", VA = "0x8D3718", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6001B60")]
		[Address(RVA = "0x8D371C", Offset = "0x8D371C", VA = "0x8D371C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6001B62")]
		[Address(RVA = "0x8D39DC", Offset = "0x8D39DC", VA = "0x8D39DC", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x400187C")]
	[FieldOffset(Offset = "0x10")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5B6ADC", Offset = "0x5B6ADC")]
	private static PlayerController _003CLocalPlayer_003Ek__BackingField;

	[Token(Token = "0x400187D")]
	[FieldOffset(Offset = "0x50")]
	public bool IsLocal;

	[Token(Token = "0x400187E")]
	[FieldOffset(Offset = "0x58")]
	public ModelContainer Models;

	[Token(Token = "0x400187F")]
	[FieldOffset(Offset = "0x60")]
	private FirstPersonCharacter _firstPersonCharacter;

	[Token(Token = "0x4001880")]
	[FieldOffset(Offset = "0x68")]
	private GameTimer _timer;

	[Token(Token = "0x4001881")]
	[FieldOffset(Offset = "0x70")]
	private PlayerAnimatorController _playerAnim;

	[Token(Token = "0x4001882")]
	[FieldOffset(Offset = "0x78")]
	private WeaponAnimatorController _weaponAnim;

	[Token(Token = "0x4001883")]
	[FieldOffset(Offset = "0x80")]
	private Vector3 _aimPosition;

	[Token(Token = "0x4001884")]
	[FieldOffset(Offset = "0x8C")]
	private bool _autoBalistic;

	[Token(Token = "0x4001885")]
	[FieldOffset(Offset = "0x90")]
	private LineRenderer _lineRenderer;

	[Token(Token = "0x4001886")]
	[FieldOffset(Offset = "0x98")]
	private LineRenderer _backLineRenderer;

	[Token(Token = "0x4001887")]
	[FieldOffset(Offset = "0xA0")]
	private float _balisticStartTime;

	[Token(Token = "0x4001888")]
	[FieldOffset(Offset = "0xA4")]
	private Vector3 _desiredRootTranslation;

	[Token(Token = "0x4001889")]
	[FieldOffset(Offset = "0xB0")]
	private Quaternion _desiredRootRotation;

	[Token(Token = "0x400188A")]
	[FieldOffset(Offset = "0xC0")]
	private List<MeshTransform> _desiredMeshTransforms;

	[Token(Token = "0x400188B")]
	[FieldOffset(Offset = "0xC8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5B6AEC", Offset = "0x5B6AEC")]
	private Weapon _003CWeapon_003Ek__BackingField;

	[Token(Token = "0x400188E")]
	[FieldOffset(Offset = "0xE0")]
	private bool _shootRequest;

	[Token(Token = "0x400188F")]
	[FieldOffset(Offset = "0xE1")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5B6B1C", Offset = "0x5B6B1C")]
	private bool _003CBlockShooting_003Ek__BackingField;

	[Token(Token = "0x4001890")]
	[FieldOffset(Offset = "0xE8")]
	private PlayerFSM _fsm;

	[Token(Token = "0x4001891")]
	[FieldOffset(Offset = "0xF0")]
	private List<PlayerSystem> _systems;

	[Token(Token = "0x4001892")]
	[FieldOffset(Offset = "0xF8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5B6B2C", Offset = "0x5B6B2C")]
	private PlayerInputSystem _003CInput_003Ek__BackingField;

	[Token(Token = "0x4001893")]
	[FieldOffset(Offset = "0x100")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5B6B3C", Offset = "0x5B6B3C")]
	private PlayerCameraSystem _003CCamera_003Ek__BackingField;

	[Token(Token = "0x4001894")]
	[FieldOffset(Offset = "0x108")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5B6B4C", Offset = "0x5B6B4C")]
	private PlayerInstinctSystem _003CInstinct_003Ek__BackingField;

	[Token(Token = "0x4001895")]
	[FieldOffset(Offset = "0x110")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5B6B5C", Offset = "0x5B6B5C")]
	private PlayerScopeSystem _003CScope_003Ek__BackingField;

	[Token(Token = "0x4001896")]
	[FieldOffset(Offset = "0x118")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5B6B6C", Offset = "0x5B6B6C")]
	private PlayerOffsetsSystem _003COffsets_003Ek__BackingField;

	[Token(Token = "0x4001897")]
	[FieldOffset(Offset = "0x120")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5B6B7C", Offset = "0x5B6B7C")]
	private PlayerBreathingSystem _003CBreathing_003Ek__BackingField;

	[Token(Token = "0x4001898")]
	[FieldOffset(Offset = "0x128")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5B6B8C", Offset = "0x5B6B8C")]
	private PlayerSwaySystem _003CSway_003Ek__BackingField;

	[Token(Token = "0x4001899")]
	[FieldOffset(Offset = "0x130")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5B6B9C", Offset = "0x5B6B9C")]
	private PlayerRecoilSystem _003CRecoil_003Ek__BackingField;

	[Token(Token = "0x400189A")]
	[FieldOffset(Offset = "0x138")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5B6BAC", Offset = "0x5B6BAC")]
	private PlayerInertiaSystem _003CInertia_003Ek__BackingField;

	[Token(Token = "0x400189B")]
	[FieldOffset(Offset = "0x140")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5B6BBC", Offset = "0x5B6BBC")]
	private PlayerSlowMotionSystem _003CSlowMotion_003Ek__BackingField;

	[Token(Token = "0x400189C")]
	[FieldOffset(Offset = "0x148")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5B6BCC", Offset = "0x5B6BCC")]
	private PlayerTrackingSystem _003CTracking_003Ek__BackingField;

	[Token(Token = "0x1700042F")]
	public static PlayerController LocalPlayer
	{
		[Token(Token = "0x6001B0D")]
		[Address(RVA = "0xB86260", Offset = "0xB86260", VA = "0xB86260")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x617954", Offset = "0x617954")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001B0E")]
		[Address(RVA = "0xB862AC", Offset = "0xB862AC", VA = "0xB862AC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x617964", Offset = "0x617964")]
		private set
		{
		}
	}

	[Token(Token = "0x17000430")]
	public new FirstPersonCharacter Character
	{
		[Token(Token = "0x6001B0F")]
		[Address(RVA = "0xB862FC", Offset = "0xB862FC", VA = "0xB862FC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000431")]
	public bool AutoBalistic
	{
		[Token(Token = "0x6001B11")]
		[Address(RVA = "0xB86358", Offset = "0xB86358", VA = "0xB86358")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6001B10")]
		[Address(RVA = "0xB86304", Offset = "0xB86304", VA = "0xB86304")]
		set
		{
		}
	}

	[Token(Token = "0x17000432")]
	public Weapon Weapon
	{
		[Token(Token = "0x6001B2E")]
		[Address(RVA = "0xB88810", Offset = "0xB88810", VA = "0xB88810")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6179D4", Offset = "0x6179D4")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001B2F")]
		[Address(RVA = "0xB88818", Offset = "0xB88818", VA = "0xB88818")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6179E4", Offset = "0x6179E4")]
		private set
		{
		}
	}

	[Token(Token = "0x17000433")]
	public bool ShootRequest
	{
		[Token(Token = "0x6001B35")]
		[Address(RVA = "0xB88FEC", Offset = "0xB88FEC", VA = "0xB88FEC")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000434")]
	public bool BlockShooting
	{
		[Token(Token = "0x6001B36")]
		[Address(RVA = "0xB88FF4", Offset = "0xB88FF4", VA = "0xB88FF4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x617A34", Offset = "0x617A34")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6001B37")]
		[Address(RVA = "0xB88FFC", Offset = "0xB88FFC", VA = "0xB88FFC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x617A44", Offset = "0x617A44")]
		set
		{
		}
	}

	[Token(Token = "0x17000435")]
	public PlayerInputSystem Input
	{
		[Token(Token = "0x6001B41")]
		[Address(RVA = "0xB8958C", Offset = "0xB8958C", VA = "0xB8958C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x617AB4", Offset = "0x617AB4")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001B42")]
		[Address(RVA = "0xB89594", Offset = "0xB89594", VA = "0xB89594")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x617AC4", Offset = "0x617AC4")]
		private set
		{
		}
	}

	[Token(Token = "0x17000436")]
	public PlayerCameraSystem Camera
	{
		[Token(Token = "0x6001B43")]
		[Address(RVA = "0xB8959C", Offset = "0xB8959C", VA = "0xB8959C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x617AD4", Offset = "0x617AD4")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001B44")]
		[Address(RVA = "0xB895A4", Offset = "0xB895A4", VA = "0xB895A4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x617AE4", Offset = "0x617AE4")]
		private set
		{
		}
	}

	[Token(Token = "0x17000437")]
	public PlayerInstinctSystem Instinct
	{
		[Token(Token = "0x6001B45")]
		[Address(RVA = "0xB895AC", Offset = "0xB895AC", VA = "0xB895AC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x617AF4", Offset = "0x617AF4")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001B46")]
		[Address(RVA = "0xB895B4", Offset = "0xB895B4", VA = "0xB895B4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x617B04", Offset = "0x617B04")]
		private set
		{
		}
	}

	[Token(Token = "0x17000438")]
	public PlayerScopeSystem Scope
	{
		[Token(Token = "0x6001B47")]
		[Address(RVA = "0xB895BC", Offset = "0xB895BC", VA = "0xB895BC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x617B14", Offset = "0x617B14")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001B48")]
		[Address(RVA = "0xB895C4", Offset = "0xB895C4", VA = "0xB895C4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x617B24", Offset = "0x617B24")]
		private set
		{
		}
	}

	[Token(Token = "0x17000439")]
	public PlayerOffsetsSystem Offsets
	{
		[Token(Token = "0x6001B49")]
		[Address(RVA = "0xB895CC", Offset = "0xB895CC", VA = "0xB895CC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x617B34", Offset = "0x617B34")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001B4A")]
		[Address(RVA = "0xB895D4", Offset = "0xB895D4", VA = "0xB895D4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x617B44", Offset = "0x617B44")]
		private set
		{
		}
	}

	[Token(Token = "0x1700043A")]
	public PlayerBreathingSystem Breathing
	{
		[Token(Token = "0x6001B4B")]
		[Address(RVA = "0xB895DC", Offset = "0xB895DC", VA = "0xB895DC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x617B54", Offset = "0x617B54")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001B4C")]
		[Address(RVA = "0xB895E4", Offset = "0xB895E4", VA = "0xB895E4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x617B64", Offset = "0x617B64")]
		private set
		{
		}
	}

	[Token(Token = "0x1700043B")]
	public PlayerSwaySystem Sway
	{
		[Token(Token = "0x6001B4D")]
		[Address(RVA = "0xB895EC", Offset = "0xB895EC", VA = "0xB895EC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x617B74", Offset = "0x617B74")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001B4E")]
		[Address(RVA = "0xB895F4", Offset = "0xB895F4", VA = "0xB895F4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x617B84", Offset = "0x617B84")]
		private set
		{
		}
	}

	[Token(Token = "0x1700043C")]
	public PlayerRecoilSystem Recoil
	{
		[Token(Token = "0x6001B4F")]
		[Address(RVA = "0xB895FC", Offset = "0xB895FC", VA = "0xB895FC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x617B94", Offset = "0x617B94")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001B50")]
		[Address(RVA = "0xB89604", Offset = "0xB89604", VA = "0xB89604")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x617BA4", Offset = "0x617BA4")]
		private set
		{
		}
	}

	[Token(Token = "0x1700043D")]
	public PlayerInertiaSystem Inertia
	{
		[Token(Token = "0x6001B51")]
		[Address(RVA = "0xB8960C", Offset = "0xB8960C", VA = "0xB8960C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x617BB4", Offset = "0x617BB4")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001B52")]
		[Address(RVA = "0xB89614", Offset = "0xB89614", VA = "0xB89614")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x617BC4", Offset = "0x617BC4")]
		private set
		{
		}
	}

	[Token(Token = "0x1700043E")]
	public PlayerSlowMotionSystem SlowMotion
	{
		[Token(Token = "0x6001B53")]
		[Address(RVA = "0xB8961C", Offset = "0xB8961C", VA = "0xB8961C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x617BD4", Offset = "0x617BD4")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001B54")]
		[Address(RVA = "0xB89624", Offset = "0xB89624", VA = "0xB89624")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x617BE4", Offset = "0x617BE4")]
		private set
		{
		}
	}

	[Token(Token = "0x1700043F")]
	public PlayerTrackingSystem Tracking
	{
		[Token(Token = "0x6001B55")]
		[Address(RVA = "0xB8962C", Offset = "0xB8962C", VA = "0xB8962C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x617BF4", Offset = "0x617BF4")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001B56")]
		[Address(RVA = "0xB89634", Offset = "0xB89634", VA = "0xB89634")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x617C04", Offset = "0x617C04")]
		private set
		{
		}
	}

	[Token(Token = "0x14000066")]
	public static event EventHandler PlayerAdded
	{
		[Token(Token = "0x6001B09")]
		[Address(RVA = "0xB85F68", Offset = "0xB85F68", VA = "0xB85F68")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x617914", Offset = "0x617914")]
		add
		{
		}
		[Token(Token = "0x6001B0A")]
		[Address(RVA = "0xB86024", Offset = "0xB86024", VA = "0xB86024")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x617924", Offset = "0x617924")]
		remove
		{
		}
	}

	[Token(Token = "0x14000067")]
	public static event EventHandler PlayerRemoved
	{
		[Token(Token = "0x6001B0B")]
		[Address(RVA = "0xB860E0", Offset = "0xB860E0", VA = "0xB860E0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x617934", Offset = "0x617934")]
		add
		{
		}
		[Token(Token = "0x6001B0C")]
		[Address(RVA = "0xB861A0", Offset = "0xB861A0", VA = "0xB861A0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x617944", Offset = "0x617944")]
		remove
		{
		}
	}

	[Token(Token = "0x14000068")]
	public event EventHandler OnWeaponAttached
	{
		[Token(Token = "0x6001B30")]
		[Address(RVA = "0xB88820", Offset = "0xB88820", VA = "0xB88820")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6179F4", Offset = "0x6179F4")]
		add
		{
		}
		[Token(Token = "0x6001B31")]
		[Address(RVA = "0xB888C0", Offset = "0xB888C0", VA = "0xB888C0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x617A04", Offset = "0x617A04")]
		remove
		{
		}
	}

	[Token(Token = "0x14000069")]
	public event EventHandler OnWeaponAttachedCompleted
	{
		[Token(Token = "0x6001B32")]
		[Address(RVA = "0xB88960", Offset = "0xB88960", VA = "0xB88960")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x617A14", Offset = "0x617A14")]
		add
		{
		}
		[Token(Token = "0x6001B33")]
		[Address(RVA = "0xB88A00", Offset = "0xB88A00", VA = "0xB88A00")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x617A24", Offset = "0x617A24")]
		remove
		{
		}
	}

	[Token(Token = "0x6001B12")]
	[Address(RVA = "0xB86360", Offset = "0xB86360", VA = "0xB86360", Slot = "7")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x6001B13")]
	[Address(RVA = "0xB867D0", Offset = "0xB867D0", VA = "0xB867D0", Slot = "9")]
	protected override void Start()
	{
	}

	[Token(Token = "0x6001B14")]
	[Address(RVA = "0xB86850", Offset = "0xB86850", VA = "0xB86850", Slot = "10")]
	protected override void OnDestroy()
	{
	}

	[Token(Token = "0x6001B15")]
	[Address(RVA = "0xB86BD0", Offset = "0xB86BD0", VA = "0xB86BD0", Slot = "5")]
	protected override void GameUpdate()
	{
	}

	[Token(Token = "0x6001B16")]
	[Address(RVA = "0xB8630C", Offset = "0xB8630C", VA = "0xB8630C")]
	private void SetAutoBalistic(bool enable)
	{
	}

	[Token(Token = "0x6001B17")]
	[Address(RVA = "0xB86E14", Offset = "0xB86E14", VA = "0xB86E14")]
	private void CreateBalisticAidUI()
	{
	}

	[Token(Token = "0x6001B18")]
	[Address(RVA = "0xB8707C", Offset = "0xB8707C", VA = "0xB8707C")]
	private void CreateLineRenderer(LazyGameObject prefab, ref LineRenderer lineRenderer)
	{
	}

	[Token(Token = "0x6001B19")]
	[Address(RVA = "0xB86F48", Offset = "0xB86F48", VA = "0xB86F48")]
	private void DestroyBalisticAidUI()
	{
	}

	[Token(Token = "0x6001B1A")]
	[Address(RVA = "0xB87328", Offset = "0xB87328", VA = "0xB87328")]
	private void OnPlayerAim(object sender, PlayerRootFSM.Sniping.AimInfo e)
	{
	}

	[Token(Token = "0x6001B1B")]
	[Address(RVA = "0xB86CBC", Offset = "0xB86CBC", VA = "0xB86CBC")]
	private void UpdateBalisticVisual()
	{
	}

	[Token(Token = "0x6001B1C")]
	[Address(RVA = "0xB874E8", Offset = "0xB874E8", VA = "0xB874E8")]
	private void GetBalisticValues(out Vector3 startPos, out Vector3 impulse, out Vector3 acceleration, out float time)
	{
	}

	[Token(Token = "0x6001B1D")]
	[Address(RVA = "0xB87710", Offset = "0xB87710", VA = "0xB87710")]
	private void SetupPoints(Vector3 startPos, Vector3 impulse, Vector3 acceleration, float totalTime, int pointCount, LineRenderer lineRenderer)
	{
	}

	[Token(Token = "0x6001B1E")]
	[Address(RVA = "0xB87950", Offset = "0xB87950", VA = "0xB87950")]
	private void SetupPointsSimple(Vector3 startPos, Vector3 impulse, Vector3 acceleration, float totalTime, int pointCount, LineRenderer lineRenderer)
	{
	}

	[Token(Token = "0x6001B1F")]
	[Address(RVA = "0xB87A64", Offset = "0xB87A64", VA = "0xB87A64", Slot = "6")]
	protected override void LateGameUpdate()
	{
	}

	[Token(Token = "0x6001B20")]
	[Address(RVA = "0xB87B54", Offset = "0xB87B54", VA = "0xB87B54")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x617974", Offset = "0x617974")]
	private IEnumerator TakeScreenShootShoot()
	{
		return null;
	}

	[Token(Token = "0x6001B21")]
	[Address(RVA = "0xB87BB0", Offset = "0xB87BB0", VA = "0xB87BB0")]
	public void ResetDesiredRootRotation()
	{
	}

	[Token(Token = "0x6001B22")]
	[Address(RVA = "0xB87BDC", Offset = "0xB87BDC", VA = "0xB87BDC", Slot = "14")]
	public override void SetCharacter(Character character)
	{
	}

	[Token(Token = "0x6001B23")]
	[Address(RVA = "0xB87CE4", Offset = "0xB87CE4", VA = "0xB87CE4")]
	public void AddRootTransform(Vector3 translation)
	{
	}

	[Token(Token = "0x6001B24")]
	[Address(RVA = "0xB85D28", Offset = "0xB85D28", VA = "0xB85D28")]
	public void AddRootTransform(Quaternion rotation)
	{
	}

	[Token(Token = "0x6001B25")]
	[Address(RVA = "0xB87D04", Offset = "0xB87D04", VA = "0xB87D04")]
	public void AddRootTransform(Vector3 translation, Quaternion rotation)
	{
	}

	[Token(Token = "0x6001B26")]
	[Address(RVA = "0xB84570", Offset = "0xB84570", VA = "0xB84570")]
	public void AddCharacterTransform(Vector3 translation)
	{
	}

	[Token(Token = "0x6001B27")]
	[Address(RVA = "0xB87D6C", Offset = "0xB87D6C", VA = "0xB87D6C")]
	public void AddCharacterTransform(Quaternion rotation)
	{
	}

	[Token(Token = "0x6001B28")]
	[Address(RVA = "0xB87EB8", Offset = "0xB87EB8", VA = "0xB87EB8")]
	public void AddCharacterTransform(Quaternion rotation, Transform pivot)
	{
	}

	[Token(Token = "0x6001B29")]
	[Address(RVA = "0xB87FDC", Offset = "0xB87FDC", VA = "0xB87FDC")]
	public void AddCharacterTransform(Quaternion rotation, Transform pivot, Vector3 pivotOffset)
	{
	}

	[Token(Token = "0x6001B2A")]
	[Address(RVA = "0xB880F8", Offset = "0xB880F8", VA = "0xB880F8")]
	public void AddCharacterTransform(Vector3 translation, Quaternion rotation)
	{
	}

	[Token(Token = "0x6001B2B")]
	[Address(RVA = "0xB8823C", Offset = "0xB8823C", VA = "0xB8823C")]
	public void AddCharacterTransform(Vector3 translation, Quaternion rotation, Transform pivot)
	{
	}

	[Token(Token = "0x6001B2C")]
	[Address(RVA = "0xB88358", Offset = "0xB88358", VA = "0xB88358")]
	public void AddCharacterTransform(Vector3 translation, Quaternion rotation, Transform pivot, Vector3 pivotOffset)
	{
	}

	[Token(Token = "0x6001B2D")]
	[Address(RVA = "0xB88474", Offset = "0xB88474", VA = "0xB88474")]
	public void UpdateCharacterTransform()
	{
	}

	[Token(Token = "0x6001B34")]
	[Address(RVA = "0xB88AA0", Offset = "0xB88AA0", VA = "0xB88AA0")]
	public void TrySetupWeapon()
	{
	}

	[Token(Token = "0x6001B38")]
	[Address(RVA = "0xB89008", Offset = "0xB89008", VA = "0xB89008")]
	private void OnVariableChanged(object sender, DataModel.VariableChangedEventArgs args)
	{
	}

	[Token(Token = "0x6001B39")]
	[Address(RVA = "0xB89144", Offset = "0xB89144", VA = "0xB89144")]
	public void TryShoot()
	{
	}

	[Token(Token = "0x6001B3A")]
	[Address(RVA = "0xB89180", Offset = "0xB89180", VA = "0xB89180")]
	private Bullet NormalShoot()
	{
		return null;
	}

	[Token(Token = "0x6001B3B")]
	[Address(RVA = "0xB89230", Offset = "0xB89230", VA = "0xB89230")]
	private Bullet AutoBalisticShoot()
	{
		return null;
	}

	[Token(Token = "0x6001B3C")]
	[Address(RVA = "0xB8930C", Offset = "0xB8930C", VA = "0xB8930C")]
	public Bullet Shoot()
	{
		return null;
	}

	[Token(Token = "0x6001B3D")]
	[Address(RVA = "0xB8940C", Offset = "0xB8940C", VA = "0xB8940C")]
	public void TakeScreenShoot()
	{
	}

	[Token(Token = "0x6001B3E")]
	[Address(RVA = "0xB894B4", Offset = "0xB894B4", VA = "0xB894B4")]
	public void StartUpdateBoltCyclePlayerTime()
	{
	}

	[Token(Token = "0x6001B3F")]
	[Address(RVA = "0xB89394", Offset = "0xB89394", VA = "0xB89394")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x617A54", Offset = "0x617A54")]
	private IEnumerator UpdateBoltCycle(Timer timer)
	{
		return null;
	}

	[Token(Token = "0x6001B40")]
	[Address(RVA = "0xB89524", Offset = "0xB89524", VA = "0xB89524")]
	private void SetBoltCycleSpeed(float timeForBoltCycleAnim)
	{
	}

	[Token(Token = "0x6001B57")]
	[Address(RVA = "0xB8963C", Offset = "0xB8963C", VA = "0xB8963C")]
	public PlayerController()
	{
	}
}
