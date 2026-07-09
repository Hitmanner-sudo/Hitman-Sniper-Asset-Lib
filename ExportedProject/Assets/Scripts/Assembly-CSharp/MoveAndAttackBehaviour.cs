using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Technology;
using UnityEngine;

[Token(Token = "0x2000103")]
public class MoveAndAttackBehaviour : AttractorBehaviour
{
	[Token(Token = "0x2000104")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x592468", Offset = "0x592468")]
	private sealed class _003CHurtReaction_003Ed__29 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40005BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40005C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40005C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MoveAndAttackBehaviour _003C_003E4__this;

		[Token(Token = "0x40005C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float speedRatio;

		[Token(Token = "0x40005C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float duration;

		[Token(Token = "0x40005C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Animator _003Canimator_003E5__2;

		[Token(Token = "0x40005C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private TaskMoveTo _003CtaskMoveTo_003E5__3;

		[Token(Token = "0x40005C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float _003CendTime_003E5__4;

		[Token(Token = "0x17000144")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600075C")]
			[Address(RVA = "0x8C928C", Offset = "0x8C928C", VA = "0x8C928C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000145")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600075E")]
			[Address(RVA = "0x8C92D4", Offset = "0x8C92D4", VA = "0x8C92D4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000759")]
		[Address(RVA = "0x8C8F34", Offset = "0x8C8F34", VA = "0x8C8F34")]
		[DebuggerHidden]
		public _003CHurtReaction_003Ed__29(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600075A")]
		[Address(RVA = "0x8C8F60", Offset = "0x8C8F60", VA = "0x8C8F60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600075B")]
		[Address(RVA = "0x8C8F64", Offset = "0x8C8F64", VA = "0x8C8F64", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600075D")]
		[Address(RVA = "0x8C9294", Offset = "0x8C9294", VA = "0x8C9294", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x40005B3")]
	private const float TIME_BEFORE_VALID_HIT = 0.25f;

	[Token(Token = "0x40005B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private float _lastDamageTime;

	[Token(Token = "0x40005B5")]
	private const float HIT_ATTACK_DURATION = 0.25f;

	[Token(Token = "0x40005B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private TaskIdle _task;

	[Token(Token = "0x40005B7")]
	private const string TASK_ID = "AttackOnSpot";

	[Token(Token = "0x40005B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private bool _attackLastEnemy;

	[Token(Token = "0x40005B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x51")]
	private bool _allyInTheWay;

	[Token(Token = "0x40005BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private GameObject _attackJoint;

	[Token(Token = "0x40005BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private Vector3 _oldPosition;

	[Token(Token = "0x40005BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	private bool _inCoroutine;

	[Token(Token = "0x40005BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private ThirdPersonCharacter _lastEnemyCharacter;

	[Token(Token = "0x40005BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private bool _isAttackingOnSpot;

	[Token(Token = "0x17000143")]
	public new MoveAndAttackEvaluator Evaluator
	{
		[Token(Token = "0x6000747")]
		[Address(RVA = "0xA2E02C", Offset = "0xA2E02C", VA = "0xA2E02C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000748")]
	[Address(RVA = "0xA2E0A8", Offset = "0xA2E0A8", VA = "0xA2E0A8", Slot = "5")]
	public override void Launch(AIController ai)
	{
	}

	[Token(Token = "0x6000749")]
	[Address(RVA = "0xA2E174", Offset = "0xA2E174", VA = "0xA2E174", Slot = "6")]
	public override void OnDestroy()
	{
	}

	[Token(Token = "0x600074A")]
	[Address(RVA = "0xA2E560", Offset = "0xA2E560", VA = "0xA2E560")]
	private void AttackOnSpot()
	{
	}

	[Token(Token = "0x600074B")]
	[Address(RVA = "0xA2E7E8", Offset = "0xA2E7E8", VA = "0xA2E7E8", Slot = "7")]
	public override bool Execute()
	{
		return default(bool);
	}

	[Token(Token = "0x600074C")]
	[Address(RVA = "0xA2F4A0", Offset = "0xA2F4A0", VA = "0xA2F4A0")]
	private void DamageLastTargetFailSafe()
	{
	}

	[Token(Token = "0x600074D")]
	[Address(RVA = "0xA2F1BC", Offset = "0xA2F1BC", VA = "0xA2F1BC")]
	private void DoSwipeDamage([Optional] SoundContainer SFX, [Optional] Faction IgnoreFaction)
	{
	}

	[Token(Token = "0x600074E")]
	[Address(RVA = "0xA2F058", Offset = "0xA2F058", VA = "0xA2F058")]
	private void AdjustAttackAnim(bool isAttacking, float HitDuration)
	{
	}

	[Token(Token = "0x600074F")]
	[Address(RVA = "0xA2ED84", Offset = "0xA2ED84", VA = "0xA2ED84")]
	private RaycastHit[] GetValidHits(RaycastHit[] rayHits, [Optional] Faction IgnoreFaction)
	{
		return null;
	}

	[Token(Token = "0x6000750")]
	[Address(RVA = "0xA2F92C", Offset = "0xA2F92C", VA = "0xA2F92C")]
	private void DoDamage(RaycastHit[] rayCastHits, Vector3 direction, [Optional] SoundContainer SFX)
	{
	}

	[Token(Token = "0x6000751")]
	[Address(RVA = "0xA2F5DC", Offset = "0xA2F5DC", VA = "0xA2F5DC")]
	private Damage GetNewDamage(Vector3 direction)
	{
		return null;
	}

	[Token(Token = "0x6000752")]
	[Address(RVA = "0xA2F800", Offset = "0xA2F800", VA = "0xA2F800")]
	private void PlayHitEffects([Optional] SoundContainer SFX)
	{
	}

	[Token(Token = "0x6000753")]
	[Address(RVA = "0xA2FAA0", Offset = "0xA2FAA0", VA = "0xA2FAA0")]
	private void SpawnEffect(GameObject SpawnEffectObject, bool attachToParent)
	{
	}

	[Token(Token = "0x6000754")]
	[Address(RVA = "0xA2FAD8", Offset = "0xA2FAD8", VA = "0xA2FAD8")]
	private void OnTakeDamage(object sender, Health.TakeDamageEventArgs args)
	{
	}

	[Token(Token = "0x6000755")]
	[Address(RVA = "0xA2F198", Offset = "0xA2F198", VA = "0xA2F198")]
	private void CheckBlockByAlly()
	{
	}

	[Token(Token = "0x6000756")]
	[Address(RVA = "0xA2FB24", Offset = "0xA2FB24", VA = "0xA2FB24")]
	private void DoReaction(float duration, float speedRatio)
	{
	}

	[Token(Token = "0x6000757")]
	[Address(RVA = "0xA2FBFC", Offset = "0xA2FBFC", VA = "0xA2FBFC")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x612410", Offset = "0x612410")]
	private IEnumerator HurtReaction(float duration, float speedRatio)
	{
		return null;
	}

	[Token(Token = "0x6000758")]
	[Address(RVA = "0xA2FC7C", Offset = "0xA2FC7C", VA = "0xA2FC7C")]
	public MoveAndAttackBehaviour()
	{
	}
}
