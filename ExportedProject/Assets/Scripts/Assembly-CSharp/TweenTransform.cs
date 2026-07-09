using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000076")]
[Attribute(Name = "AddComponentMenu", RVA = "0x591950", Offset = "0x591950")]
public class TweenTransform : UITweener
{
	[Token(Token = "0x400025C")]
	[FieldOffset(Offset = "0x90")]
	public Transform from;

	[Token(Token = "0x400025D")]
	[FieldOffset(Offset = "0x98")]
	public Transform to;

	[Token(Token = "0x400025E")]
	[FieldOffset(Offset = "0xA0")]
	public bool parentWhenFinished;

	[Token(Token = "0x400025F")]
	[FieldOffset(Offset = "0xA8")]
	private Transform mTrans;

	[Token(Token = "0x4000260")]
	[FieldOffset(Offset = "0xB0")]
	private Vector3 mPos;

	[Token(Token = "0x4000261")]
	[FieldOffset(Offset = "0xBC")]
	private Quaternion mRot;

	[Token(Token = "0x4000262")]
	[FieldOffset(Offset = "0xCC")]
	private Vector3 mScale;

	[Token(Token = "0x600039C")]
	[Address(RVA = "0x1573CEC", Offset = "0x1573CEC", VA = "0x1573CEC", Slot = "4")]
	protected override void OnUpdate(float factor, bool isFinished)
	{
	}

	[Token(Token = "0x600039D")]
	[Address(RVA = "0x1574080", Offset = "0x1574080", VA = "0x1574080")]
	public static TweenTransform Begin(GameObject go, float duration, Transform to)
	{
		return null;
	}

	[Token(Token = "0x600039E")]
	[Address(RVA = "0x157408C", Offset = "0x157408C", VA = "0x157408C")]
	public static TweenTransform Begin(GameObject go, float duration, Transform from, Transform to)
	{
		return null;
	}

	[Token(Token = "0x600039F")]
	[Address(RVA = "0x157413C", Offset = "0x157413C", VA = "0x157413C")]
	public TweenTransform()
	{
	}
}
