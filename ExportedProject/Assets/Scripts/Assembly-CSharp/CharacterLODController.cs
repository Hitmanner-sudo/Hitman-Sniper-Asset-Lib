using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000198")]
public class CharacterLODController : MonoBehaviour
{
	[Token(Token = "0x2000199")]
	private struct TriggerColliderPair
	{
		[Token(Token = "0x40008AE")]
		[FieldOffset(Offset = "0x0")]
		public NPCColliderTrigger Trigger;

		[Token(Token = "0x40008AF")]
		[FieldOffset(Offset = "0x8")]
		public Collider ColliderInside;
	}

	[Token(Token = "0x200019A")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x592880", Offset = "0x592880")]
	private sealed class _003CDelayedSwitch_003Ed__55 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40008B0")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40008B1")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40008B2")]
		[FieldOffset(Offset = "0x20")]
		public CharacterLODController _003C_003E4__this;

		[Token(Token = "0x40008B3")]
		[FieldOffset(Offset = "0x28")]
		private List<CharacterLODController> _003ClodControllers_003E5__2;

		[Token(Token = "0x40008B4")]
		[FieldOffset(Offset = "0x30")]
		private int _003Ccount_003E5__3;

		[Token(Token = "0x40008B5")]
		[FieldOffset(Offset = "0x34")]
		private int _003Ci_003E5__4;

