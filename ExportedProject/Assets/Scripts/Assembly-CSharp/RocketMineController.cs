using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000315")]
public class RocketMineController : MonoBehaviour
{
	[Token(Token = "0x2000316")]
	private enum State
	{
		[Token(Token = "0x4001148")]
		FirstWait = 0,
		[Token(Token = "0x4001149")]
		Ignition = 1,
		[Token(Token = "0x400114A")]
		Rocket = 2,
		[Token(Token = "0x400114B")]
		SecondWait = 3,
		[Token(Token = "0x400114C")]
		Explosion = 4,
		[Token(Token = "0x400114D")]
		Done = 5
	}

	[Token(Token = "0x4001131")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	[Attribute(Name = "HeaderAttribute", RVA = "0x5B40C0", Offset = "0x5B40C0")]
	private float _waitBeforeIgnition;

	[Token(Token = "0x4001132")]
	[FieldOffset(Offset = "0x1C")]
	[SerializeField]
	private float _ignitionDuration;

	[Token(Token = "0x4001133")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Attribute(Name = "HeaderAttribute", RVA = "0x5B411C", Offset = "0x5B411C")]
	private float _rocketTotalDuration;

	[Token(Token = "0x4001134")]
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	private float _turnUpwardTorque;

	[Token(Token = "0x4001135")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private float _directionDampingTime;

	[Token(Token = "0x4001136")]
	[FieldOffset(Offset = "0x2C")]
	[SerializeField]
	[Attribute(Name = "HeaderAttribute", RVA = "0x5B4188", Offset = "0x5B4188")]
	private float _rocketFadeInDuration;

	[Token(Token = "0x4001137")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private float _rocketFullThrustDuration;

	[Token(Token = "0x4001138")]
	[FieldOffset(Offset = "0x34")]
	[SerializeField]
	private float _thrustMagnitude;

	[Token(Token = "0x4001139")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private float _magicLiftMagnitude;

	[Token(Token = "0x400113A")]
	[FieldOffset(Offset = "0x3C")]
	[SerializeField]
	[Attribute(Name = "HeaderAttribute", RVA = "0x5B4204", Offset = "0x5B4204")]
	private float _waitBeforeExplosion;

	[Token(Token = "0x400113B")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private Health _health;

	[Token(Token = "0x400113C")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private ParticleSystem _ignitionParticles;

	[Token(Token = "0x400113D")]
	[FieldOffset(Offset = "0x50")]
	private readonly Timer _timer;

	[Token(Token = "0x400113E")]
	[FieldOffset(Offset = "0x58")]
	private State _currentState;

	[Token(Token = "0x400113F")]
	[FieldOffset(Offset = "0x60")]
	private Transform _transform;

	[Token(Token = "0x4001140")]
	[FieldOffset(Offset = "0x68")]
	private Rigidbody _rigidBody;

	[Token(Token = "0x4001141")]
	[FieldOffset(Offset = "0x70")]
	private ThirdPersonCharacter _character;

	[Token(Token = "0x4001142")]
	[FieldOffset(Offset = "0x78")]
	private Vector3 _forward;

	[Token(Token = "0x4001143")]
	[FieldOffset(Offset = "0x84")]
	private Vector3 _forwardSmoothDampVelocity;

	[Token(Token = "0x4001144")]
	[FieldOffset(Offset = "0x90")]
	private float _fadeForcesFactor;

	[Token(Token = "0x4001145")]
	[FieldOffset(Offset = "0x94")]
	private float _fadeOutDuration;

	[Token(Token = "0x4001146")]
	[FieldOffset(Offset = "0x98")]
	private bool _shouldApplyForce;

	[Token(Token = "0x60012F4")]
	[Address(RVA = "0x96EA18", Offset = "0x96EA18", VA = "0x96EA18")]
	protected void Start()
	{
	}

	[Token(Token = "0x60012F5")]
	[Address(RVA = "0x96EB64", Offset = "0x96EB64", VA = "0x96EB64")]
	protected void Update()
	{
	}

	[Token(Token = "0x60012F6")]
	[Address(RVA = "0x96F0EC", Offset = "0x96F0EC", VA = "0x96F0EC")]
	protected void FixedUpdate()
	{
	}

	[Token(Token = "0x60012F7")]
	[Address(RVA = "0x96EB9C", Offset = "0x96EB9C", VA = "0x96EB9C")]
	private void UpdateFirstWait()
	{
	}

	[Token(Token = "0x60012F8")]
	[Address(RVA = "0x96EBDC", Offset = "0x96EBDC", VA = "0x96EBDC")]
	private void UpdateIgnition()
	{
	}

	[Token(Token = "0x60012F9")]
	[Address(RVA = "0x96EC2C", Offset = "0x96EC2C", VA = "0x96EC2C")]
	private void UpdateRocket()
	{
	}

	[Token(Token = "0x60012FA")]
	[Address(RVA = "0x96EF4C", Offset = "0x96EF4C", VA = "0x96EF4C")]
	private void UpdateSecondWait()
	{
	}

	[Token(Token = "0x60012FB")]
	[Address(RVA = "0x96EF98", Offset = "0x96EF98", VA = "0x96EF98")]
	private void UpdateExplosion()
	{
	}

	[Token(Token = "0x60012FC")]
	[Address(RVA = "0x96F284", Offset = "0x96F284", VA = "0x96F284")]
	private void TryGoNextState()
	{
	}

	[Token(Token = "0x60012FD")]
	[Address(RVA = "0x96F2D4", Offset = "0x96F2D4", VA = "0x96F2D4")]
	private void StartPropulsionEffects()
	{
	}

	[Token(Token = "0x60012FE")]
	[Address(RVA = "0x96F2F0", Offset = "0x96F2F0", VA = "0x96F2F0")]
	private void StopPropulsionEffects()
	{
	}

	[Token(Token = "0x60012FF")]
	[Address(RVA = "0x96F0FC", Offset = "0x96F0FC", VA = "0x96F0FC")]
	private void ApplyForce()
	{
	}

	[Token(Token = "0x6001300")]
	[Address(RVA = "0x96F360", Offset = "0x96F360", VA = "0x96F360")]
	public RocketMineController()
	{
	}
}
