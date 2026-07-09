using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;

[Token(Token = "0x20000CE")]
public class LeanWaypoint : Waypoint
{
	[Token(Token = "0x20000CF")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5923E8", Offset = "0x5923E8")]
	private sealed class _003CApplyFallDamage_003Ed__7 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40004CD")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40004CE")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40004CF")]
		[FieldOffset(Offset = "0x20")]
		public DamageCollider collider;

		[Token(Token = "0x40004D0")]
		[FieldOffset(Offset = "0x28")]
		public Damage damage;

		[Token(Token = "0x1700012C")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6000637")]
			[Address(RVA = "0x8C14E8", Offset = "0x8C14E8", VA = "0x8C14E8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700012D")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6000639")]
			[Address(RVA = "0x8C1530", Offset = "0x8C1530", VA = "0x8C1530", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000634")]
		[Address(RVA = "0x8C13CC", Offset = "0x8C13CC", VA = "0x8C13CC")]
		[DebuggerHidden]
		public _003CApplyFallDamage_003Ed__7(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6000635")]
		[Address(RVA = "0x8C13F8", Offset = "0x8C13F8", VA = "0x8C13F8", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6000636")]
		[Address(RVA = "0x8C13FC", Offset = "0x8C13FC", VA = "0x8C13FC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000638")]
		[Address(RVA = "0x8C14F0", Offset = "0x8C14F0", VA = "0x8C14F0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x40004CA")]
	[FieldOffset(Offset = "0xE8")]
	public AnimationConfig.IdleType IdleTypeBroken;

	[Token(Token = "0x40004CB")]
	[FieldOffset(Offset = "0xF0")]
	public Breakable LeanAgainst;

	[Token(Token = "0x40004CC")]
	[FieldOffset(Offset = "0xF8")]
	public float FallImpuse;

	[Token(Token = "0x600062B")]
	[Address(RVA = "0x9A9D98", Offset = "0x9A9D98", VA = "0x9A9D98", Slot = "9")]
	protected override void Start()
	{
	}

	[Token(Token = "0x600062C")]
	[Address(RVA = "0x9A9E9C", Offset = "0x9A9E9C", VA = "0x9A9E9C", Slot = "14")]
	public override FilterType Filter(AIController ai)
	{
		return default(FilterType);
	}

	[Token(Token = "0x600062D")]
	[Address(RVA = "0x9A9F94", Offset = "0x9A9F94", VA = "0x9A9F94", Slot = "10")]
	protected override void OnDestroy()
	{
	}

	[Token(Token = "0x600062E")]
	[Address(RVA = "0x9AA0D4", Offset = "0x9AA0D4", VA = "0x9AA0D4")]
	private void OnBreak(object breakable, Breakable.BreakEvent args)
	{
	}

	[Token(Token = "0x600062F")]
	[Address(RVA = "0x9AA384", Offset = "0x9AA384", VA = "0x9AA384")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x612070", Offset = "0x612070")]
	private IEnumerator ApplyFallDamage(DamageCollider collider, Damage damage)
	{
		return null;
	}

	[Token(Token = "0x6000630")]
	[Address(RVA = "0x9A9EEC", Offset = "0x9A9EEC", VA = "0x9A9EEC")]
	private bool IsBroken()
	{
		return default(bool);
	}

	[Token(Token = "0x6000631")]
	[Address(RVA = "0x9A9F84", Offset = "0x9A9F84", VA = "0x9A9F84")]
	private bool HasValidBrokenIdleType()
	{
		return default(bool);
	}

	[Token(Token = "0x6000632")]
	[Address(RVA = "0x9AA3FC", Offset = "0x9AA3FC", VA = "0x9AA3FC", Slot = "28")]
	public override AnimationConfig.IdleType GetIdleType()
	{
		return default(AnimationConfig.IdleType);
	}

	[Token(Token = "0x6000633")]
	[Address(RVA = "0x9AA430", Offset = "0x9AA430", VA = "0x9AA430")]
	public LeanWaypoint()
	{
	}
}
