using Il2CppDummyDll;
using Technology;
using UnityEngine;

[Token(Token = "0x20000B5")]
[Attribute(Name = "RequireComponent", RVA = "0x59224C", Offset = "0x59224C")]
[ExecuteInEditMode]
public class PlayParticleSound : MonoBehaviour
{
	[Token(Token = "0x4000448")]
	[FieldOffset(Offset = "0x18")]
	public SoundContainer OnBirthSound;

	[Token(Token = "0x4000449")]
	[FieldOffset(Offset = "0x20")]
	public SoundContainer OnDeathSound;

	[Token(Token = "0x400044A")]
	[FieldOffset(Offset = "0x28")]
	private int _numberOfParticles;

	[Token(Token = "0x400044B")]
	[FieldOffset(Offset = "0x30")]
	private ParticleSystem _particleSystem;

	[Token(Token = "0x6000589")]
	[Address(RVA = "0xB80348", Offset = "0xB80348", VA = "0xB80348")]
	protected void Awake()
	{
	}

	[Token(Token = "0x600058A")]
	[Address(RVA = "0xB8039C", Offset = "0xB8039C", VA = "0xB8039C")]
	protected void Update()
	{
	}

	[Token(Token = "0x600058B")]
	[Address(RVA = "0xB8044C", Offset = "0xB8044C", VA = "0xB8044C")]
	private void PlaySound(SoundContainer soundContainer)
	{
	}

	[Token(Token = "0x600058C")]
	[Address(RVA = "0xB80558", Offset = "0xB80558", VA = "0xB80558")]
	public PlayParticleSound()
	{
	}
}
