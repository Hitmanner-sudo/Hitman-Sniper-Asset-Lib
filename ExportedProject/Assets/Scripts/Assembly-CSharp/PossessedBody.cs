using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200034B")]
public class PossessedBody : MonoBehaviour
{
	[Token(Token = "0x200034C")]
	private class ValidTarget
	{
		[Token(Token = "0x400121C")]
		[FieldOffset(Offset = "0x10")]
		public ThirdPersonCharacter TargetThirdPersonCharacter;

		[Token(Token = "0x400121D")]
		[FieldOffset(Offset = "0x18")]
		public bool AimForTorso;

		[Token(Token = "0x400121E")]
		[FieldOffset(Offset = "0x19")]
		public bool AimForHead;

		[Token(Token = "0x60013F6")]
		[Address(RVA = "0x8B0588", Offset = "0x8B0588", VA = "0x8B0588")]
		public Vector3 GetAimingPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60013F7")]
		[Address(RVA = "0x8B1514", Offset = "0x8B1514", VA = "0x8B1514")]
		public ValidTarget()
		{
		}
	}

	[Token(Token = "0x200034D")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x593414", Offset = "0x593414")]
	private sealed class _003CLiftBody_003Ed__11 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400121F")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4001220")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4001221")]
		[FieldOffset(Offset = "0x20")]
		public PossessedBody _003C_003E4__this;

		[Token(Token = "0x4001222")]
		[FieldOffset(Offset = "0x28")]
		public Vector3 fromPosition;

