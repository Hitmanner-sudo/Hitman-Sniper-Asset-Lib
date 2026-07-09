using Il2CppDummyDll;
using Technology;
using UnityEngine;

[Token(Token = "0x20007C5")]
public class DecoyBulletFirecracker : MonoBehaviour
{
	[Token(Token = "0x4002B95")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	public float MinDelayBetweenExplode;

	[Token(Token = "0x4002B96")]
	[FieldOffset(Offset = "0x1C")]
	[SerializeField]
	public float MaxDelayBetweenExplode;

	[Token(Token = "0x4002B97")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	public SoundContainer Sound;

	[Token(Token = "0x4002B98")]
	[FieldOffset(Offset = "0x28")]
	private ParticleSystem[] _particleSystems;

	[Token(Token = "0x4002B99")]
	[FieldOffset(Offset = "0x30")]
	private Timer _timer;

	[Token(Token = "0x600331E")]
	[Address(RVA = "0xAEC15C", Offset = "0xAEC15C", VA = "0xAEC15C")]
	private void Awake()
	{
	}

	[Token(Token = "0x600331F")]
	[Address(RVA = "0xAEC208", Offset = "0xAEC208", VA = "0xAEC208")]
	private void Update()
	{
	}

	[Token(Token = "0x6003320")]
	[Address(RVA = "0xAEC1FC", Offset = "0xAEC1FC", VA = "0xAEC1FC")]
	private float GetRandomDelay()
	{
		return default(float);
	}

	[Token(Token = "0x6003321")]
	[Address(RVA = "0xAEC274", Offset = "0xAEC274", VA = "0xAEC274")]
	private void PlayParticleSystems()
	{
	}

	[Token(Token = "0x6003322")]
	[Address(RVA = "0xAEC2E0", Offset = "0xAEC2E0", VA = "0xAEC2E0")]
	private void PlaySoundEffect()
	{
	}

	[Token(Token = "0x6003323")]
	[Address(RVA = "0xAEC3F0", Offset = "0xAEC3F0", VA = "0xAEC3F0")]
	public DecoyBulletFirecracker()
	{
	}
}
