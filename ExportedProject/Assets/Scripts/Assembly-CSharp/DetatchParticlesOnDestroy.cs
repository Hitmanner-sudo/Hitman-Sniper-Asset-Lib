using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20002F1")]
public class DetatchParticlesOnDestroy : MonoBehaviour
{
	[Token(Token = "0x400102A")]
	[FieldOffset(Offset = "0x18")]
	public ParticleSystem Steam;

	[Token(Token = "0x400102B")]
	[FieldOffset(Offset = "0x20")]
	private Health _HealthCached;

	[Token(Token = "0x6001214")]
	[Address(RVA = "0xC13968", Offset = "0xC13968", VA = "0xC13968")]
	private void Start()
	{
	}

	[Token(Token = "0x6001215")]
	[Address(RVA = "0xC13A84", Offset = "0xC13A84", VA = "0xC13A84")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6001216")]
	[Address(RVA = "0xC13BB8", Offset = "0xC13BB8", VA = "0xC13BB8")]
	private void OnTakeDamage(object sender, Health.TakeDamageEventArgs args)
	{
	}

	[Token(Token = "0x6001217")]
	[Address(RVA = "0xC13C34", Offset = "0xC13C34", VA = "0xC13C34")]
	public DetatchParticlesOnDestroy()
	{
	}
}