		[Token(Token = "0x170002E5")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60013FB")]
			[Address(RVA = "0x8B0A70", Offset = "0x8B0A70", VA = "0x8B0A70", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170002E6")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60013FD")]
			[Address(RVA = "0x8B0AB8", Offset = "0x8B0AB8", VA = "0x8B0AB8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60013F8")]
		[Address(RVA = "0x8B086C", Offset = "0x8B086C", VA = "0x8B086C")]
		[DebuggerHidden]
		public _003CLiftBody_003Ed__11(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60013F9")]
		[Address(RVA = "0x8B0898", Offset = "0x8B0898", VA = "0x8B0898", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60013FA")]
		[Address(RVA = "0x8B089C", Offset = "0x8B089C", VA = "0x8B089C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60013FC")]
		[Address(RVA = "0x8B0A78", Offset = "0x8B0A78", VA = "0x8B0A78", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x200034E")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x593424", Offset = "0x593424")]
	private sealed class _003CDropBody_003Ed__12 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4001223")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4001224")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4001225")]
		[FieldOffset(Offset = "0x20")]
		public PossessedBody _003C_003E4__this;

		[Token(Token = "0x4001226")]
		[FieldOffset(Offset = "0x28")]
		public Vector3 fromPosition;

		[Token(Token = "0x170002E7")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6001401")]
			[Address(RVA = "0x8B081C", Offset = "0x8B081C", VA = "0x8B081C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170002E8")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6001403")]
			[Address(RVA = "0x8B0864", Offset = "0x8B0864", VA = "0x8B0864", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60013FE")]
		[Address(RVA = "0x8B06A8", Offset = "0x8B06A8", VA = "0x8B06A8")]
		[DebuggerHidden]
		public _003CDropBody_003Ed__12(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60013FF")]
		[Address(RVA = "0x8B06D4", Offset = "0x8B06D4", VA = "0x8B06D4", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6001400")]
		[Address(RVA = "0x8B06D8", Offset = "0x8B06D8", VA = "0x8B06D8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6001402")]
		[Address(RVA = "0x8B0824", Offset = "0x8B0824", VA = "0x8B0824", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x200034F")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x593434", Offset = "0x593434")]
	private sealed class _003CPlaySequence_003Ed__13 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4001227")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4001228")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4001229")]
		[FieldOffset(Offset = "0x20")]
		public GeneralConfig.PossessSequence possessSequence;

		[Token(Token = "0x400122A")]
		[FieldOffset(Offset = "0x28")]
		public PossessedBody _003C_003E4__this;

		[Token(Token = "0x400122B")]
		[FieldOffset(Offset = "0x30")]
		public Vector3 direction;

		[Token(Token = "0x400122C")]
		[FieldOffset(Offset = "0x3C")]
		public Vector3 fromPosition;

		[Token(Token = "0x170002E9")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6001407")]
			[Address(RVA = "0x8B0D74", Offset = "0x8B0D74", VA = "0x8B0D74", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170002EA")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6001409")]
			[Address(RVA = "0x8B0DBC", Offset = "0x8B0DBC", VA = "0x8B0DBC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6001404")]
		[Address(RVA = "0x8B0AC0", Offset = "0x8B0AC0", VA = "0x8B0AC0")]
		[DebuggerHidden]
		public _003CPlaySequence_003Ed__13(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6001405")]
		[Address(RVA = "0x8B0AEC", Offset = "0x8B0AEC", VA = "0x8B0AEC", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6001406")]
		[Address(RVA = "0x8B0AF0", Offset = "0x8B0AF0", VA = "0x8B0AF0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6001408")]
		[Address(RVA = "0x8B0D7C", Offset = "0x8B0D7C", VA = "0x8B0D7C", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x2000350")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x593444", Offset = "0x593444")]
	private sealed class _003CThrowBody_003Ed__14 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400122D")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400122E")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400122F")]
		[FieldOffset(Offset = "0x20")]
		public Vector3 targetPos;

		[Token(Token = "0x4001230")]
		[FieldOffset(Offset = "0x30")]
		public PossessedBody _003C_003E4__this;

		[Token(Token = "0x4001231")]
		[FieldOffset(Offset = "0x38")]
		public Vector3 fromPosition;

		[Token(Token = "0x170002EB")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600140D")]
			[Address(RVA = "0x8B14C4", Offset = "0x8B14C4", VA = "0x8B14C4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170002EC")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600140F")]
			[Address(RVA = "0x8B150C", Offset = "0x8B150C", VA = "0x8B150C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600140A")]
		[Address(RVA = "0x8B1300", Offset = "0x8B1300", VA = "0x8B1300")]
		[DebuggerHidden]
		public _003CThrowBody_003Ed__14(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600140B")]
		[Address(RVA = "0x8B132C", Offset = "0x8B132C", VA = "0x8B132C", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600140C")]
		[Address(RVA = "0x8B1330", Offset = "0x8B1330", VA = "0x8B1330", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600140E")]
		[Address(RVA = "0x8B14CC", Offset = "0x8B14CC", VA = "0x8B14CC", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x2000351")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x593454", Offset = "0x593454")]
	private sealed class _003CDeadBodyPossess_003Ed__15 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4001232")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4001233")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4001234")]
		[FieldOffset(Offset = "0x20")]
		public PossessedBody _003C_003E4__this;

		[Token(Token = "0x4001235")]
		[FieldOffset(Offset = "0x28")]
		private bool _003CthrowBody_003E5__2;

		[Token(Token = "0x4001236")]
		[FieldOffset(Offset = "0x2C")]
		private Vector3 _003Cposition_003E5__3;

		[Token(Token = "0x4001237")]
		[FieldOffset(Offset = "0x38")]
		private int _003Ci_003E5__4;

		[Token(Token = "0x170002ED")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6001413")]
			[Address(RVA = "0x8B0658", Offset = "0x8B0658", VA = "0x8B0658", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170002EE")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6001415")]
			[Address(RVA = "0x8B06A0", Offset = "0x8B06A0", VA = "0x8B06A0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6001410")]
		[Address(RVA = "0x8B0034", Offset = "0x8B0034", VA = "0x8B0034")]
		[DebuggerHidden]
		public _003CDeadBodyPossess_003Ed__15(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6001411")]
		[Address(RVA = "0x8B0060", Offset = "0x8B0060", VA = "0x8B0060", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6001412")]
		[Address(RVA = "0x8B0064", Offset = "0x8B0064", VA = "0x8B0064", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6001414")]
		[Address(RVA = "0x8B0660", Offset = "0x8B0660", VA = "0x8B0660", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2000352")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x593464", Offset = "0x593464")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x4001238")]
		[FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x4001239")]
		[FieldOffset(Offset = "0x8")]
		public static Comparison<RaycastHit> _003C_003E9__18_0;

		[Token(Token = "0x6001417")]
		[Address(RVA = "0x8AFCC8", Offset = "0x8AFCC8", VA = "0x8AFCC8")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x6001418")]
		[Address(RVA = "0x8AFCD0", Offset = "0x8AFCD0", VA = "0x8AFCD0")]
		internal int _003CRayCastHitBlocker_003Eb__18_0(RaycastHit a, RaycastHit b)
		{
			return default(int);
		}
	}

	[Token(Token = "0x2000353")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x593474", Offset = "0x593474")]
	private sealed class _003CShowWaitingApparition_003Ed__19 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400123A")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400123B")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400123C")]
		[FieldOffset(Offset = "0x20")]
		public PossessedBody _003C_003E4__this;

		[Token(Token = "0x400123D")]
		[FieldOffset(Offset = "0x28")]
		private GeneralConfig.PossessShotInfo _003CpossessShot_003E5__2;

		[Token(Token = "0x170002EF")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600141C")]
			[Address(RVA = "0x8B12B0", Offset = "0x8B12B0", VA = "0x8B12B0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170002F0")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600141E")]
			[Address(RVA = "0x8B12F8", Offset = "0x8B12F8", VA = "0x8B12F8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6001419")]
		[Address(RVA = "0x8B1064", Offset = "0x8B1064", VA = "0x8B1064")]
		[DebuggerHidden]
		public _003CShowWaitingApparition_003Ed__19(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600141A")]
		[Address(RVA = "0x8B1090", Offset = "0x8B1090", VA = "0x8B1090", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600141B")]
		[Address(RVA = "0x8B1094", Offset = "0x8B1094", VA = "0x8B1094", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600141D")]
		[Address(RVA = "0x8B12B8", Offset = "0x8B12B8", VA = "0x8B12B8", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x2000354")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x593484", Offset = "0x593484")]
	private sealed class _003CShowBillboard_003Ed__20 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400123E")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400123F")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4001240")]
		[FieldOffset(Offset = "0x20")]
		public PossessedBody _003C_003E4__this;

		[Token(Token = "0x4001241")]
		[FieldOffset(Offset = "0x28")]
		public Vector3 position;

		[Token(Token = "0x4001242")]
		[FieldOffset(Offset = "0x38")]
		public GeneralConfig.PossessSequence possessSequence;

		[Token(Token = "0x4001243")]
		[FieldOffset(Offset = "0x40")]
		private GeneralConfig.PossessShotInfo _003CpossessShot_003E5__2;

		[Token(Token = "0x170002F1")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6001422")]
			[Address(RVA = "0x8B1014", Offset = "0x8B1014", VA = "0x8B1014", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170002F2")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6001424")]
			[Address(RVA = "0x8B105C", Offset = "0x8B105C", VA = "0x8B105C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600141F")]
		[Address(RVA = "0x8B0DC4", Offset = "0x8B0DC4", VA = "0x8B0DC4")]
		[DebuggerHidden]
		public _003CShowBillboard_003Ed__20(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6001420")]
		[Address(RVA = "0x8B0DF0", Offset = "0x8B0DF0", VA = "0x8B0DF0", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6001421")]
		[Address(RVA = "0x8B0DF4", Offset = "0x8B0DF4", VA = "0x8B0DF4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6001423")]
		[Address(RVA = "0x8B101C", Offset = "0x8B101C", VA = "0x8B101C", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x2000355")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x593494", Offset = "0x593494")]
	private sealed class _003CChangeAlpha_003Ed__22 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4001244")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4001245")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4001246")]
		[FieldOffset(Offset = "0x20")]
		public Material material;

		[Token(Token = "0x4001247")]
		[FieldOffset(Offset = "0x28")]
		public float duration;

		[Token(Token = "0x4001248")]
		[FieldOffset(Offset = "0x2C")]
		public float startAlpha;

		[Token(Token = "0x4001249")]
		[FieldOffset(Offset = "0x30")]
		public float endAlpha;

		[Token(Token = "0x400124A")]
		[FieldOffset(Offset = "0x34")]
		private Color _003Ccolor_003E5__2;

		[Token(Token = "0x400124B")]
		[FieldOffset(Offset = "0x44")]
		private float _003CstartTime_003E5__3;

		[Token(Token = "0x400124C")]
		[FieldOffset(Offset = "0x48")]
		private float _003CendTime_003E5__4;

		[Token(Token = "0x170002F3")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6001428")]
			[Address(RVA = "0x8AFFE4", Offset = "0x8AFFE4", VA = "0x8AFFE4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170002F4")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600142A")]
			[Address(RVA = "0x8B002C", Offset = "0x8B002C", VA = "0x8B002C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6001425")]
		[Address(RVA = "0x8AFD40", Offset = "0x8AFD40", VA = "0x8AFD40")]
		[DebuggerHidden]
		public _003CChangeAlpha_003Ed__22(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6001426")]
		[Address(RVA = "0x8AFD6C", Offset = "0x8AFD6C", VA = "0x8AFD6C", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6001427")]
		[Address(RVA = "0x8AFD70", Offset = "0x8AFD70", VA = "0x8AFD70", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6001429")]
		[Address(RVA = "0x8AFFEC", Offset = "0x8AFFEC", VA = "0x8AFFEC", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x4001215")]
	[FieldOffset(Offset = "0x18")]
	private ThirdPersonCharacter _characterRef;

	[Token(Token = "0x4001216")]
	[FieldOffset(Offset = "0x20")]
	private Material _bbMaterial;

	[Token(Token = "0x4001217")]
	[FieldOffset(Offset = "0x28")]
	private GameObject _billboard;

	[Token(Token = "0x4001218")]
	[FieldOffset(Offset = "0x30")]
	private Coroutine _possessCoroutine;

	[Token(Token = "0x4001219")]
	[FieldOffset(Offset = "0x38")]
	private List<ThirdPersonCharacter> _triggedColliders;

	[Token(Token = "0x400121A")]
	[FieldOffset(Offset = "0x40")]
	private List<Rigidbody> _allRigidBodies;

	[Token(Token = "0x400121B")]
	[FieldOffset(Offset = "0x48")]
	private ValidTarget _validTarget;

	[Token(Token = "0x60013E4")]
	[Address(RVA = "0x93E114", Offset = "0x93E114", VA = "0x93E114")]
	internal void Start()
	{
	}

	[Token(Token = "0x60013E5")]
	[Address(RVA = "0x93E200", Offset = "0x93E200", VA = "0x93E200")]
	public void StartBodyPossess()
	{
	}

	[Token(Token = "0x60013E6")]
	[Address(RVA = "0x93E2D4", Offset = "0x93E2D4", VA = "0x93E2D4")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60013E7")]
	[Address(RVA = "0x93E364", Offset = "0x93E364", VA = "0x93E364")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x616C24", Offset = "0x616C24")]
	private IEnumerator LiftBody(Vector3 fromPosition)
	{
		return null;
	}

	[Token(Token = "0x60013E8")]
	[Address(RVA = "0x93E3F4", Offset = "0x93E3F4", VA = "0x93E3F4")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x616C84", Offset = "0x616C84")]
	private IEnumerator DropBody(Vector3 fromPosition)
	{
		return null;
	}

	[Token(Token = "0x60013E9")]
	[Address(RVA = "0x93E484", Offset = "0x93E484", VA = "0x93E484")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x616CE4", Offset = "0x616CE4")]
	private IEnumerator PlaySequence(Vector3 fromPosition, GeneralConfig.PossessSequence possessSequence, Vector3 direction)
	{
		return null;
	}

	[Token(Token = "0x60013EA")]
	[Address(RVA = "0x93E538", Offset = "0x93E538", VA = "0x93E538")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x616D44", Offset = "0x616D44")]
	private IEnumerator ThrowBody(Vector3 fromPosition, Vector3 targetPos)
	{
		return null;
	}

	[Token(Token = "0x60013EB")]
	[Address(RVA = "0x93E268", Offset = "0x93E268", VA = "0x93E268")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x616DA4", Offset = "0x616DA4")]
	private IEnumerator DeadBodyPossess()
	{
		return null;
	}

	[Token(Token = "0x60013EC")]
	[Address(RVA = "0x93E5E4", Offset = "0x93E5E4", VA = "0x93E5E4")]
	private ValidTarget HasOneValidCollider(List<ThirdPersonCharacter> thirdPersonCharacterColliders)
	{
		return null;
	}

	[Token(Token = "0x60013ED")]
	[Address(RVA = "0x93E688", Offset = "0x93E688", VA = "0x93E688")]
	private ValidTarget IsValidCollider(ThirdPersonCharacter thirdPersonCharacterCollider)
	{
		return null;
	}

	[Token(Token = "0x60013EE")]
	[Address(RVA = "0x93E9B8", Offset = "0x93E9B8", VA = "0x93E9B8")]
	private bool RayCastHitBlocker(Vector3 fromPosition, Vector3 toPosition)
	{
		return default(bool);
	}

	[Token(Token = "0x60013EF")]
	[Address(RVA = "0x93ED18", Offset = "0x93ED18", VA = "0x93ED18")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x616E04", Offset = "0x616E04")]
	private IEnumerator ShowWaitingApparition()
	{
		return null;
	}

	[Token(Token = "0x60013F0")]
	[Address(RVA = "0x93ED84", Offset = "0x93ED84", VA = "0x93ED84")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x616E64", Offset = "0x616E64")]
	private IEnumerator ShowBillboard(Vector3 position, GeneralConfig.PossessSequence possessSequence)
	{
		return null;
	}

	[Token(Token = "0x60013F1")]
	[Address(RVA = "0x93EE24", Offset = "0x93EE24", VA = "0x93EE24")]
	private void CreateApparition(Vector3 position, LazyMaterial lazyMaterial)
	{
	}

	[Token(Token = "0x60013F2")]
	[Address(RVA = "0x93F0CC", Offset = "0x93F0CC", VA = "0x93F0CC")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x616EC4", Offset = "0x616EC4")]
	private IEnumerator ChangeAlpha(Material material, float startAlpha, float endAlpha, float duration)
	{
		return null;
	}

	[Token(Token = "0x60013F3")]
	[Address(RVA = "0x93F15C", Offset = "0x93F15C", VA = "0x93F15C")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x60013F4")]
	[Address(RVA = "0x93F3B4", Offset = "0x93F3B4", VA = "0x93F3B4")]
	private void OnTriggerExit(Collider other)
	{
	}

	[Token(Token = "0x60013F5")]
	[Address(RVA = "0x93F4E4", Offset = "0x93F4E4", VA = "0x93F4E4")]
	public PossessedBody()
	{
	}
}
