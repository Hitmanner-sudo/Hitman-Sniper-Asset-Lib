using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20001FC")]
public class GestureConfig : BaseConfig<GestureConfig>
{
	[Token(Token = "0x4000B79")]
	[FieldOffset(Offset = "0x30")]
	[Setting]
	public float TapTime;

	[Token(Token = "0x4000B7A")]
	[FieldOffset(Offset = "0x34")]
	[Setting]
	public float MaxTapDistance;

	[Token(Token = "0x4000B7B")]
	[FieldOffset(Offset = "0x38")]
	[Setting]
	public float HorizontalSpeed;

	[Token(Token = "0x4000B7C")]
	[FieldOffset(Offset = "0x3C")]
	[Setting]
	public float VerticalSpeed;

	[Token(Token = "0x4000B7D")]
	[FieldOffset(Offset = "0x40")]
	[Setting]
	public Vector2 SpeedMultiplier;

	[Token(Token = "0x4000B7E")]
	[FieldOffset(Offset = "0x48")]
	[Setting]
	public Vector2 SpeedMultiplierRange;

	[Token(Token = "0x4000B7F")]
	[FieldOffset(Offset = "0x50")]
	[Setting]
	public float MovementDamping;

	[Token(Token = "0x4000B80")]
	[FieldOffset(Offset = "0x54")]
	[Setting]
	public float StationnaryDamping;

	[Token(Token = "0x4000B81")]
	[FieldOffset(Offset = "0x58")]
	[Setting]
	public float StopDamping;

	[Token(Token = "0x4000B82")]
	[FieldOffset(Offset = "0x5C")]
	[Setting]
	public float PinchTimeWindow;

	[Token(Token = "0x4000B83")]
	[FieldOffset(Offset = "0x60")]
	[Setting]
	public float PinchSpeed;

	[Token(Token = "0x4000B84")]
	[FieldOffset(Offset = "0x64")]
	[Setting]
	public float PinchDamping;

	[Token(Token = "0x4000B85")]
	[FieldOffset(Offset = "0x68")]
	[Setting]
	public float PinchScopeDelay;

	[Token(Token = "0x4000B86")]
	[FieldOffset(Offset = "0x6C")]
	[Setting]
	public float PinchScopeMovement;

	[Token(Token = "0x4000B87")]
	[FieldOffset(Offset = "0x70")]
	[Setting]
	public float PinchQuickZoomDuration;

	[Token(Token = "0x4000B88")]
	[FieldOffset(Offset = "0x74")]
	[Setting]
	public float PinchQuickZoomSpeed;

	[Token(Token = "0x4000B89")]
	[FieldOffset(Offset = "0x78")]
	[Setting]
	public float PinchQuickZoomWindow;

	[Token(Token = "0x4000B8A")]
	[FieldOffset(Offset = "0x7C")]
	[Setting]
	public float PinchMaxZoomSpeed;

	[Token(Token = "0x4000B8B")]
	[FieldOffset(Offset = "0x80")]
	[Setting]
	public float PinchQuickZoomStaticZoomInDeltaRatio;

	[Token(Token = "0x4000B8C")]
	[FieldOffset(Offset = "0x84")]
	[Setting]
	public float PinchQuickZoomStaticZoomOutDeltaRatio;

	[Token(Token = "0x4000B8D")]
	[FieldOffset(Offset = "0x88")]
	[Setting]
	public bool PinchToExitScope;

	[Token(Token = "0x4000B8E")]
	[FieldOffset(Offset = "0x89")]
	[Setting]
	public bool UseUnityTouchFilter;

	[Token(Token = "0x6000C2C")]
	[Address(RVA = "0xD9F5A0", Offset = "0xD9F5A0", VA = "0xD9F5A0")]
	public GestureConfig()
	{
	}
}
