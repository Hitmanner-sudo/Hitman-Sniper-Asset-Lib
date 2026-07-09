using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200089A")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x596AFC", Offset = "0x596AFC")]
public class ParticlesHelper : MonoBehaviour
{
	[Token(Token = "0x200089B")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x596B5C", Offset = "0x596B5C")]
	private sealed class _003CAutoDestroy_003Ed__7 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4003019")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400301A")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400301B")]
		[FieldOffset(Offset = "0x20")]
		public ParticlesHelper _003C_003E4__this;

		[Token(Token = "0x1700071D")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60037FE")]
			[Address(RVA = "0x8CED60", Offset = "0x8CED60", VA = "0x8CED60", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700071E")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6003800")]
			[Address(RVA = "0x8CEDA8", Offset = "0x8CEDA8", VA = "0x8CEDA8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60037FB")]
		[Address(RVA = "0x8CEC28", Offset = "0x8CEC28", VA = "0x8CEC28")]
		[DebuggerHidden]
		public _003CAutoDestroy_003Ed__7(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60037FC")]
		[Address(RVA = "0x8CEC54", Offset = "0x8CEC54", VA = "0x8CEC54", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60037FD")]
		[Address(RVA = "0x8CEC58", Offset = "0x8CEC58", VA = "0x8CEC58", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60037FF")]
		[Address(RVA = "0x8CED68", Offset = "0x8CED68", VA = "0x8CED68", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x4003013")]
	[FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x5BB774", Offset = "0x5BB774")]
	public Vector3 LocalOffset;

	[Token(Token = "0x4003014")]
	[FieldOffset(Offset = "0x24")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x5BB7AC", Offset = "0x5BB7AC")]
	public bool MoveTowardCamera;

	[Token(Token = "0x4003015")]
	[FieldOffset(Offset = "0x28")]
	public float Offset;

	[Token(Token = "0x4003016")]
	[FieldOffset(Offset = "0x2C")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x5BB7E4", Offset = "0x5BB7E4")]
	public bool PlayAfterMove;

	[Token(Token = "0x4003017")]
	[FieldOffset(Offset = "0x2D")]
	public bool AutoDestroyGameObject;

	[Token(Token = "0x4003018")]
	[FieldOffset(Offset = "0x30")]
	private ParticleSystem _particles;

	[Token(Token = "0x60037F8")]
	[Address(RVA = "0x8F5FBC", Offset = "0x8F5FBC", VA = "0x8F5FBC")]
	protected void Start()
	{
	}

	[Token(Token = "0x60037F9")]
	[Address(RVA = "0x8F61F0", Offset = "0x8F61F0", VA = "0x8F61F0")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x623970", Offset = "0x623970")]
	protected IEnumerator AutoDestroy()
	{
		return null;
	}

	[Token(Token = "0x60037FA")]
	[Address(RVA = "0x8F625C", Offset = "0x8F625C", VA = "0x8F625C")]
	public ParticlesHelper()
	{
	}
}
