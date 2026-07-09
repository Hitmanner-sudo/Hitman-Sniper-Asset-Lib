using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using Technology;
using UnityEngine;

[Token(Token = "0x20002FA")]
public class Explosive : Breakable
{
	[Token(Token = "0x20002FB")]
	public enum DistributionMethod
	{
		[Token(Token = "0x400105D")]
		Uniform = 0,
		[Token(Token = "0x400105E")]
		FallOff = 1
	}

	[Token(Token = "0x20002FC")]
	public struct ExplosionArgs
	{
		[Token(Token = "0x400105F")]
		[FieldOffset(Offset = "0x0")]
		public long BulletID;

		[Token(Token = "0x4001060")]
		[FieldOffset(Offset = "0x8")]
		public Vector3 Position;

		[Token(Token = "0x4001061")]
		[FieldOffset(Offset = "0x14")]
		public Vector3 Normal;

		[Token(Token = "0x4001062")]
		[FieldOffset(Offset = "0x20")]
		public Damage.Types DamageType;

		[Token(Token = "0x4001063")]
		[FieldOffset(Offset = "0x28")]
		public GameObject Instigator;

		[Token(Token = "0x4001064")]
		[FieldOffset(Offset = "0x30")]
		public Faction InstigatorFaction;

		[Token(Token = "0x4001065")]
		[FieldOffset(Offset = "0x38")]
		public float ExplosionRadius;

		[Token(Token = "0x4001066")]
		[FieldOffset(Offset = "0x3C")]
		public float ExplosionDamage;

		[Token(Token = "0x4001067")]
		[FieldOffset(Offset = "0x40")]
		public float ExplosionImpulse;

		[Token(Token = "0x4001068")]
		[FieldOffset(Offset = "0x48")]
		public Collider EffectZone;

		[Token(Token = "0x4001069")]
		[FieldOffset(Offset = "0x50")]
		public bool IgnoreGeometry;

		[Token(Token = "0x400106A")]
		[FieldOffset(Offset = "0x51")]
		public bool SpawnEffectsAtRoot;

		[Token(Token = "0x400106B")]
		[FieldOffset(Offset = "0x54")]
		public DistributionMethod Distribution;

		[Token(Token = "0x400106C")]
		[FieldOffset(Offset = "0x58")]
		public Explosive Exploder;

		[Token(Token = "0x400106D")]
		[FieldOffset(Offset = "0x60")]
		public float TravelDistance;

		[Token(Token = "0x400106E")]
		[FieldOffset(Offset = "0x68")]
		public List<Damage.Hit> History;

		[Token(Token = "0x400106F")]
		[FieldOffset(Offset = "0x70")]
		public bool NoFriendlyFire;

		[Token(Token = "0x4001070")]
		[FieldOffset(Offset = "0x78")]
		public DamageOverTime DotToApply;

		[Token(Token = "0x4001071")]
		[FieldOffset(Offset = "0x80")]
		public GameObject ExplosionEffect;

		[Token(Token = "0x4001072")]
		[FieldOffset(Offset = "0x88")]
		public SoundContainer ImpactSound;

		[Token(Token = "0x4001073")]
		[FieldOffset(Offset = "0x90")]
		public bool FromAttractiveBulletExplosion;
	}

	[Token(Token = "0x20002FD")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x593304", Offset = "0x593304")]
	private sealed class _003CDelayedExplode_003Ed__17 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4001074")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4001075")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4001076")]
		[FieldOffset(Offset = "0x20")]
		public Explosive _003C_003E4__this;

		[Token(Token = "0x4001077")]
		[FieldOffset(Offset = "0x28")]
		public Damage damage;

		[Token(Token = "0x4001078")]
		[FieldOffset(Offset = "0x30")]
		private float _003CexplosionTime_003E5__2;

