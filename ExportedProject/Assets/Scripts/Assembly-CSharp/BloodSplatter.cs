using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using Technology;
using UnityEngine;

[Token(Token = "0x20007C8")]
public class BloodSplatter : GameMonoBehaviour
{
	[Serializable]
	[Token(Token = "0x20007C9")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x59628C", Offset = "0x59628C")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x4002BA3")]
		[FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x4002BA4")]
		[FieldOffset(Offset = "0x8")]
		public static Comparison<RaycastHit> _003C_003E9__7_0;

		[Token(Token = "0x6003333")]
		[Address(RVA = "0x926D18", Offset = "0x926D18", VA = "0x926D18")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x6003334")]
		[Address(RVA = "0x926D20", Offset = "0x926D20", VA = "0x926D20")]
		internal int _003CApplySplatters_003Eb__7_0(RaycastHit a, RaycastHit b)
		{
			return default(int);
		}
	}

	[Token(Token = "0x20007CA")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x59629C", Offset = "0x59629C")]
	private sealed class _003CApplySplatters_003Ed__7 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4002BA5")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4002BA6")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4002BA7")]
		[FieldOffset(Offset = "0x20")]
		public BloodSplatter _003C_003E4__this;

		[Token(Token = "0x17000695")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6003338")]
			[Address(RVA = "0x9274AC", Offset = "0x9274AC", VA = "0x9274AC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000696")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600333A")]
			[Address(RVA = "0x9274F4", Offset = "0x9274F4", VA = "0x9274F4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6003335")]
		[Address(RVA = "0x926D90", Offset = "0x926D90", VA = "0x926D90")]
		[DebuggerHidden]
		public _003CApplySplatters_003Ed__7(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6003336")]
		[Address(RVA = "0x926DBC", Offset = "0x926DBC", VA = "0x926DBC", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6003337")]
		[Address(RVA = "0x926DC0", Offset = "0x926DC0", VA = "0x926DC0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6003339")]
		[Address(RVA = "0x9274B4", Offset = "0x9274B4", VA = "0x9274B4", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x20007CB")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5962AC", Offset = "0x5962AC")]
	private sealed class _003CBloodFadeOut_003Ed__8 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4002BA8")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4002BA9")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4002BAA")]
		[FieldOffset(Offset = "0x20")]
		public GameObject splatter;

		[Token(Token = "0x4002BAB")]
		[FieldOffset(Offset = "0x28")]
		private float _003Cdelay_003E5__2;

		[Token(Token = "0x4002BAC")]
		[FieldOffset(Offset = "0x30")]
		private Material _003Cmat_003E5__3;

		[Token(Token = "0x4002BAD")]
		[FieldOffset(Offset = "0x38")]
		private Color _003Ccolor_003E5__4;

		[Token(Token = "0x17000697")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600333E")]
			[Address(RVA = "0x9278A0", Offset = "0x9278A0", VA = "0x9278A0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000698")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6003340")]
			[Address(RVA = "0x9278E8", Offset = "0x9278E8", VA = "0x9278E8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600333B")]
		[Address(RVA = "0x9274FC", Offset = "0x9274FC", VA = "0x9274FC")]
		[DebuggerHidden]
		public _003CBloodFadeOut_003Ed__8(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600333C")]
		[Address(RVA = "0x927528", Offset = "0x927528", VA = "0x927528", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600333D")]
		[Address(RVA = "0x92752C", Offset = "0x92752C", VA = "0x92752C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600333F")]
		[Address(RVA = "0x9278A8", Offset = "0x9278A8", VA = "0x9278A8", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x4002B9E")]
	[FieldOffset(Offset = "0x48")]
	public GameObject FlatSplat;

	[Token(Token = "0x4002B9F")]
	[FieldOffset(Offset = "0x50")]
	public GameObject AngleSplat;

	[Token(Token = "0x4002BA0")]
	[FieldOffset(Offset = "0x58")]
	public float AngleThreshold;

	[Token(Token = "0x4002BA1")]
	[FieldOffset(Offset = "0x5C")]
	public float MaxDistance;

	[Token(Token = "0x4002BA2")]
	[FieldOffset(Offset = "0x60")]
	public GameObject Bleeder;

	[Token(Token = "0x600332D")]
	[Address(RVA = "0xC69C18", Offset = "0xC69C18", VA = "0xC69C18", Slot = "9")]
	protected override void Start()
	{
	}

	[Token(Token = "0x600332E")]
	[Address(RVA = "0xC69CD4", Offset = "0xC69CD4", VA = "0xC69CD4", Slot = "10")]
	protected override void OnDestroy()
	{
	}

	[Token(Token = "0x600332F")]
	[Address(RVA = "0xC69C68", Offset = "0xC69C68", VA = "0xC69C68")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x6228A0", Offset = "0x6228A0")]
	private IEnumerator ApplySplatters()
	{
		return null;
	}

	[Token(Token = "0x6003330")]
	[Address(RVA = "0xC69D60", Offset = "0xC69D60", VA = "0xC69D60")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x622900", Offset = "0x622900")]
	private IEnumerator BloodFadeOut(GameObject splatter)
	{
		return null;
	}

	[Token(Token = "0x6003331")]
	[Address(RVA = "0xC69DCC", Offset = "0xC69DCC", VA = "0xC69DCC")]
	public BloodSplatter()
	{
	}
}
