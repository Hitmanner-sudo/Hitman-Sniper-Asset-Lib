using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20001A0")]
public class ForceOnCharacter : MonoBehaviour
{
	[Token(Token = "0x20001A1")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x592944", Offset = "0x592944")]
	private sealed class _003CApplyForceOverTime_003Ed__12 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40008CE")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40008CF")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40008D0")]
		[FieldOffset(Offset = "0x20")]
		public ForceOnCharacter _003C_003E4__this;

		[Token(Token = "0x40008D1")]
		[FieldOffset(Offset = "0x28")]
		private GameTimer _003CdurationTimer_003E5__2;

		[Token(Token = "0x170001C9")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6000B14")]
			[Address(RVA = "0x8718DC", Offset = "0x8718DC", VA = "0x8718DC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001CA")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6000B16")]
			[Address(RVA = "0x871924", Offset = "0x871924", VA = "0x871924", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000B11")]
		[Address(RVA = "0x8717C4", Offset = "0x8717C4", VA = "0x8717C4")]
		[DebuggerHidden]
		public _003CApplyForceOverTime_003Ed__12(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6000B12")]
		[Address(RVA = "0x8717F0", Offset = "0x8717F0", VA = "0x8717F0", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6000B13")]
		[Address(RVA = "0x8717F4", Offset = "0x8717F4", VA = "0x8717F4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000B15")]
		[Address(RVA = "0x8718E4", Offset = "0x8718E4", VA = "0x8718E4", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x40008C7")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private float _forceValue;

	[Token(Token = "0x40008C8")]
	[FieldOffset(Offset = "0x1C")]
	[SerializeField]
	private Vector3 _directionOfForce;

	[Token(Token = "0x40008C9")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Rigidbody _rigidBodyToApplyForce;

	[Token(Token = "0x40008CA")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private Health _healthOfObjectApplyingForce;

	[Token(Token = "0x40008CB")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private Health _healthOfCharacterToAddForce;

	[Token(Token = "0x40008CC")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private float _forceDuration;

	[Token(Token = "0x40008CD")]
	[FieldOffset(Offset = "0x44")]
	[SerializeField]
	private ForceMode _forceMode;

	[Token(Token = "0x6000B09")]
	[Address(RVA = "0x95A324", Offset = "0x95A324", VA = "0x95A324")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000B0A")]
	[Address(RVA = "0x95A41C", Offset = "0x95A41C", VA = "0x95A41C")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000B0B")]
	[Address(RVA = "0x95A4C4", Offset = "0x95A4C4", VA = "0x95A4C4")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000B0C")]
	[Address(RVA = "0x95A5B8", Offset = "0x95A5B8", VA = "0x95A5B8")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000B0D")]
	[Address(RVA = "0x95A628", Offset = "0x95A628", VA = "0x95A628")]
	private void OnTakeDamage(object sender, Health.TakeDamageEventArgs args)
	{
	}

	[Token(Token = "0x6000B0E")]
	[Address(RVA = "0x95A7F0", Offset = "0x95A7F0", VA = "0x95A7F0")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x613E74", Offset = "0x613E74")]
	private IEnumerator ApplyForceOverTime()
	{
		return null;
	}

	[Token(Token = "0x6000B0F")]
	[Address(RVA = "0x95A774", Offset = "0x95A774", VA = "0x95A774")]
	private void ApplyForce()
	{
	}

	[Token(Token = "0x6000B10")]
	[Address(RVA = "0x95A85C", Offset = "0x95A85C", VA = "0x95A85C")]
	public ForceOnCharacter()
	{
	}
}
