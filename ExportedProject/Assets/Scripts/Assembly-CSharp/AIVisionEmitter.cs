using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using Technology;
using UnityEngine;

[Token(Token = "0x2000138")]
public class AIVisionEmitter : AIEmitter
{
	[Token(Token = "0x2000139")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5925CC", Offset = "0x5925CC")]
	private sealed class _003CDelayedRegister_003Ed__4 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40006BE")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40006BF")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40006C0")]
		[FieldOffset(Offset = "0x20")]
		public AIVisionEmitter _003C_003E4__this;

		[Token(Token = "0x17000167")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600087E")]
			[Address(RVA = "0x910B3C", Offset = "0x910B3C", VA = "0x910B3C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000168")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6000880")]
			[Address(RVA = "0x910B84", Offset = "0x910B84", VA = "0x910B84", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600087B")]
		[Address(RVA = "0x910A70", Offset = "0x910A70", VA = "0x910A70")]
		[DebuggerHidden]
		public _003CDelayedRegister_003Ed__4(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600087C")]
		[Address(RVA = "0x910A9C", Offset = "0x910A9C", VA = "0x910A9C", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600087D")]
		[Address(RVA = "0x910AA0", Offset = "0x910AA0", VA = "0x910AA0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600087F")]
		[Address(RVA = "0x910B44", Offset = "0x910B44", VA = "0x910B44", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x40006BB")]
	[FieldOffset(Offset = "0x50")]
	[HideInInspector]
	public Vector3 LookAtPosition;

	[Token(Token = "0x40006BC")]
	[FieldOffset(Offset = "0x60")]
	public Blackboard VisibleProperties;

	[Token(Token = "0x40006BD")]
	[FieldOffset(Offset = "0x68")]
	public bool Hidden;

	[Token(Token = "0x6000870")]
	[Address(RVA = "0xA995E4", Offset = "0xA995E4", VA = "0xA995E4", Slot = "9")]
	protected override void Start()
	{
	}

	[Token(Token = "0x6000871")]
	[Address(RVA = "0xA9961C", Offset = "0xA9961C", VA = "0xA9961C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x6126E0", Offset = "0x6126E0")]
	private IEnumerator DelayedRegister()
	{
		return null;
	}

	[Token(Token = "0x6000872")]
	[Address(RVA = "0xA99688", Offset = "0xA99688", VA = "0xA99688", Slot = "10")]
	protected override void OnDestroy()
	{
	}

	[Token(Token = "0x6000873")]
	[Address(RVA = "0xA9971C", Offset = "0xA9971C", VA = "0xA9971C")]
	public void Hide()
	{
	}

	[Token(Token = "0x6000874")]
	[Address(RVA = "0xA99728", Offset = "0xA99728", VA = "0xA99728", Slot = "19")]
	public virtual ThreatLevel GetVisibleThreatLevel(AIVisionSensor sensor)
	{
		return default(ThreatLevel);
	}

	[Token(Token = "0x6000875")]
	[Address(RVA = "0xA99730", Offset = "0xA99730", VA = "0xA99730", Slot = "20")]
	public virtual bool GetVisibleIsScared(AIVisionSensor sensor)
	{
		return default(bool);
	}

	[Token(Token = "0x6000876")]
	[Address(RVA = "0xA99738", Offset = "0xA99738", VA = "0xA99738", Slot = "21")]
	public virtual void UpdateLookAtPosition()
	{
	}

	[Token(Token = "0x6000877")]
	[Address(RVA = "0xA99770", Offset = "0xA99770", VA = "0xA99770", Slot = "5")]
	protected override void GameUpdate()
	{
	}

	[Token(Token = "0x6000878")]
	[Address(RVA = "0xA99780", Offset = "0xA99780", VA = "0xA99780")]
	protected void OnDrawGizmosSelected()
	{
	}

	[Token(Token = "0x6000879")]
	[Address(RVA = "0xA99908", Offset = "0xA99908", VA = "0xA99908", Slot = "22")]
	public virtual void WasSeen(AIVisionSensor sensor)
	{
	}

	[Token(Token = "0x600087A")]
	[Address(RVA = "0xA96588", Offset = "0xA96588", VA = "0xA96588")]
	public AIVisionEmitter()
	{
	}
}
