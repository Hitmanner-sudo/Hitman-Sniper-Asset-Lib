using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200085D")]
public class GestureSystem : MonoBehaviour, InputsManager.IInputHandler
{
	[Token(Token = "0x200085E")]
	public delegate void TapHandler(FingerInput.FingerID finger, Vector2 pos, bool createdFromBrokenMoreFingerGesture);

	[Token(Token = "0x200085F")]
	public delegate void LongTapHandler(FingerInput.FingerID finger, Vector2 pos, float tapDuration, bool createdFromBrokenMoreFingerGesture);

	[Token(Token = "0x2000860")]
	public delegate void DragRawHandler(FingerInput.FingerID finger, Vector2 dragRaw);

	[Token(Token = "0x2000861")]
	public delegate void DragHandler(FingerInput.FingerID finger, Vector2 drag);

	[Token(Token = "0x2000862")]
	public delegate void DragExtraInfoHandler(FingerInput.FingerID finger, float drawSpeed, float dragSpeedMultiplier);

	[Token(Token = "0x2000863")]
	public delegate void PinchRawHandler(FingerInput.FingerID finger, float delta, float dist, Vector2 dir);

	[Token(Token = "0x2000864")]
	public delegate void PinchHandler(FingerInput.FingerID finger, float delta, float dist, Vector2 dir);

	[Token(Token = "0x2000865")]
	public delegate void PinchStartHandler(FingerInput.FingerID finger, float dist);

	[Token(Token = "0x2000866")]
	public delegate void PinchStopHandler(FingerInput.FingerID finger, float dist);

	[Token(Token = "0x4002F19")]
	[FieldOffset(Offset = "0x18")]
	private TapHandler _tapHandlers;

	[Token(Token = "0x4002F1A")]
	[FieldOffset(Offset = "0x20")]
	private LongTapHandler _longTapHandlers;

	[Token(Token = "0x4002F1B")]
	[FieldOffset(Offset = "0x28")]
	private DragRawHandler _dragRawHandlers;

	[Token(Token = "0x4002F1C")]
	[FieldOffset(Offset = "0x30")]
	private DragHandler _dragHandlers;

	[Token(Token = "0x4002F1D")]
	[FieldOffset(Offset = "0x38")]
	private DragExtraInfoHandler _dragExtraInfoHandlers;

	[Token(Token = "0x4002F1E")]
	[FieldOffset(Offset = "0x40")]
	private PinchRawHandler _pinchRawHandlers;

	[Token(Token = "0x4002F1F")]
	[FieldOffset(Offset = "0x48")]
	private PinchHandler _pinchHandlers;

	[Token(Token = "0x4002F20")]
	[FieldOffset(Offset = "0x50")]
	private PinchStartHandler _pinchStartHandlers;

	[Token(Token = "0x4002F21")]
	[FieldOffset(Offset = "0x58")]
	private PinchStopHandler _pinchStopHandlers;

	[NonSerialized]
	[Token(Token = "0x4002F22")]
	[FieldOffset(Offset = "0x60")]
	public bool CanTap;

	[NonSerialized]
	[Token(Token = "0x4002F23")]
	[FieldOffset(Offset = "0x61")]
	public bool CanDrag;

	[NonSerialized]
	[Token(Token = "0x4002F24")]
	[FieldOffset(Offset = "0x62")]
	public bool CanPinch;

	[NonSerialized]
	[Token(Token = "0x4002F25")]
	[FieldOffset(Offset = "0x68")]
	public GestureConfig DefaultConfig;

	[Token(Token = "0x4002F26")]
	[FieldOffset(Offset = "0x70")]
	private List<Gesture> _gestures;

	[Token(Token = "0x4002F27")]
	[FieldOffset(Offset = "0x78")]
	private List<Touch> _touches;

	[Token(Token = "0x4002F28")]
	[FieldOffset(Offset = "0x80")]
	private FingerInput _activeFingers;

	[Token(Token = "0x4002F29")]
	[FieldOffset(Offset = "0x88")]
	private float _timeSinceLastTouch;

