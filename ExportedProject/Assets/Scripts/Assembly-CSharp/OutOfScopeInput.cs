using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20002EC")]
public class OutOfScopeInput : InputMapping
{
	[Token(Token = "0x4001019")]
	[FieldOffset(Offset = "0x20")]
	public GestureConfig Config;

	[Token(Token = "0x400101A")]
	[FieldOffset(Offset = "0x28")]
	private PlayerController _player;

	[Token(Token = "0x400101B")]
	[FieldOffset(Offset = "0x30")]
	private float _cummulatedPinch;

	[Token(Token = "0x60011F8")]
	[Address(RVA = "0x9FF024", Offset = "0x9FF024", VA = "0x9FF024", Slot = "4")]
	public override void Activate(GameObject owner)
	{
	}

	[Token(Token = "0x60011F9")]
	[Address(RVA = "0x9FF0C8", Offset = "0x9FF0C8", VA = "0x9FF0C8", Slot = "5")]
	public override void Deactivate()
	{
	}

	[Token(Token = "0x60011FA")]
	[Address(RVA = "0x9FF110", Offset = "0x9FF110", VA = "0x9FF110", Slot = "6")]
	public override void RegisterGestureDelegates()
	{
	}

	[Token(Token = "0x60011FB")]
	[Address(RVA = "0x9FF28C", Offset = "0x9FF28C", VA = "0x9FF28C", Slot = "7")]
	public override void UnregisterGestureDelegates()
	{
	}

	[Token(Token = "0x60011FC")]
	[Address(RVA = "0x9FF408", Offset = "0x9FF408", VA = "0x9FF408")]
	private void TapToScope(FingerInput.FingerID finger, Vector2 pos, bool createdFromBrokenMoreFingerGesture)
	{
	}

	[Token(Token = "0x60011FD")]
	[Address(RVA = "0x9FF7FC", Offset = "0x9FF7FC", VA = "0x9FF7FC")]
	private void UpdateAiming(FingerInput.FingerID finger, Vector2 drag)
	{
	}

	[Token(Token = "0x60011FE")]
	[Address(RVA = "0x9FF86C", Offset = "0x9FF86C", VA = "0x9FF86C")]
	private void PinchToScope(FingerInput.FingerID finger, float delta, float dist, Vector2 dir)
	{
	}

	[Token(Token = "0x60011FF")]
	[Address(RVA = "0x9FF9C4", Offset = "0x9FF9C4", VA = "0x9FF9C4")]
	public OutOfScopeInput()
	{
	}
}
