using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using Technology;
using UnityEngine;

[Token(Token = "0x20002F3")]
public class ExplodeAfterDelay : MonoBehaviour
{
	[Token(Token = "0x20002F4")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5932C4", Offset = "0x5932C4")]
	private sealed class _003CDelayedExplosion_003Ed__20 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400103D")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400103E")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400103F")]
		[FieldOffset(Offset = "0x20")]
		public ExplodeAfterDelay _003C_003E4__this;

		[Token(Token = "0x4001040")]
		[FieldOffset(Offset = "0x28")]
		private float _003CexplosionTime_003E5__2;

		[Token(Token = "0x170002A7")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6001222")]
			[Address(RVA = "0x86F9BC", Offset = "0x86F9BC", VA = "0x86F9BC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170002A8")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6001224")]
			[Address(RVA = "0x86FA04", Offset = "0x86FA04", VA = "0x86FA04", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600121F")]
		[Address(RVA = "0x86F730", Offset = "0x86F730", VA = "0x86F730")]
		[DebuggerHidden]
		public _003CDelayedExplosion_003Ed__20(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6001220")]
		[Address(RVA = "0x86F75C", Offset = "0x86F75C", VA = "0x86F75C", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6001221")]
		[Address(RVA = "0x86F760", Offset = "0x86F760", VA = "0x86F760", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6001223")]
		[Address(RVA = "0x86F9C4", Offset = "0x86F9C4", VA = "0x86F9C4", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x400102C")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private float _delay;

	[Token(Token = "0x400102D")]
	[FieldOffset(Offset = "0x1C")]
	[SerializeField]
	private float _explosionRadius;

	[Token(Token = "0x400102E")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private float _explosionDamage;

	[Token(Token = "0x400102F")]
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	private float _explosionImpulse;

	[Token(Token = "0x4001030")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private GameObject _explosionEffect;

	[Token(Token = "0x4001031")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private float _explosionCuriousDistance;

	[Token(Token = "0x4001032")]
	[FieldOffset(Offset = "0x34")]
	[SerializeField]
	private float _explosionSuspiciousDistance;

	[Token(Token = "0x4001033")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private SoundContainer _explosionSound;

	[Token(Token = "0x4001034")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private GameObject _gameObjectToDestroyAfterExplosion;

	[Token(Token = "0x4001035")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private DamageOverTime _dotToApply;

	[Token(Token = "0x4001036")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private bool _fromAttractiveBullet;

	[Token(Token = "0x4001037")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	private SoundContainer _soundToPlayOnDelay;

	[Token(Token = "0x4001038")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	private Explosive.DistributionMethod _distributionMethod;

	[Token(Token = "0x4001039")]
	[FieldOffset(Offset = "0x64")]
	[SerializeField]
	private Damage.Types _explosionDamageType;

	[Token(Token = "0x400103A")]
	[FieldOffset(Offset = "0x68")]
	private long _bulletID;

	[Token(Token = "0x400103B")]
	[FieldOffset(Offset = "0x70")]
	private bool _explodeCalled;

	[Token(Token = "0x400103C")]
	[FieldOffset(Offset = "0x78")]
	private PlayingSoundContainer _soundToPlayOnDelayPlayingSoundContainer;

	[Token(Token = "0x6001219")]
	[Address(RVA = "0xE1D818", Offset = "0xE1D818", VA = "0xE1D818")]
	private void Start()
	{
	}

	[Token(Token = "0x600121A")]
	[Address(RVA = "0xE1D8B0", Offset = "0xE1D8B0", VA = "0xE1D8B0")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x600121B")]
	[Address(RVA = "0xE1DDBC", Offset = "0xE1DDBC", VA = "0xE1DDBC")]
	public void SetExplosionData(float explosionRadius, float explosionDamage, DamageOverTime dotToApply, float delay, long bulletID)
	{
	}

	[Token(Token = "0x600121C")]
	[Address(RVA = "0xE1D844", Offset = "0xE1D844", VA = "0xE1D844")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x616024", Offset = "0x616024")]
	private IEnumerator DelayedExplosion()
	{
		return null;
	}

	[Token(Token = "0x600121D")]
	[Address(RVA = "0xE1D9D0", Offset = "0xE1D9D0", VA = "0xE1D9D0")]
	public void Explode()
	{
	}

	[Token(Token = "0x600121E")]
	[Address(RVA = "0xE1EA28", Offset = "0xE1EA28", VA = "0xE1EA28")]
	public ExplodeAfterDelay()
	{
	}
}
