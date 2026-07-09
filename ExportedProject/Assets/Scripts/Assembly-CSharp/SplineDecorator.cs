using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20004F2")]
public class SplineDecorator : MonoBehaviour
{
	[Token(Token = "0x4001A75")]
	[FieldOffset(Offset = "0x18")]
	public BezierSpline Spline;

	[Token(Token = "0x4001A76")]
	[FieldOffset(Offset = "0x20")]
	public int Frequency;

	[Token(Token = "0x4001A77")]
	[FieldOffset(Offset = "0x24")]
	public bool LookForward;

	[Token(Token = "0x4001A78")]
	[FieldOffset(Offset = "0x28")]
	public Transform[] Items;

	[Token(Token = "0x6001E7E")]
	[Address(RVA = "0xA75CAC", Offset = "0xA75CAC", VA = "0xA75CAC")]
	private void Awake()
	{
	}

	[Token(Token = "0x6001E7F")]
	[Address(RVA = "0xA75EDC", Offset = "0xA75EDC", VA = "0xA75EDC")]
	public SplineDecorator()
	{
	}
}