		[Token(Token = "0x170002AB")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6001245")]
			[Address(RVA = "0x86FFE8", Offset = "0x86FFE8", VA = "0x86FFE8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170002AC")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6001247")]
			[Address(RVA = "0x870030", Offset = "0x870030", VA = "0x870030", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6001242")]
		[Address(RVA = "0x86FD88", Offset = "0x86FD88", VA = "0x86FD88")]
		[DebuggerHidden]
		public _003CDelayedExplode_003Ed__17(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6001243")]
		[Address(RVA = "0x86FDB4", Offset = "0x86FDB4", VA = "0x86FDB4", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6001244")]
		[Address(RVA = "0x86FDB8", Offset = "0x86FDB8", VA = "0x86FDB8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6001246")]
		[Address(RVA = "0x86FFF0", Offset = "0x86FFF0", VA = "0x86FFF0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x400104D")]
	[FieldOffset(Offset = "0x88")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x5B3E6C", Offset = "0x5B3E6C")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5B3E6C", Offset = "0x5B3E6C")]
	public float ExplosionRadius;

	[Token(Token = "0x400104E")]
	[FieldOffset(Offset = "0x8C")]
	public float ExplosionDamage;

	[Token(Token = "0x400104F")]
	[FieldOffset(Offset = "0x90")]
	public float ExplosionImpulse;

	[Token(Token = "0x4001050")]
	[FieldOffset(Offset = "0x94")]
	public float ExplosionDelay;

	[Token(Token = "0x4001051")]
	[FieldOffset(Offset = "0x98")]
	public Damage.Types InflictDamageType;

	[Token(Token = "0x4001052")]
	[FieldOffset(Offset = "0xA0")]
	public Collider EffectZone;

	[Token(Token = "0x4001053")]
	[FieldOffset(Offset = "0xA8")]
	public bool SpawnEffectsAtRoot;

	[Token(Token = "0x4001054")]
	[FieldOffset(Offset = "0xB0")]
	public GameObject DelayEffects;

	[Token(Token = "0x4001055")]
	[FieldOffset(Offset = "0xB8")]
	public bool IgnoreGeometry;

	[Token(Token = "0x4001056")]
	[FieldOffset(Offset = "0xC0")]
	public DamageOverTime DotToApply;

	[Token(Token = "0x4001057")]
	[FieldOffset(Offset = "0xC8")]
	public DistributionMethod Distribution;

	[Token(Token = "0x4001058")]
	[FieldOffset(Offset = "0xD0")]
	private Coroutine _delayedExplosion;

	[Token(Token = "0x4001059")]
	[FieldOffset(Offset = "0xD8")]
	private GameObject _spawnedBuildUpEffects;

	[Token(Token = "0x400105A")]
	[FieldOffset(Offset = "0xE0")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x5B3EC8", Offset = "0x5B3EC8")]
	public bool SkipDelayOnReHit;

	[Token(Token = "0x400105B")]
	[FieldOffset(Offset = "0xE1")]
	public bool AlwaysDrawGizmo;

	[Token(Token = "0x600123A")]
	[Address(RVA = "0xE1F9B4", Offset = "0xE1F9B4", VA = "0xE1F9B4", Slot = "10")]
	protected override void OnDestroy()
	{
	}

	[Token(Token = "0x600123B")]
	[Address(RVA = "0xE1FA48", Offset = "0xE1FA48", VA = "0xE1FA48", Slot = "14")]
	protected override void OnTakeDamage(object sender, Health.TakeDamageEventArgs args)
	{
	}

	[Token(Token = "0x600123C")]
	[Address(RVA = "0xE1FB40", Offset = "0xE1FB40", VA = "0xE1FB40")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x616184", Offset = "0x616184")]
	private IEnumerator DelayedExplode(Damage damage)
	{
		return null;
	}

	[Token(Token = "0x600123D")]
	[Address(RVA = "0xE1FBB8", Offset = "0xE1FBB8", VA = "0xE1FBB8")]
	private void Explode(Damage damage)
	{
	}

	[Token(Token = "0x600123E")]
	[Address(RVA = "0xE1DDD0", Offset = "0xE1DDD0", VA = "0xE1DDD0")]
	public static void Explode(Damage receivedDamage, ExplosionArgs args)
	{
	}

	[Token(Token = "0x600123F")]
	[Address(RVA = "0xE1FCC8", Offset = "0xE1FCC8", VA = "0xE1FCC8")]
	private static DamageCollider TryApplyDamage(Collider hit, Damage explosionDamage, ExplosionArgs args, bool showEffects, DamageOverTime dotToApply)
	{
		return null;
	}

	[Token(Token = "0x6001240")]
	[Address(RVA = "0xE1FED0", Offset = "0xE1FED0", VA = "0xE1FED0")]
	private static DamageCollider ApplyDamage(Collider hit, Damage explosionDamage, ExplosionArgs args, bool showEffects, DamageOverTime dotToApply)
	{
		return null;
	}

	[Token(Token = "0x6001241")]
	[Address(RVA = "0xE201C4", Offset = "0xE201C4", VA = "0xE201C4")]
	public Explosive()
	{
	}
}
