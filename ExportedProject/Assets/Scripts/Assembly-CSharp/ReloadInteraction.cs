using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using Technology;
using UnityEngine;

[Token(Token = "0x200030C")]
public class ReloadInteraction : GameMonoBehaviour
{
	[Token(Token = "0x200030D")]
	public enum AxisEnum
	{
		[Token(Token = "0x40010FC")]
		X = 0,
		[Token(Token = "0x40010FD")]
		Y = 1,
		[Token(Token = "0x40010FE")]
		Z = 2
	}

	[Token(Token = "0x200030E")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x593354", Offset = "0x593354")]
	private sealed class _003CInit_003Ed__47 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40010FF")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4001100")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4001101")]
		[FieldOffset(Offset = "0x20")]
		public ReloadInteraction _003C_003E4__this;

		[Token(Token = "0x170002C0")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60012C4")]
			[Address(RVA = "0x8B2D5C", Offset = "0x8B2D5C", VA = "0x8B2D5C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170002C1")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60012C6")]
			[Address(RVA = "0x8B2DA4", Offset = "0x8B2DA4", VA = "0x8B2DA4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60012C1")]
		[Address(RVA = "0x8B2C54", Offset = "0x8B2C54", VA = "0x8B2C54")]
		[DebuggerHidden]
		public _003CInit_003Ed__47(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60012C2")]
		[Address(RVA = "0x8B2C80", Offset = "0x8B2C80", VA = "0x8B2C80", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60012C3")]
		[Address(RVA = "0x8B2C84", Offset = "0x8B2C84", VA = "0x8B2C84", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60012C5")]
		[Address(RVA = "0x8B2D64", Offset = "0x8B2D64", VA = "0x8B2D64", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x200030F")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x593364", Offset = "0x593364")]
	private sealed class _003CExecute_003Ed__50 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4001102")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4001103")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4001104")]
		[FieldOffset(Offset = "0x20")]
		public ReloadInteraction _003C_003E4__this;

		[Token(Token = "0x4001105")]
		[FieldOffset(Offset = "0x28")]
		private float _003CcompleteDist_003E5__2;

		[Token(Token = "0x4001106")]
		[FieldOffset(Offset = "0x2C")]
		private float _003Ctime_003E5__3;

		[Token(Token = "0x4001107")]
		[FieldOffset(Offset = "0x30")]
		private float _003Cpos_003E5__4;

		[Token(Token = "0x170002C2")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60012CA")]
			[Address(RVA = "0x8B2C04", Offset = "0x8B2C04", VA = "0x8B2C04", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170002C3")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60012CC")]
			[Address(RVA = "0x8B2C4C", Offset = "0x8B2C4C", VA = "0x8B2C4C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60012C7")]
		[Address(RVA = "0x8B27D8", Offset = "0x8B27D8", VA = "0x8B27D8")]
		[DebuggerHidden]
		public _003CExecute_003Ed__50(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60012C8")]
		[Address(RVA = "0x8B2804", Offset = "0x8B2804", VA = "0x8B2804", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60012C9")]
		[Address(RVA = "0x8B2808", Offset = "0x8B2808", VA = "0x8B2808", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60012CB")]
		[Address(RVA = "0x8B2C0C", Offset = "0x8B2C0C", VA = "0x8B2C0C", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x2000310")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x593374", Offset = "0x593374")]
	private sealed class _003CCompleteInteraction_003Ed__52 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4001108")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4001109")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400110A")]
		[FieldOffset(Offset = "0x20")]
		public ReloadInteraction _003C_003E4__this;

		[Token(Token = "0x400110B")]
		[FieldOffset(Offset = "0x28")]
		private float _003CcurrentTime_003E5__2;

		[Token(Token = "0x170002C4")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60012D0")]
			[Address(RVA = "0x8B2788", Offset = "0x8B2788", VA = "0x8B2788", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170002C5")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60012D2")]
			[Address(RVA = "0x8B27D0", Offset = "0x8B27D0", VA = "0x8B27D0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60012CD")]
		[Address(RVA = "0x8B2570", Offset = "0x8B2570", VA = "0x8B2570")]
		[DebuggerHidden]
		public _003CCompleteInteraction_003Ed__52(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60012CE")]
		[Address(RVA = "0x8B259C", Offset = "0x8B259C", VA = "0x8B259C", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60012CF")]
		[Address(RVA = "0x8B25A0", Offset = "0x8B25A0", VA = "0x8B25A0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60012D1")]
		[Address(RVA = "0x8B2790", Offset = "0x8B2790", VA = "0x8B2790", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x40010E9")]
	[FieldOffset(Offset = "0x48")]
	public AxisEnum MovementAxis;

	[Token(Token = "0x40010EA")]
	[FieldOffset(Offset = "0x4C")]
	public float PreTransitionTime;

	[Token(Token = "0x40010EB")]
	[FieldOffset(Offset = "0x50")]
	public UIDragObject DragObject;

	[Token(Token = "0x40010EC")]
	[FieldOffset(Offset = "0x58")]
	public Transform StartPosition;

	[Token(Token = "0x40010ED")]
	[FieldOffset(Offset = "0x60")]
	public Transform EndPosition;

	[Token(Token = "0x40010EE")]
	[FieldOffset(Offset = "0x68")]
	public string AttachmentBone;

	[Token(Token = "0x40010EF")]
	[FieldOffset(Offset = "0x70")]
	public Vector3 SniperPosition;

	[Token(Token = "0x40010F0")]
	[FieldOffset(Offset = "0x7C")]
	public Vector3 SniperAngle;

	[Token(Token = "0x40010F1")]
	[FieldOffset(Offset = "0x88")]
	public int ReloadStageCount;

	[Token(Token = "0x40010F2")]
	[FieldOffset(Offset = "0x8C")]
	private bool _isCompleting;

	[Token(Token = "0x40010F3")]
	[FieldOffset(Offset = "0x90")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5B4000", Offset = "0x5B4000")]
	private ReloadSequence _003CReloadSequence_003Ek__BackingField;

	[Token(Token = "0x40010F4")]
	[FieldOffset(Offset = "0x98")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5B4010", Offset = "0x5B4010")]
	private float _003CCompletion_003Ek__BackingField;

	[Token(Token = "0x40010F5")]
	[FieldOffset(Offset = "0xA0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5B4020", Offset = "0x5B4020")]
	private GameObject _003CDragGameObject_003Ek__BackingField;

	[Token(Token = "0x40010F6")]
	[FieldOffset(Offset = "0xA8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5B4030", Offset = "0x5B4030")]
	private Transform _003CDragObjectTransform_003Ek__BackingField;

	[Token(Token = "0x40010F7")]
	[FieldOffset(Offset = "0xB0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5B4040", Offset = "0x5B4040")]
	private Vector3 _003C_initialPosition_003Ek__BackingField;

	[Token(Token = "0x40010F8")]
	[FieldOffset(Offset = "0xBC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5B4050", Offset = "0x5B4050")]
	private Quaternion _003C_initialRotation_003Ek__BackingField;

	[Token(Token = "0x40010F9")]
	[FieldOffset(Offset = "0xCC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5B4060", Offset = "0x5B4060")]
	private Vector3 _003C_endPosition_003Ek__BackingField;

	[Token(Token = "0x40010FA")]
	[FieldOffset(Offset = "0xD8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5B4070", Offset = "0x5B4070")]
	private bool _003CIsDragObjectPressed_003Ek__BackingField;

	[Token(Token = "0x170002B7")]
	public Quaternion SniperRotation
	{
		[Token(Token = "0x60012A4")]
		[Address(RVA = "0x963118", Offset = "0x963118", VA = "0x963118")]
		get
		{
			return default(Quaternion);
		}
	}

	[Token(Token = "0x170002B8")]
	public ReloadSequence ReloadSequence
	{
		[Token(Token = "0x60012A5")]
		[Address(RVA = "0x963128", Offset = "0x963128", VA = "0x963128")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x616574", Offset = "0x616574")]
		get
		{
			return null;
		}
		[Token(Token = "0x60012A6")]
		[Address(RVA = "0x963130", Offset = "0x963130", VA = "0x963130")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x616584", Offset = "0x616584")]
		set
		{
		}
	}

	[Token(Token = "0x170002B9")]
	public float Completion
	{
		[Token(Token = "0x60012A7")]
		[Address(RVA = "0x963138", Offset = "0x963138", VA = "0x963138")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x616594", Offset = "0x616594")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x60012A8")]
		[Address(RVA = "0x963140", Offset = "0x963140", VA = "0x963140")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6165A4", Offset = "0x6165A4")]
		protected set
		{
		}
	}

	[Token(Token = "0x170002BA")]
	protected GameObject DragGameObject
	{
		[Token(Token = "0x60012A9")]
		[Address(RVA = "0x963148", Offset = "0x963148", VA = "0x963148")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6165B4", Offset = "0x6165B4")]
		get
		{
			return null;
		}
		[Token(Token = "0x60012AA")]
		[Address(RVA = "0x963150", Offset = "0x963150", VA = "0x963150")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6165C4", Offset = "0x6165C4")]
		set
		{
		}
	}

	[Token(Token = "0x170002BB")]
	protected Transform DragObjectTransform
	{
		[Token(Token = "0x60012AB")]
		[Address(RVA = "0x963158", Offset = "0x963158", VA = "0x963158")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6165D4", Offset = "0x6165D4")]
		get
		{
			return null;
		}
		[Token(Token = "0x60012AC")]
		[Address(RVA = "0x963160", Offset = "0x963160", VA = "0x963160")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6165E4", Offset = "0x6165E4")]
		set
		{
		}
	}

	[Token(Token = "0x170002BC")]
	protected Vector3 _initialPosition
	{
		[Token(Token = "0x60012AD")]
		[Address(RVA = "0x963168", Offset = "0x963168", VA = "0x963168")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6165F4", Offset = "0x6165F4")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x60012AE")]
		[Address(RVA = "0x963174", Offset = "0x963174", VA = "0x963174")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x616604", Offset = "0x616604")]
		private set
		{
		}
	}

	[Token(Token = "0x170002BD")]
	protected Quaternion _initialRotation
	{
		[Token(Token = "0x60012AF")]
		[Address(RVA = "0x963180", Offset = "0x963180", VA = "0x963180")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x616614", Offset = "0x616614")]
		get
		{
			return default(Quaternion);
		}
		[Token(Token = "0x60012B0")]
		[Address(RVA = "0x96318C", Offset = "0x96318C", VA = "0x96318C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x616624", Offset = "0x616624")]
		private set
		{
		}
	}

	[Token(Token = "0x170002BE")]
	protected Vector3 _endPosition
	{
		[Token(Token = "0x60012B1")]
		[Address(RVA = "0x963198", Offset = "0x963198", VA = "0x963198")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x616634", Offset = "0x616634")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x60012B2")]
		[Address(RVA = "0x9631A4", Offset = "0x9631A4", VA = "0x9631A4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x616644", Offset = "0x616644")]
		private set
		{
		}
	}

	[Token(Token = "0x170002BF")]
	public bool IsDragObjectPressed
	{
		[Token(Token = "0x60012B3")]
		[Address(RVA = "0x9631B0", Offset = "0x9631B0", VA = "0x9631B0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x616654", Offset = "0x616654")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60012B4")]
		[Address(RVA = "0x9631B8", Offset = "0x9631B8", VA = "0x9631B8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x616664", Offset = "0x616664")]
		private set
		{
		}
	}

	[Token(Token = "0x60012B5")]
	[Address(RVA = "0x9631C4", Offset = "0x9631C4", VA = "0x9631C4", Slot = "7")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x60012B6")]
	[Address(RVA = "0x963390", Offset = "0x963390", VA = "0x963390")]
	protected void BaseInit()
	{
	}

	[Token(Token = "0x60012B7")]
	[Address(RVA = "0x963624", Offset = "0x963624", VA = "0x963624", Slot = "14")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x616674", Offset = "0x616674")]
	protected virtual IEnumerator Init()
	{
		return null;
	}

	[Token(Token = "0x60012B8")]
	[Address(RVA = "0x963690", Offset = "0x963690", VA = "0x963690")]
	protected Vector3 ClampMovement(Vector3 current, int index, Vector3 min, Vector3 max)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60012B9")]
	[Address(RVA = "0x96391C", Offset = "0x96391C", VA = "0x96391C", Slot = "15")]
	public virtual void Reset()
	{
	}

	[Token(Token = "0x60012BA")]
	[Address(RVA = "0x96392C", Offset = "0x96392C", VA = "0x96392C", Slot = "16")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x6166D4", Offset = "0x6166D4")]
	public virtual IEnumerator Execute()
	{
		return null;
	}

	[Token(Token = "0x60012BB")]
	[Address(RVA = "0x963998", Offset = "0x963998", VA = "0x963998", Slot = "17")]
	public virtual void AutoComplete()
	{
	}

	[Token(Token = "0x60012BC")]
	[Address(RVA = "0x9639EC", Offset = "0x9639EC", VA = "0x9639EC")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x616734", Offset = "0x616734")]
	private IEnumerator CompleteInteraction()
	{
		return null;
	}

	[Token(Token = "0x60012BD")]
	[Address(RVA = "0x963A58", Offset = "0x963A58", VA = "0x963A58", Slot = "18")]
	protected virtual void OnDragObjectPressed(bool isPressed)
	{
	}

	[Token(Token = "0x60012BE")]
	[Address(RVA = "0x963A64", Offset = "0x963A64", VA = "0x963A64", Slot = "19")]
	public virtual void OnGestureDrag(FingerInput.FingerID finger, Vector2 drag)
	{
	}

	[Token(Token = "0x60012BF")]
	[Address(RVA = "0x963A68", Offset = "0x963A68", VA = "0x963A68")]
	public ReloadInteraction()
	{
	}

	[Token(Token = "0x60012C0")]
	[Address(RVA = "0x963A80", Offset = "0x963A80", VA = "0x963A80")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x616794", Offset = "0x616794")]
	private void _003CAwake_003Eb__45_0(object src, DragObjectHandler.DragObjectEventArgs e)
	{
	}
}
