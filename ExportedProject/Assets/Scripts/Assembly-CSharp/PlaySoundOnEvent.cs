using Il2CppDummyDll;
using Technology;
using UnityEngine;

[Token(Token = "0x20000B6")]
public class PlaySoundOnEvent : MonoBehaviour
{
	[Token(Token = "0x400044C")]
	[FieldOffset(Offset = "0x18")]
	public SoundContainer SoundOnHit;

	[Token(Token = "0x400044D")]
	[FieldOffset(Offset = "0x20")]
	public SoundContainer SoundOnDie;

	[Token(Token = "0x400044E")]
	[FieldOffset(Offset = "0x28")]
	public SoundContainer SoundOnDotDamage;

	[Token(Token = "0x400044F")]
	[FieldOffset(Offset = "0x30")]
	public ThirdPersonCharacter Character;

	[Token(Token = "0x600058D")]
	[Address(RVA = "0xB815A4", Offset = "0xB815A4", VA = "0xB815A4")]
	protected void Awake()
	{
	}

	[Token(Token = "0x600058E")]
	[Address(RVA = "0xB81664", Offset = "0xB81664", VA = "0xB81664")]
	protected void OnEnable()
	{
	}

	[Token(Token = "0x600058F")]
	[Address(RVA = "0xB81768", Offset = "0xB81768", VA = "0xB81768")]
	protected void OnDisable()
	{
	}

	[Token(Token = "0x6000590")]
	[Address(RVA = "0xB818A8", Offset = "0xB818A8", VA = "0xB818A8")]
	private void OnTakeDamage(object sender, Health.TakeDamageEventArgs args)
	{
	}

	[Token(Token = "0x6000591")]
	[Address(RVA = "0xB81AD4", Offset = "0xB81AD4", VA = "0xB81AD4")]
	public PlaySoundOnEvent()
	{
	}
}
