using Il2CppDummyDll;
using Technology;
using UnityEngine;

[Token(Token = "0x20000B2")]
public class AudioDilator : GameMonoBehaviour
{
	[Token(Token = "0x4000436")]
	[FieldOffset(Offset = "0x48")]
	public float Pitch;

	[Token(Token = "0x4000437")]
	[FieldOffset(Offset = "0x4C")]
	public float Dampening;

	[Token(Token = "0x4000438")]
	[FieldOffset(Offset = "0x50")]
	public float Frequency;

	[Token(Token = "0x4000439")]
	[FieldOffset(Offset = "0x54")]
	public float Resonance;

	[Token(Token = "0x400043A")]
	[FieldOffset(Offset = "0x58")]
	private float _oldPitch;

	[Token(Token = "0x400043B")]
	[FieldOffset(Offset = "0x60")]
	private AudioLowPassFilter _lowPass;

	[Token(Token = "0x400043C")]
	[FieldOffset(Offset = "0x68")]
	private AudioSource _audioSource;

	[Token(Token = "0x400043D")]
	[FieldOffset(Offset = "0x70")]
	private PlayerController _player;

	[Token(Token = "0x6000573")]
	[Address(RVA = "0xC08BC8", Offset = "0xC08BC8", VA = "0xC08BC8", Slot = "9")]
	protected override void Start()
	{
	}

	[Token(Token = "0x6000574")]
	[Address(RVA = "0xC08D5C", Offset = "0xC08D5C", VA = "0xC08D5C", Slot = "5")]
	protected override void GameUpdate()
	{
	}

	[Token(Token = "0x6000575")]
	[Address(RVA = "0xC0903C", Offset = "0xC0903C", VA = "0xC0903C")]
	public AudioDilator()
	{
	}
}