	[Token(Token = "0x170006FB")]
	public int Priority
	{
		[Token(Token = "0x60036BF")]
		[Address(RVA = "0xDA004C", Offset = "0xDA004C", VA = "0xDA004C", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170006FC")]
	public bool HasTouch
	{
		[Token(Token = "0x60036C9")]
		[Address(RVA = "0xDA09E0", Offset = "0xDA09E0", VA = "0xDA09E0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170006FD")]
	public float TimeSinceLastTouch
	{
		[Token(Token = "0x60036CA")]
		[Address(RVA = "0xDA0CEC", Offset = "0xDA0CEC", VA = "0xDA0CEC")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x60036A4")]
	[Address(RVA = "0xD9F66C", Offset = "0xD9F66C", VA = "0xD9F66C")]
	public void RegisterTapHandler(TapHandler handler)
	{
	}

	[Token(Token = "0x60036A5")]
	[Address(RVA = "0xD9F6E8", Offset = "0xD9F6E8", VA = "0xD9F6E8")]
	public void UnregisterTapHandler(TapHandler handler)
	{
	}

	[Token(Token = "0x60036A6")]
	[Address(RVA = "0xD9F764", Offset = "0xD9F764", VA = "0xD9F764")]
	public void RegisterLongTapHandler(LongTapHandler handler)
	{
	}

	[Token(Token = "0x60036A7")]
	[Address(RVA = "0xD9F7E0", Offset = "0xD9F7E0", VA = "0xD9F7E0")]
	public void UnregisterLongTapHandler(LongTapHandler handler)
	{
	}

	[Token(Token = "0x60036A8")]
	[Address(RVA = "0xD9F85C", Offset = "0xD9F85C", VA = "0xD9F85C")]
	public void RegisterDragRawHandler(DragRawHandler handler)
	{
	}

	[Token(Token = "0x60036A9")]
	[Address(RVA = "0xD9F8D8", Offset = "0xD9F8D8", VA = "0xD9F8D8")]
	public void UnregisterDragRawHandler(DragRawHandler handler)
	{
	}

	[Token(Token = "0x60036AA")]
	[Address(RVA = "0xD9F954", Offset = "0xD9F954", VA = "0xD9F954")]
	public void RegisterDragHandler(DragHandler handler)
	{
	}

	[Token(Token = "0x60036AB")]
	[Address(RVA = "0xD9F9D0", Offset = "0xD9F9D0", VA = "0xD9F9D0")]
	public void UnregisterDragHandler(DragHandler handler)
	{
	}

	[Token(Token = "0x60036AC")]
	[Address(RVA = "0xD9FA4C", Offset = "0xD9FA4C", VA = "0xD9FA4C")]
	public void RegisterDragExtraInfoHandler(DragExtraInfoHandler handler)
	{
	}

	[Token(Token = "0x60036AD")]
	[Address(RVA = "0xD9FAC8", Offset = "0xD9FAC8", VA = "0xD9FAC8")]
	public void UnregisterDragExtraInfoHandler(DragExtraInfoHandler handler)
	{
	}

	[Token(Token = "0x60036AE")]
	[Address(RVA = "0xD9FB44", Offset = "0xD9FB44", VA = "0xD9FB44")]
	public void RegisterPinchRawHandler(PinchRawHandler handler)
	{
	}

	[Token(Token = "0x60036AF")]
	[Address(RVA = "0xD9FBC0", Offset = "0xD9FBC0", VA = "0xD9FBC0")]
	public void UnregisterPinchRawHandler(PinchRawHandler handler)
	{
	}

	[Token(Token = "0x60036B0")]
	[Address(RVA = "0xD9FC3C", Offset = "0xD9FC3C", VA = "0xD9FC3C")]
	public void RegisterPinchHandler(PinchHandler handler)
	{
	}

	[Token(Token = "0x60036B1")]
	[Address(RVA = "0xD9FCB8", Offset = "0xD9FCB8", VA = "0xD9FCB8")]
	public void UnregisterPinchHandler(PinchHandler handler)
	{
	}

	[Token(Token = "0x60036B2")]
	[Address(RVA = "0xD9FD34", Offset = "0xD9FD34", VA = "0xD9FD34")]
	public void RegisterPinchStartHandler(PinchStartHandler handler)
	{
	}

	[Token(Token = "0x60036B3")]
	[Address(RVA = "0xD9FDB0", Offset = "0xD9FDB0", VA = "0xD9FDB0")]
	public void UnregisterPinchStartHandler(PinchStartHandler handler)
	{
	}

	[Token(Token = "0x60036B4")]
	[Address(RVA = "0xD9FE2C", Offset = "0xD9FE2C", VA = "0xD9FE2C")]
	public void RegisterPinchStopHandler(PinchStopHandler handler)
	{
	}

	[Token(Token = "0x60036B5")]
	[Address(RVA = "0xD9FEA8", Offset = "0xD9FEA8", VA = "0xD9FEA8")]
	public void UnregisterPinchStopHandler(PinchStopHandler handler)
	{
	}

	[Token(Token = "0x60036B6")]
	[Address(RVA = "0xD9FF24", Offset = "0xD9FF24", VA = "0xD9FF24")]
	public void OnGestureTap(FingerInput.FingerID finger, Vector2 pos, bool createdFromBrokenMoreFingerGesture)
	{
	}

	[Token(Token = "0x60036B7")]
	[Address(RVA = "0xD9FF48", Offset = "0xD9FF48", VA = "0xD9FF48")]
	public void OnGestureLongTap(FingerInput.FingerID finger, Vector2 pos, float duration, bool createdFromBrokenMoreFingerGesture)
	{
	}

	[Token(Token = "0x60036B8")]
	[Address(RVA = "0xD9FF6C", Offset = "0xD9FF6C", VA = "0xD9FF6C")]
	public void OnGestureDragRaw(FingerInput.FingerID finger, Vector2 dragRaw)
	{
	}

	[Token(Token = "0x60036B9")]
	[Address(RVA = "0xD9FF8C", Offset = "0xD9FF8C", VA = "0xD9FF8C")]
	public void OnGestureDrag(FingerInput.FingerID finger, Vector2 drag)
	{
	}

	[Token(Token = "0x60036BA")]
	[Address(RVA = "0xD9FFAC", Offset = "0xD9FFAC", VA = "0xD9FFAC")]
	public void OnGestureDragExtraInfo(FingerInput.FingerID finger, float dragSpeed, float dragSpeedMultiplier)
	{
	}

	[Token(Token = "0x60036BB")]
	[Address(RVA = "0xD9FFCC", Offset = "0xD9FFCC", VA = "0xD9FFCC")]
	public void OnGesturePinchRaw(FingerInput.FingerID finger, float delta, float dist, Vector2 dir)
	{
	}

	[Token(Token = "0x60036BC")]
	[Address(RVA = "0xD9FFEC", Offset = "0xD9FFEC", VA = "0xD9FFEC")]
	public void OnGesturePinch(FingerInput.FingerID finger, float delta, float dist, Vector2 dir)
	{
	}

	[Token(Token = "0x60036BD")]
	[Address(RVA = "0xDA000C", Offset = "0xDA000C", VA = "0xDA000C")]
	public void OnGestureStartPinch(FingerInput.FingerID finger, float dist)
	{
	}

	[Token(Token = "0x60036BE")]
	[Address(RVA = "0xDA002C", Offset = "0xDA002C", VA = "0xDA002C")]
	public void OnGestureStopPinch(FingerInput.FingerID finger, float dist)
	{
	}

	[Token(Token = "0x60036C0")]
	[Address(RVA = "0xDA0054", Offset = "0xDA0054", VA = "0xDA0054", Slot = "5")]
	private void InputsManager_002EIInputHandler_002EHandleInputs(List<int> validTouchIDs)
	{
	}

	[Token(Token = "0x60036C1")]
	[Address(RVA = "0xDA0150", Offset = "0xDA0150", VA = "0xDA0150")]
	private void BuildActiveTouchesList(List<int> validTouchIDs)
	{
	}

	[Token(Token = "0x60036C2")]
	[Address(RVA = "0xDA02BC", Offset = "0xDA02BC", VA = "0xDA02BC")]
	private void BuildInactiveFingersMask()
	{
	}

	[Token(Token = "0x60036C3")]
	[Address(RVA = "0xDA03C0", Offset = "0xDA03C0", VA = "0xDA03C0")]
	private void StopInactiveGestures()
	{
	}

	[Token(Token = "0x60036C4")]
	[Address(RVA = "0xDA0678", Offset = "0xDA0678", VA = "0xDA0678")]
	private void CreateNewGesture()
	{
	}

	[Token(Token = "0x60036C5")]
	[Address(RVA = "0xDA0810", Offset = "0xDA0810", VA = "0xDA0810")]
	private void CombineTwoFingerGestures()
	{
	}

	[Token(Token = "0x60036C6")]
	[Address(RVA = "0xDA0938", Offset = "0xDA0938", VA = "0xDA0938")]
	private void UpdateGestures()
	{
	}

	[Token(Token = "0x60036C7")]
	[Address(RVA = "0xDA0AD8", Offset = "0xDA0AD8", VA = "0xDA0AD8")]
	private void CreateOneFingerGesture(FingerInput.FingerID finger, float startTime = -1f, bool createdFromBrokenMoreFingerGesture = false)
	{
	}

	[Token(Token = "0x60036C8")]
	[Address(RVA = "0xDA0BB8", Offset = "0xDA0BB8", VA = "0xDA0BB8")]
	private void CreateTwoFingersGesture(OneFingerGesture fingerOne, OneFingerGesture fingerTwo)
	{
	}

	[Token(Token = "0x60036CB")]
	[Address(RVA = "0xDA0DB8", Offset = "0xDA0DB8", VA = "0xDA0DB8")]
	public GestureSystem()
	{
	}
}
