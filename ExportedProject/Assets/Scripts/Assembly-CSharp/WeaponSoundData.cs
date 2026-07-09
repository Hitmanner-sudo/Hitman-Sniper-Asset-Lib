using Il2CppDummyDll;
using Technology;
using UnityEngine;

[Token(Token = "0x20003AC")]
public class WeaponSoundData : ScriptableObject
{
	[Token(Token = "0x40014E9")]
	[FieldOffset(Offset = "0x18")]
	public SoundContainer Shoot;

	[Token(Token = "0x40014EA")]
	[FieldOffset(Offset = "0x20")]
	public SoundContainer BoltAction;

	[Token(Token = "0x40014EB")]
	[FieldOffset(Offset = "0x28")]
	public SoundContainer BulletShellsRocks;

	[Token(Token = "0x40014EC")]
	[FieldOffset(Offset = "0x30")]
	public SoundContainer BulletShellsConcrete;

	[Token(Token = "0x40014ED")]
	[FieldOffset(Offset = "0x38")]
	public SoundContainer Reload1;

	[Token(Token = "0x40014EE")]
	[FieldOffset(Offset = "0x40")]
	public SoundContainer Reload2;

	[Token(Token = "0x40014EF")]
	[FieldOffset(Offset = "0x48")]
	public SoundContainer Reload3Success;

	[Token(Token = "0x40014F0")]
	[FieldOffset(Offset = "0x50")]
	public SoundContainer Reload3Fail;

	[Token(Token = "0x40014F1")]
	[FieldOffset(Offset = "0x58")]
	public SoundContainer Reload4Success;

	[Token(Token = "0x40014F2")]
	[FieldOffset(Offset = "0x60")]
	public SoundContainer Reload4Fail;

	[Token(Token = "0x40014F3")]
	[FieldOffset(Offset = "0x68")]
	public SoundContainer ZoomScopeSound;

	[Token(Token = "0x40014F4")]
	[FieldOffset(Offset = "0x70")]
	[Attribute(Name = "RangeAttribute", RVA = "0x5B4CE4", Offset = "0x5B4CE4")]
	public float ZoomScopeSoundInterval;

	[Token(Token = "0x40014F5")]
	[FieldOffset(Offset = "0x78")]
	public SoundContainer EnterScopeSound;

	[Token(Token = "0x40014F6")]
	[FieldOffset(Offset = "0x80")]
	public SoundContainer ExitScopeSound;

	[Token(Token = "0x40014F7")]
	[FieldOffset(Offset = "0x88")]
	public SoundContainer SwipeSound;

	[Token(Token = "0x40014F8")]
	[FieldOffset(Offset = "0x90")]
	public float SwipeSoundMovementThreshold;

	[Token(Token = "0x40014F9")]
	[FieldOffset(Offset = "0x94")]
	public float SwipeSoundDelay;

	[Token(Token = "0x60016CE")]
	[Address(RVA = "0x98C4D4", Offset = "0x98C4D4", VA = "0x98C4D4")]
	public WeaponSoundData()
	{
	}
}
