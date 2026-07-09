using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Technology;
using UnityEngine;

[Token(Token = "0x20002FF")]
public class HierarchicalCollision : GameMonoBehaviour
{
	[Token(Token = "0x2000300")]
	private struct DistancePair
	{
		[Token(Token = "0x4001091")]
		[FieldOffset(Offset = "0x0")]
		internal Transform _transform;

		[Token(Token = "0x4001092")]
		[FieldOffset(Offset = "0x8")]
		internal float _distance;

		[Token(Token = "0x4001093")]
		[FieldOffset(Offset = "0xC")]
		internal float _offset;

		[Token(Token = "0x4001094")]
		[FieldOffset(Offset = "0x10")]
		internal float _interpolator;

		[Token(Token = "0x4001095")]
		[FieldOffset(Offset = "0x14")]
		internal float _speed;

		[Token(Token = "0x4001096")]
		[FieldOffset(Offset = "0x18")]
		internal float _delta;
	}

	[Token(Token = "0x4001086")]
	[FieldOffset(Offset = "0x48")]
	public GameObject Target;

	[NonSerialized]
	[Token(Token = "0x4001087")]
	[FieldOffset(Offset = "0x50")]
	public List<Rigidbody> RigidBodies;

	[NonSerialized]
	[Token(Token = "0x4001088")]
	[FieldOffset(Offset = "0x58")]
	public List<Collider> Colliders;

	[NonSerialized]
	[Token(Token = "0x4001089")]
	[FieldOffset(Offset = "0x60")]
	public List<CharacterJoint> Joints;

	[NonSerialized]
	[Token(Token = "0x400108A")]
	[FieldOffset(Offset = "0x68")]
	public List<DamageCollider> DamageColliders;

	[Token(Token = "0x400108B")]
	[FieldOffset(Offset = "0x70")]
	private int _nbObjectsInTrigger;

	[Token(Token = "0x400108C")]
	[FieldOffset(Offset = "0x74")]
	private int _nbOfEnableCalled;

	[Token(Token = "0x400108D")]
	[FieldOffset(Offset = "0x78")]
	private bool _inRagDoll;

	[Token(Token = "0x400108E")]
	[FieldOffset(Offset = "0x80")]
	private List<CollisionDetectionMode> DefaultCollisionMode;

	[Token(Token = "0x400108F")]
	[FieldOffset(Offset = "0x88")]
	private List<DistancePair> _childsToReposition;

	[Token(Token = "0x4001090")]
	[FieldOffset(Offset = "0x90")]
	private bool _isRepositioningJoints;

	[Token(Token = "0x600124C")]
	[Address(RVA = "0xA12868", Offset = "0xA12868", VA = "0xA12868", Slot = "7")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x600124D")]
	[Address(RVA = "0xA1302C", Offset = "0xA1302C", VA = "0xA1302C")]
	protected void FixedUpdate()
	{
	}

	[Token(Token = "0x600124E")]
	[Address(RVA = "0xA12890", Offset = "0xA12890", VA = "0xA12890")]
	public void InitRigidbodies()
	{
	}

	[Token(Token = "0x600124F")]
	[Address(RVA = "0xA13080", Offset = "0xA13080", VA = "0xA13080")]
	private void NormalizeMass(CharacterJoint joint)
	{
	}

	[Token(Token = "0x6001250")]
	[Address(RVA = "0xA13170", Offset = "0xA13170", VA = "0xA13170")]
	private void CacheDistances(Transform current)
	{
	}

	[Token(Token = "0x6001251")]
	[Address(RVA = "0xA134B8", Offset = "0xA134B8", VA = "0xA134B8")]
	private void CacheDistance(Collider colliderToAssess)
	{
	}

	[Token(Token = "0x6001252")]
	[Address(RVA = "0xA135E4", Offset = "0xA135E4", VA = "0xA135E4")]
	public void UnlinkCollisions()
	{
	}

	[Token(Token = "0x6001253")]
	[Address(RVA = "0xA136A0", Offset = "0xA136A0", VA = "0xA136A0")]
	public void EnableRagdoll(bool isEnabled)
	{
	}

	[Token(Token = "0x6001254")]
	[Address(RVA = "0xA132D4", Offset = "0xA132D4", VA = "0xA132D4")]
	private void DoEnableRigibodies(bool isEnabled)
	{
	}

	[Token(Token = "0x6001255")]
	[Address(RVA = "0xA13814", Offset = "0xA13814", VA = "0xA13814")]
	public void EnableRigibodies(bool isEnabled)
	{
	}

	[Token(Token = "0x6001256")]
	[Address(RVA = "0xA13864", Offset = "0xA13864", VA = "0xA13864")]
	private bool IsValidCollision(Collider other)
	{
		return default(bool);
	}

	[Token(Token = "0x6001257")]
	[Address(RVA = "0xA139D8", Offset = "0xA139D8", VA = "0xA139D8")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x6001258")]
	[Address(RVA = "0xA13A14", Offset = "0xA13A14", VA = "0xA13A14")]
	private void OnTriggerExit(Collider other)
	{
	}

	[Token(Token = "0x6001259")]
	[Address(RVA = "0xA13A70", Offset = "0xA13A70", VA = "0xA13A70")]
	public void ApplyForce(Vector3 force, ForceMode mode = ForceMode.Force)
	{
	}

	[Token(Token = "0x600125A")]
	[Address(RVA = "0xA13B40", Offset = "0xA13B40", VA = "0xA13B40")]
	public void CombineForce(Vector3 force, ForceMode mode = ForceMode.Force)
	{
	}

	[Token(Token = "0x600125B")]
	[Address(RVA = "0xA13CD0", Offset = "0xA13CD0", VA = "0xA13CD0")]
	public void CancelXZVelocity()
	{
	}

	[Token(Token = "0x600125C")]
	[Address(RVA = "0xA13D8C", Offset = "0xA13D8C", VA = "0xA13D8C")]
	internal void PrepareRagdollForFall()
	{
	}

	[Token(Token = "0x600125D")]
	[Address(RVA = "0xA14110", Offset = "0xA14110", VA = "0xA14110", Slot = "6")]
	protected override void LateGameUpdate()
	{
	}

	[Token(Token = "0x600125E")]
	[Address(RVA = "0xA143A8", Offset = "0xA143A8", VA = "0xA143A8")]
	public HierarchicalCollision()
	{
	}

	[Token(Token = "0x600125F")]
	[Address(RVA = "0xA143B0", Offset = "0xA143B0", VA = "0xA143B0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x616234", Offset = "0x616234")]
	private bool _003CInitRigidbodies_003Eb__14_0(Rigidbody rb)
	{
		return default(bool);
	}

	[Token(Token = "0x6001260")]
	[Address(RVA = "0xA144BC", Offset = "0xA144BC", VA = "0xA144BC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x616244", Offset = "0x616244")]
	private bool _003CInitRigidbodies_003Eb__14_1(Collider rb)
	{
		return default(bool);
	}

	[Token(Token = "0x6001261")]
	[Address(RVA = "0xA145C8", Offset = "0xA145C8", VA = "0xA145C8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x616254", Offset = "0x616254")]
	private bool _003CInitRigidbodies_003Eb__14_2(DamageCollider rb)
	{
		return default(bool);
	}

	[Token(Token = "0x6001262")]
	[Address(RVA = "0xA146D4", Offset = "0xA146D4", VA = "0xA146D4")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x616264", Offset = "0x616264")]
	private bool _003CInitRigidbodies_003Eb__14_3(CharacterJoint rb)
	{
		return default(bool);
	}
}