		[Token(Token = "0x170001BD")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6000AEB")]
			[Address(RVA = "0x862064", Offset = "0x862064", VA = "0x862064", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001BE")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6000AED")]
			[Address(RVA = "0x8620AC", Offset = "0x8620AC", VA = "0x8620AC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000AE8")]
		[Address(RVA = "0x861D00", Offset = "0x861D00", VA = "0x861D00")]
		[DebuggerHidden]
		public _003CDelayedSwitch_003Ed__55(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6000AE9")]
		[Address(RVA = "0x861D2C", Offset = "0x861D2C", VA = "0x861D2C", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6000AEA")]
		[Address(RVA = "0x861D30", Offset = "0x861D30", VA = "0x861D30", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000AEC")]
		[Address(RVA = "0x86206C", Offset = "0x86206C", VA = "0x86206C", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x200019B")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x592890", Offset = "0x592890")]
	private sealed class _003C_003Ec__DisplayClass58_0
	{
		[Token(Token = "0x40008B6")]
		[FieldOffset(Offset = "0x10")]
		public NPCColliderTrigger trigger;

		[Token(Token = "0x6000AEE")]
		[Address(RVA = "0x861C80", Offset = "0x861C80", VA = "0x861C80")]
		public _003C_003Ec__DisplayClass58_0()
		{
		}

		[Token(Token = "0x6000AEF")]
		[Address(RVA = "0x861C88", Offset = "0x861C88", VA = "0x861C88")]
		internal bool _003CExitedTrigger_003Eb__0(TriggerColliderPair pair)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x400089B")]
	private const string HIGH_LOD_NAME = "Character";

	[Token(Token = "0x400089C")]
	private const string LOW_LOD_NAME = "CharacterLow";

	[Token(Token = "0x400089D")]
	private const string RAGDOLL_GAMEOBJECT_NAME = "Ragdoll Collision";

	[Token(Token = "0x400089E")]
	[FieldOffset(Offset = "0x0")]
	private static LODGroup _activeLOD;

	[Token(Token = "0x400089F")]
	[FieldOffset(Offset = "0x18")]
	private readonly Dictionary<Animator, bool> _moveAnticipationCache;

	[Token(Token = "0x40008A0")]
	[FieldOffset(Offset = "0x20")]
	private SkinnedMeshRenderer _highLODSkin;

	[Token(Token = "0x40008A1")]
	[FieldOffset(Offset = "0x28")]
	private SkinnedMeshRenderer _activeLODSkin;

	[Token(Token = "0x40008A2")]
	[FieldOffset(Offset = "0x30")]
	private Bounds _highExtendBound;

	[Token(Token = "0x40008A3")]
	[FieldOffset(Offset = "0x48")]
	public Action<Animator, LODGroup> SwitchLOD;

	[Token(Token = "0x40008A4")]
	[FieldOffset(Offset = "0x50")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5B1FEC", Offset = "0x5B1FEC")]
	private Animator _003CHighLODAnimator_003Ek__BackingField;

	[Token(Token = "0x40008A5")]
	[FieldOffset(Offset = "0x58")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5B1FFC", Offset = "0x5B1FFC")]
	private GameObject _003CHighLODCharacter_003Ek__BackingField;

	[Token(Token = "0x40008A6")]
	[FieldOffset(Offset = "0x60")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5B200C", Offset = "0x5B200C")]
	private Collider _003CHighLODCharacterCapsule_003Ek__BackingField;

	[Token(Token = "0x40008A7")]
	[FieldOffset(Offset = "0x68")]
	private readonly List<TriggerColliderPair> _triggersInside;

	[Token(Token = "0x40008A8")]
	[FieldOffset(Offset = "0x70")]
	private SkinnedMeshRenderer _lowLODSkin;

	[Token(Token = "0x40008A9")]
	[FieldOffset(Offset = "0x78")]
	private Bounds _lowExtendBound;

	[Token(Token = "0x40008AA")]
	[FieldOffset(Offset = "0x90")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5B201C", Offset = "0x5B201C")]
	private Animator _003CLowLODAnimator_003Ek__BackingField;

	[Token(Token = "0x40008AB")]
	[FieldOffset(Offset = "0x98")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5B202C", Offset = "0x5B202C")]
	private GameObject _003CLowLODCharacter_003Ek__BackingField;

	[Token(Token = "0x40008AC")]
	[FieldOffset(Offset = "0xA0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5B203C", Offset = "0x5B203C")]
	private Collider _003CLowLODCharacterCapsule_003Ek__BackingField;

	[Token(Token = "0x40008AD")]
	[FieldOffset(Offset = "0xA8")]
	private int m_numLODsToProcessPerTick;

	[Token(Token = "0x170001B3")]
	public static LODGroup ActiveLOD
	{
		[Token(Token = "0x6000AC7")]
		[Address(RVA = "0xAFC4E4", Offset = "0xAFC4E4", VA = "0xAFC4E4")]
		get
		{
			return default(LODGroup);
		}
		[Token(Token = "0x6000AC8")]
		[Address(RVA = "0xAFC548", Offset = "0xAFC548", VA = "0xAFC548")]
		set
		{
		}
	}

	[Token(Token = "0x170001B4")]
	protected Animator HighLODAnimator
	{
		[Token(Token = "0x6000AC9")]
		[Address(RVA = "0xAFC5B0", Offset = "0xAFC5B0", VA = "0xAFC5B0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x613C54", Offset = "0x613C54")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000ACA")]
		[Address(RVA = "0xAFC5B8", Offset = "0xAFC5B8", VA = "0xAFC5B8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x613C64", Offset = "0x613C64")]
		private set
		{
		}
	}

	[Token(Token = "0x170001B5")]
	public GameObject HighLODCharacter
	{
		[Token(Token = "0x6000ACB")]
		[Address(RVA = "0xAFC5C0", Offset = "0xAFC5C0", VA = "0xAFC5C0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x613C74", Offset = "0x613C74")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000ACC")]
		[Address(RVA = "0xAFC5C8", Offset = "0xAFC5C8", VA = "0xAFC5C8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x613C84", Offset = "0x613C84")]
		private set
		{
		}
	}

	[Token(Token = "0x170001B6")]
	public Collider HighLODCharacterCapsule
	{
		[Token(Token = "0x6000ACD")]
		[Address(RVA = "0xAFC5D0", Offset = "0xAFC5D0", VA = "0xAFC5D0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x613C94", Offset = "0x613C94")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000ACE")]
		[Address(RVA = "0xAFC5D8", Offset = "0xAFC5D8", VA = "0xAFC5D8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x613CA4", Offset = "0x613CA4")]
		private set
		{
		}
	}

	[Token(Token = "0x170001B7")]
	protected Animator LowLODAnimator
	{
		[Token(Token = "0x6000ACF")]
		[Address(RVA = "0xAFC5E0", Offset = "0xAFC5E0", VA = "0xAFC5E0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x613CB4", Offset = "0x613CB4")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000AD0")]
		[Address(RVA = "0xAFC5E8", Offset = "0xAFC5E8", VA = "0xAFC5E8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x613CC4", Offset = "0x613CC4")]
		private set
		{
		}
	}

	[Token(Token = "0x170001B8")]
	public GameObject LowLODCharacter
	{
		[Token(Token = "0x6000AD1")]
		[Address(RVA = "0xAFC5F0", Offset = "0xAFC5F0", VA = "0xAFC5F0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x613CD4", Offset = "0x613CD4")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000AD2")]
		[Address(RVA = "0xAFC5F8", Offset = "0xAFC5F8", VA = "0xAFC5F8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x613CE4", Offset = "0x613CE4")]
		private set
		{
		}
	}

	[Token(Token = "0x170001B9")]
	public Collider LowLODCharacterCapsule
	{
		[Token(Token = "0x6000AD3")]
		[Address(RVA = "0xAFC600", Offset = "0xAFC600", VA = "0xAFC600")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x613CF4", Offset = "0x613CF4")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000AD4")]
		[Address(RVA = "0xAFC608", Offset = "0xAFC608", VA = "0xAFC608")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x613D04", Offset = "0x613D04")]
		private set
		{
		}
	}

	[Token(Token = "0x170001BA")]
	public SkinnedMeshRenderer ActiveLODSkin
	{
		[Token(Token = "0x6000AD5")]
		[Address(RVA = "0xAFC610", Offset = "0xAFC610", VA = "0xAFC610")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170001BB")]
	public Bounds OriginalExtendBound
	{
		[Token(Token = "0x6000AD6")]
		[Address(RVA = "0xAFC618", Offset = "0xAFC618", VA = "0xAFC618")]
		get
		{
			return default(Bounds);
		}
	}

	[Token(Token = "0x170001BC")]
	private Animator ActiveAnimator
	{
		[Token(Token = "0x6000AD7")]
		[Address(RVA = "0xAFC6B4", Offset = "0xAFC6B4", VA = "0xAFC6B4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000AD8")]
	[Address(RVA = "0xAFC740", Offset = "0xAFC740", VA = "0xAFC740")]
	public bool IsMoveAnticipationEnabled()
	{
		return default(bool);
	}

	[Token(Token = "0x6000AD9")]
	[Address(RVA = "0xAFC87C", Offset = "0xAFC87C", VA = "0xAFC87C")]
	public void Awake()
	{
	}

	[Token(Token = "0x6000ADA")]
	[Address(RVA = "0xAFCBD8", Offset = "0xAFCBD8", VA = "0xAFCBD8")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000ADB")]
	[Address(RVA = "0xAFCC70", Offset = "0xAFCC70", VA = "0xAFCC70")]
	public void OnEnable()
	{
	}

	[Token(Token = "0x6000ADC")]
	[Address(RVA = "0xAFCCE8", Offset = "0xAFCCE8", VA = "0xAFCCE8")]
	public void OnDisable()
	{
	}

	[Token(Token = "0x6000ADD")]
	[Address(RVA = "0xAFCDA8", Offset = "0xAFCDA8", VA = "0xAFCDA8")]
	public void SetLOD(LODGroup lodGroup, int frameID)
	{
	}

	[Token(Token = "0x6000ADE")]
	[Address(RVA = "0xAFD038", Offset = "0xAFD038", VA = "0xAFD038")]
	private void SetBounds(SkinnedMeshRenderer lodSkin, Bounds bound)
	{
	}

	[Token(Token = "0x6000ADF")]
	[Address(RVA = "0xAFD1A4", Offset = "0xAFD1A4", VA = "0xAFD1A4")]
	public static void SetInScopeForAllObjects(bool inScope)
	{
	}

	[Token(Token = "0x6000AE0")]
	[Address(RVA = "0xAFD308", Offset = "0xAFD308", VA = "0xAFD308")]
	private void SwitchAllLODs()
	{
	}

	[Token(Token = "0x6000AE1")]
	[Address(RVA = "0xAFD368", Offset = "0xAFD368", VA = "0xAFD368")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x613D14", Offset = "0x613D14")]
	private IEnumerator DelayedSwitch()
	{
		return null;
	}

	[Token(Token = "0x6000AE2")]
	[Address(RVA = "0xAFCB58", Offset = "0xAFCB58", VA = "0xAFCB58")]
	private Collider GetRagdollCollider(GameObject ancestor)
	{
		return null;
	}

	[Token(Token = "0x6000AE3")]
	[Address(RVA = "0xAFD3D4", Offset = "0xAFD3D4", VA = "0xAFD3D4")]
	public void EnteredTrigger(NPCColliderTrigger trigger, Collider col)
	{
	}

	[Token(Token = "0x6000AE4")]
	[Address(RVA = "0xAFD440", Offset = "0xAFD440", VA = "0xAFD440")]
	public void ExitedTrigger(NPCColliderTrigger trigger)
	{
	}

	[Token(Token = "0x6000AE5")]
	[Address(RVA = "0xAFD088", Offset = "0xAFD088", VA = "0xAFD088")]
	private void UpdateTriggersInside(LODGroup newLodGroup)
	{
	}

	[Token(Token = "0x6000AE6")]
	[Address(RVA = "0xAFD530", Offset = "0xAFD530", VA = "0xAFD530")]
	public CharacterLODController()
	{
	}
}
