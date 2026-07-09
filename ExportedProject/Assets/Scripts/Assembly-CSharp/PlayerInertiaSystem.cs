using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20004D5")]
public class PlayerInertiaSystem : PlayerSystem
{
	[Token(Token = "0x40019CD")]
	[FieldOffset(Offset = "0x50")]
	private Vector3 _outOfScopePosition;

	[Token(Token = "0x40019CE")]
	[FieldOffset(Offset = "0x5C")]
	private Vector3 _outOfScopePositionVelocity;

	[Token(Token = "0x40019CF")]
	[FieldOffset(Offset = "0x68")]
	private Quaternion _outOfScopeRotation;

	[Token(Token = "0x40019D0")]
	[FieldOffset(Offset = "0x78")]
	private Vector3 _outOfScopeRotationVelocity;

	[Token(Token = "0x40019D1")]
	[FieldOffset(Offset = "0x84")]
	private Vector3 _inScopePosition;

	[Token(Token = "0x40019D2")]
	[FieldOffset(Offset = "0x90")]
	private Vector3 _inScopePositionVelocity;

	[Token(Token = "0x40019D3")]
	[FieldOffset(Offset = "0x9C")]
	private Quaternion _inScopeRotation;

	[Token(Token = "0x40019D4")]
	[FieldOffset(Offset = "0xAC")]
	private Vector3 _inScopeRotationVelocity;

	[Token(Token = "0x40019D5")]
	[FieldOffset(Offset = "0xB8")]
	private Vector3 _deltaPosition;

	[Token(Token = "0x40019D6")]
	[FieldOffset(Offset = "0xC4")]
	private Quaternion _deltaRotation;

	[Token(Token = "0x40019D7")]
	[FieldOffset(Offset = "0xD4")]
	private Vector3 _horizontalPivot;

	[Token(Token = "0x40019D8")]
	[FieldOffset(Offset = "0xE0")]
	private Vector3 _verticalPivot;

	[Token(Token = "0x40019D9")]
	[FieldOffset(Offset = "0xEC")]
	private bool _hasTreshold;

	[Token(Token = "0x6001D99")]
	[Address(RVA = "0xB897DC", Offset = "0xB897DC", VA = "0xB897DC", Slot = "14")]
	public override void Execute()
	{
	}

	[Token(Token = "0x6001D9A")]
	[Address(RVA = "0xB8A4A0", Offset = "0xB8A4A0", VA = "0xB8A4A0", Slot = "15")]
	public override void ApplyToCharacter()
	{
	}

	[Token(Token = "0x6001D9B")]
	[Address(RVA = "0xB8A574", Offset = "0xB8A574", VA = "0xB8A574")]
	public PlayerInertiaSystem()
	{
	}
}
