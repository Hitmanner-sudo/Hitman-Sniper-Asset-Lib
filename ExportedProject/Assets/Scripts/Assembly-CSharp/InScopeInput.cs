using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20002E9")]
public class InScopeInput : InputMapping
{
	[Token(Token = "0x400100C")]
	[FieldOffset(Offset = "0x20")]
	public GestureConfig Config;

	[Token(Token = "0x400100D")]
	[FieldOffset(Offset = "0x28")]
	private PlayerController _player;

	[Token(Token = "0x400100E")]
	[FieldOffset(Offset = "0x30")]
	private float _fadeOutZoomSpeed;

	[Token(Token = "0x400100F")]
	[FieldOffset(Offset = "0x34")]
	private float _lastZoomDelta;

	[Token(Token = "0x4001010")]
	[FieldOffset(Offset = "0x38")]
	private float _zoomStartTime;

	[Token(Token = "0x4001011")]
	[FieldOffset(Offset = "0x3C")]
	private float _deltaVelocity;

	[Token(Token = "0x4001012")]
	[FieldOffset(Offset = "0x40")]
	private float _maxZoomDelta;

	[Token(Token = "0x4001013")]
	[FieldOffset(Offset = "0x44")]
	private bool _fadeOutZoom;

	[Token(Token = "0x4001014")]
	[FieldOffset(Offset = "0x48")]
	private float _pinchLastTime;

	[Token(Token = "0x4001015")]
	[FieldOffset(Offset = "0x4C")]
	private float _cummulatedPinch;

	[Token(Token = "0x60011E0")]
	[Address(RVA = "0xB090C0", Offset = "0xB090C0", VA = "0xB090C0", Slot = "4")]
	public override void Activate(GameObject owner)
	{
	}

	[Token(Token = "0x60011E1")]
	[Address(RVA = "0xB09164", Offset = "0xB09164", VA = "0xB09164", Slot = "5")]
	public override void Deactivate()
	{
	}

	[Token(Token = "0x60011E2")]
	[Address(RVA = "0xB091A4", Offset = "0xB091A4", VA = "0xB091A4", Slot = "6")]
	public override void RegisterGestureDelegates()
	{
	}

	[Token(Token = "0x60011E3")]
	[Address(RVA = "0xB09470", Offset = "0xB09470", VA = "0xB09470", Slot = "7")]
	public override void UnregisterGestureDelegates()
	{
	}

	[Token(Token = "0x60011E4")]
	[Address(RVA = "0xB0973C", Offset = "0xB0973C", VA = "0xB0973C")]
	private void TapToUnscope(FingerInput.FingerID finger, Vector2 pos, bool createdFromBrokenMoreFingerGesture)
	{
	}

	[Token(Token = "0x60011E5")]
	[Address(RVA = "0xB09864", Offset = "0xB09864", VA = "0xB09864")]
	private bool IsInsideScope(Vector2 touch)
	{
		return default(bool);
	}

	[Token(Token = "0x60011E6")]
	[Address(RVA = "0xB098D4", Offset = "0xB098D4", VA = "0xB098D4")]
	private void UpdateAiming(FingerInput.FingerID finger, Vector2 drag)
	{
	}

	[Token(Token = "0x60011E7")]
	[Address(RVA = "0xB09900", Offset = "0xB09900", VA = "0xB09900")]
	private void StartZoom(FingerInput.FingerID finger, float dist)
	{
	}

	[Token(Token = "0x60011E8")]
	[Address(RVA = "0xB099D4", Offset = "0xB099D4", VA = "0xB099D4")]
	private void StopZoom(FingerInput.FingerID finger, float dist)
	{
	}

	[Token(Token = "0x60011E9")]
	[Address(RVA = "0xB09C70", Offset = "0xB09C70", VA = "0xB09C70")]
	private void UpdateZoom(FingerInput.FingerID finger, float delta, float dist, Vector2 dir)
	{
	}

	[Token(Token = "0x60011EA")]
	[Address(RVA = "0xB09E08", Offset = "0xB09E08", VA = "0xB09E08")]
	private void Update()
	{
	}

	[Token(Token = "0x60011EB")]
	[Address(RVA = "0xB0A0F8", Offset = "0xB0A0F8", VA = "0xB0A0F8")]
	private void PinchToExitScope(FingerInput.FingerID finger, float delta, float dist, Vector2 dir)
	{
	}

	[Token(Token = "0x60011EC")]
	[Address(RVA = "0xB0A2C8", Offset = "0xB0A2C8", VA = "0xB0A2C8")]
	public InScopeInput()
	{
	}
}
