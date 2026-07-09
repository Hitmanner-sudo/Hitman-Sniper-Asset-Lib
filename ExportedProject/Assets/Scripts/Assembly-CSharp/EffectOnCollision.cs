using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200000D")]
public class EffectOnCollision : MonoBehaviour
{
	[Token(Token = "0x4000013")]
	[FieldOffset(Offset = "0x18")]
	public ParticleSystem ParticleEffect;

	[Token(Token = "0x6000033")]
	[Address(RVA = "0xE0BF7C", Offset = "0xE0BF7C", VA = "0xE0BF7C")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x6000034")]
	[Address(RVA = "0xE0C1D8", Offset = "0xE0C1D8", VA = "0xE0C1D8")]
	private void OnCollisionEnter(Collision collision)
	{
	}

	[Token(Token = "0x6000035")]
	[Address(RVA = "0xE0C074", Offset = "0xE0C074", VA = "0xE0C074")]
	private void SpawnEffect(Vector3 position, Quaternion rotation, Rigidbody colRigidbody)
	{
	}

	[Token(Token = "0x6000036")]
	[Address(RVA = "0xE0C2B8", Offset = "0xE0C2B8", VA = "0xE0C2B8")]
	public EffectOnCollision()
	{
	}
}
