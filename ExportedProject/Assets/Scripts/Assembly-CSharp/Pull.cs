using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000302")]
public class Pull : MonoBehaviour
{
	[Token(Token = "0x400109D")]
	[FieldOffset(Offset = "0x18")]
	public GameObject PulledGO;

	[Token(Token = "0x400109E")]
	[FieldOffset(Offset = "0x20")]
	public GameObject TargetGO;

	[Token(Token = "0x400109F")]
	[FieldOffset(Offset = "0x28")]
	public bool StopPullingOnTargetReached;

	[Token(Token = "0x40010A0")]
	[FieldOffset(Offset = "0x2C")]
	[SerializeField]
	private float _pullForce;

	[Token(Token = "0x40010A1")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private float _upwardsMultiplier;

	[Token(Token = "0x40010A2")]
	[FieldOffset(Offset = "0x34")]
	[SerializeField]
	private float _pullDuration;

	[Token(Token = "0x40010A3")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private float _targetReachedDistance;

	[Token(Token = "0x40010A4")]
	[FieldOffset(Offset = "0x40")]
	private readonly GameTimer _pullTimer;

	[Token(Token = "0x600126F")]
	[Address(RVA = "0xB3B8EC", Offset = "0xB3B8EC", VA = "0xB3B8EC")]
	protected void Start()
	{
	}

	[Token(Token = "0x6001270")]
	[Address(RVA = "0xB3B918", Offset = "0xB3B918", VA = "0xB3B918")]
	protected void FixedUpdate()
	{
	}

	[Token(Token = "0x6001271")]
	[Address(RVA = "0xB3BB88", Offset = "0xB3BB88", VA = "0xB3BB88")]
	public Pull()
	{
	}
}
