using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200086D")]
public class TwoFingersGesture : FingerGesture
{
	[Token(Token = "0x4002F49")]
	[FieldOffset(Offset = "0x30")]
	private float _rawPinchDistance;

	[Token(Token = "0x4002F4A")]
	[FieldOffset(Offset = "0x34")]
	private float _rawPinchDelta;

	[Token(Token = "0x4002F4B")]
	[FieldOffset(Offset = "0x38")]
	private float _pinchDistance;

	[Token(Token = "0x4002F4C")]
	[FieldOffset(Offset = "0x3C")]
	private float _pinchDelta;

	[Token(Token = "0x4002F4D")]
	[FieldOffset(Offset = "0x40")]
	private float _lastDelta;

	[Token(Token = "0x4002F4E")]
	[FieldOffset(Offset = "0x44")]
	private Vector2 _pinchDir;

	[Token(Token = "0x4002F4F")]
	[FieldOffset(Offset = "0x4C")]
	private FingerInput.FingerID _fingerOne;

	[Token(Token = "0x4002F50")]
	[FieldOffset(Offset = "0x50")]
	private FingerInput.FingerID _fingerTwo;

	[Token(Token = "0x4002F51")]
	[FieldOffset(Offset = "0x54")]
	private Vector2 _lastFingerOnePos;

	[Token(Token = "0x4002F52")]
	[FieldOffset(Offset = "0x5C")]
	private Vector2 _lastFingerTwoPos;

	[Token(Token = "0x4002F53")]
	[FieldOffset(Offset = "0x64")]
	private float _velocity;

	[Token(Token = "0x4002F54")]
	[FieldOffset(Offset = "0x68")]
	private bool _hasTouch;

	[Token(Token = "0x1700070A")]
	private float Speed
	{
		[Token(Token = "0x6003721")]
		[Address(RVA = "0x157528C", Offset = "0x157528C", VA = "0x157528C")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x1700070B")]
	private float Damping
	{
		[Token(Token = "0x6003722")]
		[Address(RVA = "0x15752B0", Offset = "0x15752B0", VA = "0x15752B0")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x1700070C")]
	private float PinchMaxZoomSpeed
	{
		[Token(Token = "0x6003723")]
		[Address(RVA = "0x15752D4", Offset = "0x15752D4", VA = "0x15752D4")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x1700070D")]
	public override bool HasTouch
	{
		[Token(Token = "0x6003729")]
		[Address(RVA = "0x1575B54", Offset = "0x1575B54", VA = "0x1575B54", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6003724")]
	[Address(RVA = "0x15752F8", Offset = "0x15752F8", VA = "0x15752F8")]
	public TwoFingersGesture(GestureSystem owner)
	{
	}

	[Token(Token = "0x6003725")]
	[Address(RVA = "0x1575348", Offset = "0x1575348", VA = "0x1575348", Slot = "9")]
	public override void Execute(List<Touch> touches)
	{
	}

	[Token(Token = "0x6003726")]
	[Address(RVA = "0x1575B04", Offset = "0x1575B04", VA = "0x1575B04", Slot = "10")]
	public override void Stop()
	{
	}

	[Token(Token = "0x6003727")]
	[Address(RVA = "0x1575384", Offset = "0x1575384", VA = "0x1575384")]
	private void UpdateTouchControl(List<Touch> touches)
	{
	}

	[Token(Token = "0x6003728")]
	[Address(RVA = "0x1575774", Offset = "0x1575774", VA = "0x1575774")]
	private void PostProcessPinch()
	{
	}
}
