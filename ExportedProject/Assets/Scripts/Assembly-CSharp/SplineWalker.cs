using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20004F3")]
public class SplineWalker : MonoBehaviour
{
	[Token(Token = "0x20004F4")]
	public enum SplineWalkerMode
	{
		[Token(Token = "0x4001A81")]
		Once = 0,
		[Token(Token = "0x4001A82")]
		Loop = 1,
		[Token(Token = "0x4001A83")]
		PingPong = 2
	}

	[Token(Token = "0x4001A79")]
	[FieldOffset(Offset = "0x18")]
	public BezierSpline Spline;

	[Token(Token = "0x4001A7A")]
	[FieldOffset(Offset = "0x20")]
	public float Duration;

	[Token(Token = "0x4001A7B")]
	[FieldOffset(Offset = "0x24")]
	public bool LookForward;

	[Token(Token = "0x4001A7C")]
	[FieldOffset(Offset = "0x28")]
	public SplineWalkerMode Mode;

	[Token(Token = "0x4001A7D")]
	[FieldOffset(Offset = "0x2C")]
	private bool _goingForward;

	[Token(Token = "0x4001A7E")]
	[FieldOffset(Offset = "0x30")]
	private Transform _transform;

	[Token(Token = "0x4001A7F")]
	[FieldOffset(Offset = "0x38")]
	private ContinuousTimer _timer;

	[Token(Token = "0x170004B9")]
	public float Progress
	{
		[Token(Token = "0x6001E80")]
		[Address(RVA = "0xD2495C", Offset = "0xD2495C", VA = "0xD2495C")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x6001E81")]
	[Address(RVA = "0xD24978", Offset = "0xD24978", VA = "0xD24978")]
	public void SetUp(BezierSpline spline, float duration, bool lookForward, SplineWalkerMode mode)
	{
	}

	[Token(Token = "0x6001E82")]
	[Address(RVA = "0xD24A40", Offset = "0xD24A40", VA = "0xD24A40")]
	private void Update()
	{
	}

	[Token(Token = "0x6001E83")]
	[Address(RVA = "0xD24B54", Offset = "0xD24B54", VA = "0xD24B54")]
	public SplineWalker()
	{
	}
}
