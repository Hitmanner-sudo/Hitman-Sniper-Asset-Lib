using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000303")]
public class PushVolume : NPCColliderTrigger
{
	[Token(Token = "0x2000304")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x593314", Offset = "0x593314")]
	private sealed class _003CPush_003Ed__7 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40010AA")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40010AB")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40010AC")]
		[FieldOffset(Offset = "0x20")]
		public AIController ai;

		[Token(Token = "0x40010AD")]
		[FieldOffset(Offset = "0x28")]
		public PushVolume _003C_003E4__this;

		[Token(Token = "0x40010AE")]
		[FieldOffset(Offset = "0x30")]
		private HierarchicalCollision[] _003Chcs_003E5__2;

		[Token(Token = "0x40010AF")]
		[FieldOffset(Offset = "0x38")]
		private Vector3 _003Cforce_003E5__3;

		[Token(Token = "0x170002AF")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6001279")]
			[Address(RVA = "0x8B219C", Offset = "0x8B219C", VA = "0x8B219C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170002B0")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600127B")]
			[Address(RVA = "0x8B21E4", Offset = "0x8B21E4", VA = "0x8B21E4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6001276")]
		[Address(RVA = "0x8B1E04", Offset = "0x8B1E04", VA = "0x8B1E04")]
		[DebuggerHidden]
		public _003CPush_003Ed__7(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6001277")]
		[Address(RVA = "0x8B1E30", Offset = "0x8B1E30", VA = "0x8B1E30", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6001278")]
		[Address(RVA = "0x8B1E34", Offset = "0x8B1E34", VA = "0x8B1E34", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600127A")]
		[Address(RVA = "0x8B21A4", Offset = "0x8B21A4", VA = "0x8B21A4", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x40010A5")]
	[FieldOffset(Offset = "0x78")]
	public float Force;

	[Token(Token = "0x40010A6")]
	[FieldOffset(Offset = "0x7C")]
	public bool On;

	[Token(Token = "0x40010A7")]
	[FieldOffset(Offset = "0x80")]
	public Damage.Types Type;

	[Token(Token = "0x40010A8")]
	[FieldOffset(Offset = "0x84")]
	private float pushSource;

	[Token(Token = "0x40010A9")]
	[FieldOffset(Offset = "0x88")]
	private float pushMultiplier;

	[Token(Token = "0x6001272")]
	[Address(RVA = "0xB3C2E8", Offset = "0xB3C2E8", VA = "0xB3C2E8", Slot = "14")]
	protected override bool OnEnter(AIController ai)
	{
		return default(bool);
	}

	[Token(Token = "0x6001273")]
	[Address(RVA = "0xB3C3B4", Offset = "0xB3C3B4", VA = "0xB3C3B4", Slot = "16")]
	protected override bool SatisfiedBy(AIController ai)
	{
		return default(bool);
	}

	[Token(Token = "0x6001274")]
	[Address(RVA = "0xB3C33C", Offset = "0xB3C33C", VA = "0xB3C33C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x616274", Offset = "0x616274")]
	private IEnumerator Push(AIController ai)
	{
		return null;
	}

	[Token(Token = "0x6001275")]
	[Address(RVA = "0xB3C3CC", Offset = "0xB3C3CC", VA = "0xB3C3CC")]
	public PushVolume()
	{
	}
}
