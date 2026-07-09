using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20001AA")]
public class DamageCollider : MonoBehaviour
{
	[Token(Token = "0x20001AB")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x592954", Offset = "0x592954")]
	private sealed class _003CSpawnEffectsAsync_003Ed__33 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000935")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4000936")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4000937")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public DamageCollider _003C_003E4__this;

		[Token(Token = "0x4000938")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public LazyGameObject lazyGameObject;

		[Token(Token = "0x4000939")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Damage damage;

		[Token(Token = "0x170001D3")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6000B40")]
			[Address(RVA = "0x86A56C", Offset = "0x86A56C", VA = "0x86A56C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001D4")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6000B42")]
			[Address(RVA = "0x86A5B4", Offset = "0x86A5B4", VA = "0x86A5B4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000B3D")]
		[Address(RVA = "0x86A120", Offset = "0x86A120", VA = "0x86A120")]
		[DebuggerHidden]
		public _003CSpawnEffectsAsync_003Ed__33(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6000B3E")]
		[Address(RVA = "0x86A14C", Offset = "0x86A14C", VA = "0x86A14C", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6000B3F")]
		[Address(RVA = "0x86A150", Offset = "0x86A150", VA = "0x86A150", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000B41")]
		[Address(RVA = "0x86A574", Offset = "0x86A574", VA = "0x86A574", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x4000923")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Health Health;

	[Token(Token = "0x4000924")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public OnDamageDesc OnDamageDesc;

	[Token(Token = "0x4000925")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public bool CanGiveDamage;

	[Token(Token = "0x4000926")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
	public bool VerticalDamageOnly;

	[Token(Token = "0x4000927")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2A")]
	public bool SpawnBulletHoles;

	[Token(Token = "0x4000928")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2B")]
	public bool DetonateExplosiveBullets;

	[Token(Token = "0x4000929")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5B2124", Offset = "0x5B2124")]
	public float RicochetRadius;

	[Token(Token = "0x400092A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public bool ReceiveBloodDecals;

	[Token(Token = "0x400092B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0x5B2140", Offset = "0x5B2140")]
	public bool AwardXRayKills;

	[Token(Token = "0x400092C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public List<Damage.Types> AffectedByDamageType;

	[Token(Token = "0x400092D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public bool StopAllBullets;

	[Token(Token = "0x400092E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x41")]
	public bool NeedDirectHit;

	[Token(Token = "0x400092F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x42")]
	private bool _pinOnCollision;

	[Token(Token = "0x4000930")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	private Vector3 _pinForce;

	[Token(Token = "0x4000931")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private float _pinTime;

	[Token(Token = "0x4000932")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private GameObject _pinPullObject;

	[Token(Token = "0x4000933")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private Rigidbody _rigidBodyObject;

	[Token(Token = "0x4000934")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private ThirdPersonCharacter _thirdPersonCharacter;

	[Token(Token = "0x170001D1")]
	public Damage.BodyPart Part
	{
		[Token(Token = "0x6000B2D")]
		[Address(RVA = "0xADFDD8", Offset = "0xADFDD8", VA = "0xADFDD8")]
		get
		{
			return default(Damage.BodyPart);
		}
	}

	[Token(Token = "0x170001D2")]
	private bool HasThirdPersonCharacter
	{
		[Token(Token = "0x6000B2E")]
		[Address(RVA = "0xADFDF4", Offset = "0xADFDF4", VA = "0xADFDF4")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6000B2F")]
	[Address(RVA = "0xADFE60", Offset = "0xADFE60", VA = "0xADFE60")]
	public void Awake()
	{
	}

	[Token(Token = "0x6000B30")]
	[Address(RVA = "0xAE0020", Offset = "0xAE0020", VA = "0xAE0020")]
	public void OnDestroy()
	{
	}

	[Token(Token = "0x6000B31")]
	[Address(RVA = "0xADF700", Offset = "0xADF700", VA = "0xADF700")]
	public bool TakeDamage(Damage damage, [Optional] DamageOverTime dot)
	{
		return default(bool);
	}

	[Token(Token = "0x6000B32")]
	[Address(RVA = "0xAE02F8", Offset = "0xAE02F8", VA = "0xAE02F8")]
	private void DoPinShot(bool hasHealth, Damage damage)
	{
	}

	[Token(Token = "0x6000B33")]
	[Address(RVA = "0xAE0784", Offset = "0xAE0784", VA = "0xAE0784")]
	private void DoPushShot(bool hasHealth, Damage damage)
	{
	}

	[Token(Token = "0x6000B34")]
	[Address(RVA = "0xAE0A3C", Offset = "0xAE0A3C", VA = "0xAE0A3C")]
	private Vector3 GetValidClosestTargetPosition(ThirdPersonCharacter targetCharacter)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000B35")]
	[Address(RVA = "0xAE095C", Offset = "0xAE095C", VA = "0xAE095C")]
	private void DoPossessShot(bool hasHealth)
	{
	}

	[Token(Token = "0x6000B36")]
	[Address(RVA = "0xAE0CFC", Offset = "0xAE0CFC", VA = "0xAE0CFC")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x6000B37")]
	[Address(RVA = "0xAE104C", Offset = "0xAE104C", VA = "0xAE104C")]
	private void PinOnCollision(Rigidbody rigidBodyObject)
	{
	}

	[Token(Token = "0x6000B38")]
	[Address(RVA = "0xAE1184", Offset = "0xAE1184", VA = "0xAE1184")]
	private void ChangeCanGiveDamage(bool value)
	{
	}

	[Token(Token = "0x6000B39")]
	[Address(RVA = "0xAE00EC", Offset = "0xAE00EC", VA = "0xAE00EC")]
	private void SpawnEffects(Damage damage)
	{
	}

	[Token(Token = "0x6000B3A")]
	[Address(RVA = "0xAE12A4", Offset = "0xAE12A4", VA = "0xAE12A4")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x613F24", Offset = "0x613F24")]
	private IEnumerator SpawnEffectsAsync(Damage damage, LazyGameObject lazyGameObject)
	{
		return null;
	}

	[Token(Token = "0x6000B3B")]
	[Address(RVA = "0xAE1324", Offset = "0xAE1324", VA = "0xAE1324")]
	private void OnCollisionEnter(Collision collision)
	{
	}

	[Token(Token = "0x6000B3C")]
	[Address(RVA = "0xAE1C30", Offset = "0xAE1C30", VA = "0xAE1C30")]
	public DamageCollider()
	{
	}
}
