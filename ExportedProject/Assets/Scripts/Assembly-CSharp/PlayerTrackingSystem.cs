using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20004E9")]
public class PlayerTrackingSystem : PlayerSystem
{
	[Token(Token = "0x20004EA")]
	private enum AssassinateState
	{
		[Token(Token = "0x4001A64")]
		Focus = 0,
		[Token(Token = "0x4001A65")]
		Shoot = 1,
		[Token(Token = "0x4001A66")]
		Wait = 2
	}

	[Token(Token = "0x20004EB")]
	public class TrackableLookedAt : EventArgs
	{
		[Token(Token = "0x4001A67")]
		[FieldOffset(Offset = "0x10")]
		public Target Target;

		[Token(Token = "0x6001E5E")]
		[Address(RVA = "0x8AC084", Offset = "0x8AC084", VA = "0x8AC084")]
		public TrackableLookedAt()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x20004EC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x594E78", Offset = "0x594E78")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x4001A68")]
		[FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x4001A69")]
		[FieldOffset(Offset = "0x8")]
		public static Predicate<Transform> _003C_003E9__47_0;

		[Token(Token = "0x4001A6A")]
		[FieldOffset(Offset = "0x10")]
		public static Predicate<Trackable> _003C_003E9__48_0;

		[Token(Token = "0x4001A6B")]
		[FieldOffset(Offset = "0x18")]
		public static Converter<Trackable, Transform> _003C_003E9__48_1;

		[Token(Token = "0x6001E60")]
		[Address(RVA = "0x8ABE7C", Offset = "0x8ABE7C", VA = "0x8ABE7C")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x6001E61")]
		[Address(RVA = "0x8ABE84", Offset = "0x8ABE84", VA = "0x8ABE84")]
		internal bool _003CUpdateAssassination_003Eb__47_0(Transform x)
		{
			return default(bool);
		}

		[Token(Token = "0x6001E62")]
		[Address(RVA = "0x8ABEEC", Offset = "0x8ABEEC", VA = "0x8ABEEC")]
		internal bool _003CAssassinateAllTags_003Eb__48_0(Trackable x)
		{
			return default(bool);
		}

		[Token(Token = "0x6001E63")]
		[Address(RVA = "0x8ABFB8", Offset = "0x8ABFB8", VA = "0x8ABFB8")]
		internal Transform _003CAssassinateAllTags_003Eb__48_1(Trackable x)
		{
			return null;
		}
	}

	[Token(Token = "0x20004ED")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x594E88", Offset = "0x594E88")]
	private sealed class _003C_003Ec__DisplayClass66_0
	{
		[Token(Token = "0x4001A6C")]
		[FieldOffset(Offset = "0x10")]
		public Transform t;

		[Token(Token = "0x6001E64")]
		[Address(RVA = "0x8ABFE4", Offset = "0x8ABFE4", VA = "0x8ABFE4")]
		public _003C_003Ec__DisplayClass66_0()
		{
		}

		[Token(Token = "0x6001E65")]
		[Address(RVA = "0x8ABFEC", Offset = "0x8ABFEC", VA = "0x8ABFEC")]
		internal bool _003CIsTagged_003Eb__0(Trackable tagged)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x4001A4E")]
	[FieldOffset(Offset = "0x50")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5B743C", Offset = "0x5B743C")]
	private int _003CMaxTaggingNumber_003Ek__BackingField;

	[NonSerialized]
	[Token(Token = "0x4001A4F")]
	[FieldOffset(Offset = "0x58")]
	public Trackable _lastLockedOnTarget;

	[Token(Token = "0x4001A50")]
	[FieldOffset(Offset = "0x60")]
	public float AssassinateWaitTimer;

	[Token(Token = "0x4001A51")]
	[FieldOffset(Offset = "0x68")]
	private List<Trackable> _trackers;

	[Token(Token = "0x4001A52")]
	[FieldOffset(Offset = "0x70")]
	private LinkedList<Trackable> _tags;

	[Token(Token = "0x4001A53")]
	[FieldOffset(Offset = "0x78")]
	private PlayerTimer _activateLockedOnTimer;

	[Token(Token = "0x4001A54")]
	[FieldOffset(Offset = "0x80")]
	private PlayerTimer _focusTimer;

	[Token(Token = "0x4001A55")]
	[FieldOffset(Offset = "0x88")]
	private Transform _focusTarget;

	[Token(Token = "0x4001A56")]
	[FieldOffset(Offset = "0x90")]
	private Transform _lastFocusTarget;

	[Token(Token = "0x4001A57")]
	[FieldOffset(Offset = "0x98")]
	private Vector3 _startFocusDirection;

	[Token(Token = "0x4001A58")]
	[FieldOffset(Offset = "0xA4")]
	private bool _stickToTarget;

	[Token(Token = "0x4001A59")]
	[FieldOffset(Offset = "0xA8")]
	private PowerUp _currentAssassinatePowerUp;

	[Token(Token = "0x4001A5A")]
	[FieldOffset(Offset = "0xB0")]
	private List<Transform> _assassinateList;

	[Token(Token = "0x4001A5B")]
	[FieldOffset(Offset = "0xB8")]
	private AssassinateState _assassinateState;

	[Token(Token = "0x4001A5C")]
	[FieldOffset(Offset = "0xBC")]
	private float _assassinateTimer;

	[Token(Token = "0x4001A5D")]
	[FieldOffset(Offset = "0xC0")]
	private List<Trackable> _cunningTackers;

	[Token(Token = "0x4001A5E")]
	[FieldOffset(Offset = "0xC8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5B744C", Offset = "0x5B744C")]
	private GameObject _003CCunningTrackerPrefab_003Ek__BackingField;

	[Token(Token = "0x170004B2")]
	public int MaxTaggingNumber
	{
		[Token(Token = "0x6001E33")]
		[Address(RVA = "0xABB21C", Offset = "0xABB21C", VA = "0xABB21C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x618CB8", Offset = "0x618CB8")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6001E34")]
		[Address(RVA = "0xABB224", Offset = "0xABB224", VA = "0xABB224")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x618CC8", Offset = "0x618CC8")]
		private set
		{
		}
	}

	[Token(Token = "0x170004B3")]
	public GameObject CunningTrackerPrefab
	{
		[Token(Token = "0x6001E35")]
		[Address(RVA = "0xABB22C", Offset = "0xABB22C", VA = "0xABB22C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x618CD8", Offset = "0x618CD8")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001E36")]
		[Address(RVA = "0xABB234", Offset = "0xABB234", VA = "0xABB234")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x618CE8", Offset = "0x618CE8")]
		set
		{
		}
	}

	[Token(Token = "0x170004B4")]
	public Transform LastFocusTarget
	{
		[Token(Token = "0x6001E37")]
		[Address(RVA = "0xABB23C", Offset = "0xABB23C", VA = "0xABB23C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170004B5")]
	public int TagsCount
	{
		[Token(Token = "0x6001E38")]
		[Address(RVA = "0xABB244", Offset = "0xABB244", VA = "0xABB244")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x14000078")]
	public static event EventHandler<TrackableLookedAt> OnTrackableLookedAt
	{
		[Token(Token = "0x6001E39")]
		[Address(RVA = "0xABB290", Offset = "0xABB290", VA = "0xABB290")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x618CF8", Offset = "0x618CF8")]
		add
		{
		}
		[Token(Token = "0x6001E3A")]
		[Address(RVA = "0xABB34C", Offset = "0xABB34C", VA = "0xABB34C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x618D08", Offset = "0x618D08")]
		remove
		{
		}
	}

	[Token(Token = "0x14000079")]
	public static event EventHandler OnTagged
	{
		[Token(Token = "0x6001E3B")]
		[Address(RVA = "0xABB408", Offset = "0xABB408", VA = "0xABB408")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x618D18", Offset = "0x618D18")]
		add
		{
		}
		[Token(Token = "0x6001E3C")]
		[Address(RVA = "0xABB4C8", Offset = "0xABB4C8", VA = "0xABB4C8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x618D28", Offset = "0x618D28")]
		remove
		{
		}
	}

	[Token(Token = "0x1400007A")]
	public static event EventHandler OnUntagged
	{
		[Token(Token = "0x6001E3D")]
		[Address(RVA = "0xABB588", Offset = "0xABB588", VA = "0xABB588")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x618D38", Offset = "0x618D38")]
		add
		{
		}
		[Token(Token = "0x6001E3E")]
		[Address(RVA = "0xABB648", Offset = "0xABB648", VA = "0xABB648")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x618D48", Offset = "0x618D48")]
		remove
		{
		}
	}

	[Token(Token = "0x1400007B")]
	public static event EventHandler OnTagFocus
	{
		[Token(Token = "0x6001E3F")]
		[Address(RVA = "0xABB708", Offset = "0xABB708", VA = "0xABB708")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x618D58", Offset = "0x618D58")]
		add
		{
		}
		[Token(Token = "0x6001E40")]
		[Address(RVA = "0xABB7C8", Offset = "0xABB7C8", VA = "0xABB7C8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x618D68", Offset = "0x618D68")]
		remove
		{
		}
	}

	[Token(Token = "0x6001E41")]
	[Address(RVA = "0xABB888", Offset = "0xABB888", VA = "0xABB888", Slot = "9")]
	protected override void Start()
	{
	}

	[Token(Token = "0x6001E42")]
	[Address(RVA = "0xABBCE8", Offset = "0xABBCE8", VA = "0xABBCE8", Slot = "14")]
	public override void Execute()
	{
	}

	[Token(Token = "0x6001E43")]
	[Address(RVA = "0xABC080", Offset = "0xABC080", VA = "0xABC080")]
	private bool IsTargetAlive(Transform targetTransform)
	{
		return default(bool);
	}

	[Token(Token = "0x6001E44")]
	[Address(RVA = "0xABC170", Offset = "0xABC170", VA = "0xABC170")]
	private void AssassinateFocus()
	{
	}

	[Token(Token = "0x6001E45")]
	[Address(RVA = "0xABC470", Offset = "0xABC470", VA = "0xABC470")]
	private void AssassinateShoot()
	{
	}

	[Token(Token = "0x6001E46")]
	[Address(RVA = "0xABC91C", Offset = "0xABC91C", VA = "0xABC91C")]
	private void AssassinateWait()
	{
	}

	[Token(Token = "0x6001E47")]
	[Address(RVA = "0xABBEA4", Offset = "0xABBEA4", VA = "0xABBEA4")]
	private void UpdateAssassination()
	{
	}

	[Token(Token = "0x6001E48")]
	[Address(RVA = "0xABCA38", Offset = "0xABCA38", VA = "0xABCA38")]
	public void AssassinateAllTags(PowerUp caller)
	{
	}

	[Token(Token = "0x6001E49")]
	[Address(RVA = "0xABCC70", Offset = "0xABCC70", VA = "0xABCC70")]
	public void AssassinateList(List<Transform> assassinateList)
	{
	}

	[Token(Token = "0x6001E4A")]
	[Address(RVA = "0xABC368", Offset = "0xABC368", VA = "0xABC368")]
	public void FocusOnTarget(Transform focusTransform)
	{
	}

	[Token(Token = "0x6001E4B")]
	[Address(RVA = "0xABCDC4", Offset = "0xABCDC4", VA = "0xABCDC4")]
	private void OnVariableChangedEvent(object sender, DataModel.VariableChangedEventArgs args)
	{
	}

	[Token(Token = "0x6001E4C")]
	[Address(RVA = "0xABD040", Offset = "0xABD040", VA = "0xABD040", Slot = "10")]
	protected override void OnDestroy()
	{
	}

	[Token(Token = "0x6001E4D")]
	[Address(RVA = "0xABD4A4", Offset = "0xABD4A4", VA = "0xABD4A4")]
	private void OnPlayerAim(object sender, PlayerRootFSM.Sniping.AimInfo e)
	{
	}

	[Token(Token = "0x6001E4E")]
	[Address(RVA = "0xABD8D4", Offset = "0xABD8D4", VA = "0xABD8D4")]
	private void ResetLastLockingOnTarget()
	{
	}

	[Token(Token = "0x6001E4F")]
	[Address(RVA = "0xABDA30", Offset = "0xABDA30", VA = "0xABDA30")]
	public void TagObject(Trackable trackable)
	{
	}

	[Token(Token = "0x6001E50")]
	[Address(RVA = "0xABD974", Offset = "0xABD974", VA = "0xABD974")]
	public void TrackObject(Trackable trackable)
	{
	}

	[Token(Token = "0x6001E51")]
	[Address(RVA = "0xABDCBC", Offset = "0xABDCBC", VA = "0xABDCBC")]
	public void UnTrackObject(Trackable trackable)
	{
	}

	[Token(Token = "0x6001E52")]
	[Address(RVA = "0xABDD7C", Offset = "0xABDD7C", VA = "0xABDD7C")]
	public void OnTrackableDestroyed(Trackable trackable)
	{
	}

	[Token(Token = "0x6001E53")]
	[Address(RVA = "0xABD2D0", Offset = "0xABD2D0", VA = "0xABD2D0")]
	public void ClearTrackingList()
	{
	}

	[Token(Token = "0x6001E54")]
	[Address(RVA = "0xABDF74", Offset = "0xABDF74", VA = "0xABDF74")]
	private void OnTrackableAdded(Trackable trackable)
	{
	}

	[Token(Token = "0x6001E55")]
	[Address(RVA = "0xABBC3C", Offset = "0xABBC3C", VA = "0xABBC3C")]
	public void HandleAddTrackable(Trackable trackable, bool force = false)
	{
	}

	[Token(Token = "0x6001E56")]
	[Address(RVA = "0xABCC7C", Offset = "0xABCC7C", VA = "0xABCC7C")]
	private void StartFocusToTarget()
	{
	}

	[Token(Token = "0x6001E57")]
	[Address(RVA = "0xABC7E4", Offset = "0xABC7E4", VA = "0xABC7E4")]
	private void AimAtTarget(Transform targetTransform, float weight)
	{
	}

	[Token(Token = "0x6001E58")]
	[Address(RVA = "0xABBD0C", Offset = "0xABBD0C", VA = "0xABBD0C")]
	private void UpdateFocusToTarget()
	{
	}

	[Token(Token = "0x6001E59")]
	[Address(RVA = "0xABCFA0", Offset = "0xABCFA0", VA = "0xABCFA0")]
	public void ClearMoveToFocus()
	{
	}

	[Token(Token = "0x6001E5A")]
	[Address(RVA = "0xABDF7C", Offset = "0xABDF7C", VA = "0xABDF7C")]
	public bool IsTagged(Transform t)
	{
		return default(bool);
	}

	[Token(Token = "0x6001E5B")]
	[Address(RVA = "0xABE068", Offset = "0xABE068", VA = "0xABE068")]
	public Trackable PlaceCunningTracker()
	{
		return null;
	}

	[Token(Token = "0x6001E5C")]
	[Address(RVA = "0xABE240", Offset = "0xABE240", VA = "0xABE240")]
	public void ClearCunningTrackers()
	{
	}

	[Token(Token = "0x6001E5D")]
	[Address(RVA = "0xABE3FC", Offset = "0xABE3FC", VA = "0xABE3FC")]
	public PlayerTrackingSystem()
	{
	}
}
